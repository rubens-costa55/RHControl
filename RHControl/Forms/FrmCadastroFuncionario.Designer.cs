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
        private System.Windows.Forms.TextBox txtObservacoes;

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            txtObservacoes = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pnlCabecalho.SuspendLayout();
            pnlDadosPessoais.SuspendLayout();
            pnlDadosProfissionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).BeginInit();
            pnlBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercentual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficios).BeginInit();
            pnlObservacoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1000, 90);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(35, 45, 55);
            lblTitulo.Location = new Point(40, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Funcionário";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 110, 120);
            lblSubtitulo.Location = new Point(42, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(345, 15);
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
            pnlDadosPessoais.Location = new Point(25, 105);
            pnlDadosPessoais.Name = "pnlDadosPessoais";
            pnlDadosPessoais.Size = new Size(950, 125);
            pnlDadosPessoais.TabIndex = 1;
            // 
            // lblDadosPessoais
            // 
            lblDadosPessoais.AutoSize = true;
            lblDadosPessoais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDadosPessoais.ForeColor = Color.FromArgb(21, 101, 192);
            lblDadosPessoais.Location = new Point(20, 12);
            lblDadosPessoais.Name = "lblDadosPessoais";
            lblDadosPessoais.Size = new Size(111, 19);
            lblDadosPessoais.TabIndex = 0;
            lblDadosPessoais.Text = "Dados pessoais";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNome.Location = new Point(20, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(105, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome completo *";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(390, 23);
            txtNome.TabIndex = 2;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCPF.Location = new Point(430, 40);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(27, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(430, 60);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(180, 23);
            txtCPF.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataNascimento.Location = new Point(630, 40);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 5;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(630, 60);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(135, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTelefone.Location = new Point(785, 40);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(56, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(785, 60);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(140, 23);
            txtTelefone.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEmail.Location = new Point(20, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(540, 23);
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
            pnlDadosProfissionais.Controls.Add(lblCargaHoraria);
            pnlDadosProfissionais.Controls.Add(nudCargaHoraria);
            pnlDadosProfissionais.Controls.Add(lblHorarioEntrada);
            pnlDadosProfissionais.Controls.Add(dtpHorarioEntrada);
            pnlDadosProfissionais.Controls.Add(lblHorarioSaida);
            pnlDadosProfissionais.Controls.Add(dtpHorarioSaida);
            pnlDadosProfissionais.Controls.Add(lblInicioIntervalo);
            pnlDadosProfissionais.Controls.Add(dtpInicioIntervalo);
            pnlDadosProfissionais.Controls.Add(lblFimIntervalo);
            pnlDadosProfissionais.Controls.Add(dtpFimIntervalo);
            pnlDadosProfissionais.Location = new Point(25, 245);
            pnlDadosProfissionais.Name = "pnlDadosProfissionais";
            pnlDadosProfissionais.Size = new Size(950, 225);
            pnlDadosProfissionais.TabIndex = 2;
            // 
            // lblDadosProfissionais
            // 
            lblDadosProfissionais.AutoSize = true;
            lblDadosProfissionais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDadosProfissionais.ForeColor = Color.FromArgb(21, 101, 192);
            lblDadosProfissionais.Location = new Point(20, 12);
            lblDadosProfissionais.Name = "lblDadosProfissionais";
            lblDadosProfissionais.Size = new Size(139, 19);
            lblDadosProfissionais.TabIndex = 0;
            lblDadosProfissionais.Text = "Dados profissionais";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCargo.Location = new Point(20, 40);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(47, 15);
            lblCargo.TabIndex = 1;
            lblCargo.Text = "Cargo *";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(20, 60);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(230, 23);
            txtCargo.TabIndex = 2;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSetor.Location = new Point(270, 40);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(38, 15);
            lblSetor.TabIndex = 3;
            lblSetor.Text = "Setor";
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(270, 60);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(170, 23);
            txtSetor.TabIndex = 4;
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataAdmissao.Location = new Point(460, 40);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(111, 15);
            lblDataAdmissao.TabIndex = 5;
            lblDataAdmissao.Text = "Data de admissão *";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(460, 60);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(140, 23);
            dtpDataAdmissao.TabIndex = 6;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSalario.Location = new Point(620, 40);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(52, 15);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salário *";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(620, 60);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(135, 23);
            txtSalario.TabIndex = 8;
            // 
            // lblTipoJornada
            // 
            lblTipoJornada.AutoSize = true;
            lblTipoJornada.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipoJornada.Location = new Point(775, 40);
            lblTipoJornada.Name = "lblTipoJornada";
            lblTipoJornada.Size = new Size(88, 15);
            lblTipoJornada.TabIndex = 9;
            lblTipoJornada.Text = "Tipo de jornada";
            // 
            // cmbTipoJornada
            // 
            cmbTipoJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoJornada.Items.AddRange(new object[] { "Jornada fixa", "Por escala" });
            cmbTipoJornada.Location = new Point(775, 60);
            cmbTipoJornada.Name = "cmbTipoJornada";
            cmbTipoJornada.Size = new Size(150, 23);
            cmbTipoJornada.TabIndex = 10;
            // 
            // lblEscala
            // 
            lblEscala.AutoSize = true;
            lblEscala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEscala.Location = new Point(20, 102);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(47, 15);
            lblEscala.TabIndex = 11;
            lblEscala.Text = "Escala *";
            // 
            // cmbEscala
            // 
            cmbEscala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscala.Items.AddRange(new object[] { "5x2", "6x1", "12x36", "4x2", "5x1", "Outra" });
            cmbEscala.Location = new Point(20, 122);
            cmbEscala.Name = "cmbEscala";
            cmbEscala.Size = new Size(120, 23);
            cmbEscala.TabIndex = 12;
            // 
            // lblDiaFolga
            // 
            lblDiaFolga.AutoSize = true;
            lblDiaFolga.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaFolga.Location = new Point(165, 102);
            lblDiaFolga.Name = "lblDiaFolga";
            lblDiaFolga.Size = new Size(90, 15);
            lblDiaFolga.TabIndex = 13;
            lblDiaFolga.Text = "Folga principal";
            // 
            // cmbDiaFolga
            // 
            cmbDiaFolga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiaFolga.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            cmbDiaFolga.Location = new Point(165, 122);
            cmbDiaFolga.Name = "cmbDiaFolga";
            cmbDiaFolga.Size = new Size(145, 23);
            cmbDiaFolga.TabIndex = 14;
            // 
            // lblDiaFolga2
            // 
            lblDiaFolga2.AutoSize = true;
            lblDiaFolga2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDiaFolga2.Location = new Point(330, 102);
            lblDiaFolga2.Name = "lblDiaFolga2";
            lblDiaFolga2.Size = new Size(61, 15);
            lblDiaFolga2.TabIndex = 15;
            lblDiaFolga2.Text = "2ª folga";
            // 
            // cmbDiaFolga2
            // 
            cmbDiaFolga2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiaFolga2.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            cmbDiaFolga2.Location = new Point(330, 122);
            cmbDiaFolga2.Name = "cmbDiaFolga2";
            cmbDiaFolga2.Size = new Size(145, 23);
            cmbDiaFolga2.TabIndex = 16;
            // 
            // lblDataBaseEscala
            // 
            lblDataBaseEscala.AutoSize = true;
            lblDataBaseEscala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDataBaseEscala.Location = new Point(495, 102);
            lblDataBaseEscala.Name = "lblDataBaseEscala";
            lblDataBaseEscala.Size = new Size(116, 15);
            lblDataBaseEscala.TabIndex = 17;
            lblDataBaseEscala.Text = "Data-base da escala";
            // 
            // dtpDataBaseEscala
            // 
            dtpDataBaseEscala.Format = DateTimePickerFormat.Short;
            dtpDataBaseEscala.Location = new Point(495, 122);
            dtpDataBaseEscala.Name = "dtpDataBaseEscala";
            dtpDataBaseEscala.Size = new Size(125, 23);
            dtpDataBaseEscala.TabIndex = 18;
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCargaHoraria.Location = new Point(20, 180);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(128, 15);
            lblCargaHoraria.TabIndex = 19;
            lblCargaHoraria.Text = "Carga horária semanal";
            // 
            // nudCargaHoraria
            // 
            nudCargaHoraria.Location = new Point(151, 177);
            nudCargaHoraria.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudCargaHoraria.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCargaHoraria.Name = "nudCargaHoraria";
            nudCargaHoraria.Size = new Size(52, 23);
            nudCargaHoraria.TabIndex = 20;
            nudCargaHoraria.Value = new decimal(new int[] { 44, 0, 0, 0 });
            // 
            // lblHorarioEntrada
            // 
            lblHorarioEntrada.AutoSize = true;
            lblHorarioEntrada.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHorarioEntrada.Location = new Point(271, 180);
            lblHorarioEntrada.Name = "lblHorarioEntrada";
            lblHorarioEntrada.Size = new Size(49, 15);
            lblHorarioEntrada.TabIndex = 21;
            lblHorarioEntrada.Text = "Entrada";
            // 
            // dtpHorarioEntrada
            // 
            dtpHorarioEntrada.Format = DateTimePickerFormat.Time;
            dtpHorarioEntrada.Location = new Point(326, 176);
            dtpHorarioEntrada.Name = "dtpHorarioEntrada";
            dtpHorarioEntrada.ShowUpDown = true;
            dtpHorarioEntrada.Size = new Size(67, 23);
            dtpHorarioEntrada.TabIndex = 22;
            dtpHorarioEntrada.Value = new DateTime(2026, 9, 7, 8, 0, 0, 0);
            // 
            // lblHorarioSaida
            // 
            lblHorarioSaida.AutoSize = true;
            lblHorarioSaida.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHorarioSaida.Location = new Point(460, 180);
            lblHorarioSaida.Name = "lblHorarioSaida";
            lblHorarioSaida.Size = new Size(36, 15);
            lblHorarioSaida.TabIndex = 23;
            lblHorarioSaida.Text = "Saída";
            // 
            // dtpHorarioSaida
            // 
            dtpHorarioSaida.Format = DateTimePickerFormat.Time;
            dtpHorarioSaida.Location = new Point(502, 176);
            dtpHorarioSaida.Name = "dtpHorarioSaida";
            dtpHorarioSaida.ShowUpDown = true;
            dtpHorarioSaida.Size = new Size(85, 23);
            dtpHorarioSaida.TabIndex = 24;
            dtpHorarioSaida.Value = new DateTime(2026, 9, 7, 17, 0, 0, 0);
            // 
            // lblInicioIntervalo
            // 
            lblInicioIntervalo.AutoSize = true;
            lblInicioIntervalo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInicioIntervalo.Location = new Point(614, 180);
            lblInicioIntervalo.Name = "lblInicioIntervalo";
            lblInicioIntervalo.Size = new Size(58, 15);
            lblInicioIntervalo.TabIndex = 25;
            lblInicioIntervalo.Text = "Intervalo";
            // 
            // dtpInicioIntervalo
            // 
            dtpInicioIntervalo.Format = DateTimePickerFormat.Time;
            dtpInicioIntervalo.Location = new Point(690, 176);
            dtpInicioIntervalo.Name = "dtpInicioIntervalo";
            dtpInicioIntervalo.ShowUpDown = true;
            dtpInicioIntervalo.Size = new Size(65, 23);
            dtpInicioIntervalo.TabIndex = 26;
            dtpInicioIntervalo.Value = new DateTime(2026, 9, 7, 12, 0, 0, 0);
            // 
            // lblFimIntervalo
            // 
            lblFimIntervalo.AutoSize = true;
            lblFimIntervalo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFimIntervalo.Location = new Point(777, 180);
            lblFimIntervalo.Name = "lblFimIntervalo";
            lblFimIntervalo.Size = new Size(27, 15);
            lblFimIntervalo.TabIndex = 27;
            lblFimIntervalo.Text = "Até";
            // 
            // dtpFimIntervalo
            // 
            dtpFimIntervalo.Format = DateTimePickerFormat.Time;
            dtpFimIntervalo.Location = new Point(810, 176);
            dtpFimIntervalo.Name = "dtpFimIntervalo";
            dtpFimIntervalo.ShowUpDown = true;
            dtpFimIntervalo.Size = new Size(85, 23);
            dtpFimIntervalo.TabIndex = 28;
            dtpFimIntervalo.Value = new DateTime(2026, 9, 7, 13, 0, 0, 0);
            // 
            // pnlBeneficios
            // 
            pnlBeneficios.BackColor = Color.White;
            pnlBeneficios.BorderStyle = BorderStyle.FixedSingle;
            pnlBeneficios.Controls.Add(lblBeneficios);
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
            pnlBeneficios.Location = new Point(25, 485);
            pnlBeneficios.Name = "pnlBeneficios";
            pnlBeneficios.Size = new Size(950, 265);
            pnlBeneficios.TabIndex = 3;
            // 
            // lblBeneficios
            // 
            lblBeneficios.AutoSize = true;
            lblBeneficios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBeneficios.ForeColor = Color.FromArgb(21, 101, 192);
            lblBeneficios.Location = new Point(20, 12);
            lblBeneficios.Name = "lblBeneficios";
            lblBeneficios.Size = new Size(160, 19);
            lblBeneficios.TabIndex = 0;
            lblBeneficios.Text = "Benefícios e descontos";
            // 
            // lblNomeBeneficio
            // 
            lblNomeBeneficio.AutoSize = true;
            lblNomeBeneficio.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNomeBeneficio.Location = new Point(20, 43);
            lblNomeBeneficio.Name = "lblNomeBeneficio";
            lblNomeBeneficio.Size = new Size(113, 15);
            lblNomeBeneficio.TabIndex = 1;
            lblNomeBeneficio.Text = "Nome do benefício";
            // 
            // txtNomeBeneficio
            // 
            txtNomeBeneficio.Location = new Point(20, 63);
            txtNomeBeneficio.Name = "txtNomeBeneficio";
            txtNomeBeneficio.Size = new Size(300, 23);
            txtNomeBeneficio.TabIndex = 2;
            // 
            // lblTipoDesconto
            // 
            lblTipoDesconto.AutoSize = true;
            lblTipoDesconto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipoDesconto.Location = new Point(340, 43);
            lblTipoDesconto.Name = "lblTipoDesconto";
            lblTipoDesconto.Size = new Size(102, 15);
            lblTipoDesconto.TabIndex = 3;
            lblTipoDesconto.Text = "Tipo de desconto";
            // 
            // rbPercentual
            // 
            rbPercentual.AutoSize = true;
            rbPercentual.Checked = true;
            rbPercentual.Font = new Font("Segoe UI", 8.5F);
            rbPercentual.Location = new Point(340, 64);
            rbPercentual.Name = "rbPercentual";
            rbPercentual.Size = new Size(117, 19);
            rbPercentual.TabIndex = 4;
            rbPercentual.TabStop = true;
            rbPercentual.Text = "Porcentagem (%)";
            // 
            // rbValorFixo
            // 
            rbValorFixo.AutoSize = true;
            rbValorFixo.Font = new Font("Segoe UI", 8.5F);
            rbValorFixo.Location = new Point(340, 88);
            rbValorFixo.Name = "rbValorFixo";
            rbValorFixo.Size = new Size(98, 19);
            rbValorFixo.TabIndex = 5;
            rbValorFixo.Text = "Valor fixo (R$)";
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblValorDesconto.Location = new Point(540, 43);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(35, 15);
            lblValorDesconto.TabIndex = 6;
            lblValorDesconto.Text = "Valor";
            // 
            // nudPercentual
            // 
            nudPercentual.DecimalPlaces = 2;
            nudPercentual.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPercentual.Location = new Point(540, 63);
            nudPercentual.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPercentual.Name = "nudPercentual";
            nudPercentual.Size = new Size(110, 23);
            nudPercentual.TabIndex = 7;
            nudPercentual.ThousandsSeparator = true;
            // 
            // btnAdicionarBeneficio
            // 
            btnAdicionarBeneficio.BackColor = Color.FromArgb(21, 101, 192);
            btnAdicionarBeneficio.Cursor = Cursors.Hand;
            btnAdicionarBeneficio.FlatAppearance.BorderSize = 0;
            btnAdicionarBeneficio.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 71, 161);
            btnAdicionarBeneficio.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnAdicionarBeneficio.FlatStyle = FlatStyle.Flat;
            btnAdicionarBeneficio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionarBeneficio.ForeColor = Color.White;
            btnAdicionarBeneficio.Location = new Point(680, 60);
            btnAdicionarBeneficio.Name = "btnAdicionarBeneficio";
            btnAdicionarBeneficio.Size = new Size(125, 35);
            btnAdicionarBeneficio.TabIndex = 8;
            btnAdicionarBeneficio.Text = "+ Adicionar";
            btnAdicionarBeneficio.UseVisualStyleBackColor = false;
            btnAdicionarBeneficio.Click += BtnAdicionarBeneficio_Click;
            // 
            // dgvBeneficios
            // 
            dgvBeneficios.AllowUserToAddRows = false;
            dgvBeneficios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 253);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 251, 253);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(35, 45, 55);
            dgvBeneficios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBeneficios.BackgroundColor = Color.White;
            dgvBeneficios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBeneficios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 247, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 55, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 247, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(45, 55, 65);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBeneficios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBeneficios.ColumnHeadersHeight = 34;
            dgvBeneficios.Columns.AddRange(new DataGridViewColumn[] { colBeneficio, colTipo, colDesconto, colValorDesconto, colRemoverBeneficio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(35, 45, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(35, 45, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBeneficios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBeneficios.EnableHeadersVisualStyles = false;
            dgvBeneficios.GridColor = Color.FromArgb(225, 230, 235);
            dgvBeneficios.Location = new Point(20, 125);
            dgvBeneficios.MultiSelect = false;
            dgvBeneficios.Name = "dgvBeneficios";
            dgvBeneficios.ReadOnly = true;
            dgvBeneficios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(35, 45, 55);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(35, 45, 55);
            dgvBeneficios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBeneficios.RowTemplate.Height = 32;
            dgvBeneficios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeneficios.Size = new Size(652, 120);
            dgvBeneficios.TabIndex = 9;
            dgvBeneficios.CellContentClick += DgvBeneficios_CellContentClick;
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
            colTipo.Width = 125;
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
            colRemoverBeneficio.Width = 95;
            // 
            // lblTotalDescontos
            // 
            lblTotalDescontos.AutoSize = true;
            lblTotalDescontos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalDescontos.ForeColor = Color.FromArgb(80, 90, 100);
            lblTotalDescontos.Location = new Point(709, 141);
            lblTotalDescontos.Name = "lblTotalDescontos";
            lblTotalDescontos.Size = new Size(113, 15);
            lblTotalDescontos.TabIndex = 10;
            lblTotalDescontos.Text = "Descontos: R$ 0,00";
            // 
            // lblSalarioEstimado
            // 
            lblSalarioEstimado.AutoSize = true;
            lblSalarioEstimado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalarioEstimado.ForeColor = Color.FromArgb(21, 101, 192);
            lblSalarioEstimado.Location = new Point(709, 178);
            lblSalarioEstimado.Name = "lblSalarioEstimado";
            lblSalarioEstimado.Size = new Size(179, 19);
            lblSalarioEstimado.TabIndex = 11;
            lblSalarioEstimado.Text = "Salário estimado: R$ 0,00";
            // 
            // pnlObservacoes
            // 
            pnlObservacoes.BackColor = Color.White;
            pnlObservacoes.BorderStyle = BorderStyle.FixedSingle;
            pnlObservacoes.Controls.Add(lblObservacoes);
            pnlObservacoes.Controls.Add(txtObservacoes);
            pnlObservacoes.Location = new Point(25, 765);
            pnlObservacoes.Name = "pnlObservacoes";
            pnlObservacoes.Size = new Size(950, 80);
            pnlObservacoes.TabIndex = 4;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblObservacoes.Location = new Point(20, 10);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(78, 15);
            lblObservacoes.TabIndex = 0;
            lblObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(20, 32);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.ScrollBars = ScrollBars.Vertical;
            txtObservacoes.Size = new Size(900, 35);
            txtObservacoes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(210, 215, 220);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(80, 90, 100);
            btnCancelar.Location = new Point(705, 870);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(21, 101, 192);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 71, 161);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(835, 870);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 42);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar funcionário";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1000, 930);
            Controls.Add(pnlCabecalho);
            Controls.Add(pnlDadosPessoais);
            Controls.Add(pnlDadosProfissionais);
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