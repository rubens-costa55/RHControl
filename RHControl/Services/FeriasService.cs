using Microsoft.Data.Sqlite;
using System;
using System.Globalization;
using RHControl.Data;

namespace RHControl.Services
{
    public static class FeriasService
    {
        public static void SincronizarFerias()
        {
            DateTime hoje = DateTime.Today;

            using var connection = Database.GetConnection();
            connection.Open();

            string sqlFuncionarios = @"
                SELECT Id, DataAdmissao
                FROM Funcionarios
                WHERE DataAdmissao IS NOT NULL
                  AND TRIM(DataAdmissao) <> '';
            ";

            using var commandFuncionarios = connection.CreateCommand();
            commandFuncionarios.CommandText = sqlFuncionarios;

            using var reader = commandFuncionarios.ExecuteReader();

            while (reader.Read())
            {
                long funcionarioId = reader.GetInt64(0);
                string dataTexto = reader.IsDBNull(1)
                    ? ""
                    : reader.GetString(1);

                if (!DateTime.TryParse(
                    dataTexto,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime admissao))
                {
                    if (!DateTime.TryParse(
                        dataTexto,
                        new CultureInfo("pt-BR"),
                        DateTimeStyles.None,
                        out admissao))
                    {
                        continue;
                    }
                }

                GerarPeriodos(connection, funcionarioId, admissao.Date, hoje);
            }
        }

        private static void GerarPeriodos(
            SqliteConnection connection,
            long funcionarioId,
            DateTime admissao,
            DateTime hoje)
        {
            DateTime inicioAquisitivo = admissao;

            // Gera todos os períodos que já começaram.
            // Ex.: admissão 01/01/2023:
            // 01/01/2023 -> 31/12/2023
            // 01/01/2024 -> 31/12/2024
            // etc.
            while (inicioAquisitivo <= hoje)
            {
                DateTime fimAquisitivo =
                    inicioAquisitivo.AddYears(1).AddDays(-1);

                DateTime dataDireito =
                    inicioAquisitivo.AddYears(1);

                DateTime inicioConcessivo = dataDireito;

                DateTime fimConcessivo =
                    dataDireito.AddYears(1).AddDays(-1);

                if (!ExistePeriodo(
                    connection,
                    funcionarioId,
                    inicioAquisitivo))
                {
                    InserirPeriodo(
                        connection,
                        funcionarioId,
                        inicioAquisitivo,
                        fimAquisitivo,
                        dataDireito,
                        inicioConcessivo,
                        fimConcessivo,
                        hoje);
                }
                else
                {
                    AtualizarStatusPeriodo(
                        connection,
                        funcionarioId,
                        inicioAquisitivo,
                        dataDireito,
                        fimConcessivo,
                        hoje);
                }

                inicioAquisitivo = dataDireito;
            }
        }

        private static bool ExistePeriodo(
            SqliteConnection connection,
            long funcionarioId,
            DateTime inicioAquisitivo)
        {
            using var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT COUNT(*)
                FROM Ferias
                WHERE FuncionarioId = $FuncionarioId
                  AND InicioAquisitivo = $InicioAquisitivo;
            ";

            command.Parameters.AddWithValue(
                "$FuncionarioId",
                funcionarioId);

            command.Parameters.AddWithValue(
                "$InicioAquisitivo",
                inicioAquisitivo.ToString("yyyy-MM-dd"));

            return Convert.ToInt64(command.ExecuteScalar()) > 0;
        }

        private static void InserirPeriodo(
            SqliteConnection connection,
            long funcionarioId,
            DateTime inicioAquisitivo,
            DateTime fimAquisitivo,
            DateTime dataDireito,
            DateTime inicioConcessivo,
            DateTime fimConcessivo,
            DateTime hoje)
        {
            string status;

            if (hoje < dataDireito)
            {
                status = "Em aquisição";
            }
            else
            {
                status = "Disponível";
            }

            using var command = connection.CreateCommand();

            command.CommandText = @"
                INSERT INTO Ferias
                (
                    FuncionarioId,
                    InicioAquisitivo,
                    FimAquisitivo,
                    DataDireito,
                    InicioConcessivo,
                    FimConcessivo,
                    InicioFerias,
                    FimFerias,
                    Dias,
                    Status,
                    Observacoes,
                    CriadoEm,
                    AtualizadoEm
                )
                VALUES
                (
                    $FuncionarioId,
                    $InicioAquisitivo,
                    $FimAquisitivo,
                    $DataDireito,
                    $InicioConcessivo,
                    $FimConcessivo,
                    NULL,
                    NULL,
                    NULL,
                    $Status,
                    NULL,
                    $CriadoEm,
                    NULL
                );
            ";

            command.Parameters.AddWithValue(
                "$FuncionarioId",
                funcionarioId);

            command.Parameters.AddWithValue(
                "$InicioAquisitivo",
                inicioAquisitivo.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$FimAquisitivo",
                fimAquisitivo.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$DataDireito",
                dataDireito.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$InicioConcessivo",
                inicioConcessivo.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$FimConcessivo",
                fimConcessivo.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$Status",
                status);

            command.Parameters.AddWithValue(
                "$CriadoEm",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            command.ExecuteNonQuery();
        }

        private static void AtualizarStatusPeriodo(
            SqliteConnection connection,
            long funcionarioId,
            DateTime inicioAquisitivo,
            DateTime dataDireito,
            DateTime fimConcessivo,
            DateTime hoje)
        {
            // Não altera períodos que futuramente serão programados/concluídos.
            // Aqui atualizamos somente o status automático.
            string novoStatus;

            if (hoje < dataDireito)
            {
                novoStatus = "Em aquisição";
            }
            else if (hoje <= fimConcessivo)
            {
                novoStatus = "Disponível";
            }
            else
            {
                novoStatus = "Prazo encerrado";
            }

            using var command = connection.CreateCommand();

            command.CommandText = @"
                UPDATE Ferias
                SET Status = $Status,
                    AtualizadoEm = $AtualizadoEm
                WHERE FuncionarioId = $FuncionarioId
                  AND InicioAquisitivo = $InicioAquisitivo
                  AND Status IN ('Em aquisição', 'Disponível', 'Prazo encerrado');
            ";

            command.Parameters.AddWithValue(
                "$Status",
                novoStatus);

            command.Parameters.AddWithValue(
                "$AtualizadoEm",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            command.Parameters.AddWithValue(
                "$FuncionarioId",
                funcionarioId);

            command.Parameters.AddWithValue(
                "$InicioAquisitivo",
                inicioAquisitivo.ToString("yyyy-MM-dd"));

            command.ExecuteNonQuery();
        }
    }
}
