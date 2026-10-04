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

            if (!SessaoUsuario.EhAdministrador)
            {
                mensagem = "Somente um Administrador pode criar contas.";
                return false;
            }

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
                verificar.CommandText = @"
                    SELECT Usuario
                    FROM Usuarios
                    WHERE Id = $id
                    LIMIT 1;";

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

        public static bool PodeGerenciarConta(
            int idConta,
            bool exigeExclusao,
            out string mensagem)
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

                command.CommandText =
                    "SELECT Usuario FROM Usuarios WHERE Id = $id LIMIT 1;";

                command.Parameters.AddWithValue("$id", idConta);

                string? usuarioAlvo = command.ExecuteScalar()?.ToString();

                if (string.IsNullOrWhiteSpace(usuarioAlvo))
                {
                    mensagem = "A conta selecionada não foi encontrada.";
                    return false;
                }

                if (string.Equals(
                    usuarioAlvo,
                    "admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    mensagem =
                        "A conta administradora principal (admin) é protegida e nunca pode ser alterada ou excluída.";

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                mensagem =
                    "Não foi possível validar a conta.\n\n" + ex.Message;

                return false;
            }
        }

        public static bool AlterarMinhaSenha(
            int id,
            string email,
            string senhaAtual,
            string novaSenha,
            out string mensagem)
        {
            mensagem = string.Empty;

            if (id <= 0)
            {
                mensagem = "Sessão de usuário inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                mensagem = "Informe o e-mail cadastrado.";
                return false;
            }

            if (string.IsNullOrEmpty(senhaAtual))
            {
                mensagem = "Informe a senha atual.";
                return false;
            }

            if (string.IsNullOrEmpty(novaSenha))
            {
                mensagem = "Informe a nova senha.";
                return false;
            }

            if (novaSenha.Length < 6)
            {
                mensagem = "A nova senha deve ter pelo menos 6 caracteres.";
                return false;
            }

            if (string.Equals(
                senhaAtual,
                novaSenha,
                StringComparison.Ordinal))
            {
                mensagem =
                    "A nova senha precisa ser diferente da senha atual.";

                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                string senhaBanco;
                string emailBanco;

                using (var buscar = connection.CreateCommand())
                {
                    buscar.CommandText = @"
                        SELECT
                            COALESCE(Senha, ''),
                            COALESCE(Email, '')
                        FROM Usuarios
                        WHERE Id = $id
                        LIMIT 1;";

                    buscar.Parameters.AddWithValue("$id", id);

                    using var reader = buscar.ExecuteReader();

                    if (!reader.Read())
                    {
                        mensagem = "Usuário não encontrado.";
                        return false;
                    }

                    senhaBanco = reader.GetString(0);
                    emailBanco = reader.GetString(1);
                }

                if (!string.Equals(
                    email.Trim(),
                    emailBanco.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    mensagem =
                        "O e-mail informado não corresponde ao e-mail cadastrado.";

                    return false;
                }

                if (!VerificarSenha(
                    senhaAtual,
                    senhaBanco,
                    out bool senhaLegada))
                {
                    mensagem = "A senha atual está incorreta.";
                    return false;
                }

                string agora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using var atualizar = connection.CreateCommand();

                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Senha = $senha,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                atualizar.Parameters.AddWithValue(
                    "$senha",
                    CriarHash(novaSenha));

                atualizar.Parameters.AddWithValue(
                    "$atualizado",
                    agora);

                atualizar.Parameters.AddWithValue("$id", id);

                atualizar.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                mensagem =
                    "Não foi possível alterar a senha.\n\n" + ex.Message;

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

            if (id <= 0)
            {
                mensagem = "Sessão de usuário inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                mensagem = "Informe o e-mail.";
                return false;
            }

            if (string.IsNullOrEmpty(senhaAtual))
            {
                mensagem = "Informe a senha atual para confirmar a alteração.";
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
                        SELECT COALESCE(Senha, '')
                        FROM Usuarios
                        WHERE Id = $id
                        LIMIT 1;";

                    buscar.Parameters.AddWithValue("$id", id);

                    senhaBanco = buscar.ExecuteScalar()?.ToString() ?? string.Empty;
                }

                if (string.IsNullOrEmpty(senhaBanco))
                {
                    mensagem = "Usuário não encontrado.";
                    return false;
                }

                if (!VerificarSenha(senhaAtual, senhaBanco, out _))
                {
                    mensagem = "A senha atual está incorreta.";
                    return false;
                }

                string agora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                using var atualizar = connection.CreateCommand();

                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Email = $email,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                atualizar.Parameters.AddWithValue("$email", email.Trim());
                atualizar.Parameters.AddWithValue("$atualizado", agora);
                atualizar.Parameters.AddWithValue("$id", id);

                atualizar.ExecuteNonQuery();

                SessaoUsuario.Iniciar(
                    SessaoUsuario.Id,
                    SessaoUsuario.Nome,
                    SessaoUsuario.Usuario,
                    email.Trim(),
                    SessaoUsuario.TipoUsuario,
                    SessaoUsuario.UltimoAcesso);

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível atualizar o e-mail.\n\n" + ex.Message;
                return false;
            }
        }

        public static bool AtualizarProprioEmail(
            int id,
            string email,
            out string mensagem)
        {
            mensagem = string.Empty;

            if (id <= 0)
            {
                mensagem = "Sessão de usuário inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                mensagem = "Informe o e-mail.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var atualizar = connection.CreateCommand();

                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Email = $email,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                atualizar.Parameters.AddWithValue("$email", email.Trim());
                atualizar.Parameters.AddWithValue(
                    "$atualizado",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                atualizar.Parameters.AddWithValue("$id", id);

                int linhas = atualizar.ExecuteNonQuery();

                if (linhas <= 0)
                {
                    mensagem = "Usuário não encontrado.";
                    return false;
                }

                SessaoUsuario.Iniciar(
                    SessaoUsuario.Id,
                    SessaoUsuario.Nome,
                    SessaoUsuario.Usuario,
                    email.Trim(),
                    SessaoUsuario.TipoUsuario,
                    SessaoUsuario.UltimoAcesso);

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível atualizar o e-mail.\n\n" + ex.Message;
                return false;
            }
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

            if (!valorBanco.StartsWith(
                PrefixoHash,
                StringComparison.Ordinal))
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

                byte[] hashAtual =
                    pbkdf2.GetBytes(hashEsperado.Length);

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
