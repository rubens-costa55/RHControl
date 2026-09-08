namespace RHControl
{
    partial class FrmFuncionarios
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

        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;

        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnNovoFuncionario;

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Button btnAfastados;
        private System.Windows.Forms.Button btnDesligados;

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
            {
                components.Dispose();
            }

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

            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlBusca.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlLista.SuspendLayout();
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
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1150, 760);

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
                System.Drawing.Color.FromArgb(248, 250, 252);

            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblNomeSistema);
            this.pnlMenu.Controls.Add(this.lblSubtituloMenu);

            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnFuncionarios);
            this.pnlMenu.Controls.Add(this.btnJornada);
            this.pnlMenu.Controls.Add(this.btnFolha);
            this.pnlMenu.Controls.Add(this.btnConfiguracoes);

            this.pnlMenu.Controls.Add(this.lblVersao);

            this.pnlMenu.Dock =
                System.Windows.Forms.DockStyle.Left;

            this.pnlMenu.Location =
                new System.Drawing.Point(0, 0);

            this.pnlMenu.Name =
                "pnlMenu";

            this.pnlMenu.Size =
                new System.Drawing.Size(220, 760);

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

            this.lblNomeSistema.Text =
                "RH Control";

            // =========================================================
            // SUBTÍTULO
            // =========================================================

            this.lblSubtituloMenu.AutoSize = true;

            this.lblSubtituloMenu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblSubtituloMenu.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblSubtituloMenu.Location =
                new System.Drawing.Point(61, 145);

            this.lblSubtituloMenu.Text =
                "Gestão de Pessoas";

            // =========================================================
            // BOTÕES DO MENU
            // =========================================================

            this.btnDashboard.BackColor =
                System.Drawing.Color.White;

            this.btnDashboard.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnDashboard.FlatAppearance.BorderSize = 1;

            this.btnDashboard.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnDashboard.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDashboard.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnDashboard.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.btnDashboard.Location =
                new System.Drawing.Point(15, 190);

            this.btnDashboard.Size =
                new System.Drawing.Size(190, 44);

            this.btnDashboard.Text =
                "Dashboard";

            this.btnDashboard.UseVisualStyleBackColor =
                false;

            // Funcionários ativo

            this.btnFuncionarios.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.btnFuncionarios.FlatAppearance.BorderSize = 0;

            this.btnFuncionarios.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(25, 118, 210);

            this.btnFuncionarios.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(13, 71, 161);

            this.btnFuncionarios.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFuncionarios.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnFuncionarios.ForeColor =
                System.Drawing.Color.White;

            this.btnFuncionarios.Location =
                new System.Drawing.Point(15, 242);

            this.btnFuncionarios.Size =
                new System.Drawing.Size(190, 44);

            this.btnFuncionarios.Text =
                "Funcionários";

            this.btnFuncionarios.UseVisualStyleBackColor =
                false;

            // Jornada

            this.btnJornada.BackColor =
                System.Drawing.Color.White;

            this.btnJornada.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnJornada.FlatAppearance.BorderSize = 1;

            this.btnJornada.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnJornada.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnJornada.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnJornada.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.btnJornada.Location =
                new System.Drawing.Point(15, 294);

            this.btnJornada.Size =
                new System.Drawing.Size(190, 44);

            this.btnJornada.Text =
                "Jornada / Calendário";

            this.btnJornada.UseVisualStyleBackColor =
                false;

            // Folha

            this.btnFolha.BackColor =
                System.Drawing.Color.White;

            this.btnFolha.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnFolha.FlatAppearance.BorderSize = 1;

            this.btnFolha.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnFolha.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFolha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnFolha.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.btnFolha.Location =
                new System.Drawing.Point(15, 346);

            this.btnFolha.Size =
                new System.Drawing.Size(190, 44);

            this.btnFolha.Text =
                "Folha / Relatórios";

            this.btnFolha.UseVisualStyleBackColor =
                false;

            // Configurações

            this.btnConfiguracoes.BackColor =
                System.Drawing.Color.White;

            this.btnConfiguracoes.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(225, 230, 236);

            this.btnConfiguracoes.FlatAppearance.BorderSize = 1;

            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.btnConfiguracoes.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnConfiguracoes.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnConfiguracoes.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.btnConfiguracoes.Location =
                new System.Drawing.Point(15, 398);

            this.btnConfiguracoes.Size =
                new System.Drawing.Size(190, 44);

            this.btnConfiguracoes.Text =
                "Configurações";

            this.btnConfiguracoes.UseVisualStyleBackColor =
                false;

            // =========================================================
            // VERSÃO
            // =========================================================

            this.lblVersao.AutoSize = true;

            this.lblVersao.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F);

            this.lblVersao.ForeColor =
                System.Drawing.Color.FromArgb(110, 120, 130);

            this.lblVersao.Location =
                new System.Drawing.Point(65, 715);

            this.lblVersao.Text =
                "RH Control • v1.0";

            // =========================================================
            // CONTEÚDO
            // =========================================================

            this.pnlConteudo.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.pnlConteudo.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlConteudo.Location =
                new System.Drawing.Point(220, 0);

            this.pnlConteudo.Name =
                "pnlConteudo";

            this.pnlConteudo.Size =
                new System.Drawing.Size(930, 760);

            this.pnlConteudo.Controls.Add(this.pnlCabecalho);
            this.pnlConteudo.Controls.Add(this.pnlBusca);
            this.pnlConteudo.Controls.Add(this.pnlFiltros);
            this.pnlConteudo.Controls.Add(this.pnlLista);

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
                new System.Drawing.Size(930, 95);

            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Controls.Add(this.lblUsuario);

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.lblTitulo.Location =
                new System.Drawing.Point(35, 25);

            this.lblTitulo.Text =
                "Funcionários";

            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblSubtitulo.Location =
                new System.Drawing.Point(37, 61);

            this.lblSubtitulo.Text =
                "Gerencie os colaboradores cadastrados";

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblUsuario.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblUsuario.Location =
                new System.Drawing.Point(760, 38);

            this.lblUsuario.Text =
                "Administrador";

            // =========================================================
            // BUSCA
            // =========================================================

            this.pnlBusca.BackColor =
                System.Drawing.Color.White;

            this.pnlBusca.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlBusca.Location =
                new System.Drawing.Point(25, 115);

            this.pnlBusca.Name =
                "pnlBusca";

            this.pnlBusca.Size =
                new System.Drawing.Size(880, 80);

            this.pnlBusca.Controls.Add(this.lblBuscar);
            this.pnlBusca.Controls.Add(this.txtBusca);
            this.pnlBusca.Controls.Add(this.btnNovoFuncionario);

            this.lblBuscar.AutoSize = true;

            this.lblBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold);

            this.lblBuscar.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 65);

            this.lblBuscar.Location =
                new System.Drawing.Point(20, 12);

            this.lblBuscar.Text =
                "Buscar funcionário";

            this.txtBusca.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtBusca.Location =
                new System.Drawing.Point(20, 38);

            this.txtBusca.Name =
                "txtBusca";

            this.txtBusca.Size =
                new System.Drawing.Size(500, 23);

            this.btnNovoFuncionario.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.btnNovoFuncionario.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnNovoFuncionario.FlatAppearance.BorderSize = 0;

            this.btnNovoFuncionario.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(25, 118, 210);

            this.btnNovoFuncionario.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(13, 71, 161);

            this.btnNovoFuncionario.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNovoFuncionario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnNovoFuncionario.ForeColor =
                System.Drawing.Color.White;

            this.btnNovoFuncionario.Location =
                new System.Drawing.Point(605, 27);

            this.btnNovoFuncionario.Size =
                new System.Drawing.Size(180, 40);

            this.btnNovoFuncionario.Name =
                "btnNovoFuncionario";

            this.btnNovoFuncionario.Text =
                "+  Novo Funcionário";

            this.btnNovoFuncionario.UseVisualStyleBackColor =
                false;

            // =========================================================
            // FILTROS
            // =========================================================

            this.pnlFiltros.BackColor =
                System.Drawing.Color.White;

            this.pnlFiltros.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFiltros.Location =
                new System.Drawing.Point(25, 205);

            this.pnlFiltros.Size =
                new System.Drawing.Size(880, 50);

            this.pnlFiltros.Controls.Add(this.btnTodos);
            this.pnlFiltros.Controls.Add(this.btnAtivos);
            this.pnlFiltros.Controls.Add(this.btnFerias);
            this.pnlFiltros.Controls.Add(this.btnAfastados);
            this.pnlFiltros.Controls.Add(this.btnDesligados);

            // Todos
            this.btnTodos.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);

            this.btnTodos.FlatAppearance.BorderSize = 0;

            this.btnTodos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnTodos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnTodos.ForeColor =
                System.Drawing.Color.White;

            this.btnTodos.Location =
                new System.Drawing.Point(5, 5);

            this.btnTodos.Size =
                new System.Drawing.Size(100, 36);

            this.btnTodos.Text =
                "Todos";

            this.btnTodos.UseVisualStyleBackColor =
                false;

            // Ativos
            this.btnAtivos.BackColor =
                System.Drawing.Color.White;

            this.btnAtivos.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 225, 230);

            this.btnAtivos.FlatAppearance.BorderSize = 1;

            this.btnAtivos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAtivos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnAtivos.ForeColor =
                System.Drawing.Color.FromArgb(50, 60, 70);

            this.btnAtivos.Location =
                new System.Drawing.Point(115, 5);

            this.btnAtivos.Size =
                new System.Drawing.Size(100, 36);

            this.btnAtivos.Text =
                "Ativos";

            // Férias
            this.btnFerias.BackColor =
                System.Drawing.Color.White;

            this.btnFerias.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 225, 230);

            this.btnFerias.FlatAppearance.BorderSize = 1;

            this.btnFerias.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnFerias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnFerias.ForeColor =
                System.Drawing.Color.FromArgb(50, 60, 70);

            this.btnFerias.Location =
                new System.Drawing.Point(225, 5);

            this.btnFerias.Size =
                new System.Drawing.Size(100, 36);

            this.btnFerias.Text =
                "Férias";

            // Afastados
            this.btnAfastados.BackColor =
                System.Drawing.Color.White;

            this.btnAfastados.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 225, 230);

            this.btnAfastados.FlatAppearance.BorderSize = 1;

            this.btnAfastados.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAfastados.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnAfastados.ForeColor =
                System.Drawing.Color.FromArgb(50, 60, 70);

            this.btnAfastados.Location =
                new System.Drawing.Point(335, 5);

            this.btnAfastados.Size =
                new System.Drawing.Size(100, 36);

            this.btnAfastados.Text =
                "Afastados";

            // Desligados
            this.btnDesligados.BackColor =
                System.Drawing.Color.White;

            this.btnDesligados.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 225, 230);

            this.btnDesligados.FlatAppearance.BorderSize = 1;

            this.btnDesligados.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDesligados.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnDesligados.ForeColor =
                System.Drawing.Color.FromArgb(50, 60, 70);

            this.btnDesligados.Location =
                new System.Drawing.Point(445, 5);

            this.btnDesligados.Size =
                new System.Drawing.Size(110, 36);

            this.btnDesligados.Text =
                "Desligados";

            // =========================================================
            // LISTA
            // =========================================================

            this.pnlLista.BackColor =
                System.Drawing.Color.White;

            this.pnlLista.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlLista.Location =
                new System.Drawing.Point(25, 265);

            this.pnlLista.Name =
                "pnlLista";

            this.pnlLista.Size =
                new System.Drawing.Size(880, 460);

            this.pnlLista.Controls.Add(this.lblLista);
            this.pnlLista.Controls.Add(this.dgvFuncionarios);

            this.lblLista.AutoSize = true;

            this.lblLista.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblLista.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.lblLista.Location =
                new System.Drawing.Point(20, 17);

            this.lblLista.Text =
                "Lista de funcionários";

            // =========================================================
            // DATAGRIDVIEW
            // =========================================================

            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeColumns = true;
            this.dgvFuncionarios.AllowUserToResizeRows = true;

            this.dgvFuncionarios.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

            this.dgvFuncionarios.AutoSizeRowsMode =
                System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;

            this.dgvFuncionarios.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvFuncionarios.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvFuncionarios.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvFuncionarios.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            this.dgvFuncionarios.ColumnHeadersHeight =
                38;

            this.dgvFuncionarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dgvFuncionarios.EnableHeadersVisualStyles =
                false;

            this.dgvFuncionarios.GridColor =
                System.Drawing.Color.FromArgb(230, 234, 238);

            this.dgvFuncionarios.Location =
                new System.Drawing.Point(20, 50);

            this.dgvFuncionarios.MultiSelect =
                false;

            this.dgvFuncionarios.Name =
                "dgvFuncionarios";

            this.dgvFuncionarios.ReadOnly =
                true;

            this.dgvFuncionarios.RowHeadersVisible =
                false;

            this.dgvFuncionarios.RowTemplate.Height =
                42;

            this.dgvFuncionarios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvFuncionarios.Size =
                new System.Drawing.Size(840, 395);

            // =========================================================
            // CORES DA TABELA
            // =========================================================

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 65);

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold);

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(45, 55, 65);

            this.dgvFuncionarios.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.dgvFuncionarios.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.dgvFuncionarios.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            this.dgvFuncionarios.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.dgvFuncionarios.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(250, 251, 253);

            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(235, 243, 255);

            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(35, 45, 55);

            // =========================================================
            // COLUNAS
            // =========================================================

            this.colNome.HeaderText =
                "Nome";

            this.colNome.Name =
                "colNome";

            this.colNome.ReadOnly = true;

            this.colNome.Width =
                180;

            this.colCargo.HeaderText =
                "Cargo";

            this.colCargo.Name =
                "colCargo";

            this.colCargo.ReadOnly = true;

            this.colCargo.Width =
                165;

            this.colSetor.HeaderText =
                "Setor";

            this.colSetor.Name =
                "colSetor";

            this.colSetor.ReadOnly = true;

            this.colSetor.Width =
                130;

            this.colAdmissao.HeaderText =
                "Admissão";

            this.colAdmissao.Name =
                "colAdmissao";

            this.colAdmissao.ReadOnly = true;

            this.colAdmissao.Width =
                105;

            this.colStatus.HeaderText =
                "Status";

            this.colStatus.Name =
                "colStatus";

            this.colStatus.ReadOnly = true;

            this.colStatus.Width =
                90;

            this.colEditar.HeaderText =
                "Editar";

            this.colEditar.Name =
                "colEditar";

            this.colEditar.ReadOnly = true;

            this.colEditar.Text =
                "Editar";

            this.colEditar.UseColumnTextForButtonValue =
                true;

            this.colEditar.Width =
                70;

            this.colJornada.HeaderText =
                "Jornada";

            this.colJornada.Name =
                "colJornada";

            this.colJornada.ReadOnly = true;

            this.colJornada.Text =
                "Jornada";

            this.colJornada.UseColumnTextForButtonValue =
                true;

            this.colJornada.Width =
                80;

            this.colDetalhes.HeaderText =
                "Detalhes";

            this.colDetalhes.Name =
                "colDetalhes";

            this.colDetalhes.ReadOnly = true;

            this.colDetalhes.Text =
                "Detalhes";

            this.colDetalhes.UseColumnTextForButtonValue =
                true;

            this.colDetalhes.Width =
                80;

            this.colDesligar.HeaderText =
                "Desligar";

            this.colDesligar.Name =
                "colDesligar";

            this.colDesligar.ReadOnly = true;

            this.colDesligar.Text =
                "Desligar";

            this.colDesligar.UseColumnTextForButtonValue =
                true;

            this.colDesligar.Width =
                80;

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
            // ADICIONAR FORM
            // =========================================================

            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);

            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.picLogo)).EndInit();

            this.pnlConteudo.ResumeLayout(false);

            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();

            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();

            this.pnlFiltros.ResumeLayout(false);

            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvFuncionarios)).EndInit();

            this.ResumeLayout(false);
        }
    }
}