namespace RHControl
{
    partial class FrmCadastroFuncionario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel pnlDadosPessoais;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Panel pnlDadosProfissionais;
        private System.Windows.Forms.Label lblDadosProfissionais;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblTipoJornada;
        private System.Windows.Forms.ComboBox cmbTipoJornada;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.ComboBox cmbEscala;
        private System.Windows.Forms.Label lblDiaFolga;
        private System.Windows.Forms.ComboBox cmbDiaFolga;
        private System.Windows.Forms.Label lblDiaFolga2;
        private System.Windows.Forms.ComboBox cmbDiaFolga2;
        private System.Windows.Forms.Label lblDataBaseEscala;
        private System.Windows.Forms.DateTimePicker dtpDataBaseEscala;

        private System.Windows.Forms.Panel pnlJornada;
        private System.Windows.Forms.Label lblJornadaTitulo;
        private System.Windows.Forms.Label lblJornadaSubtitulo;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.NumericUpDown nudCargaHoraria;
        private System.Windows.Forms.Label lblHorarioEntrada;
        private System.Windows.Forms.DateTimePicker dtpHorarioEntrada;
        private System.Windows.Forms.Label lblHorarioSaida;
        private System.Windows.Forms.DateTimePicker dtpHorarioSaida;
        private System.Windows.Forms.Label lblInicioIntervalo;
        private System.Windows.Forms.DateTimePicker dtpInicioIntervalo;
        private System.Windows.Forms.Label lblFimIntervalo;
        private System.Windows.Forms.DateTimePicker dtpFimIntervalo;

        private System.Windows.Forms.Panel pnlBeneficios;
        private System.Windows.Forms.Label lblBeneficios;
        private System.Windows.Forms.Label lblBeneficiosSubtitulo;
        private System.Windows.Forms.Label lblNomeBeneficio;
        private System.Windows.Forms.TextBox txtNomeBeneficio;
        private System.Windows.Forms.Label lblTipoDesconto;
        private System.Windows.Forms.RadioButton rbPercentual;
        private System.Windows.Forms.RadioButton rbValorFixo;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.NumericUpDown nudPercentual;
        private System.Windows.Forms.Button btnAdicionarBeneficio;
        private System.Windows.Forms.DataGridView dgvBeneficios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeneficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDesconto;
        private System.Windows.Forms.DataGridViewButtonColumn colRemoverBeneficio;
        private System.Windows.Forms.Label lblTotalDescontos;
        private System.Windows.Forms.Label lblSalarioEstimado;

        private System.Windows.Forms.Panel pnlObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblObservacoesSubtitulo;
        private System.Windows.Forms.TextBox txtObservacoes;

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;

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
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlDadosPessoais = new Panel();
            lblDadosPessoais = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            pnlDadosProfissionais = new Panel();
            lblDadosProfissionais = new Label();
            lblCargo = new Label();
            txtCargo = new TextBox();
            lblSetor = new Label();
            txtSetor = new TextBox();
            lblDataAdmissao = new Label();
            dtpDataAdmissao = new DateTimePicker();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblTipoJornada = new Label();
            cmbTipoJornada = new ComboBox();
            lblEscala = new Label();
            cmbEscala = new ComboBox();
            lblDiaFolga = new Label();
            cmbDiaFolga = new ComboBox();
            lblDiaFolga2 = new Label();
            cmbDiaFolga2 = new ComboBox();
            lblDataBaseEscala = new Label();
            dtpDataBaseEscala = new DateTimePicker();
            pnlJornada = new Panel();
            lblJornadaTitulo = new Label();
            lblJornadaSubtitulo = new Label();
            lblCargaHoraria = new Label();
            nudCargaHoraria = new NumericUpDown();
            lblHorarioEntrada = new Label();
            dtpHorarioEntrada = new DateTimePicker();
            lblHorarioSaida = new Label();
            dtpHorarioSaida = new DateTimePicker();
            lblInicioIntervalo = new Label();
            dtpInicioIntervalo = new DateTimePicker();
            lblFimIntervalo = new Label();
            dtpFimIntervalo = new DateTimePicker();
            pnlBeneficios = new Panel();
            lblBeneficios = new Label();
            lblBeneficiosSubtitulo = new Label();
            lblNomeBeneficio = new Label();
            txtNomeBeneficio = new TextBox();
            lblTipoDesconto = new Label();
            rbPercentual = new RadioButton();
            rbValorFixo = new RadioButton();
            lblValorDesconto = new Label();
            nudPercentual = new NumericUpDown();
            btnAdicionarBeneficio = new Button();
            dgvBeneficios = new DataGridView();
            colBeneficio = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colDesconto = new DataGridViewTextBoxColumn();
            colValorDesconto = new DataGridViewTextBoxColumn();
            colRemoverBeneficio = new DataGridViewButtonColumn();
            lblTotalDescontos = new Label();
            lblSalarioEstimado = new Label();
            pnlObservacoes = new Panel();
            lblObservacoes = new Label();
            lblObservacoesSubtitulo = new Label();
            txtObservacoes = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pnlCabecalho.SuspendLayout();
            pnlDadosPessoais.SuspendLayout();
            pnlDadosProfissionais.SuspendLayout();
            pnlJornada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).BeginInit();
            pnlBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercentual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).BeginInit();
            pnlObservacoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(10, 60, 105);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1100, 105);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(38, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Funcionário";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(205, 225, 245);
            lblSubtitulo.Location = new Point(42, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(394, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Cadastre as informações pessoais e profissionais do colaborador";
            // 
            // pnlDadosPessoais
            // 
            pnlDadosPessoais.BackColor = Color.White;
            pnlDadosPessoais.BorderStyle = BorderStyle.FixedSingle;
            pnlDadosPessoais.Controls.Add(lblDadosPessoais);
            pnlDadosPessoais.Controls.Add(lblNome);
            pnlDadosPessoais.Controls.Add(txtNome);
            pnlDadosPessoais.Controls.Add(lblCPF);
            pnlDadosPessoais.Controls.Add(txtCPF);
            pnlDadosPessoais.Controls.Add(lblDataNascimento);
            pnlDadosPessoais.Controls.Add(dtpDataNascimento);
            pnlDadosPessoais.Controls.Add(lblTelefone);
            pnlDadosPessoais.Controls.Add(txtTelefone);
            pnlDadosPessoais.Controls.Add(lblEmail);
            pnlDadosPessoais.Controls.Add(txtEmail);
            pnlDadosPessoais.Location = new Point(25, 125);
            pnlDadosPessoais.Name = "pnlDadosPessoais";
            pnlDadosPessoais.Size = new Size(1050, 135);
            pnlDadosPessoais.TabIndex = 1;
            // 
            // lblDadosPessoais
            // 
            lblDadosPessoais.AutoSize = true;
            lblDadosPessoais.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDadosPessoais.ForeColor = Color.FromArgb(21, 101, 192);
            lblDadosPessoais.Location = new Point(20, 12);
            lblDadosPessoais.Name = "lblDadosPessoais";
            lblDadosPessoais.Size = new Size(116, 20);
            lblDadosPessoais.TabIndex = 0;
            lblDadosPessoais.Text = "Dados pessoais";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNome.Location = new Point(20, 43);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(105, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome completo *";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(20, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(390, 25);
            txtNome.TabIndex = 2;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCPF.Location = new Point(430, 43);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(27, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 10F);
            txtCPF.Location = new Point(430, 64);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(180, 25);
            txtCPF.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataNascimento.Location = new Point(630, 43);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 5;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(630, 64);
            dtpDataNascimento.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDataNascimento.MinDate = new DateTime(1919, 1, 1, 0, 0, 0, 0);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(145, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTelefone.Location = new Point(795, 43);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(56, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10F);
            txtTelefone.Location = new Point(795, 64);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(225, 25);
            txtTelefone.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEmail.Location = new Point(20, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(70, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(540, 25);
            txtEmail.TabIndex = 10;
            // 
            // pnlDadosProfissionais
            // 
            pnlDadosProfissionais.BackColor = Color.White;
            pnlDadosProfissionais.BorderStyle = BorderStyle.FixedSingle;
            pnlDadosProfissionais.Controls.Add(lblDadosProfissionais);
            pnlDadosProfissionais.Controls.Add(lblCargo);
            pnlDadosProfissionais.Controls.Add(txtCargo);
            pnlDadosProfissionais.Controls.Add(lblSetor);
            pnlDadosProfissionais.Controls.Add(txtSetor);
            pnlDadosProfissionais.Controls.Add(lblDataAdmissao);
            pnlDadosProfissionais.Controls.Add(dtpDataAdmissao);
            pnlDadosProfissionais.Controls.Add(lblSalario);
            pnlDadosProfissionais.Controls.Add(txtSalario);
            pnlDadosProfissionais.Controls.Add(lblTipoJornada);
            pnlDadosProfissionais.Controls.Add(cmbTipoJornada);
            pnlDadosProfissionais.Controls.Add(lblEscala);
            pnlDadosProfissionais.Controls.Add(cmbEscala);
            pnlDadosProfissionais.Controls.Add(lblDiaFolga);
            pnlDadosProfissionais.Controls.Add(cmbDiaFolga);
            pnlDadosProfissionais.Controls.Add(lblDiaFolga2);
            pnlDadosProfissionais.Controls.Add(cmbDiaFolga2);
            pnlDadosProfissionais.Controls.Add(lblDataBaseEscala);
            pnlDadosProfissionais.Controls.Add(dtpDataBaseEscala);
            pnlDadosProfissionais.Location = new Point(25, 275);
            pnlDadosProfissionais.Name = "pnlDadosProfissionais";
            pnlDadosProfissionais.Size = new Size(1050, 175);
            pnlDadosProfissionais.TabIndex = 2;
            // 
            // lblDadosProfissionais
            // 
            lblDadosProfissionais.AutoSize = true;
            lblDadosProfissionais.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDadosProfissionais.ForeColor = Color.FromArgb(21, 101, 192);
            lblDadosProfissionais.Location = new Point(20, 12);
            lblDadosProfissionais.Name = "lblDadosProfissionais";
            lblDadosProfissionais.Size = new Size(146, 20);
            lblDadosProfissionais.TabIndex = 0;
            lblDadosProfissionais.Text = "Dados profissionais";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCargo.Location = new Point(20, 43);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(47, 15);
            lblCargo.TabIndex = 1;
            lblCargo.Text = "Cargo *";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 10F);
            txtCargo.Location = new Point(20, 64);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(250, 25);
            txtCargo.TabIndex = 2;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSetor.Location = new Point(290, 43);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(38, 15);
            lblSetor.TabIndex = 3;
            lblSetor.Text = "Setor";
            // 
            // txtSetor
            // 
            txtSetor.Font = new Font("Segoe UI", 10F);
            txtSetor.Location = new Point(290, 64);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(180, 25);
            txtSetor.TabIndex = 4;
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataAdmissao.Location = new Point(490, 43);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(111, 15);
            lblDataAdmissao.TabIndex = 5;
            lblDataAdmissao.Text = "Data de admissão *";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(490, 64);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(145, 23);
            dtpDataAdmissao.TabIndex = 6;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSalario.Location = new Point(655, 43);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(52, 15);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salário *";
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 10F);
            txtSalario.Location = new Point(655, 64);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(145, 25);
            txtSalario.TabIndex = 8;
            // 
            // lblTipoJornada
            // 
            lblTipoJornada.AutoSize = true;
            lblTipoJornada.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipoJornada.Location = new Point(820, 43);
            lblTipoJornada.Name = "lblTipoJornada";
            lblTipoJornada.Size = new Size(92, 15);
            lblTipoJornada.TabIndex = 9;
            lblTipoJornada.Text = "Tipo de jornada";
            // 
            // cmbTipoJornada
            // 
            cmbTipoJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoJornada.Font = new Font("Segoe UI", 9F);
            cmbTipoJornada.Items.AddRange(new object[] { "Jornada fixa", "Por escala" });
            cmbTipoJornada.Location = new Point(820, 64);
            cmbTipoJornada.Name = "cmbTipoJornada";
            cmbTipoJornada.Size = new Size(200, 23);
            cmbTipoJornada.TabIndex = 10;
            // 
            // lblEscala
            // 
            lblEscala.AutoSize = true;
            lblEscala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEscala.Location = new Point(20, 105);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(47, 15);
            lblEscala.TabIndex = 11;
            lblEscala.Text = "Escala *";
            // 
            // cmbEscala
            // 
            cmbEscala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscala.Font = new Font("Segoe UI", 9F);
            cmbEscala.Items.AddRange(new object[] { "5x2", "6x1", "12x36", "4x2", "5x1", "Outra" });
            cmbEscala.Location = new Point(20, 126);
            cmbEscala.Name = "cmbEscala";
            cmbEscala.Size = new Size(130, 23);
            cmbEscala.TabIndex = 12;
            // 
            // lblDiaFolga
            // 
            lblDiaFolga.AutoSize = true;
            lblDiaFolga.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaFolga.Location = new Point(175, 105);
            lblDiaFolga.Name = "lblDiaFolga";
            lblDiaFolga.Size = new Size(86, 15);
            lblDiaFolga.TabIndex = 13;
            lblDiaFolga.Text = "Folga principal";
            // 
            // cmbDiaFolga
            // 
            cmbDiaFolga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiaFolga.Font = new Font("Segoe UI", 9F);
            cmbDiaFolga.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            cmbDiaFolga.Location = new Point(175, 126);
            cmbDiaFolga.Name = "cmbDiaFolga";
            cmbDiaFolga.Size = new Size(150, 23);
            cmbDiaFolga.TabIndex = 14;
            // 
            // lblDiaFolga2
            // 
            lblDiaFolga2.AutoSize = true;
            lblDiaFolga2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaFolga2.Location = new Point(350, 105);
            lblDiaFolga2.Name = "lblDiaFolga2";
            lblDiaFolga2.Size = new Size(50, 15);
            lblDiaFolga2.TabIndex = 15;
            lblDiaFolga2.Text = "2ª folga";
            // 
            // cmbDiaFolga2
            // 
            cmbDiaFolga2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiaFolga2.Font = new Font("Segoe UI", 9F);
            cmbDiaFolga2.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            cmbDiaFolga2.Location = new Point(350, 126);
            cmbDiaFolga2.Name = "cmbDiaFolga2";
            cmbDiaFolga2.Size = new Size(150, 23);
            cmbDiaFolga2.TabIndex = 16;
            // 
            // lblDataBaseEscala
            // 
            lblDataBaseEscala.AutoSize = true;
            lblDataBaseEscala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataBaseEscala.Location = new Point(525, 105);
            lblDataBaseEscala.Name = "lblDataBaseEscala";
            lblDataBaseEscala.Size = new Size(115, 15);
            lblDataBaseEscala.TabIndex = 17;
            lblDataBaseEscala.Text = "Data-base da escala";
            // 
            // dtpDataBaseEscala
            // 
            dtpDataBaseEscala.Format = DateTimePickerFormat.Short;
            dtpDataBaseEscala.Location = new Point(525, 126);
            dtpDataBaseEscala.Name = "dtpDataBaseEscala";
            dtpDataBaseEscala.Size = new Size(145, 23);
            dtpDataBaseEscala.TabIndex = 18;
            // 
            // pnlJornada
            // 
            pnlJornada.BackColor = Color.FromArgb(237, 246, 255);
            pnlJornada.BorderStyle = BorderStyle.FixedSingle;
            pnlJornada.Controls.Add(lblJornadaTitulo);
            pnlJornada.Controls.Add(lblJornadaSubtitulo);
            pnlJornada.Controls.Add(lblCargaHoraria);
            pnlJornada.Controls.Add(nudCargaHoraria);
            pnlJornada.Controls.Add(lblHorarioEntrada);
            pnlJornada.Controls.Add(dtpHorarioEntrada);
            pnlJornada.Controls.Add(lblHorarioSaida);
            pnlJornada.Controls.Add(dtpHorarioSaida);
            pnlJornada.Controls.Add(lblInicioIntervalo);
            pnlJornada.Controls.Add(dtpInicioIntervalo);
            pnlJornada.Controls.Add(lblFimIntervalo);
            pnlJornada.Controls.Add(dtpFimIntervalo);
            pnlJornada.Location = new Point(25, 465);
            pnlJornada.Name = "pnlJornada";
            pnlJornada.Size = new Size(1050, 105);
            pnlJornada.TabIndex = 3;
            // 
            // lblJornadaTitulo
            // 
            lblJornadaTitulo.AutoSize = true;
            lblJornadaTitulo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblJornadaTitulo.ForeColor = Color.FromArgb(21, 101, 192);
            lblJornadaTitulo.Location = new Point(20, 10);
            lblJornadaTitulo.Name = "lblJornadaTitulo";
            lblJornadaTitulo.Size = new Size(145, 19);
            lblJornadaTitulo.TabIndex = 0;
            lblJornadaTitulo.Text = "Jornada de trabalho";
            // 
            // lblJornadaSubtitulo
            // 
            lblJornadaSubtitulo.AutoSize = true;
            lblJornadaSubtitulo.Font = new Font("Segoe UI", 8F);
            lblJornadaSubtitulo.ForeColor = Color.FromArgb(90, 120, 150);
            lblJornadaSubtitulo.Location = new Point(180, 13);
            lblJornadaSubtitulo.Name = "lblJornadaSubtitulo";
            lblJornadaSubtitulo.Size = new Size(254, 13);
            lblJornadaSubtitulo.TabIndex = 1;
            lblJornadaSubtitulo.Text = "Configure os horários e a carga horária semanal";
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCargaHoraria.Location = new Point(20, 53);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(128, 15);
            lblCargaHoraria.TabIndex = 2;
            lblCargaHoraria.Text = "Carga horária semanal";
            // 
            // nudCargaHoraria
            // 
            nudCargaHoraria.Location = new Point(145, 50);
            nudCargaHoraria.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudCargaHoraria.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCargaHoraria.Name = "nudCargaHoraria";
            nudCargaHoraria.Size = new Size(60, 23);
            nudCargaHoraria.TabIndex = 3;
            nudCargaHoraria.Value = new decimal(new int[] { 44, 0, 0, 0 });
            // 
            // lblHorarioEntrada
            // 
            lblHorarioEntrada.AutoSize = true;
            lblHorarioEntrada.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHorarioEntrada.Location = new Point(240, 53);
            lblHorarioEntrada.Name = "lblHorarioEntrada";
            lblHorarioEntrada.Size = new Size(49, 15);
            lblHorarioEntrada.TabIndex = 4;
            lblHorarioEntrada.Text = "Entrada";
            // 
            // dtpHorarioEntrada
            // 
            dtpHorarioEntrada.Format = DateTimePickerFormat.Time;
            dtpHorarioEntrada.Location = new Point(295, 49);
            dtpHorarioEntrada.Name = "dtpHorarioEntrada";
            dtpHorarioEntrada.ShowUpDown = true;
            dtpHorarioEntrada.Size = new Size(80, 23);
            dtpHorarioEntrada.TabIndex = 5;
            dtpHorarioEntrada.Value = new DateTime(2026, 9, 8, 8, 0, 0, 0);
            // 
            // lblHorarioSaida
            // 
            lblHorarioSaida.AutoSize = true;
            lblHorarioSaida.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHorarioSaida.Location = new Point(410, 53);
            lblHorarioSaida.Name = "lblHorarioSaida";
            lblHorarioSaida.Size = new Size(36, 15);
            lblHorarioSaida.TabIndex = 6;
            lblHorarioSaida.Text = "Saída";
            // 
            // dtpHorarioSaida
            // 
            dtpHorarioSaida.Format = DateTimePickerFormat.Time;
            dtpHorarioSaida.Location = new Point(450, 49);
            dtpHorarioSaida.Name = "dtpHorarioSaida";
            dtpHorarioSaida.ShowUpDown = true;
            dtpHorarioSaida.Size = new Size(85, 23);
            dtpHorarioSaida.TabIndex = 7;
            dtpHorarioSaida.Value = new DateTime(2026, 9, 8, 17, 0, 0, 0);
            // 
            // lblInicioIntervalo
            // 
            lblInicioIntervalo.AutoSize = true;
            lblInicioIntervalo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInicioIntervalo.Location = new Point(570, 53);
            lblInicioIntervalo.Name = "lblInicioIntervalo";
            lblInicioIntervalo.Size = new Size(90, 15);
            lblInicioIntervalo.TabIndex = 8;
            lblInicioIntervalo.Text = "Início intervalo";
            // 
            // dtpInicioIntervalo
            // 
            dtpInicioIntervalo.Format = DateTimePickerFormat.Time;
            dtpInicioIntervalo.Location = new Point(665, 49);
            dtpInicioIntervalo.Name = "dtpInicioIntervalo";
            dtpInicioIntervalo.ShowUpDown = true;
            dtpInicioIntervalo.Size = new Size(85, 23);
            dtpInicioIntervalo.TabIndex = 9;
            dtpInicioIntervalo.Value = new DateTime(2026, 9, 8, 12, 0, 0, 0);
            // 
            // lblFimIntervalo
            // 
            lblFimIntervalo.AutoSize = true;
            lblFimIntervalo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFimIntervalo.Location = new Point(785, 53);
            lblFimIntervalo.Name = "lblFimIntervalo";
            lblFimIntervalo.Size = new Size(80, 15);
            lblFimIntervalo.TabIndex = 10;
            lblFimIntervalo.Text = "Fim intervalo";
            // 
            // dtpFimIntervalo
            // 
            dtpFimIntervalo.Format = DateTimePickerFormat.Time;
            dtpFimIntervalo.Location = new Point(875, 49);
            dtpFimIntervalo.Name = "dtpFimIntervalo";
            dtpFimIntervalo.ShowUpDown = true;
            dtpFimIntervalo.Size = new Size(90, 23);
            dtpFimIntervalo.TabIndex = 11;
            dtpFimIntervalo.Value = new DateTime(2026, 9, 8, 13, 0, 0, 0);
            // 
            // pnlBeneficios
            // 
            pnlBeneficios.BackColor = Color.White;
            pnlBeneficios.BorderStyle = BorderStyle.FixedSingle;
            pnlBeneficios.Controls.Add(lblBeneficios);
            pnlBeneficios.Controls.Add(lblBeneficiosSubtitulo);
            pnlBeneficios.Controls.Add(lblNomeBeneficio);
            pnlBeneficios.Controls.Add(txtNomeBeneficio);
            pnlBeneficios.Controls.Add(lblTipoDesconto);
            pnlBeneficios.Controls.Add(rbPercentual);
            pnlBeneficios.Controls.Add(rbValorFixo);
            pnlBeneficios.Controls.Add(lblValorDesconto);
            pnlBeneficios.Controls.Add(nudPercentual);
            pnlBeneficios.Controls.Add(btnAdicionarBeneficio);
            pnlBeneficios.Controls.Add(dgvBeneficios);
            pnlBeneficios.Controls.Add(lblTotalDescontos);
            pnlBeneficios.Controls.Add(lblSalarioEstimado);
            pnlBeneficios.Location = new Point(25, 585);
            pnlBeneficios.Name = "pnlBeneficios";
            pnlBeneficios.Size = new Size(1050, 225);
            pnlBeneficios.TabIndex = 4;
            // 
            // lblBeneficios
            // 
            lblBeneficios.AutoSize = true;
            lblBeneficios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBeneficios.ForeColor = Color.FromArgb(21, 101, 192);
            lblBeneficios.Location = new Point(20, 10);
            lblBeneficios.Name = "lblBeneficios";
            lblBeneficios.Size = new Size(168, 20);
            lblBeneficios.TabIndex = 0;
            lblBeneficios.Text = "Benefícios e descontos";
            // 
            // lblBeneficiosSubtitulo
            // 
            lblBeneficiosSubtitulo.AutoSize = true;
            lblBeneficiosSubtitulo.Font = new Font("Segoe UI", 8F);
            lblBeneficiosSubtitulo.ForeColor = Color.FromArgb(105, 125, 145);
            lblBeneficiosSubtitulo.Location = new Point(190, 13);
            lblBeneficiosSubtitulo.Name = "lblBeneficiosSubtitulo";
            lblBeneficiosSubtitulo.Size = new Size(241, 13);
            lblBeneficiosSubtitulo.TabIndex = 1;
            lblBeneficiosSubtitulo.Text = "Adicione benefícios e configure os descontos";
            // 
            // lblNomeBeneficio
            // 
            lblNomeBeneficio.AutoSize = true;
            lblNomeBeneficio.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNomeBeneficio.Location = new Point(20, 43);
            lblNomeBeneficio.Name = "lblNomeBeneficio";
            lblNomeBeneficio.Size = new Size(113, 15);
            lblNomeBeneficio.TabIndex = 2;
            lblNomeBeneficio.Text = "Nome do benefício";
            // 
            // txtNomeBeneficio
            // 
            txtNomeBeneficio.Font = new Font("Segoe UI", 9.5F);
            txtNomeBeneficio.Location = new Point(20, 64);
            txtNomeBeneficio.Name = "txtNomeBeneficio";
            txtNomeBeneficio.Size = new Size(300, 24);
            txtNomeBeneficio.TabIndex = 3;
            // 
            // lblTipoDesconto
            // 
            lblTipoDesconto.AutoSize = true;
            lblTipoDesconto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipoDesconto.Location = new Point(345, 43);
            lblTipoDesconto.Name = "lblTipoDesconto";
            lblTipoDesconto.Size = new Size(102, 15);
            lblTipoDesconto.TabIndex = 4;
            lblTipoDesconto.Text = "Tipo de desconto";
            // 
            // rbPercentual
            // 
            rbPercentual.AutoSize = true;
            rbPercentual.Checked = true;
            rbPercentual.Font = new Font("Segoe UI", 8.5F);
            rbPercentual.Location = new Point(345, 64);
            rbPercentual.Name = "rbPercentual";
            rbPercentual.Size = new Size(102, 19);
            rbPercentual.TabIndex = 5;
            rbPercentual.TabStop = true;
            rbPercentual.Text = "Percentual (%)";
            // 
            // rbValorFixo
            // 
            rbValorFixo.AutoSize = true;
            rbValorFixo.Font = new Font("Segoe UI", 8.5F);
            rbValorFixo.Location = new Point(345, 88);
            rbValorFixo.Name = "rbValorFixo";
            rbValorFixo.Size = new Size(98, 19);
            rbValorFixo.TabIndex = 6;
            rbValorFixo.Text = "Valor fixo (R$)";
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblValorDesconto.Location = new Point(530, 43);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(35, 15);
            lblValorDesconto.TabIndex = 7;
            lblValorDesconto.Text = "Valor";
            // 
            // nudPercentual
            // 
            nudPercentual.DecimalPlaces = 2;
            nudPercentual.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPercentual.Location = new Point(530, 64);
            nudPercentual.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPercentual.Name = "nudPercentual";
            nudPercentual.Size = new Size(105, 23);
            nudPercentual.TabIndex = 8;
            // 
            // btnAdicionarBeneficio
            // 
            btnAdicionarBeneficio.BackColor = Color.FromArgb(21, 101, 192);
            btnAdicionarBeneficio.Cursor = Cursors.Hand;
            btnAdicionarBeneficio.FlatAppearance.BorderSize = 0;
            btnAdicionarBeneficio.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnAdicionarBeneficio.FlatStyle = FlatStyle.Flat;
            btnAdicionarBeneficio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionarBeneficio.ForeColor = Color.White;
            btnAdicionarBeneficio.Location = new Point(660, 61);
            btnAdicionarBeneficio.Name = "btnAdicionarBeneficio";
            btnAdicionarBeneficio.Size = new Size(140, 38);
            btnAdicionarBeneficio.TabIndex = 9;
            btnAdicionarBeneficio.Text = "+ Adicionar";
            btnAdicionarBeneficio.UseVisualStyleBackColor = false;
            // 
            // dgvBeneficios
            // 
            dgvBeneficios.AllowUserToAddRows = false;
            dgvBeneficios.AllowUserToDeleteRows = false;
            dgvBeneficios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 253);
            dgvBeneficios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBeneficios.BackgroundColor = Color.White;
            dgvBeneficios.BorderStyle = BorderStyle.None;
            dgvBeneficios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(235, 242, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 55, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 242, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 55, 80);
            dgvBeneficios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBeneficios.ColumnHeadersHeight = 35;
            dgvBeneficios.Columns.AddRange(new DataGridViewColumn[] { colBeneficio, colTipo, colDesconto, colValorDesconto, colRemoverBeneficio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 60, 75);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 239, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(25, 55, 85);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBeneficios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBeneficios.EnableHeadersVisualStyles = false;
            dgvBeneficios.GridColor = Color.FromArgb(225, 232, 240);
            dgvBeneficios.Location = new Point(20, 120);
            dgvBeneficios.MultiSelect = false;
            dgvBeneficios.Name = "dgvBeneficios";
            dgvBeneficios.ReadOnly = true;
            dgvBeneficios.RowHeadersVisible = false;
            dgvBeneficios.RowTemplate.Height = 30;
            dgvBeneficios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeneficios.Size = new Size(650, 88);
            dgvBeneficios.TabIndex = 10;
            // 
            // colBeneficio
            // 
            colBeneficio.HeaderText = "Benefício";
            colBeneficio.Name = "colBeneficio";
            colBeneficio.ReadOnly = true;
            colBeneficio.Width = 190;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 120;
            // 
            // colDesconto
            // 
            colDesconto.HeaderText = "Desconto";
            colDesconto.Name = "colDesconto";
            colDesconto.ReadOnly = true;
            colDesconto.Width = 110;
            // 
            // colValorDesconto
            // 
            colValorDesconto.HeaderText = "Valor";
            colValorDesconto.Name = "colValorDesconto";
            colValorDesconto.ReadOnly = true;
            colValorDesconto.Width = 120;
            // 
            // colRemoverBeneficio
            // 
            colRemoverBeneficio.HeaderText = "Ação";
            colRemoverBeneficio.Name = "colRemoverBeneficio";
            colRemoverBeneficio.ReadOnly = true;
            colRemoverBeneficio.Text = "Remover";
            colRemoverBeneficio.UseColumnTextForButtonValue = true;
            colRemoverBeneficio.Width = 90;
            // 
            // lblTotalDescontos
            // 
            lblTotalDescontos.AutoSize = true;
            lblTotalDescontos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalDescontos.ForeColor = Color.FromArgb(90, 105, 120);
            lblTotalDescontos.Location = new Point(705, 135);
            lblTotalDescontos.Name = "lblTotalDescontos";
            lblTotalDescontos.Size = new Size(113, 15);
            lblTotalDescontos.TabIndex = 11;
            lblTotalDescontos.Text = "Descontos: R$ 0,00";
            // 
            // lblSalarioEstimado
            // 
            lblSalarioEstimado.AutoSize = true;
            lblSalarioEstimado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSalarioEstimado.ForeColor = Color.FromArgb(21, 101, 192);
            lblSalarioEstimado.Location = new Point(705, 172);
            lblSalarioEstimado.Name = "lblSalarioEstimado";
            lblSalarioEstimado.Size = new Size(187, 20);
            lblSalarioEstimado.TabIndex = 12;
            lblSalarioEstimado.Text = "Salário estimado: R$ 0,00";
            // 
            // pnlObservacoes
            // 
            pnlObservacoes.BackColor = Color.White;
            pnlObservacoes.BorderStyle = BorderStyle.FixedSingle;
            pnlObservacoes.Controls.Add(lblObservacoes);
            pnlObservacoes.Controls.Add(lblObservacoesSubtitulo);
            pnlObservacoes.Controls.Add(txtObservacoes);
            pnlObservacoes.Location = new Point(25, 825);
            pnlObservacoes.Name = "pnlObservacoes";
            pnlObservacoes.Size = new Size(1050, 65);
            pnlObservacoes.TabIndex = 5;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.FromArgb(21, 101, 192);
            lblObservacoes.Location = new Point(20, 8);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(96, 19);
            lblObservacoes.TabIndex = 0;
            lblObservacoes.Text = "Observações";
            // 
            // lblObservacoesSubtitulo
            // 
            lblObservacoesSubtitulo.AutoSize = true;
            lblObservacoesSubtitulo.Font = new Font("Segoe UI", 8F);
            lblObservacoesSubtitulo.ForeColor = Color.FromArgb(105, 125, 145);
            lblObservacoesSubtitulo.Location = new Point(110, 11);
            lblObservacoesSubtitulo.Name = "lblObservacoesSubtitulo";
            lblObservacoesSubtitulo.Size = new Size(233, 13);
            lblObservacoesSubtitulo.TabIndex = 1;
            lblObservacoesSubtitulo.Text = "Informações adicionais sobre o colaborador";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Segoe UI", 9F);
            txtObservacoes.Location = new Point(20, 32);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.ScrollBars = ScrollBars.Vertical;
            txtObservacoes.Size = new Size(1000, 25);
            txtObservacoes.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(205, 215, 225);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 247, 250);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(70, 85, 100);
            btnCancelar.Location = new Point(775, 900);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(21, 101, 192);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(915, 900);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar funcionário";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1100, 940);
            Controls.Add(pnlCabecalho);
            Controls.Add(pnlDadosPessoais);
            Controls.Add(pnlDadosProfissionais);
            Controls.Add(pnlJornada);
            Controls.Add(pnlBeneficios);
            Controls.Add(pnlObservacoes);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RH Control — Novo Funcionário";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlDadosPessoais.ResumeLayout(false);
            pnlDadosPessoais.PerformLayout();
            pnlDadosProfissionais.ResumeLayout(false);
            pnlDadosProfissionais.PerformLayout();
            pnlJornada.ResumeLayout(false);
            pnlJornada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).EndInit();
            pnlBeneficios.ResumeLayout(false);
            pnlBeneficios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercentual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).EndInit();
            pnlObservacoes.ResumeLayout(false);
            pnlObservacoes.PerformLayout();
            ResumeLayout(false);
        }
    }
}