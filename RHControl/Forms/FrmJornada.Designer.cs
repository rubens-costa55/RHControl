namespace RHControl
{
    partial class FrmJornada
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Button btnFolha;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblVersao;

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblAdministrador;

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Button btnAtualizar;

        private System.Windows.Forms.Panel pnlCalendario;
        private System.Windows.Forms.Label lblTituloCalendario;
        private System.Windows.Forms.Button btnMesAnterior;
        private System.Windows.Forms.Button btnProximoMes;
        private System.Windows.Forms.Label lblMesAno;
        private System.Windows.Forms.TableLayoutPanel tblCalendario;

        private System.Windows.Forms.Panel pnlLegenda;
        private System.Windows.Forms.Label lblLegendaTitulo;
        private System.Windows.Forms.Label lblLegendaTrabalho;
        private System.Windows.Forms.Label lblLegendaFolga;
        private System.Windows.Forms.Label lblLegendaFeriado;
        private System.Windows.Forms.Label lblLegendaPagamento;
        private System.Windows.Forms.Label lblLegendaAdiantamento;
        private System.Windows.Forms.Label lblLegendaHoje;

        private System.Windows.Forms.Panel pnlResumo;
        private System.Windows.Forms.Label lblTituloResumo;
        private System.Windows.Forms.Label lblDiasUteis;
        private System.Windows.Forms.Label lblDiasTrabalhados;
        private System.Windows.Forms.Label lblFolgas;
        private System.Windows.Forms.Label lblFerias;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblDataSelecionada;
        private System.Windows.Forms.Label lblIconDiasUteis;
        private System.Windows.Forms.Label lblIconDiasTrabalhados;
        private System.Windows.Forms.Label lblIconFolgas;
        private System.Windows.Forms.Label lblIconFerias;
        private System.Windows.Forms.Label lblIconFaltas;

        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Label lblTituloEventos;
        private System.Windows.Forms.Panel pnlEvento1;
        private System.Windows.Forms.Panel pnlEvento2;
        private System.Windows.Forms.Panel pnlEvento3;
        private System.Windows.Forms.Panel pnlEvento4;
        private System.Windows.Forms.Panel pnlEvento5;

        private System.Windows.Forms.Label lblEvento1Data;
        private System.Windows.Forms.Label lblEvento1Titulo;
        private System.Windows.Forms.Label lblEvento1Info;
        private System.Windows.Forms.Label lblEvento2Data;
        private System.Windows.Forms.Label lblEvento2Titulo;
        private System.Windows.Forms.Label lblEvento2Info;
        private System.Windows.Forms.Label lblEvento3Data;
        private System.Windows.Forms.Label lblEvento3Titulo;
        private System.Windows.Forms.Label lblEvento3Info;
        private System.Windows.Forms.Label lblEvento4Data;
        private System.Windows.Forms.Label lblEvento4Titulo;
        private System.Windows.Forms.Label lblEvento4Info;
        private System.Windows.Forms.Label lblEvento5Data;
        private System.Windows.Forms.Label lblEvento5Titulo;
        private System.Windows.Forms.Label lblEvento5Info;

        // Ícones visuais dos próximos eventos
        private System.Windows.Forms.Label lblIconEvento1;
        private System.Windows.Forms.Label lblIconEvento2;
        private System.Windows.Forms.Label lblIconEvento3;
        private System.Windows.Forms.Label lblIconEvento4;
        private System.Windows.Forms.Label lblIconEvento5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void ConfigurarIconeResumo(System.Windows.Forms.Label label, string texto, System.Drawing.Point local, System.Drawing.Color cor)
        {
            label.AutoSize = false;
            label.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Bold);
            label.ForeColor = cor;
            label.Location = local;
            label.Size = new System.Drawing.Size(22, 25);
            label.Text = texto;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            lblLogoSub = new Label();
            btnDashboard = new Button();
            btnFuncionarios = new Button();
            btnJornada = new Button();
            btnFolha = new Button();
            btnConfiguracoes = new Button();
            btnSair = new Button();
            lblVersao = new Label();
            pnlTopo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblAdministrador = new Label();
            pnlFiltros = new Panel();
            lblFuncionario = new Label();
            lblMes = new Label();
            lblAno = new Label();
            cmbFuncionario = new ComboBox();
            cmbMes = new ComboBox();
            cmbAno = new ComboBox();
            btnAtualizar = new Button();
            pnlCalendario = new Panel();
            lblTituloCalendario = new Label();
            btnMesAnterior = new Button();
            btnProximoMes = new Button();
            lblMesAno = new Label();
            tblCalendario = new TableLayoutPanel();
            pnlLegenda = new Panel();
            lblLegendaTitulo = new Label();
            lblLegendaTrabalho = new Label();
            lblLegendaFolga = new Label();
            lblLegendaFeriado = new Label();
            lblLegendaPagamento = new Label();
            lblLegendaAdiantamento = new Label();
            lblLegendaHoje = new Label();
            pnlResumo = new Panel();
            lblTituloResumo = new Label();
            lblIconDiasUteis = new Label();
            lblIconDiasTrabalhados = new Label();
            lblIconFolgas = new Label();
            lblIconFerias = new Label();
            lblIconFaltas = new Label();
            lblDiasUteis = new Label();
            lblDiasTrabalhados = new Label();
            lblFolgas = new Label();
            lblFerias = new Label();
            lblFaltas = new Label();
            lblHoras = new Label();
            lblDataSelecionada = new Label();
            pnlEventos = new Panel();
            lblTituloEventos = new Label();
            pnlEvento1 = new Panel();
            lblEvento1Data = new Label();
            lblEvento1Titulo = new Label();
            lblEvento1Info = new Label();
            lblIconEvento1 = new Label();
            pnlEvento2 = new Panel();
            lblEvento2Data = new Label();
            lblEvento2Titulo = new Label();
            lblEvento2Info = new Label();
            lblIconEvento2 = new Label();
            pnlEvento3 = new Panel();
            lblEvento3Data = new Label();
            lblEvento3Titulo = new Label();
            lblEvento3Info = new Label();
            lblIconEvento3 = new Label();
            pnlEvento4 = new Panel();
            lblEvento4Data = new Label();
            lblEvento4Titulo = new Label();
            lblEvento4Info = new Label();
            lblIconEvento4 = new Label();
            pnlEvento5 = new Panel();
            lblEvento5Data = new Label();
            lblEvento5Titulo = new Label();
            lblEvento5Info = new Label();
            lblIconEvento5 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTopo.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlCalendario.SuspendLayout();
            pnlLegenda.SuspendLayout();
            pnlResumo.SuspendLayout();
            pnlEventos.SuspendLayout();
            pnlEvento1.SuspendLayout();
            pnlEvento2.SuspendLayout();
            pnlEvento3.SuspendLayout();
            pnlEvento4.SuspendLayout();
            pnlEvento5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(10, 30, 50);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblLogo);
            pnlMenu.Controls.Add(lblLogoSub);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnFuncionarios);
            pnlMenu.Controls.Add(btnJornada);
            pnlMenu.Controls.Add(btnFolha);
            pnlMenu.Controls.Add(btnConfiguracoes);
            pnlMenu.Controls.Add(lblVersao);
            pnlMenu.Controls.Add(btnSair);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(245, 760);
            pnlMenu.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.logorh;
            picLogo.Location = new Point(68, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(110, 92);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = false;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(20, 140);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(205, 30);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "RH Control";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = false;
            lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblLogoSub.ForeColor = Color.FromArgb(153, 178, 202);
            lblLogoSub.Location = new Point(20, 169);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(205, 20);
            lblLogoSub.TabIndex = 2;
            lblLogoSub.Text = "GESTÃO DE PESSOAS";
            lblLogoSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(10, 30, 50);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(18, 210);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
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
            btnFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(18, 263);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(20, 0, 0, 0);
            btnFuncionarios.Size = new Size(209, 45);
            btnFuncionarios.TabIndex = 4;
            btnFuncionarios.Text = "●   Funcionários";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnJornada
            // 
            btnJornada.BackColor = Color.FromArgb(18, 126, 255);
            btnJornada.Cursor = Cursors.Hand;
            btnJornada.FlatAppearance.BorderSize = 0;
            btnJornada.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            btnJornada.FlatStyle = FlatStyle.Flat;
            btnJornada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnJornada.ForeColor = Color.White;
            btnJornada.Location = new Point(18, 316);
            btnJornada.Name = "btnJornada";
            btnJornada.Padding = new Padding(20, 0, 0, 0);
            btnJornada.Size = new Size(209, 45);
            btnJornada.TabIndex = 5;
            btnJornada.Text = "▣   Jornada / Calendário";
            btnJornada.TextAlign = ContentAlignment.MiddleLeft;
            btnJornada.UseVisualStyleBackColor = false;
            // 
            // btnFolha
            // 
            btnFolha.BackColor = Color.FromArgb(10, 30, 50);
            btnFolha.Cursor = Cursors.Hand;
            btnFolha.FlatAppearance.BorderSize = 0;
            btnFolha.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnFolha.FlatStyle = FlatStyle.Flat;
            btnFolha.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnFolha.ForeColor = Color.White;
            btnFolha.Location = new Point(18, 369);
            btnFolha.Name = "btnFolha";
            btnFolha.Padding = new Padding(20, 0, 0, 0);
            btnFolha.Size = new Size(209, 45);
            btnFolha.TabIndex = 6;
            btnFolha.Text = "$   Folha / Relatórios";
            btnFolha.TextAlign = ContentAlignment.MiddleLeft;
            btnFolha.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.FromArgb(10, 30, 50);
            btnConfiguracoes.Cursor = Cursors.Hand;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.Location = new Point(18, 422);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(20, 0, 0, 0);
            btnConfiguracoes.Size = new Size(209, 45);
            btnConfiguracoes.TabIndex = 7;
            btnConfiguracoes.Text = "⚙   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblVersao.ForeColor = Color.FromArgb(145, 180, 210);
            lblVersao.Location = new Point(20, 718);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(98, 15);
            lblVersao.TabIndex = 8;
            lblVersao.Text = "RH Control • v1.0";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(10, 30, 50);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(18, 650);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(20, 0, 0, 0);
            btnSair.Size = new Size(209, 45);
            btnSair.TabIndex = 9;
            btnSair.Text = "↪   Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.White;
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Controls.Add(lblAdministrador);
            pnlTopo.Location = new Point(245, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(955, 120);
            pnlTopo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 28, 45);
            lblTitulo.Location = new Point(34, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(365, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Jornada / Calendário";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 110, 125);
            lblSubtitulo.Location = new Point(36, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(272, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Controle de jornada, calendário e previsões";
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdministrador.ForeColor = Color.FromArgb(21, 101, 192);
            lblAdministrador.Location = new Point(845, 34);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(86, 15);
            lblAdministrador.TabIndex = 2;
            lblAdministrador.Text = "Administrador";
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.BorderStyle = BorderStyle.FixedSingle;
            pnlFiltros.Controls.Add(lblFuncionario);
            pnlFiltros.Controls.Add(lblMes);
            pnlFiltros.Controls.Add(lblAno);
            pnlFiltros.Controls.Add(cmbFuncionario);
            pnlFiltros.Controls.Add(cmbMes);
            pnlFiltros.Controls.Add(cmbAno);
            pnlFiltros.Controls.Add(btnAtualizar);
            pnlFiltros.Location = new Point(260, 135);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(930, 72);
            pnlFiltros.TabIndex = 2;
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 8.5F);
            lblFuncionario.ForeColor = Color.FromArgb(95, 105, 120);
            lblFuncionario.Location = new Point(18, 8);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(70, 15);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionário";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Segoe UI", 8.5F);
            lblMes.ForeColor = Color.FromArgb(95, 105, 120);
            lblMes.Location = new Point(395, 8);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 8.5F);
            lblAno.ForeColor = Color.FromArgb(95, 105, 120);
            lblAno.Location = new Point(565, 8);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(29, 15);
            lblAno.TabIndex = 2;
            lblAno.Text = "Ano";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncionario.Font = new Font("Segoe UI", 9F);
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(18, 27);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(280, 23);
            cmbFuncionario.TabIndex = 3;
            // 
            // cmbMes
            // 
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.Font = new Font("Segoe UI", 9F);
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new Point(395, 27);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(130, 23);
            cmbMes.TabIndex = 4;
            // 
            // cmbAno
            // 
            cmbAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAno.Font = new Font("Segoe UI", 9F);
            cmbAno.FormattingEnabled = true;
            cmbAno.Location = new Point(565, 27);
            cmbAno.Name = "cmbAno";
            cmbAno.Size = new Size(90, 23);
            cmbAno.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(21, 101, 192);
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(675, 27);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(105, 31);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // pnlCalendario
            // 
            pnlCalendario.BackColor = Color.White;
            pnlCalendario.BorderStyle = BorderStyle.FixedSingle;
            pnlCalendario.Controls.Add(lblTituloCalendario);
            pnlCalendario.Controls.Add(btnMesAnterior);
            pnlCalendario.Controls.Add(btnProximoMes);
            pnlCalendario.Controls.Add(lblMesAno);
            pnlCalendario.Controls.Add(tblCalendario);
            pnlCalendario.Controls.Add(pnlLegenda);
            pnlCalendario.Location = new Point(260, 220);
            pnlCalendario.Name = "pnlCalendario";
            pnlCalendario.Size = new Size(555, 405);
            pnlCalendario.TabIndex = 3;
            // 
            // lblTituloCalendario
            // 
            lblTituloCalendario.AutoSize = true;
            lblTituloCalendario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloCalendario.ForeColor = Color.FromArgb(20, 28, 45);
            lblTituloCalendario.Location = new Point(20, 16);
            lblTituloCalendario.Name = "lblTituloCalendario";
            lblTituloCalendario.Size = new Size(209, 25);
            lblTituloCalendario.TabIndex = 0;
            lblTituloCalendario.Text = "Calendário da jornada";
            // 
            // btnMesAnterior
            // 
            btnMesAnterior.BackColor = Color.White;
            btnMesAnterior.Cursor = Cursors.Hand;
            btnMesAnterior.FlatAppearance.BorderColor = Color.FromArgb(21, 101, 192);
            btnMesAnterior.FlatStyle = FlatStyle.Flat;
            btnMesAnterior.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMesAnterior.ForeColor = Color.FromArgb(21, 101, 192);
            btnMesAnterior.Location = new Point(260, 10);
            btnMesAnterior.Name = "btnMesAnterior";
            btnMesAnterior.Size = new Size(34, 30);
            btnMesAnterior.TabIndex = 1;
            btnMesAnterior.Text = "<";
            btnMesAnterior.UseVisualStyleBackColor = false;
            // 
            // btnProximoMes
            // 
            btnProximoMes.BackColor = Color.White;
            btnProximoMes.Cursor = Cursors.Hand;
            btnProximoMes.FlatAppearance.BorderColor = Color.FromArgb(21, 101, 192);
            btnProximoMes.FlatStyle = FlatStyle.Flat;
            btnProximoMes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProximoMes.ForeColor = Color.FromArgb(21, 101, 192);
            btnProximoMes.Location = new Point(484, 10);
            btnProximoMes.Name = "btnProximoMes";
            btnProximoMes.Size = new Size(34, 30);
            btnProximoMes.TabIndex = 2;
            btnProximoMes.Text = ">";
            btnProximoMes.UseVisualStyleBackColor = false;
            // 
            // lblMesAno
            // 
            lblMesAno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMesAno.ForeColor = Color.FromArgb(20, 28, 45);
            lblMesAno.Location = new Point(300, 10);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(180, 30);
            lblMesAno.TabIndex = 3;
            lblMesAno.Text = "SETEMBRO 2026";
            lblMesAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblCalendario
            // 
            tblCalendario.BackColor = Color.White;
            tblCalendario.ColumnCount = 7;
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857F));
            tblCalendario.Location = new Point(18, 58);
            tblCalendario.Name = "tblCalendario";
            tblCalendario.RowCount = 6;
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCalendario.Size = new Size(518, 265);
            tblCalendario.TabIndex = 0;
            // 
            // pnlLegenda
            // 
            pnlLegenda.BackColor = Color.White;
            pnlLegenda.Controls.Add(lblLegendaTitulo);
            pnlLegenda.Controls.Add(lblLegendaTrabalho);
            pnlLegenda.Controls.Add(lblLegendaFolga);
            pnlLegenda.Controls.Add(lblLegendaFeriado);
            pnlLegenda.Controls.Add(lblLegendaPagamento);
            pnlLegenda.Controls.Add(lblLegendaAdiantamento);
            pnlLegenda.Controls.Add(lblLegendaHoje);
            pnlLegenda.Location = new Point(18, 328);
            pnlLegenda.Name = "pnlLegenda";
            pnlLegenda.Size = new Size(518, 60);
            pnlLegenda.TabIndex = 4;
            // 
            // lblLegendaTitulo
            // 
            lblLegendaTitulo.AutoSize = true;
            lblLegendaTitulo.Font = new Font("Segoe UI", 8F);
            lblLegendaTitulo.ForeColor = Color.FromArgb(95, 105, 120);
            lblLegendaTitulo.Location = new Point(2, 8);
            lblLegendaTitulo.Name = "lblLegendaTitulo";
            lblLegendaTitulo.Size = new Size(51, 13);
            lblLegendaTitulo.TabIndex = 0;
            lblLegendaTitulo.Text = "Legenda";
            // 
            // lblLegendaTrabalho
            // 
            lblLegendaTrabalho.AutoSize = true;
            lblLegendaTrabalho.BackColor = Color.FromArgb(227, 242, 253);
            lblLegendaTrabalho.Font = new Font("Segoe UI", 8F);
            lblLegendaTrabalho.ForeColor = Color.FromArgb(21, 101, 192);
            lblLegendaTrabalho.Location = new Point(62, 5);
            lblLegendaTrabalho.Name = "lblLegendaTrabalho";
            lblLegendaTrabalho.Padding = new Padding(5, 3, 5, 3);
            lblLegendaTrabalho.Size = new Size(62, 19);
            lblLegendaTrabalho.TabIndex = 1;
            lblLegendaTrabalho.Text = "Trabalho";
            // 
            // lblLegendaFolga
            // 
            lblLegendaFolga.AutoSize = true;
            lblLegendaFolga.BackColor = Color.FromArgb(238, 238, 238);
            lblLegendaFolga.Font = new Font("Segoe UI", 8F);
            lblLegendaFolga.ForeColor = Color.FromArgb(80, 80, 80);
            lblLegendaFolga.Location = new Point(138, 5);
            lblLegendaFolga.Name = "lblLegendaFolga";
            lblLegendaFolga.Padding = new Padding(5, 3, 5, 3);
            lblLegendaFolga.Size = new Size(46, 19);
            lblLegendaFolga.TabIndex = 2;
            lblLegendaFolga.Text = "Folga";
            // 
            // lblLegendaFeriado
            // 
            lblLegendaFeriado.AutoSize = true;
            lblLegendaFeriado.BackColor = Color.FromArgb(232, 245, 233);
            lblLegendaFeriado.Font = new Font("Segoe UI", 8F);
            lblLegendaFeriado.ForeColor = Color.FromArgb(46, 125, 50);
            lblLegendaFeriado.Location = new Point(194, 5);
            lblLegendaFeriado.Name = "lblLegendaFeriado";
            lblLegendaFeriado.Padding = new Padding(5, 3, 5, 3);
            lblLegendaFeriado.Size = new Size(56, 19);
            lblLegendaFeriado.TabIndex = 3;
            lblLegendaFeriado.Text = "Feriado";
            // 
            // lblLegendaPagamento
            // 
            lblLegendaPagamento.AutoSize = true;
            lblLegendaPagamento.BackColor = Color.FromArgb(243, 229, 245);
            lblLegendaPagamento.Font = new Font("Segoe UI", 8F);
            lblLegendaPagamento.ForeColor = Color.FromArgb(106, 27, 154);
            lblLegendaPagamento.Location = new Point(266, 5);
            lblLegendaPagamento.Name = "lblLegendaPagamento";
            lblLegendaPagamento.Padding = new Padding(5, 3, 5, 3);
            lblLegendaPagamento.Size = new Size(75, 19);
            lblLegendaPagamento.TabIndex = 4;
            lblLegendaPagamento.Text = "Pagamento";
            // 
            // lblLegendaAdiantamento
            // 
            lblLegendaAdiantamento.AutoSize = true;
            lblLegendaAdiantamento.BackColor = Color.FromArgb(255, 235, 238);
            lblLegendaAdiantamento.Font = new Font("Segoe UI", 8F);
            lblLegendaAdiantamento.ForeColor = Color.FromArgb(183, 28, 28);
            lblLegendaAdiantamento.Location = new Point(350, 5);
            lblLegendaAdiantamento.Name = "lblLegendaAdiantamento";
            lblLegendaAdiantamento.Padding = new Padding(5, 3, 5, 3);
            lblLegendaAdiantamento.Size = new Size(90, 19);
            lblLegendaAdiantamento.TabIndex = 5;
            lblLegendaAdiantamento.Text = "Adiantamento";
            // 
            // lblLegendaHoje
            // 
            lblLegendaHoje.AutoSize = true;
            lblLegendaHoje.BackColor = Color.White;
            lblLegendaHoje.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLegendaHoje.ForeColor = Color.FromArgb(21, 101, 192);
            lblLegendaHoje.Location = new Point(454, 5);
            lblLegendaHoje.Name = "lblLegendaHoje";
            lblLegendaHoje.Padding = new Padding(5, 3, 5, 3);
            lblLegendaHoje.Size = new Size(41, 19);
            lblLegendaHoje.TabIndex = 6;
            lblLegendaHoje.Text = "Hoje";
            // 
            // pnlResumo
            // 
            pnlResumo.BackColor = Color.White;
            pnlResumo.BorderStyle = BorderStyle.FixedSingle;
            pnlResumo.Controls.Add(lblTituloResumo);
            pnlResumo.Controls.Add(lblIconDiasUteis);
            pnlResumo.Controls.Add(lblIconDiasTrabalhados);
            pnlResumo.Controls.Add(lblIconFolgas);
            pnlResumo.Controls.Add(lblIconFerias);
            pnlResumo.Controls.Add(lblIconFaltas);
            pnlResumo.Controls.Add(lblDiasUteis);
            pnlResumo.Controls.Add(lblDiasTrabalhados);
            pnlResumo.Controls.Add(lblFolgas);
            pnlResumo.Controls.Add(lblFerias);
            pnlResumo.Controls.Add(lblFaltas);
            pnlResumo.Controls.Add(lblHoras);
            pnlResumo.Controls.Add(lblDataSelecionada);
            pnlResumo.Location = new Point(830, 220);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(360, 405);
            pnlResumo.TabIndex = 4;
            // 
            // lblTituloResumo
            // 
            lblTituloResumo.AutoSize = true;
            lblTituloResumo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloResumo.ForeColor = Color.FromArgb(20, 28, 45);
            lblTituloResumo.Location = new Point(20, 18);
            lblTituloResumo.Name = "lblTituloResumo";
            lblTituloResumo.Size = new Size(152, 25);
            lblTituloResumo.TabIndex = 0;
            lblTituloResumo.Text = "Resumo do mês";
            // 
            // lblIconDiasUteis
            // 
            lblIconDiasUteis.Location = new Point(0, 0);
            lblIconDiasUteis.Name = "lblIconDiasUteis";
            lblIconDiasUteis.Size = new Size(100, 23);
            lblIconDiasUteis.TabIndex = 1;
            // 
            // lblIconDiasTrabalhados
            // 
            lblIconDiasTrabalhados.Location = new Point(0, 0);
            lblIconDiasTrabalhados.Name = "lblIconDiasTrabalhados";
            lblIconDiasTrabalhados.Size = new Size(100, 23);
            lblIconDiasTrabalhados.TabIndex = 2;
            // 
            // lblIconFolgas
            // 
            lblIconFolgas.Location = new Point(0, 0);
            lblIconFolgas.Name = "lblIconFolgas";
            lblIconFolgas.Size = new Size(100, 23);
            lblIconFolgas.TabIndex = 3;
            // 
            // lblIconFerias
            // 
            lblIconFerias.Location = new Point(0, 0);
            lblIconFerias.Name = "lblIconFerias";
            lblIconFerias.Size = new Size(100, 23);
            lblIconFerias.TabIndex = 4;
            // 
            // lblIconFaltas
            // 
            lblIconFaltas.Location = new Point(0, 0);
            lblIconFaltas.Name = "lblIconFaltas";
            lblIconFaltas.Size = new Size(100, 23);
            lblIconFaltas.TabIndex = 5;
            // 
            // lblDiasUteis
            // 
            lblDiasUteis.AutoSize = true;
            lblDiasUteis.Font = new Font("Segoe UI", 10F);
            lblDiasUteis.ForeColor = Color.FromArgb(55, 65, 80);
            lblDiasUteis.Location = new Point(52, 70);
            lblDiasUteis.Name = "lblDiasUteis";
            lblDiasUteis.Size = new Size(91, 19);
            lblDiasUteis.TabIndex = 6;
            lblDiasUteis.Text = "Dias úteis: 25";
            // 
            // lblDiasTrabalhados
            // 
            lblDiasTrabalhados.AutoSize = true;
            lblDiasTrabalhados.Font = new Font("Segoe UI", 10F);
            lblDiasTrabalhados.ForeColor = Color.FromArgb(55, 65, 80);
            lblDiasTrabalhados.Location = new Point(52, 116);
            lblDiasTrabalhados.Name = "lblDiasTrabalhados";
            lblDiasTrabalhados.Size = new Size(105, 19);
            lblDiasTrabalhados.TabIndex = 7;
            lblDiasTrabalhados.Text = "Trabalhados: 25";
            // 
            // lblFolgas
            // 
            lblFolgas.AutoSize = true;
            lblFolgas.Font = new Font("Segoe UI", 10F);
            lblFolgas.ForeColor = Color.FromArgb(55, 65, 80);
            lblFolgas.Location = new Point(52, 162);
            lblFolgas.Name = "lblFolgas";
            lblFolgas.Size = new Size(63, 19);
            lblFolgas.TabIndex = 8;
            lblFolgas.Text = "Folgas: 4";
            // 
            // lblFerias
            // 
            lblFerias.AutoSize = true;
            lblFerias.Font = new Font("Segoe UI", 10F);
            lblFerias.ForeColor = Color.FromArgb(55, 65, 80);
            lblFerias.Location = new Point(52, 208);
            lblFerias.Name = "lblFerias";
            lblFerias.Size = new Size(59, 19);
            lblFerias.TabIndex = 9;
            lblFerias.Text = "Férias: 0";
            // 
            // lblFaltas
            // 
            lblFaltas.AutoSize = true;
            lblFaltas.Font = new Font("Segoe UI", 10F);
            lblFaltas.ForeColor = Color.FromArgb(55, 65, 80);
            lblFaltas.Location = new Point(52, 254);
            lblFaltas.Name = "lblFaltas";
            lblFaltas.Size = new Size(59, 19);
            lblFaltas.TabIndex = 10;
            lblFaltas.Text = "Faltas: 0";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHoras.ForeColor = Color.FromArgb(21, 101, 192);
            lblHoras.Location = new Point(20, 310);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(179, 20);
            lblHoras.TabIndex = 11;
            lblHoras.Text = "Horas previstas: 200h00";
            // 
            // lblDataSelecionada
            // 
            lblDataSelecionada.Font = new Font("Segoe UI", 8.5F);
            lblDataSelecionada.ForeColor = Color.FromArgb(115, 125, 140);
            lblDataSelecionada.Location = new Point(20, 350);
            lblDataSelecionada.Name = "lblDataSelecionada";
            lblDataSelecionada.Size = new Size(315, 35);
            lblDataSelecionada.TabIndex = 12;
            lblDataSelecionada.Text = "Selecione um dia no calendário";
            // 
            // pnlEventos
            // 
            pnlEventos.BackColor = Color.White;
            pnlEventos.BorderStyle = BorderStyle.FixedSingle;
            pnlEventos.Controls.Add(lblTituloEventos);
            pnlEventos.Controls.Add(pnlEvento1);
            pnlEventos.Controls.Add(pnlEvento2);
            pnlEventos.Controls.Add(pnlEvento3);
            pnlEventos.Controls.Add(pnlEvento4);
            pnlEventos.Controls.Add(pnlEvento5);
            pnlEventos.Location = new Point(260, 640);
            pnlEventos.Name = "pnlEventos";
            pnlEventos.Size = new Size(930, 115);
            pnlEventos.TabIndex = 5;
            // 
            // lblTituloEventos
            // 
            lblTituloEventos.AutoSize = true;
            lblTituloEventos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloEventos.ForeColor = Color.FromArgb(20, 28, 45);
            lblTituloEventos.Location = new Point(20, 14);
            lblTituloEventos.Name = "lblTituloEventos";
            lblTituloEventos.Size = new Size(263, 25);
            lblTituloEventos.TabIndex = 0;
            lblTituloEventos.Text = "Próximos eventos e previsões";
            // 
            // pnlEvento1
            // 
            pnlEvento1.BackColor = Color.FromArgb(249, 251, 254);
            pnlEvento1.BorderStyle = BorderStyle.FixedSingle;
            pnlEvento1.Controls.Add(lblEvento1Data);
            pnlEvento1.Controls.Add(lblEvento1Titulo);
            pnlEvento1.Controls.Add(lblEvento1Info);
            pnlEvento1.Controls.Add(lblIconEvento1);
            pnlEvento1.Location = new Point(18, 42);
            pnlEvento1.Name = "pnlEvento1";
            pnlEvento1.Size = new Size(165, 64);
            pnlEvento1.TabIndex = 1;
            // 
            // lblEvento1Data
            // 
            lblEvento1Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvento1Data.ForeColor = Color.FromArgb(21, 101, 192);
            lblEvento1Data.Location = new Point(9, 9);
            lblEvento1Data.Name = "lblEvento1Data";
            lblEvento1Data.Size = new Size(45, 20);
            lblEvento1Data.TabIndex = 0;
            // 
            // lblEvento1Titulo
            // 
            lblEvento1Titulo.AutoEllipsis = true;
            lblEvento1Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEvento1Titulo.ForeColor = Color.FromArgb(35, 42, 55);
            lblEvento1Titulo.Location = new Point(55, 7);
            lblEvento1Titulo.Name = "lblEvento1Titulo";
            lblEvento1Titulo.Size = new Size(98, 22);
            lblEvento1Titulo.TabIndex = 1;
            // 
            // lblEvento1Info
            // 
            lblEvento1Info.Font = new Font("Segoe UI", 7.5F);
            lblEvento1Info.ForeColor = Color.FromArgb(105, 115, 130);
            lblEvento1Info.Location = new Point(55, 29);
            lblEvento1Info.Name = "lblEvento1Info";
            lblEvento1Info.Size = new Size(98, 28);
            lblEvento1Info.TabIndex = 2;
            // 
            // lblIconEvento1
            // 
            lblIconEvento1.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold);
            lblIconEvento1.ForeColor = Color.FromArgb(21, 101, 192);
            lblIconEvento1.Location = new Point(8, 34);
            lblIconEvento1.Name = "lblIconEvento1";
            lblIconEvento1.Size = new Size(40, 25);
            lblIconEvento1.TabIndex = 3;
            lblIconEvento1.Text = "✈";
            lblIconEvento1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEvento2
            // 
            pnlEvento2.BackColor = Color.FromArgb(249, 251, 254);
            pnlEvento2.BorderStyle = BorderStyle.FixedSingle;
            pnlEvento2.Controls.Add(lblEvento2Data);
            pnlEvento2.Controls.Add(lblEvento2Titulo);
            pnlEvento2.Controls.Add(lblEvento2Info);
            pnlEvento2.Controls.Add(lblIconEvento2);
            pnlEvento2.Location = new Point(200, 42);
            pnlEvento2.Name = "pnlEvento2";
            pnlEvento2.Size = new Size(165, 64);
            pnlEvento2.TabIndex = 2;
            // 
            // lblEvento2Data
            // 
            lblEvento2Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvento2Data.ForeColor = Color.FromArgb(21, 101, 192);
            lblEvento2Data.Location = new Point(9, 9);
            lblEvento2Data.Name = "lblEvento2Data";
            lblEvento2Data.Size = new Size(45, 20);
            lblEvento2Data.TabIndex = 0;
            // 
            // lblEvento2Titulo
            // 
            lblEvento2Titulo.AutoEllipsis = true;
            lblEvento2Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEvento2Titulo.ForeColor = Color.FromArgb(35, 42, 55);
            lblEvento2Titulo.Location = new Point(55, 7);
            lblEvento2Titulo.Name = "lblEvento2Titulo";
            lblEvento2Titulo.Size = new Size(98, 22);
            lblEvento2Titulo.TabIndex = 1;
            // 
            // lblEvento2Info
            // 
            lblEvento2Info.Font = new Font("Segoe UI", 7.5F);
            lblEvento2Info.ForeColor = Color.FromArgb(105, 115, 130);
            lblEvento2Info.Location = new Point(55, 29);
            lblEvento2Info.Name = "lblEvento2Info";
            lblEvento2Info.Size = new Size(98, 28);
            lblEvento2Info.TabIndex = 2;
            // 
            // lblIconEvento2
            // 
            lblIconEvento2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIconEvento2.ForeColor = Color.FromArgb(106, 27, 154);
            lblIconEvento2.Location = new Point(8, 34);
            lblIconEvento2.Name = "lblIconEvento2";
            lblIconEvento2.Size = new Size(40, 25);
            lblIconEvento2.TabIndex = 3;
            lblIconEvento2.Text = "R$";
            lblIconEvento2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEvento3
            // 
            pnlEvento3.BackColor = Color.FromArgb(249, 251, 254);
            pnlEvento3.BorderStyle = BorderStyle.FixedSingle;
            pnlEvento3.Controls.Add(lblEvento3Data);
            pnlEvento3.Controls.Add(lblEvento3Titulo);
            pnlEvento3.Controls.Add(lblEvento3Info);
            pnlEvento3.Controls.Add(lblIconEvento3);
            pnlEvento3.Location = new Point(382, 42);
            pnlEvento3.Name = "pnlEvento3";
            pnlEvento3.Size = new Size(165, 64);
            pnlEvento3.TabIndex = 3;
            // 
            // lblEvento3Data
            // 
            lblEvento3Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvento3Data.ForeColor = Color.FromArgb(21, 101, 192);
            lblEvento3Data.Location = new Point(9, 9);
            lblEvento3Data.Name = "lblEvento3Data";
            lblEvento3Data.Size = new Size(45, 20);
            lblEvento3Data.TabIndex = 0;
            // 
            // lblEvento3Titulo
            // 
            lblEvento3Titulo.AutoEllipsis = true;
            lblEvento3Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEvento3Titulo.ForeColor = Color.FromArgb(35, 42, 55);
            lblEvento3Titulo.Location = new Point(55, 7);
            lblEvento3Titulo.Name = "lblEvento3Titulo";
            lblEvento3Titulo.Size = new Size(98, 22);
            lblEvento3Titulo.TabIndex = 1;
            // 
            // lblEvento3Info
            // 
            lblEvento3Info.Font = new Font("Segoe UI", 7.5F);
            lblEvento3Info.ForeColor = Color.FromArgb(105, 115, 130);
            lblEvento3Info.Location = new Point(55, 29);
            lblEvento3Info.Name = "lblEvento3Info";
            lblEvento3Info.Size = new Size(98, 28);
            lblEvento3Info.TabIndex = 2;
            // 
            // lblIconEvento3
            // 
            lblIconEvento3.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold);
            lblIconEvento3.ForeColor = Color.FromArgb(230, 126, 34);
            lblIconEvento3.Location = new Point(8, 34);
            lblIconEvento3.Name = "lblIconEvento3";
            lblIconEvento3.Size = new Size(40, 25);
            lblIconEvento3.TabIndex = 3;
            lblIconEvento3.Text = "▣";
            lblIconEvento3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEvento4
            // 
            pnlEvento4.BackColor = Color.FromArgb(249, 251, 254);
            pnlEvento4.BorderStyle = BorderStyle.FixedSingle;
            pnlEvento4.Controls.Add(lblEvento4Data);
            pnlEvento4.Controls.Add(lblEvento4Titulo);
            pnlEvento4.Controls.Add(lblEvento4Info);
            pnlEvento4.Controls.Add(lblIconEvento4);
            pnlEvento4.Location = new Point(564, 42);
            pnlEvento4.Name = "pnlEvento4";
            pnlEvento4.Size = new Size(165, 64);
            pnlEvento4.TabIndex = 4;
            // 
            // lblEvento4Data
            // 
            lblEvento4Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvento4Data.ForeColor = Color.FromArgb(21, 101, 192);
            lblEvento4Data.Location = new Point(9, 9);
            lblEvento4Data.Name = "lblEvento4Data";
            lblEvento4Data.Size = new Size(45, 20);
            lblEvento4Data.TabIndex = 0;
            // 
            // lblEvento4Titulo
            // 
            lblEvento4Titulo.AutoEllipsis = true;
            lblEvento4Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEvento4Titulo.ForeColor = Color.FromArgb(35, 42, 55);
            lblEvento4Titulo.Location = new Point(55, 7);
            lblEvento4Titulo.Name = "lblEvento4Titulo";
            lblEvento4Titulo.Size = new Size(98, 22);
            lblEvento4Titulo.TabIndex = 1;
            // 
            // lblEvento4Info
            // 
            lblEvento4Info.Font = new Font("Segoe UI", 7.5F);
            lblEvento4Info.ForeColor = Color.FromArgb(105, 115, 130);
            lblEvento4Info.Location = new Point(55, 29);
            lblEvento4Info.Name = "lblEvento4Info";
            lblEvento4Info.Size = new Size(98, 28);
            lblEvento4Info.TabIndex = 2;
            // 
            // lblIconEvento4
            // 
            lblIconEvento4.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold);
            lblIconEvento4.ForeColor = Color.FromArgb(46, 125, 50);
            lblIconEvento4.Location = new Point(8, 34);
            lblIconEvento4.Name = "lblIconEvento4";
            lblIconEvento4.Size = new Size(40, 25);
            lblIconEvento4.TabIndex = 3;
            lblIconEvento4.Text = "✓";
            lblIconEvento4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEvento5
            // 
            pnlEvento5.BackColor = Color.FromArgb(249, 251, 254);
            pnlEvento5.BorderStyle = BorderStyle.FixedSingle;
            pnlEvento5.Controls.Add(lblEvento5Data);
            pnlEvento5.Controls.Add(lblEvento5Titulo);
            pnlEvento5.Controls.Add(lblEvento5Info);
            pnlEvento5.Controls.Add(lblIconEvento5);
            pnlEvento5.Location = new Point(746, 42);
            pnlEvento5.Name = "pnlEvento5";
            pnlEvento5.Size = new Size(165, 64);
            pnlEvento5.TabIndex = 5;
            // 
            // lblEvento5Data
            // 
            lblEvento5Data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvento5Data.ForeColor = Color.FromArgb(21, 101, 192);
            lblEvento5Data.Location = new Point(9, 9);
            lblEvento5Data.Name = "lblEvento5Data";
            lblEvento5Data.Size = new Size(45, 20);
            lblEvento5Data.TabIndex = 0;
            // 
            // lblEvento5Titulo
            // 
            lblEvento5Titulo.AutoEllipsis = true;
            lblEvento5Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEvento5Titulo.ForeColor = Color.FromArgb(35, 42, 55);
            lblEvento5Titulo.Location = new Point(55, 7);
            lblEvento5Titulo.Name = "lblEvento5Titulo";
            lblEvento5Titulo.Size = new Size(98, 22);
            lblEvento5Titulo.TabIndex = 1;
            // 
            // lblEvento5Info
            // 
            lblEvento5Info.Font = new Font("Segoe UI", 7.5F);
            lblEvento5Info.ForeColor = Color.FromArgb(105, 115, 130);
            lblEvento5Info.Location = new Point(55, 29);
            lblEvento5Info.Name = "lblEvento5Info";
            lblEvento5Info.Size = new Size(98, 28);
            lblEvento5Info.TabIndex = 2;
            // 
            // lblIconEvento5
            // 
            lblIconEvento5.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold);
            lblIconEvento5.ForeColor = Color.FromArgb(21, 101, 192);
            lblIconEvento5.Location = new Point(8, 34);
            lblIconEvento5.Name = "lblIconEvento5";
            lblIconEvento5.Size = new Size(40, 25);
            lblIconEvento5.TabIndex = 3;
            lblIconEvento5.Text = "●";
            lblIconEvento5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1200, 760);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTopo);
            Controls.Add(pnlFiltros);
            Controls.Add(pnlCalendario);
            Controls.Add(pnlResumo);
            Controls.Add(pnlEventos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RH Control — Jornada / Calendário";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlCalendario.ResumeLayout(false);
            pnlCalendario.PerformLayout();
            pnlLegenda.ResumeLayout(false);
            pnlLegenda.PerformLayout();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
            pnlEventos.ResumeLayout(false);
            pnlEventos.PerformLayout();
            pnlEvento1.ResumeLayout(false);
            pnlEvento2.ResumeLayout(false);
            pnlEvento3.ResumeLayout(false);
            pnlEvento4.ResumeLayout(false);
            pnlEvento5.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
