namespace RHControl.Forms
{
    partial class FrmConfiguracoes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picLogoSistema;
        private System.Windows.Forms.Label lblRhControl;
        private System.Windows.Forms.Label lblGestaoPessoas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Button btnFolha;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnSair;

        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Panel pnlIconeTitulo;
        private System.Windows.Forms.Label lblIconeConfiguracoes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblAdministrador;

        private System.Windows.Forms.Panel pnlAbas;
        private System.Windows.Forms.Button btnAbaEmpresa;
        private System.Windows.Forms.Button btnAbaFolha;
        private System.Windows.Forms.Button btnAbaSistema;
        private System.Windows.Forms.Button btnAbaUsuario;
        private System.Windows.Forms.Button btnAbaBackup;

        private System.Windows.Forms.Panel pnlAreaConteudo;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Panel pnlFolha;
        private System.Windows.Forms.Panel pnlSistema;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlBackup;

        private System.Windows.Forms.Panel pnlFolhaGeral;
        private System.Windows.Forms.Label lblIconeFolha;
        private System.Windows.Forms.Label lblTituloFolha;
        private System.Windows.Forms.Label lblDescricaoFolha;
        private System.Windows.Forms.Label lblDiaPagamento;
        private System.Windows.Forms.NumericUpDown nudDiaPagamento;
        private System.Windows.Forms.Label lblDiaAdiantamento;
        private System.Windows.Forms.NumericUpDown nudDiaAdiantamento;
        private System.Windows.Forms.Label lblPercentualAdiantamento;
        private System.Windows.Forms.NumericUpDown nudPercentualAdiantamento;
        private System.Windows.Forms.Label lblDescontoVA;
        private System.Windows.Forms.NumericUpDown nudDescontoVA;
        private System.Windows.Forms.Label lblDescontoPlano;
        private System.Windows.Forms.NumericUpDown nudDescontoPlano;
        private System.Windows.Forms.Label lblDescontoVT;
        private System.Windows.Forms.NumericUpDown nudDescontoVT;
        private System.Windows.Forms.Label lblBeneficioAdicional;
        private System.Windows.Forms.TextBox txtBeneficioAdicional;
        private System.Windows.Forms.Label lblValorBeneficio;
        private System.Windows.Forms.NumericUpDown nudValorBeneficio;
        private System.Windows.Forms.Label lblTipoBeneficio;
        private System.Windows.Forms.RadioButton rdbBeneficioPercentual;
        private System.Windows.Forms.RadioButton rdbBeneficioValor;
        private System.Windows.Forms.Label lblDescontoAdicional;
        private System.Windows.Forms.TextBox txtDescontoAdicional;
        private System.Windows.Forms.Label lblValorDescontoAdicional;
        private System.Windows.Forms.NumericUpDown nudValorDescontoAdicional;
        private System.Windows.Forms.Label lblTipoDescontoAdicional;
        private System.Windows.Forms.RadioButton rdbDescontoPercentual;
        private System.Windows.Forms.RadioButton rdbDescontoValor;
        private System.Windows.Forms.Panel pnlTributos;
        private System.Windows.Forms.Label lblTributos;
        private System.Windows.Forms.Label lblDescricaoTributos;
        private System.Windows.Forms.CheckBox chkCalcularINSS;
        private System.Windows.Forms.CheckBox chkCalcularIRRF;
        private System.Windows.Forms.Panel pnlInfoFolha;
        private System.Windows.Forms.Label lblInfoFolha;
        private System.Windows.Forms.Label lblTextoInfoFolha;

        private System.Windows.Forms.Panel pnlResumoFolha;
        private System.Windows.Forms.Label lblIconeResumo;
        private System.Windows.Forms.Label lblTituloResumo;
        private System.Windows.Forms.Label lblDescricaoResumo;
        private System.Windows.Forms.DataGridView dgvResumoFolha;
        private System.Windows.Forms.Button btnEditarResumo;
        private System.Windows.Forms.Button btnExcluirResumo;
        private System.Windows.Forms.Label lblOrientacaoResumo;

        private System.Windows.Forms.Panel pnlDadosEmpresa;
        private System.Windows.Forms.Label lblIconeDados;
        private System.Windows.Forms.Label lblDadosEmpresa;
        private System.Windows.Forms.Label lblDescricaoDados;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;

        private System.Windows.Forms.Panel pnlImportante;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblImportante;
        private System.Windows.Forms.Label lblTextoImportante;

        private System.Windows.Forms.Panel pnlLogoEmpresa;
        private System.Windows.Forms.Label lblIconeLogo;
        private System.Windows.Forms.Label lblLogoEmpresa;
        private System.Windows.Forms.Label lblDescricaoLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSelecionarLogo;
        private System.Windows.Forms.Button btnRemoverLogo;
        private System.Windows.Forms.Label lblFormatoLogo;

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Label lblIconeInformacoes;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Label lblDescricaoInformacoes;
        private System.Windows.Forms.Label lblInscricaoEstadual;
        private System.Windows.Forms.TextBox txtInscricaoEstadual;
        private System.Windows.Forms.Label lblInscricaoMunicipal;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;

        // Usuário
        private System.Windows.Forms.Panel pnlUsuarioCabecalho;
        private System.Windows.Forms.Label lblIconeUsuario;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblDescricaoUsuario;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnInativarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Label lblOrientacaoUsuario;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            pnlSidebar = new Panel();
            btnSair = new Button();
            lblVersao = new Label();
            btnConfiguracoes = new Button();
            btnFolha = new Button();
            btnJornada = new Button();
            btnFuncionarios = new Button();
            btnDashboard = new Button();
            lblGestaoPessoas = new Label();
            lblRhControl = new Label();
            picLogoSistema = new PictureBox();
            pnlConteudo = new Panel();
            btnSalvar = new Button();
            btnCancelar = new Button();
            pnlAreaConteudo = new Panel();
            pnlUsuario = new Panel();
            lblOrientacaoUsuario = new Label();
            btnExcluirUsuario = new Button();
            btnInativarUsuario = new Button();
            btnEditarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            btnNovaConta = new Button();
            pnlUsuarioCabecalho = new Panel();
            lblDescricaoUsuario = new Label();
            lblTituloUsuario = new Label();
            lblIconeUsuario = new Label();
            pnlFolha = new Panel();
            pnlResumoFolha = new Panel();
            btnExcluirResumo = new Button();
            btnEditarResumo = new Button();
            lblOrientacaoResumo = new Label();
            dgvResumoFolha = new DataGridView();
            lblDescricaoResumo = new Label();
            lblTituloResumo = new Label();
            lblIconeResumo = new Label();
            pnlInfoFolha = new Panel();
            lblTextoInfoFolha = new Label();
            lblInfoFolha = new Label();
            pnlFolhaGeral = new Panel();
            nudDescontoVT = new NumericUpDown();
            lblDescontoVT = new Label();
            nudValorDescontoAdicional = new NumericUpDown();
            lblValorDescontoAdicional = new Label();
            rdbDescontoValor = new RadioButton();
            rdbDescontoPercentual = new RadioButton();
            lblTipoDescontoAdicional = new Label();
            txtDescontoAdicional = new TextBox();
            lblDescontoAdicional = new Label();
            nudValorBeneficio = new NumericUpDown();
            lblValorBeneficio = new Label();
            rdbBeneficioValor = new RadioButton();
            rdbBeneficioPercentual = new RadioButton();
            lblTipoBeneficio = new Label();
            txtBeneficioAdicional = new TextBox();
            lblBeneficioAdicional = new Label();
            nudDescontoPlano = new NumericUpDown();
            lblDescontoPlano = new Label();
            nudDescontoVA = new NumericUpDown();
            lblDescontoVA = new Label();
            nudPercentualAdiantamento = new NumericUpDown();
            lblPercentualAdiantamento = new Label();
            nudDiaAdiantamento = new NumericUpDown();
            lblDiaAdiantamento = new Label();
            nudDiaPagamento = new NumericUpDown();
            lblDiaPagamento = new Label();
            lblDescricaoFolha = new Label();
            lblTituloFolha = new Label();
            lblIconeFolha = new Label();
            pnlTributos = new Panel();
            chkCalcularIRRF = new CheckBox();
            chkCalcularINSS = new CheckBox();
            lblDescricaoTributos = new Label();
            lblTributos = new Label();
            pnlEmpresa = new Panel();
            pnlInformacoes = new Panel();
            txtSite = new TextBox();
            lblSite = new Label();
            txtInscricaoMunicipal = new TextBox();
            lblInscricaoMunicipal = new Label();
            txtInscricaoEstadual = new TextBox();
            lblInscricaoEstadual = new Label();
            lblDescricaoInformacoes = new Label();
            lblInformacoes = new Label();
            lblIconeInformacoes = new Label();
            pnlLogoEmpresa = new Panel();
            lblFormatoLogo = new Label();
            btnRemoverLogo = new Button();
            btnSelecionarLogo = new Button();
            picLogo = new PictureBox();
            lblDescricaoLogo = new Label();
            lblLogoEmpresa = new Label();
            lblIconeLogo = new Label();
            pnlDadosEmpresa = new Panel();
            pnlImportante = new Panel();
            lblTextoImportante = new Label();
            lblImportante = new Label();
            lblInfo = new Label();
            lblCep = new Label();
            txtCep = new TextBox();
            lblUf = new Label();
            cmbUf = new ComboBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblCnpj = new Label();
            txtCnpj = new TextBox();
            lblNomeEmpresa = new Label();
            txtNomeEmpresa = new TextBox();
            lblDescricaoDados = new Label();
            lblDadosEmpresa = new Label();
            lblIconeDados = new Label();
            pnlAbas = new Panel();
            btnAbaBackup = new Button();
            btnAbaUsuario = new Button();
            btnAbaFolha = new Button();
            btnAbaEmpresa = new Button();
            pnlCabecalho = new Panel();
            lblAdministrador = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlIconeTitulo = new Panel();
            lblIconeConfiguracoes = new Label();
            btnAbaSistema = new Button();
            pnlSistema = new Panel();
            pnlBackup = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoSistema).BeginInit();
            pnlConteudo.SuspendLayout();
            pnlAreaConteudo.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlUsuarioCabecalho.SuspendLayout();
            pnlFolha.SuspendLayout();
            pnlResumoFolha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumoFolha).BeginInit();
            pnlInfoFolha.SuspendLayout();
            pnlFolhaGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescontoVT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValorDescontoAdicional).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValorBeneficio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescontoPlano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescontoVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPercentualAdiantamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiaAdiantamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiaPagamento).BeginInit();
            pnlTributos.SuspendLayout();
            pnlEmpresa.SuspendLayout();
            pnlInformacoes.SuspendLayout();
            pnlLogoEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlDadosEmpresa.SuspendLayout();
            pnlImportante.SuspendLayout();
            pnlAbas.SuspendLayout();
            pnlCabecalho.SuspendLayout();
            pnlIconeTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(10, 30, 50);
            pnlSidebar.Controls.Add(btnSair);
            pnlSidebar.Controls.Add(lblVersao);
            pnlSidebar.Controls.Add(btnConfiguracoes);
            pnlSidebar.Controls.Add(btnFolha);
            pnlSidebar.Controls.Add(btnJornada);
            pnlSidebar.Controls.Add(btnFuncionarios);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblGestaoPessoas);
            pnlSidebar.Controls.Add(lblRhControl);
            pnlSidebar.Controls.Add(picLogoSistema);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(248, 760);
            pnlSidebar.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(10, 30, 50);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(12, 650);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(224, 42);
            btnSair.TabIndex = 0;
            btnSair.Text = "↪   Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // lblVersao
            // 
            lblVersao.Anchor = AnchorStyles.Bottom;
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 8.5F);
            lblVersao.ForeColor = Color.FromArgb(190, 205, 220);
            lblVersao.Location = new Point(76, 728);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(107, 15);
            lblVersao.TabIndex = 1;
            lblVersao.Text = "RH Control • v1.0.0";
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.FromArgb(18, 126, 255);
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.Location = new Point(12, 422);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(224, 42);
            btnConfiguracoes.TabIndex = 2;
            btnConfiguracoes.Text = "⚙   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // btnFolha
            // 
            btnFolha.BackColor = Color.FromArgb(10, 30, 50);
            btnFolha.FlatAppearance.BorderSize = 0;
            btnFolha.FlatStyle = FlatStyle.Flat;
            btnFolha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFolha.ForeColor = Color.White;
            btnFolha.Location = new Point(12, 370);
            btnFolha.Name = "btnFolha";
            btnFolha.Size = new Size(224, 42);
            btnFolha.TabIndex = 3;
            btnFolha.Text = "▤   Folha / Relatórios";
            btnFolha.TextAlign = ContentAlignment.MiddleLeft;
            btnFolha.UseVisualStyleBackColor = false;
            // 
            // btnJornada
            // 
            btnJornada.BackColor = Color.FromArgb(10, 30, 50);
            btnJornada.FlatAppearance.BorderSize = 0;
            btnJornada.FlatStyle = FlatStyle.Flat;
            btnJornada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnJornada.ForeColor = Color.White;
            btnJornada.Location = new Point(12, 318);
            btnJornada.Name = "btnJornada";
            btnJornada.Size = new Size(224, 42);
            btnJornada.TabIndex = 4;
            btnJornada.Text = "▣   Jornada / Calendário";
            btnJornada.TextAlign = ContentAlignment.MiddleLeft;
            btnJornada.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(10, 30, 50);
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(12, 266);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(224, 42);
            btnFuncionarios.TabIndex = 5;
            btnFuncionarios.Text = "♟   Funcionários";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(10, 30, 50);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 214);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(224, 42);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "⌂   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblGestaoPessoas
            // 
            lblGestaoPessoas.AutoSize = true;
            lblGestaoPessoas.Font = new Font("Segoe UI", 8.5F);
            lblGestaoPessoas.ForeColor = Color.FromArgb(190, 205, 220);
            lblGestaoPessoas.Location = new Point(69, 177);
            lblGestaoPessoas.Name = "lblGestaoPessoas";
            lblGestaoPessoas.Size = new Size(117, 15);
            lblGestaoPessoas.TabIndex = 7;
            lblGestaoPessoas.Text = "GESTÃO DE PESSOAS";
            // 
            // lblRhControl
            // 
            lblRhControl.AutoSize = true;
            lblRhControl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRhControl.ForeColor = Color.White;
            lblRhControl.Location = new Point(69, 150);
            lblRhControl.Name = "lblRhControl";
            lblRhControl.Size = new Size(127, 30);
            lblRhControl.TabIndex = 8;
            lblRhControl.Text = "RH Control";
            // 
            // picLogoSistema
            // 
            picLogoSistema.BackColor = Color.White;
            picLogoSistema.BorderStyle = BorderStyle.FixedSingle;
            picLogoSistema.Image = Properties.Resources.logorh;
            picLogoSistema.Location = new Point(69, 38);
            picLogoSistema.Name = "picLogoSistema";
            picLogoSistema.Size = new Size(110, 94);
            picLogoSistema.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoSistema.TabIndex = 0;
            picLogoSistema.TabStop = false;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(244, 247, 251);
            pnlConteudo.Controls.Add(btnSalvar);
            pnlConteudo.Controls.Add(btnCancelar);
            pnlConteudo.Controls.Add(pnlAreaConteudo);
            pnlConteudo.Controls.Add(pnlAbas);
            pnlConteudo.Controls.Add(pnlCabecalho);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(248, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(952, 760);
            pnlConteudo.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(18, 126, 255);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(760, 698);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 42);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "▣  Salvar Configurações";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(8, 42, 78);
            btnCancelar.Location = new Point(628, 698);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 42);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "↻  Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlAreaConteudo
            // 
            pnlAreaConteudo.BackColor = Color.FromArgb(244, 247, 251);
            pnlAreaConteudo.Controls.Add(pnlUsuario);
            pnlAreaConteudo.Controls.Add(pnlFolha);
            pnlAreaConteudo.Controls.Add(pnlEmpresa);
            pnlAreaConteudo.Location = new Point(0, 194);
            pnlAreaConteudo.Name = "pnlAreaConteudo";
            pnlAreaConteudo.Size = new Size(952, 490);
            pnlAreaConteudo.TabIndex = 2;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.FromArgb(244, 247, 251);
            pnlUsuario.Controls.Add(lblOrientacaoUsuario);
            pnlUsuario.Controls.Add(btnExcluirUsuario);
            pnlUsuario.Controls.Add(btnInativarUsuario);
            pnlUsuario.Controls.Add(btnEditarUsuario);
            pnlUsuario.Controls.Add(dgvUsuarios);
            pnlUsuario.Controls.Add(btnNovaConta);
            pnlUsuario.Controls.Add(pnlUsuarioCabecalho);
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(952, 490);
            pnlUsuario.TabIndex = 0;
            pnlUsuario.Visible = false;
            // 
            // lblOrientacaoUsuario
            // 
            lblOrientacaoUsuario.Font = new Font("Segoe UI", 8.5F);
            lblOrientacaoUsuario.ForeColor = Color.FromArgb(75, 110, 145);
            lblOrientacaoUsuario.Location = new Point(470, 407);
            lblOrientacaoUsuario.Name = "lblOrientacaoUsuario";
            lblOrientacaoUsuario.Size = new Size(440, 38);
            lblOrientacaoUsuario.TabIndex = 0;
            lblOrientacaoUsuario.Text = "Administrador: acesso completo.  Usuário: visualização e exportação de relatórios.";
            lblOrientacaoUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.BackColor = Color.White;
            btnExcluirUsuario.FlatAppearance.BorderColor = Color.FromArgb(225, 190, 190);
            btnExcluirUsuario.FlatStyle = FlatStyle.Flat;
            btnExcluirUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirUsuario.ForeColor = Color.FromArgb(165, 55, 55);
            btnExcluirUsuario.Location = new Point(322, 407);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(120, 36);
            btnExcluirUsuario.TabIndex = 1;
            btnExcluirUsuario.Text = "🗑  Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // btnInativarUsuario
            // 
            btnInativarUsuario.BackColor = Color.White;
            btnInativarUsuario.FlatAppearance.BorderColor = Color.FromArgb(190, 205, 220);
            btnInativarUsuario.FlatStyle = FlatStyle.Flat;
            btnInativarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInativarUsuario.ForeColor = Color.FromArgb(8, 42, 78);
            btnInativarUsuario.Location = new Point(172, 407);
            btnInativarUsuario.Name = "btnInativarUsuario";
            btnInativarUsuario.Size = new Size(140, 36);
            btnInativarUsuario.TabIndex = 2;
            btnInativarUsuario.Text = "🔒  Inativar";
            btnInativarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.White;
            btnEditarUsuario.FlatAppearance.BorderColor = Color.FromArgb(190, 205, 220);
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarUsuario.ForeColor = Color.FromArgb(8, 42, 78);
            btnEditarUsuario.Location = new Point(42, 407);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(120, 36);
            btnEditarUsuario.TabIndex = 3;
            btnEditarUsuario.Text = "✎  Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersHeight = 38;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Location = new Point(42, 108);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(868, 285);
            dgvUsuarios.TabIndex = 20;
            // 
            // btnNovaConta
            // 
            btnNovaConta.BackColor = Color.FromArgb(18, 126, 255);
            btnNovaConta.FlatAppearance.BorderSize = 0;
            btnNovaConta.FlatStyle = FlatStyle.Flat;
            btnNovaConta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovaConta.ForeColor = Color.White;
            btnNovaConta.Location = new Point(750, 22);
            btnNovaConta.Name = "btnNovaConta";
            btnNovaConta.Size = new Size(140, 40);
            btnNovaConta.TabIndex = 21;
            btnNovaConta.Text = "+  Nova conta";
            btnNovaConta.UseVisualStyleBackColor = false;
            // 
            // pnlUsuarioCabecalho
            // 
            pnlUsuarioCabecalho.BackColor = Color.White;
            pnlUsuarioCabecalho.BorderStyle = BorderStyle.FixedSingle;
            pnlUsuarioCabecalho.Controls.Add(lblDescricaoUsuario);
            pnlUsuarioCabecalho.Controls.Add(lblTituloUsuario);
            pnlUsuarioCabecalho.Controls.Add(lblIconeUsuario);
            pnlUsuarioCabecalho.Location = new Point(42, 0);
            pnlUsuarioCabecalho.Name = "pnlUsuarioCabecalho";
            pnlUsuarioCabecalho.Size = new Size(868, 92);
            pnlUsuarioCabecalho.TabIndex = 22;
            // 
            // lblDescricaoUsuario
            // 
            lblDescricaoUsuario.AutoSize = true;
            lblDescricaoUsuario.Font = new Font("Segoe UI", 8.5F);
            lblDescricaoUsuario.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoUsuario.Location = new Point(84, 47);
            lblDescricaoUsuario.Name = "lblDescricaoUsuario";
            lblDescricaoUsuario.Size = new Size(277, 15);
            lblDescricaoUsuario.TabIndex = 0;
            lblDescricaoUsuario.Text = "Gerencie usuários e níveis de acesso ao RH Control.";
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.AutoSize = true;
            lblTituloUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloUsuario.ForeColor = Color.FromArgb(8, 42, 78);
            lblTituloUsuario.Location = new Point(84, 20);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Size = new Size(139, 21);
            lblTituloUsuario.TabIndex = 1;
            lblTituloUsuario.Text = "Contas de acesso";
            // 
            // lblIconeUsuario
            // 
            lblIconeUsuario.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeUsuario.Font = new Font("Segoe UI Symbol", 20F);
            lblIconeUsuario.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeUsuario.Location = new Point(18, 20);
            lblIconeUsuario.Name = "lblIconeUsuario";
            lblIconeUsuario.Size = new Size(52, 52);
            lblIconeUsuario.TabIndex = 2;
            lblIconeUsuario.Text = "♟";
            lblIconeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFolha
            // 
            pnlFolha.BackColor = Color.FromArgb(244, 247, 251);
            pnlFolha.Controls.Add(pnlResumoFolha);
            pnlFolha.Controls.Add(pnlInfoFolha);
            pnlFolha.Controls.Add(pnlFolhaGeral);
            pnlFolha.Location = new Point(0, 0);
            pnlFolha.Name = "pnlFolha";
            pnlFolha.Size = new Size(952, 490);
            pnlFolha.TabIndex = 1;
            pnlFolha.Visible = false;
            // 
            // pnlResumoFolha
            // 
            pnlResumoFolha.BackColor = Color.White;
            pnlResumoFolha.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoFolha.Controls.Add(btnExcluirResumo);
            pnlResumoFolha.Controls.Add(btnEditarResumo);
            pnlResumoFolha.Controls.Add(lblOrientacaoResumo);
            pnlResumoFolha.Controls.Add(dgvResumoFolha);
            pnlResumoFolha.Controls.Add(lblDescricaoResumo);
            pnlResumoFolha.Controls.Add(lblTituloResumo);
            pnlResumoFolha.Controls.Add(lblIconeResumo);
            pnlResumoFolha.Location = new Point(624, 156);
            pnlResumoFolha.Name = "pnlResumoFolha";
            pnlResumoFolha.Size = new Size(258, 324);
            pnlResumoFolha.TabIndex = 0;
            // 
            // btnExcluirResumo
            // 
            btnExcluirResumo.BackColor = Color.FromArgb(253, 235, 235);
            btnExcluirResumo.FlatAppearance.BorderSize = 0;
            btnExcluirResumo.FlatStyle = FlatStyle.Flat;
            btnExcluirResumo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnExcluirResumo.ForeColor = Color.FromArgb(190, 55, 55);
            btnExcluirResumo.Location = new Point(132, 262);
            btnExcluirResumo.Name = "btnExcluirResumo";
            btnExcluirResumo.Size = new Size(82, 38);
            btnExcluirResumo.TabIndex = 0;
            btnExcluirResumo.Text = "▣  Excluir";
            btnExcluirResumo.UseVisualStyleBackColor = false;
            // 
            // btnEditarResumo
            // 
            btnEditarResumo.BackColor = Color.FromArgb(232, 242, 253);
            btnEditarResumo.FlatAppearance.BorderSize = 0;
            btnEditarResumo.FlatStyle = FlatStyle.Flat;
            btnEditarResumo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnEditarResumo.ForeColor = Color.FromArgb(20, 115, 205);
            btnEditarResumo.Location = new Point(40, 262);
            btnEditarResumo.Name = "btnEditarResumo";
            btnEditarResumo.Size = new Size(82, 38);
            btnEditarResumo.TabIndex = 1;
            btnEditarResumo.Text = "✎  Editar";
            btnEditarResumo.UseVisualStyleBackColor = false;
            // 
            // lblOrientacaoResumo
            // 
            lblOrientacaoResumo.Font = new Font("Segoe UI", 7.5F);
            lblOrientacaoResumo.ForeColor = Color.FromArgb(75, 110, 145);
            lblOrientacaoResumo.Location = new Point(10, 228);
            lblOrientacaoResumo.Name = "lblOrientacaoResumo";
            lblOrientacaoResumo.Size = new Size(236, 25);
            lblOrientacaoResumo.TabIndex = 2;
            lblOrientacaoResumo.Text = "Selecione um item na tabela para editar ou excluir.";
            lblOrientacaoResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvResumoFolha
            // 
            dgvResumoFolha.AllowUserToAddRows = false;
            dgvResumoFolha.AllowUserToDeleteRows = false;
            dgvResumoFolha.AllowUserToResizeRows = false;
            dgvResumoFolha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumoFolha.BackgroundColor = Color.White;
            dgvResumoFolha.BorderStyle = BorderStyle.None;
            dgvResumoFolha.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResumoFolha.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 238, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(8, 42, 78);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResumoFolha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResumoFolha.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 236, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(8, 42, 78);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResumoFolha.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResumoFolha.EnableHeadersVisualStyles = false;
            dgvResumoFolha.Font = new Font("Segoe UI", 7.5F);
            dgvResumoFolha.GridColor = Color.FromArgb(225, 232, 240);
            dgvResumoFolha.Location = new Point(10, 66);
            dgvResumoFolha.MultiSelect = false;
            dgvResumoFolha.Name = "dgvResumoFolha";
            dgvResumoFolha.ReadOnly = true;
            dgvResumoFolha.RowHeadersVisible = false;
            dgvResumoFolha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResumoFolha.Size = new Size(236, 156);
            dgvResumoFolha.TabIndex = 0;
            // 
            // lblDescricaoResumo
            // 
            lblDescricaoResumo.AutoSize = true;
            lblDescricaoResumo.Font = new Font("Segoe UI", 7.5F);
            lblDescricaoResumo.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoResumo.Location = new Point(64, 37);
            lblDescricaoResumo.Name = "lblDescricaoResumo";
            lblDescricaoResumo.Size = new Size(163, 12);
            lblDescricaoResumo.TabIndex = 3;
            lblDescricaoResumo.Text = "Selecione uma informação para agir";
            // 
            // lblTituloResumo
            // 
            lblTituloResumo.AutoSize = true;
            lblTituloResumo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTituloResumo.ForeColor = Color.FromArgb(8, 42, 78);
            lblTituloResumo.Location = new Point(64, 15);
            lblTituloResumo.Name = "lblTituloResumo";
            lblTituloResumo.Size = new Size(121, 19);
            lblTituloResumo.TabIndex = 4;
            lblTituloResumo.Text = "Resumo da folha";
            // 
            // lblIconeResumo
            // 
            lblIconeResumo.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeResumo.Font = new Font("Segoe UI Symbol", 15F);
            lblIconeResumo.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeResumo.Location = new Point(14, 14);
            lblIconeResumo.Name = "lblIconeResumo";
            lblIconeResumo.Size = new Size(40, 40);
            lblIconeResumo.TabIndex = 5;
            lblIconeResumo.Text = "▤";
            lblIconeResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfoFolha
            // 
            pnlInfoFolha.BackColor = Color.FromArgb(232, 242, 253);
            pnlInfoFolha.Controls.Add(lblTextoInfoFolha);
            pnlInfoFolha.Controls.Add(lblInfoFolha);
            pnlInfoFolha.Location = new Point(624, 0);
            pnlInfoFolha.Name = "pnlInfoFolha";
            pnlInfoFolha.Size = new Size(258, 142);
            pnlInfoFolha.TabIndex = 1;
            // 
            // lblTextoInfoFolha
            // 
            lblTextoInfoFolha.Font = new Font("Segoe UI", 8.5F);
            lblTextoInfoFolha.ForeColor = Color.FromArgb(75, 110, 145);
            lblTextoInfoFolha.Location = new Point(18, 50);
            lblTextoInfoFolha.Name = "lblTextoInfoFolha";
            lblTextoInfoFolha.Size = new Size(220, 145);
            lblTextoInfoFolha.TabIndex = 0;
            lblTextoInfoFolha.Text = resources.GetString("lblTextoInfoFolha.Text");
            // 
            // lblInfoFolha
            // 
            lblInfoFolha.AutoSize = true;
            lblInfoFolha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInfoFolha.ForeColor = Color.FromArgb(30, 125, 210);
            lblInfoFolha.Location = new Point(18, 18);
            lblInfoFolha.Name = "lblInfoFolha";
            lblInfoFolha.Size = new Size(115, 20);
            lblInfoFolha.TabIndex = 1;
            lblInfoFolha.Text = "Como funciona";
            // 
            // pnlFolhaGeral
            // 
            pnlFolhaGeral.BackColor = Color.White;
            pnlFolhaGeral.BorderStyle = BorderStyle.FixedSingle;
            pnlFolhaGeral.Controls.Add(nudDescontoVT);
            pnlFolhaGeral.Controls.Add(lblDescontoVT);
            pnlFolhaGeral.Controls.Add(nudValorDescontoAdicional);
            pnlFolhaGeral.Controls.Add(lblValorDescontoAdicional);
            pnlFolhaGeral.Controls.Add(rdbDescontoValor);
            pnlFolhaGeral.Controls.Add(rdbDescontoPercentual);
            pnlFolhaGeral.Controls.Add(lblTipoDescontoAdicional);
            pnlFolhaGeral.Controls.Add(txtDescontoAdicional);
            pnlFolhaGeral.Controls.Add(lblDescontoAdicional);
            pnlFolhaGeral.Controls.Add(nudValorBeneficio);
            pnlFolhaGeral.Controls.Add(lblValorBeneficio);
            pnlFolhaGeral.Controls.Add(rdbBeneficioValor);
            pnlFolhaGeral.Controls.Add(rdbBeneficioPercentual);
            pnlFolhaGeral.Controls.Add(lblTipoBeneficio);
            pnlFolhaGeral.Controls.Add(txtBeneficioAdicional);
            pnlFolhaGeral.Controls.Add(lblBeneficioAdicional);
            pnlFolhaGeral.Controls.Add(nudDescontoPlano);
            pnlFolhaGeral.Controls.Add(lblDescontoPlano);
            pnlFolhaGeral.Controls.Add(nudDescontoVA);
            pnlFolhaGeral.Controls.Add(lblDescontoVA);
            pnlFolhaGeral.Controls.Add(nudPercentualAdiantamento);
            pnlFolhaGeral.Controls.Add(lblPercentualAdiantamento);
            pnlFolhaGeral.Controls.Add(nudDiaAdiantamento);
            pnlFolhaGeral.Controls.Add(lblDiaAdiantamento);
            pnlFolhaGeral.Controls.Add(nudDiaPagamento);
            pnlFolhaGeral.Controls.Add(lblDiaPagamento);
            pnlFolhaGeral.Controls.Add(lblDescricaoFolha);
            pnlFolhaGeral.Controls.Add(lblTituloFolha);
            pnlFolhaGeral.Controls.Add(lblIconeFolha);
            pnlFolhaGeral.Controls.Add(pnlTributos);
            pnlFolhaGeral.Location = new Point(42, 0);
            pnlFolhaGeral.Name = "pnlFolhaGeral";
            pnlFolhaGeral.Size = new Size(566, 438);
            pnlFolhaGeral.TabIndex = 2;
            // 
            // nudDescontoVT
            // 
            nudDescontoVT.DecimalPlaces = 2;
            nudDescontoVT.Font = new Font("Segoe UI", 9F);
            nudDescontoVT.Location = new Point(310, 181);
            nudDescontoVT.Name = "nudDescontoVT";
            nudDescontoVT.Size = new Size(120, 23);
            nudDescontoVT.TabIndex = 0;
            // 
            // lblDescontoVT
            // 
            lblDescontoVT.AutoSize = true;
            lblDescontoVT.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDescontoVT.ForeColor = Color.FromArgb(15, 50, 85);
            lblDescontoVT.Location = new Point(310, 160);
            lblDescontoVT.Name = "lblDescontoVT";
            lblDescontoVT.Size = new Size(99, 15);
            lblDescontoVT.TabIndex = 1;
            lblDescontoVT.Text = "Desconto VT (%)";
            // 
            // nudValorDescontoAdicional
            // 
            nudValorDescontoAdicional.DecimalPlaces = 2;
            nudValorDescontoAdicional.Font = new Font("Segoe UI", 9F);
            nudValorDescontoAdicional.Location = new Point(420, 309);
            nudValorDescontoAdicional.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudValorDescontoAdicional.Name = "nudValorDescontoAdicional";
            nudValorDescontoAdicional.Size = new Size(120, 23);
            nudValorDescontoAdicional.TabIndex = 2;
            // 
            // lblValorDescontoAdicional
            // 
            lblValorDescontoAdicional.AutoSize = true;
            lblValorDescontoAdicional.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblValorDescontoAdicional.ForeColor = Color.FromArgb(15, 50, 85);
            lblValorDescontoAdicional.Location = new Point(420, 288);
            lblValorDescontoAdicional.Name = "lblValorDescontoAdicional";
            lblValorDescontoAdicional.Size = new Size(33, 13);
            lblValorDescontoAdicional.TabIndex = 3;
            lblValorDescontoAdicional.Text = "Valor";
            // 
            // rdbDescontoValor
            // 
            rdbDescontoValor.AutoSize = true;
            rdbDescontoValor.Font = new Font("Segoe UI", 7.5F);
            rdbDescontoValor.Location = new Point(278, 328);
            rdbDescontoValor.Name = "rdbDescontoValor";
            rdbDescontoValor.Size = new Size(83, 16);
            rdbDescontoValor.TabIndex = 4;
            rdbDescontoValor.Text = "Valor fixo (R$)";
            rdbDescontoValor.UseVisualStyleBackColor = true;
            // 
            // rdbDescontoPercentual
            // 
            rdbDescontoPercentual.AutoSize = true;
            rdbDescontoPercentual.Checked = true;
            rdbDescontoPercentual.Font = new Font("Segoe UI", 7.5F);
            rdbDescontoPercentual.Location = new Point(278, 307);
            rdbDescontoPercentual.Name = "rdbDescontoPercentual";
            rdbDescontoPercentual.Size = new Size(99, 16);
            rdbDescontoPercentual.TabIndex = 5;
            rdbDescontoPercentual.TabStop = true;
            rdbDescontoPercentual.Text = "Porcentagem (%)";
            rdbDescontoPercentual.UseVisualStyleBackColor = true;
            // 
            // lblTipoDescontoAdicional
            // 
            lblTipoDescontoAdicional.AutoSize = true;
            lblTipoDescontoAdicional.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTipoDescontoAdicional.ForeColor = Color.FromArgb(15, 50, 85);
            lblTipoDescontoAdicional.Location = new Point(278, 288);
            lblTipoDescontoAdicional.Name = "lblTipoDescontoAdicional";
            lblTipoDescontoAdicional.Size = new Size(30, 13);
            lblTipoDescontoAdicional.TabIndex = 6;
            lblTipoDescontoAdicional.Text = "Tipo";
            // 
            // txtDescontoAdicional
            // 
            txtDescontoAdicional.BorderStyle = BorderStyle.FixedSingle;
            txtDescontoAdicional.Font = new Font("Segoe UI", 9F);
            txtDescontoAdicional.Location = new Point(26, 309);
            txtDescontoAdicional.Name = "txtDescontoAdicional";
            txtDescontoAdicional.Size = new Size(240, 23);
            txtDescontoAdicional.TabIndex = 7;
            // 
            // lblDescontoAdicional
            // 
            lblDescontoAdicional.AutoSize = true;
            lblDescontoAdicional.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDescontoAdicional.ForeColor = Color.FromArgb(15, 50, 85);
            lblDescontoAdicional.Location = new Point(26, 288);
            lblDescontoAdicional.Name = "lblDescontoAdicional";
            lblDescontoAdicional.Size = new Size(154, 15);
            lblDescontoAdicional.TabIndex = 8;
            lblDescontoAdicional.Text = "Desconto adicional (nome)";
            // 
            // nudValorBeneficio
            // 
            nudValorBeneficio.DecimalPlaces = 2;
            nudValorBeneficio.Font = new Font("Segoe UI", 9F);
            nudValorBeneficio.Location = new Point(420, 249);
            nudValorBeneficio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudValorBeneficio.Name = "nudValorBeneficio";
            nudValorBeneficio.Size = new Size(120, 23);
            nudValorBeneficio.TabIndex = 9;
            // 
            // lblValorBeneficio
            // 
            lblValorBeneficio.AutoSize = true;
            lblValorBeneficio.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblValorBeneficio.ForeColor = Color.FromArgb(15, 50, 85);
            lblValorBeneficio.Location = new Point(420, 228);
            lblValorBeneficio.Name = "lblValorBeneficio";
            lblValorBeneficio.Size = new Size(33, 13);
            lblValorBeneficio.TabIndex = 10;
            lblValorBeneficio.Text = "Valor";
            // 
            // rdbBeneficioValor
            // 
            rdbBeneficioValor.AutoSize = true;
            rdbBeneficioValor.Font = new Font("Segoe UI", 7.5F);
            rdbBeneficioValor.Location = new Point(278, 268);
            rdbBeneficioValor.Name = "rdbBeneficioValor";
            rdbBeneficioValor.Size = new Size(83, 16);
            rdbBeneficioValor.TabIndex = 11;
            rdbBeneficioValor.Text = "Valor fixo (R$)";
            rdbBeneficioValor.UseVisualStyleBackColor = true;
            // 
            // rdbBeneficioPercentual
            // 
            rdbBeneficioPercentual.AutoSize = true;
            rdbBeneficioPercentual.Checked = true;
            rdbBeneficioPercentual.Font = new Font("Segoe UI", 7.5F);
            rdbBeneficioPercentual.Location = new Point(278, 247);
            rdbBeneficioPercentual.Name = "rdbBeneficioPercentual";
            rdbBeneficioPercentual.Size = new Size(99, 16);
            rdbBeneficioPercentual.TabIndex = 12;
            rdbBeneficioPercentual.TabStop = true;
            rdbBeneficioPercentual.Text = "Porcentagem (%)";
            rdbBeneficioPercentual.UseVisualStyleBackColor = true;
            // 
            // lblTipoBeneficio
            // 
            lblTipoBeneficio.AutoSize = true;
            lblTipoBeneficio.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTipoBeneficio.ForeColor = Color.FromArgb(15, 50, 85);
            lblTipoBeneficio.Location = new Point(278, 228);
            lblTipoBeneficio.Name = "lblTipoBeneficio";
            lblTipoBeneficio.Size = new Size(30, 13);
            lblTipoBeneficio.TabIndex = 13;
            lblTipoBeneficio.Text = "Tipo";
            // 
            // txtBeneficioAdicional
            // 
            txtBeneficioAdicional.BorderStyle = BorderStyle.FixedSingle;
            txtBeneficioAdicional.Font = new Font("Segoe UI", 9F);
            txtBeneficioAdicional.Location = new Point(26, 249);
            txtBeneficioAdicional.Name = "txtBeneficioAdicional";
            txtBeneficioAdicional.Size = new Size(240, 23);
            txtBeneficioAdicional.TabIndex = 14;
            // 
            // lblBeneficioAdicional
            // 
            lblBeneficioAdicional.AutoSize = true;
            lblBeneficioAdicional.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBeneficioAdicional.ForeColor = Color.FromArgb(15, 50, 85);
            lblBeneficioAdicional.Location = new Point(26, 228);
            lblBeneficioAdicional.Name = "lblBeneficioAdicional";
            lblBeneficioAdicional.Size = new Size(154, 15);
            lblBeneficioAdicional.TabIndex = 15;
            lblBeneficioAdicional.Text = "Benefício adicional (nome)";
            // 
            // nudDescontoPlano
            // 
            nudDescontoPlano.DecimalPlaces = 2;
            nudDescontoPlano.Font = new Font("Segoe UI", 9F);
            nudDescontoPlano.Location = new Point(168, 181);
            nudDescontoPlano.Name = "nudDescontoPlano";
            nudDescontoPlano.Size = new Size(120, 23);
            nudDescontoPlano.TabIndex = 16;
            // 
            // lblDescontoPlano
            // 
            lblDescontoPlano.AutoSize = true;
            lblDescontoPlano.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDescontoPlano.ForeColor = Color.FromArgb(15, 50, 85);
            lblDescontoPlano.Location = new Point(168, 160);
            lblDescontoPlano.Name = "lblDescontoPlano";
            lblDescontoPlano.Size = new Size(114, 15);
            lblDescontoPlano.TabIndex = 17;
            lblDescontoPlano.Text = "Desconto plano (%)";
            // 
            // nudDescontoVA
            // 
            nudDescontoVA.DecimalPlaces = 2;
            nudDescontoVA.Font = new Font("Segoe UI", 9F);
            nudDescontoVA.Location = new Point(26, 181);
            nudDescontoVA.Name = "nudDescontoVA";
            nudDescontoVA.Size = new Size(120, 23);
            nudDescontoVA.TabIndex = 18;
            // 
            // lblDescontoVA
            // 
            lblDescontoVA.AutoSize = true;
            lblDescontoVA.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDescontoVA.ForeColor = Color.FromArgb(15, 50, 85);
            lblDescontoVA.Location = new Point(26, 160);
            lblDescontoVA.Name = "lblDescontoVA";
            lblDescontoVA.Size = new Size(99, 15);
            lblDescontoVA.TabIndex = 19;
            lblDescontoVA.Text = "Desconto VA (%)";
            // 
            // nudPercentualAdiantamento
            // 
            nudPercentualAdiantamento.DecimalPlaces = 2;
            nudPercentualAdiantamento.Font = new Font("Segoe UI", 9F);
            nudPercentualAdiantamento.Location = new Point(310, 112);
            nudPercentualAdiantamento.Name = "nudPercentualAdiantamento";
            nudPercentualAdiantamento.Size = new Size(120, 23);
            nudPercentualAdiantamento.TabIndex = 20;
            nudPercentualAdiantamento.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // lblPercentualAdiantamento
            // 
            lblPercentualAdiantamento.AutoSize = true;
            lblPercentualAdiantamento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPercentualAdiantamento.ForeColor = Color.FromArgb(15, 50, 85);
            lblPercentualAdiantamento.Location = new Point(310, 91);
            lblPercentualAdiantamento.Name = "lblPercentualAdiantamento";
            lblPercentualAdiantamento.Size = new Size(114, 15);
            lblPercentualAdiantamento.TabIndex = 21;
            lblPercentualAdiantamento.Text = "% de adiantamento";
            // 
            // nudDiaAdiantamento
            // 
            nudDiaAdiantamento.Font = new Font("Segoe UI", 9F);
            nudDiaAdiantamento.Location = new Point(168, 112);
            nudDiaAdiantamento.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudDiaAdiantamento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDiaAdiantamento.Name = "nudDiaAdiantamento";
            nudDiaAdiantamento.Size = new Size(120, 23);
            nudDiaAdiantamento.TabIndex = 22;
            nudDiaAdiantamento.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblDiaAdiantamento
            // 
            lblDiaAdiantamento.AutoSize = true;
            lblDiaAdiantamento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaAdiantamento.ForeColor = Color.FromArgb(15, 50, 85);
            lblDiaAdiantamento.Location = new Point(168, 91);
            lblDiaAdiantamento.Name = "lblDiaAdiantamento";
            lblDiaAdiantamento.Size = new Size(122, 15);
            lblDiaAdiantamento.TabIndex = 23;
            lblDiaAdiantamento.Text = "Dia do adiantamento";
            // 
            // nudDiaPagamento
            // 
            nudDiaPagamento.Font = new Font("Segoe UI", 9F);
            nudDiaPagamento.Location = new Point(26, 112);
            nudDiaPagamento.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudDiaPagamento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDiaPagamento.Name = "nudDiaPagamento";
            nudDiaPagamento.Size = new Size(120, 23);
            nudDiaPagamento.TabIndex = 24;
            nudDiaPagamento.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiaPagamento
            // 
            lblDiaPagamento.AutoSize = true;
            lblDiaPagamento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaPagamento.ForeColor = Color.FromArgb(15, 50, 85);
            lblDiaPagamento.Location = new Point(26, 91);
            lblDiaPagamento.Name = "lblDiaPagamento";
            lblDiaPagamento.Size = new Size(108, 15);
            lblDiaPagamento.TabIndex = 25;
            lblDiaPagamento.Text = "Dia do pagamento";
            // 
            // lblDescricaoFolha
            // 
            lblDescricaoFolha.AutoSize = true;
            lblDescricaoFolha.Font = new Font("Segoe UI", 8.5F);
            lblDescricaoFolha.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoFolha.Location = new Point(80, 43);
            lblDescricaoFolha.Name = "lblDescricaoFolha";
            lblDescricaoFolha.Size = new Size(231, 15);
            lblDescricaoFolha.TabIndex = 26;
            lblDescricaoFolha.Text = "Defina as regras gerais utilizadas pela folha";
            // 
            // lblTituloFolha
            // 
            lblTituloFolha.AutoSize = true;
            lblTituloFolha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloFolha.ForeColor = Color.FromArgb(8, 42, 78);
            lblTituloFolha.Location = new Point(80, 20);
            lblTituloFolha.Name = "lblTituloFolha";
            lblTituloFolha.Size = new Size(189, 21);
            lblTituloFolha.TabIndex = 27;
            lblTituloFolha.Text = "Configurações da Folha";
            // 
            // lblIconeFolha
            // 
            lblIconeFolha.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeFolha.Font = new Font("Segoe UI Symbol", 18F);
            lblIconeFolha.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeFolha.Location = new Point(18, 18);
            lblIconeFolha.Name = "lblIconeFolha";
            lblIconeFolha.Size = new Size(48, 48);
            lblIconeFolha.TabIndex = 28;
            lblIconeFolha.Text = "▤";
            lblIconeFolha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTributos
            // 
            pnlTributos.BackColor = Color.White;
            pnlTributos.BorderStyle = BorderStyle.FixedSingle;
            pnlTributos.Controls.Add(chkCalcularIRRF);
            pnlTributos.Controls.Add(chkCalcularINSS);
            pnlTributos.Controls.Add(lblDescricaoTributos);
            pnlTributos.Controls.Add(lblTributos);
            pnlTributos.Location = new Point(26, 350);
            pnlTributos.Name = "pnlTributos";
            pnlTributos.Size = new Size(522, 78);
            pnlTributos.TabIndex = 2;
            // 
            // chkCalcularIRRF
            // 
            chkCalcularIRRF.AutoSize = true;
            chkCalcularIRRF.Font = new Font("Segoe UI", 9F);
            chkCalcularIRRF.ForeColor = Color.FromArgb(15, 50, 85);
            chkCalcularIRRF.Location = new Point(190, 48);
            chkCalcularIRRF.Name = "chkCalcularIRRF";
            chkCalcularIRRF.Size = new Size(95, 19);
            chkCalcularIRRF.TabIndex = 0;
            chkCalcularIRRF.Text = "Calcular IRRF";
            chkCalcularIRRF.UseVisualStyleBackColor = true;
            // 
            // chkCalcularINSS
            // 
            chkCalcularINSS.AutoSize = true;
            chkCalcularINSS.Font = new Font("Segoe UI", 9F);
            chkCalcularINSS.ForeColor = Color.FromArgb(15, 50, 85);
            chkCalcularINSS.Location = new Point(18, 48);
            chkCalcularINSS.Name = "chkCalcularINSS";
            chkCalcularINSS.Size = new Size(96, 19);
            chkCalcularINSS.TabIndex = 1;
            chkCalcularINSS.Text = "Calcular INSS";
            chkCalcularINSS.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoTributos
            // 
            lblDescricaoTributos.AutoSize = true;
            lblDescricaoTributos.Font = new Font("Segoe UI", 8F);
            lblDescricaoTributos.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoTributos.Location = new Point(18, 37);
            lblDescricaoTributos.Name = "lblDescricaoTributos";
            lblDescricaoTributos.Size = new Size(185, 13);
            lblDescricaoTributos.TabIndex = 2;
            lblDescricaoTributos.Text = "Ative os cálculos aplicáveis à folha.";
            // 
            // lblTributos
            // 
            lblTributos.AutoSize = true;
            lblTributos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTributos.ForeColor = Color.FromArgb(8, 42, 78);
            lblTributos.Location = new Point(18, 14);
            lblTributos.Name = "lblTributos";
            lblTributos.Size = new Size(112, 19);
            lblTributos.TabIndex = 3;
            lblTributos.Text = "Encargos legais";
            // 
            // pnlEmpresa
            // 
            pnlEmpresa.BackColor = Color.FromArgb(244, 247, 251);
            pnlEmpresa.Controls.Add(pnlInformacoes);
            pnlEmpresa.Controls.Add(pnlLogoEmpresa);
            pnlEmpresa.Controls.Add(pnlDadosEmpresa);
            pnlEmpresa.Location = new Point(0, 0);
            pnlEmpresa.Name = "pnlEmpresa";
            pnlEmpresa.Size = new Size(952, 490);
            pnlEmpresa.TabIndex = 2;
            // 
            // pnlInformacoes
            // 
            pnlInformacoes.BackColor = Color.White;
            pnlInformacoes.BorderStyle = BorderStyle.FixedSingle;
            pnlInformacoes.Controls.Add(txtSite);
            pnlInformacoes.Controls.Add(lblSite);
            pnlInformacoes.Controls.Add(txtInscricaoMunicipal);
            pnlInformacoes.Controls.Add(lblInscricaoMunicipal);
            pnlInformacoes.Controls.Add(txtInscricaoEstadual);
            pnlInformacoes.Controls.Add(lblInscricaoEstadual);
            pnlInformacoes.Controls.Add(lblDescricaoInformacoes);
            pnlInformacoes.Controls.Add(lblInformacoes);
            pnlInformacoes.Controls.Add(lblIconeInformacoes);
            pnlInformacoes.Location = new Point(624, 282);
            pnlInformacoes.Name = "pnlInformacoes";
            pnlInformacoes.Size = new Size(258, 198);
            pnlInformacoes.TabIndex = 0;
            // 
            // txtSite
            // 
            txtSite.BorderStyle = BorderStyle.FixedSingle;
            txtSite.Font = new Font("Segoe UI", 9F);
            txtSite.Location = new Point(22, 160);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(214, 23);
            txtSite.TabIndex = 0;
            // 
            // lblSite
            // 
            lblSite.AutoSize = true;
            lblSite.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSite.ForeColor = Color.FromArgb(15, 50, 85);
            lblSite.Location = new Point(22, 139);
            lblSite.Name = "lblSite";
            lblSite.Size = new Size(29, 15);
            lblSite.TabIndex = 1;
            lblSite.Text = "Site";
            // 
            // txtInscricaoMunicipal
            // 
            txtInscricaoMunicipal.BorderStyle = BorderStyle.FixedSingle;
            txtInscricaoMunicipal.Font = new Font("Segoe UI", 9F);
            txtInscricaoMunicipal.Location = new Point(142, 109);
            txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            txtInscricaoMunicipal.Size = new Size(94, 23);
            txtInscricaoMunicipal.TabIndex = 2;
            // 
            // lblInscricaoMunicipal
            // 
            lblInscricaoMunicipal.AutoSize = true;
            lblInscricaoMunicipal.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInscricaoMunicipal.ForeColor = Color.FromArgb(15, 50, 85);
            lblInscricaoMunicipal.Location = new Point(142, 88);
            lblInscricaoMunicipal.Name = "lblInscricaoMunicipal";
            lblInscricaoMunicipal.Size = new Size(112, 15);
            lblInscricaoMunicipal.TabIndex = 3;
            lblInscricaoMunicipal.Text = "Inscrição Municipal";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.BorderStyle = BorderStyle.FixedSingle;
            txtInscricaoEstadual.Font = new Font("Segoe UI", 9F);
            txtInscricaoEstadual.Location = new Point(22, 109);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(110, 23);
            txtInscricaoEstadual.TabIndex = 4;
            // 
            // lblInscricaoEstadual
            // 
            lblInscricaoEstadual.AutoSize = true;
            lblInscricaoEstadual.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInscricaoEstadual.ForeColor = Color.FromArgb(15, 50, 85);
            lblInscricaoEstadual.Location = new Point(22, 88);
            lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            lblInscricaoEstadual.Size = new Size(104, 15);
            lblInscricaoEstadual.TabIndex = 5;
            lblInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // lblDescricaoInformacoes
            // 
            lblDescricaoInformacoes.AutoSize = true;
            lblDescricaoInformacoes.Font = new Font("Segoe UI", 8F);
            lblDescricaoInformacoes.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoInformacoes.Location = new Point(76, 43);
            lblDescricaoInformacoes.Name = "lblDescricaoInformacoes";
            lblDescricaoInformacoes.Size = new Size(180, 13);
            lblDescricaoInformacoes.TabIndex = 6;
            lblDescricaoInformacoes.Text = "Dados complementares opcionais";
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInformacoes.ForeColor = Color.FromArgb(8, 42, 78);
            lblInformacoes.Location = new Point(76, 20);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(105, 21);
            lblInformacoes.TabIndex = 7;
            lblInformacoes.Text = "Informações";
            // 
            // lblIconeInformacoes
            // 
            lblIconeInformacoes.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeInformacoes.Font = new Font("Segoe UI Symbol", 17F);
            lblIconeInformacoes.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeInformacoes.Location = new Point(16, 18);
            lblIconeInformacoes.Name = "lblIconeInformacoes";
            lblIconeInformacoes.Size = new Size(48, 48);
            lblIconeInformacoes.TabIndex = 8;
            lblIconeInformacoes.Text = "▤";
            lblIconeInformacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLogoEmpresa
            // 
            pnlLogoEmpresa.BackColor = Color.White;
            pnlLogoEmpresa.BorderStyle = BorderStyle.FixedSingle;
            pnlLogoEmpresa.Controls.Add(lblFormatoLogo);
            pnlLogoEmpresa.Controls.Add(btnRemoverLogo);
            pnlLogoEmpresa.Controls.Add(btnSelecionarLogo);
            pnlLogoEmpresa.Controls.Add(picLogo);
            pnlLogoEmpresa.Controls.Add(lblDescricaoLogo);
            pnlLogoEmpresa.Controls.Add(lblLogoEmpresa);
            pnlLogoEmpresa.Controls.Add(lblIconeLogo);
            pnlLogoEmpresa.Location = new Point(624, 0);
            pnlLogoEmpresa.Name = "pnlLogoEmpresa";
            pnlLogoEmpresa.Size = new Size(258, 266);
            pnlLogoEmpresa.TabIndex = 1;
            // 
            // lblFormatoLogo
            // 
            lblFormatoLogo.AutoSize = true;
            lblFormatoLogo.Font = new Font("Segoe UI", 8F);
            lblFormatoLogo.ForeColor = Color.FromArgb(75, 110, 145);
            lblFormatoLogo.Location = new Point(24, 201);
            lblFormatoLogo.Name = "lblFormatoLogo";
            lblFormatoLogo.Size = new Size(78, 26);
            lblFormatoLogo.TabIndex = 0;
            lblFormatoLogo.Text = "PNG ou JPG\r\nMáximo: 2 MB";
            // 
            // btnRemoverLogo
            // 
            btnRemoverLogo.BackColor = Color.White;
            btnRemoverLogo.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnRemoverLogo.FlatStyle = FlatStyle.Flat;
            btnRemoverLogo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRemoverLogo.ForeColor = Color.FromArgb(8, 42, 78);
            btnRemoverLogo.Location = new Point(151, 133);
            btnRemoverLogo.Name = "btnRemoverLogo";
            btnRemoverLogo.Size = new Size(90, 39);
            btnRemoverLogo.TabIndex = 1;
            btnRemoverLogo.Text = "▣  Remover";
            btnRemoverLogo.UseVisualStyleBackColor = false;
            // 
            // btnSelecionarLogo
            // 
            btnSelecionarLogo.BackColor = Color.FromArgb(18, 126, 255);
            btnSelecionarLogo.FlatAppearance.BorderSize = 0;
            btnSelecionarLogo.FlatStyle = FlatStyle.Flat;
            btnSelecionarLogo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnSelecionarLogo.ForeColor = Color.White;
            btnSelecionarLogo.Location = new Point(151, 88);
            btnSelecionarLogo.Name = "btnSelecionarLogo";
            btnSelecionarLogo.Size = new Size(90, 39);
            btnSelecionarLogo.TabIndex = 2;
            btnSelecionarLogo.Text = "↑  Selecionar";
            btnSelecionarLogo.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(22, 88);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(118, 106);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // lblDescricaoLogo
            // 
            lblDescricaoLogo.AutoSize = true;
            lblDescricaoLogo.Font = new Font("Segoe UI", 8.5F);
            lblDescricaoLogo.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoLogo.Location = new Point(76, 43);
            lblDescricaoLogo.Name = "lblDescricaoLogo";
            lblDescricaoLogo.Size = new Size(149, 15);
            lblDescricaoLogo.TabIndex = 4;
            lblDescricaoLogo.Text = "Logo exibida nos relatórios";
            // 
            // lblLogoEmpresa
            // 
            lblLogoEmpresa.AutoSize = true;
            lblLogoEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogoEmpresa.ForeColor = Color.FromArgb(8, 42, 78);
            lblLogoEmpresa.Location = new Point(76, 20);
            lblLogoEmpresa.Name = "lblLogoEmpresa";
            lblLogoEmpresa.Size = new Size(140, 21);
            lblLogoEmpresa.TabIndex = 5;
            lblLogoEmpresa.Text = "Logo da Empresa";
            // 
            // lblIconeLogo
            // 
            lblIconeLogo.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeLogo.Font = new Font("Segoe UI Symbol", 17F);
            lblIconeLogo.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeLogo.Location = new Point(16, 18);
            lblIconeLogo.Name = "lblIconeLogo";
            lblIconeLogo.Size = new Size(48, 48);
            lblIconeLogo.TabIndex = 6;
            lblIconeLogo.Text = "□";
            lblIconeLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDadosEmpresa
            // 
            pnlDadosEmpresa.BackColor = Color.White;
            pnlDadosEmpresa.BorderStyle = BorderStyle.FixedSingle;
            pnlDadosEmpresa.Controls.Add(pnlImportante);
            pnlDadosEmpresa.Controls.Add(lblCep);
            pnlDadosEmpresa.Controls.Add(txtCep);
            pnlDadosEmpresa.Controls.Add(lblUf);
            pnlDadosEmpresa.Controls.Add(cmbUf);
            pnlDadosEmpresa.Controls.Add(lblCidade);
            pnlDadosEmpresa.Controls.Add(txtCidade);
            pnlDadosEmpresa.Controls.Add(lblBairro);
            pnlDadosEmpresa.Controls.Add(txtBairro);
            pnlDadosEmpresa.Controls.Add(lblEndereco);
            pnlDadosEmpresa.Controls.Add(txtEndereco);
            pnlDadosEmpresa.Controls.Add(lblEmail);
            pnlDadosEmpresa.Controls.Add(txtEmail);
            pnlDadosEmpresa.Controls.Add(lblTelefone);
            pnlDadosEmpresa.Controls.Add(txtTelefone);
            pnlDadosEmpresa.Controls.Add(lblCnpj);
            pnlDadosEmpresa.Controls.Add(txtCnpj);
            pnlDadosEmpresa.Controls.Add(lblNomeEmpresa);
            pnlDadosEmpresa.Controls.Add(txtNomeEmpresa);
            pnlDadosEmpresa.Controls.Add(lblDescricaoDados);
            pnlDadosEmpresa.Controls.Add(lblDadosEmpresa);
            pnlDadosEmpresa.Controls.Add(lblIconeDados);
            pnlDadosEmpresa.Location = new Point(42, 0);
            pnlDadosEmpresa.Name = "pnlDadosEmpresa";
            pnlDadosEmpresa.Size = new Size(566, 438);
            pnlDadosEmpresa.TabIndex = 2;
            // 
            // pnlImportante
            // 
            pnlImportante.BackColor = Color.FromArgb(232, 242, 253);
            pnlImportante.Controls.Add(lblTextoImportante);
            pnlImportante.Controls.Add(lblImportante);
            pnlImportante.Controls.Add(lblInfo);
            pnlImportante.Location = new Point(26, 344);
            pnlImportante.Name = "pnlImportante";
            pnlImportante.Size = new Size(522, 62);
            pnlImportante.TabIndex = 0;
            // 
            // lblTextoImportante
            // 
            lblTextoImportante.AutoSize = true;
            lblTextoImportante.Font = new Font("Segoe UI", 8.5F);
            lblTextoImportante.ForeColor = Color.FromArgb(75, 110, 145);
            lblTextoImportante.Location = new Point(67, 32);
            lblTextoImportante.Name = "lblTextoImportante";
            lblTextoImportante.Size = new Size(393, 15);
            lblTextoImportante.TabIndex = 0;
            lblTextoImportante.Text = "Essas informações serão utilizadas nos relatórios, holerites e documentos.";
            // 
            // lblImportante
            // 
            lblImportante.AutoSize = true;
            lblImportante.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblImportante.ForeColor = Color.FromArgb(30, 125, 210);
            lblImportante.Location = new Point(67, 9);
            lblImportante.Name = "lblImportante";
            lblImportante.Size = new Size(77, 17);
            lblImportante.TabIndex = 1;
            lblImportante.Text = "Importante";
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.FromArgb(30, 125, 210);
            lblInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(17, 13);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(35, 35);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "i";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCep.ForeColor = Color.FromArgb(15, 50, 85);
            lblCep.Location = new Point(453, 283);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(27, 15);
            lblCep.TabIndex = 1;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Font = new Font("Segoe UI", 9F);
            txtCep.Location = new Point(453, 304);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(95, 23);
            txtCep.TabIndex = 2;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblUf.ForeColor = Color.FromArgb(15, 50, 85);
            lblUf.Location = new Point(368, 283);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(22, 15);
            lblUf.TabIndex = 3;
            lblUf.Text = "UF";
            // 
            // cmbUf
            // 
            cmbUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUf.Font = new Font("Segoe UI", 9F);
            cmbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbUf.Location = new Point(368, 304);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(70, 23);
            cmbUf.TabIndex = 4;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCidade.ForeColor = Color.FromArgb(15, 50, 85);
            lblCidade.Location = new Point(184, 283);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 5;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Segoe UI", 9F);
            txtCidade.Location = new Point(184, 304);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(171, 23);
            txtCidade.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBairro.ForeColor = Color.FromArgb(15, 50, 85);
            lblBairro.Location = new Point(26, 283);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 7;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Segoe UI", 9F);
            txtBairro.Location = new Point(26, 304);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(145, 23);
            txtBairro.TabIndex = 8;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEndereco.ForeColor = Color.FromArgb(15, 50, 85);
            lblEndereco.Location = new Point(26, 219);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 9;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 9F);
            txtEndereco.Location = new Point(26, 240);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(522, 23);
            txtEndereco.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(15, 50, 85);
            lblEmail.Location = new Point(306, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(306, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(15, 50, 85);
            lblTelefone.Location = new Point(26, 155);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(56, 15);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Segoe UI", 9F);
            txtTelefone.Location = new Point(26, 176);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(259, 23);
            txtTelefone.TabIndex = 14;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCnpj.ForeColor = Color.FromArgb(15, 50, 85);
            lblCnpj.Location = new Point(306, 91);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(42, 15);
            lblCnpj.TabIndex = 15;
            lblCnpj.Text = "CNPJ *";
            // 
            // txtCnpj
            // 
            txtCnpj.BorderStyle = BorderStyle.FixedSingle;
            txtCnpj.Font = new Font("Segoe UI", 9F);
            txtCnpj.Location = new Point(306, 112);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(242, 23);
            txtCnpj.TabIndex = 16;
            // 
            // lblNomeEmpresa
            // 
            lblNomeEmpresa.AutoSize = true;
            lblNomeEmpresa.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNomeEmpresa.ForeColor = Color.FromArgb(15, 50, 85);
            lblNomeEmpresa.Location = new Point(26, 91);
            lblNomeEmpresa.Name = "lblNomeEmpresa";
            lblNomeEmpresa.Size = new Size(115, 15);
            lblNomeEmpresa.TabIndex = 17;
            lblNomeEmpresa.Text = "Nome da Empresa *";
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeEmpresa.Font = new Font("Segoe UI", 9F);
            txtNomeEmpresa.Location = new Point(26, 112);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(259, 23);
            txtNomeEmpresa.TabIndex = 18;
            // 
            // lblDescricaoDados
            // 
            lblDescricaoDados.AutoSize = true;
            lblDescricaoDados.Font = new Font("Segoe UI", 8.5F);
            lblDescricaoDados.ForeColor = Color.FromArgb(75, 110, 145);
            lblDescricaoDados.Location = new Point(80, 43);
            lblDescricaoDados.Name = "lblDescricaoDados";
            lblDescricaoDados.Size = new Size(263, 15);
            lblDescricaoDados.TabIndex = 19;
            lblDescricaoDados.Text = "Informações usadas em relatórios e documentos";
            // 
            // lblDadosEmpresa
            // 
            lblDadosEmpresa.AutoSize = true;
            lblDadosEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDadosEmpresa.ForeColor = Color.FromArgb(8, 42, 78);
            lblDadosEmpresa.Location = new Point(80, 20);
            lblDadosEmpresa.Name = "lblDadosEmpresa";
            lblDadosEmpresa.Size = new Size(150, 21);
            lblDadosEmpresa.TabIndex = 20;
            lblDadosEmpresa.Text = "Dados da Empresa";
            // 
            // lblIconeDados
            // 
            lblIconeDados.BackColor = Color.FromArgb(232, 241, 251);
            lblIconeDados.Font = new Font("Segoe UI Symbol", 18F);
            lblIconeDados.ForeColor = Color.FromArgb(25, 125, 210);
            lblIconeDados.Location = new Point(18, 18);
            lblIconeDados.Name = "lblIconeDados";
            lblIconeDados.Size = new Size(48, 48);
            lblIconeDados.TabIndex = 21;
            lblIconeDados.Text = "▥";
            lblIconeDados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAbas
            // 
            pnlAbas.BackColor = Color.FromArgb(244, 247, 251);
            pnlAbas.Controls.Add(btnAbaBackup);
            pnlAbas.Controls.Add(btnAbaUsuario);
            pnlAbas.Controls.Add(btnAbaFolha);
            pnlAbas.Controls.Add(btnAbaEmpresa);
            pnlAbas.Dock = DockStyle.Top;
            pnlAbas.Location = new Point(0, 130);
            pnlAbas.Name = "pnlAbas";
            pnlAbas.Padding = new Padding(42, 12, 42, 10);
            pnlAbas.Size = new Size(952, 64);
            pnlAbas.TabIndex = 3;
            // 
            // btnAbaBackup
            // 
            btnAbaBackup.BackColor = Color.FromArgb(244, 247, 251);
            btnAbaBackup.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnAbaBackup.FlatStyle = FlatStyle.Flat;
            btnAbaBackup.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAbaBackup.ForeColor = Color.FromArgb(8, 42, 78);
            btnAbaBackup.Location = new Point(601, 12);
            btnAbaBackup.Name = "btnAbaBackup";
            btnAbaBackup.Size = new Size(126, 42);
            btnAbaBackup.TabIndex = 0;
            btnAbaBackup.Text = "▤   Backup";
            btnAbaBackup.UseVisualStyleBackColor = false;
            // 
            // btnAbaUsuario
            // 
            btnAbaUsuario.BackColor = Color.FromArgb(244, 247, 251);
            btnAbaUsuario.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnAbaUsuario.FlatStyle = FlatStyle.Flat;
            btnAbaUsuario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAbaUsuario.ForeColor = Color.FromArgb(8, 42, 78);
            btnAbaUsuario.Location = new Point(417, 12);
            btnAbaUsuario.Name = "btnAbaUsuario";
            btnAbaUsuario.Size = new Size(174, 42);
            btnAbaUsuario.TabIndex = 1;
            btnAbaUsuario.Text = "♟   Usuário";
            btnAbaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAbaFolha
            // 
            btnAbaFolha.BackColor = Color.FromArgb(244, 247, 251);
            btnAbaFolha.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnAbaFolha.FlatStyle = FlatStyle.Flat;
            btnAbaFolha.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAbaFolha.ForeColor = Color.FromArgb(8, 42, 78);
            btnAbaFolha.Location = new Point(228, 12);
            btnAbaFolha.Name = "btnAbaFolha";
            btnAbaFolha.Size = new Size(176, 42);
            btnAbaFolha.TabIndex = 2;
            btnAbaFolha.Text = "▤   Folha de Pagamento";
            btnAbaFolha.UseVisualStyleBackColor = false;
            // 
            // btnAbaEmpresa
            // 
            btnAbaEmpresa.BackColor = Color.FromArgb(18, 126, 255);
            btnAbaEmpresa.FlatAppearance.BorderSize = 0;
            btnAbaEmpresa.FlatStyle = FlatStyle.Flat;
            btnAbaEmpresa.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAbaEmpresa.ForeColor = Color.White;
            btnAbaEmpresa.Location = new Point(42, 12);
            btnAbaEmpresa.Name = "btnAbaEmpresa";
            btnAbaEmpresa.Size = new Size(174, 42);
            btnAbaEmpresa.TabIndex = 3;
            btnAbaEmpresa.Text = "▣   Empresa";
            btnAbaEmpresa.UseVisualStyleBackColor = false;
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Controls.Add(lblAdministrador);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(pnlIconeTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(952, 130);
            pnlCabecalho.TabIndex = 4;
            // 
            // lblAdministrador
            // 
            lblAdministrador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdministrador.ForeColor = Color.FromArgb(20, 115, 205);
            lblAdministrador.Location = new Point(802, 47);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(94, 15);
            lblAdministrador.TabIndex = 0;
            lblAdministrador.Text = "• Administrador";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(75, 110, 145);
            lblSubtitulo.Location = new Point(134, 69);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(237, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie as configurações do sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(8, 42, 78);
            lblTitulo.Location = new Point(132, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 46);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Configurações";
            // 
            // pnlIconeTitulo
            // 
            pnlIconeTitulo.BackColor = Color.FromArgb(232, 241, 251);
            pnlIconeTitulo.Controls.Add(lblIconeConfiguracoes);
            pnlIconeTitulo.Location = new Point(42, 27);
            pnlIconeTitulo.Name = "pnlIconeTitulo";
            pnlIconeTitulo.Size = new Size(74, 60);
            pnlIconeTitulo.TabIndex = 3;
            // 
            // lblIconeConfiguracoes
            // 
            lblIconeConfiguracoes.AutoSize = true;
            lblIconeConfiguracoes.Font = new Font("Segoe UI Symbol", 27F);
            lblIconeConfiguracoes.ForeColor = Color.FromArgb(30, 125, 210);
            lblIconeConfiguracoes.Location = new Point(17, 8);
            lblIconeConfiguracoes.Name = "lblIconeConfiguracoes";
            lblIconeConfiguracoes.Size = new Size(50, 48);
            lblIconeConfiguracoes.TabIndex = 0;
            lblIconeConfiguracoes.Text = "⚙";
            // 
            // btnAbaSistema
            // 
            btnAbaSistema.BackColor = Color.FromArgb(244, 247, 251);
            btnAbaSistema.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            btnAbaSistema.FlatStyle = FlatStyle.Flat;
            btnAbaSistema.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAbaSistema.ForeColor = Color.FromArgb(8, 42, 78);
            btnAbaSistema.Location = new Point(412, 12);
            btnAbaSistema.Name = "btnAbaSistema";
            btnAbaSistema.Size = new Size(176, 42);
            btnAbaSistema.TabIndex = 0;
            btnAbaSistema.Text = "▣   Sistema";
            btnAbaSistema.UseVisualStyleBackColor = false;
            btnAbaSistema.Visible = false;
            // 
            // pnlSistema
            // 
            pnlSistema.BackColor = Color.FromArgb(244, 247, 251);
            pnlSistema.Location = new Point(0, 0);
            pnlSistema.Name = "pnlSistema";
            pnlSistema.Size = new Size(952, 490);
            pnlSistema.TabIndex = 0;
            pnlSistema.Visible = false;
            // 
            // pnlBackup
            // 
            pnlBackup.BackColor = Color.FromArgb(244, 247, 251);
            pnlBackup.Location = new Point(0, 0);
            pnlBackup.Name = "pnlBackup";
            pnlBackup.Size = new Size(952, 490);
            pnlBackup.TabIndex = 0;
            pnlBackup.Visible = false;
            // 
            // FrmConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1200, 760);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 700);
            Name = "FrmConfiguracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RH Control — Configurações";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoSistema).EndInit();
            pnlConteudo.ResumeLayout(false);
            pnlAreaConteudo.ResumeLayout(false);
            pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlUsuarioCabecalho.ResumeLayout(false);
            pnlUsuarioCabecalho.PerformLayout();
            pnlFolha.ResumeLayout(false);
            pnlResumoFolha.ResumeLayout(false);
            pnlResumoFolha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumoFolha).EndInit();
            pnlInfoFolha.ResumeLayout(false);
            pnlInfoFolha.PerformLayout();
            pnlFolhaGeral.ResumeLayout(false);
            pnlFolhaGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescontoVT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValorDescontoAdicional).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValorBeneficio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescontoPlano).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescontoVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPercentualAdiantamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiaAdiantamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiaPagamento).EndInit();
            pnlTributos.ResumeLayout(false);
            pnlTributos.PerformLayout();
            pnlEmpresa.ResumeLayout(false);
            pnlInformacoes.ResumeLayout(false);
            pnlInformacoes.PerformLayout();
            pnlLogoEmpresa.ResumeLayout(false);
            pnlLogoEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlDadosEmpresa.ResumeLayout(false);
            pnlDadosEmpresa.PerformLayout();
            pnlImportante.ResumeLayout(false);
            pnlImportante.PerformLayout();
            pnlAbas.ResumeLayout(false);
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlIconeTitulo.ResumeLayout(false);
            pnlIconeTitulo.PerformLayout();
            ResumeLayout(false);
        }
    }
}
