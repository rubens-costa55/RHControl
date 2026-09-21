using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Forms;

namespace RHControl
{
    public partial class FrmDashboard : Form
    {
        private bool encerrandoSessao;
        private readonly CultureInfo cultura = new CultureInfo("pt-BR");

        public FrmDashboard()
        {
            InitializeComponent();

            btnFuncionarios.Click += BtnFuncionarios_Click;
            btnJornada.Click += BtnJornada_Click;
            btnFolha.Click += BtnFolha_Click;
            btnConfiguracoes.Click += BtnConfiguracoes_Click;
            btnSair.Click += BtnSair_Click;

            AplicarPermissoes();

            Shown += FrmDashboard_Shown;
            Activated += FrmDashboard_Activated;
        }

        private void FrmDashboard_Shown(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            if (!encerrandoSessao)
                AtualizarDashboard();
        }

        private void AplicarPermissoes()
        {
            btnDashboard.Enabled = true;
            btnFuncionarios.Enabled = true;
            btnJornada.Enabled = true;
            btnFolha.Enabled = true;

            btnConfiguracoes.Visible = SessaoUsuario.PodeConfigurar;
            btnConfiguracoes.Enabled = SessaoUsuario.PodeConfigurar;

            AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            if (lblUsuario == null)
                return;

            string nome = string.IsNullOrWhiteSpace(SessaoUsuario.Nome)
                ? SessaoUsuario.Usuario
                : SessaoUsuario.Nome;

            string tipo = SessaoUsuario.EhAdministrador
                ? "Administrador"
                : "Usuário";

            lblUsuario.Text = "●  " + nome + "  •  " + tipo;
        }

        private void AtualizarDashboard()
        {
            try
            {
                using (SqliteConnection connection = Database.GetConnection())
                {
                    connection.Open();

                    AtualizarCards(connection);
                    AtualizarSituacao(connection);
                    AtualizarEventos(connection);
                    AtualizarAlertas(connection);
                }

                AtualizarUsuario();
            }
            catch (Exception ex)
            {
                // O Dashboard não deve impedir a abertura do sistema se uma
                // informação complementar estiver indisponível.
                lblSituacaoResumo.Text =
                    "Não foi possível atualizar os indicadores agora.";

                lblEvento1.Text = "Verifique os dados cadastrados.";
                lblEvento2.Text = "Folha e pagamentos disponíveis no menu.";
                lblEvento3.Text = "Jornada e férias disponíveis no calendário.";
                lblEvento4.Text = "Configurações disponíveis para administrador.";

                lblAlerta1.Text = "Não foi possível atualizar o resumo.";
                lblAlerta2.Text = "Confira a tela de Folha / Relatórios.";
                lblAlerta3.Text = "Confira a tela de Jornada / Calendário.";
            }
        }

        private void AtualizarCards(SqliteConnection connection)
        {
            int total;
            int ativos;
            int ferias;
            int afastados;
            int desligados;
            decimal folha;

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
                    SELECT
                        COUNT(*) AS Total,
                        COALESCE(SUM(CASE WHEN Status = 'Ativo' THEN 1 ELSE 0 END), 0) AS Ativos,
                        COALESCE(SUM(CASE WHEN Status = 'Férias' THEN 1 ELSE 0 END), 0) AS Ferias,
                        COALESCE(SUM(CASE WHEN Status = 'Afastado' THEN 1 ELSE 0 END), 0) AS Afastados,
                        COALESCE(SUM(CASE WHEN Status = 'Desligado' THEN 1 ELSE 0 END), 0) AS Desligados,
                        COALESCE(SUM(
                            CASE
                                WHEN Status <> 'Desligado'
                                THEN COALESCE(Salario, 0)
                                ELSE 0
                            END
                        ), 0) AS Folha
                    FROM Funcionarios;";

                using SqliteDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                    return;

                total = Convert.ToInt32(reader["Total"]);
                ativos = Convert.ToInt32(reader["Ativos"]);
                ferias = Convert.ToInt32(reader["Ferias"]);
                afastados = Convert.ToInt32(reader["Afastados"]);
                desligados = Convert.ToInt32(reader["Desligados"]);
                folha = Convert.ToDecimal(reader["Folha"]);
            }

            lblFuncionariosValor.Text = ativos.ToString();
            lblFuncionariosInfo.Text =
                total == 1 ? "1 colaborador cadastrado" :
                total.ToString() + " colaboradores cadastrados";

            lblFolhaValor.Text = folha.ToString("C2", cultura);
            lblFolhaInfo.Text = "Total estimado dos funcionários não desligados";

            DateTime hoje = DateTime.Today;
            DateTime pagamento = ObterProximoPagamento(connection, hoje);

            lblPagamentoValor.Text = pagamento.ToString("dd/MM");
            lblPagamentoInfo.Text =
                pagamento.Month == hoje.Month
                    ? "Próximo pagamento"
                    : "Próximo mês";

            int diaAdiantamento = ObterConfiguracaoInteiro(
                connection,
                "Folha_DiaAdiantamento",
                20);

            DateTime adiantamento = ProximoDiaDoMes(
                hoje,
                diaAdiantamento);

            lblAdiantamentoValor.Text = adiantamento.ToString("dd/MM");
            lblAdiantamentoInfo.Text = "Data configurada";

            int feriasProximas = ContarFeriasProximas(
                connection,
                hoje,
                hoje.AddDays(30));

            lblFeriasValor.Text = feriasProximas.ToString();
            lblFeriasInfo.Text = "Próximos 30 dias";
        }

        private void AtualizarSituacao(SqliteConnection connection)
        {
            int ativos = 0;
            int ferias = 0;
            int afastados = 0;
            int total = 0;

            using SqliteCommand command = connection.CreateCommand();

            command.CommandText = @"
                SELECT
                    COUNT(*) AS Total,
                    COALESCE(SUM(CASE WHEN Status = 'Ativo' THEN 1 ELSE 0 END), 0) AS Ativos,
                    COALESCE(SUM(CASE WHEN Status = 'Férias' THEN 1 ELSE 0 END), 0) AS Ferias,
                    COALESCE(SUM(CASE WHEN Status = 'Afastado' THEN 1 ELSE 0 END), 0) AS Afastados
                FROM Funcionarios;";

            using SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                total = Convert.ToInt32(reader["Total"]);
                ativos = Convert.ToInt32(reader["Ativos"]);
                ferias = Convert.ToInt32(reader["Ferias"]);
                afastados = Convert.ToInt32(reader["Afastados"]);
            }

            lblAtivos.Text = "Ativos — " + ativos;
            lblFerias.Text = "Férias — " + ferias;
            lblAfastados.Text = "Afastados — " + afastados;

            progressAtivos.Maximum = Math.Max(1, total);
            progressFerias.Maximum = Math.Max(1, total);
            progressAfastados.Maximum = Math.Max(1, total);

            progressAtivos.Value = Math.Min(ativos, progressAtivos.Maximum);
            progressFerias.Value = Math.Min(ferias, progressFerias.Maximum);
            progressAfastados.Value = Math.Min(afastados, progressAfastados.Maximum);

            lblSituacaoResumo.Text =
                total == 0
                    ? "Nenhum funcionário cadastrado."
                    : total + " funcionário(s) cadastrado(s).";
        }

        private void AtualizarEventos(
            SqliteConnection connection)
        {
            DateTime hoje = DateTime.Today;
            DateTime limite = hoje.AddDays(30);

            string evento1 = "Nenhum evento próximo.";
            string evento2 = "Nenhum evento próximo.";
            string evento3 = "Nenhum evento próximo.";
            string evento4 = "Nenhum evento próximo.";

            var eventos = new System.Collections.Generic.List<Tuple<DateTime, string>>();

            DateTime pagamento = ObterProximoPagamento(connection, hoje);
            eventos.Add(Tuple.Create(
                pagamento,
                "Folha mensal — " + pagamento.ToString("dd/MM/yyyy")));

            int diaAdiantamento = ObterConfiguracaoInteiro(
                connection,
                "Folha_DiaAdiantamento",
                20);

            DateTime adiantamento = ProximoDiaDoMes(
                hoje,
                diaAdiantamento);

            eventos.Add(Tuple.Create(
                adiantamento,
                "Adiantamento — " + adiantamento.ToString("dd/MM/yyyy")));

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
                    SELECT f.Nome, fe.InicioFerias, fe.FimFerias
                    FROM Ferias fe
                    INNER JOIN Funcionarios f ON f.Id = fe.FuncionarioId
                    WHERE f.Status <> 'Desligado'
                      AND fe.InicioFerias IS NOT NULL
                      AND date(fe.InicioFerias) BETWEEN date($hoje) AND date($limite)
                    ORDER BY date(fe.InicioFerias)
                    LIMIT 5;";

                command.Parameters.AddWithValue(
                    "$hoje",
                    hoje.ToString("yyyy-MM-dd"));

                command.Parameters.AddWithValue(
                    "$limite",
                    limite.ToString("yyyy-MM-dd"));

                using SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!DateTime.TryParse(
                        reader["InicioFerias"]?.ToString(),
                        out DateTime inicio))
                        continue;

                    string nome = reader["Nome"]?.ToString() ?? "Funcionário";

                    eventos.Add(Tuple.Create(
                        inicio,
                        "Início de férias — " +
                        nome + " — " +
                        inicio.ToString("dd/MM/yyyy")));
                }
            }

            eventos = eventos
                .Where(x => x.Item1 >= hoje)
                .OrderBy(x => x.Item1)
                .Take(4)
                .ToList();

            if (eventos.Count > 0) evento1 = eventos[0].Item2;
            if (eventos.Count > 1) evento2 = eventos[1].Item2;
            if (eventos.Count > 2) evento3 = eventos[2].Item2;
            if (eventos.Count > 3) evento4 = eventos[3].Item2;

            lblEvento1.Text = evento1;
            lblEvento2.Text = evento2;
            lblEvento3.Text = evento3;
            lblEvento4.Text = evento4;
        }

        private void AtualizarAlertas(SqliteConnection connection)
        {
            DateTime hoje = DateTime.Today;
            int ano = hoje.Year;
            int mes = hoje.Month;

            int atrasados = 0;
            int pagos = 0;
            int pendentes = 0;

            try
            {
                using SqliteCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT
                        COALESCE(SUM(
                            CASE
                                WHEN DataPagamento IS NULL
                                     AND date(DataPrevista) < date($hoje)
                                THEN 1 ELSE 0
                            END), 0) AS Atrasados,
                        COALESCE(SUM(
                            CASE
                                WHEN DataPagamento IS NOT NULL
                                THEN 1 ELSE 0
                            END), 0) AS Pagos,
                        COALESCE(SUM(
                            CASE
                                WHEN DataPagamento IS NULL
                                     AND date(DataPrevista) >= date($hoje)
                                THEN 1 ELSE 0
                            END), 0) AS Pendentes
                    FROM PagamentosFolha
                    WHERE Ano = $ano
                      AND Mes = $mes;";

                command.Parameters.AddWithValue("$hoje", hoje.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("$ano", ano);
                command.Parameters.AddWithValue("$mes", mes);

                using SqliteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    atrasados = Convert.ToInt32(reader["Atrasados"]);
                    pagos = Convert.ToInt32(reader["Pagos"]);
                    pendentes = Convert.ToInt32(reader["Pendentes"]);
                }
            }
            catch
            {
                // A tabela pode ainda não possuir registros da competência.
            }

            int feriasProximas = ContarFeriasProximas(
                connection,
                hoje,
                hoje.AddDays(30));

            lblAlerta1.Text =
                atrasados > 0
                    ? atrasados + " pagamento(s) em atraso."
                    : "Nenhum pagamento em atraso.";

            lblAlerta2.Text =
                pendentes > 0
                    ? pendentes + " pagamento(s) pendente(s)."
                    : "Nenhum pagamento pendente.";

            lblAlerta3.Text =
                feriasProximas > 0
                    ? feriasProximas + " férias programada(s) nos próximos 30 dias."
                    : "Nenhuma férias próxima.";
        }

        private int ContarFeriasProximas(
            SqliteConnection connection,
            DateTime inicio,
            DateTime fim)
        {
            using SqliteCommand command = connection.CreateCommand();

            command.CommandText = @"
                SELECT COUNT(*)
                FROM Ferias fe
                INNER JOIN Funcionarios f
                    ON f.Id = fe.FuncionarioId
                WHERE f.Status <> 'Desligado'
                  AND fe.InicioFerias IS NOT NULL
                  AND date(fe.InicioFerias)
                      BETWEEN date($inicio) AND date($fim);";

            command.Parameters.AddWithValue(
                "$inicio",
                inicio.ToString("yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$fim",
                fim.ToString("yyyy-MM-dd"));

            return Convert.ToInt32(command.ExecuteScalar());
        }

        private DateTime ObterProximoPagamento(
            SqliteConnection connection,
            DateTime hoje)
        {
            int configurado = ObterConfiguracaoInteiro(
                connection,
                "Folha_DiaPagamento",
                5);

            if (configurado == 5)
            {
                DateTime atual = QuintoDiaUtil(
                    hoje.Year,
                    hoje.Month);

                if (atual >= hoje)
                    return atual;

                DateTime proximoMes = hoje.AddMonths(1);

                return QuintoDiaUtil(
                    proximoMes.Year,
                    proximoMes.Month);
            }

            DateTime candidato = ProximoDiaDoMes(
                hoje,
                configurado);

            if (candidato >= hoje)
                return candidato;

            DateTime proximo = hoje.AddMonths(1);

            return ProximoDiaDoMes(
                proximo,
                configurado);
        }

        private DateTime QuintoDiaUtil(
            int ano,
            int mes)
        {
            DateTime data = new DateTime(ano, mes, 1);
            int contador = 0;

            while (true)
            {
                if (data.DayOfWeek != DayOfWeek.Sunday)
                    contador++;

                if (contador == 5)
                    return data;

                data = data.AddDays(1);
            }
        }

        private DateTime ProximoDiaDoMes(
            DateTime referencia,
            int dia)
        {
            dia = Math.Max(1, Math.Min(31, dia));

            int ano = referencia.Year;
            int mes = referencia.Month;

            int ultimoDia = DateTime.DaysInMonth(ano, mes);
            DateTime atual = new DateTime(
                ano,
                mes,
                Math.Min(dia, ultimoDia));

            if (atual >= referencia.Date)
                return atual;

            DateTime proximo = referencia.AddMonths(1);
            ultimoDia = DateTime.DaysInMonth(
                proximo.Year,
                proximo.Month);

            return new DateTime(
                proximo.Year,
                proximo.Month,
                Math.Min(dia, ultimoDia));
        }

        private int ObterConfiguracaoInteiro(
            SqliteConnection connection,
            string chave,
            int padrao)
        {
            try
            {
                using SqliteCommand command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT Valor
                    FROM Configuracoes
                    WHERE Chave = $chave
                    LIMIT 1;";

                command.Parameters.AddWithValue("$chave", chave);

                object valor = command.ExecuteScalar();

                if (valor != null &&
                    int.TryParse(valor.ToString(), out int resultado))
                    return resultado;
            }
            catch
            {
            }

            return padrao;
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFuncionarios());
        }

        private void BtnJornada_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmJornada());
        }

        private void BtnFolha_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFolhaPagamento());
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
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

            AbrirForm(new FrmConfiguracoes());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair do RH Control?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            SessaoUsuario.Encerrar();
            encerrandoSessao = true;

            FrmLogin login = Application.OpenForms
                .OfType<FrmLogin>()
                .FirstOrDefault();

            if (login == null || login.IsDisposed)
                login = new FrmLogin();

            login.Show();
            login.BringToFront();

            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                if (form == login || form == this)
                    continue;

                if (form is FrmFuncionarios ||
                    form is FrmJornada ||
                    form is FrmFolhaPagamento ||
                    form is FrmConfiguracoes)
                {
                    form.Close();
                }
            }

            Close();
        }

        public void EncerrarPorLogout()
        {
            encerrandoSessao = true;
            Close();
        }

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
                    AtualizarDashboard();
                }
            };

            Hide();
            form.Show();
        }
    }
}
