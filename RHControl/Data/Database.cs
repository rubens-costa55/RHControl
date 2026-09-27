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
                );";

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
                );";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlFerias;
                command.ExecuteNonQuery();
            }

            CriarIndiceSeNaoExistir(connection, "IX_Ferias_FuncionarioId", "Ferias", "FuncionarioId");
            CriarIndiceSeNaoExistir(connection, "IX_Ferias_DataDireito", "Ferias", "DataDireito");
            CriarIndiceSeNaoExistir(connection, "IX_Ferias_FimConcessivo", "Ferias", "FimConcessivo");

            string sqlConfiguracoes = @"
                CREATE TABLE IF NOT EXISTS Configuracoes
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Chave TEXT NOT NULL UNIQUE,
                    Valor TEXT,
                    AtualizadoEm TEXT
                );";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlConfiguracoes;
                command.ExecuteNonQuery();
            }

            string sqlUsuarios = @"
                CREATE TABLE IF NOT EXISTS Usuarios
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Usuario TEXT NOT NULL UNIQUE,
                    Senha TEXT NOT NULL,
                    TipoUsuario TEXT NOT NULL DEFAULT 'Usuario',
                    Status TEXT NOT NULL DEFAULT 'Ativo',
                    Email TEXT,
                    CriadoEm TEXT NOT NULL,
                    AtualizadoEm TEXT,
                    UltimoAcesso TEXT
                );";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlUsuarios;
                command.ExecuteNonQuery();
            }

            CriarIndiceSeNaoExistir(connection, "IX_Usuarios_TipoUsuario", "Usuarios", "TipoUsuario");
            CriarIndiceSeNaoExistir(connection, "IX_Usuarios_Status", "Usuarios", "Status");

            // ============================================================
            // RECUPERAÇÃO DE SENHA
            // ============================================================
            // Esta tabela é adicionada somente se ainda não existir.
            // Nenhum dado existente de Usuarios é apagado ou alterado.
            string sqlRecuperacaoSenha = @"
                CREATE TABLE IF NOT EXISTS RecuperacaoSenha
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UsuarioId INTEGER NOT NULL,
                    CodigoHash TEXT NOT NULL,
                    CriadoEm TEXT NOT NULL,
                    ExpiraEm TEXT NOT NULL,
                    Tentativas INTEGER NOT NULL DEFAULT 0,
                    Utilizado INTEGER NOT NULL DEFAULT 0,
                    FOREIGN KEY (UsuarioId)
                        REFERENCES Usuarios(Id)
                        ON DELETE CASCADE
                );";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlRecuperacaoSenha;
                command.ExecuteNonQuery();
            }

            CriarIndiceSeNaoExistir(
                connection,
                "IX_RecuperacaoSenha_UsuarioId",
                "RecuperacaoSenha",
                "UsuarioId");

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
                    INSERT INTO Usuarios
                    (
                        Nome,
                        Usuario,
                        Senha,
                        TipoUsuario,
                        Status,
                        CriadoEm
                    )
                    SELECT
                        'Administrador',
                        'admin',
                        'admin123',
                        'Administrador',
                        'Ativo',
                        $criadoEm
                    WHERE NOT EXISTS
                    (
                        SELECT 1
                        FROM Usuarios
                        WHERE Usuario = 'admin'
                    );";

                command.Parameters.AddWithValue(
                    "$criadoEm",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                command.ExecuteNonQuery();
            }

            // ============================================================
            // PAGAMENTOS DA FOLHA
            // ============================================================
            // A versão atual usa Ano/Mes + RegistradoEm.
            // A compatibilidade abaixo mantém funcionando também versões
            // anteriores que usavam CompetenciaAno/CompetenciaMes + CriadoEm.
            string sqlPagamentos = @"
                CREATE TABLE IF NOT EXISTS PagamentosFolha
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FuncionarioId INTEGER NOT NULL,
                    Ano INTEGER NOT NULL,
                    Mes INTEGER NOT NULL,
                    DataPrevista TEXT NOT NULL,
                    DataPagamento TEXT,
                    Status TEXT NOT NULL DEFAULT 'Pendente',
                    RegistradoEm TEXT,
                    Observacoes TEXT,
                    FOREIGN KEY (FuncionarioId)
                        REFERENCES Funcionarios(Id)
                        ON DELETE CASCADE,
                    UNIQUE (FuncionarioId, Ano, Mes)
                );";

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sqlPagamentos;
                command.ExecuteNonQuery();
            }

            // Colunas usadas pela versão atual.
            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "Ano",
                "INTEGER");

            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "Mes",
                "INTEGER");

            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "RegistradoEm",
                "TEXT");

            // Colunas usadas por versões anteriores do projeto.
            // Elas permanecem para que Jornada/Folha de versões anteriores
            // não quebrem o banco existente.
            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "CompetenciaAno",
                "INTEGER");

            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "CompetenciaMes",
                "INTEGER");

            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "CriadoEm",
                "TEXT");

            AdicionarColunaSeNaoExistir(
                connection,
                "PagamentosFolha",
                "AtualizadoEm",
                "TEXT");

            // Sincroniza a nomenclatura antiga com a atual.
            // Não apaga nem substitui registros existentes.
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
                    UPDATE PagamentosFolha
                    SET Ano = CompetenciaAno
                    WHERE (Ano IS NULL OR Ano = 0)
                      AND CompetenciaAno IS NOT NULL;

                    UPDATE PagamentosFolha
                    SET Mes = CompetenciaMes
                    WHERE (Mes IS NULL OR Mes = 0)
                      AND CompetenciaMes IS NOT NULL;

                    UPDATE PagamentosFolha
                    SET CompetenciaAno = Ano
                    WHERE (CompetenciaAno IS NULL OR CompetenciaAno = 0)
                      AND Ano IS NOT NULL;

                    UPDATE PagamentosFolha
                    SET CompetenciaMes = Mes
                    WHERE (CompetenciaMes IS NULL OR CompetenciaMes = 0)
                      AND Mes IS NOT NULL;

                    UPDATE PagamentosFolha
                    SET CriadoEm = RegistradoEm
                    WHERE (CriadoEm IS NULL OR CriadoEm = '')
                      AND RegistradoEm IS NOT NULL;

                    UPDATE PagamentosFolha
                    SET RegistradoEm = CriadoEm
                    WHERE (RegistradoEm IS NULL OR RegistradoEm = '')
                      AND CriadoEm IS NOT NULL;
                ";

                command.ExecuteNonQuery();
            }

            CriarIndiceSeNaoExistir(
                connection,
                "IX_PagamentosFolha_Funcionario",
                "PagamentosFolha",
                "FuncionarioId");

            CriarIndiceSeNaoExistir(
                connection,
                "IX_PagamentosFolha_Competencia",
                "PagamentosFolha",
                "Ano, Mes");

            CriarIndiceSeNaoExistir(
                connection,
                "IX_PagamentosFolha_CompetenciaAntiga",
                "PagamentosFolha",
                "CompetenciaAno, CompetenciaMes");
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
                WHERE name = $coluna;";

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
                ON {tabela} ({coluna});";

            command.ExecuteNonQuery();
        }
    }
}
