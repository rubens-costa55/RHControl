namespace RHControl
{
    partial class FrmFuncionarios
    {
        private System.ComponentModel.IContainer components = null;

        // MENU
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

        // CONTEÚDO
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;

        // RESUMO
        private System.Windows.Forms.Panel pnlResumo;
        private System.Windows.Forms.Panel pnlResumoTotal;
        private System.Windows.Forms.Panel pnlResumoAtivos;
        private System.Windows.Forms.Panel pnlResumoFerias;
        private System.Windows.Forms.Panel pnlResumoAfastados;

        private System.Windows.Forms.Label lblResumoTotal;
        private System.Windows.Forms.Label lblResumoTotalTexto;
        private System.Windows.Forms.Label lblResumoAtivos;
        private System.Windows.Forms.Label lblResumoAtivosTexto;
        private System.Windows.Forms.Label lblResumoFerias;
        private System.Windows.Forms.Label lblResumoFeriasTexto;
        private System.Windows.Forms.Label lblResumoAfastados;
        private System.Windows.Forms.Label lblResumoAfastadosTexto;

        // BUSCA
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnNovoFuncionario;

        // FILTROS
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Button btnAfastados;
        private System.Windows.Forms.Button btnDesligados;

        // LISTA
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvFuncionarios;

        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colJornada;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalhes;
        private System.Windows.Forms.DataGridViewButtonColumn colDesligar;

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

            this.lblVersao = new System.Windows.Forms.Label();

            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();

            this.pnlResumo = new System.Windows.Forms.Panel();

            this.pnlResumoTotal = new System.Windows.Forms.Panel();
            this.pnlResumoAtivos = new System.Windows.Forms.Panel();
            this.pnlResumoFerias = new System.Windows.Forms.Panel();
            this.pnlResumoAfastados = new System.Windows.Forms.Panel();

            this.lblResumoTotal = new System.Windows.Forms.Label();
            this.lblResumoTotalTexto = new System.Windows.Forms.Label();

            this.lblResumoAtivos = new System.Windows.Forms.Label();
            this.lblResumoAtivosTexto = new System.Windows.Forms.Label();

            this.lblResumoFerias = new System.Windows.Forms.Label();
            this.lblResumoFeriasTexto = new System.Windows.Forms.Label();

            this.lblResumoAfastados = new System.Windows.Forms.Label();
            this.lblResumoAfastadosTexto = new System.Windows.Forms.Label();

            this.pnlBusca = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();

            this.pnlFiltros = new System.Windows.Forms.Panel();

            this.btnTodos = new System.Windows.Forms.Button();
            this.btnAtivos = new System.Windows.Forms.Button();
            this.btnFerias = new System.Windows.Forms.Button();
            this.btnAfastados = new System.Windows.Forms.Button();
            this.btnDesligados = new System.Windows.Forms.Button();

            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();

            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();

            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colJornada = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDetalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDesligar = new System.Windows.Forms.DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();

            this.SuspendLayout();

            // =========================================================
            // FORM
            // =========================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(244, 247, 251);

            this.ClientSize =
                new System.Drawing.Size(1280, 800);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = true;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "RH Control — Funcionários";

            // =========================================================
            // MENU LATERAL
            // =========================================================

            this.pnlMenu.BackColor =
                System.Drawing.Color.FromArgb(8, 48, 88);

            this.pnlMenu.Dock =
                System.Windows.Forms.DockStyle.Left;

            this.pnlMenu.Location =
                new System.Drawing.Point(0, 0);

            this.pnlMenu.Name =
                "pnlMenu";

            this.pnlMenu.Size =
                new System.Drawing.Size(235, 800);

            // =========================================================
            // LOGO
            // =========================================================

            this.picLogo.BackColor =
                System.Drawing.Color.Transparent;

            this.picLogo.Image =
                global::RHControl.Properties.Resources.logorh;

            this.picLogo.Location =
                new System.Drawing.Point(38, 30);

            this.picLogo.Name =
                "picLogo";

            this.picLogo.Size =
                new System.Drawing.Size(160, 125);

            this.picLogo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // =========================================================
            // NOME SISTEMA
            // =========================================================

            this.lblNomeSistema.AutoSize = true;

            this.lblNomeSistema.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    17F,
                    System.Drawing.FontStyle.Bold);

            this.lblNomeSistema.ForeColor =
                System.Drawing.Color.White;

            this.lblNomeSistema.Location =
                new System.Drawing.Point(43, 162);

            this.lblNomeSistema.Name =
                "lblNomeSistema";

            this.lblNomeSistema.Text =
                "RH CONTROL";

            // =========================================================
            // SUBTÍTULO MENU
            // =========================================================

            this.lblSubtituloMenu.AutoSize = true;

            this.lblSubtituloMenu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSubtituloMenu.ForeColor =
                System.Drawing.Color.FromArgb(
                    175,
                    202,
                    225);

            this.lblSubtituloMenu.Location =
                new System.Drawing.Point(47, 189);

            this.lblSubtituloMenu.Name =
                "lblSubtituloMenu";

            this.lblSubtituloMenu.Text =
                "GESTÃO DE PESSOAS";

            // =========================================================
            // DASHBOARD
            // =========================================================

            this.btnDashboard.BackColor =
                System.Drawing.Color.FromArgb(8, 48, 88);

            this.btnDashboard.FlatAppearance.BorderSize = 0;

            this.btnDashboard.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(22, 82, 125);

            this.btnDashboard.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDashboard.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnDashboard.ForeColor =
                System.Drawing.Color.White;

            this.btnDashboard.Location =
                new System.Drawing.Point(10, 225);

            this.btnDashboard.Name =
                "btnDashboard";

            this.btnDashboard.Size =
                new System.Drawing.Size(215, 44);

            this.btnDashboard.Text =
                "⌂   Dashboard";

            this.btnDashboard.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnDashboard.Padding =
                new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.btnDashboard.UseVisualStyleBackColor =
                false;

            // =========================================================
            // FUNCIONÁRIOS
            // =========================================================

            this.btnFuncionarios.BackColor =
                System.Drawing.Color.FromArgb(20, 125, 235);

            this.btnFuncionarios.FlatAppearance.BorderSize = 0;

            this.btnFuncionarios.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(35, 145, 250);

            this.btnFuncionarios.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFuncionarios.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnFuncionarios.ForeColor =
                System.Drawing.Color.White;

            this.btnFuncionarios.Location =
                new System.Drawing.Point(10, 277);

            this.btnFuncionarios.Name =
                "btnFuncionarios";

            this.btnFuncionarios.Size =
                new System.Drawing.Size(215, 44);

            this.btnFuncionarios.Text =
                "●   Funcionários";

            this.btnFuncionarios.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnFuncionarios.Padding =
                new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.btnFuncionarios.UseVisualStyleBackColor =
                false;

            // =========================================================
            // JORNADA
            // =========================================================

            this.btnJornada.BackColor =
                System.Drawing.Color.FromArgb(8, 48, 88);

            this.btnJornada.FlatAppearance.BorderSize = 0;

            this.btnJornada.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(22, 82, 125);

            this.btnJornada.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnJornada.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnJornada.ForeColor =
                System.Drawing.Color.White;

            this.btnJornada.Location =
                new System.Drawing.Point(10, 329);

            this.btnJornada.Name =
                "btnJornada";

            this.btnJornada.Size =
                new System.Drawing.Size(215, 44);

            this.btnJornada.Text =
                "▣   Jornada / Calendário";

            this.btnJornada.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnJornada.Padding =
                new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.btnJornada.UseVisualStyleBackColor =
                false;

            // =========================================================
            // FOLHA
            // =========================================================

            this.btnFolha.BackColor =
                System.Drawing.Color.FromArgb(8, 48, 88);

            this.btnFolha.FlatAppearance.BorderSize = 0;

            this.btnFolha.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(22, 82, 125);

            this.btnFolha.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFolha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnFolha.ForeColor =
                System.Drawing.Color.White;

            this.btnFolha.Location =
                new System.Drawing.Point(10, 381);

            this.btnFolha.Name =
                "btnFolha";

            this.btnFolha.Size =
                new System.Drawing.Size(215, 44);

            this.btnFolha.Text =
                "$   Folha / Relatórios";

            this.btnFolha.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnFolha.Padding =
                new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.btnFolha.UseVisualStyleBackColor =
                false;

            // =========================================================
            // CONFIGURAÇÕES
            // =========================================================

            this.btnConfiguracoes.BackColor =
                System.Drawing.Color.FromArgb(8, 48, 88);

            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;

            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(22, 82, 125);

            this.btnConfiguracoes.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnConfiguracoes.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnConfiguracoes.ForeColor =
                System.Drawing.Color.White;

            this.btnConfiguracoes.Location =
                new System.Drawing.Point(10, 433);

            this.btnConfiguracoes.Name =
                "btnConfiguracoes";

            this.btnConfiguracoes.Size =
                new System.Drawing.Size(215, 44);

            this.btnConfiguracoes.Text =
                "⚙   Configurações";

            this.btnConfiguracoes.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnConfiguracoes.Padding =
                new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.btnConfiguracoes.UseVisualStyleBackColor =
                false;

            // =========================================================
            // VERSÃO
            // =========================================================

            this.lblVersao.AutoSize = true;

            this.lblVersao.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblVersao.ForeColor =
                System.Drawing.Color.FromArgb(
                    145,
                    180,
                    210);

            this.lblVersao.Location =
                new System.Drawing.Point(42, 752);

            this.lblVersao.Name =
                "lblVersao";

            this.lblVersao.Text =
                "RH Control • v1.0";

            // =========================================================
            // CONTROLES MENU
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
            // CONTEÚDO
            // =========================================================

            this.pnlConteudo.BackColor =
                System.Drawing.Color.FromArgb(
                    244,
                    247,
                    251);

            this.pnlConteudo.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlConteudo.Location =
                new System.Drawing.Point(235, 0);

            this.pnlConteudo.Name =
                "pnlConteudo";

            this.pnlConteudo.Size =
                new System.Drawing.Size(1045, 800);

            // =========================================================
            // CABEÇALHO
            // =========================================================

            this.pnlCabecalho.BackColor =
                System.Drawing.Color.White;

            this.pnlCabecalho.Location =
                new System.Drawing.Point(0, 0);

            this.pnlCabecalho.Name =
                "pnlCabecalho";

            this.pnlCabecalho.Size =
                new System.Drawing.Size(1045, 112);

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    26F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(
                    14,
                    48,
                    82);

            this.lblTitulo.Location =
                new System.Drawing.Point(34, 25);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Funcionários";

            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(
                    100,
                    125,
                    150);

            this.lblSubtitulo.Location =
                new System.Drawing.Point(38, 73);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Text =
                "Gerencie os colaboradores da empresa";

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblUsuario.ForeColor =
                System.Drawing.Color.FromArgb(
                    21,
                    101,
                    192);

            this.lblUsuario.Location =
                new System.Drawing.Point(875, 40);

            this.lblUsuario.Name =
                "lblUsuario";

            this.lblUsuario.Text =
                "●  Administrador";

            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Controls.Add(this.lblUsuario);

            // =========================================================
            // RESUMO
            // =========================================================

            this.pnlResumo.BackColor =
                System.Drawing.Color.Transparent;

            this.pnlResumo.Location =
                new System.Drawing.Point(25, 130);

            this.pnlResumo.Name =
                "pnlResumo";

            this.pnlResumo.Size =
                new System.Drawing.Size(995, 90);

            // TOTAL
            this.pnlResumoTotal.BackColor =
                System.Drawing.Color.White;

            this.pnlResumoTotal.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlResumoTotal.Location =
                new System.Drawing.Point(0, 0);

            this.pnlResumoTotal.Name =
                "pnlResumoTotal";

            this.pnlResumoTotal.Size =
                new System.Drawing.Size(235, 88);

            this.lblResumoTotal.AutoSize = true;

            this.lblResumoTotal.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblResumoTotal.ForeColor =
                System.Drawing.Color.FromArgb(
                    21,
                    101,
                    192);

            this.lblResumoTotal.Location =
                new System.Drawing.Point(18, 9);

            this.lblResumoTotal.Name =
                "lblResumoTotal";

            this.lblResumoTotal.Text =
                "0";

            this.lblResumoTotalTexto.AutoSize = true;

            this.lblResumoTotalTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblResumoTotalTexto.ForeColor =
                System.Drawing.Color.FromArgb(
                    95,
                    115,
                    135);

            this.lblResumoTotalTexto.Location =
                new System.Drawing.Point(20, 57);

            this.lblResumoTotalTexto.Name =
                "lblResumoTotalTexto";

            this.lblResumoTotalTexto.Text =
                "Funcionários cadastrados";

            this.pnlResumoTotal.Controls.Add(this.lblResumoTotal);
            this.pnlResumoTotal.Controls.Add(this.lblResumoTotalTexto);

            // ATIVOS
            this.pnlResumoAtivos.BackColor =
                System.Drawing.Color.White;

            this.pnlResumoAtivos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlResumoAtivos.Location =
                new System.Drawing.Point(253, 0);

            this.pnlResumoAtivos.Name =
                "pnlResumoAtivos";

            this.pnlResumoAtivos.Size =
                new System.Drawing.Size(235, 88);

            this.lblResumoAtivos.AutoSize = true;

            this.lblResumoAtivos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblResumoAtivos.ForeColor =
                System.Drawing.Color.FromArgb(
                    34,
                    139,
                    82);

            this.lblResumoAtivos.Location =
                new System.Drawing.Point(18, 9);

            this.lblResumoAtivos.Name =
                "lblResumoAtivos";

            this.lblResumoAtivos.Text =
                "0";

            this.lblResumoAtivosTexto.AutoSize = true;

            this.lblResumoAtivosTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblResumoAtivosTexto.ForeColor =
                System.Drawing.Color.FromArgb(
                    95,
                    115,
                    135);

            this.lblResumoAtivosTexto.Location =
                new System.Drawing.Point(20, 57);

            this.lblResumoAtivosTexto.Name =
                "lblResumoAtivosTexto";

            this.lblResumoAtivosTexto.Text =
                "Colaboradores ativos";

            this.pnlResumoAtivos.Controls.Add(this.lblResumoAtivos);
            this.pnlResumoAtivos.Controls.Add(this.lblResumoAtivosTexto);

            // FÉRIAS
            this.pnlResumoFerias.BackColor =
                System.Drawing.Color.White;

            this.pnlResumoFerias.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlResumoFerias.Location =
                new System.Drawing.Point(506, 0);

            this.pnlResumoFerias.Name =
                "pnlResumoFerias";

            this.pnlResumoFerias.Size =
                new System.Drawing.Size(235, 88);

            this.lblResumoFerias.AutoSize = true;

            this.lblResumoFerias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblResumoFerias.ForeColor =
                System.Drawing.Color.FromArgb(
                    230,
                    145,
                    20);

            this.lblResumoFerias.Location =
                new System.Drawing.Point(18, 9);

            this.lblResumoFerias.Name =
                "lblResumoFerias";

            this.lblResumoFerias.Text =
                "0";

            this.lblResumoFeriasTexto.AutoSize = true;

            this.lblResumoFeriasTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblResumoFeriasTexto.ForeColor =
                System.Drawing.Color.FromArgb(
                    95,
                    115,
                    135);

            this.lblResumoFeriasTexto.Location =
                new System.Drawing.Point(20, 57);

            this.lblResumoFeriasTexto.Name =
                "lblResumoFeriasTexto";

            this.lblResumoFeriasTexto.Text =
                "Em período de férias";

            this.pnlResumoFerias.Controls.Add(this.lblResumoFerias);
            this.pnlResumoFerias.Controls.Add(this.lblResumoFeriasTexto);

            // AFASTADOS
            this.pnlResumoAfastados.BackColor =
                System.Drawing.Color.White;

            this.pnlResumoAfastados.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlResumoAfastados.Location =
                new System.Drawing.Point(759, 0);

            this.pnlResumoAfastados.Name =
                "pnlResumoAfastados";

            this.pnlResumoAfastados.Size =
                new System.Drawing.Size(235, 88);

            this.lblResumoAfastados.AutoSize = true;

            this.lblResumoAfastados.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblResumoAfastados.ForeColor =
                System.Drawing.Color.FromArgb(
                    190,
                    75,
                    75);

            this.lblResumoAfastados.Location =
                new System.Drawing.Point(18, 9);

            this.lblResumoAfastados.Name =
                "lblResumoAfastados";

            this.lblResumoAfastados.Text =
                "0";

            this.lblResumoAfastadosTexto.AutoSize = true;

            this.lblResumoAfastadosTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblResumoAfastadosTexto.ForeColor =
                System.Drawing.Color.FromArgb(
                    95,
                    115,
                    135);

            this.lblResumoAfastadosTexto.Location =
                new System.Drawing.Point(20, 57);

            this.lblResumoAfastadosTexto.Name =
                "lblResumoAfastadosTexto";

            this.lblResumoAfastadosTexto.Text =
                "Afastamentos registrados";

            this.pnlResumoAfastados.Controls.Add(this.lblResumoAfastados);
            this.pnlResumoAfastados.Controls.Add(this.lblResumoAfastadosTexto);

            this.pnlResumo.Controls.Add(this.pnlResumoTotal);
            this.pnlResumo.Controls.Add(this.pnlResumoAtivos);
            this.pnlResumo.Controls.Add(this.pnlResumoFerias);
            this.pnlResumo.Controls.Add(this.pnlResumoAfastados);

            // =========================================================
            // BUSCA
            // =========================================================

            this.pnlBusca.BackColor =
                System.Drawing.Color.FromArgb(
                    14,
                    52,
                    86);

            this.pnlBusca.Location =
                new System.Drawing.Point(25, 235);

            this.pnlBusca.Name =
                "pnlBusca";

            this.pnlBusca.Size =
                new System.Drawing.Size(995, 82);

            this.lblBuscar.AutoSize = true;

            this.lblBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblBuscar.ForeColor =
                System.Drawing.Color.White;

            this.lblBuscar.Location =
                new System.Drawing.Point(20, 10);

            this.lblBuscar.Name =
                "lblBuscar";

            this.lblBuscar.Text =
                "Buscar funcionário";

            this.txtBusca.BackColor =
                System.Drawing.Color.FromArgb(
                    35,
                    72,
                    106);

            this.txtBusca.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtBusca.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtBusca.ForeColor =
                System.Drawing.Color.White;

            this.txtBusca.Location =
                new System.Drawing.Point(20, 36);

            this.txtBusca.Name =
                "txtBusca";

            this.txtBusca.Size =
                new System.Drawing.Size(700, 27);

            this.btnNovoFuncionario.BackColor =
                System.Drawing.Color.FromArgb(
                    20,
                    125,
                    235);

            this.btnNovoFuncionario.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnNovoFuncionario.FlatAppearance.BorderSize = 0;

            this.btnNovoFuncionario.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(
                    35,
                    145,
                    250);

            this.btnNovoFuncionario.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNovoFuncionario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btnNovoFuncionario.ForeColor =
                System.Drawing.Color.White;

            this.btnNovoFuncionario.Location =
                new System.Drawing.Point(740, 25);

            this.btnNovoFuncionario.Name =
                "btnNovoFuncionario";

            this.btnNovoFuncionario.Size =
                new System.Drawing.Size(235, 40);

            this.btnNovoFuncionario.Text =
                "+   Novo Funcionário";

            this.btnNovoFuncionario.UseVisualStyleBackColor =
                false;

            this.pnlBusca.Controls.Add(this.lblBuscar);
            this.pnlBusca.Controls.Add(this.txtBusca);
            this.pnlBusca.Controls.Add(this.btnNovoFuncionario);

            // =========================================================
            // FILTROS
            // =========================================================

            this.pnlFiltros.BackColor =
                System.Drawing.Color.Transparent;

            this.pnlFiltros.Location =
                new System.Drawing.Point(25, 330);

            this.pnlFiltros.Name =
                "pnlFiltros";

            this.pnlFiltros.Size =
                new System.Drawing.Size(995, 48);

            ConfigurarFiltro(
                this.btnTodos,
                "Todos",
                0,
                true);

            ConfigurarFiltro(
                this.btnAtivos,
                "Ativos",
                110,
                false);

            ConfigurarFiltro(
                this.btnFerias,
                "Férias",
                220,
                false);

            ConfigurarFiltro(
                this.btnAfastados,
                "Afastados",
                330,
                false);

            ConfigurarFiltro(
                this.btnDesligados,
                "Desligados",
                450,
                false);

            this.pnlFiltros.Controls.Add(this.btnTodos);
            this.pnlFiltros.Controls.Add(this.btnAtivos);
            this.pnlFiltros.Controls.Add(this.btnFerias);
            this.pnlFiltros.Controls.Add(this.btnAfastados);
            this.pnlFiltros.Controls.Add(this.btnDesligados);

            // =========================================================
            // LISTA
            // =========================================================

            this.pnlLista.BackColor =
                System.Drawing.Color.White;

            this.pnlLista.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlLista.Location =
                new System.Drawing.Point(25, 395);

            this.pnlLista.Name =
                "pnlLista";

            this.pnlLista.Size =
                new System.Drawing.Size(995, 380);

            this.lblLista.AutoSize = true;

            this.lblLista.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblLista.ForeColor =
                System.Drawing.Color.FromArgb(
                    14,
                    48,
                    82);

            this.lblLista.Location =
                new System.Drawing.Point(20, 15);

            this.lblLista.Name =
                "lblLista";

            this.lblLista.Text =
                "Lista de funcionários";

            // =========================================================
            // DATAGRIDVIEW
            // =========================================================

            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;

            this.dgvFuncionarios.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

            this.dgvFuncionarios.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvFuncionarios.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvFuncionarios.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvFuncionarios.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvFuncionarios.ColumnHeadersHeight =
                42;

            this.dgvFuncionarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvFuncionarios.EnableHeadersVisualStyles =
                false;

            this.dgvFuncionarios.GridColor =
                System.Drawing.Color.FromArgb(
                    228,
                    235,
                    242);

            this.dgvFuncionarios.Location =
                new System.Drawing.Point(18, 52);

            this.dgvFuncionarios.MultiSelect =
                false;

            this.dgvFuncionarios.Name =
                "dgvFuncionarios";

            this.dgvFuncionarios.ReadOnly =
                true;

            this.dgvFuncionarios.RowHeadersVisible =
                false;

            this.dgvFuncionarios.RowTemplate.Height =
                43;

            this.dgvFuncionarios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvFuncionarios.Size =
                new System.Drawing.Size(955, 310);

            // =========================================================
            // CABEÇALHO GRID
            // =========================================================

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            237,
                            243,
                            249),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F,
                            System.Drawing.FontStyle.Bold),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            25,
                            55,
                            85),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            237,
                            243,
                            249),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            25,
                            55,
                            85),

                    WrapMode =
                        System.Windows.Forms.DataGridViewTriState.False
                };

            // =========================================================
            // CÉLULAS
            // =========================================================

            this.dgvFuncionarios.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,

                    BackColor =
                        System.Drawing.Color.White,

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            35,
                            55,
                            75),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            225,
                            239,
                            255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            20,
                            55,
                            90),

                    WrapMode =
                        System.Windows.Forms.DataGridViewTriState.False
                };

            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    BackColor =
                        System.Drawing.Color.FromArgb(
                            249,
                            251,
                            253),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            225,
                            239,
                            255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            20,
                            55,
                            90)
                };

            // =========================================================
            // COLUNAS
            // =========================================================

            this.colNome.HeaderText =
                "Nome";

            this.colNome.Name =
                "colNome";

            this.colNome.ReadOnly = true;

            this.colNome.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colNome.Width =
                175;

            this.colCargo.HeaderText =
                "Cargo";

            this.colCargo.Name =
                "colCargo";

            this.colCargo.ReadOnly = true;

            this.colCargo.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colCargo.Width =
                155;

            this.colSetor.HeaderText =
                "Setor";

            this.colSetor.Name =
                "colSetor";

            this.colSetor.ReadOnly = true;

            this.colSetor.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colSetor.Width =
                115;

            this.colAdmissao.HeaderText =
                "Admissão";

            this.colAdmissao.Name =
                "colAdmissao";

            this.colAdmissao.ReadOnly = true;

            this.colAdmissao.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colAdmissao.Width =
                100;

            this.colStatus.HeaderText =
                "Status";

            this.colStatus.Name =
                "colStatus";

            this.colStatus.ReadOnly = true;

            this.colStatus.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colStatus.Width =
                85;

            // =========================================================
            // EDITAR
            // =========================================================

            this.colEditar.HeaderText =
                "Ações";

            this.colEditar.Name =
                "colEditar";

            this.colEditar.ReadOnly =
                true;

            this.colEditar.Text =
                "Editar";

            this.colEditar.UseColumnTextForButtonValue =
                true;

            this.colEditar.Width =
                70;

            this.colEditar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.colEditar.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            232,
                            242,
                            253),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            21,
                            101,
                            192),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            210,
                            230,
                            250),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            21,
                            101,
                            192),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F,
                            System.Drawing.FontStyle.Bold)
                };

            // =========================================================
            // JORNADA
            // =========================================================

            this.colJornada.HeaderText =
                "";

            this.colJornada.Name =
                "colJornada";

            this.colJornada.ReadOnly =
                true;

            this.colJornada.Text =
                "Jornada";

            this.colJornada.UseColumnTextForButtonValue =
                true;

            this.colJornada.Width =
                80;

            this.colJornada.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.colJornada.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            245,
                            248,
                            251),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            45,
                            65,
                            85),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            225,
                            239,
                            255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            30,
                            65,
                            100),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F,
                            System.Drawing.FontStyle.Bold)
                };

            // =========================================================
            // DETALHES
            // =========================================================

            this.colDetalhes.HeaderText =
                "";

            this.colDetalhes.Name =
                "colDetalhes";

            this.colDetalhes.ReadOnly =
                true;

            this.colDetalhes.Text =
                "Detalhes";

            this.colDetalhes.UseColumnTextForButtonValue =
                true;

            this.colDetalhes.Width =
                80;

            this.colDetalhes.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.colDetalhes.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            245,
                            248,
                            251),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            21,
                            101,
                            192),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            225,
                            239,
                            255),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            21,
                            101,
                            192),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F,
                            System.Drawing.FontStyle.Bold)
                };

            // =========================================================
            // DESLIGAR
            // =========================================================

            this.colDesligar.HeaderText =
                "";

            this.colDesligar.Name =
                "colDesligar";

            this.colDesligar.ReadOnly =
                true;

            this.colDesligar.Text =
                "Desligar";

            this.colDesligar.UseColumnTextForButtonValue =
                true;

            this.colDesligar.Width =
                80;

            this.colDesligar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.colDesligar.DefaultCellStyle =
                new System.Windows.Forms.DataGridViewCellStyle
                {
                    Alignment =
                        System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,

                    BackColor =
                        System.Drawing.Color.FromArgb(
                            253,
                            241,
                            241),

                    ForeColor =
                        System.Drawing.Color.FromArgb(
                            198,
                            40,
                            40),

                    SelectionBackColor =
                        System.Drawing.Color.FromArgb(
                            250,
                            225,
                            225),

                    SelectionForeColor =
                        System.Drawing.Color.FromArgb(
                            198,
                            40,
                            40),

                    Font =
                        new System.Drawing.Font(
                            "Segoe UI",
                            8.5F,
                            System.Drawing.FontStyle.Bold)
                };

            // =========================================================
            // ADICIONAR COLUNAS
            // =========================================================

            this.dgvFuncionarios.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colNome,
                    this.colCargo,
                    this.colSetor,
                    this.colAdmissao,
                    this.colStatus,
                    this.colEditar,
                    this.colJornada,
                    this.colDetalhes,
                    this.colDesligar
                });

            // =========================================================
            // LISTA
            // =========================================================

            this.pnlLista.Controls.Add(
                this.lblLista);

            this.pnlLista.Controls.Add(
                this.dgvFuncionarios);

            // =========================================================
            // CONTEÚDO
            // =========================================================

            this.pnlConteudo.Controls.Add(
                this.pnlLista);

            this.pnlConteudo.Controls.Add(
                this.pnlFiltros);

            this.pnlConteudo.Controls.Add(
                this.pnlBusca);

            this.pnlConteudo.Controls.Add(
                this.pnlResumo);

            this.pnlConteudo.Controls.Add(
                this.pnlCabecalho);

            // =========================================================
            // FORM
            // =========================================================

            this.Controls.Add(
                this.pnlConteudo);

            this.Controls.Add(
                this.pnlMenu);

            ((System.ComponentModel.ISupportInitialize)
                (this.picLogo)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvFuncionarios)).EndInit();

            this.ResumeLayout(false);
        }

        // =============================================================
        // FILTROS
        // =============================================================

        private void ConfigurarFiltro(
            System.Windows.Forms.Button botao,
            string texto,
            int esquerda,
            bool ativo)
        {
            botao.BackColor =
                ativo
                    ? System.Drawing.Color.FromArgb(
                        21,
                        101,
                        192)
                    : System.Drawing.Color.White;

            botao.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(
                    215,
                    225,
                    235);

            botao.FlatAppearance.BorderSize =
                ativo ? 0 : 1;

            botao.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(
                    232,
                    242,
                    253);

            botao.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            botao.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    ativo
                        ? System.Drawing.FontStyle.Bold
                        : System.Drawing.FontStyle.Regular);

            botao.ForeColor =
                ativo
                    ? System.Drawing.Color.White
                    : System.Drawing.Color.FromArgb(
                        45,
                        65,
                        85);

            botao.Location =
                new System.Drawing.Point(
                    esquerda,
                    4);

            botao.Size =
                new System.Drawing.Size(
                    texto == "Desligados"
                        ? 115
                        : 100,
                    38);

            botao.Text =
                texto;

            botao.UseVisualStyleBackColor =
                false;
        }
    }
}