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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            pnlCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(8, 48, 88);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblNomeSistema);
            pnlMenu.Controls.Add(lblSubtituloMenu);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnFuncionarios);
            pnlMenu.Controls.Add(btnJornada);
            pnlMenu.Controls.Add(btnFolha);
            pnlMenu.Controls.Add(btnConfiguracoes);
            pnlMenu.Controls.Add(lblVersao);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(235, 800);
            pnlMenu.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logorh;
            picLogo.Location = new Point(38, 30);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(160, 125);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.AutoSize = true;
            lblNomeSistema.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblNomeSistema.ForeColor = Color.White;
            lblNomeSistema.Location = new Point(43, 162);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(159, 31);
            lblNomeSistema.TabIndex = 1;
            lblNomeSistema.Text = "RH CONTROL";
            // 
            // lblSubtituloMenu
            // 
            lblSubtituloMenu.AutoSize = true;
            lblSubtituloMenu.Font = new Font("Segoe UI", 9F);
            lblSubtituloMenu.ForeColor = Color.FromArgb(175, 202, 225);
            lblSubtituloMenu.Location = new Point(47, 189);
            lblSubtituloMenu.Name = "lblSubtituloMenu";
            lblSubtituloMenu.Size = new Size(117, 15);
            lblSubtituloMenu.TabIndex = 2;
            lblSubtituloMenu.Text = "GESTÃO DE PESSOAS";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(8, 48, 88);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 82, 125);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 225);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(215, 44);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "⌂   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(20, 125, 235);
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 250);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(10, 277);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(15, 0, 0, 0);
            btnFuncionarios.Size = new Size(215, 44);
            btnFuncionarios.TabIndex = 4;
            btnFuncionarios.Text = "●   Funcionários";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnJornada
            // 
            btnJornada.BackColor = Color.FromArgb(8, 48, 88);
            btnJornada.FlatAppearance.BorderSize = 0;
            btnJornada.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 82, 125);
            btnJornada.FlatStyle = FlatStyle.Flat;
            btnJornada.Font = new Font("Segoe UI", 10F);
            btnJornada.ForeColor = Color.White;
            btnJornada.Location = new Point(10, 329);
            btnJornada.Name = "btnJornada";
            btnJornada.Padding = new Padding(15, 0, 0, 0);
            btnJornada.Size = new Size(215, 44);
            btnJornada.TabIndex = 5;
            btnJornada.Text = "▣   Jornada / Calendário";
            btnJornada.TextAlign = ContentAlignment.MiddleLeft;
            btnJornada.UseVisualStyleBackColor = false;
            // 
            // btnFolha
            // 
            btnFolha.BackColor = Color.FromArgb(8, 48, 88);
            btnFolha.FlatAppearance.BorderSize = 0;
            btnFolha.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 82, 125);
            btnFolha.FlatStyle = FlatStyle.Flat;
            btnFolha.Font = new Font("Segoe UI", 10F);
            btnFolha.ForeColor = Color.White;
            btnFolha.Location = new Point(10, 381);
            btnFolha.Name = "btnFolha";
            btnFolha.Padding = new Padding(15, 0, 0, 0);
            btnFolha.Size = new Size(215, 44);
            btnFolha.TabIndex = 6;
            btnFolha.Text = "$   Folha / Relatórios";
            btnFolha.TextAlign = ContentAlignment.MiddleLeft;
            btnFolha.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.FromArgb(8, 48, 88);
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 82, 125);
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Segoe UI", 10F);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.Location = new Point(10, 433);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(15, 0, 0, 0);
            btnConfiguracoes.Size = new Size(215, 44);
            btnConfiguracoes.TabIndex = 7;
            btnConfiguracoes.Text = "⚙   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 8.5F);
            lblVersao.ForeColor = Color.FromArgb(145, 180, 210);
            lblVersao.Location = new Point(42, 752);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(98, 15);
            lblVersao.TabIndex = 8;
            lblVersao.Text = "RH Control • v1.0";
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
            pnlConteudo.Location = new Point(235, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1045, 800);
            pnlConteudo.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.BorderStyle = BorderStyle.FixedSingle;
            pnlLista.Controls.Add(lblLista);
            pnlLista.Controls.Add(dgvFuncionarios);
            pnlLista.Location = new Point(25, 395);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(995, 380);
            pnlLista.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
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
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colNome, colCargo, colSetor, colAdmissao, colStatus, colEditar, colJornada, colDetalhes, colDesligar });
            dgvFuncionarios.EnableHeadersVisualStyles = false;
            dgvFuncionarios.GridColor = Color.FromArgb(228, 235, 242);
            dgvFuncionarios.Location = new Point(18, 52);
            dgvFuncionarios.MultiSelect = false;
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.RowHeadersVisible = false;
            dgvFuncionarios.RowTemplate.Height = 43;
            dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionarios.Size = new Size(955, 310);
            dgvFuncionarios.TabIndex = 1;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNome.Width = 175;
            // 
            // colCargo
            // 
            colCargo.HeaderText = "Cargo";
            colCargo.Name = "colCargo";
            colCargo.ReadOnly = true;
            colCargo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCargo.Width = 155;
            // 
            // colSetor
            // 
            colSetor.HeaderText = "Setor";
            colSetor.Name = "colSetor";
            colSetor.ReadOnly = true;
            colSetor.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSetor.Width = 115;
            // 
            // colAdmissao
            // 
            colAdmissao.HeaderText = "Admissão";
            colAdmissao.Name = "colAdmissao";
            colAdmissao.ReadOnly = true;
            colAdmissao.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 85;
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
            colEditar.Width = 70;
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
            colJornada.Width = 80;
            // 
            // colDetalhes
            // 
            colDetalhes.DefaultCellStyle = dataGridViewCellStyle4;
            colDetalhes.FlatStyle = FlatStyle.Flat;
            colDetalhes.HeaderText = "";
            colDetalhes.Name = "colDetalhes";
            colDetalhes.ReadOnly = true;
            colDetalhes.Text = "Detalhes";
            colDetalhes.UseColumnTextForButtonValue = true;
            colDetalhes.Width = 80;
            // 
            // colDesligar
            // 
            colDesligar.DefaultCellStyle = dataGridViewCellStyle5;
            colDesligar.FlatStyle = FlatStyle.Flat;
            colDesligar.HeaderText = "";
            colDesligar.Name = "colDesligar";
            colDesligar.ReadOnly = true;
            colDesligar.Text = "Desligar";
            colDesligar.UseColumnTextForButtonValue = true;
            colDesligar.Width = 80;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.Transparent;
            pnlFiltros.Controls.Add(btnTodos);
            pnlFiltros.Controls.Add(btnAtivos);
            pnlFiltros.Controls.Add(btnFerias);
            pnlFiltros.Controls.Add(btnAfastados);
            pnlFiltros.Controls.Add(btnDesligados);
            pnlFiltros.Location = new Point(25, 330);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(995, 48);
            pnlFiltros.TabIndex = 1;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(0, 0);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 0;
            // 
            // btnAtivos
            // 
            btnAtivos.Location = new Point(0, 0);
            btnAtivos.Name = "btnAtivos";
            btnAtivos.Size = new Size(75, 23);
            btnAtivos.TabIndex = 1;
            // 
            // btnFerias
            // 
            btnFerias.Location = new Point(0, 0);
            btnFerias.Name = "btnFerias";
            btnFerias.Size = new Size(75, 23);
            btnFerias.TabIndex = 2;
            // 
            // btnAfastados
            // 
            btnAfastados.Location = new Point(0, 0);
            btnAfastados.Name = "btnAfastados";
            btnAfastados.Size = new Size(75, 23);
            btnAfastados.TabIndex = 3;
            // 
            // btnDesligados
            // 
            btnDesligados.Location = new Point(0, 0);
            btnDesligados.Name = "btnDesligados";
            btnDesligados.Size = new Size(75, 23);
            btnDesligados.TabIndex = 4;
            // 
            // pnlBusca
            // 
            pnlBusca.BackColor = Color.FromArgb(14, 52, 86);
            pnlBusca.Controls.Add(lblBuscar);
            pnlBusca.Controls.Add(txtBusca);
            pnlBusca.Controls.Add(btnNovoFuncionario);
            pnlBusca.Location = new Point(25, 235);
            pnlBusca.Name = "pnlBusca";
            pnlBusca.Size = new Size(995, 82);
            pnlBusca.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            txtBusca.Font = new Font("Segoe UI", 10F);
            txtBusca.ForeColor = Color.White;
            txtBusca.Location = new Point(20, 36);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(700, 25);
            txtBusca.TabIndex = 1;
            // 
            // btnNovoFuncionario
            // 
            btnNovoFuncionario.BackColor = Color.FromArgb(20, 125, 235);
            btnNovoFuncionario.Cursor = Cursors.Hand;
            btnNovoFuncionario.FlatAppearance.BorderSize = 0;
            btnNovoFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 250);
            btnNovoFuncionario.FlatStyle = FlatStyle.Flat;
            btnNovoFuncionario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovoFuncionario.ForeColor = Color.White;
            btnNovoFuncionario.Location = new Point(740, 25);
            btnNovoFuncionario.Name = "btnNovoFuncionario";
            btnNovoFuncionario.Size = new Size(235, 40);
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
            pnlResumo.Location = new Point(25, 130);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(995, 90);
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
            pnlResumoTotal.Size = new Size(235, 88);
            pnlResumoTotal.TabIndex = 0;
            // 
            // lblResumoTotal
            // 
            lblResumoTotal.AutoSize = true;
            lblResumoTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
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
            lblResumoTotalTexto.Font = new Font("Segoe UI", 9F);
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
            pnlResumoAtivos.Location = new Point(253, 0);
            pnlResumoAtivos.Name = "pnlResumoAtivos";
            pnlResumoAtivos.Size = new Size(235, 88);
            pnlResumoAtivos.TabIndex = 1;
            // 
            // lblResumoAtivos
            // 
            lblResumoAtivos.AutoSize = true;
            lblResumoAtivos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
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
            lblResumoAtivosTexto.Font = new Font("Segoe UI", 9F);
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
            pnlResumoFerias.Location = new Point(506, 0);
            pnlResumoFerias.Name = "pnlResumoFerias";
            pnlResumoFerias.Size = new Size(235, 88);
            pnlResumoFerias.TabIndex = 2;
            // 
            // lblResumoFerias
            // 
            lblResumoFerias.AutoSize = true;
            lblResumoFerias.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
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
            lblResumoFeriasTexto.Font = new Font("Segoe UI", 9F);
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
            pnlResumoAfastados.Location = new Point(759, 0);
            pnlResumoAfastados.Name = "pnlResumoAfastados";
            pnlResumoAfastados.Size = new Size(235, 88);
            pnlResumoAfastados.TabIndex = 3;
            // 
            // lblResumoAfastados
            // 
            lblResumoAfastados.AutoSize = true;
            lblResumoAfastados.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
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
            lblResumoAfastadosTexto.Font = new Font("Segoe UI", 9F);
            lblResumoAfastadosTexto.ForeColor = Color.FromArgb(95, 115, 135);
            lblResumoAfastadosTexto.Location = new Point(20, 57);
            lblResumoAfastadosTexto.Name = "lblResumoAfastadosTexto";
            lblResumoAfastadosTexto.Size = new Size(141, 15);
            lblResumoAfastadosTexto.TabIndex = 1;
            lblResumoAfastadosTexto.Text = "Afastamentos registrados";
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
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(14, 48, 82);
            lblTitulo.Location = new Point(44, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Funcionários";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 125, 150);
            lblSubtitulo.Location = new Point(38, 73);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(245, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie os colaboradores da empresa";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(21, 101, 192);
            lblUsuario.Location = new Point(875, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(122, 19);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "●  Administrador";
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1280, 800);
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