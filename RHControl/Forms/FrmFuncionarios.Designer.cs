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
        private System.Windows.Forms.Button btnSair;

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
        private System.Windows.Forms.Panel pnlResumoDesligados;

        private System.Windows.Forms.Label lblResumoTotal;
        private System.Windows.Forms.Label lblResumoTotalTexto;
        private System.Windows.Forms.Label lblResumoAtivos;
        private System.Windows.Forms.Label lblResumoAtivosTexto;
        private System.Windows.Forms.Label lblResumoFerias;
        private System.Windows.Forms.Label lblResumoFeriasTexto;
        private System.Windows.Forms.Label lblResumoAfastados;
        private System.Windows.Forms.Label lblResumoAfastadosTexto;
        private System.Windows.Forms.Label lblResumoDesligados;
        private System.Windows.Forms.Label lblResumoDesligadosTexto;

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
        private System.Windows.Forms.DataGridViewButtonColumn colFerias;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblNomeSistema = new Label();
            lblSubtituloMenu = new Label();
            btnDashboard = new Button();
            btnFuncionarios = new Button();
            btnJornada = new Button();
            btnFolha = new Button();
            btnConfiguracoes = new Button();
            lblVersao = new Label();
            btnSair = new Button();
            pnlConteudo = new Panel();
            pnlLista = new Panel();
            lblLista = new Label();
            dgvFuncionarios = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colCargo = new DataGridViewTextBoxColumn();
            colSetor = new DataGridViewTextBoxColumn();
            colAdmissao = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colJornada = new DataGridViewButtonColumn();
            colFerias = new DataGridViewButtonColumn();
            colDetalhes = new DataGridViewButtonColumn();
            colDesligar = new DataGridViewButtonColumn();
            pnlFiltros = new Panel();
            btnTodos = new Button();
            btnAtivos = new Button();
            btnFerias = new Button();
            btnAfastados = new Button();
            btnDesligados = new Button();
            pnlBusca = new Panel();
            lblBuscar = new Label();
            txtBusca = new TextBox();
            btnNovoFuncionario = new Button();
            pnlResumo = new Panel();
            pnlResumoTotal = new Panel();
            lblResumoTotal = new Label();
            lblResumoTotalTexto = new Label();
            pnlResumoAtivos = new Panel();
            lblResumoAtivos = new Label();
            lblResumoAtivosTexto = new Label();
            pnlResumoFerias = new Panel();
            lblResumoFerias = new Label();
            lblResumoFeriasTexto = new Label();
            pnlResumoAfastados = new Panel();
            lblResumoAfastados = new Label();
            lblResumoAfastadosTexto = new Label();
            pnlResumoDesligados = new Panel();
            lblResumoDesligados = new Label();
            lblResumoDesligadosTexto = new Label();
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlConteudo.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            pnlFiltros.SuspendLayout();
            pnlBusca.SuspendLayout();
            pnlResumo.SuspendLayout();
            pnlResumoTotal.SuspendLayout();
            pnlResumoAtivos.SuspendLayout();
            pnlResumoFerias.SuspendLayout();
            pnlResumoAfastados.SuspendLayout();
            pnlResumoDesligados.SuspendLayout();
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
            pnlMenu.Controls.Add(lblVersao);
            pnlMenu.Controls.Add(btnSair);
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
            picLogo.Location = new Point(68, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(110, 92);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.AutoSize = false;
            lblNomeSistema.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblNomeSistema.ForeColor = Color.White;
            lblNomeSistema.Location = new Point(20, 140);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(205, 30);
            lblNomeSistema.TabIndex = 1;
            lblNomeSistema.Text = "RH Control";
            lblNomeSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloMenu
            // 
            lblSubtituloMenu.AutoSize = false;
            lblSubtituloMenu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblSubtituloMenu.ForeColor = Color.FromArgb(153, 178, 202);
            lblSubtituloMenu.Location = new Point(20, 169);
            lblSubtituloMenu.Name = "lblSubtituloMenu";
            lblSubtituloMenu.Size = new Size(205, 20);
            lblSubtituloMenu.TabIndex = 2;
            lblSubtituloMenu.Text = "GESTÃO DE PESSOAS";
            lblSubtituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            btnDashboard.BackColor = Color.FromArgb(10, 30, 50);
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
            btnFuncionarios.BackColor = Color.FromArgb(18, 126, 255);
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
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
            btnJornada.BackColor = Color.FromArgb(10, 30, 50);
            btnJornada.FlatAppearance.BorderSize = 0;
            btnJornada.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 62, 93);
            btnJornada.FlatStyle = FlatStyle.Flat;
            btnJornada.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            btnFolha.BackColor = Color.FromArgb(10, 30, 50);
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
            btnConfiguracoes.BackColor = Color.FromArgb(10, 30, 50);
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
            btnSair.TabIndex = 5;
            btnSair.Text = "↪   Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(244, 247, 251);
            pnlConteudo.Controls.Add(pnlLista);
            pnlConteudo.Controls.Add(pnlFiltros);
            pnlConteudo.Controls.Add(pnlBusca);
            pnlConteudo.Controls.Add(pnlResumo);
            pnlConteudo.Controls.Add(pnlCabecalho);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(245, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(955, 760);
            pnlConteudo.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.BorderStyle = BorderStyle.FixedSingle;
            pnlLista.Controls.Add(lblLista);
            pnlLista.Controls.Add(dgvFuncionarios);
            pnlLista.Location = new Point(20, 390);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(915, 330);
            pnlLista.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(14, 48, 82);
            lblLista.Location = new Point(20, 15);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(188, 25);
            lblLista.TabIndex = 0;
            lblLista.Text = "Lista de funcionários";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.AllowUserToResizeRows = false;
            dgvFuncionarios.BackgroundColor = Color.White;
            dgvFuncionarios.BorderStyle = BorderStyle.None;
            dgvFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFuncionarios.ColumnHeadersHeight = 42;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colNome, colCargo, colSetor, colAdmissao, colStatus, colEditar, colJornada, colFerias, colDetalhes, colDesligar });
            dgvFuncionarios.EnableHeadersVisualStyles = false;
            dgvFuncionarios.GridColor = Color.FromArgb(228, 235, 242);
            dgvFuncionarios.Location = new Point(18, 52);
            dgvFuncionarios.MultiSelect = false;
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.RowHeadersVisible = false;
            dgvFuncionarios.RowTemplate.Height = 43;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvFuncionarios.Size = new Size(875, 260);
            dgvFuncionarios.TabIndex = 1;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNome.Width = 145;
            // 
            // colCargo
            // 
            colCargo.HeaderText = "Cargo";
            colCargo.Name = "colCargo";
            colCargo.ReadOnly = true;
            colCargo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCargo.Width = 125;
            // 
            // colSetor
            // 
            colSetor.HeaderText = "Setor";
            colSetor.Name = "colSetor";
            colSetor.ReadOnly = true;
            colSetor.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSetor.Width = 95;
            // 
            // colAdmissao
            // 
            colAdmissao.HeaderText = "Admissão";
            colAdmissao.Name = "colAdmissao";
            colAdmissao.ReadOnly = true;
            colAdmissao.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAdmissao.Width = 90;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 70;
            // 
            // colEditar
            // 
            colEditar.DefaultCellStyle = dataGridViewCellStyle2;
            colEditar.FlatStyle = FlatStyle.Flat;
            colEditar.HeaderText = "Ações";
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Width = 60;
            // 
            // colJornada
            // 
            colJornada.DefaultCellStyle = dataGridViewCellStyle3;
            colJornada.FlatStyle = FlatStyle.Flat;
            colJornada.HeaderText = "";
            colJornada.Name = "colJornada";
            colJornada.ReadOnly = true;
            colJornada.Text = "Jornada";
            colJornada.UseColumnTextForButtonValue = true;
            colJornada.Width = 70;
            // 
            // colFerias
            // 
            colFerias.DefaultCellStyle = dataGridViewCellStyle4;
            colFerias.FlatStyle = FlatStyle.Flat;
            colFerias.HeaderText = "";
            colFerias.Name = "colFerias";
            colFerias.ReadOnly = true;
            colFerias.Text = "Férias";
            colFerias.UseColumnTextForButtonValue = true;
            colFerias.Width = 65;
            // 
            // colDetalhes
            // 
            colDetalhes.DefaultCellStyle = dataGridViewCellStyle5;
            colDetalhes.FlatStyle = FlatStyle.Flat;
            colDetalhes.HeaderText = "";
            colDetalhes.Name = "colDetalhes";
            colDetalhes.ReadOnly = true;
            colDetalhes.Text = "Detalhes";
            colDetalhes.UseColumnTextForButtonValue = true;
            colDetalhes.Width = 65;
            // 
            // colDesligar
            // 
            colDesligar.DefaultCellStyle = dataGridViewCellStyle6;
            colDesligar.FlatStyle = FlatStyle.Flat;
            colDesligar.HeaderText = "";
            colDesligar.Name = "colDesligar";
            colDesligar.ReadOnly = true;
            colDesligar.Text = "Desligar";
            colDesligar.UseColumnTextForButtonValue = true;
            colDesligar.Width = 70;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.Transparent;
            pnlFiltros.Controls.Add(btnTodos);
            pnlFiltros.Controls.Add(btnAtivos);
            pnlFiltros.Controls.Add(btnFerias);
            pnlFiltros.Controls.Add(btnAfastados);
            pnlFiltros.Controls.Add(btnDesligados);
            pnlFiltros.Location = new Point(20, 325);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(915, 48);
            pnlFiltros.TabIndex = 1;
            // \
            // btnTodos
            // \
            btnTodos.BackColor = Color.White;
            btnTodos.Cursor = Cursors.Hand;
            btnTodos.FlatAppearance.BorderColor = Color.FromArgb(215, 225, 235);
            btnTodos.FlatAppearance.BorderSize = 1;
            btnTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 253);
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnTodos.ForeColor = Color.FromArgb(45, 65, 85);
            btnTodos.Location = new Point(0, 4);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(100, 38);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = false;
            // \
            // btnAtivos
            // \
            btnAtivos.BackColor = Color.White;
            btnAtivos.Cursor = Cursors.Hand;
            btnAtivos.FlatAppearance.BorderColor = Color.FromArgb(215, 225, 235);
            btnAtivos.FlatAppearance.BorderSize = 1;
            btnAtivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 253);
            btnAtivos.FlatStyle = FlatStyle.Flat;
            btnAtivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnAtivos.ForeColor = Color.FromArgb(45, 65, 85);
            btnAtivos.Location = new Point(110, 4);
            btnAtivos.Name = "btnAtivos";
            btnAtivos.Size = new Size(100, 38);
            btnAtivos.TabIndex = 1;
            btnAtivos.Text = "Ativos";
            btnAtivos.UseVisualStyleBackColor = false;
            // \
            // btnFerias
            // \
            btnFerias.BackColor = Color.White;
            btnFerias.Cursor = Cursors.Hand;
            btnFerias.FlatAppearance.BorderColor = Color.FromArgb(215, 225, 235);
            btnFerias.FlatAppearance.BorderSize = 1;
            btnFerias.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 253);
            btnFerias.FlatStyle = FlatStyle.Flat;
            btnFerias.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnFerias.ForeColor = Color.FromArgb(45, 65, 85);
            btnFerias.Location = new Point(220, 4);
            btnFerias.Name = "btnFerias";
            btnFerias.Size = new Size(100, 38);
            btnFerias.TabIndex = 2;
            btnFerias.Text = "Férias";
            btnFerias.UseVisualStyleBackColor = false;
            // \
            // btnAfastados
            // \
            btnAfastados.BackColor = Color.White;
            btnAfastados.Cursor = Cursors.Hand;
            btnAfastados.FlatAppearance.BorderColor = Color.FromArgb(215, 225, 235);
            btnAfastados.FlatAppearance.BorderSize = 1;
            btnAfastados.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 253);
            btnAfastados.FlatStyle = FlatStyle.Flat;
            btnAfastados.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnAfastados.ForeColor = Color.FromArgb(45, 65, 85);
            btnAfastados.Location = new Point(330, 4);
            btnAfastados.Name = "btnAfastados";
            btnAfastados.Size = new Size(100, 38);
            btnAfastados.TabIndex = 3;
            btnAfastados.Text = "Afastados";
            btnAfastados.UseVisualStyleBackColor = false;
            // \
            // btnDesligados
            // \
            btnDesligados.BackColor = Color.White;
            btnDesligados.Cursor = Cursors.Hand;
            btnDesligados.FlatAppearance.BorderColor = Color.FromArgb(215, 225, 235);
            btnDesligados.FlatAppearance.BorderSize = 1;
            btnDesligados.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 253);
            btnDesligados.FlatStyle = FlatStyle.Flat;
            btnDesligados.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnDesligados.ForeColor = Color.FromArgb(45, 65, 85);
            btnDesligados.Location = new Point(440, 4);
            btnDesligados.Name = "btnDesligados";
            btnDesligados.Size = new Size(115, 38);
            btnDesligados.TabIndex = 4;
            btnDesligados.Text = "Desligados";
            btnDesligados.UseVisualStyleBackColor = false;
            // 
            // pnlBusca
            // 
            pnlBusca.BackColor = Color.FromArgb(14, 52, 86);
            pnlBusca.Controls.Add(lblBuscar);
            pnlBusca.Controls.Add(txtBusca);
            pnlBusca.Controls.Add(btnNovoFuncionario);
            pnlBusca.Location = new Point(20, 230);
            pnlBusca.Name = "pnlBusca";
            pnlBusca.Size = new Size(915, 82);
            pnlBusca.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(20, 10);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(110, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar funcionário";
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.FromArgb(35, 72, 106);
            txtBusca.BorderStyle = BorderStyle.FixedSingle;
            txtBusca.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtBusca.ForeColor = Color.White;
            txtBusca.Location = new Point(20, 36);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(650, 25);
            txtBusca.TabIndex = 1;
            // 
            // btnNovoFuncionario
            // 
            btnNovoFuncionario.BackColor = Color.FromArgb(18, 126, 255);
            btnNovoFuncionario.Cursor = Cursors.Hand;
            btnNovoFuncionario.FlatAppearance.BorderSize = 0;
            btnNovoFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            btnNovoFuncionario.FlatStyle = FlatStyle.Flat;
            btnNovoFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnNovoFuncionario.ForeColor = Color.White;
            btnNovoFuncionario.Location = new Point(690, 25);
            btnNovoFuncionario.Name = "btnNovoFuncionario";
            btnNovoFuncionario.Size = new Size(205, 40);
            btnNovoFuncionario.TabIndex = 2;
            btnNovoFuncionario.Text = "+   Novo Funcionário";
            btnNovoFuncionario.UseVisualStyleBackColor = false;
            // 
            // pnlResumo
            // 
            pnlResumo.BackColor = Color.Transparent;
            pnlResumo.Controls.Add(pnlResumoTotal);
            pnlResumo.Controls.Add(pnlResumoAtivos);
            pnlResumo.Controls.Add(pnlResumoFerias);
            pnlResumo.Controls.Add(pnlResumoAfastados);
            pnlResumo.Controls.Add(pnlResumoDesligados);
            pnlResumo.Location = new Point(20, 125);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(915, 90);
            pnlResumo.TabIndex = 3;
            // 
            // pnlResumoTotal
            // 
            pnlResumoTotal.BackColor = Color.White;
            pnlResumoTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoTotal.Controls.Add(lblResumoTotal);
            pnlResumoTotal.Controls.Add(lblResumoTotalTexto);
            pnlResumoTotal.Location = new Point(0, 0);
            pnlResumoTotal.Name = "pnlResumoTotal";
            pnlResumoTotal.Size = new Size(175, 88);
            pnlResumoTotal.TabIndex = 0;
            // 
            // lblResumoTotal
            // 
            lblResumoTotal.AutoSize = true;
            lblResumoTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblResumoTotal.ForeColor = Color.FromArgb(21, 101, 192);
            lblResumoTotal.Location = new Point(18, 9);
            lblResumoTotal.Name = "lblResumoTotal";
            lblResumoTotal.Size = new Size(38, 45);
            lblResumoTotal.TabIndex = 0;
            lblResumoTotal.Text = "0";
            // 
            // lblResumoTotalTexto
            // 
            lblResumoTotalTexto.AutoSize = true;
            lblResumoTotalTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblResumoTotalTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoTotalTexto.Location = new Point(20, 57);
            lblResumoTotalTexto.Name = "lblResumoTotalTexto";
            lblResumoTotalTexto.Size = new Size(141, 15);
            lblResumoTotalTexto.TabIndex = 1;
            lblResumoTotalTexto.Text = "Funcionários cadastrados";
            // 
            // pnlResumoAtivos
            // 
            pnlResumoAtivos.BackColor = Color.White;
            pnlResumoAtivos.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoAtivos.Controls.Add(lblResumoAtivos);
            pnlResumoAtivos.Controls.Add(lblResumoAtivosTexto);
            pnlResumoAtivos.Location = new Point(185, 0);
            pnlResumoAtivos.Name = "pnlResumoAtivos";
            pnlResumoAtivos.Size = new Size(175, 88);
            pnlResumoAtivos.TabIndex = 1;
            // 
            // lblResumoAtivos
            // 
            lblResumoAtivos.AutoSize = true;
            lblResumoAtivos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblResumoAtivos.ForeColor = Color.FromArgb(34, 139, 82);
            lblResumoAtivos.Location = new Point(18, 9);
            lblResumoAtivos.Name = "lblResumoAtivos";
            lblResumoAtivos.Size = new Size(38, 45);
            lblResumoAtivos.TabIndex = 0;
            lblResumoAtivos.Text = "0";
            // 
            // lblResumoAtivosTexto
            // 
            lblResumoAtivosTexto.AutoSize = true;
            lblResumoAtivosTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblResumoAtivosTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoAtivosTexto.Location = new Point(20, 57);
            lblResumoAtivosTexto.Name = "lblResumoAtivosTexto";
            lblResumoAtivosTexto.Size = new Size(118, 15);
            lblResumoAtivosTexto.TabIndex = 1;
            lblResumoAtivosTexto.Text = "Colaboradores ativos";
            // 
            // pnlResumoFerias
            // 
            pnlResumoFerias.BackColor = Color.White;
            pnlResumoFerias.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoFerias.Controls.Add(lblResumoFerias);
            pnlResumoFerias.Controls.Add(lblResumoFeriasTexto);
            pnlResumoFerias.Location = new Point(370, 0);
            pnlResumoFerias.Name = "pnlResumoFerias";
            pnlResumoFerias.Size = new Size(175, 88);
            pnlResumoFerias.TabIndex = 2;
            // 
            // lblResumoFerias
            // 
            lblResumoFerias.AutoSize = true;
            lblResumoFerias.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblResumoFerias.ForeColor = Color.FromArgb(230, 145, 20);
            lblResumoFerias.Location = new Point(18, 9);
            lblResumoFerias.Name = "lblResumoFerias";
            lblResumoFerias.Size = new Size(38, 45);
            lblResumoFerias.TabIndex = 0;
            lblResumoFerias.Text = "0";
            // 
            // lblResumoFeriasTexto
            // 
            lblResumoFeriasTexto.AutoSize = true;
            lblResumoFeriasTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblResumoFeriasTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoFeriasTexto.Location = new Point(20, 57);
            lblResumoFeriasTexto.Name = "lblResumoFeriasTexto";
            lblResumoFeriasTexto.Size = new Size(115, 15);
            lblResumoFeriasTexto.TabIndex = 1;
            lblResumoFeriasTexto.Text = "Em período de férias";
            // 
            // pnlResumoAfastados
            // 
            pnlResumoAfastados.BackColor = Color.White;
            pnlResumoAfastados.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoAfastados.Controls.Add(lblResumoAfastados);
            pnlResumoAfastados.Controls.Add(lblResumoAfastadosTexto);
            pnlResumoAfastados.Location = new Point(555, 0);
            pnlResumoAfastados.Name = "pnlResumoAfastados";
            pnlResumoAfastados.Size = new Size(175, 88);
            pnlResumoAfastados.TabIndex = 3;
            // 
            // lblResumoAfastados
            // 
            lblResumoAfastados.AutoSize = true;
            lblResumoAfastados.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblResumoAfastados.ForeColor = Color.FromArgb(190, 75, 75);
            lblResumoAfastados.Location = new Point(18, 9);
            lblResumoAfastados.Name = "lblResumoAfastados";
            lblResumoAfastados.Size = new Size(38, 45);
            lblResumoAfastados.TabIndex = 0;
            lblResumoAfastados.Text = "0";
            // 
            // lblResumoAfastadosTexto
            // 
            lblResumoAfastadosTexto.AutoSize = true;
            lblResumoAfastadosTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblResumoAfastadosTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoAfastadosTexto.Location = new Point(20, 57);
            lblResumoAfastadosTexto.Name = "lblResumoAfastadosTexto";
            lblResumoAfastadosTexto.Size = new Size(141, 15);
            lblResumoAfastadosTexto.TabIndex = 1;
            lblResumoAfastadosTexto.Text = "Afastamentos registrados";
            // 
            // pnlResumoDesligados
            // 
            pnlResumoDesligados.BackColor = Color.White;
            pnlResumoDesligados.BorderStyle = BorderStyle.FixedSingle;
            pnlResumoDesligados.Controls.Add(lblResumoDesligados);
            pnlResumoDesligados.Controls.Add(lblResumoDesligadosTexto);
            pnlResumoDesligados.Location = new Point(740, 0);
            pnlResumoDesligados.Name = "pnlResumoDesligados";
            pnlResumoDesligados.Size = new Size(175, 88);
            pnlResumoDesligados.TabIndex = 4;
            // 
            // lblResumoDesligados
            // 
            lblResumoDesligados.AutoSize = true;
            lblResumoDesligados.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblResumoDesligados.ForeColor = Color.FromArgb(198, 40, 40);
            lblResumoDesligados.Location = new Point(18, 9);
            lblResumoDesligados.Name = "lblResumoDesligados";
            lblResumoDesligados.Size = new Size(38, 45);
            lblResumoDesligados.TabIndex = 0;
            lblResumoDesligados.Text = "0";
            // 
            // lblResumoDesligadosTexto
            // 
            lblResumoDesligadosTexto.AutoSize = true;
            lblResumoDesligadosTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblResumoDesligadosTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoDesligadosTexto.Location = new Point(20, 57);
            lblResumoDesligadosTexto.Name = "lblResumoDesligadosTexto";
            lblResumoDesligadosTexto.Size = new Size(70, 15);
            lblResumoDesligadosTexto.TabIndex = 1;
            lblResumoDesligadosTexto.Text = "Desligados";
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblUsuario);
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1045, 112);
            pnlCabecalho.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(14, 48, 82);
            lblTitulo.Location = new Point(32, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Funcionários";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 125, 150);
            lblSubtitulo.Location = new Point(35, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(245, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie os colaboradores da empresa";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(21, 101, 192);
            lblUsuario.Location = new Point(760, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(160, 24);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "●  Administrador";
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1200, 760);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RH Control — Funcionários";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlConteudo.ResumeLayout(false);
            pnlLista.ResumeLayout(false);
            pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            pnlFiltros.ResumeLayout(false);
            pnlBusca.ResumeLayout(false);
            pnlBusca.PerformLayout();
            pnlResumo.ResumeLayout(false);
            pnlResumoTotal.ResumeLayout(false);
            pnlResumoTotal.PerformLayout();
            pnlResumoAtivos.ResumeLayout(false);
            pnlResumoAtivos.PerformLayout();
            pnlResumoFerias.ResumeLayout(false);
            pnlResumoFerias.PerformLayout();
            pnlResumoAfastados.ResumeLayout(false);
            pnlResumoAfastados.PerformLayout();
            pnlResumoDesligados.ResumeLayout(false);
            pnlResumoDesligados.PerformLayout();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ResumeLayout(false);
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