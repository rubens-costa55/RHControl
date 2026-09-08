using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace RHControl.Data
{
    public static class Database
    {
        private static readonly string PastaBanco =
            Path.Combine(AppContext.BaseDirectory, "Data");

        private static readonly string CaminhoBanco =
            Path.Combine(PastaBanco, "rhcontrol.db");

        private static readonly string ConnectionString =
            $"Data Source={CaminhoBanco}";

        public static SqliteConnection GetConnection()
        {
            Directory.CreateDirectory(PastaBanco);
            return new SqliteConnection(ConnectionString);
        }

        public static void Inicializar()
        {
            Directory.CreateDirectory(PastaBanco);

            using var connection = GetConnection();
            connection.Open();

            string sqlFuncionarios = @"
                CREATE TABLE IF NOT EXISTS Funcionarios
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    CPF TEXT,
                    DataNascimento TEXT,
                    Telefone TEXT,
                    Email TEXT,
                    Cargo TEXT,
                    Setor TEXT,
                    DataAdmissao TEXT,
                    Salario REAL,
                    Escala TEXT,
                    TipoJornada TEXT,
                    DiaFolga TEXT,
                    DiaFolga2 TEXT,
                    DataBaseEscala TEXT,
                    CargaHorariaSemanal INTEGER,
                    HorarioEntrada TEXT,
                    HorarioSaida TEXT,
                    InicioIntervalo TEXT,
                    FimIntervalo TEXT,
                    Status TEXT NOT NULL DEFAULT 'Ativo',
                    DataDesligamento TEXT,
                    MotivoDesligamento TEXT,
                    Observacoes TEXT,
                    CriadoEm TEXT NOT NULL,
                    AtualizadoEm TEXT
                );
            ";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlFuncionarios;
                command.ExecuteNonQuery();
            }

            AdicionarColunaSeNaoExistir(connection, "Funcionarios", "TipoJornada", "TEXT");
            AdicionarColunaSeNaoExistir(connection, "Funcionarios", "DiaFolga", "TEXT");
            AdicionarColunaSeNaoExistir(connection, "Funcionarios", "DiaFolga2", "TEXT");
            AdicionarColunaSeNaoExistir(connection, "Funcionarios", "DataBaseEscala", "TEXT");

            string sqlFerias = @"
                CREATE TABLE IF NOT EXISTS Ferias
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FuncionarioId INTEGER NOT NULL,
                    InicioAquisitivo TEXT NOT NULL,
                    FimAquisitivo TEXT NOT NULL,
                    DataDireito TEXT NOT NULL,
                    InicioConcessivo TEXT NOT NULL,
                    FimConcessivo TEXT NOT NULL,
                    InicioFerias TEXT,
                    FimFerias TEXT,
                    Dias INTEGER,
                    Status TEXT NOT NULL DEFAULT 'Em aquisição',
                    Observacoes TEXT,
                    CriadoEm TEXT NOT NULL,
                    AtualizadoEm TEXT,
                    FOREIGN KEY (FuncionarioId)
                        REFERENCES Funcionarios(Id)
                        ON DELETE CASCADE
                );
            ";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlFerias;
                command.ExecuteNonQuery();
            }

            CriarIndiceSeNaoExistir(
                connection,
                "IX_Ferias_FuncionarioId",
                "Ferias",
                "FuncionarioId");

            CriarIndiceSeNaoExistir(
                connection,
                "IX_Ferias_DataDireito",
                "Ferias",
                "DataDireito");

            CriarIndiceSeNaoExistir(
                connection,
                "IX_Ferias_FimConcessivo",
                "Ferias",
                "FimConcessivo");
        }

        private static void AdicionarColunaSeNaoExistir(
            SqliteConnection connection,
            string tabela,
            string coluna,
            string tipo)
        {
            using var command = connection.CreateCommand();

            command.CommandText = $@"
                SELECT COUNT(*)
                FROM pragma_table_info('{tabela}')
                WHERE name = $coluna;
            ";

            command.Parameters.AddWithValue("$coluna", coluna);

            long existe = Convert.ToInt64(command.ExecuteScalar());

            if (existe == 0)
            {
                command.Parameters.Clear();
                command.CommandText =
                    $"ALTER TABLE {tabela} ADD COLUMN {coluna} {tipo};";

                command.ExecuteNonQuery();
            }
        }

        private static void CriarIndiceSeNaoExistir(
            SqliteConnection connection,
            string nomeIndice,
            string tabela,
            string coluna)
        {
            using var command = connection.CreateCommand();

            command.CommandText = $@"
                CREATE INDEX IF NOT EXISTS {nomeIndice}
                ON {tabela} ({coluna});
            ";

            command.ExecuteNonQuery();
        }
    }
}
