using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;

namespace RHControl.Forms
{
    public partial class FrmFolhaPagamento : Form
    {
        private int indiceLinhaPdf;
        private int paginaPdf;
        private bool alterandoPesquisa;
        private bool encerrandoSessao;
        private string tipoRelatorioPdf = "Folha";

        public FrmFolhaPagamento()
        {
            InitializeComponent();

            AplicarPermissoes();

            // Eventos da tela
            btnGerarFolha.Click += btnGerarFolha_Click;
            btnFiltrar.Click += btnFiltrar_Click;
            btnRelatorioSintetico.Click += btnRelatorioSintetico_Click;
            btnRelatorioAnalitico.Click += btnRelatorioAnalitico_Click;

            btnRegistrarPagamento.Click -= btnRegistrarPagamento_Click;
            btnRegistrarPagamento.Click += btnRegistrarPagamento_Click;

            btnSair.Click -= BtnSair_Click;
            btnSair.Click += BtnSair_Click;

            btnDashboard.Click -= BtnDashboard_Click;
            btnDashboard.Click += BtnDashboard_Click;

            btnFuncionarios.Click -= BtnFuncionarios_Click;
            btnFuncionarios.Click += BtnFuncionarios_Click;

            btnJornada.Click -= BtnJornada_Click;
            btnJornada.Click += BtnJornada_Click;

            btnConfiguracoes.Click -= BtnConfiguracoes_Click;
            btnConfiguracoes.Click += BtnConfiguracoes_Click;

            txtPesquisar.Enter += txtPesquisar_Enter;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyDown += txtPesquisar_KeyDown;

            // Ao abrir a tela, o período atual já é carregado automaticamente.
            // Cada competência possui seus próprios registros de pagamento,
            // portanto os dados de meses anteriores permanecem salvos.
            PrepararPeriodoAtual();
            CarregarFolha();
        }

        // =========================================================
        // NAVEGAÇÃO
        // =========================================================

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = Application.OpenForms
                .OfType<FrmDashboard>()
                .FirstOrDefault();

            if (dashboard == null || dashboard.IsDisposed)
                dashboard = new FrmDashboard();

            dashboard.Show();
            dashboard.BringToFront();
            Hide();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirMenuForm(new FrmFuncionarios());
        }

        private void BtnJornada_Click(object sender, EventArgs e)
        {
            AbrirMenuForm(new FrmJornada());
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeConfigurar)
            {
                MessageBox.Show(
                    "O acesso às Configurações é exclusivo do Administrador.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            AbrirMenuForm(new FrmConfiguracoes());
        }

        private void AbrirMenuForm(Form form)
        {
            form.FormClosed += (s, args) =>
            {
                if (!encerrandoSessao &&
                    SessaoUsuario.Id > 0 &&
                    !IsDisposed)
                {
                    Show();
                    BringToFront();
                }
            };

            Hide();
            form.Show();
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

                if (form is FrmDashboard ||
                    form is FrmFuncionarios ||
                    form is FrmJornada ||
                    form is FrmFolhaPagamento ||
                    form is FrmConfiguracoes)
                {
                    form.Close();
                }
            }

            Close();
        }

        private void AplicarPermissoes()
        {
            // Cabeçalho: mostra somente o nível de acesso
            if (lblUsuario != null)
            {
                lblUsuario.AutoSize = true;
                lblUsuario.Font = new Font("Segoe UI Semibold", 9F);
                lblUsuario.ForeColor = Color.FromArgb(18, 103, 181);

                lblUsuario.Text =
                    SessaoUsuario.EhAdministrador
                        ? "♙  Administrador"
                        : "♙  Usuário";

                lblUsuario.TextAlign = ContentAlignment.MiddleRight;
                lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                // Mantém o texto encostado à direita do cabeçalho
                lblUsuario.Location = new Point(
                    lblUsuario.Parent.ClientSize.Width - lblUsuario.PreferredWidth - 25,
                    34);
            }

            // Permissões da folha
            btnGerarFolha.Enabled = SessaoUsuario.PodeEditar;
            btnRegistrarPagamento.Enabled = SessaoUsuario.PodeEditar;

            if (!SessaoUsuario.PodeEditar)
            {
                btnGerarFolha.Text = "Gerar Folha";
                btnGerarFolha.Cursor = Cursors.Default;
            }

            if (!SessaoUsuario.PodeExportar)
                btnImprimir.Enabled = false;
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeEditar)
            {
                MessageBox.Show(
                    "Seu perfil pode apenas consultar e exportar a folha de pagamento.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private void PrepararPeriodoAtual()
        {
            string mesAtual = DateTime.Now.ToString("MMMM", CulturaPtBr());
            mesAtual = char.ToUpper(mesAtual[0]) + mesAtual.Substring(1);

            // Seleciona o mês atual, se ele existir no ComboBox.
            int indiceMes = cmbMes.FindStringExact(mesAtual);
            if (indiceMes >= 0)
                cmbMes.SelectedIndex = indiceMes;
            else
                cmbMes.Text = mesAtual;

            // Seleciona o ano atual, se ele existir no ComboBox.
            int indiceAno = cmbAno.FindStringExact(DateTime.Now.Year.ToString());
            if (indiceAno >= 0)
                cmbAno.SelectedIndex = indiceAno;
            else
                cmbAno.Text = DateTime.Now.Year.ToString();
        }

        private bool ValidarPeriodo()
        {
            bool mesValido =
                !string.IsNullOrWhiteSpace(cmbMes.Text) &&
                !cmbMes.Text.Equals("Selecione o mês", StringComparison.OrdinalIgnoreCase) &&
                !cmbMes.Text.Equals("Selecione", StringComparison.OrdinalIgnoreCase);

            bool anoValido =
                !string.IsNullOrWhiteSpace(cmbAno.Text) &&
                !cmbAno.Text.Equals("Selecione o ano", StringComparison.OrdinalIgnoreCase) &&
                !cmbAno.Text.Equals("Selecione", StringComparison.OrdinalIgnoreCase);

            if (!mesValido || !anoValido)
            {
                MessageBox.Show(
                    "Para gerar ou filtrar a folha, selecione o mês e o ano.",
                    "Período obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (!mesValido)
                    cmbMes.Focus();
                else
                    cmbAno.Focus();

                return false;
            }

            return true;
        }

        private int ObterNumeroMesSelecionado()
        {
            string[] meses =
            {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto",
                "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            int indice = Array.IndexOf(meses, cmbMes.Text);
            return indice >= 0 ? indice + 1 : DateTime.Now.Month;
        }

        private int ObterAnoSelecionado()
        {
            return int.TryParse(cmbAno.Text, out int ano)
                ? ano
                : DateTime.Now.Year;
        }

        private DateTime ObterDataPagamentoPrevista(int ano, int mes)
        {
            // Mantém a mesma regra de 5º dia útil usada pelo calendário:
            // segunda a sábado contam como dias úteis.
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

        private void GarantirTabelaPagamentos(SqliteConnection connection)
        {
            using SqliteCommand command = connection.CreateCommand();

            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS PagamentosFolha
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FuncionarioId INTEGER NOT NULL,
                    Ano INTEGER NOT NULL,
                    Mes INTEGER NOT NULL,
                    DataPrevista TEXT NOT NULL,
                    DataPagamento TEXT,
                    Status TEXT NOT NULL DEFAULT 'Pendente',
                    CriadoEm TEXT NOT NULL,
                    AtualizadoEm TEXT,
                    Observacoes TEXT,
                    FOREIGN KEY (FuncionarioId)
                        REFERENCES Funcionarios(Id)
                        ON DELETE CASCADE,
                    UNIQUE (FuncionarioId, Ano, Mes)
                );
            ";

            command.ExecuteNonQuery();
        }

        private void GarantirRegistrosPagamento(
            SqliteConnection connection,
            int ano,
            int mes,
            DateTime dataPrevista)
        {
            using SqliteCommand command = connection.CreateCommand();

            command.CommandText = @"
                INSERT OR IGNORE INTO PagamentosFolha
                (
                    FuncionarioId,
                    Ano,
                    Mes,
                    DataPrevista,
                    Status,
                    CriadoEm
                )
                SELECT
                    Id,
                    $ano,
                    $mes,
                    $dataPrevista,
                    'Pendente',
                    $criadoEm
                FROM Funcionarios;
            ";

            command.Parameters.AddWithValue("$ano", ano);
            command.Parameters.AddWithValue("$mes", mes);
            command.Parameters.AddWithValue(
                "$dataPrevista",
                dataPrevista.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue(
                "$criadoEm",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            command.ExecuteNonQuery();
        }

        private string ObterStatusPagamento(
            DateTime dataPrevista,
            DateTime? dataPagamento)
        {
            if (dataPagamento.HasValue)
            {
                return dataPagamento.Value.Date <= dataPrevista.Date
                    ? "Pago • " + dataPagamento.Value.ToString("dd/MM")
                    : "Pago c/ atraso • " + dataPagamento.Value.ToString("dd/MM");
            }

            if (DateTime.Today > dataPrevista.Date)
                return "Atrasado • " + dataPrevista.ToString("dd/MM");

            if (DateTime.Today == dataPrevista.Date)
                return "Vence hoje";

            return "Pendente • " + dataPrevista.ToString("dd/MM");
        }

        private bool ObterIdFuncionarioSelecionado(
            out long funcionarioId,
            out string nomeFuncionario)
        {
            funcionarioId = 0;
            nomeFuncionario = "";

            if (dgvFuncionarios.CurrentRow == null)
                return false;

            if (dgvFuncionarios.CurrentRow.Tag == null)
                return false;

            if (!long.TryParse(
                dgvFuncionarios.CurrentRow.Tag.ToString(),
                out funcionarioId))
                return false;

            nomeFuncionario =
                dgvFuncionarios.CurrentRow.Cells["colNome"]
                    .Value?.ToString() ?? "";

            return funcionarioId > 0;
        }

        private void btnRegistrarPagamento_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeEditar)
            {
                MessageBox.Show(
                    "Apenas o Administrador pode registrar pagamentos.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!ObterIdFuncionarioSelecionado(
                out long funcionarioId,
                out string nomeFuncionario))
            {
                MessageBox.Show(
                    "Selecione um funcionário na folha para registrar o pagamento.",
                    "Registro de pagamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int ano = ObterAnoSelecionado();
            int mes = ObterNumeroMesSelecionado();
            DateTime dataPrevista = ObterDataPagamentoPrevista(ano, mes);

            using Form dialog = new Form
            {
                Text = "Registrar pagamento",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                ClientSize = new Size(390, 180),
                BackColor = Color.FromArgb(244, 247, 251)
            };

            Label lbl = new Label
            {
                Text = "Funcionário: " + nomeFuncionario +
                       "\nCompetência: " + cmbMes.Text + "/" + ano +
                       "\nData prevista: " + dataPrevista.ToString("dd/MM/yyyy"),
                Location = new Point(20, 18),
                Size = new Size(350, 58),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(35, 45, 55)
            };

            Label lblData = new Label
            {
                Text = "Data efetiva do pagamento:",
                Location = new Point(20, 82),
                Size = new Size(180, 22),
                Font = new Font("Segoe UI Semibold", 9F),
                ForeColor = Color.FromArgb(20, 55, 87)
            };

            DateTimePicker dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Today,
                Location = new Point(205, 80),
                Size = new Size(145, 25)
            };

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                DialogResult = DialogResult.Cancel,
                Location = new Point(165, 125),
                Size = new Size(95, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(31, 91, 145)
            };

            Button btnConfirmar = new Button
            {
                Text = "Registrar",
                DialogResult = DialogResult.OK,
                Location = new Point(265, 125),
                Size = new Size(85, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 126, 255),
                ForeColor = Color.White
            };

            dialog.Controls.Add(lbl);
            dialog.Controls.Add(lblData);
            dialog.Controls.Add(dtp);
            dialog.Controls.Add(btnCancelar);
            dialog.Controls.Add(btnConfirmar);
            dialog.AcceptButton = btnConfirmar;
            dialog.CancelButton = btnCancelar;

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                using SqliteConnection connection = Database.GetConnection();
                connection.Open();

                using SqliteCommand command = connection.CreateCommand();

                command.CommandText = @"
                    INSERT OR IGNORE INTO PagamentosFolha
                    (
                        FuncionarioId,
                        Ano,
                        Mes,
                        DataPrevista,
                        Status,
                        CriadoEm
                    )
                    VALUES
                    (
                        $funcionarioId,
                        $ano,
                        $mes,
                        $dataPrevista,
                        'Pendente',
                        $criadoEm
                    );

                    UPDATE PagamentosFolha
                    SET DataPagamento = $dataPagamento,
                        Status = $status,
                        AtualizadoEm = $atualizado
                    WHERE FuncionarioId = $funcionarioId
                      AND Ano = $ano
                      AND Mes = $mes;
                ";

                DateTime dataPagamento = dtp.Value.Date;
                string status = dataPagamento <= dataPrevista.Date
                    ? "Pago"
                    : "Pago com atraso";

                command.Parameters.AddWithValue("$funcionarioId", funcionarioId);
                command.Parameters.AddWithValue("$ano", ano);
                command.Parameters.AddWithValue("$mes", mes);
                command.Parameters.AddWithValue(
                    "$dataPrevista",
                    dataPrevista.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue(
                    "$dataPagamento",
                    dataPagamento.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("$status", status);
                command.Parameters.AddWithValue(
                    "$criadoEm",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue(
                    "$atualizado",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                command.ExecuteNonQuery();

                CarregarFolha();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível registrar o pagamento.\n\n" +
                    "Erro: " + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimparFolhaInicial()
        {
            dgvFuncionarios.Rows.Clear();

            lblFuncionariosValor.Text = "0";
            lblBrutoValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblDescontosValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblLiquidoValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblHorasValor.Text = "0h";

            lblProcessados.Text = "0 de 0";
            progressProcessados.Value = 0;

            string mes = cmbMes.Text;
            string ano = cmbAno.Text;

            if (string.IsNullOrWhiteSpace(mes))
                mes = "Período não selecionado";

            if (string.IsNullOrWhiteSpace(ano))
                ano = "-";

            if (cmbMes.Text.Length > 0 && cmbAno.Text.Length > 0)
                lblPeriodo.Text = ObterPeriodoTexto(cmbMes.Text, cmbAno.Text);
            else
                lblPeriodo.Text = "-";

            lblGerada.Text = "-";

            lblSituacaoFolha.Text = "●  Não gerada";
            lblSituacaoFolha.ForeColor = Color.FromArgb(195, 55, 55);

            lblObservacoes.Text =
                "Selecione o mês e o ano e clique em Gerar Folha.";

            lblListaTitulo.Text =
                "Funcionários na folha (" + mes + "/" + ano + ")";

            // Placeholder da pesquisa.
            txtPesquisar.Text = "Pesquisar funcionário...";
            txtPesquisar.ForeColor = Color.FromArgb(128, 128, 128);
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
            {
                alterandoPesquisa = true;
                txtPesquisar.Clear();
                txtPesquisar.ForeColor = Color.FromArgb(45, 45, 45);
                alterandoPesquisa = false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (alterandoPesquisa)
                return;

            // O placeholder não é uma pesquisa.
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
                return;

            // Pesquisa em tempo real, mas sem validar período a cada letra.
            // Se mês/ano ainda não estiverem selecionados, apenas não pesquisa.
            if (PeriodoValidoSemMensagem())
                CarregarFolha();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            e.Handled = true;

            // Se ainda estiver com o placeholder, primeiro limpa o campo.
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
            {
                txtPesquisar.Clear();
                txtPesquisar.ForeColor = Color.FromArgb(45, 45, 45);
                return;
            }

            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private bool PeriodoValidoSemMensagem()
        {
            bool mesValido =
                !string.IsNullOrWhiteSpace(cmbMes.Text) &&
                !cmbMes.Text.Equals("Selecione o mês",
                    StringComparison.OrdinalIgnoreCase) &&
                !cmbMes.Text.Equals("Selecione",
                    StringComparison.OrdinalIgnoreCase);

            bool anoValido =
                !string.IsNullOrWhiteSpace(cmbAno.Text) &&
                !cmbAno.Text.Equals("Selecione o ano",
                    StringComparison.OrdinalIgnoreCase) &&
                !cmbAno.Text.Equals("Selecione",
                    StringComparison.OrdinalIgnoreCase);

            return mesValido && anoValido;
        }

        private void CarregarFolha()
        {
            try
            {
                int mes = ObterNumeroMesSelecionado();
                int ano = ObterAnoSelecionado();
                DateTime dataPrevista = ObterDataPagamentoPrevista(ano, mes);

                dgvFuncionarios.Rows.Clear();

                using (SqliteConnection connection = Database.GetConnection())
                {
                    connection.Open();

                    GarantirTabelaPagamentos(connection);

                    GarantirRegistrosPagamento(
                        connection,
                        ano,
                        mes,
                        dataPrevista);

                    string sql = @"
                        SELECT
                            f.Id,
                            f.Nome,
                            f.Cargo,
                            f.Salario,
                            f.Setor,
                            f.Status,
                            COALESCE(
                                (
                                    SELECT SUM(b.ValorDesconto)
                                    FROM BeneficiosFuncionario b
                                    WHERE b.FuncionarioId = f.Id
                                ), 0
                            ) AS TotalDescontos,
                            p.DataPrevista,
                            p.DataPagamento
                        FROM Funcionarios f
                        LEFT JOIN PagamentosFolha p
                            ON p.FuncionarioId = f.Id
                           AND p.Ano = $Ano
                           AND p.Mes = $Mes
                        WHERE 1 = 1
                    ";

                    if (!string.IsNullOrWhiteSpace(txtPesquisar.Text) &&
                        !string.Equals(
                            txtPesquisar.Text,
                            "Pesquisar funcionário...",
                            StringComparison.OrdinalIgnoreCase))
                    {
                        sql += @"
                            AND (
                                COALESCE(f.Nome, '') LIKE $Busca
                                OR COALESCE(f.Cargo, '') LIKE $Busca
                                OR COALESCE(f.Setor, '') LIKE $Busca
                                OR COALESCE(f.Status, '') LIKE $Busca
                                OR CAST(COALESCE(f.Salario, 0) AS TEXT) LIKE $Busca
                                OR '0h' LIKE $Busca
                            ) ";
                    }

                    if (!string.IsNullOrWhiteSpace(cmbDepartamento.Text) &&
                        cmbDepartamento.Text != "Todos os departamentos")
                    {
                        sql += " AND COALESCE(f.Setor, '') = $Departamento ";
                    }

                    if (!string.IsNullOrWhiteSpace(cmbSituacao.Text) &&
                        cmbSituacao.Text != "Todos")
                    {
                        sql += " AND COALESCE(f.Status, '') = $Situacao ";
                    }

                    sql += " ORDER BY f.Nome;";

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        command.Parameters.AddWithValue("$Ano", ano);
                        command.Parameters.AddWithValue("$Mes", mes);

                        if (!string.IsNullOrWhiteSpace(txtPesquisar.Text) &&
                            !string.Equals(
                                txtPesquisar.Text,
                                "Pesquisar funcionário...",
                                StringComparison.OrdinalIgnoreCase))
                        {
                            command.Parameters.AddWithValue(
                                "$Busca",
                                "%" + txtPesquisar.Text.Trim() + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(cmbDepartamento.Text) &&
                            cmbDepartamento.Text != "Todos os departamentos")
                        {
                            command.Parameters.AddWithValue(
                                "$Departamento",
                                cmbDepartamento.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(cmbSituacao.Text) &&
                            cmbSituacao.Text != "Todos")
                        {
                            command.Parameters.AddWithValue(
                                "$Situacao",
                                cmbSituacao.Text);
                        }

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                long funcionarioId =
                                    Convert.ToInt64(reader["Id"]);

                                string nome =
                                    reader["Nome"]?.ToString() ?? "";

                                string cargo =
                                    reader["Cargo"]?.ToString() ?? "";

                                decimal salario =
                                    ConverterDecimal(reader["Salario"]);

                                decimal descontos =
                                    ConverterDecimal(reader["TotalDescontos"]);

                                decimal liquido =
                                    salario - descontos;

                                string statusFuncionario =
                                    reader["Status"]?.ToString() ?? "Ativo";

                                DateTime prevista = dataPrevista;

                                if (DateTime.TryParse(
                                    reader["DataPrevista"]?.ToString(),
                                    out DateTime previstaBanco))
                                {
                                    prevista = previstaBanco.Date;
                                }

                                DateTime? pagamento = null;

                                if (DateTime.TryParse(
                                    reader["DataPagamento"]?.ToString(),
                                    out DateTime dataPagamentoBanco))
                                {
                                    pagamento = dataPagamentoBanco.Date;
                                }

                                string statusPagamento =
                                    ObterStatusPagamento(
                                        prevista,
                                        pagamento);

                                int indice = dgvFuncionarios.Rows.Add(
                                    nome,
                                    cargo,
                                    salario.ToString(
                                        "C2",
                                        CulturaPtBr()),
                                    descontos.ToString(
                                        "C2",
                                        CulturaPtBr()),
                                    liquido.ToString(
                                        "C2",
                                        CulturaPtBr()),
                                    "0h",
                                    statusFuncionario,
                                    statusPagamento
                                );

                                dgvFuncionarios.Rows[indice].Tag =
                                    funcionarioId;

                                DataGridViewCell celulaPagamento =
                                    dgvFuncionarios.Rows[indice]
                                        .Cells["colPagamento"];

                                if (statusPagamento.StartsWith(
                                    "Pago c/",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    celulaPagamento.Style.ForeColor =
                                        Color.FromArgb(230, 126, 34);
                                }
                                else if (statusPagamento.StartsWith(
                                    "Pago",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    celulaPagamento.Style.ForeColor =
                                        Color.FromArgb(0, 145, 75);
                                }
                                else if (statusPagamento.StartsWith(
                                    "Atrasado",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    celulaPagamento.Style.ForeColor =
                                        Color.FromArgb(198, 40, 40);
                                }
                                else
                                {
                                    celulaPagamento.Style.ForeColor =
                                        Color.FromArgb(55, 85, 120);
                                }
                            }
                        }
                    }
                }

                dgvFuncionarios.ClearSelection();
                dgvFuncionarios.CurrentCell = null;

                AtualizarResumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar a folha de pagamento.\n\n" +
                    "Erro: " + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AtualizarResumo()
        {
            int quantidade = dgvFuncionarios.Rows.Count;
            decimal bruto = 0;
            decimal descontos = 0;
            decimal liquido = 0;

            foreach (DataGridViewRow row in dgvFuncionarios.Rows)
            {
                bruto += ConverterDecimal(row.Cells["colSalario"].Value);
                descontos += ConverterDecimal(row.Cells["colDescontos"].Value);
                liquido += ConverterDecimal(row.Cells["colLiquido"].Value);
            }

            lblFuncionariosValor.Text = quantidade.ToString();
            lblBrutoValor.Text = bruto.ToString("C2", CulturaPtBr());
            lblDescontosValor.Text = descontos.ToString("C2", CulturaPtBr());
            lblLiquidoValor.Text = liquido.ToString("C2", CulturaPtBr());

            int horas = quantidade * 0;
            lblHorasValor.Text = horas.ToString() + "h";

            lblProcessados.Text = quantidade + " de " + quantidade;
            progressProcessados.Value = quantidade > 0 ? 100 : 0;

            string mes = cmbMes.Text;
            string ano = cmbAno.Text;

            if (string.IsNullOrWhiteSpace(mes))
                mes = "Setembro";

            if (string.IsNullOrWhiteSpace(ano))
                ano = DateTime.Now.Year.ToString();

            lblPeriodo.Text = ObterPeriodoTexto(mes, ano);
            lblGerada.Text = quantidade > 0
                ? DateTime.Now.ToString("dd/MM/yyyy 'às' HH:mm")
                : "-";

            lblSituacaoFolha.Text = quantidade > 0
                ? "●  Processada"
                : "●  Não gerada";

            lblSituacaoFolha.ForeColor = quantidade > 0
                ? Color.FromArgb(0, 145, 75)
                : Color.FromArgb(195, 55, 55);

            int pagos = 0;
            int pagosComAtraso = 0;
            int atrasados = 0;
            int pendentes = 0;

            foreach (DataGridViewRow row in dgvFuncionarios.Rows)
            {
                string pagamento =
                    row.Cells["colPagamento"].Value?.ToString() ?? "";

                if (pagamento.StartsWith(
                    "Pago c/",
                    StringComparison.OrdinalIgnoreCase))
                    pagosComAtraso++;
                else if (pagamento.StartsWith(
                    "Pago",
                    StringComparison.OrdinalIgnoreCase))
                    pagos++;
                else if (pagamento.StartsWith(
                    "Atrasado",
                    StringComparison.OrdinalIgnoreCase))
                    atrasados++;
                else
                    pendentes++;
            }

            lblObservacoes.Text = quantidade > 0
                ? $"Pagamentos: {pagos} pago(s) • {pagosComAtraso} com atraso(s) • " +
                  $"{atrasados} atrasado(s) • {pendentes} pendente(s)."
                : "Nenhum funcionário encontrado.";

            lblListaTitulo.Text =
                "Funcionários na folha (" + mes + "/" + ano + ")";

        }

        private string ObterPeriodoTexto(string mes, string ano)
        {
            int numeroMes = Array.IndexOf(
                new[]
                {
                    "Janeiro", "Fevereiro", "Março", "Abril",
                    "Maio", "Junho", "Julho", "Agosto",
                    "Setembro", "Outubro", "Novembro", "Dezembro"
                },
                mes) + 1;

            if (numeroMes < 1)
                numeroMes = DateTime.Now.Month;

            if (!int.TryParse(ano, out int numeroAno))
                numeroAno = DateTime.Now.Year;

            DateTime inicio = new DateTime(numeroAno, numeroMes, 1);
            DateTime fim = inicio.AddMonths(1).AddDays(-1);

            return inicio.ToString("dd/MM/yyyy") +
                   " a " +
                   fim.ToString("dd/MM/yyyy");
        }

        private static CultureInfo CulturaPtBr()
        {
            return new CultureInfo("pt-BR");
        }

        private static decimal ConverterDecimal(object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return 0;

            if (valor is decimal decimalValor)
                return decimalValor;

            if (valor is double doubleValor)
                return Convert.ToDecimal(doubleValor);

            if (valor is float floatValor)
                return Convert.ToDecimal(floatValor);

            string texto = valor.ToString();

            if (decimal.TryParse(
                texto,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal resultado))
            {
                return resultado;
            }

            if (decimal.TryParse(
                texto,
                NumberStyles.Any,
                CulturaPtBr(),
                out resultado))
            {
                return resultado;
            }

            return 0;
        }

        private void btnRelatorioSintetico_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeExportar)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para exportar relatórios.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!ValidarPeriodo())
                return;

            if (dgvFuncionarios.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Não há funcionários carregados para gerar o relatório sintético.\n\n" +
                    "Clique em \"Gerar Folha\" ou utilize os filtros antes de gerar o relatório.",
                    "Relatório Sintético",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            ExportarRelatorioPdf("Sintetico");
        }

        private void btnRelatorioAnalitico_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeExportar)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para exportar relatórios.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!ValidarPeriodo())
                return;

            if (dgvFuncionarios.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Não há funcionários carregados para gerar o relatório analítico.\n\n" +
                    "Clique em \"Gerar Folha\" ou utilize os filtros antes de gerar o relatório.",
                    "Relatório Analítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            ExportarRelatorioPdf("Analitico");
        }

        private void ExportarRelatorioPdf(string tipo)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                bool sintetico = tipo.Equals("Sintetico", StringComparison.OrdinalIgnoreCase);

                dialog.Title = sintetico
                    ? "Exportar relatório sintético em PDF"
                    : "Exportar relatório analítico em PDF";

                dialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                dialog.DefaultExt = "pdf";
                dialog.AddExtension = true;
                dialog.FileName =
                    (sintetico ? "Relatorio_Sintetico_Folha_" : "Relatorio_Analitico_Folha_") +
                    DateTime.Now.ToString("yyyy_MM_dd") + ".pdf";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                string impressoraPdf = EncontrarImpressoraPdf();

                if (string.IsNullOrWhiteSpace(impressoraPdf))
                {
                    MessageBox.Show(
                        "A impressora 'Microsoft Print to PDF' não está disponível no Windows.\n\n" +
                        "Ative o recurso Microsoft Print to PDF e tente novamente.",
                        "Exportação para PDF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    tipoRelatorioPdf = tipo;
                    indiceLinhaPdf = 0;
                    paginaPdf = 1;

                    using (PrintDocument documento = new PrintDocument())
                    {
                        documento.DocumentName = Path.GetFileName(dialog.FileName);
                        documento.PrinterSettings.PrinterName = impressoraPdf;
                        documento.PrinterSettings.PrintToFile = true;
                        documento.PrinterSettings.PrintFileName = dialog.FileName;
                        documento.DefaultPageSettings.Landscape = true;
                        documento.DefaultPageSettings.Margins = new Margins(35, 35, 35, 35);
                        documento.PrintPage += Documento_Relatorio_PrintPage;
                        documento.Print();
                    }

                    if (File.Exists(dialog.FileName))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = dialog.FileName,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show(
                            "O Windows não confirmou a criação do arquivo PDF.",
                            "Exportação para PDF",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível gerar o relatório em PDF.\n\n" + ex.Message,
                        "Erro na exportação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    tipoRelatorioPdf = "Folha";
                    indiceLinhaPdf = 0;
                    paginaPdf = 1;
                }
            }
        }

        private void Documento_Relatorio_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (tipoRelatorioPdf.Equals("Sintetico", StringComparison.OrdinalIgnoreCase))
                DesenharRelatorioSintetico(e);
            else
                DesenharRelatorioAnalitico(e);
        }

        private void DesenharCabecalhoRelatorio(
            Graphics g,
            Rectangle area,
            string titulo,
            string subtitulo,
            Color azulEscuro,
            Color azul)
        {
            using (SolidBrush fundo = new SolidBrush(Color.FromArgb(244, 247, 251)))
                g.FillRectangle(fundo, area);

            Rectangle cabecalho = new Rectangle(area.Left, area.Top, area.Width, 78);

            using (SolidBrush brush = new SolidBrush(azulEscuro))
                g.FillRectangle(brush, cabecalho);

            using (SolidBrush brush = new SolidBrush(azul))
                g.FillRectangle(
                    brush,
                    area.Left,
                    area.Top + 74,
                    area.Width,
                    4);

            using (Font fonteTitulo = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (Font fonteSubtitulo = new Font("Segoe UI", 9F))
            using (Font fonteCompetencia = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Font fonteFiltro = new Font("Segoe UI", 7.5F))
            {
                g.DrawString(
                    "RH CONTROL",
                    fonteTitulo,
                    Brushes.White,
                    area.Left + 18,
                    area.Top + 9);

                g.DrawString(
                    subtitulo,
                    fonteSubtitulo,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Left + 20,
                    area.Top + 43);

                string competencia = "Competência: " + cmbMes.Text + "/" + cmbAno.Text;
                SizeF tamanhoCompetencia = g.MeasureString(competencia, fonteCompetencia);

                g.DrawString(
                    competencia,
                    fonteCompetencia,
                    Brushes.White,
                    area.Right - tamanhoCompetencia.Width - 18,
                    area.Top + 19);

                string filtros =
                    "Departamento: " + cmbDepartamento.Text +
                    "  •  Situação: " + cmbSituacao.Text;

                SizeF tamanhoFiltros = g.MeasureString(filtros, fonteFiltro);

                g.DrawString(
                    filtros,
                    fonteFiltro,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Right - tamanhoFiltros.Width - 18,
                    area.Top + 44);
            }
        }

        private void DesenharRelatorioSintetico(PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = e.MarginBounds;

            Color azulEscuro = Color.FromArgb(16, 42, 67);
            Color azul = Color.FromArgb(25, 118, 210);
            Color cinzaTexto = Color.FromArgb(88, 102, 115);
            Color cinzaBorda = Color.FromArgb(220, 226, 232);
            Color verde = Color.FromArgb(0, 145, 75);

            DesenharCabecalhoRelatorio(
                g,
                area,
                "RELATÓRIO SINTÉTICO",
                "FOLHA DE PAGAMENTO",
                azulEscuro,
                azul);

            using (Font secao = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (Font cardTitulo = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font cardValor = new Font("Segoe UI", 15F, FontStyle.Bold))
            using (Font texto = new Font("Segoe UI", 9F))
            using (Font textoNegrito = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Font pequeno = new Font("Segoe UI", 8F))
            {
                float y = area.Top + 105;
                float largura = area.Width;

                g.DrawString(
                    "Resumo da competência",
                    secao,
                    new SolidBrush(azulEscuro),
                    area.Left,
                    y);

                y += 30;

                string[] titulos =
                {
                    "FUNCIONÁRIOS",
                    "SALÁRIO BRUTO",
                    "DESCONTOS",
                    "SALÁRIO LÍQUIDO",
                    "HORAS EXTRAS"
                };

                string[] valores =
                {
                    lblFuncionariosValor.Text,
                    lblBrutoValor.Text,
                    lblDescontosValor.Text,
                    lblLiquidoValor.Text,
                    lblHorasValor.Text
                };

                float espacamento = 12;
                float larguraCard = (largura - (espacamento * 4)) / 5f;
                float alturaCard = 78;

                for (int i = 0; i < titulos.Length; i++)
                {
                    float cardX = area.Left + i * (larguraCard + espacamento);

                    Rectangle card = new Rectangle(
                        (int)cardX,
                        (int)y,
                        (int)larguraCard,
                        (int)alturaCard);

                    using (SolidBrush brush = new SolidBrush(Color.White))
                        g.FillRectangle(brush, card);

                    using (Pen pen = new Pen(cinzaBorda))
                        g.DrawRectangle(pen, card);

                    using (SolidBrush brush = new SolidBrush(azul))
                        g.FillRectangle(
                            brush,
                            card.Left,
                            card.Top,
                            4,
                            card.Height);

                    g.DrawString(
                        titulos[i],
                        cardTitulo,
                        new SolidBrush(cinzaTexto),
                        card.Left + 13,
                        card.Top + 12);

                    g.DrawString(
                        valores[i],
                        cardValor,
                        new SolidBrush(azulEscuro),
                        card.Left + 13,
                        card.Top + 35);
                }

                y += alturaCard + 35;

                Rectangle informacoes = new Rectangle(
                    area.Left,
                    (int)y,
                    area.Width,
                    155);

                using (SolidBrush brush = new SolidBrush(Color.White))
                    g.FillRectangle(brush, informacoes);

                using (Pen pen = new Pen(cinzaBorda))
                    g.DrawRectangle(pen, informacoes);

                using (SolidBrush brush = new SolidBrush(azul))
                    g.FillRectangle(
                        brush,
                        informacoes.Left,
                        informacoes.Top,
                        5,
                        informacoes.Height);

                g.DrawString(
                    "Informações da folha",
                    textoNegrito,
                    new SolidBrush(azulEscuro),
                    informacoes.Left + 18,
                    informacoes.Top + 15);

                g.DrawString(
                    "Período:",
                    textoNegrito,
                    new SolidBrush(cinzaTexto),
                    informacoes.Left + 18,
                    informacoes.Top + 48);

                g.DrawString(
                    lblPeriodo.Text,
                    texto,
                    new SolidBrush(Color.FromArgb(45, 55, 65)),
                    informacoes.Left + 85,
                    informacoes.Top + 48);

                g.DrawString(
                    "Funcionários processados:",
                    textoNegrito,
                    new SolidBrush(cinzaTexto),
                    informacoes.Left + 18,
                    informacoes.Top + 74);

                g.DrawString(
                    lblProcessados.Text,
                    texto,
                    new SolidBrush(Color.FromArgb(45, 55, 65)),
                    informacoes.Left + 175,
                    informacoes.Top + 74);

                g.DrawString(
                    "Situação:",
                    textoNegrito,
                    new SolidBrush(cinzaTexto),
                    informacoes.Left + 18,
                    informacoes.Top + 100);

                g.DrawString(
                    lblSituacaoFolha.Text,
                    texto,
                    new SolidBrush(verde),
                    informacoes.Left + 85,
                    informacoes.Top + 100);

                g.DrawString(
                    "Gerada em:",
                    textoNegrito,
                    new SolidBrush(cinzaTexto),
                    informacoes.Left + 330,
                    informacoes.Top + 100);

                g.DrawString(
                    lblGerada.Text,
                    texto,
                    new SolidBrush(Color.FromArgb(45, 55, 65)),
                    informacoes.Left + 405,
                    informacoes.Top + 100);

                g.DrawString(
                    "Observações:",
                    textoNegrito,
                    new SolidBrush(cinzaTexto),
                    informacoes.Left + 18,
                    informacoes.Top + 126);

                g.DrawString(
                    lblObservacoes.Text,
                    pequeno,
                    new SolidBrush(Color.FromArgb(45, 55, 65)),
                    new RectangleF(
                        informacoes.Left + 105,
                        informacoes.Top + 125,
                        informacoes.Width - 125,
                        20));
            }

            DesenharRodape(
                g,
                area,
                1,
                azulEscuro,
                cinzaTexto);

            e.HasMorePages = false;
        }

        private void DesenharRelatorioAnalitico(PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = e.MarginBounds;

            Color azulEscuro = Color.FromArgb(16, 42, 67);
            Color azul = Color.FromArgb(25, 118, 210);
            Color fundo = Color.FromArgb(244, 247, 251);
            Color cinzaTexto = Color.FromArgb(88, 102, 115);
            Color cinzaBorda = Color.FromArgb(220, 226, 232);
            Color verde = Color.FromArgb(0, 145, 75);

            DesenharCabecalhoRelatorio(
                g,
                area,
                "RELATÓRIO ANALÍTICO",
                "FOLHA DE PAGAMENTO",
                azulEscuro,
                azul);

            using (Font secao = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font cabecalho = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (Font texto = new Font("Segoe UI", 7.5F))
            using (Font textoNegrito = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            {
                float y = area.Top + 105;
                float largura = area.Width;

                g.DrawString(
                    "Detalhamento por funcionário",
                    secao,
                    new SolidBrush(azulEscuro),
                    area.Left,
                    y);

                y += 25;

                string[] cabecalhos =
                {
                    "Funcionário",
                    "Cargo",
                    "Bruto",
                    "Descontos",
                    "Líquido",
                    "Horas extras",
                    "Situação",
                    "Pagamento"
                };

                float[] larguras =
                {
                    175, 145, 100, 100, 100, 90, 95, 115
                };

                float soma = larguras.Sum();

                if (soma > largura)
                {
                    float fator = largura / soma;

                    for (int i = 0; i < larguras.Length; i++)
                        larguras[i] *= fator;
                }

                float x = area.Left;

                using (SolidBrush headerBrush = new SolidBrush(azulEscuro))
                using (SolidBrush headerTextBrush = new SolidBrush(Color.White))
                {
                    for (int i = 0; i < cabecalhos.Length; i++)
                    {
                        g.FillRectangle(
                            headerBrush,
                            x,
                            y,
                            larguras[i],
                            30);

                        g.DrawString(
                            cabecalhos[i],
                            cabecalho,
                            headerTextBrush,
                            new RectangleF(
                                x + 6,
                                y + 7,
                                larguras[i] - 12,
                                18));

                        x += larguras[i];
                    }
                }

                y += 30;

                while (indiceLinhaPdf < dgvFuncionarios.Rows.Count)
                {
                    DataGridViewRow linha = dgvFuncionarios.Rows[indiceLinhaPdf];

                    if (y + 26 > area.Bottom - 35)
                    {
                        DesenharRodape(
                            g,
                            area,
                            paginaPdf,
                            azulEscuro,
                            cinzaTexto);

                        paginaPdf++;
                        e.HasMorePages = true;
                        return;
                    }

                    x = area.Left;

                    using (SolidBrush linhaBrush = new SolidBrush(
                        indiceLinhaPdf % 2 == 0
                            ? Color.White
                            : fundo))
                    using (Pen linhaPen = new Pen(cinzaBorda))
                    {
                        for (int i = 0;
                             i < dgvFuncionarios.Columns.Count &&
                             i < larguras.Length;
                             i++)
                        {
                            string valor =
                                Convert.ToString(linha.Cells[i].Value) ?? "";

                            RectangleF celula = new RectangleF(
                                x,
                                y,
                                larguras[i],
                                26);

                            g.FillRectangle(linhaBrush, celula);
                            g.DrawRectangle(
                                linhaPen,
                                celula.X,
                                celula.Y,
                                celula.Width,
                                celula.Height);

                            bool situacao = i == 6;

                            using (SolidBrush textoBrush = new SolidBrush(
                                situacao &&
                                valor.Equals(
                                    "Ativo",
                                    StringComparison.OrdinalIgnoreCase)
                                    ? verde
                                    : cinzaTexto))
                            {
                                g.DrawString(
                                    valor,
                                    situacao ? textoNegrito : texto,
                                    textoBrush,
                                    new RectangleF(
                                        x + 6,
                                        y + 6,
                                        larguras[i] - 12,
                                        18));
                            }

                            x += larguras[i];
                        }
                    }

                    y += 26;
                    indiceLinhaPdf++;
                }

                y += 20;

                if (y + 70 <= area.Bottom - 30)
                {
                    Rectangle resumo = new Rectangle(
                        area.Left,
                        (int)y,
                        area.Width,
                        65);

                    using (SolidBrush brush = new SolidBrush(Color.White))
                        g.FillRectangle(brush, resumo);

                    using (Pen pen = new Pen(cinzaBorda))
                        g.DrawRectangle(pen, resumo);

                    using (SolidBrush brush = new SolidBrush(azul))
                        g.FillRectangle(
                            brush,
                            resumo.Left,
                            resumo.Top,
                            5,
                            resumo.Height);

                    using (Font titulo = new Font(
                        "Segoe UI",
                        8.5F,
                        FontStyle.Bold))
                    using (Font textoResumo = new Font(
                        "Segoe UI",
                        8F))
                    {
                        g.DrawString(
                            "Resumo",
                            titulo,
                            new SolidBrush(azulEscuro),
                            resumo.Left + 15,
                            resumo.Top + 10);

                        g.DrawString(
                            "Funcionários: " + lblFuncionariosValor.Text +
                            "   •   Bruto: " + lblBrutoValor.Text +
                            "   •   Descontos: " + lblDescontosValor.Text +
                            "   •   Líquido: " + lblLiquidoValor.Text,
                            textoResumo,
                            new SolidBrush(cinzaTexto),
                            resumo.Left + 15,
                            resumo.Top + 34);
                    }
                }
            }

            DesenharRodape(
                g,
                area,
                paginaPdf,
                azulEscuro,
                cinzaTexto);

            e.HasMorePages = false;
            indiceLinhaPdf = 0;
            paginaPdf = 1;
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeExportar)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para exportar relatórios.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Exportar folha de pagamento em PDF";
                dialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                dialog.DefaultExt = "pdf";
                dialog.AddExtension = true;
                dialog.FileName = "Folha_Pagamento_" +
                                  DateTime.Now.ToString("yyyy_MM_dd") + ".pdf";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                string impressoraPdf = EncontrarImpressoraPdf();

                if (string.IsNullOrWhiteSpace(impressoraPdf))
                {
                    MessageBox.Show(
                        "A impressora 'Microsoft Print to PDF' não está disponível no Windows.\n\n" +
                        "Ative o recurso Microsoft Print to PDF e tente novamente.",
                        "Exportação para PDF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    indiceLinhaPdf = 0;
                    paginaPdf = 1;

                    using (PrintDocument documento = new PrintDocument())
                    {
                        documento.DocumentName = Path.GetFileName(dialog.FileName);
                        documento.PrinterSettings.PrinterName = impressoraPdf;
                        documento.PrinterSettings.PrintToFile = true;
                        documento.PrinterSettings.PrintFileName = dialog.FileName;
                        documento.DefaultPageSettings.Landscape = true;
                        documento.DefaultPageSettings.Margins =
                            new Margins(35, 35, 35, 35);
                        documento.PrintPage += Documento_PrintPage;

                        documento.Print();
                    }

                    if (File.Exists(dialog.FileName))
                    {
                        // Abre automaticamente o PDF no visualizador padrão do Windows.
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = dialog.FileName,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show(
                            "O Windows não confirmou a criação do arquivo PDF.",
                            "Exportação para PDF",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível exportar a folha para PDF.\n\n" +
                        ex.Message,
                        "Erro na exportação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string EncontrarImpressoraPdf()
        {
            foreach (string nome in PrinterSettings.InstalledPrinters)
            {
                if (nome.IndexOf(
                    "Microsoft Print to PDF",
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return nome;
                }
            }

            return null;
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = e.MarginBounds;

            Color azulEscuro = Color.FromArgb(16, 42, 67);   // #102A43
            Color azul = Color.FromArgb(25, 118, 210);      // #1976D2
            Color fundo = Color.FromArgb(244, 247, 251);   // #F4F7FB
            Color cinzaTexto = Color.FromArgb(88, 102, 115);
            Color cinzaBorda = Color.FromArgb(220, 226, 232);
            Color verde = Color.FromArgb(0, 145, 75);

            using (Font titulo = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (Font subtitulo = new Font("Segoe UI", 9F))
            using (Font secao = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font cardTitulo = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (Font cardValor = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font cabecalho = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font texto = new Font("Segoe UI", 8F))
            using (Font textoNegrito = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font pequeno = new Font("Segoe UI", 7.5F))
            {
                float x = area.Left;
                float y = area.Top;
                float largura = area.Width;

                // Fundo geral
                using (SolidBrush fundoBrush = new SolidBrush(fundo))
                    g.FillRectangle(fundoBrush, area);

                // =====================================================
                // CABEÇALHO RH CONTROL
                // =====================================================
                Rectangle cabecalhoRect = new Rectangle(
                    area.Left, (int)y, area.Width, 78);

                using (SolidBrush brush = new SolidBrush(azulEscuro))
                    g.FillRectangle(brush, cabecalhoRect);

                using (SolidBrush brush = new SolidBrush(azul))
                    g.FillRectangle(brush,
                        area.Left, (int)y + 74, area.Width, 4);

                g.DrawString(
                    "RH CONTROL",
                    titulo,
                    Brushes.White,
                    area.Left + 18,
                    y + 10);

                g.DrawString(
                    "FOLHA DE PAGAMENTO",
                    subtitulo,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Left + 20,
                    y + 43);

                string competencia =
                    "Competência: " + cmbMes.Text + "/" + cmbAno.Text;

                string filtros =
                    "Departamento: " + cmbDepartamento.Text +
                    "  •  Situação: " + cmbSituacao.Text;

                SizeF tamanhoCompetencia =
                    g.MeasureString(competencia, subtitulo);

                g.DrawString(
                    competencia,
                    subtitulo,
                    Brushes.White,
                    area.Right - tamanhoCompetencia.Width - 18,
                    y + 20);

                SizeF tamanhoFiltros =
                    g.MeasureString(filtros, pequeno);

                g.DrawString(
                    filtros,
                    pequeno,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Right - tamanhoFiltros.Width - 18,
                    y + 45);

                y += 98;

                // =====================================================
                // TÍTULO DA COMPETÊNCIA
                // =====================================================
                g.DrawString(
                    "Resumo da folha",
                    secao,
                    new SolidBrush(azulEscuro),
                    x,
                    y);

                y += 24;

                // =====================================================
                // CARDS
                // =====================================================
                float espacoCard = 10;
                float larguraCard = (largura - (espacoCard * 4)) / 5f;
                float alturaCard = 62;

                string[] cardTitulos =
                {
                    "FUNCIONÁRIOS",
                    "SALÁRIO BRUTO",
                    "DESCONTOS",
                    "SALÁRIO LÍQUIDO",
                    "HORAS EXTRAS"
                };

                string[] cardValores =
                {
                    lblFuncionariosValor.Text,
                    lblBrutoValor.Text,
                    lblDescontosValor.Text,
                    lblLiquidoValor.Text,
                    lblHorasValor.Text
                };

                for (int i = 0; i < 5; i++)
                {
                    float cardX = x + i * (larguraCard + espacoCard);

                    Rectangle cardRect = new Rectangle(
                        (int)cardX,
                        (int)y,
                        (int)larguraCard,
                        (int)alturaCard);

                    using (SolidBrush brush = new SolidBrush(Color.White))
                        g.FillRectangle(brush, cardRect);

                    using (Pen pen = new Pen(cinzaBorda))
                        g.DrawRectangle(pen, cardRect);

                    using (SolidBrush brush = new SolidBrush(azul))
                        g.FillRectangle(
                            brush,
                            cardRect.Left,
                            cardRect.Top,
                            4,
                            cardRect.Height);

                    g.DrawString(
                        cardTitulos[i],
                        cardTitulo,
                        new SolidBrush(cinzaTexto),
                        cardRect.Left + 12,
                        cardRect.Top + 9);

                    g.DrawString(
                        cardValores[i],
                        cardValor,
                        new SolidBrush(azulEscuro),
                        cardRect.Left + 12,
                        cardRect.Top + 29);
                }

                y += alturaCard + 26;

                // =====================================================
                // TABELA
                // =====================================================
                g.DrawString(
                    "Funcionários processados",
                    secao,
                    new SolidBrush(azulEscuro),
                    x,
                    y);

                y += 24;

                string[] cabecalhos =
                {
                    "Funcionário", "Cargo", "Bruto", "Descontos",
                    "Líquido", "Horas extras", "Situação", "Pagamento"
                };

                float[] larguras =
                {
                    165, 140, 100, 100, 100, 90, 95, 110
                };

                // Ajusta proporcionalmente se a soma ultrapassar a área.
                float somaLarguras = 0;
                foreach (float w in larguras)
                    somaLarguras += w;

                if (somaLarguras > largura)
                {
                    float fator = largura / somaLarguras;
                    for (int i = 0; i < larguras.Length; i++)
                        larguras[i] *= fator;
                }

                x = area.Left;

                using (SolidBrush headerBrush = new SolidBrush(azulEscuro))
                using (SolidBrush headerTextBrush = new SolidBrush(Color.White))
                {
                    for (int i = 0; i < cabecalhos.Length; i++)
                    {
                        g.FillRectangle(
                            headerBrush,
                            x,
                            y,
                            larguras[i],
                            28);

                        g.DrawString(
                            cabecalhos[i],
                            cabecalho,
                            headerTextBrush,
                            new RectangleF(
                                x + 6,
                                y + 6,
                                larguras[i] - 12,
                                20));

                        x += larguras[i];
                    }
                }

                y += 28;

                while (indiceLinhaPdf < dgvFuncionarios.Rows.Count)
                {
                    DataGridViewRow linha =
                        dgvFuncionarios.Rows[indiceLinhaPdf];

                    if (y + 25 > area.Bottom - 45)
                    {
                        DesenharRodape(g, area, paginaPdf, azulEscuro, cinzaTexto);
                        paginaPdf++;
                        e.HasMorePages = true;
                        return;
                    }

                    x = area.Left;

                    using (SolidBrush linhaBrush =
                           new SolidBrush(
                               indiceLinhaPdf % 2 == 0
                                   ? Color.White
                                   : Color.FromArgb(248, 250, 252)))
                    using (Pen linhaPen = new Pen(cinzaBorda))
                    {
                        for (int i = 0;
                             i < dgvFuncionarios.Columns.Count &&
                             i < larguras.Length;
                             i++)
                        {
                            string valor =
                                Convert.ToString(linha.Cells[i].Value) ?? "";

                            RectangleF celula = new RectangleF(
                                x,
                                y,
                                larguras[i],
                                25);

                            g.FillRectangle(linhaBrush, celula);
                            g.DrawRectangle(
                                linhaPen,
                                celula.X,
                                celula.Y,
                                celula.Width,
                                celula.Height);

                            bool situacao =
                                i == 7 &&
                                !string.IsNullOrWhiteSpace(valor);

                            Brush textoBrush =
                                situacao &&
                                valor.Equals("Ativo",
                                    StringComparison.OrdinalIgnoreCase)
                                    ? new SolidBrush(verde)
                                    : new SolidBrush(cinzaTexto);

                            Font fonteCelula =
                                situacao
                                    ? textoNegrito
                                    : texto;

                            g.DrawString(
                                valor,
                                fonteCelula,
                                textoBrush,
                                new RectangleF(
                                    x + 6,
                                    y + 5,
                                    larguras[i] - 12,
                                    17));

                            textoBrush.Dispose();
                            x += larguras[i];
                        }
                    }

                    y += 25;
                    indiceLinhaPdf++;
                }

                // =====================================================
                // RESUMO FINAL
                // =====================================================
                y += 18;

                float resumoAltura = 68;

                if (y + resumoAltura > area.Bottom - 40)
                {
                    DesenharRodape(g, area, paginaPdf, azulEscuro, cinzaTexto);
                    paginaPdf++;
                    e.HasMorePages = true;
                    return;
                }

                Rectangle resumoRect = new Rectangle(
                    area.Left,
                    (int)y,
                    area.Width,
                    (int)resumoAltura);

                using (SolidBrush brush = new SolidBrush(Color.White))
                    g.FillRectangle(brush, resumoRect);

                using (Pen pen = new Pen(cinzaBorda))
                    g.DrawRectangle(pen, resumoRect);

                using (SolidBrush brush = new SolidBrush(azul))
                    g.FillRectangle(
                        brush,
                        resumoRect.Left,
                        resumoRect.Top,
                        5,
                        resumoRect.Height);

                g.DrawString(
                    "Informações do processamento",
                    textoNegrito,
                    new SolidBrush(azulEscuro),
                    resumoRect.Left + 16,
                    resumoRect.Top + 9);

                g.DrawString(
                    "Período: " + lblPeriodo.Text +
                    "   •   Processados: " + lblProcessados.Text,
                    pequeno,
                    new SolidBrush(cinzaTexto),
                    resumoRect.Left + 16,
                    resumoRect.Top + 29);

                g.DrawString(
                    "Situação: " + lblSituacaoFolha.Text +
                    "   •   Gerada em: " + lblGerada.Text,
                    pequeno,
                    new SolidBrush(cinzaTexto),
                    resumoRect.Left + 16,
                    resumoRect.Top + 46);

                DesenharRodape(
                    g,
                    area,
                    paginaPdf,
                    azulEscuro,
                    cinzaTexto);

                e.HasMorePages = false;
                indiceLinhaPdf = 0;
                paginaPdf = 1;
            }
        }

        private void DesenharRodape(
            Graphics g,
            Rectangle area,
            int pagina,
            Color azulEscuro,
            Color cinzaTexto)
        {
            using (Font rodape = new Font("Segoe UI", 7F))
            using (Pen linha = new Pen(Color.FromArgb(220, 226, 232)))
            using (SolidBrush texto = new SolidBrush(cinzaTexto))
            using (SolidBrush marca = new SolidBrush(azulEscuro))
            {
                float y = area.Bottom - 24;

                g.DrawLine(
                    linha,
                    area.Left,
                    y,
                    area.Right,
                    y);

                g.DrawString(
                    "RH CONTROL • Gestão de Pessoas",
                    rodape,
                    marca,
                    area.Left,
                    y + 7);

                string paginaTexto = "Página " + pagina;

                SizeF tamanho =
                    g.MeasureString(paginaTexto, rodape);

                g.DrawString(
                    paginaTexto,
                    rodape,
                    texto,
                    area.Right - tamanho.Width,
                    y + 7);
            }
        }
    }
}
