using Microsoft.Data.Sqlite;
using System;
using System.Security.Cryptography;
using RHControl.Data;

namespace RHControl.Services
{
    public static class UsuarioService
    {
        private const int Iteracoes = 120000;
        private const int TamanhoSalt = 16;
        private const int TamanhoHash = 32;
        private const string PrefixoHash = "PBKDF2$";

        public sealed class ResultadoLogin
        {
            public bool Sucesso { get; set; }
            public string Mensagem { get; set; } = string.Empty;
            public int Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public string Usuario { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string TipoUsuario { get; set; } = string.Empty;
            public string UltimoAcesso { get; set; } = string.Empty;
        }

        public static ResultadoLogin Autenticar(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(senha))
            {
                return new ResultadoLogin
                {
                    Sucesso = false,
                    Mensagem = "Informe o usuário e a senha."
                };
            }

            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT
                    Id,
                    Nome,
                    Usuario,
                    Senha,
                    TipoUsuario,
                    Status,
                    COALESCE(Email, ''),
                    COALESCE(UltimoAcesso, '')
                FROM Usuarios
                WHERE lower(Usuario) = lower($usuario)
                LIMIT 1;";

            command.Parameters.AddWithValue("$usuario", usuario.Trim());

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return new ResultadoLogin
                {
                    Sucesso = false,
                    Mensagem = "Usuário ou senha inválidos."
                };
            }

            int id = reader.GetInt32(0);
            string nome = reader.GetString(1);
            string usuarioBanco = reader.GetString(2);
            string senhaBanco = reader.GetString(3);
            string tipoUsuario = reader.IsDBNull(4) ? "Usuario" : reader.GetString(4);
            string status = reader.IsDBNull(5) ? "Ativo" : reader.GetString(5);
            string email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);

            if (!string.Equals(status, "Ativo", StringComparison.OrdinalIgnoreCase))
            {
                return new ResultadoLogin
                {
                    Sucesso = false,
                    Mensagem = "Esta conta está inativa. Procure um administrador."
                };
            }

            bool senhaValida = VerificarSenha(senha, senhaBanco, out bool senhaLegada);

            if (!senhaValida)
            {
                return new ResultadoLogin
                {
                    Sucesso = false,
                    Mensagem = "Usuário ou senha inválidos."
                };
            }

            string ultimoAcesso = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Se a senha ainda estiver no formato antigo, converte
            // automaticamente para o formato protegido.
            if (senhaLegada)
            {
                string novoHash = CriarHash(senha);

                using var atualizarSenha = connection.CreateCommand();
                atualizarSenha.CommandText = @"
                    UPDATE Usuarios
                    SET Senha = $senha,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                atualizarSenha.Parameters.AddWithValue("$senha", novoHash);
                atualizarSenha.Parameters.AddWithValue("$atualizado", ultimoAcesso);
                atualizarSenha.Parameters.AddWithValue("$id", id);
                atualizarSenha.ExecuteNonQuery();
            }

            using (var atualizarAcesso = connection.CreateCommand())
            {
                atualizarAcesso.CommandText = @"
                    UPDATE Usuarios
                    SET UltimoAcesso = $ultimoAcesso,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                atualizarAcesso.Parameters.AddWithValue("$ultimoAcesso", ultimoAcesso);
                atualizarAcesso.Parameters.AddWithValue("$atualizado", ultimoAcesso);
                atualizarAcesso.Parameters.AddWithValue("$id", id);
                atualizarAcesso.ExecuteNonQuery();
            }

            return new ResultadoLogin
            {
                Sucesso = true,
                Mensagem = "Login realizado com sucesso.",
                Id = id,
                Nome = nome,
                Usuario = usuarioBanco,
                Email = email,
                TipoUsuario = tipoUsuario,
                UltimoAcesso = ultimoAcesso
            };
        }

        public static bool CriarUsuario(
            string nome,
            string usuario,
            string email,
            string senha,
            string tipoUsuario,
            out string mensagem)
        {
            mensagem = string.Empty;

            // Segunda camada de segurança: a criação de contas só pode ocorrer
            // durante uma sessão administrativa.
            if (!SessaoUsuario.EhAdministrador)
            {
                mensagem = "Somente um Administrador pode criar contas.";
                return false;
            }

            // Somente o administrador principal (usuário "admin") pode criar
            // outro administrador. Novos administradores ficam limitados a
            // contas do tipo Usuário.
            if (!SessaoUsuario.EhAdministradorPrincipal)
                tipoUsuario = "Usuario";

            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagem = "Informe o nome.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                mensagem = "Informe o usuário.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                mensagem = "Informe a senha.";
                return false;
            }

            if (senha.Length < 6)
            {
                mensagem = "A senha deve ter pelo menos 6 caracteres.";
                return false;
            }

            if (tipoUsuario != "Administrador" && tipoUsuario != "Usuario")
                tipoUsuario = "Usuario";

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();

                command.CommandText = @"
                    INSERT INTO Usuarios
                    (
                        Nome,
                        Usuario,
                        Senha,
                        TipoUsuario,
                        Status,
                        Email,
                        CriadoEm,
                        AtualizadoEm
                    )
                    VALUES
                    (
                        $nome,
                        $usuario,
                        $senha,
                        $tipo,
                        'Ativo',
                        $email,
                        $criado,
                        $atualizado
                    );";

                string agora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                command.Parameters.AddWithValue("$nome", nome.Trim());
                command.Parameters.AddWithValue("$usuario", usuario.Trim());
                command.Parameters.AddWithValue("$senha", CriarHash(senha));
                command.Parameters.AddWithValue("$tipo", tipoUsuario);
                command.Parameters.AddWithValue("$email", email?.Trim() ?? string.Empty);
                command.Parameters.AddWithValue("$criado", agora);
                command.Parameters.AddWithValue("$atualizado", agora);

                command.ExecuteNonQuery();

                return true;
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
            {
                mensagem = "Este usuário já está cadastrado.";
                return false;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível criar a conta.\n\n" + ex.Message;
                return false;
            }
        }

        public static bool AtualizarProprioEmail(
            int id,
            string email,
            string senhaAtual,
            out string mensagem)
        {
            mensagem = string.Empty;

            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                mensagem = "Somente o Administrador principal pode alterar o próprio e-mail.";
                return false;
            }

            if (id != SessaoUsuario.Id)
            {
                mensagem = "A conta informada não corresponde ao administrador conectado.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                mensagem = "Informe o e-mail.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(senhaAtual))
            {
                mensagem = "Informe sua senha atual para confirmar a alteração.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                string senhaBanco;

                using (var buscar = connection.CreateCommand())
                {
                    buscar.CommandText = @"
                        SELECT Senha
                        FROM Usuarios
                        WHERE Id = $id
                          AND Usuario = 'admin'
                          AND Status = 'Ativo'
                        LIMIT 1;";

                    buscar.Parameters.AddWithValue("$id", id);
                    object? resultado = buscar.ExecuteScalar();

                    if (resultado == null)
                    {
                        mensagem = "Administrador principal não encontrado.";
                        return false;
                    }

                    senhaBanco = resultado.ToString() ?? string.Empty;
                }

                bool senhaValida = VerificarSenha(
                    senhaAtual,
                    senhaBanco,
                    out bool senhaLegada);

                if (!senhaValida)
                {
                    mensagem = "A senha atual está incorreta.";
                    return false;
                }

                using var verificarEmail = connection.CreateCommand();
                verificarEmail.CommandText = @"
                    SELECT Id
                    FROM Usuarios
                    WHERE lower(trim(Email)) = lower(trim($email))
                      AND Id <> $id
                    LIMIT 1;";
                verificarEmail.Parameters.AddWithValue("$email", email.Trim());
                verificarEmail.Parameters.AddWithValue("$id", id);

                if (verificarEmail.ExecuteScalar() != null)
                {
                    mensagem = "Este e-mail já está cadastrado em outra conta.";
                    return false;
                }

                using var atualizar = connection.CreateCommand();
                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Email = $email,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id
                      AND Usuario = 'admin';";

                atualizar.Parameters.AddWithValue("$email", email.Trim());
                atualizar.Parameters.AddWithValue(
                    "$atualizado",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                atualizar.Parameters.AddWithValue("$id", id);

                int linhas = atualizar.ExecuteNonQuery();

                if (linhas == 0)
                {
                    mensagem = "Não foi possível salvar o e-mail.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível atualizar o e-mail.\n\n" + ex.Message;
                return false;
            }
        }

        public static bool AtualizarUsuario(
            int id,
            string nome,
            string email,
            string senha,
            string tipoUsuario,
            out string mensagem)
        {
            mensagem = string.Empty;

            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                mensagem = "Somente o Administrador principal pode editar contas existentes.";
                return false;
            }

            if (id <= 0)
            {
                mensagem = "Conta inválida.";
                return false;
            }

            if (id == SessaoUsuario.Id)
            {
                mensagem = "A própria conta não pode ser alterada por esta ação.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagem = "Informe o nome.";
                return false;
            }

            if (tipoUsuario != "Administrador" && tipoUsuario != "Usuario")
                tipoUsuario = "Usuario";

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var verificar = connection.CreateCommand();
                verificar.CommandText = @"SELECT Usuario FROM Usuarios WHERE Id = $id LIMIT 1;";
                verificar.Parameters.AddWithValue("$id", id);

                string? usuarioAlvo = verificar.ExecuteScalar()?.ToString();

                if (string.IsNullOrWhiteSpace(usuarioAlvo))
                {
                    mensagem = "A conta selecionada não foi encontrada.";
                    return false;
                }

                if (string.Equals(usuarioAlvo, "admin", StringComparison.OrdinalIgnoreCase))
                {
                    mensagem = "A conta administradora principal (admin) é protegida e não pode ser editada.";
                    return false;
                }

                string agora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using var command = connection.CreateCommand();

                if (string.IsNullOrWhiteSpace(senha))
                {
                    command.CommandText = @"
                        UPDATE Usuarios
                        SET Nome = $nome,
                            Email = $email,
                            TipoUsuario = $tipo,
                            AtualizadoEm = $atualizado
                        WHERE Id = $id;";
                }
                else
                {
                    if (senha.Length < 6)
                    {
                        mensagem = "A senha deve ter pelo menos 6 caracteres.";
                        return false;
                    }

                    command.CommandText = @"
                        UPDATE Usuarios
                        SET Nome = $nome,
                            Email = $email,
                            Senha = $senha,
                            TipoUsuario = $tipo,
                            AtualizadoEm = $atualizado
                        WHERE Id = $id;";

                    command.Parameters.AddWithValue("$senha", CriarHash(senha));
                }

                command.Parameters.AddWithValue("$nome", nome.Trim());
                command.Parameters.AddWithValue("$email", email?.Trim() ?? string.Empty);
                command.Parameters.AddWithValue("$tipo", tipoUsuario);
                command.Parameters.AddWithValue("$atualizado", agora);
                command.Parameters.AddWithValue("$id", id);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível atualizar a conta.\n\n" + ex.Message;
                return false;
            }
        }

        public static bool PodeGerenciarConta(int idConta, bool exigeExclusao, out string mensagem)
        {
            mensagem = string.Empty;

            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                mensagem = exigeExclusao
                    ? "Somente o Administrador principal pode excluir contas."
                    : "Somente o Administrador principal pode alterar contas existentes.";
                return false;
            }

            if (idConta == SessaoUsuario.Id)
            {
                mensagem = "A própria conta não pode ser alterada por esta ação.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText = "SELECT Usuario FROM Usuarios WHERE Id = $id LIMIT 1;";
                command.Parameters.AddWithValue("$id", idConta);

                string? usuarioAlvo = command.ExecuteScalar()?.ToString();

                if (string.Equals(usuarioAlvo, "admin", StringComparison.OrdinalIgnoreCase))
                {
                    mensagem = "A conta administradora principal (admin) é protegida e nunca pode ser alterada ou excluída.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível validar a conta.\n\n" + ex.Message;
                return false;
            }
        }

        public static bool CriarSolicitacaoRecuperacao(
            string email,
            out int solicitacaoId,
            out string codigo,
            out DateTime expiraEm,
            out string mensagem)
        {
            solicitacaoId = 0;
            codigo = string.Empty;
            expiraEm = DateTime.MinValue;
            mensagem = string.Empty;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                mensagem = "Informe um e-mail válido.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var buscar = connection.CreateCommand();
                buscar.CommandText = @"
                    SELECT Id
                    FROM Usuarios
                    WHERE lower(trim(COALESCE(Email, ''))) = lower(trim($email))
                      AND lower(COALESCE(Status, 'Ativo')) = 'ativo'
                    LIMIT 1;";
                buscar.Parameters.AddWithValue("$email", email.Trim());

                object? resultado = buscar.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    mensagem = "Não encontramos uma conta ativa com esse e-mail.";
                    return false;
                }

                int usuarioId = Convert.ToInt32(resultado);
                codigo = RandomNumberGenerator.GetInt32(1000, 10000).ToString();
                expiraEm = DateTime.Now.AddMinutes(10);
                string agora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Somente o código mais recente permanece válido.
                using (var invalidar = connection.CreateCommand())
                {
                    invalidar.CommandText = @"
                        UPDATE RecuperacaoSenha
                        SET Usado = 1
                        WHERE UsuarioId = $usuarioId
                          AND Usado = 0;";
                    invalidar.Parameters.AddWithValue("$usuarioId", usuarioId);
                    invalidar.ExecuteNonQuery();
                }

                using var inserir = connection.CreateCommand();
                inserir.CommandText = @"
                    INSERT INTO RecuperacaoSenha
                    (
                        UsuarioId,
                        CodigoHash,
                        ExpiraEm,
                        Tentativas,
                        Validado,
                        Usado,
                        CriadoEm
                    )
                    VALUES
                    (
                        $usuarioId,
                        $codigoHash,
                        $expiraEm,
                        0,
                        0,
                        0,
                        $criadoEm
                    );
                    SELECT last_insert_rowid();";

                inserir.Parameters.AddWithValue("$usuarioId", usuarioId);
                inserir.Parameters.AddWithValue("$codigoHash", CriarHash(codigo));
                inserir.Parameters.AddWithValue("$expiraEm", expiraEm.ToString("yyyy-MM-dd HH:mm:ss"));
                inserir.Parameters.AddWithValue("$criadoEm", agora);

                solicitacaoId = Convert.ToInt32(inserir.ExecuteScalar());
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível criar a solicitação de recuperação.\r\n\r\n" + ex.Message;
                return false;
            }
        }

        public static bool ValidarCodigoRecuperacao(
            string email,
            string codigo,
            out string mensagem)
        {
            mensagem = string.Empty;

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT
                        r.Id,
                        r.CodigoHash,
                        r.ExpiraEm,
                        r.Tentativas,
                        r.Validado,
                        u.Id
                    FROM RecuperacaoSenha r
                    INNER JOIN Usuarios u ON u.Id = r.UsuarioId
                    WHERE lower(trim(COALESCE(u.Email, ''))) = lower(trim($email))
                      AND lower(COALESCE(u.Status, 'Ativo')) = 'ativo'
                      AND r.Usado = 0
                    ORDER BY r.Id DESC
                    LIMIT 1;";
                command.Parameters.AddWithValue("$email", email.Trim());

                using var reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    mensagem = "Nenhum código de recuperação válido foi encontrado. Solicite um novo código.";
                    return false;
                }

                int solicitacaoId = reader.GetInt32(0);
                string codigoHash = reader.GetString(1);
                DateTime expiraEm = DateTime.Parse(reader.GetString(2));
                int tentativas = reader.GetInt32(3);

                if (reader.GetInt32(4) == 1)
                {
                    mensagem = "Este código já foi validado. Continue para criar a nova senha.";
                    return true;
                }

                if (DateTime.Now > expiraEm)
                {
                    reader.Close();
                    MarcarSolicitacaoComoUsada(connection, solicitacaoId);
                    mensagem = "O código expirou. Solicite um novo código.";
                    return false;
                }

                if (tentativas >= 5)
                {
                    reader.Close();
                    MarcarSolicitacaoComoUsada(connection, solicitacaoId);
                    mensagem = "O limite de tentativas foi atingido. Solicite um novo código.";
                    return false;
                }

                bool valido = VerificarSenha(codigo.Trim(), codigoHash, out _);
                reader.Close();

                if (!valido)
                {
                    using var tentativa = connection.CreateCommand();
                    tentativa.CommandText = @"
                        UPDATE RecuperacaoSenha
                        SET Tentativas = Tentativas + 1
                        WHERE Id = $id;";
                    tentativa.Parameters.AddWithValue("$id", solicitacaoId);
                    tentativa.ExecuteNonQuery();

                    int restante = Math.Max(0, 4 - tentativas);
                    mensagem = restante == 0
                        ? "Código inválido. O limite de tentativas foi atingido."
                        : $"Código inválido. Você ainda pode tentar {restante} vez(es).";
                    return false;
                }

                using var validar = connection.CreateCommand();
                validar.CommandText = @"
                    UPDATE RecuperacaoSenha
                    SET Validado = 1
                    WHERE Id = $id AND Usado = 0;";
                validar.Parameters.AddWithValue("$id", solicitacaoId);
                validar.ExecuteNonQuery();

                mensagem = "Código validado com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível validar o código.\r\n\r\n" + ex.Message;
                return false;
            }
        }

        public static bool RedefinirSenhaPorRecuperacao(
            string email,
            string novaSenha,
            out string mensagem)
        {
            mensagem = string.Empty;

            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 6)
            {
                mensagem = "A nova senha deve ter pelo menos 6 caracteres.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var buscar = connection.CreateCommand();
                buscar.CommandText = @"
                    SELECT r.Id, u.Id
                    FROM RecuperacaoSenha r
                    INNER JOIN Usuarios u ON u.Id = r.UsuarioId
                    WHERE lower(trim(COALESCE(u.Email, ''))) = lower(trim($email))
                      AND lower(COALESCE(u.Status, 'Ativo')) = 'ativo'
                      AND r.Validado = 1
                      AND r.Usado = 0
                      AND datetime(r.ExpiraEm) >= datetime('now', 'localtime')
                    ORDER BY r.Id DESC
                    LIMIT 1;";
                buscar.Parameters.AddWithValue("$email", email.Trim());

                using var reader = buscar.ExecuteReader();
                if (!reader.Read())
                {
                    mensagem = "A validação não está mais disponível. Solicite um novo código.";
                    return false;
                }

                int solicitacaoId = reader.GetInt32(0);
                int usuarioId = reader.GetInt32(1);
                reader.Close();

                using var atualizar = connection.CreateCommand();
                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Senha = $senha,
                        AtualizadoEm = $atualizado
                    WHERE Id = $usuarioId;";
                atualizar.Parameters.AddWithValue("$senha", CriarHash(novaSenha));
                atualizar.Parameters.AddWithValue("$atualizado", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                atualizar.Parameters.AddWithValue("$usuarioId", usuarioId);
                atualizar.ExecuteNonQuery();

                using var invalidar = connection.CreateCommand();
                invalidar.CommandText = @"
                    UPDATE RecuperacaoSenha
                    SET Usado = 1
                    WHERE Id = $id;";
                invalidar.Parameters.AddWithValue("$id", solicitacaoId);
                invalidar.ExecuteNonQuery();

                mensagem = "Senha redefinida com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível redefinir a senha.\r\n\r\n" + ex.Message;
                return false;
            }
        }

        public static void CancelarSolicitacaoRecuperacao(int solicitacaoId)
        {
            if (solicitacaoId <= 0)
                return;

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();
                MarcarSolicitacaoComoUsada(connection, solicitacaoId);
            }
            catch
            {
                // Falha no cancelamento não deve interromper o fluxo da tela.
            }
        }

        private static void MarcarSolicitacaoComoUsada(
            SqliteConnection connection,
            int solicitacaoId)
        {
            using var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE RecuperacaoSenha
                SET Usado = 1
                WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", solicitacaoId);
            command.ExecuteNonQuery();
        }

        public static string CriarHash(string senha)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(TamanhoSalt);

            using var pbkdf2 = new Rfc2898DeriveBytes(
                senha,
                salt,
                Iteracoes,
                HashAlgorithmName.SHA256);

            byte[] hash = pbkdf2.GetBytes(TamanhoHash);

            return PrefixoHash
                + Iteracoes + "$"
                + Convert.ToBase64String(salt) + "$"
                + Convert.ToBase64String(hash);
        }

        private static bool VerificarSenha(
            string senha,
            string valorBanco,
            out bool senhaLegada)
        {
            senhaLegada = false;

            if (string.IsNullOrEmpty(valorBanco))
                return false;

            // Compatibilidade com a senha inicial criada pelo Database.
            if (!valorBanco.StartsWith(PrefixoHash, StringComparison.Ordinal))
            {
                senhaLegada = true;
                return string.Equals(
                    senha,
                    valorBanco,
                    StringComparison.Ordinal);
            }

            string[] partes = valorBanco.Split('$');

            if (partes.Length != 4)
                return false;

            if (!int.TryParse(partes[1], out int iteracoes))
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(partes[2]);
                byte[] hashEsperado = Convert.FromBase64String(partes[3]);

                using var pbkdf2 = new Rfc2898DeriveBytes(
                    senha,
                    salt,
                    iteracoes,
                    HashAlgorithmName.SHA256);

                byte[] hashAtual = pbkdf2.GetBytes(hashEsperado.Length);

                return CryptographicOperations.FixedTimeEquals(
                    hashAtual,
                    hashEsperado);
            }
            catch
            {
                return false;
            }
        }
    }
}
