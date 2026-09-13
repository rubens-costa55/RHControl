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
