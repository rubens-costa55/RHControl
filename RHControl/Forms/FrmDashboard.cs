using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmDashboard : Form
    {
        private bool encerrandoSessao;
        private Button btnAlterarSenha;

        public FrmDashboard()
        {
            InitializeComponent();

            btnFuncionarios.Click += BtnFuncionarios_Click;
            btnJornada.Click += BtnJornada_Click;
            btnFolha.Click += BtnFolha_Click;
            btnConfiguracoes.Click += BtnConfiguracoes_Click;
            btnSair.Click += BtnSair_Click;

            CriarBotaoAlterarSenha();
            AplicarPermissoes();

            CarregarDashboard();
        }

        // ============================================================
        // BOTÃO ALTERAR SENHA
        // ============================================================

        private void CriarBotaoAlterarSenha()
        {
            if (pnlMenu == null)
                return;

            Control existente = pnlMenu.Controls["btnAlterarSenha"];

            if (existente is Button botaoExistente)
            {
                btnAlterarSenha = botaoExistente;

                btnAlterarSenha.Click -= BtnAlterarSenha_Click;
                btnAlterarSenha.Click += BtnAlterarSenha_Click;

                return;
            }

            btnAlterarSenha = new Button
            {
                Name = "btnAlterarSenha",
                Text = "🔑  Alterar senha",
                Dock = DockStyle.Bottom,
                Height = 44,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(20, 48, 75),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(18, 0, 0, 0),
                Cursor = Cursors.Hand,
                TabStop = false
            };

            btnAlterarSenha.FlatAppearance.BorderSize = 0;

            btnAlterarSenha.Click += BtnAlterarSenha_Click;

            pnlMenu.Controls.Add(btnAlterarSenha);

            btnAlterarSenha.BringToFront();
            btnSair.BringToFront();
        }

        // ============================================================
        // PERMISSÕES
        // ============================================================

        private void AplicarPermissoes()
        {
            btnDashboard.Enabled = true;
            btnFuncionarios.Enabled = true;
            btnJornada.Enabled = true;
            btnFolha.Enabled = true;

            btnConfiguracoes.Visible =
                SessaoUsuario.PodeConfigurar;

            btnConfiguracoes.Enabled =
                SessaoUsuario.PodeConfigurar;

            if (lblUsuario != null)
            {
                lblUsuario.AutoSize = true;

                lblUsuario.Font =
                    new Font("Segoe UI Semibold", 9F);

                lblUsuario.ForeColor =
                    Color.FromArgb(18, 103, 181);

                lblUsuario.Text =
                    SessaoUsuario.EhAdministrador
                        ? "♙  Administrador"
                        : "♙  Usuário";

                lblUsuario.TextAlign =
                    ContentAlignment.MiddleRight;

                lblUsuario.Anchor =
                    AnchorStyles.Top |
                    AnchorStyles.Right;

                lblUsuario.Location =
                    new Point(
                        lblUsuario.Parent.ClientSize.Width -
                        lblUsuario.PreferredWidth -
                        25,
                        34);
            }
        }

        // ============================================================
        // CARREGAMENTO DO DASHBOARD
        // ============================================================

        private void CarregarDashboard()
        {
            try
            {
                using SqliteConnection conexao =
                    Database.GetConnection();

                conexao.Open();

                CarregarResumoFuncionarios(conexao);
                CarregarFolha(conexao);
                CarregarPagamentos(conexao);
                CarregarFerias(conexao);
                CarregarEventos(conexao);
                CarregarAlertas(conexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os dados do Dashboard.\n\n" +
                    ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ============================================================
        // FUNCIONÁRIOS
        // ============================================================

        private void CarregarResumoFuncionarios(
            SqliteConnection conexao)
        {
            int ativos = 0;
            int ferias = 0;
            int afastados = 0;

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT
                        COALESCE(
                            SUM(
                                CASE
                                    WHEN Status = 'Ativo'
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS Ativos,

                        COALESCE(
                            SUM(
                                CASE
                                    WHEN Status = 'Férias'
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS Ferias,

                        COALESCE(
                            SUM(
                                CASE
                                    WHEN Status = 'Afastado'
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS Afastados

                    FROM Funcionarios;";

                using SqliteDataReader reader =
                    command.ExecuteReader();

                if (reader.Read())
                {
                    ativos =
                        Convert.ToInt32(
                            reader["Ativos"]);

                    ferias =
                        Convert.ToInt32(
                            reader["Ferias"]);

                    afastados =
                        Convert.ToInt32(
                            reader["Afastados"]);
                }
            }

            lblFuncionariosValor.Text =
                ativos.ToString();

            lblFuncionariosInfo.Text =
                "Colaboradores ativos";

            lblAtivos.Text =
                $"Ativos — {ativos}";

            lblFerias.Text =
                $"Férias — {ferias}";

            lblAfastados.Text =
                $"Afastados — {afastados}";

            int total =
                ativos +
                ferias +
                afastados;

            progressFerias.Value =
                CalcularPercentual(
                    ferias,
                    total);

            progressAfastados.Value =
                CalcularPercentual(
                    afastados,
                    total);
        }

        // ============================================================
        // FOLHA ESTIMADA
        // ============================================================

        private void CarregarFolha(
            SqliteConnection conexao)
        {
            decimal totalFolha = 0;

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT
                        COALESCE(
                            SUM(
                                COALESCE(Salario, 0)
                            ),
                            0
                        )
                    FROM Funcionarios
                    WHERE Status = 'Ativo';";

                object resultado =
                    command.ExecuteScalar();

                if (resultado != null &&
                    resultado != DBNull.Value)
                {
                    totalFolha =
                        Convert.ToDecimal(
                            resultado,
                            CultureInfo.InvariantCulture);
                }
            }

            lblFolhaValor.Text =
                totalFolha.ToString(
                    "C",
                    CultureInfo.GetCultureInfo("pt-BR"));

            lblFolhaInfo.Text =
                "Total estimado";
        }

        // ============================================================
        // PAGAMENTOS
        // ============================================================

        private void CarregarPagamentos(
            SqliteConnection conexao)
        {
            int diaPagamento =
                LerConfiguracaoInteiro(
                    conexao,
                    "Folha_DiaPagamento",
                    5);

            int diaAdiantamento =
                LerConfiguracaoInteiro(
                    conexao,
                    "Folha_DiaAdiantamento",
                    20);

            DateTime hoje = DateTime.Today;

            DateTime proximoPagamento =
                ProximaDataDoMes(
                    hoje,
                    diaPagamento);

            DateTime proximoAdiantamento =
                ProximaDataDoMes(
                    hoje,
                    diaAdiantamento);

            lblPagamentoValor.Text =
                proximoPagamento.ToString(
                    "dd/MM");

            lblPagamentoInfo.Text =
                CalcularDescricaoData(
                    proximoPagamento,
                    "dia útil");

            lblAdiantamentoValor.Text =
                proximoAdiantamento.ToString(
                    "dd/MM");

            lblAdiantamentoInfo.Text =
                "Data configurada";
        }

        // ============================================================
        // FÉRIAS
        // ============================================================

        private void CarregarFerias(
            SqliteConnection conexao)
        {
            DateTime hoje = DateTime.Today;

            DateTime limite =
                hoje.AddDays(30);

            List<DateTime> proximasFerias =
                new List<DateTime>();

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT InicioFerias
                    FROM Ferias
                    WHERE InicioFerias IS NOT NULL
                      AND TRIM(InicioFerias) <> '';";

                using SqliteDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    string valor =
                        reader["InicioFerias"]?.ToString()
                        ?? "";

                    if (TentarConverterData(
                        valor,
                        out DateTime data))
                    {
                        if (data >= hoje &&
                            data <= limite)
                        {
                            proximasFerias.Add(data);
                        }
                    }
                }
            }

            proximasFerias =
                proximasFerias
                    .OrderBy(x => x)
                    .ToList();

            int quantidade =
                proximasFerias.Count;

            lblFeriasValor.Text =
                quantidade.ToString();

            lblFeriasInfo.Text =
                "Próximos 30 dias";
        }

        // ============================================================
        // EVENTOS
        // ============================================================

        private void CarregarEventos(
            SqliteConnection conexao)
        {
            DateTime hoje = DateTime.Today;

            DateTime proximoPagamento =
                ProximaDataDoMes(
                    hoje,
                    LerConfiguracaoInteiro(
                        conexao,
                        "Folha_DiaPagamento",
                        5));

            DateTime proximoAdiantamento =
                ProximaDataDoMes(
                    hoje,
                    LerConfiguracaoInteiro(
                        conexao,
                        "Folha_DiaAdiantamento",
                        20));

            List<string> eventos =
                new List<string>();

            // --------------------------------------------------------
            // Próximas férias
            // --------------------------------------------------------

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT
                        InicioFerias,
                        FimFerias
                    FROM Ferias
                    WHERE InicioFerias IS NOT NULL
                      AND TRIM(InicioFerias) <> ''
                    ORDER BY InicioFerias;";

                using SqliteDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    string inicioTexto =
                        reader["InicioFerias"]?.ToString()
                        ?? "";

                    string fimTexto =
                        reader["FimFerias"]?.ToString()
                        ?? "";

                    if (!TentarConverterData(
                        inicioTexto,
                        out DateTime inicio))
                    {
                        continue;
                    }

                    if (inicio < hoje)
                        continue;

                    if (eventos.Count < 2)
                    {
                        eventos.Add(
                            "  Início de férias  —  " +
                            inicio.ToString("dd/MM/yyyy"));

                        if (TentarConverterData(
                            fimTexto,
                            out DateTime fim))
                        {
                            eventos.Add(
                                "  Fim de férias  —  " +
                                fim.ToString("dd/MM/yyyy"));
                        }
                    }

                    if (eventos.Count >= 2)
                        break;
                }
            }

            // --------------------------------------------------------
            // Adiantamento
            // --------------------------------------------------------

            eventos.Add(
                "  Adiantamento  —  " +
                proximoAdiantamento.ToString("dd/MM/yyyy"));

            // --------------------------------------------------------
            // Folha
            // --------------------------------------------------------

            eventos.Add(
                "  Folha mensal  —  " +
                proximoPagamento.ToString("dd/MM/yyyy"));

            while (eventos.Count < 4)
            {
                eventos.Add(
                    "  Nenhum outro evento programado.");
            }

            lblEvento1.Text = eventos[0];
            lblEvento2.Text = eventos[1];
            lblEvento3.Text = eventos[2];
            lblEvento4.Text = eventos[3];
        }

        // ============================================================
        // ALERTAS
        // ============================================================

        private void CarregarAlertas(
            SqliteConnection conexao)
        {
            int registrosIncompletos = 0;

            // No banco atual não existe uma tabela específica
            // para banco de horas. Portanto, não vamos inventar
            // um número no Dashboard.
            string alerta1 =
                "  Nenhum alerta de banco de horas.";

            // Verifica funcionários sem salário informado.
            int semSalario = 0;

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT COUNT(*)
                    FROM Funcionarios
                    WHERE Status = 'Ativo'
                      AND (
                          Salario IS NULL
                          OR Salario <= 0
                      );";

                semSalario =
                    Convert.ToInt32(
                        command.ExecuteScalar());
            }

            string alerta2;

            if (semSalario > 0)
            {
                alerta2 =
                    $"  {semSalario} funcionário(s) sem salário informado.";
            }
            else
            {
                alerta2 =
                    "  Nenhum funcionário com salário pendente.";
            }

            // Férias programadas nos próximos 30 dias.
            int feriasProgramadas = 0;

            DateTime hoje = DateTime.Today;
            DateTime limite = hoje.AddDays(30);

            using (SqliteCommand command =
                   conexao.CreateCommand())
            {
                command.CommandText = @"
                    SELECT InicioFerias
                    FROM Ferias
                    WHERE InicioFerias IS NOT NULL
                      AND TRIM(InicioFerias) <> '';";

                using SqliteDataReader reader =
                    command.ExecuteReader();

                while (reader.Read())
                {
                    string valor =
                        reader["InicioFerias"]?.ToString()
                        ?? "";

                    if (TentarConverterData(
                        valor,
                        out DateTime data))
                    {
                        if (data >= hoje &&
                            data <= limite)
                        {
                            feriasProgramadas++;
                        }
                    }
                }
            }

            string alerta3 =
                feriasProgramadas > 0
                    ? $"  {feriasProgramadas} férias programada(s)."
                    : "  Nenhuma férias programada.";

            lblAlerta1.Text = alerta1;
            lblAlerta2.Text = alerta2;
            lblAlerta3.Text = alerta3;
        }

        // ============================================================
        // CONFIGURAÇÕES
        // ============================================================

        private static int LerConfiguracaoInteiro(
            SqliteConnection conexao,
            string chave,
            int padrao)
        {
            try
            {
                using SqliteCommand command =
                    conexao.CreateCommand();

                command.CommandText = @"
                    SELECT Valor
                    FROM Configuracoes
                    WHERE Chave = $chave
                    LIMIT 1;";

                command.Parameters.AddWithValue(
                    "$chave",
                    chave);

                object resultado =
                    command.ExecuteScalar();

                if (resultado == null ||
                    resultado == DBNull.Value)
                {
                    return padrao;
                }

                if (int.TryParse(
                    resultado.ToString(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out int valor))
                {
                    if (valor >= 1 &&
                        valor <= 31)
                    {
                        return valor;
                    }
                }
            }
            catch
            {
                // Usa o padrão caso a configuração ainda não exista.
            }

            return padrao;
        }

        // ============================================================
        // DATAS
        // ============================================================

        private static DateTime ProximaDataDoMes(
            DateTime hoje,
            int dia)
        {
            dia = Math.Max(
                1,
                Math.Min(31, dia));

            int ultimoDia =
                DateTime.DaysInMonth(
                    hoje.Year,
                    hoje.Month);

            DateTime dataAtual =
                new DateTime(
                    hoje.Year,
                    hoje.Month,
                    Math.Min(dia, ultimoDia));

            if (dataAtual >= hoje)
                return dataAtual;

            DateTime proximoMes =
                hoje.AddMonths(1);

            int ultimoDiaProximoMes =
                DateTime.DaysInMonth(
                    proximoMes.Year,
                    proximoMes.Month);

            return new DateTime(
                proximoMes.Year,
                proximoMes.Month,
                Math.Min(
                    dia,
                    ultimoDiaProximoMes));
        }

        private static string CalcularDescricaoData(
            DateTime data,
            string complemento)
        {
            if (data.Date == DateTime.Today)
                return "Hoje";

            if (data.Date == DateTime.Today.AddDays(1))
                return "Amanhã";

            return complemento;
        }

        private static bool TentarConverterData(
            string valor,
            out DateTime data)
        {
            string[] formatos =
            {
                "yyyy-MM-dd",
                "yyyy-MM-dd HH:mm:ss",
                "dd/MM/yyyy",
                "dd/MM/yyyy HH:mm:ss",
                "yyyy-MM-ddTHH:mm:ss"
            };

            return DateTime.TryParseExact(
                       valor,
                       formatos,
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out data)
                   ||
                   DateTime.TryParse(
                       valor,
                       CultureInfo.GetCultureInfo("pt-BR"),
                       DateTimeStyles.None,
                       out data);
        }

        private static int CalcularPercentual(
            int valor,
            int total)
        {
            if (total <= 0)
                return 0;

            int percentual =
                (int)Math.Round(
                    valor * 100.0 / total);

            return Math.Max(
                0,
                Math.Min(100, percentual));
        }

        // ============================================================
        // ALTERAR SENHA
        // ============================================================

        private void BtnAlterarSenha_Click(
            object? sender,
            EventArgs e)
        {
            if (SessaoUsuario.Id <= 0)
                return;

            using (FrmAlterarSenha tela =
                   new FrmAlterarSenha())
            {
                tela.ShowDialog(this);
            }
        }

        // ============================================================
        // NAVEGAÇÃO
        // ============================================================

        private void BtnFuncionarios_Click(
            object? sender,
            EventArgs e)
        {
            AbrirForm(
                new FrmFuncionarios());
        }

        private void BtnJornada_Click(
            object? sender,
            EventArgs e)
        {
            AbrirForm(
                new FrmJornada());
        }

        private void BtnFolha_Click(
            object? sender,
            EventArgs e)
        {
            AbrirForm(
                new FrmFolhaPagamento());
        }

        private void BtnConfiguracoes_Click(
            object? sender,
            EventArgs e)
        {
            if (!SessaoUsuario.PodeConfigurar)
            {
                MessageBox.Show(
                    "Seu perfil permite apenas visualizar informações e exportar relatórios.\n\n" +
                    "O acesso às Configurações é exclusivo do Administrador.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            AbrirForm(
                new FrmConfiguracoes());
        }

        // ============================================================
        // SAIR
        // ============================================================

        private void BtnSair_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult resposta =
                MessageBox.Show(
                    "Deseja realmente sair do RH Control?",
                    "Sair",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            SessaoUsuario.Encerrar();

            FrmLogin? login =
                Application.OpenForms
                    .OfType<FrmLogin>()
                    .FirstOrDefault();

            if (login == null ||
                login.IsDisposed)
            {
                login = new FrmLogin();
            }

            login.Show();
            login.BringToFront();

            foreach (
                Form form
                in Application.OpenForms
                    .Cast<Form>()
                    .ToArray())
            {
                if (form == login ||
                    form == this)
                {
                    continue;
                }

                if (form is FrmFuncionarios ||
                    form is FrmJornada ||
                    form is FrmFolhaPagamento ||
                    form is FrmConfiguracoes)
                {
                    form.Close();
                }
            }

            encerrandoSessao = true;

            Close();
        }

        // ============================================================
        // ENCERRAMENTO
        // ============================================================

        public void EncerrarPorLogout()
        {
            encerrandoSessao = true;
            Close();
        }

        // ============================================================
        // ABRIR OUTRAS TELAS
        // ============================================================

        private void AbrirForm(Form form)
        {
            form.FormClosed += (s, args) =>
            {
                if (!encerrandoSessao &&
                    SessaoUsuario.Id > 0 &&
                    !IsDisposed)
                {
                    Show();
                    BringToFront();

                    // Atualiza os números quando voltamos
                    // de outra tela.
                    CarregarDashboard();
                }
            };

            Hide();

            form.Show();
        }
    }
}