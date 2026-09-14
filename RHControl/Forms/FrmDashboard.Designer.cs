namespace RHControl
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNomeSistema;
        private System.Windows.Forms.Label lblSubtituloMenu;
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
        private System.Windows.Forms.Label lblUsuario;

        private System.Windows.Forms.Panel pnlCardFuncionarios;
        private System.Windows.Forms.Label lblCardFuncionariosTitulo;
        private System.Windows.Forms.Label lblFuncionariosValor;
        private System.Windows.Forms.Label lblFuncionariosInfo;

        private System.Windows.Forms.Panel pnlCardFolha;
        private System.Windows.Forms.Label lblCardFolhaTitulo;
        private System.Windows.Forms.Label lblFolhaValor;
        private System.Windows.Forms.Label lblFolhaInfo;

        private System.Windows.Forms.Panel pnlCardPagamento;
        private System.Windows.Forms.Label lblCardPagamentoTitulo;
        private System.Windows.Forms.Label lblPagamentoValor;
        private System.Windows.Forms.Label lblPagamentoInfo;

        private System.Windows.Forms.Panel pnlCardAdiantamento;
        private System.Windows.Forms.Label lblCardAdiantamentoTitulo;
        private System.Windows.Forms.Label lblAdiantamentoValor;
        private System.Windows.Forms.Label lblAdiantamentoInfo;

        private System.Windows.Forms.Panel pnlCardFerias;
        private System.Windows.Forms.Label lblCardFeriasTitulo;
        private System.Windows.Forms.Label lblFeriasValor;
        private System.Windows.Forms.Label lblFeriasInfo;

        private System.Windows.Forms.Panel pnlSituacao;
        private System.Windows.Forms.Label lblSituacaoTitulo;
        private System.Windows.Forms.Label lblSituacaoResumo;
        private System.Windows.Forms.Label lblAtivos;
        private System.Windows.Forms.ProgressBar progressAtivos;
        private System.Windows.Forms.Label lblFerias;
        private System.Windows.Forms.ProgressBar progressFerias;
        private System.Windows.Forms.Label lblAfastados;
        private System.Windows.Forms.ProgressBar progressAfastados;

        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Label lblEventosTitulo;
        private System.Windows.Forms.Label lblEvento1;
        private System.Windows.Forms.Label lblEvento2;
        private System.Windows.Forms.Label lblEvento3;
        private System.Windows.Forms.Label lblEvento4;

        private System.Windows.Forms.Panel pnlAlertas;
        private System.Windows.Forms.Label lblAlertasTitulo;
        private System.Windows.Forms.Label lblAlerta1;
        private System.Windows.Forms.Label lblAlerta2;
        private System.Windows.Forms.Label lblAlerta3;

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
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.lblSubtituloMenu = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnJornada = new System.Windows.Forms.Button();
            this.btnFolha = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();

            this.pnlCardFuncionarios = new System.Windows.Forms.Panel();
            this.lblCardFuncionariosTitulo = new System.Windows.Forms.Label();
            this.lblFuncionariosValor = new System.Windows.Forms.Label();
            this.lblFuncionariosInfo = new System.Windows.Forms.Label();

            this.pnlCardFolha = new System.Windows.Forms.Panel();
            this.lblCardFolhaTitulo = new System.Windows.Forms.Label();
            this.lblFolhaValor = new System.Windows.Forms.Label();
            this.lblFolhaInfo = new System.Windows.Forms.Label();

            this.pnlCardPagamento = new System.Windows.Forms.Panel();
            this.lblCardPagamentoTitulo = new System.Windows.Forms.Label();
            this.lblPagamentoValor = new System.Windows.Forms.Label();
            this.lblPagamentoInfo = new System.Windows.Forms.Label();

            this.pnlCardAdiantamento = new System.Windows.Forms.Panel();
            this.lblCardAdiantamentoTitulo = new System.Windows.Forms.Label();
            this.lblAdiantamentoValor = new System.Windows.Forms.Label();
            this.lblAdiantamentoInfo = new System.Windows.Forms.Label();

            this.pnlCardFerias = new System.Windows.Forms.Panel();
            this.lblCardFeriasTitulo = new System.Windows.Forms.Label();
            this.lblFeriasValor = new System.Windows.Forms.Label();
            this.lblFeriasInfo = new System.Windows.Forms.Label();

            this.pnlSituacao = new System.Windows.Forms.Panel();
            this.lblSituacaoTitulo = new System.Windows.Forms.Label();
            this.lblSituacaoResumo = new System.Windows.Forms.Label();
            this.lblAtivos = new System.Windows.Forms.Label();
            this.progressAtivos = new System.Windows.Forms.ProgressBar();
            this.lblFerias = new System.Windows.Forms.Label();
            this.progressFerias = new System.Windows.Forms.ProgressBar();
            this.lblAfastados = new System.Windows.Forms.Label();
            this.progressAfastados = new System.Windows.Forms.ProgressBar();

            this.pnlEventos = new System.Windows.Forms.Panel();
            this.lblEventosTitulo = new System.Windows.Forms.Label();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.lblEvento2 = new System.Windows.Forms.Label();
            this.lblEvento3 = new System.Windows.Forms.Label();
            this.lblEvento4 = new System.Windows.Forms.Label();

            this.pnlAlertas = new System.Windows.Forms.Panel();
            this.lblAlertasTitulo = new System.Windows.Forms.Label();
            this.lblAlerta1 = new System.Windows.Forms.Label();
            this.lblAlerta2 = new System.Windows.Forms.Label();
            this.lblAlerta3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH Control — Gestão de Pessoas";

            // MENU
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(245, 760);

            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;
            this.picLogo.Location = new System.Drawing.Point(68, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 92);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            this.lblNomeSistema.AutoSize = false;
            this.lblNomeSistema.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNomeSistema.ForeColor = System.Drawing.Color.White;
            this.lblNomeSistema.Location = new System.Drawing.Point(20, 140);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(205, 30);
            this.lblNomeSistema.Text = "RH Control";
            this.lblNomeSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtituloMenu.AutoSize = false;
            this.lblSubtituloMenu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtituloMenu.ForeColor = System.Drawing.Color.FromArgb(153, 178, 202);
            this.lblSubtituloMenu.Location = new System.Drawing.Point(20, 169);
            this.lblSubtituloMenu.Name = "lblSubtituloMenu";
            this.lblSubtituloMenu.Size = new System.Drawing.Size(205, 20);
            this.lblSubtituloMenu.Text = "GESTÃO DE PESSOAS";
            this.lblSubtituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(18, 126, 255);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 145, 255);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(18, 210);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(209, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "⌂   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.UseVisualStyleBackColor = false;

            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(20, 48, 75);
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 62, 93);
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(18, 263);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(209, 45);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "●   Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFuncionarios.UseVisualStyleBackColor = false;

            this.btnJornada.BackColor = System.Drawing.Color.FromArgb(20, 48, 75);
            this.btnJornada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJornada.FlatAppearance.BorderSize = 0;
            this.btnJornada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 62, 93);
            this.btnJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJornada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnJornada.ForeColor = System.Drawing.Color.White;
            this.btnJornada.Location = new System.Drawing.Point(18, 316);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(209, 45);
            this.btnJornada.TabIndex = 2;
            this.btnJornada.Text = "▣   Jornada / Calendário";
            this.btnJornada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJornada.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnJornada.UseVisualStyleBackColor = false;

            this.btnFolha.BackColor = System.Drawing.Color.FromArgb(20, 48, 75);
            this.btnFolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolha.FlatAppearance.BorderSize = 0;
            this.btnFolha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 62, 93);
            this.btnFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFolha.ForeColor = System.Drawing.Color.White;
            this.btnFolha.Location = new System.Drawing.Point(18, 369);
            this.btnFolha.Name = "btnFolha";
            this.btnFolha.Size = new System.Drawing.Size(209, 45);
            this.btnFolha.TabIndex = 3;
            this.btnFolha.Text = "$   Folha / Relatórios";
            this.btnFolha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolha.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFolha.UseVisualStyleBackColor = false;

            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(20, 48, 75);
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 62, 93);
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(18, 422);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(209, 45);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "⚙   Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConfiguracoes.UseVisualStyleBackColor = false;

            // SAIR
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 62, 93);
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(18, 650);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(209, 45);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "↪   Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSair.UseVisualStyleBackColor = false;

            this.lblVersao.AutoSize = false;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(125, 151, 177);
            this.lblVersao.Location = new System.Drawing.Point(20, 718);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(205, 20);
            this.lblVersao.Text = "RH Control • v1.0";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblNomeSistema);
            this.pnlMenu.Controls.Add(this.lblSubtituloMenu);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnFuncionarios);
            this.pnlMenu.Controls.Add(this.btnJornada);
            this.pnlMenu.Controls.Add(this.btnFolha);
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.lblVersao);

            // TOPO
            this.pnlTopo.BackColor = System.Drawing.Color.White;
            this.pnlTopo.Location = new System.Drawing.Point(245, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(955, 105);

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.lblTitulo.Location = new System.Drawing.Point(32, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);
            this.lblTitulo.Text = "Dashboard";

            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(105, 122, 140);
            this.lblSubtitulo.Location = new System.Drawing.Point(35, 61);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(500, 22);
            this.lblSubtitulo.Text = "Visão geral das informações mais importantes";

            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(18, 126, 255);
            this.lblUsuario.Location = new System.Drawing.Point(760, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(160, 24);
            this.lblUsuario.Text = "Administrador";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Controls.Add(this.lblUsuario);

            // CARD FUNCIONÁRIOS
            this.pnlCardFuncionarios.BackColor = System.Drawing.Color.White;
            this.pnlCardFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardFuncionarios.Location = new System.Drawing.Point(265, 130);
            this.pnlCardFuncionarios.Name = "pnlCardFuncionarios";
            this.pnlCardFuncionarios.Size = new System.Drawing.Size(175, 110);

            this.lblCardFuncionariosTitulo.AutoSize = false;
            this.lblCardFuncionariosTitulo.BackColor = System.Drawing.Color.FromArgb(18, 126, 255);
            this.lblCardFuncionariosTitulo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCardFuncionariosTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCardFuncionariosTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCardFuncionariosTitulo.Name = "lblCardFuncionariosTitulo";
            this.lblCardFuncionariosTitulo.Size = new System.Drawing.Size(173, 26);
            this.lblCardFuncionariosTitulo.Text = "FUNCIONÁRIOS ATIVOS";
            this.lblCardFuncionariosTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardFuncionariosTitulo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);

            this.lblFuncionariosValor.AutoSize = false;
            this.lblFuncionariosValor.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblFuncionariosValor.ForeColor = System.Drawing.Color.FromArgb(18, 126, 255);
            this.lblFuncionariosValor.Location = new System.Drawing.Point(13, 35);
            this.lblFuncionariosValor.Name = "lblFuncionariosValor";
            this.lblFuncionariosValor.Size = new System.Drawing.Size(145, 38);
            this.lblFuncionariosValor.Text = "24";

            this.lblFuncionariosInfo.AutoSize = false;
            this.lblFuncionariosInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFuncionariosInfo.ForeColor = System.Drawing.Color.FromArgb(115, 128, 142);
            this.lblFuncionariosInfo.Location = new System.Drawing.Point(14, 83);
            this.lblFuncionariosInfo.Name = "lblFuncionariosInfo";
            this.lblFuncionariosInfo.Size = new System.Drawing.Size(145, 18);
            this.lblFuncionariosInfo.Text = "Colaboradores ativos";

            this.pnlCardFuncionarios.Controls.Add(this.lblCardFuncionariosTitulo);
            this.pnlCardFuncionarios.Controls.Add(this.lblFuncionariosValor);
            this.pnlCardFuncionarios.Controls.Add(this.lblFuncionariosInfo);

            // CARD FOLHA
            this.pnlCardFolha.BackColor = System.Drawing.Color.White;
            this.pnlCardFolha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardFolha.Location = new System.Drawing.Point(450, 130);
            this.pnlCardFolha.Name = "pnlCardFolha";
            this.pnlCardFolha.Size = new System.Drawing.Size(175, 110);

            this.lblCardFolhaTitulo.AutoSize = false;
            this.lblCardFolhaTitulo.BackColor = System.Drawing.Color.FromArgb(39, 153, 76);
            this.lblCardFolhaTitulo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCardFolhaTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCardFolhaTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCardFolhaTitulo.Name = "lblCardFolhaTitulo";
            this.lblCardFolhaTitulo.Size = new System.Drawing.Size(173, 26);
            this.lblCardFolhaTitulo.Text = "FOLHA ESTIMADA";
            this.lblCardFolhaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardFolhaTitulo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);

            this.lblFolhaValor.AutoSize = false;
            this.lblFolhaValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFolhaValor.ForeColor = System.Drawing.Color.FromArgb(39, 153, 76);
            this.lblFolhaValor.Location = new System.Drawing.Point(13, 38);
            this.lblFolhaValor.Name = "lblFolhaValor";
            this.lblFolhaValor.Size = new System.Drawing.Size(155, 35);
            this.lblFolhaValor.Text = "R$ 48.750,00";

            this.lblFolhaInfo.AutoSize = false;
            this.lblFolhaInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFolhaInfo.ForeColor = System.Drawing.Color.FromArgb(115, 128, 142);
            this.lblFolhaInfo.Location = new System.Drawing.Point(14, 83);
            this.lblFolhaInfo.Name = "lblFolhaInfo";
            this.lblFolhaInfo.Size = new System.Drawing.Size(145, 18);
            this.lblFolhaInfo.Text = "Total estimado";

            this.pnlCardFolha.Controls.Add(this.lblCardFolhaTitulo);
            this.pnlCardFolha.Controls.Add(this.lblFolhaValor);
            this.pnlCardFolha.Controls.Add(this.lblFolhaInfo);

            // CARD PAGAMENTO
            this.pnlCardPagamento.BackColor = System.Drawing.Color.White;
            this.pnlCardPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPagamento.Location = new System.Drawing.Point(635, 130);
            this.pnlCardPagamento.Name = "pnlCardPagamento";
            this.pnlCardPagamento.Size = new System.Drawing.Size(175, 110);

            this.lblCardPagamentoTitulo.AutoSize = false;
            this.lblCardPagamentoTitulo.BackColor = System.Drawing.Color.FromArgb(123, 31, 162);
            this.lblCardPagamentoTitulo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCardPagamentoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCardPagamentoTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCardPagamentoTitulo.Name = "lblCardPagamentoTitulo";
            this.lblCardPagamentoTitulo.Size = new System.Drawing.Size(173, 26);
            this.lblCardPagamentoTitulo.Text = "PRÓXIMO PAGAMENTO";
            this.lblCardPagamentoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardPagamentoTitulo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);

            this.lblPagamentoValor.AutoSize = false;
            this.lblPagamentoValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPagamentoValor.ForeColor = System.Drawing.Color.FromArgb(123, 31, 162);
            this.lblPagamentoValor.Location = new System.Drawing.Point(13, 35);
            this.lblPagamentoValor.Name = "lblPagamentoValor";
            this.lblPagamentoValor.Size = new System.Drawing.Size(145, 38);
            this.lblPagamentoValor.Text = "05/09";

            this.lblPagamentoInfo.AutoSize = false;
            this.lblPagamentoInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPagamentoInfo.ForeColor = System.Drawing.Color.FromArgb(115, 128, 142);
            this.lblPagamentoInfo.Location = new System.Drawing.Point(14, 83);
            this.lblPagamentoInfo.Name = "lblPagamentoInfo";
            this.lblPagamentoInfo.Size = new System.Drawing.Size(145, 18);
            this.lblPagamentoInfo.Text = "5º dia útil";

            this.pnlCardPagamento.Controls.Add(this.lblCardPagamentoTitulo);
            this.pnlCardPagamento.Controls.Add(this.lblPagamentoValor);
            this.pnlCardPagamento.Controls.Add(this.lblPagamentoInfo);

            // CARD ADIANTAMENTO
            this.pnlCardAdiantamento.BackColor = System.Drawing.Color.White;
            this.pnlCardAdiantamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAdiantamento.Location = new System.Drawing.Point(820, 130);
            this.pnlCardAdiantamento.Name = "pnlCardAdiantamento";
            this.pnlCardAdiantamento.Size = new System.Drawing.Size(175, 110);

            this.lblCardAdiantamentoTitulo.AutoSize = false;
            this.lblCardAdiantamentoTitulo.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblCardAdiantamentoTitulo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCardAdiantamentoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCardAdiantamentoTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCardAdiantamentoTitulo.Name = "lblCardAdiantamentoTitulo";
            this.lblCardAdiantamentoTitulo.Size = new System.Drawing.Size(173, 26);
            this.lblCardAdiantamentoTitulo.Text = "PRÓX. ADIANTAMENTO";
            this.lblCardAdiantamentoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardAdiantamentoTitulo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);

            this.lblAdiantamentoValor.AutoSize = false;
            this.lblAdiantamentoValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAdiantamentoValor.ForeColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblAdiantamentoValor.Location = new System.Drawing.Point(13, 35);
            this.lblAdiantamentoValor.Name = "lblAdiantamentoValor";
            this.lblAdiantamentoValor.Size = new System.Drawing.Size(145, 38);
            this.lblAdiantamentoValor.Text = "20/09";

            this.lblAdiantamentoInfo.AutoSize = false;
            this.lblAdiantamentoInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAdiantamentoInfo.ForeColor = System.Drawing.Color.FromArgb(115, 128, 142);
            this.lblAdiantamentoInfo.Location = new System.Drawing.Point(14, 83);
            this.lblAdiantamentoInfo.Name = "lblAdiantamentoInfo";
            this.lblAdiantamentoInfo.Size = new System.Drawing.Size(145, 18);
            this.lblAdiantamentoInfo.Text = "Data configurada";

            this.pnlCardAdiantamento.Controls.Add(this.lblCardAdiantamentoTitulo);
            this.pnlCardAdiantamento.Controls.Add(this.lblAdiantamentoValor);
            this.pnlCardAdiantamento.Controls.Add(this.lblAdiantamentoInfo);

            // CARD FÉRIAS
            this.pnlCardFerias.BackColor = System.Drawing.Color.White;
            this.pnlCardFerias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardFerias.Location = new System.Drawing.Point(1005, 130);
            this.pnlCardFerias.Name = "pnlCardFerias";
            this.pnlCardFerias.Size = new System.Drawing.Size(175, 110);

            this.lblCardFeriasTitulo.AutoSize = false;
            this.lblCardFeriasTitulo.BackColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.lblCardFeriasTitulo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCardFeriasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblCardFeriasTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCardFeriasTitulo.Name = "lblCardFeriasTitulo";
            this.lblCardFeriasTitulo.Size = new System.Drawing.Size(173, 26);
            this.lblCardFeriasTitulo.Text = "FÉRIAS PRÓXIMAS";
            this.lblCardFeriasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardFeriasTitulo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);

            this.lblFeriasValor.AutoSize = false;
            this.lblFeriasValor.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblFeriasValor.ForeColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.lblFeriasValor.Location = new System.Drawing.Point(13, 35);
            this.lblFeriasValor.Name = "lblFeriasValor";
            this.lblFeriasValor.Size = new System.Drawing.Size(145, 38);
            this.lblFeriasValor.Text = "3";

            this.lblFeriasInfo.AutoSize = false;
            this.lblFeriasInfo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFeriasInfo.ForeColor = System.Drawing.Color.FromArgb(115, 128, 142);
            this.lblFeriasInfo.Location = new System.Drawing.Point(14, 83);
            this.lblFeriasInfo.Name = "lblFeriasInfo";
            this.lblFeriasInfo.Size = new System.Drawing.Size(145, 18);
            this.lblFeriasInfo.Text = "Próximos 30 dias";

            this.pnlCardFerias.Controls.Add(this.lblCardFeriasTitulo);
            this.pnlCardFerias.Controls.Add(this.lblFeriasValor);
            this.pnlCardFerias.Controls.Add(this.lblFeriasInfo);

            // SITUAÇÃO
            this.pnlSituacao.BackColor = System.Drawing.Color.White;
            this.pnlSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSituacao.Location = new System.Drawing.Point(265, 265);
            this.pnlSituacao.Name = "pnlSituacao";
            this.pnlSituacao.Size = new System.Drawing.Size(455, 275);

            this.lblSituacaoTitulo.AutoSize = false;
            this.lblSituacaoTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSituacaoTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.lblSituacaoTitulo.Location = new System.Drawing.Point(22, 17);
            this.lblSituacaoTitulo.Name = "lblSituacaoTitulo";
            this.lblSituacaoTitulo.Size = new System.Drawing.Size(400, 28);
            this.lblSituacaoTitulo.Text = "Funcionários por situação";

            this.lblSituacaoResumo.AutoSize = false;
            this.lblSituacaoResumo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSituacaoResumo.ForeColor = System.Drawing.Color.FromArgb(120, 135, 150);
            this.lblSituacaoResumo.Location = new System.Drawing.Point(24, 46);
            this.lblSituacaoResumo.Name = "lblSituacaoResumo";
            this.lblSituacaoResumo.Size = new System.Drawing.Size(400, 22);
            this.lblSituacaoResumo.Text = "Distribuição atual dos colaboradores";

            this.lblAtivos.AutoSize = false;
            this.lblAtivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAtivos.ForeColor = System.Drawing.Color.FromArgb(39, 153, 76);
            this.lblAtivos.Location = new System.Drawing.Point(24, 80);
            this.lblAtivos.Name = "lblAtivos";
            this.lblAtivos.Size = new System.Drawing.Size(390, 22);
            this.lblAtivos.Text = "Ativos — 20";

            this.progressAtivos.Location = new System.Drawing.Point(24, 105);
            this.progressAtivos.Name = "progressAtivos";
            this.progressAtivos.Size = new System.Drawing.Size(405, 13);
            this.progressAtivos.Minimum = 0;
            this.progressAtivos.Maximum = 100;
            this.progressAtivos.Value = 83;
            this.progressAtivos.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.lblFerias.AutoSize = false;
            this.lblFerias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFerias.ForeColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.lblFerias.Location = new System.Drawing.Point(24, 137);
            this.lblFerias.Name = "lblFerias";
            this.lblFerias.Size = new System.Drawing.Size(390, 22);
            this.lblFerias.Text = "Férias — 3";

            this.progressFerias.Location = new System.Drawing.Point(24, 162);
            this.progressFerias.Name = "progressFerias";
            this.progressFerias.Size = new System.Drawing.Size(405, 13);
            this.progressFerias.Minimum = 0;
            this.progressFerias.Maximum = 100;
            this.progressFerias.Value = 13;
            this.progressFerias.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.lblAfastados.AutoSize = false;
            this.lblAfastados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAfastados.ForeColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblAfastados.Location = new System.Drawing.Point(24, 194);
            this.lblAfastados.Name = "lblAfastados";
            this.lblAfastados.Size = new System.Drawing.Size(390, 22);
            this.lblAfastados.Text = "Afastados — 1";

            this.progressAfastados.Location = new System.Drawing.Point(24, 219);
            this.progressAfastados.Name = "progressAfastados";
            this.progressAfastados.Size = new System.Drawing.Size(405, 13);
            this.progressAfastados.Minimum = 0;
            this.progressAfastados.Maximum = 100;
            this.progressAfastados.Value = 4;
            this.progressAfastados.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.pnlSituacao.Controls.Add(this.lblSituacaoTitulo);
            this.pnlSituacao.Controls.Add(this.lblSituacaoResumo);
            this.pnlSituacao.Controls.Add(this.lblAtivos);
            this.pnlSituacao.Controls.Add(this.progressAtivos);
            this.pnlSituacao.Controls.Add(this.lblFerias);
            this.pnlSituacao.Controls.Add(this.progressFerias);
            this.pnlSituacao.Controls.Add(this.lblAfastados);
            this.pnlSituacao.Controls.Add(this.progressAfastados);

            // EVENTOS
            this.pnlEventos.BackColor = System.Drawing.Color.White;
            this.pnlEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventos.Location = new System.Drawing.Point(740, 265);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(440, 275);

            this.lblEventosTitulo.AutoSize = false;
            this.lblEventosTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEventosTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.lblEventosTitulo.Location = new System.Drawing.Point(22, 17);
            this.lblEventosTitulo.Name = "lblEventosTitulo";
            this.lblEventosTitulo.Size = new System.Drawing.Size(390, 28);
            this.lblEventosTitulo.Text = "Próximos eventos";

            this.lblEvento1.AutoSize = false;
            this.lblEvento1.BackColor = System.Drawing.Color.FromArgb(246, 249, 252);
            this.lblEvento1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEvento1.ForeColor = System.Drawing.Color.FromArgb(55, 68, 82);
            this.lblEvento1.Location = new System.Drawing.Point(22, 61);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(390, 32);
            this.lblEvento1.Text = "  Início de férias  —  10/09/2026";
            this.lblEvento1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblEvento2.AutoSize = false;
            this.lblEvento2.BackColor = System.Drawing.Color.FromArgb(246, 249, 252);
            this.lblEvento2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEvento2.ForeColor = System.Drawing.Color.FromArgb(55, 68, 82);
            this.lblEvento2.Location = new System.Drawing.Point(22, 100);
            this.lblEvento2.Name = "lblEvento2";
            this.lblEvento2.Size = new System.Drawing.Size(390, 32);
            this.lblEvento2.Text = "  Fim de férias  —  24/09/2026";
            this.lblEvento2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblEvento3.AutoSize = false;
            this.lblEvento3.BackColor = System.Drawing.Color.FromArgb(246, 249, 252);
            this.lblEvento3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEvento3.ForeColor = System.Drawing.Color.FromArgb(55, 68, 82);
            this.lblEvento3.Location = new System.Drawing.Point(22, 139);
            this.lblEvento3.Name = "lblEvento3";
            this.lblEvento3.Size = new System.Drawing.Size(390, 32);
            this.lblEvento3.Text = "  Adiantamento  —  20/09/2026";
            this.lblEvento3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblEvento4.AutoSize = false;
            this.lblEvento4.BackColor = System.Drawing.Color.FromArgb(246, 249, 252);
            this.lblEvento4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEvento4.ForeColor = System.Drawing.Color.FromArgb(55, 68, 82);
            this.lblEvento4.Location = new System.Drawing.Point(22, 178);
            this.lblEvento4.Name = "lblEvento4";
            this.lblEvento4.Size = new System.Drawing.Size(390, 32);
            this.lblEvento4.Text = "  Folha mensal  —  05/10/2026";
            this.lblEvento4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlEventos.Controls.Add(this.lblEventosTitulo);
            this.pnlEventos.Controls.Add(this.lblEvento1);
            this.pnlEventos.Controls.Add(this.lblEvento2);
            this.pnlEventos.Controls.Add(this.lblEvento3);
            this.pnlEventos.Controls.Add(this.lblEvento4);

            // ALERTAS
            this.pnlAlertas.BackColor = System.Drawing.Color.White;
            this.pnlAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertas.Location = new System.Drawing.Point(265, 560);
            this.pnlAlertas.Name = "pnlAlertas";
            this.pnlAlertas.Size = new System.Drawing.Size(915, 145);

            this.lblAlertasTitulo.AutoSize = false;
            this.lblAlertasTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAlertasTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 30, 50);
            this.lblAlertasTitulo.Location = new System.Drawing.Point(22, 16);
            this.lblAlertasTitulo.Name = "lblAlertasTitulo";
            this.lblAlertasTitulo.Size = new System.Drawing.Size(400, 28);
            this.lblAlertasTitulo.Text = "Alertas";

            this.lblAlerta1.AutoSize = false;
            this.lblAlerta1.BackColor = System.Drawing.Color.FromArgb(255, 248, 235);
            this.lblAlerta1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlerta1.ForeColor = System.Drawing.Color.FromArgb(130, 80, 15);
            this.lblAlerta1.Location = new System.Drawing.Point(22, 57);
            this.lblAlerta1.Name = "lblAlerta1";
            this.lblAlerta1.Size = new System.Drawing.Size(265, 46);
            this.lblAlerta1.Text = "  1 funcionário com banco de horas negativo.";
            this.lblAlerta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblAlerta2.AutoSize = false;
            this.lblAlerta2.BackColor = System.Drawing.Color.FromArgb(244, 248, 252);
            this.lblAlerta2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlerta2.ForeColor = System.Drawing.Color.FromArgb(55, 65, 75);
            this.lblAlerta2.Location = new System.Drawing.Point(327, 57);
            this.lblAlerta2.Name = "lblAlerta2";
            this.lblAlerta2.Size = new System.Drawing.Size(265, 46);
            this.lblAlerta2.Text = "  2 registros de ponto incompletos.";
            this.lblAlerta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblAlerta3.AutoSize = false;
            this.lblAlerta3.BackColor = System.Drawing.Color.FromArgb(238, 250, 247);
            this.lblAlerta3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlerta3.ForeColor = System.Drawing.Color.FromArgb(0, 105, 92);
            this.lblAlerta3.Location = new System.Drawing.Point(632, 57);
            this.lblAlerta3.Name = "lblAlerta3";
            this.lblAlerta3.Size = new System.Drawing.Size(255, 46);
            this.lblAlerta3.Text = "  3 férias programadas.";
            this.lblAlerta3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlAlertas.Controls.Add(this.lblAlertasTitulo);
            this.pnlAlertas.Controls.Add(this.lblAlerta1);
            this.pnlAlertas.Controls.Add(this.lblAlerta2);
            this.pnlAlertas.Controls.Add(this.lblAlerta3);

            // FORM CONTROLS
            this.Controls.Add(this.pnlAlertas);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.pnlSituacao);
            this.Controls.Add(this.pnlCardFerias);
            this.Controls.Add(this.pnlCardAdiantamento);
            this.Controls.Add(this.pnlCardPagamento);
            this.Controls.Add(this.pnlCardFolha);
            this.Controls.Add(this.pnlCardFuncionarios);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlMenu);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
