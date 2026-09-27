using Microsoft.Data.Sqlite;
using RHControl.Data;
using System;
using System.Security.Cryptography;
using System.Text;

namespace RHControl.Services
{
    public static class RecuperacaoSenhaService
    {
        private const int ValidadeMinutos = 10;
        private const int MaxTentativas = 5;

        public sealed class ResultadoSolicitacao
        {
            public bool Sucesso { get; set; }
            public string Mensagem { get; set; } = string.Empty;
            public int UsuarioId { get; set; }
            public string Email { get; set; } = string.Empty;
        }

        public sealed class ResultadoCodigo
        {
            public bool Sucesso { get; set; }
            public string Mensagem { get; set; } = string.Empty;
            public int UsuarioId { get; set; }
        }

        public static ResultadoSolicitacao SolicitarCodigo(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return new ResultadoSolicitacao
                {
                    Mensagem = "Informe o e-mail cadastrado."
                };
            }

            using var connection = Database.GetConnection();
            connection.Open();

            using var localizar = connection.CreateCommand();
            localizar.CommandText = @"
                SELECT Id, Email
                FROM Usuarios
                WHERE lower(trim(Email)) = lower(trim($email))
                  AND Status = 'Ativo'
                LIMIT 1;";
            localizar.Parameters.AddWithValue("$email", email.Trim());

            using var reader = localizar.ExecuteReader();

            if (!reader.Read())
            {
                return new ResultadoSolicitacao
                {
                    Mensagem = "Não encontramos um usuário ativo com esse e-mail."
                };
            }

            int usuarioId = reader.GetInt32(0);
            string emailBanco = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
            reader.Close();

            if (string.IsNullOrWhiteSpace(emailBanco))
            {
                return new ResultadoSolicitacao
                {
                    Mensagem = "Este usuário não possui um e-mail cadastrado."
                };
            }

            using (var invalidar = connection.CreateCommand())
            {
                invalidar.CommandText = @"
                    UPDATE RecuperacaoSenha
                    SET Utilizado = 1
                    WHERE UsuarioId = $usuarioId
                      AND Utilizado = 0;";
                invalidar.Parameters.AddWithValue("$usuarioId", usuarioId);
                invalidar.ExecuteNonQuery();
            }

            string codigo = GerarCodigo();
            string codigoHash = CriarHashCodigo(codigo);
            DateTime agora = DateTime.Now;
            DateTime expiracao = agora.AddMinutes(ValidadeMinutos);

            using (var inserir = connection.CreateCommand())
            {
                inserir.CommandText = @"
                    INSERT INTO RecuperacaoSenha
                    (UsuarioId, CodigoHash, CriadoEm, ExpiraEm, Tentativas, Utilizado)
                    VALUES
                    ($usuarioId, $codigoHash, $criadoEm, $expiraEm, 0, 0);";
                inserir.Parameters.AddWithValue("$usuarioId", usuarioId);
                inserir.Parameters.AddWithValue("$codigoHash", codigoHash);
                inserir.Parameters.AddWithValue("$criadoEm", agora.ToString("yyyy-MM-dd HH:mm:ss"));
                inserir.Parameters.AddWithValue("$expiraEm", expiracao.ToString("yyyy-MM-dd HH:mm:ss"));
                inserir.ExecuteNonQuery();
            }

            try
            {
                EmailService.EnviarCodigo(emailBanco, codigo);

                return new ResultadoSolicitacao
                {
                    Sucesso = true,
                    Mensagem = "Código enviado com sucesso.",
                    UsuarioId = usuarioId,
                    Email = emailBanco
                };
            }
            catch (Exception ex)
            {
                using var cancelar = connection.CreateCommand();
                cancelar.CommandText = @"
                    UPDATE RecuperacaoSenha
                    SET Utilizado = 1
                    WHERE UsuarioId = $usuarioId
                      AND Utilizado = 0;";
                cancelar.Parameters.AddWithValue("$usuarioId", usuarioId);
                cancelar.ExecuteNonQuery();

                return new ResultadoSolicitacao
                {
                    Mensagem = "Não foi possível enviar o código por e-mail.\r\n\r\nDetalhes: " + ex.Message
                };
            }
        }

        public static ResultadoCodigo ValidarCodigo(int usuarioId, string codigo)
        {
            if (usuarioId <= 0)
                return new ResultadoCodigo { Mensagem = "Solicitação inválida." };

            codigo = codigo?.Trim() ?? string.Empty;

            if (codigo.Length != 4 || !int.TryParse(codigo, out _))
                return new ResultadoCodigo { Mensagem = "O código deve possuir 4 números." };

            using var connection = Database.GetConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT Id, CodigoHash, ExpiraEm, Tentativas
                FROM RecuperacaoSenha
                WHERE UsuarioId = $usuarioId
                  AND Utilizado = 0
                ORDER BY Id DESC
                LIMIT 1;";
            command.Parameters.AddWithValue("$usuarioId", usuarioId);

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return new ResultadoCodigo { Mensagem = "Não existe um código ativo." };

            int id = reader.GetInt32(0);
            string codigoHash = reader.GetString(1);
            DateTime expiraEm = DateTime.Parse(reader.GetString(2));
            int tentativas = reader.GetInt32(3);
            reader.Close();

            if (tentativas >= MaxTentativas)
                return new ResultadoCodigo { Mensagem = "Número máximo de tentativas atingido. Solicite um novo código." };

            if (DateTime.Now > expiraEm)
            {
                InvalidarCodigo(connection, id);
                return new ResultadoCodigo { Mensagem = "Esse código expirou. Solicite um novo código." };
            }

            string hashInformado = CriarHashCodigo(codigo);

            bool valido = CryptographicOperations.FixedTimeEquals(
                Convert.FromBase64String(codigoHash),
                Convert.FromBase64String(hashInformado));

            if (!valido)
            {
                using var tentativa = connection.CreateCommand();
                tentativa.CommandText = @"
                    UPDATE RecuperacaoSenha
                    SET Tentativas = Tentativas + 1
                    WHERE Id = $id;";
                tentativa.Parameters.AddWithValue("$id", id);
                tentativa.ExecuteNonQuery();

                return new ResultadoCodigo { Mensagem = "Código inválido." };
            }

            InvalidarCodigo(connection, id);

            return new ResultadoCodigo
            {
                Sucesso = true,
                Mensagem = "Código validado com sucesso.",
                UsuarioId = usuarioId
            };
        }

        public static bool AlterarSenha(int usuarioId, string novaSenha, out string mensagem)
        {
            mensagem = string.Empty;

            if (usuarioId <= 0)
            {
                mensagem = "Usuário inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                mensagem = "Digite a nova senha.";
                return false;
            }

            if (novaSenha.Length < 6)
            {
                mensagem = "A senha deve ter pelo menos 6 caracteres.";
                return false;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                string hash = UsuarioService.CriarHash(novaSenha);

                using var command = connection.CreateCommand();
                command.CommandText = @"
                    UPDATE Usuarios
                    SET Senha = $senha,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id
                      AND Status = 'Ativo';";
                command.Parameters.AddWithValue("$senha", hash);
                command.Parameters.AddWithValue("$atualizado", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("$id", usuarioId);

                if (command.ExecuteNonQuery() == 0)
                {
                    mensagem = "Não foi possível alterar a senha.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível alterar a senha.\r\n\r\n" + ex.Message;
                return false;
            }
        }

        private static void InvalidarCodigo(SqliteConnection connection, int id)
        {
            using var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE RecuperacaoSenha
                SET Utilizado = 1
                WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        private static string GerarCodigo()
        {
            int numero = RandomNumberGenerator.GetInt32(0, 10000);
            return numero.ToString("D4");
        }

        private static string CriarHashCodigo(string codigo)
        {
            byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes(codigo));
            return Convert.ToBase64String(hash);
        }
    }
}
