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
        private System.Windows.Forms.Label lblFerias;
        private System.Windows.Forms.Label lblAfastados;
        private System.Windows.Forms.ProgressBar progressAtivos;
        private System.Windows.Forms.ProgressBar progressFerias;
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

        #region Windows Form Designer generated code

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

            this.pnlMenu.SuspendLayout();
            this.pnlTopo.SuspendLayout();

            this.pnlCardFuncionarios.SuspendLayout();
            this.pnlCardFolha.SuspendLayout();
            this.pnlCardPagamento.SuspendLayout();
            this.pnlCardAdiantamento.SuspendLayout();
            this.pnlCardFerias.SuspendLayout();

            this.pnlSituacao.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.pnlAlertas.SuspendLayout();

            this.SuspendLayout();

            // =========================================================
            // MENU LATERAL
            // =========================================================

            this.pnlMenu.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            this.pnlMenu.Location =
                new System.Drawing.Point(0, 0);

            this.pnlMenu.Name =
                "pnlMenu";

            this.pnlMenu.Size =
                new System.Drawing.Size(220, 700);

            // =========================================================
            // LOGO
            // =========================================================

            this.picLogo.Image =
                global::RHControl.Properties.Resources.logorh;

            this.picLogo.Location =
                new System.Drawing.Point(55, 25);

            this.picLogo.Name =
                "picLogo";

            this.picLogo.Size =
                new System.Drawing.Size(110, 90);

            this.picLogo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picLogo.TabStop =
                false;

            // =========================================================
            // NOME
            // =========================================================

            this.lblNomeSistema.AutoSize = true;

            this.lblNomeSistema.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold);

            this.lblNomeSistema.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblNomeSistema.Location =
                new System.Drawing.Point(52, 120);

            this.lblNomeSistema.Name =
                "lblNomeSistema";

            this.lblNomeSistema.Text =
                "RH Control";

            // =========================================================
            // SUBTÍTULO
            // =========================================================

            this.lblSubtituloMenu.AutoSize = true;

            this.lblSubtituloMenu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F);

            this.lblSubtituloMenu.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSubtituloMenu.Location =
                new System.Drawing.Point(61, 145);

            this.lblSubtituloMenu.Name =
                "lblSubtituloMenu";

            this.lblSubtituloMenu.Text =
                "Gestão de Pessoas";

            // =========================================================
            // BOTÃO DASHBOARD
            // =========================================================

            this.btnDashboard.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.btnDashboard.FlatAppearance.BorderSize =
                0;

            this.btnDashboard.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(13, 71, 161);

            this.btnDashboard.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(25, 118, 210);

            this.btnDashboard.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDashboard.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnDashboard.ForeColor =
                System.Drawing.Color.White;

            this.btnDashboard.Location =
                new System.Drawing.Point(15, 190);

            this.btnDashboard.Name =
                "btnDashboard";

            this.btnDashboard.Size =
                new System.Drawing.Size(190, 44);

            this.btnDashboard.Text =
                "     Dashboard";

            this.btnDashboard.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================================
            // BOTÃO FUNCIONÁRIOS
            // =========================================================

            this.btnFuncionarios.BackColor =
                System.Drawing.Color.White;

            this.btnFuncionarios.FlatAppearance.BorderSize =
                1;

            this.btnFuncionarios.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnFuncionarios.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnFuncionarios.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(220, 235, 255);

            this.btnFuncionarios.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFuncionarios.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnFuncionarios.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 55);

            this.btnFuncionarios.Location =
                new System.Drawing.Point(15, 242);

            this.btnFuncionarios.Name =
                "btnFuncionarios";

            this.btnFuncionarios.Size =
                new System.Drawing.Size(190, 44);

            this.btnFuncionarios.Text =
                "     Funcionários";

            this.btnFuncionarios.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================================
            // BOTÃO JORNADA
            // =========================================================

            this.btnJornada.BackColor =
                System.Drawing.Color.White;

            this.btnJornada.FlatAppearance.BorderSize =
                1;

            this.btnJornada.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnJornada.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnJornada.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(220, 235, 255);

            this.btnJornada.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnJornada.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnJornada.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 55);

            this.btnJornada.Location =
                new System.Drawing.Point(15, 294);

            this.btnJornada.Name =
                "btnJornada";

            this.btnJornada.Size =
                new System.Drawing.Size(190, 44);

            this.btnJornada.Text =
                "     Jornada / Calendário";

            this.btnJornada.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================================
            // BOTÃO FOLHA
            // =========================================================

            this.btnFolha.BackColor =
                System.Drawing.Color.White;

            this.btnFolha.FlatAppearance.BorderSize =
                1;

            this.btnFolha.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnFolha.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnFolha.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(220, 235, 255);

            this.btnFolha.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFolha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnFolha.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 55);

            this.btnFolha.Location =
                new System.Drawing.Point(15, 346);

            this.btnFolha.Name =
                "btnFolha";

            this.btnFolha.Size =
                new System.Drawing.Size(190, 44);

            this.btnFolha.Text =
                "     Folha / Relatórios";

            this.btnFolha.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================================
            // BOTÃO CONFIGURAÇÕES
            // =========================================================

            this.btnConfiguracoes.BackColor =
                System.Drawing.Color.White;

            this.btnConfiguracoes.FlatAppearance.BorderSize =
                1;

            this.btnConfiguracoes.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnConfiguracoes.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(220, 235, 255);

            this.btnConfiguracoes.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnConfiguracoes.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnConfiguracoes.ForeColor =
                System.Drawing.Color.FromArgb(55, 55, 55);

            this.btnConfiguracoes.Location =
                new System.Drawing.Point(15, 398);

            this.btnConfiguracoes.Name =
                "btnConfiguracoes";

            this.btnConfiguracoes.Size =
                new System.Drawing.Size(190, 44);

            this.btnConfiguracoes.Text =
                "     Configurações";

            this.btnConfiguracoes.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =========================================================
            // VERSÃO
            // =========================================================

            this.lblVersao.AutoSize = true;

            this.lblVersao.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F);

            this.lblVersao.ForeColor =
                System.Drawing.Color.Gray;

            this.lblVersao.Location =
                new System.Drawing.Point(65, 655);

            this.lblVersao.Name =
                "lblVersao";

            this.lblVersao.Text =
                "RH Control • v1.0";

            // =========================================================
            // TOPO
            // =========================================================

            this.pnlTopo.BackColor =
                System.Drawing.Color.White;

            this.pnlTopo.Location =
                new System.Drawing.Point(220, 0);

            this.pnlTopo.Name =
                "pnlTopo";

            this.pnlTopo.Size =
                new System.Drawing.Size(880, 95);

            // =========================================================
            // TÍTULO
            // =========================================================

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(35, 35, 35);

            this.lblTitulo.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Dashboard";

            // =========================================================
            // SUBTÍTULO
            // =========================================================

            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSubtitulo.Location =
                new System.Drawing.Point(32, 57);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Text =
                "Visão geral das informações mais importantes";

            // =========================================================
            // USUÁRIO
            // =========================================================

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblUsuario.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblUsuario.Location =
                new System.Drawing.Point(745, 35);

            this.lblUsuario.Name =
                "lblUsuario";

            this.lblUsuario.Text =
                "Administrador";

            // =========================================================
            // CARD FUNCIONÁRIOS
            // =========================================================

            this.pnlCardFuncionarios.BackColor =
                System.Drawing.Color.White;

            this.pnlCardFuncionarios.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCardFuncionarios.Location =
                new System.Drawing.Point(235, 115);

            this.pnlCardFuncionarios.Name =
                "pnlCardFuncionarios";

            this.pnlCardFuncionarios.Size =
                new System.Drawing.Size(160, 115);

            this.lblCardFuncionariosTitulo.AutoSize = true;

            this.lblCardFuncionariosTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblCardFuncionariosTitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCardFuncionariosTitulo.Location =
                new System.Drawing.Point(12, 13);

            this.lblCardFuncionariosTitulo.Text =
                "Funcionários ativos";

            this.lblFuncionariosValor.AutoSize = true;

            this.lblFuncionariosValor.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblFuncionariosValor.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblFuncionariosValor.Location =
                new System.Drawing.Point(12, 37);

            this.lblFuncionariosValor.Text =
                "24";

            this.lblFuncionariosInfo.AutoSize = true;

            this.lblFuncionariosInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    7.5F);

            this.lblFuncionariosInfo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblFuncionariosInfo.Location =
                new System.Drawing.Point(14, 84);

            this.lblFuncionariosInfo.Text =
                "Colaboradores ativos";

            // =========================================================
            // CARD FOLHA
            // =========================================================

            this.pnlCardFolha.BackColor =
                System.Drawing.Color.White;

            this.pnlCardFolha.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCardFolha.Location =
                new System.Drawing.Point(405, 115);

            this.pnlCardFolha.Name =
                "pnlCardFolha";

            this.pnlCardFolha.Size =
                new System.Drawing.Size(160, 115);

            this.lblCardFolhaTitulo.AutoSize = true;

            this.lblCardFolhaTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblCardFolhaTitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCardFolhaTitulo.Location =
                new System.Drawing.Point(12, 13);

            this.lblCardFolhaTitulo.Text =
                "Folha estimada";

            this.lblFolhaValor.AutoSize = true;

            this.lblFolhaValor.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    15F,
                    System.Drawing.FontStyle.Bold);

            this.lblFolhaValor.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblFolhaValor.Location =
                new System.Drawing.Point(12, 43);

            this.lblFolhaValor.Text =
                "R$ 48.750,00";

            this.lblFolhaInfo.AutoSize = true;

            this.lblFolhaInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    7.5F);

            this.lblFolhaInfo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblFolhaInfo.Location =
                new System.Drawing.Point(14, 84);

            this.lblFolhaInfo.Text =
                "Total estimado";

            // =========================================================
            // CARD PAGAMENTO
            // =========================================================

            this.pnlCardPagamento.BackColor =
                System.Drawing.Color.White;

            this.pnlCardPagamento.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCardPagamento.Location =
                new System.Drawing.Point(575, 115);

            this.pnlCardPagamento.Name =
                "pnlCardPagamento";

            this.pnlCardPagamento.Size =
                new System.Drawing.Size(160, 115);

            this.lblCardPagamentoTitulo.AutoSize = true;

            this.lblCardPagamentoTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblCardPagamentoTitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCardPagamentoTitulo.Location =
                new System.Drawing.Point(12, 13);

            this.lblCardPagamentoTitulo.Text =
                "Próximo pagamento";

            this.lblPagamentoValor.AutoSize = true;

            this.lblPagamentoValor.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblPagamentoValor.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblPagamentoValor.Location =
                new System.Drawing.Point(12, 40);

            this.lblPagamentoValor.Text =
                "05/09";

            this.lblPagamentoInfo.AutoSize = true;

            this.lblPagamentoInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    7.5F);

            this.lblPagamentoInfo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblPagamentoInfo.Location =
                new System.Drawing.Point(14, 84);

            this.lblPagamentoInfo.Text =
                "5º dia útil";

            // =========================================================
            // CARD ADIANTAMENTO
            // =========================================================

            this.pnlCardAdiantamento.BackColor =
                System.Drawing.Color.White;

            this.pnlCardAdiantamento.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCardAdiantamento.Location =
                new System.Drawing.Point(745, 115);

            this.pnlCardAdiantamento.Name =
                "pnlCardAdiantamento";

            this.pnlCardAdiantamento.Size =
                new System.Drawing.Size(160, 115);

            this.lblCardAdiantamentoTitulo.AutoSize = true;

            this.lblCardAdiantamentoTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblCardAdiantamentoTitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCardAdiantamentoTitulo.Location =
                new System.Drawing.Point(12, 13);

            this.lblCardAdiantamentoTitulo.Text =
                "Próximo adiantamento";

            this.lblAdiantamentoValor.AutoSize = true;

            this.lblAdiantamentoValor.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblAdiantamentoValor.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblAdiantamentoValor.Location =
                new System.Drawing.Point(12, 40);

            this.lblAdiantamentoValor.Text =
                "20/09";

            this.lblAdiantamentoInfo.AutoSize = true;

            this.lblAdiantamentoInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    7.5F);

            this.lblAdiantamentoInfo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblAdiantamentoInfo.Location =
                new System.Drawing.Point(14, 84);

            this.lblAdiantamentoInfo.Text =
                "Data configurada";

            // =========================================================
            // CARD FÉRIAS
            // =========================================================

            this.pnlCardFerias.BackColor =
                System.Drawing.Color.White;

            this.pnlCardFerias.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCardFerias.Location =
                new System.Drawing.Point(915, 115);

            this.pnlCardFerias.Name =
                "pnlCardFerias";

            this.pnlCardFerias.Size =
                new System.Drawing.Size(160, 115);

            this.lblCardFeriasTitulo.AutoSize = true;

            this.lblCardFeriasTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblCardFeriasTitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCardFeriasTitulo.Location =
                new System.Drawing.Point(12, 13);

            this.lblCardFeriasTitulo.Text =
                "Férias próximas";

            this.lblFeriasValor.AutoSize = true;

            this.lblFeriasValor.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblFeriasValor.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblFeriasValor.Location =
                new System.Drawing.Point(12, 37);

            this.lblFeriasValor.Text =
                "3";

            this.lblFeriasInfo.AutoSize = true;

            this.lblFeriasInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    7.5F);

            this.lblFeriasInfo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblFeriasInfo.Location =
                new System.Drawing.Point(14, 84);

            this.lblFeriasInfo.Text =
                "Próximos 30 dias";

            // =========================================================
            // FUNCIONÁRIOS POR SITUAÇÃO
            // =========================================================

            this.pnlSituacao.BackColor =
                System.Drawing.Color.White;

            this.pnlSituacao.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlSituacao.Location =
                new System.Drawing.Point(235, 250);

            this.pnlSituacao.Name =
                "pnlSituacao";

            this.pnlSituacao.Size =
                new System.Drawing.Size(410, 265);

            this.lblSituacaoTitulo.AutoSize = true;

            this.lblSituacaoTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblSituacaoTitulo.Location =
                new System.Drawing.Point(18, 17);

            this.lblSituacaoTitulo.Text =
                "Funcionários por situação";

            this.lblSituacaoResumo.AutoSize = true;

            this.lblSituacaoResumo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblSituacaoResumo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSituacaoResumo.Location =
                new System.Drawing.Point(20, 46);

            this.lblSituacaoResumo.Text =
                "Distribuição atual dos colaboradores";

            this.lblAtivos.AutoSize = true;

            this.lblAtivos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblAtivos.Location =
                new System.Drawing.Point(20, 80);

            this.lblAtivos.Text =
                "Ativos — 20";

            this.progressAtivos.Location =
                new System.Drawing.Point(20, 104);

            this.progressAtivos.Size =
                new System.Drawing.Size(365, 12);

            this.progressAtivos.Value =
                83;

            this.lblFerias.AutoSize = true;

            this.lblFerias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblFerias.Location =
                new System.Drawing.Point(20, 135);

            this.lblFerias.Text =
                "Férias — 3";

            this.progressFerias.Location =
                new System.Drawing.Point(20, 159);

            this.progressFerias.Size =
                new System.Drawing.Size(365, 12);

            this.progressFerias.Value =
                13;

            this.lblAfastados.AutoSize = true;

            this.lblAfastados.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblAfastados.Location =
                new System.Drawing.Point(20, 190);

            this.lblAfastados.Text =
                "Afastados — 1";

            this.progressAfastados.Location =
                new System.Drawing.Point(20, 214);

            this.progressAfastados.Size =
                new System.Drawing.Size(365, 12);

            this.progressAfastados.Value =
                4;

            // =========================================================
            // PRÓXIMOS EVENTOS
            // =========================================================

            this.pnlEventos.BackColor =
                System.Drawing.Color.White;

            this.pnlEventos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlEventos.Location =
                new System.Drawing.Point(665, 250);

            this.pnlEventos.Name =
                "pnlEventos";

            this.pnlEventos.Size =
                new System.Drawing.Size(410, 265);

            this.lblEventosTitulo.AutoSize = true;

            this.lblEventosTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblEventosTitulo.Location =
                new System.Drawing.Point(18, 17);

            this.lblEventosTitulo.Text =
                "Próximos eventos";

            this.lblEvento1.AutoSize = true;

            this.lblEvento1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblEvento1.Location =
                new System.Drawing.Point(20, 62);

            this.lblEvento1.Text =
                "• Início de férias — 10/09/2026";

            this.lblEvento2.AutoSize = true;

            this.lblEvento2.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblEvento2.Location =
                new System.Drawing.Point(20, 100);

            this.lblEvento2.Text =
                "• Fim de férias — 24/09/2026";

            this.lblEvento3.AutoSize = true;

            this.lblEvento3.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblEvento3.Location =
                new System.Drawing.Point(20, 138);

            this.lblEvento3.Text =
                "• Adiantamento — 20/09/2026";

            this.lblEvento4.AutoSize = true;

            this.lblEvento4.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblEvento4.Location =
                new System.Drawing.Point(20, 176);

            this.lblEvento4.Text =
                "• Folha mensal — 05/10/2026";

            // =========================================================
            // ALERTAS
            // =========================================================

            this.pnlAlertas.BackColor =
                System.Drawing.Color.White;

            this.pnlAlertas.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlAlertas.Location =
                new System.Drawing.Point(235, 535);

            this.pnlAlertas.Name =
                "pnlAlertas";

            this.pnlAlertas.Size =
                new System.Drawing.Size(840, 115);

            this.lblAlertasTitulo.AutoSize = true;

            this.lblAlertasTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblAlertasTitulo.Location =
                new System.Drawing.Point(18, 15);

            this.lblAlertasTitulo.Text =
                "Alertas";

            this.lblAlerta1.AutoSize = true;

            this.lblAlerta1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblAlerta1.Location =
                new System.Drawing.Point(20, 55);

            this.lblAlerta1.Text =
                "• 1 funcionário com banco de horas negativo.";

            this.lblAlerta2.AutoSize = true;

            this.lblAlerta2.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblAlerta2.Location =
                new System.Drawing.Point(300, 55);

            this.lblAlerta2.Text =
                "• 2 registros de ponto incompletos.";

            this.lblAlerta3.AutoSize = true;

            this.lblAlerta3.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblAlerta3.Location =
                new System.Drawing.Point(585, 55);

            this.lblAlerta3.Text =
                "• 3 férias programadas.";

            // =========================================================
            // ADICIONAR CONTROLES AO MENU
            // =========================================================

            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblNomeSistema);
            this.pnlMenu.Controls.Add(this.lblSubtituloMenu);

            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnFuncionarios);
            this.pnlMenu.Controls.Add(this.btnJornada);
            this.pnlMenu.Controls.Add(this.btnFolha);
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);

            this.pnlMenu.Controls.Add(this.lblVersao);

            // =========================================================
            // ADICIONAR CONTROLES AO TOPO
            // =========================================================

            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Controls.Add(this.lblUsuario);

            // =========================================================
            // ADICIONAR CONTROLES AOS CARDS
            // =========================================================

            this.pnlCardFuncionarios.Controls.Add(
                this.lblCardFuncionariosTitulo);

            this.pnlCardFuncionarios.Controls.Add(
                this.lblFuncionariosValor);

            this.pnlCardFuncionarios.Controls.Add(
                this.lblFuncionariosInfo);

            this.pnlCardFolha.Controls.Add(
                this.lblCardFolhaTitulo);

            this.pnlCardFolha.Controls.Add(
                this.lblFolhaValor);

            this.pnlCardFolha.Controls.Add(
                this.lblFolhaInfo);

            this.pnlCardPagamento.Controls.Add(
                this.lblCardPagamentoTitulo);

            this.pnlCardPagamento.Controls.Add(
                this.lblPagamentoValor);

            this.pnlCardPagamento.Controls.Add(
                this.lblPagamentoInfo);

            this.pnlCardAdiantamento.Controls.Add(
                this.lblCardAdiantamentoTitulo);

            this.pnlCardAdiantamento.Controls.Add(
                this.lblAdiantamentoValor);

            this.pnlCardAdiantamento.Controls.Add(
                this.lblAdiantamentoInfo);

            this.pnlCardFerias.Controls.Add(
                this.lblCardFeriasTitulo);

            this.pnlCardFerias.Controls.Add(
                this.lblFeriasValor);

            this.pnlCardFerias.Controls.Add(
                this.lblFeriasInfo);

            // =========================================================
            // SITUAÇÃO
            // =========================================================

            this.pnlSituacao.Controls.Add(
                this.lblSituacaoTitulo);

            this.pnlSituacao.Controls.Add(
                this.lblSituacaoResumo);

            this.pnlSituacao.Controls.Add(
                this.lblAtivos);

            this.pnlSituacao.Controls.Add(
                this.progressAtivos);

            this.pnlSituacao.Controls.Add(
                this.lblFerias);

            this.pnlSituacao.Controls.Add(
                this.progressFerias);

            this.pnlSituacao.Controls.Add(
                this.lblAfastados);

            this.pnlSituacao.Controls.Add(
                this.progressAfastados);

            // =========================================================
            // EVENTOS
            // =========================================================

            this.pnlEventos.Controls.Add(
                this.lblEventosTitulo);

            this.pnlEventos.Controls.Add(
                this.lblEvento1);

            this.pnlEventos.Controls.Add(
                this.lblEvento2);

            this.pnlEventos.Controls.Add(
                this.lblEvento3);

            this.pnlEventos.Controls.Add(
                this.lblEvento4);

            // =========================================================
            // ALERTAS
            // =========================================================

            this.pnlAlertas.Controls.Add(
                this.lblAlertasTitulo);

            this.pnlAlertas.Controls.Add(
                this.lblAlerta1);

            this.pnlAlertas.Controls.Add(
                this.lblAlerta2);

            this.pnlAlertas.Controls.Add(
                this.lblAlerta3);

            // =========================================================
            // FORMULÁRIO
            // =========================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1100, 700);

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

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = true;

            this.Name =
                "FrmDashboard";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "RH Control — Gestão de Pessoas";

            ((System.ComponentModel.ISupportInitialize)
                (this.picLogo)).EndInit();

            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();

            this.pnlCardFuncionarios.ResumeLayout(false);
            this.pnlCardFuncionarios.PerformLayout();

            this.pnlCardFolha.ResumeLayout(false);
            this.pnlCardFolha.PerformLayout();

            this.pnlCardPagamento.ResumeLayout(false);
            this.pnlCardPagamento.PerformLayout();

            this.pnlCardAdiantamento.ResumeLayout(false);
            this.pnlCardAdiantamento.PerformLayout();

            this.pnlCardFerias.ResumeLayout(false);
            this.pnlCardFerias.PerformLayout();

            this.pnlSituacao.ResumeLayout(false);
            this.pnlSituacao.PerformLayout();

            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();

            this.pnlAlertas.ResumeLayout(false);
            this.pnlAlertas.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion
    }
}