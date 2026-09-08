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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnJornada = new System.Windows.Forms.Button();
            this.btnFolha = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();

            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();

            this.pnlCalendario = new System.Windows.Forms.Panel();
            this.lblTituloCalendario = new System.Windows.Forms.Label();
            this.btnMesAnterior = new System.Windows.Forms.Button();
            this.btnProximoMes = new System.Windows.Forms.Button();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.tblCalendario = new System.Windows.Forms.TableLayoutPanel();

            this.pnlLegenda = new System.Windows.Forms.Panel();
            this.lblLegendaTitulo = new System.Windows.Forms.Label();
            this.lblLegendaTrabalho = new System.Windows.Forms.Label();
            this.lblLegendaFolga = new System.Windows.Forms.Label();
            this.lblLegendaFeriado = new System.Windows.Forms.Label();
            this.lblLegendaPagamento = new System.Windows.Forms.Label();
            this.lblLegendaAdiantamento = new System.Windows.Forms.Label();
            this.lblLegendaHoje = new System.Windows.Forms.Label();

            this.pnlResumo = new System.Windows.Forms.Panel();
            this.lblTituloResumo = new System.Windows.Forms.Label();
            this.lblDiasUteis = new System.Windows.Forms.Label();
            this.lblDiasTrabalhados = new System.Windows.Forms.Label();
            this.lblFolgas = new System.Windows.Forms.Label();
            this.lblFerias = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblDataSelecionada = new System.Windows.Forms.Label();

            this.pnlEventos = new System.Windows.Forms.Panel();
            this.lblTituloEventos = new System.Windows.Forms.Label();

            this.pnlEvento1 = new System.Windows.Forms.Panel();
            this.pnlEvento2 = new System.Windows.Forms.Panel();
            this.pnlEvento3 = new System.Windows.Forms.Panel();
            this.pnlEvento4 = new System.Windows.Forms.Panel();
            this.pnlEvento5 = new System.Windows.Forms.Panel();

            this.lblEvento1Data = new System.Windows.Forms.Label();
            this.lblEvento1Titulo = new System.Windows.Forms.Label();
            this.lblEvento1Info = new System.Windows.Forms.Label();
            this.lblEvento2Data = new System.Windows.Forms.Label();
            this.lblEvento2Titulo = new System.Windows.Forms.Label();
            this.lblEvento2Info = new System.Windows.Forms.Label();
            this.lblEvento3Data = new System.Windows.Forms.Label();
            this.lblEvento3Titulo = new System.Windows.Forms.Label();
            this.lblEvento3Info = new System.Windows.Forms.Label();
            this.lblEvento4Data = new System.Windows.Forms.Label();
            this.lblEvento4Titulo = new System.Windows.Forms.Label();
            this.lblEvento4Info = new System.Windows.Forms.Label();
            this.lblEvento5Data = new System.Windows.Forms.Label();
            this.lblEvento5Titulo = new System.Windows.Forms.Label();
            this.lblEvento5Info = new System.Windows.Forms.Label();

            this.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlCalendario.SuspendLayout();
            this.pnlLegenda.SuspendLayout();
            this.pnlResumo.SuspendLayout();
            this.pnlEventos.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.ClientSize = new System.Drawing.Size(1180, 780);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH Control — Jornada / Calendário";

            // MENU
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 780);

            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(66, 54);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(90, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblLogo.Location = new System.Drawing.Point(57, 151);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Text = "RH Control";

            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(100, 110, 125);
            this.lblLogoSub.Location = new System.Drawing.Point(59, 176);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Text = "Gestão de Pessoas";

            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 226, 235);
            this.btnDashboard.FlatAppearance.BorderSize = 1;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(45, 55, 70);
            this.btnDashboard.Location = new System.Drawing.Point(15, 218);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(190, 44);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 226, 235);
            this.btnFuncionarios.FlatAppearance.BorderSize = 1;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(45, 55, 70);
            this.btnFuncionarios.Location = new System.Drawing.Point(15, 270);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(190, 44);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnJornada.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJornada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnJornada.FlatAppearance.BorderSize = 1;
            this.btnJornada.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnJornada.ForeColor = System.Drawing.Color.White;
            this.btnJornada.Location = new System.Drawing.Point(15, 322);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(190, 44);
            this.btnJornada.Text = "Jornada / Calendário";
            this.btnJornada.UseVisualStyleBackColor = false;
            this.btnJornada.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnFolha.BackColor = System.Drawing.Color.White;
            this.btnFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 226, 235);
            this.btnFolha.FlatAppearance.BorderSize = 1;
            this.btnFolha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnFolha.ForeColor = System.Drawing.Color.FromArgb(45, 55, 70);
            this.btnFolha.Location = new System.Drawing.Point(15, 374);
            this.btnFolha.Name = "btnFolha";
            this.btnFolha.Size = new System.Drawing.Size(190, 44);
            this.btnFolha.Text = "Folha / Relatórios";
            this.btnFolha.UseVisualStyleBackColor = false;
            this.btnFolha.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnConfiguracoes.BackColor = System.Drawing.Color.White;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 226, 235);
            this.btnConfiguracoes.FlatAppearance.BorderSize = 1;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(45, 55, 70);
            this.btnConfiguracoes.Location = new System.Drawing.Point(15, 426);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(190, 44);
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblVersao.Location = new System.Drawing.Point(30, 735);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Text = "RH Control • v1.0";

            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Controls.Add(this.lblLogoSub);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnFuncionarios);
            this.pnlMenu.Controls.Add(this.btnJornada);
            this.pnlMenu.Controls.Add(this.btnFolha);
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);
            this.pnlMenu.Controls.Add(this.lblVersao);

            // TOPO
            this.pnlTopo.BackColor = System.Drawing.Color.White;
            this.pnlTopo.Location = new System.Drawing.Point(220, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(960, 120);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.lblTitulo.Location = new System.Drawing.Point(34, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Jornada / Calendário";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(100, 110, 125);
            this.lblSubtitulo.Location = new System.Drawing.Point(36, 67);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Controle de jornada, calendário e previsões";

            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdministrador.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblAdministrador.Location = new System.Drawing.Point(845, 34);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Text = "Administrador";

            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Controls.Add(this.lblAdministrador);

            // FILTROS
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Location = new System.Drawing.Point(235, 135);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(930, 72);

            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(95, 105, 120);
            this.lblFuncionario.Location = new System.Drawing.Point(18, 8);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Text = "Funcionário";

            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(95, 105, 120);
            this.lblMes.Location = new System.Drawing.Point(395, 8);
            this.lblMes.Name = "lblMes";
            this.lblMes.Text = "Mês";

            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAno.ForeColor = System.Drawing.Color.FromArgb(95, 105, 120);
            this.lblAno.Location = new System.Drawing.Point(565, 8);
            this.lblAno.Name = "lblAno";
            this.lblAno.Text = "Ano";

            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(18, 27);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(280, 25);

            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(395, 27);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(130, 25);

            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(565, 27);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(90, 25);

            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(675, 27);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(105, 31);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlFiltros.Controls.Add(this.lblFuncionario);
            this.pnlFiltros.Controls.Add(this.lblMes);
            this.pnlFiltros.Controls.Add(this.lblAno);
            this.pnlFiltros.Controls.Add(this.cmbFuncionario);
            this.pnlFiltros.Controls.Add(this.cmbMes);
            this.pnlFiltros.Controls.Add(this.cmbAno);
            this.pnlFiltros.Controls.Add(this.btnAtualizar);

            // CALENDÁRIO
            this.pnlCalendario.BackColor = System.Drawing.Color.White;
            this.pnlCalendario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalendario.Location = new System.Drawing.Point(235, 220);
            this.pnlCalendario.Name = "pnlCalendario";
            this.pnlCalendario.Size = new System.Drawing.Size(555, 405);

            this.lblTituloCalendario.AutoSize = true;
            this.lblTituloCalendario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloCalendario.ForeColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.lblTituloCalendario.Location = new System.Drawing.Point(20, 16);
            this.lblTituloCalendario.Name = "lblTituloCalendario";
            this.lblTituloCalendario.Text = "Calendário da jornada";

            this.btnMesAnterior.BackColor = System.Drawing.Color.White;
            this.btnMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnMesAnterior.FlatAppearance.BorderSize = 1;
            this.btnMesAnterior.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMesAnterior.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnMesAnterior.Location = new System.Drawing.Point(260, 10);
            this.btnMesAnterior.Name = "btnMesAnterior";
            this.btnMesAnterior.Size = new System.Drawing.Size(34, 30);
            this.btnMesAnterior.Text = "<";
            this.btnMesAnterior.UseVisualStyleBackColor = false;
            this.btnMesAnterior.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnProximoMes.BackColor = System.Drawing.Color.White;
            this.btnProximoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximoMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnProximoMes.FlatAppearance.BorderSize = 1;
            this.btnProximoMes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProximoMes.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnProximoMes.Location = new System.Drawing.Point(484, 10);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(34, 30);
            this.btnProximoMes.Text = ">";
            this.btnProximoMes.UseVisualStyleBackColor = false;
            this.btnProximoMes.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblMesAno.AutoSize = false;
            this.lblMesAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMesAno.ForeColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.lblMesAno.Location = new System.Drawing.Point(300, 10);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(180, 30);
            this.lblMesAno.Text = "SETEMBRO 2026";
            this.lblMesAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.tblCalendario.BackColor = System.Drawing.Color.White;
            this.tblCalendario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tblCalendario.ColumnCount = 7;
            this.tblCalendario.Location = new System.Drawing.Point(18, 58);
            this.tblCalendario.Name = "tblCalendario";
            this.tblCalendario.RowCount = 6;
            this.tblCalendario.Size = new System.Drawing.Size(518, 265);
            this.tblCalendario.TabIndex = 0;
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));

            this.pnlLegenda.BackColor = System.Drawing.Color.White;
            this.pnlLegenda.Location = new System.Drawing.Point(18, 328);
            this.pnlLegenda.Name = "pnlLegenda";
            this.pnlLegenda.Size = new System.Drawing.Size(518, 60);

            this.lblLegendaTitulo.AutoSize = true;
            this.lblLegendaTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 105, 120);
            this.lblLegendaTitulo.Location = new System.Drawing.Point(2, 8);
            this.lblLegendaTitulo.Text = "Legenda";

            this.lblLegendaTrabalho.AutoSize = true;
            this.lblLegendaTrabalho.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.lblLegendaTrabalho.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaTrabalho.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblLegendaTrabalho.Location = new System.Drawing.Point(62, 5);
            this.lblLegendaTrabalho.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaTrabalho.Text = "Trabalho";

            this.lblLegendaFolga.AutoSize = true;
            this.lblLegendaFolga.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.lblLegendaFolga.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaFolga.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblLegendaFolga.Location = new System.Drawing.Point(138, 5);
            this.lblLegendaFolga.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaFolga.Text = "Folga";

            this.lblLegendaFeriado.AutoSize = true;
            this.lblLegendaFeriado.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.lblLegendaFeriado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaFeriado.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblLegendaFeriado.Location = new System.Drawing.Point(194, 5);
            this.lblLegendaFeriado.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaFeriado.Text = "Feriado";

            this.lblLegendaPagamento.AutoSize = true;
            this.lblLegendaPagamento.BackColor = System.Drawing.Color.FromArgb(243, 229, 245);
            this.lblLegendaPagamento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaPagamento.ForeColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.lblLegendaPagamento.Location = new System.Drawing.Point(266, 5);
            this.lblLegendaPagamento.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaPagamento.Text = "Pagamento";

            this.lblLegendaAdiantamento.AutoSize = true;
            this.lblLegendaAdiantamento.BackColor = System.Drawing.Color.FromArgb(255, 235, 238);
            this.lblLegendaAdiantamento.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendaAdiantamento.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.lblLegendaAdiantamento.Location = new System.Drawing.Point(350, 5);
            this.lblLegendaAdiantamento.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaAdiantamento.Text = "Adiantamento";

            this.lblLegendaHoje.AutoSize = true;
            this.lblLegendaHoje.BackColor = System.Drawing.Color.White;
            this.lblLegendaHoje.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLegendaHoje.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblLegendaHoje.Location = new System.Drawing.Point(454, 5);
            this.lblLegendaHoje.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLegendaHoje.Text = "Hoje";

            this.pnlLegenda.Controls.Add(this.lblLegendaTitulo);
            this.pnlLegenda.Controls.Add(this.lblLegendaTrabalho);
            this.pnlLegenda.Controls.Add(this.lblLegendaFolga);
            this.pnlLegenda.Controls.Add(this.lblLegendaFeriado);
            this.pnlLegenda.Controls.Add(this.lblLegendaPagamento);
            this.pnlLegenda.Controls.Add(this.lblLegendaAdiantamento);
            this.pnlLegenda.Controls.Add(this.lblLegendaHoje);

            this.pnlCalendario.Controls.Add(this.lblTituloCalendario);
            this.pnlCalendario.Controls.Add(this.btnMesAnterior);
            this.pnlCalendario.Controls.Add(this.btnProximoMes);
            this.pnlCalendario.Controls.Add(this.lblMesAno);
            this.pnlCalendario.Controls.Add(this.tblCalendario);
            this.pnlCalendario.Controls.Add(this.pnlLegenda);

            // RESUMO
            this.pnlResumo.BackColor = System.Drawing.Color.White;
            this.pnlResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumo.Location = new System.Drawing.Point(805, 220);
            this.pnlResumo.Name = "pnlResumo";
            this.pnlResumo.Size = new System.Drawing.Size(360, 405);

            this.lblTituloResumo.AutoSize = true;
            this.lblTituloResumo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloResumo.ForeColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.lblTituloResumo.Location = new System.Drawing.Point(20, 18);
            this.lblTituloResumo.Name = "lblTituloResumo";
            this.lblTituloResumo.Text = "Resumo do mês";

            this.lblDiasUteis.AutoSize = true;
            this.lblDiasUteis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiasUteis.ForeColor = System.Drawing.Color.FromArgb(55, 65, 80);
            this.lblDiasUteis.Location = new System.Drawing.Point(20, 70);
            this.lblDiasUteis.Name = "lblDiasUteis";
            this.lblDiasUteis.Text = "Dias úteis: 25";

            this.lblDiasTrabalhados.AutoSize = true;
            this.lblDiasTrabalhados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiasTrabalhados.ForeColor = System.Drawing.Color.FromArgb(55, 65, 80);
            this.lblDiasTrabalhados.Location = new System.Drawing.Point(20, 116);
            this.lblDiasTrabalhados.Name = "lblDiasTrabalhados";
            this.lblDiasTrabalhados.Text = "Trabalhados: 25";

            this.lblFolgas.AutoSize = true;
            this.lblFolgas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFolgas.ForeColor = System.Drawing.Color.FromArgb(55, 65, 80);
            this.lblFolgas.Location = new System.Drawing.Point(20, 162);
            this.lblFolgas.Name = "lblFolgas";
            this.lblFolgas.Text = "Folgas: 4";

            this.lblFerias.AutoSize = true;
            this.lblFerias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFerias.ForeColor = System.Drawing.Color.FromArgb(55, 65, 80);
            this.lblFerias.Location = new System.Drawing.Point(20, 208);
            this.lblFerias.Name = "lblFerias";
            this.lblFerias.Text = "Férias: 0";

            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFaltas.ForeColor = System.Drawing.Color.FromArgb(55, 65, 80);
            this.lblFaltas.Location = new System.Drawing.Point(20, 254);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Text = "Faltas: 0";

            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblHoras.Location = new System.Drawing.Point(20, 310);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Text = "Horas previstas: 200h00";

            this.lblDataSelecionada.AutoSize = false;
            this.lblDataSelecionada.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDataSelecionada.ForeColor = System.Drawing.Color.FromArgb(115, 125, 140);
            this.lblDataSelecionada.Location = new System.Drawing.Point(20, 350);
            this.lblDataSelecionada.Name = "lblDataSelecionada";
            this.lblDataSelecionada.Size = new System.Drawing.Size(315, 35);
            this.lblDataSelecionada.Text = "Selecione um dia no calendário";
            this.lblDataSelecionada.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.pnlResumo.Controls.Add(this.lblTituloResumo);
            this.pnlResumo.Controls.Add(this.lblDiasUteis);
            this.pnlResumo.Controls.Add(this.lblDiasTrabalhados);
            this.pnlResumo.Controls.Add(this.lblFolgas);
            this.pnlResumo.Controls.Add(this.lblFerias);
            this.pnlResumo.Controls.Add(this.lblFaltas);
            this.pnlResumo.Controls.Add(this.lblHoras);
            this.pnlResumo.Controls.Add(this.lblDataSelecionada);

            // EVENTOS
            this.pnlEventos.BackColor = System.Drawing.Color.White;
            this.pnlEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventos.Location = new System.Drawing.Point(235, 640);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(930, 115);

            this.lblTituloEventos.AutoSize = true;
            this.lblTituloEventos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloEventos.ForeColor = System.Drawing.Color.FromArgb(20, 28, 45);
            this.lblTituloEventos.Location = new System.Drawing.Point(20, 14);
            this.lblTituloEventos.Name = "lblTituloEventos";
            this.lblTituloEventos.Text = "Próximos eventos e previsões";

            // Evento 1
            this.pnlEvento1.BackColor = System.Drawing.Color.FromArgb(249, 251, 254);
            this.pnlEvento1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvento1.Location = new System.Drawing.Point(18, 42);
            this.pnlEvento1.Name = "pnlEvento1";
            this.pnlEvento1.Size = new System.Drawing.Size(165, 64);
            this.pnlEvento1.Controls.Add(this.lblEvento1Data);
            this.pnlEvento1.Controls.Add(this.lblEvento1Titulo);
            this.pnlEvento1.Controls.Add(this.lblEvento1Info);

            this.lblEvento1Data.AutoSize = false;
            this.lblEvento1Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento1Data.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblEvento1Data.Location = new System.Drawing.Point(9, 9);
            this.lblEvento1Data.Name = "lblEvento1Data";
            this.lblEvento1Data.Size = new System.Drawing.Size(45, 20);

            this.lblEvento1Titulo.AutoEllipsis = true;
            this.lblEvento1Titulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvento1Titulo.ForeColor = System.Drawing.Color.FromArgb(35, 42, 55);
            this.lblEvento1Titulo.Location = new System.Drawing.Point(55, 7);
            this.lblEvento1Titulo.Name = "lblEvento1Titulo";
            this.lblEvento1Titulo.Size = new System.Drawing.Size(98, 22);

            this.lblEvento1Info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEvento1Info.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblEvento1Info.Location = new System.Drawing.Point(55, 29);
            this.lblEvento1Info.Name = "lblEvento1Info";
            this.lblEvento1Info.Size = new System.Drawing.Size(98, 28);

            // Evento 2
            this.pnlEvento2.BackColor = System.Drawing.Color.FromArgb(249, 251, 254);
            this.pnlEvento2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvento2.Location = new System.Drawing.Point(200, 42);
            this.pnlEvento2.Name = "pnlEvento2";
            this.pnlEvento2.Size = new System.Drawing.Size(165, 64);
            this.pnlEvento2.Controls.Add(this.lblEvento2Data);
            this.pnlEvento2.Controls.Add(this.lblEvento2Titulo);
            this.pnlEvento2.Controls.Add(this.lblEvento2Info);

            this.lblEvento2Data.AutoSize = false;
            this.lblEvento2Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento2Data.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblEvento2Data.Location = new System.Drawing.Point(9, 9);
            this.lblEvento2Data.Name = "lblEvento2Data";
            this.lblEvento2Data.Size = new System.Drawing.Size(45, 20);

            this.lblEvento2Titulo.AutoEllipsis = true;
            this.lblEvento2Titulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvento2Titulo.ForeColor = System.Drawing.Color.FromArgb(35, 42, 55);
            this.lblEvento2Titulo.Location = new System.Drawing.Point(55, 7);
            this.lblEvento2Titulo.Name = "lblEvento2Titulo";
            this.lblEvento2Titulo.Size = new System.Drawing.Size(98, 22);

            this.lblEvento2Info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEvento2Info.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblEvento2Info.Location = new System.Drawing.Point(55, 29);
            this.lblEvento2Info.Name = "lblEvento2Info";
            this.lblEvento2Info.Size = new System.Drawing.Size(98, 28);

            // Evento 3
            this.pnlEvento3.BackColor = System.Drawing.Color.FromArgb(249, 251, 254);
            this.pnlEvento3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvento3.Location = new System.Drawing.Point(382, 42);
            this.pnlEvento3.Name = "pnlEvento3";
            this.pnlEvento3.Size = new System.Drawing.Size(165, 64);
            this.pnlEvento3.Controls.Add(this.lblEvento3Data);
            this.pnlEvento3.Controls.Add(this.lblEvento3Titulo);
            this.pnlEvento3.Controls.Add(this.lblEvento3Info);

            this.lblEvento3Data.AutoSize = false;
            this.lblEvento3Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento3Data.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblEvento3Data.Location = new System.Drawing.Point(9, 9);
            this.lblEvento3Data.Name = "lblEvento3Data";
            this.lblEvento3Data.Size = new System.Drawing.Size(45, 20);

            this.lblEvento3Titulo.AutoEllipsis = true;
            this.lblEvento3Titulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvento3Titulo.ForeColor = System.Drawing.Color.FromArgb(35, 42, 55);
            this.lblEvento3Titulo.Location = new System.Drawing.Point(55, 7);
            this.lblEvento3Titulo.Name = "lblEvento3Titulo";
            this.lblEvento3Titulo.Size = new System.Drawing.Size(98, 22);

            this.lblEvento3Info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEvento3Info.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblEvento3Info.Location = new System.Drawing.Point(55, 29);
            this.lblEvento3Info.Name = "lblEvento3Info";
            this.lblEvento3Info.Size = new System.Drawing.Size(98, 28);

            // Evento 4
            this.pnlEvento4.BackColor = System.Drawing.Color.FromArgb(249, 251, 254);
            this.pnlEvento4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvento4.Location = new System.Drawing.Point(564, 42);
            this.pnlEvento4.Name = "pnlEvento4";
            this.pnlEvento4.Size = new System.Drawing.Size(165, 64);
            this.pnlEvento4.Controls.Add(this.lblEvento4Data);
            this.pnlEvento4.Controls.Add(this.lblEvento4Titulo);
            this.pnlEvento4.Controls.Add(this.lblEvento4Info);

            this.lblEvento4Data.AutoSize = false;
            this.lblEvento4Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento4Data.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblEvento4Data.Location = new System.Drawing.Point(9, 9);
            this.lblEvento4Data.Name = "lblEvento4Data";
            this.lblEvento4Data.Size = new System.Drawing.Size(45, 20);

            this.lblEvento4Titulo.AutoEllipsis = true;
            this.lblEvento4Titulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvento4Titulo.ForeColor = System.Drawing.Color.FromArgb(35, 42, 55);
            this.lblEvento4Titulo.Location = new System.Drawing.Point(55, 7);
            this.lblEvento4Titulo.Name = "lblEvento4Titulo";
            this.lblEvento4Titulo.Size = new System.Drawing.Size(98, 22);

            this.lblEvento4Info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEvento4Info.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblEvento4Info.Location = new System.Drawing.Point(55, 29);
            this.lblEvento4Info.Name = "lblEvento4Info";
            this.lblEvento4Info.Size = new System.Drawing.Size(98, 28);

            // Evento 5
            this.pnlEvento5.BackColor = System.Drawing.Color.FromArgb(249, 251, 254);
            this.pnlEvento5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvento5.Location = new System.Drawing.Point(746, 42);
            this.pnlEvento5.Name = "pnlEvento5";
            this.pnlEvento5.Size = new System.Drawing.Size(165, 64);
            this.pnlEvento5.Controls.Add(this.lblEvento5Data);
            this.pnlEvento5.Controls.Add(this.lblEvento5Titulo);
            this.pnlEvento5.Controls.Add(this.lblEvento5Info);

            this.lblEvento5Data.AutoSize = false;
            this.lblEvento5Data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento5Data.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblEvento5Data.Location = new System.Drawing.Point(9, 9);
            this.lblEvento5Data.Name = "lblEvento5Data";
            this.lblEvento5Data.Size = new System.Drawing.Size(45, 20);

            this.lblEvento5Titulo.AutoEllipsis = true;
            this.lblEvento5Titulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEvento5Titulo.ForeColor = System.Drawing.Color.FromArgb(35, 42, 55);
            this.lblEvento5Titulo.Location = new System.Drawing.Point(55, 7);
            this.lblEvento5Titulo.Name = "lblEvento5Titulo";
            this.lblEvento5Titulo.Size = new System.Drawing.Size(98, 22);

            this.lblEvento5Info.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEvento5Info.ForeColor = System.Drawing.Color.FromArgb(105, 115, 130);
            this.lblEvento5Info.Location = new System.Drawing.Point(55, 29);
            this.lblEvento5Info.Name = "lblEvento5Info";
            this.lblEvento5Info.Size = new System.Drawing.Size(98, 28);

            this.pnlEventos.Controls.Add(this.lblTituloEventos);
            this.pnlEventos.Controls.Add(this.pnlEvento1);
            this.pnlEventos.Controls.Add(this.pnlEvento2);
            this.pnlEventos.Controls.Add(this.pnlEvento3);
            this.pnlEventos.Controls.Add(this.pnlEvento4);
            this.pnlEventos.Controls.Add(this.pnlEvento5);

            // CONTROLS ON FORM
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlCalendario);
            this.Controls.Add(this.pnlResumo);
            this.Controls.Add(this.pnlEventos);

            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            this.pnlResumo.ResumeLayout(false);
            this.pnlResumo.PerformLayout();
            this.pnlLegenda.ResumeLayout(false);
            this.pnlLegenda.PerformLayout();
            this.pnlCalendario.ResumeLayout(false);
            this.pnlCalendario.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
