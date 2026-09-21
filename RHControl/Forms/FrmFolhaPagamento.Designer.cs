using System.Drawing;
using System.Windows.Forms;

namespace RHControl.Forms
{
    partial class FrmFolhaPagamento
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlMenu;
        private PictureBox picLogo;
        private Label lblNomeSistema;
        private Label lblSubtituloMenu;
        private Button btnDashboard;
        private Button btnFuncionarios;
        private Button btnJornada;
        private Button btnFolha;
        private Button btnConfiguracoes;
        private Button btnSair;
        private Label lblVersao;

        private Panel pnlConteudo;
        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;

        private Panel pnlFiltros;
        private Label lblMes;
        private Label lblAno;
        private Label lblDepartamento;
        private Label lblSituacaoFiltro;
        private ComboBox cmbMes;
        private ComboBox cmbAno;
        private ComboBox cmbDepartamento;
        private ComboBox cmbSituacao;
        private Button btnFiltrar;

        private Panel pnlCardFuncionarios;
        private Panel pnlCardBruto;
        private Panel pnlCardDescontos;
        private Panel pnlCardLiquido;
        private Panel pnlCardHoras;

        private Label lblIconFuncionarios;
        private Label lblIconBruto;
        private Label lblIconDescontos;
        private Label lblIconLiquido;
        private Label lblIconHoras;

        private Label lblCardFuncionariosTitulo;
        private Label lblFuncionariosValor;
        private Label lblFuncionariosInfo;
        private Label lblCardBrutoTitulo;
        private Label lblBrutoValor;
        private Label lblBrutoInfo;
        private Label lblCardDescontosTitulo;
        private Label lblDescontosValor;
        private Label lblDescontosInfo;
        private Label lblCardLiquidoTitulo;
        private Label lblLiquidoValor;
        private Label lblLiquidoInfo;
        private Label lblCardHorasTitulo;
        private Label lblHorasValor;
        private Label lblHorasInfo;

        private Panel pnlLista;
        private Label lblListaTitulo;
        private TextBox txtPesquisar;
        private DataGridView dgvFuncionarios;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCargo;
        private DataGridViewTextBoxColumn colSalario;
        private DataGridViewTextBoxColumn colDescontos;
        private DataGridViewTextBoxColumn colLiquido;
        private DataGridViewTextBoxColumn colHorasExtras;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPagamento;

        private Panel pnlResumo;
        private Label lblResumoTitulo;
        private Label lblPeriodoTitulo;
        private Label lblPeriodo;
        private Label lblProcessadosTitulo;
        private Label lblProcessados;
        private ProgressBar progressProcessados;
        private Label lblGeradaTitulo;
        private Label lblGerada;
        private Label lblSituacaoTitulo;
        private Label lblSituacaoFolha;
        private Label lblObservacoesTitulo;
        private Label lblObservacoes;

        private Panel pnlAcoes;
        private Button btnGerarFolha;
        private Button btnRelatorioSintetico;
        private Button btnRelatorioAnalitico;
        private Button btnImprimir;
        private Button btnRegistrarPagamento;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblNomeSistema = new Label();
            lblSubtituloMenu = new Label();
            btnDashboard = new Button();
            btnFuncionarios = new Button();
            btnJornada = new Button();
            btnFolha = new Button();
            btnConfiguracoes = new Button();
            btnSair = new Button();
            lblVersao = new Label();
            pnlConteudo = new Panel();
            pnlAcoes = new Panel();
            btnGerarFolha = new Button();
            btnRelatorioSintetico = new Button();
            btnRelatorioAnalitico = new Button();
            btnImprimir = new Button();
            btnRegistrarPagamento = new Button();
            pnlLista = new Panel();
            dgvFuncionarios = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colCargo = new DataGridViewTextBoxColumn();
            colSalario = new DataGridViewTextBoxColumn();
            colDescontos = new DataGridViewTextBoxColumn();
            colLiquido = new DataGridViewTextBoxColumn();
            colHorasExtras = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPagamento = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            lblListaTitulo = new Label();
            pnlResumo = new Panel();
            lblResumoTitulo = new Label();
            lblPeriodoTitulo = new Label();
            lblPeriodo = new Label();
            lblProcessadosTitulo = new Label();
            lblProcessados = new Label();
            progressProcessados = new ProgressBar();
            lblGeradaTitulo = new Label();
            lblGerada = new Label();
            lblSituacaoTitulo = new Label();
            lblSituacaoFolha = new Label();
            lblObservacoesTitulo = new Label();
            lblObservacoes = new Label();
            pnlCardHoras = new Panel();
            lblHorasInfo = new Label();
            lblHorasValor = new Label();
            lblCardHorasTitulo = new Label();
            lblIconHoras = new Label();
            pnlCardLiquido = new Panel();
            lblLiquidoInfo = new Label();
            lblLiquidoValor = new Label();
            lblCardLiquidoTitulo = new Label();
            lblIconLiquido = new Label();
            pnlCardDescontos = new Panel();
            lblDescontosInfo = new Label();
            lblDescontosValor = new Label();
            lblCardDescontosTitulo = new Label();
            lblIconDescontos = new Label();
            pnlCardBruto = new Panel();
            lblBrutoInfo = new Label();
            lblBrutoValor = new Label();
            lblCardBrutoTitulo = new Label();
            lblIconBruto = new Label();
            pnlCardFuncionarios = new Panel();
            lblFuncionariosInfo = new Label();
            lblFuncionariosValor = new Label();
            lblCardFuncionariosTitulo = new Label();
            lblIconFuncionarios = new Label();
            pnlFiltros = new Panel();
            lblMes = new Label();
            lblAno = new Label();
            lblDepartamento = new Label();
            lblSituacaoFiltro = new Label();
            cmbMes = new ComboBox();
            cmbAno = new ComboBox();
            cmbDepartamento = new ComboBox();
            cmbSituacao = new ComboBox();
            btnFiltrar = new Button();
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlConteudo.SuspendLayout();
            pnlAcoes.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            pnlResumo.SuspendLayout();
            pnlCardHoras.SuspendLayout();
            pnlCardLiquido.SuspendLayout();
            pnlCardDescontos.SuspendLayout();
            pnlCardBruto.SuspendLayout();
            pnlCardFuncionarios.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(10, 30, 50);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblNomeSistema);
            pnlMenu.Controls.Add(lblSubtituloMenu);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnFuncionarios);
            pnlMenu.Controls.Add(btnJornada);
            pnlMenu.Controls.Add(btnFolha);
            pnlMenu.Controls.Add(btnConfiguracoes);
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Controls.Add(lblVersao);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(245, 760);
            pnlMenu.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.logorh;
            picLogo.Location = new Point(69, 36);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(110, 86);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.Font = new Font("Segoe UI Semibold", 17F);
            lblNomeSistema.ForeColor = Color.White;
            lblNomeSistema.Location = new Point(25, 126);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(198, 32);
            lblNomeSistema.TabIndex = 1;
            lblNomeSistema.Text = "RH CONTROL";
            lblNomeSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloMenu
            // 
            lblSubtituloMenu.Font = new Font("Segoe UI", 8F);
            lblSubtituloMenu.ForeColor = Color.FromArgb(205, 224, 240);
            lblSubtituloMenu.Location = new Point(25, 154);
            lblSubtituloMenu.Name = "lblSubtituloMenu";
            lblSubtituloMenu.Size = new Size(198, 22);
            lblSubtituloMenu.TabIndex = 2;
            lblSubtituloMenu.Text = "GESTÃO DE PESSOAS";
            lblSubtituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(10, 30, 50);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.FromArgb(235, 242, 248);
            btnDashboard.Location = new Point(18, 210);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(18, 0, 0, 0);
            btnDashboard.Size = new Size(209, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "⌂   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(10, 30, 50);
            btnFuncionarios.Cursor = Cursors.Hand;
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Segoe UI", 9F);
            btnFuncionarios.ForeColor = Color.FromArgb(235, 242, 248);
            btnFuncionarios.Location = new Point(18, 263);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(18, 0, 0, 0);
            btnFuncionarios.Size = new Size(209, 45);
            btnFuncionarios.TabIndex = 4;
            btnFuncionarios.Text = "♙   Funcionários";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnJornada
            // 
            btnJornada.BackColor = Color.FromArgb(10, 30, 50);
            btnJornada.Cursor = Cursors.Hand;
            btnJornada.FlatAppearance.BorderSize = 0;
            btnJornada.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnJornada.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            btnJornada.FlatStyle = FlatStyle.Flat;
            btnJornada.Font = new Font("Segoe UI", 9F);
            btnJornada.ForeColor = Color.FromArgb(235, 242, 248);
            btnJornada.Location = new Point(18, 316);
            btnJornada.Name = "btnJornada";
            btnJornada.Padding = new Padding(18, 0, 0, 0);
            btnJornada.Size = new Size(209, 45);
            btnJornada.TabIndex = 5;
            btnJornada.Text = "▣   Jornada / Calendário";
            btnJornada.TextAlign = ContentAlignment.MiddleLeft;
            btnJornada.UseVisualStyleBackColor = false;
            // 
            // btnFolha
            // 
            btnFolha.BackColor = Color.FromArgb(18, 126, 255);
            btnFolha.Cursor = Cursors.Hand;
            btnFolha.FlatAppearance.BorderSize = 0;
            btnFolha.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnFolha.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            btnFolha.FlatStyle = FlatStyle.Flat;
            btnFolha.Font = new Font("Segoe UI", 9F);
            btnFolha.ForeColor = Color.White;
            btnFolha.Location = new Point(18, 369);
            btnFolha.Name = "btnFolha";
            btnFolha.Padding = new Padding(18, 0, 0, 0);
            btnFolha.Size = new Size(209, 45);
            btnFolha.TabIndex = 6;
            btnFolha.Text = "▤   Folha / Relatórios";
            btnFolha.TextAlign = ContentAlignment.MiddleLeft;
            btnFolha.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.FromArgb(10, 30, 50);
            btnConfiguracoes.Cursor = Cursors.Hand;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Segoe UI", 9F);
            btnConfiguracoes.ForeColor = Color.FromArgb(235, 242, 248);
            btnConfiguracoes.Location = new Point(18, 422);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(18, 0, 0, 0);
            btnConfiguracoes.Size = new Size(209, 45);
            btnConfiguracoes.TabIndex = 7;
            btnConfiguracoes.Text = "⚙   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(10, 30, 50);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 58, 88);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(18, 650);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(18, 0, 0, 0);
            btnSair.Size = new Size(209, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "↪   Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // lblVersao
            // 
            lblVersao.Dock = DockStyle.Bottom;
            lblVersao.Font = new Font("Segoe UI", 8F);
            lblVersao.ForeColor = Color.FromArgb(190, 211, 228);
            lblVersao.Location = new Point(25, 725);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(248, 45);
            lblVersao.TabIndex = 8;
            lblVersao.Text = "RH Control • v1.0";
            lblVersao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(244, 247, 251);
            pnlConteudo.Controls.Add(pnlAcoes);
            pnlConteudo.Controls.Add(pnlLista);
            pnlConteudo.Controls.Add(pnlResumo);
            pnlConteudo.Controls.Add(pnlCardHoras);
            pnlConteudo.Controls.Add(pnlCardLiquido);
            pnlConteudo.Controls.Add(pnlCardDescontos);
            pnlConteudo.Controls.Add(pnlCardBruto);
            pnlConteudo.Controls.Add(pnlCardFuncionarios);
            pnlConteudo.Controls.Add(pnlFiltros);
            pnlConteudo.Controls.Add(pnlCabecalho);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(245, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Padding = new Padding(22, 0, 18, 16);
            pnlConteudo.Size = new Size(955, 760);
            pnlConteudo.TabIndex = 0;
            // 
            // pnlAcoes
            // 
            pnlAcoes.BackColor = Color.White;
            pnlAcoes.BorderStyle = BorderStyle.FixedSingle;
            pnlAcoes.Controls.Add(btnGerarFolha);
            pnlAcoes.Controls.Add(btnRelatorioSintetico);
            pnlAcoes.Controls.Add(btnRelatorioAnalitico);
            pnlAcoes.Controls.Add(btnImprimir);
            pnlAcoes.Controls.Add(btnRegistrarPagamento);
            pnlAcoes.Dock = DockStyle.Bottom;
            pnlAcoes.Location = new Point(22, 690);
            pnlAcoes.Name = "pnlAcoes";
            pnlAcoes.Padding = new Padding(10);
            pnlAcoes.Size = new Size(1005, 74);
            pnlAcoes.TabIndex = 0;
            // 
            // btnGerarFolha
            // 
            btnGerarFolha.BackColor = Color.FromArgb(31, 126, 215);
            btnGerarFolha.Cursor = Cursors.Hand;
            btnGerarFolha.FlatAppearance.BorderColor = Color.FromArgb(31, 126, 215);
            btnGerarFolha.FlatStyle = FlatStyle.Flat;
            btnGerarFolha.Font = new Font("Segoe UI Semibold", 8.5F);
            btnGerarFolha.ForeColor = Color.White;
            btnGerarFolha.Location = new Point(10, 10);
            btnGerarFolha.Name = "btnGerarFolha";
            btnGerarFolha.Size = new Size(160, 38);
            btnGerarFolha.TabIndex = 0;
            btnGerarFolha.Text = "▣  Gerar Folha";
            btnGerarFolha.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioSintetico
            // 
            btnRelatorioSintetico.BackColor = Color.White;
            btnRelatorioSintetico.Cursor = Cursors.Hand;
            btnRelatorioSintetico.FlatAppearance.BorderColor = Color.FromArgb(205, 216, 227);
            btnRelatorioSintetico.FlatStyle = FlatStyle.Flat;
            btnRelatorioSintetico.Font = new Font("Segoe UI Semibold", 8.5F);
            btnRelatorioSintetico.ForeColor = Color.FromArgb(31, 91, 145);
            btnRelatorioSintetico.Location = new Point(180, 10);
            btnRelatorioSintetico.Name = "btnRelatorioSintetico";
            btnRelatorioSintetico.Size = new Size(155, 38);
            btnRelatorioSintetico.TabIndex = 1;
            btnRelatorioSintetico.Text = "■  Relatório Sintético";
            btnRelatorioSintetico.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioAnalitico
            // 
            btnRelatorioAnalitico.BackColor = Color.White;
            btnRelatorioAnalitico.Cursor = Cursors.Hand;
            btnRelatorioAnalitico.FlatAppearance.BorderColor = Color.FromArgb(205, 216, 227);
            btnRelatorioAnalitico.FlatStyle = FlatStyle.Flat;
            btnRelatorioAnalitico.Font = new Font("Segoe UI Semibold", 8.5F);
            btnRelatorioAnalitico.ForeColor = Color.FromArgb(31, 91, 145);
            btnRelatorioAnalitico.Location = new Point(345, 10);
            btnRelatorioAnalitico.Name = "btnRelatorioAnalitico";
            btnRelatorioAnalitico.Size = new Size(160, 38);
            btnRelatorioAnalitico.TabIndex = 2;
            btnRelatorioAnalitico.Text = "▤  Relatório Analítico";
            btnRelatorioAnalitico.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.White;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderColor = Color.FromArgb(205, 216, 227);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 8.5F);
            btnImprimir.ForeColor = Color.FromArgb(31, 91, 145);
            btnImprimir.Location = new Point(515, 10);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(170, 38);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "⇩  Exportar PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnExportarPdf_Click;
            // 
            // btnRegistrarPagamento
            // 
            btnRegistrarPagamento.BackColor = Color.FromArgb(18, 126, 255);
            btnRegistrarPagamento.Cursor = Cursors.Hand;
            btnRegistrarPagamento.FlatAppearance.BorderColor = Color.FromArgb(18, 126, 255);
            btnRegistrarPagamento.FlatStyle = FlatStyle.Flat;
            btnRegistrarPagamento.Font = new Font("Segoe UI Semibold", 8.5F);
            btnRegistrarPagamento.ForeColor = Color.White;
            btnRegistrarPagamento.Location = new Point(695, 10);
            btnRegistrarPagamento.Name = "btnRegistrarPagamento";
            btnRegistrarPagamento.Size = new Size(170, 38);
            btnRegistrarPagamento.TabIndex = 4;
            btnRegistrarPagamento.Text = "✓  Registrar pagamento";
            btnRegistrarPagamento.UseVisualStyleBackColor = false;
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.BorderStyle = BorderStyle.FixedSingle;
            pnlLista.Controls.Add(dgvFuncionarios);
            pnlLista.Controls.Add(txtPesquisar);
            pnlLista.Controls.Add(lblListaTitulo);
            pnlLista.Location = new Point(22, 330);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(650, 320);
            pnlLista.TabIndex = 1;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AllowUserToResizeRows = false;
            dgvFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvFuncionarios.BackgroundColor = Color.White;
            dgvFuncionarios.BorderStyle = BorderStyle.None;
            dgvFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 68, 82);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFuncionarios.ColumnHeadersHeight = 34;
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colNome, colCargo, colSalario, colDescontos, colLiquido, colHorasExtras, colStatus, colPagamento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 55, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 55, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFuncionarios.Location = new Point(14, 48);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersVisible = false;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(631, 270);
            dgvFuncionarios.TabIndex = 0;
            // 
            // colNome
            // 
            colNome.HeaderText = "Funcionário";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 110;
            // 
            // colCargo
            // 
            colCargo.HeaderText = "Cargo";
            colCargo.Name = "colCargo";
            colCargo.ReadOnly = true;
            colCargo.Width = 90;
            // 
            // colSalario
            // 
            colSalario.HeaderText = "Bruto";
            colSalario.Name = "colSalario";
            colSalario.ReadOnly = true;
            colSalario.Width = 70;
            // 
            // colDescontos
            // 
            colDescontos.HeaderText = "Descontos";
            colDescontos.Name = "colDescontos";
            colDescontos.ReadOnly = true;
            colDescontos.Width = 70;
            // 
            // colLiquido
            // 
            colLiquido.HeaderText = "Líquido";
            colLiquido.Name = "colLiquido";
            colLiquido.ReadOnly = true;
            colLiquido.Width = 70;
            // 
            // colHorasExtras
            // 
            colHorasExtras.HeaderText = "Horas extras";
            colHorasExtras.Name = "colHorasExtras";
            colHorasExtras.ReadOnly = true;
            colHorasExtras.Width = 60;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Situação";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 70;
            // 
            // colPagamento
            // 
            colPagamento.HeaderText = "Pagamento";
            colPagamento.Name = "colPagamento";
            colPagamento.ReadOnly = true;
            colPagamento.Width = 105;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPesquisar.ForeColor = Color.Gray;
            txtPesquisar.Location = new Point(429, 13);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(205, 23);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.Text = "Pesquisar funcionário...";
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.AutoSize = true;
            lblListaTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblListaTitulo.ForeColor = Color.FromArgb(20, 55, 87);
            lblListaTitulo.Location = new Point(18, 15);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(294, 21);
            lblListaTitulo.TabIndex = 2;
            lblListaTitulo.Text = "Funcionários na folha (Setembro/2026)";
            // 
            // pnlResumo
            // 
            pnlResumo.BackColor = Color.White;
            pnlResumo.BorderStyle = BorderStyle.FixedSingle;
            pnlResumo.Controls.Add(lblResumoTitulo);
            pnlResumo.Controls.Add(lblPeriodoTitulo);
            pnlResumo.Controls.Add(lblPeriodo);
            pnlResumo.Controls.Add(lblProcessadosTitulo);
            pnlResumo.Controls.Add(lblProcessados);
            pnlResumo.Controls.Add(progressProcessados);
            pnlResumo.Controls.Add(lblGeradaTitulo);
            pnlResumo.Controls.Add(lblGerada);
            pnlResumo.Controls.Add(lblSituacaoTitulo);
            pnlResumo.Controls.Add(lblSituacaoFolha);
            pnlResumo.Controls.Add(lblObservacoesTitulo);
            pnlResumo.Controls.Add(lblObservacoes);
            pnlResumo.Location = new Point(686, 330);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(251, 320);
            pnlResumo.TabIndex = 2;
            // 
            // lblResumoTitulo
            // 
            lblResumoTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblResumoTitulo.ForeColor = Color.FromArgb(18, 77, 125);
            lblResumoTitulo.Location = new Point(18, 14);
            lblResumoTitulo.Name = "lblResumoTitulo";
            lblResumoTitulo.Size = new Size(225, 20);
            lblResumoTitulo.TabIndex = 0;
            lblResumoTitulo.Text = "Resumo do período";
            // 
            // lblPeriodoTitulo
            // 
            lblPeriodoTitulo.Font = new Font("Segoe UI", 7.5F);
            lblPeriodoTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblPeriodoTitulo.Location = new Point(18, 46);
            lblPeriodoTitulo.Name = "lblPeriodoTitulo";
            lblPeriodoTitulo.Size = new Size(225, 15);
            lblPeriodoTitulo.TabIndex = 1;
            lblPeriodoTitulo.Text = "Período de referência";
            // 
            // lblPeriodo
            // 
            lblPeriodo.Font = new Font("Segoe UI Semibold", 8.5F);
            lblPeriodo.ForeColor = Color.FromArgb(18, 77, 125);
            lblPeriodo.Location = new Point(18, 62);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(225, 20);
            lblPeriodo.TabIndex = 2;
            lblPeriodo.Text = "01/09/2026 a 30/09/2026";
            // 
            // lblProcessadosTitulo
            // 
            lblProcessadosTitulo.Font = new Font("Segoe UI", 7.5F);
            lblProcessadosTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblProcessadosTitulo.Location = new Point(18, 91);
            lblProcessadosTitulo.Name = "lblProcessadosTitulo";
            lblProcessadosTitulo.Size = new Size(225, 15);
            lblProcessadosTitulo.TabIndex = 3;
            lblProcessadosTitulo.Text = "Funcionários processados";
            // 
            // lblProcessados
            // 
            lblProcessados.Font = new Font("Segoe UI Semibold", 8.5F);
            lblProcessados.ForeColor = Color.FromArgb(18, 77, 125);
            lblProcessados.Location = new Point(18, 107);
            lblProcessados.Name = "lblProcessados";
            lblProcessados.Size = new Size(225, 20);
            lblProcessados.TabIndex = 4;
            lblProcessados.Text = "25 de 25";
            // 
            // progressProcessados
            // 
            progressProcessados.Location = new Point(18, 126);
            progressProcessados.Name = "progressProcessados";
            progressProcessados.Size = new Size(215, 8);
            progressProcessados.TabIndex = 5;
            progressProcessados.Value = 100;
            // 
            // lblGeradaTitulo
            // 
            lblGeradaTitulo.Font = new Font("Segoe UI", 7.5F);
            lblGeradaTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblGeradaTitulo.Location = new Point(18, 150);
            lblGeradaTitulo.Name = "lblGeradaTitulo";
            lblGeradaTitulo.Size = new Size(225, 15);
            lblGeradaTitulo.TabIndex = 6;
            lblGeradaTitulo.Text = "Folha gerada em";
            // 
            // lblGerada
            // 
            lblGerada.Font = new Font("Segoe UI Semibold", 8.5F);
            lblGerada.ForeColor = Color.FromArgb(18, 77, 125);
            lblGerada.Location = new Point(18, 166);
            lblGerada.Name = "lblGerada";
            lblGerada.Size = new Size(225, 20);
            lblGerada.TabIndex = 7;
            lblGerada.Text = "28/09/2026 às 14:32";
            // 
            // lblSituacaoTitulo
            // 
            lblSituacaoTitulo.Font = new Font("Segoe UI", 7.5F);
            lblSituacaoTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblSituacaoTitulo.Location = new Point(18, 196);
            lblSituacaoTitulo.Name = "lblSituacaoTitulo";
            lblSituacaoTitulo.Size = new Size(225, 15);
            lblSituacaoTitulo.TabIndex = 8;
            lblSituacaoTitulo.Text = "Situação da folha";
            // 
            // lblSituacaoFolha
            // 
            lblSituacaoFolha.Font = new Font("Segoe UI Semibold", 8.5F);
            lblSituacaoFolha.ForeColor = Color.FromArgb(0, 145, 75);
            lblSituacaoFolha.Location = new Point(18, 212);
            lblSituacaoFolha.Name = "lblSituacaoFolha";
            lblSituacaoFolha.Size = new Size(225, 20);
            lblSituacaoFolha.TabIndex = 9;
            lblSituacaoFolha.Text = "●  Processada";
            // 
            // lblObservacoesTitulo
            // 
            lblObservacoesTitulo.Font = new Font("Segoe UI", 7.5F);
            lblObservacoesTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblObservacoesTitulo.Location = new Point(18, 238);
            lblObservacoesTitulo.Name = "lblObservacoesTitulo";
            lblObservacoesTitulo.Size = new Size(225, 15);
            lblObservacoesTitulo.TabIndex = 10;
            lblObservacoesTitulo.Text = "Observações";
            // 
            // lblObservacoes
            // 
            lblObservacoes.Font = new Font("Segoe UI Semibold", 7.5F);
            lblObservacoes.ForeColor = Color.FromArgb(35, 55, 75);
            lblObservacoes.Location = new Point(18, 250);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(215, 55);
            lblObservacoes.TabIndex = 11;
            lblObservacoes.Text = "Folha processada sem inconsistências.";
            // 
            // pnlCardHoras
            // 
            pnlCardHoras.BackColor = Color.White;
            pnlCardHoras.BorderStyle = BorderStyle.FixedSingle;
            pnlCardHoras.Controls.Add(lblHorasInfo);
            pnlCardHoras.Controls.Add(lblHorasValor);
            pnlCardHoras.Controls.Add(lblCardHorasTitulo);
            pnlCardHoras.Controls.Add(lblIconHoras);
            pnlCardHoras.Location = new Point(762, 202);
            pnlCardHoras.Name = "pnlCardHoras";
            pnlCardHoras.Size = new Size(175, 108);
            pnlCardHoras.TabIndex = 3;
            // 
            // lblHorasInfo
            // 
            lblHorasInfo.Font = new Font("Segoe UI", 7.5F);
            lblHorasInfo.ForeColor = Color.FromArgb(115, 125, 138);
            lblHorasInfo.Location = new Point(12, 77);
            lblHorasInfo.Name = "lblHorasInfo";
            lblHorasInfo.Size = new Size(126, 18);
            lblHorasInfo.TabIndex = 0;
            lblHorasInfo.Text = "Total no período";
            // 
            // lblHorasValor
            // 
            lblHorasValor.AutoEllipsis = true;
            lblHorasValor.Font = new Font("Segoe UI Semibold", 11F);
            lblHorasValor.ForeColor = Color.FromArgb(18, 77, 125);
            lblHorasValor.Location = new Point(58, 34);
            lblHorasValor.Name = "lblHorasValor";
            lblHorasValor.Size = new Size(82, 24);
            lblHorasValor.TabIndex = 1;
            lblHorasValor.Text = "320h";
            // 
            // lblCardHorasTitulo
            // 
            lblCardHorasTitulo.Font = new Font("Segoe UI", 7.5F);
            lblCardHorasTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblCardHorasTitulo.Location = new Point(58, 15);
            lblCardHorasTitulo.Name = "lblCardHorasTitulo";
            lblCardHorasTitulo.Size = new Size(82, 18);
            lblCardHorasTitulo.TabIndex = 2;
            lblCardHorasTitulo.Text = "Horas extras";
            // 
            // lblIconHoras
            // 
            lblIconHoras.BackColor = Color.FromArgb(235, 243, 252);
            lblIconHoras.Font = new Font("Segoe UI Semibold", 13F);
            lblIconHoras.ForeColor = Color.FromArgb(20, 105, 185);
            lblIconHoras.Location = new Point(12, 16);
            lblIconHoras.Name = "lblIconHoras";
            lblIconHoras.Size = new Size(38, 38);
            lblIconHoras.TabIndex = 3;
            lblIconHoras.Text = "◷";
            lblIconHoras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCardLiquido
            // 
            pnlCardLiquido.BackColor = Color.White;
            pnlCardLiquido.BorderStyle = BorderStyle.FixedSingle;
            pnlCardLiquido.Controls.Add(lblLiquidoInfo);
            pnlCardLiquido.Controls.Add(lblLiquidoValor);
            pnlCardLiquido.Controls.Add(lblCardLiquidoTitulo);
            pnlCardLiquido.Controls.Add(lblIconLiquido);
            pnlCardLiquido.Location = new Point(577, 202);
            pnlCardLiquido.Name = "pnlCardLiquido";
            pnlCardLiquido.Size = new Size(175, 108);
            pnlCardLiquido.TabIndex = 4;
            // 
            // lblLiquidoInfo
            // 
            lblLiquidoInfo.Font = new Font("Segoe UI", 7.5F);
            lblLiquidoInfo.ForeColor = Color.FromArgb(115, 125, 138);
            lblLiquidoInfo.Location = new Point(12, 77);
            lblLiquidoInfo.Name = "lblLiquidoInfo";
            lblLiquidoInfo.Size = new Size(126, 18);
            lblLiquidoInfo.TabIndex = 0;
            lblLiquidoInfo.Text = "Total a pagar";
            // 
            // lblLiquidoValor
            // 
            lblLiquidoValor.AutoEllipsis = true;
            lblLiquidoValor.Font = new Font("Segoe UI Semibold", 11F);
            lblLiquidoValor.ForeColor = Color.FromArgb(18, 77, 125);
            lblLiquidoValor.Location = new Point(58, 34);
            lblLiquidoValor.Name = "lblLiquidoValor";
            lblLiquidoValor.Size = new Size(82, 24);
            lblLiquidoValor.TabIndex = 1;
            lblLiquidoValor.Text = "R$ 69.130,00";
            // 
            // lblCardLiquidoTitulo
            // 
            lblCardLiquidoTitulo.Font = new Font("Segoe UI", 7.5F);
            lblCardLiquidoTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblCardLiquidoTitulo.Location = new Point(58, 15);
            lblCardLiquidoTitulo.Name = "lblCardLiquidoTitulo";
            lblCardLiquidoTitulo.Size = new Size(82, 18);
            lblCardLiquidoTitulo.TabIndex = 2;
            lblCardLiquidoTitulo.Text = "Salário líquido";
            // 
            // lblIconLiquido
            // 
            lblIconLiquido.BackColor = Color.FromArgb(235, 243, 252);
            lblIconLiquido.Font = new Font("Segoe UI Semibold", 13F);
            lblIconLiquido.ForeColor = Color.FromArgb(20, 105, 185);
            lblIconLiquido.Location = new Point(12, 16);
            lblIconLiquido.Name = "lblIconLiquido";
            lblIconLiquido.Size = new Size(38, 38);
            lblIconLiquido.TabIndex = 3;
            lblIconLiquido.Text = "▣";
            lblIconLiquido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCardDescontos
            // 
            pnlCardDescontos.BackColor = Color.White;
            pnlCardDescontos.BorderStyle = BorderStyle.FixedSingle;
            pnlCardDescontos.Controls.Add(lblDescontosInfo);
            pnlCardDescontos.Controls.Add(lblDescontosValor);
            pnlCardDescontos.Controls.Add(lblCardDescontosTitulo);
            pnlCardDescontos.Controls.Add(lblIconDescontos);
            pnlCardDescontos.Location = new Point(392, 202);
            pnlCardDescontos.Name = "pnlCardDescontos";
            pnlCardDescontos.Size = new Size(175, 108);
            pnlCardDescontos.TabIndex = 5;
            // 
            // lblDescontosInfo
            // 
            lblDescontosInfo.Font = new Font("Segoe UI", 7.5F);
            lblDescontosInfo.ForeColor = Color.FromArgb(115, 125, 138);
            lblDescontosInfo.Location = new Point(12, 77);
            lblDescontosInfo.Name = "lblDescontosInfo";
            lblDescontosInfo.Size = new Size(126, 18);
            lblDescontosInfo.TabIndex = 0;
            lblDescontosInfo.Text = "Total de descontos";
            // 
            // lblDescontosValor
            // 
            lblDescontosValor.AutoEllipsis = true;
            lblDescontosValor.Font = new Font("Segoe UI Semibold", 11F);
            lblDescontosValor.ForeColor = Color.FromArgb(195, 55, 55);
            lblDescontosValor.Location = new Point(58, 34);
            lblDescontosValor.Name = "lblDescontosValor";
            lblDescontosValor.Size = new Size(82, 24);
            lblDescontosValor.TabIndex = 1;
            lblDescontosValor.Text = "R$ 18.320,00";
            // 
            // lblCardDescontosTitulo
            // 
            lblCardDescontosTitulo.Font = new Font("Segoe UI", 7.5F);
            lblCardDescontosTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblCardDescontosTitulo.Location = new Point(58, 15);
            lblCardDescontosTitulo.Name = "lblCardDescontosTitulo";
            lblCardDescontosTitulo.Size = new Size(82, 18);
            lblCardDescontosTitulo.TabIndex = 2;
            lblCardDescontosTitulo.Text = "Descontos";
            // 
            // lblIconDescontos
            // 
            lblIconDescontos.BackColor = Color.FromArgb(235, 243, 252);
            lblIconDescontos.Font = new Font("Segoe UI Semibold", 13F);
            lblIconDescontos.ForeColor = Color.FromArgb(20, 105, 185);
            lblIconDescontos.Location = new Point(12, 16);
            lblIconDescontos.Name = "lblIconDescontos";
            lblIconDescontos.Size = new Size(38, 38);
            lblIconDescontos.TabIndex = 3;
            lblIconDescontos.Text = "−";
            lblIconDescontos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCardBruto
            // 
            pnlCardBruto.BackColor = Color.White;
            pnlCardBruto.BorderStyle = BorderStyle.FixedSingle;
            pnlCardBruto.Controls.Add(lblBrutoInfo);
            pnlCardBruto.Controls.Add(lblBrutoValor);
            pnlCardBruto.Controls.Add(lblCardBrutoTitulo);
            pnlCardBruto.Controls.Add(lblIconBruto);
            pnlCardBruto.Location = new Point(207, 202);
            pnlCardBruto.Name = "pnlCardBruto";
            pnlCardBruto.Size = new Size(175, 108);
            pnlCardBruto.TabIndex = 6;
            // 
            // lblBrutoInfo
            // 
            lblBrutoInfo.Font = new Font("Segoe UI", 7.5F);
            lblBrutoInfo.ForeColor = Color.FromArgb(115, 125, 138);
            lblBrutoInfo.Location = new Point(12, 77);
            lblBrutoInfo.Name = "lblBrutoInfo";
            lblBrutoInfo.Size = new Size(126, 18);
            lblBrutoInfo.TabIndex = 0;
            lblBrutoInfo.Text = "Total de proventos";
            // 
            // lblBrutoValor
            // 
            lblBrutoValor.AutoEllipsis = true;
            lblBrutoValor.Font = new Font("Segoe UI Semibold", 11F);
            lblBrutoValor.ForeColor = Color.FromArgb(18, 77, 125);
            lblBrutoValor.Location = new Point(58, 34);
            lblBrutoValor.Name = "lblBrutoValor";
            lblBrutoValor.Size = new Size(82, 24);
            lblBrutoValor.TabIndex = 1;
            lblBrutoValor.Text = "R$ 87.450,00";
            // 
            // lblCardBrutoTitulo
            // 
            lblCardBrutoTitulo.Font = new Font("Segoe UI", 7.5F);
            lblCardBrutoTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblCardBrutoTitulo.Location = new Point(58, 15);
            lblCardBrutoTitulo.Name = "lblCardBrutoTitulo";
            lblCardBrutoTitulo.Size = new Size(82, 18);
            lblCardBrutoTitulo.TabIndex = 2;
            lblCardBrutoTitulo.Text = "Salário bruto";
            // 
            // lblIconBruto
            // 
            lblIconBruto.BackColor = Color.FromArgb(235, 243, 252);
            lblIconBruto.Font = new Font("Segoe UI Semibold", 13F);
            lblIconBruto.ForeColor = Color.FromArgb(20, 105, 185);
            lblIconBruto.Location = new Point(12, 16);
            lblIconBruto.Name = "lblIconBruto";
            lblIconBruto.Size = new Size(38, 38);
            lblIconBruto.TabIndex = 3;
            lblIconBruto.Text = "$";
            lblIconBruto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCardFuncionarios
            // 
            pnlCardFuncionarios.BackColor = Color.White;
            pnlCardFuncionarios.BorderStyle = BorderStyle.FixedSingle;
            pnlCardFuncionarios.Controls.Add(lblFuncionariosInfo);
            pnlCardFuncionarios.Controls.Add(lblFuncionariosValor);
            pnlCardFuncionarios.Controls.Add(lblCardFuncionariosTitulo);
            pnlCardFuncionarios.Controls.Add(lblIconFuncionarios);
            pnlCardFuncionarios.Location = new Point(22, 202);
            pnlCardFuncionarios.Name = "pnlCardFuncionarios";
            pnlCardFuncionarios.Size = new Size(175, 108);
            pnlCardFuncionarios.TabIndex = 7;
            // 
            // lblFuncionariosInfo
            // 
            lblFuncionariosInfo.Font = new Font("Segoe UI", 7.5F);
            lblFuncionariosInfo.ForeColor = Color.FromArgb(115, 125, 138);
            lblFuncionariosInfo.Location = new Point(12, 77);
            lblFuncionariosInfo.Name = "lblFuncionariosInfo";
            lblFuncionariosInfo.Size = new Size(126, 18);
            lblFuncionariosInfo.TabIndex = 0;
            lblFuncionariosInfo.Text = "Ativos no período";
            // 
            // lblFuncionariosValor
            // 
            lblFuncionariosValor.AutoEllipsis = true;
            lblFuncionariosValor.Font = new Font("Segoe UI Semibold", 11F);
            lblFuncionariosValor.ForeColor = Color.FromArgb(18, 77, 125);
            lblFuncionariosValor.Location = new Point(58, 34);
            lblFuncionariosValor.Name = "lblFuncionariosValor";
            lblFuncionariosValor.Size = new Size(82, 24);
            lblFuncionariosValor.TabIndex = 1;
            lblFuncionariosValor.Text = "25";
            // 
            // lblCardFuncionariosTitulo
            // 
            lblCardFuncionariosTitulo.Font = new Font("Segoe UI", 7.5F);
            lblCardFuncionariosTitulo.ForeColor = Color.FromArgb(105, 116, 130);
            lblCardFuncionariosTitulo.Location = new Point(58, 15);
            lblCardFuncionariosTitulo.Name = "lblCardFuncionariosTitulo";
            lblCardFuncionariosTitulo.Size = new Size(82, 18);
            lblCardFuncionariosTitulo.TabIndex = 2;
            lblCardFuncionariosTitulo.Text = "Funcionários";
            // 
            // lblIconFuncionarios
            // 
            lblIconFuncionarios.BackColor = Color.FromArgb(235, 243, 252);
            lblIconFuncionarios.Font = new Font("Segoe UI Semibold", 13F);
            lblIconFuncionarios.ForeColor = Color.FromArgb(20, 105, 185);
            lblIconFuncionarios.Location = new Point(12, 16);
            lblIconFuncionarios.Name = "lblIconFuncionarios";
            lblIconFuncionarios.Size = new Size(38, 38);
            lblIconFuncionarios.TabIndex = 3;
            lblIconFuncionarios.Text = "♙";
            lblIconFuncionarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(lblMes);
            pnlFiltros.Controls.Add(lblAno);
            pnlFiltros.Controls.Add(lblDepartamento);
            pnlFiltros.Controls.Add(lblSituacaoFiltro);
            pnlFiltros.Controls.Add(cmbMes);
            pnlFiltros.Controls.Add(cmbAno);
            pnlFiltros.Controls.Add(cmbDepartamento);
            pnlFiltros.Controls.Add(cmbSituacao);
            pnlFiltros.Controls.Add(btnFiltrar);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(22, 92);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Padding = new Padding(18, 12, 12, 10);
            pnlFiltros.Size = new Size(1005, 92);
            pnlFiltros.TabIndex = 8;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Segoe UI Semibold", 8F);
            lblMes.ForeColor = Color.FromArgb(75, 88, 102);
            lblMes.Location = new Point(18, 10);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(28, 13);
            lblMes.TabIndex = 0;
            lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI Semibold", 8F);
            lblAno.ForeColor = Color.FromArgb(75, 88, 102);
            lblAno.Location = new Point(178, 10);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(27, 13);
            lblAno.TabIndex = 1;
            lblAno.Text = "Ano";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI Semibold", 8F);
            lblDepartamento.ForeColor = Color.FromArgb(75, 88, 102);
            lblDepartamento.Location = new Point(328, 10);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(81, 13);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento";
            // 
            // lblSituacaoFiltro
            // 
            lblSituacaoFiltro.AutoSize = true;
            lblSituacaoFiltro.Font = new Font("Segoe UI Semibold", 8F);
            lblSituacaoFiltro.ForeColor = Color.FromArgb(75, 88, 102);
            lblSituacaoFiltro.Location = new Point(550, 10);
            lblSituacaoFiltro.Name = "lblSituacaoFiltro";
            lblSituacaoFiltro.Size = new Size(50, 13);
            lblSituacaoFiltro.TabIndex = 3;
            lblSituacaoFiltro.Text = "Situação";
            // 
            // cmbMes
            // 
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.Font = new Font("Segoe UI", 8.5F);
            cmbMes.Items.AddRange(new object[] { "Setembro" });
            cmbMes.Location = new Point(18, 32);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(128, 21);
            cmbMes.TabIndex = 4;
            // 
            // cmbAno
            // 
            cmbAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAno.Font = new Font("Segoe UI", 8.5F);
            cmbAno.Items.AddRange(new object[] { "2026" });
            cmbAno.Location = new Point(178, 32);
            cmbAno.Name = "cmbAno";
            cmbAno.Size = new Size(110, 21);
            cmbAno.TabIndex = 5;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Font = new Font("Segoe UI", 8.5F);
            cmbDepartamento.Items.AddRange(new object[] { "Todos os departamentos" });
            cmbDepartamento.Location = new Point(328, 32);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(195, 21);
            cmbDepartamento.TabIndex = 6;
            // 
            // cmbSituacao
            // 
            cmbSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSituacao.Font = new Font("Segoe UI", 8.5F);
            cmbSituacao.Items.AddRange(new object[] { "Todos" });
            cmbSituacao.Location = new Point(550, 32);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new Size(160, 21);
            cmbSituacao.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(31, 126, 215);
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI Semibold", 9F);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(725, 30);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(105, 38);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "⌕  Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblUsuario);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(22, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1005, 92);
            pnlCabecalho.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 24F);
            lblTitulo.ForeColor = Color.FromArgb(15, 56, 92);
            lblTitulo.Location = new Point(24, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Folha de Pagamento";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(105, 118, 132);
            lblSubtitulo.Location = new Point(26, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(327, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Processamento da folha, relatórios e informações financeiras";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = false;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9F);
            lblUsuario.ForeColor = Color.FromArgb(18, 103, 181);
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            lblUsuario.Location = new Point(760, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(170, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "♙  Administrador";
            // 
            // FrmFolhaPagamento
            // 
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1200, 760);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 720);
            Name = "FrmFolhaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha de Pagamento — RH Control";
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlConteudo.ResumeLayout(false);
            pnlAcoes.ResumeLayout(false);
            pnlLista.ResumeLayout(false);
            pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlCardHoras.ResumeLayout(false);
            pnlCardLiquido.ResumeLayout(false);
            pnlCardDescontos.ResumeLayout(false);
            pnlCardBruto.ResumeLayout(false);
            pnlCardFuncionarios.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ResumeLayout(false);
        }

    }
}
