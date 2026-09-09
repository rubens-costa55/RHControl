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
            System.Windows.Forms.DataGridViewCellStyle dgvHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlt = new System.Windows.Forms.DataGridViewCellStyle();

            this.components = new System.ComponentModel.Container();

            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.pnlDadosPessoais = new System.Windows.Forms.Panel();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.pnlDadosProfissionais = new System.Windows.Forms.Panel();
            this.lblDadosProfissionais = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblTipoJornada = new System.Windows.Forms.Label();
            this.cmbTipoJornada = new System.Windows.Forms.ComboBox();
            this.lblEscala = new System.Windows.Forms.Label();
            this.cmbEscala = new System.Windows.Forms.ComboBox();
            this.lblDiaFolga = new System.Windows.Forms.Label();
            this.cmbDiaFolga = new System.Windows.Forms.ComboBox();
            this.lblDiaFolga2 = new System.Windows.Forms.Label();
            this.cmbDiaFolga2 = new System.Windows.Forms.ComboBox();
            this.lblDataBaseEscala = new System.Windows.Forms.Label();
            this.dtpDataBaseEscala = new System.Windows.Forms.DateTimePicker();

            this.pnlJornada = new System.Windows.Forms.Panel();
            this.lblJornadaTitulo = new System.Windows.Forms.Label();
            this.lblJornadaSubtitulo = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.nudCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.lblHorarioEntrada = new System.Windows.Forms.Label();
            this.dtpHorarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioSaida = new System.Windows.Forms.Label();
            this.dtpHorarioSaida = new System.Windows.Forms.DateTimePicker();
            this.lblInicioIntervalo = new System.Windows.Forms.Label();
            this.dtpInicioIntervalo = new System.Windows.Forms.DateTimePicker();
            this.lblFimIntervalo = new System.Windows.Forms.Label();
            this.dtpFimIntervalo = new System.Windows.Forms.DateTimePicker();

            this.pnlBeneficios = new System.Windows.Forms.Panel();
            this.lblBeneficios = new System.Windows.Forms.Label();
            this.lblBeneficiosSubtitulo = new System.Windows.Forms.Label();
            this.lblNomeBeneficio = new System.Windows.Forms.Label();
            this.txtNomeBeneficio = new System.Windows.Forms.TextBox();
            this.lblTipoDesconto = new System.Windows.Forms.Label();
            this.rbPercentual = new System.Windows.Forms.RadioButton();
            this.rbValorFixo = new System.Windows.Forms.RadioButton();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.nudPercentual = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarBeneficio = new System.Windows.Forms.Button();
            this.dgvBeneficios = new System.Windows.Forms.DataGridView();
            this.colBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoverBeneficio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotalDescontos = new System.Windows.Forms.Label();
            this.lblSalarioEstimado = new System.Windows.Forms.Label();

            this.pnlObservacoes = new System.Windows.Forms.Panel();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblObservacoesSubtitulo = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();

            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDadosPessoais.SuspendLayout();
            this.pnlDadosProfissionais.SuspendLayout();
            this.pnlJornada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargaHoraria)).BeginInit();
            this.pnlBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficios)).BeginInit();
            this.pnlObservacoes.SuspendLayout();

            // =========================
            // FORM
            // =========================

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            this.ClientSize = new System.Drawing.Size(1100, 940);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH Control — Novo Funcionário";

            // =========================
            // CABEÇALHO
            // =========================

            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(10, 60, 105);
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Size = new System.Drawing.Size(1100, 105);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 25F,
                System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(38, 22);
            this.lblTitulo.Text = "Novo Funcionário";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(205, 225, 245);
            this.lblSubtitulo.Location = new System.Drawing.Point(42, 67);
            this.lblSubtitulo.Text =
                "Cadastre as informações pessoais e profissionais do colaborador";

            // =========================
            // DADOS PESSOAIS
            // =========================

            this.pnlDadosPessoais.BackColor = System.Drawing.Color.White;
            this.pnlDadosPessoais.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosPessoais.Location = new System.Drawing.Point(25, 125);
            this.pnlDadosPessoais.Size = new System.Drawing.Size(1050, 135);

            this.pnlDadosPessoais.Controls.Add(this.lblDadosPessoais);
            this.pnlDadosPessoais.Controls.Add(this.lblNome);
            this.pnlDadosPessoais.Controls.Add(this.txtNome);
            this.pnlDadosPessoais.Controls.Add(this.lblCPF);
            this.pnlDadosPessoais.Controls.Add(this.txtCPF);
            this.pnlDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.pnlDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.pnlDadosPessoais.Controls.Add(this.lblTelefone);
            this.pnlDadosPessoais.Controls.Add(this.txtTelefone);
            this.pnlDadosPessoais.Controls.Add(this.lblEmail);
            this.pnlDadosPessoais.Controls.Add(this.txtEmail);

            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lblDadosPessoais.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblDadosPessoais.Location =
                new System.Drawing.Point(20, 12);
            this.lblDadosPessoais.Text = "Dados pessoais";

            this.lblNome.AutoSize = true;
            this.lblNome.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(20, 43);
            this.lblNome.Text = "Nome completo *";

            this.txtNome.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(20, 64);
            this.txtNome.Size = new System.Drawing.Size(390, 25);
            this.txtNome.Name = "txtNome";

            this.lblCPF.AutoSize = true;
            this.lblCPF.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblCPF.Location = new System.Drawing.Point(430, 43);
            this.lblCPF.Text = "CPF";

            this.txtCPF.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtCPF.Location = new System.Drawing.Point(430, 64);
            this.txtCPF.Size = new System.Drawing.Size(180, 25);
            this.txtCPF.Name = "txtCPF";

            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblDataNascimento.Location =
                new System.Drawing.Point(630, 43);
            this.lblDataNascimento.Text = "Data de nascimento";

            this.dtpDataNascimento.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location =
                new System.Drawing.Point(630, 64);
            this.dtpDataNascimento.Size =
                new System.Drawing.Size(145, 25);
            this.dtpDataNascimento.Name = "dtpDataNascimento";

            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblTelefone.Location =
                new System.Drawing.Point(795, 43);
            this.lblTelefone.Text = "Telefone";

            this.txtTelefone.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefone.Location =
                new System.Drawing.Point(795, 64);
            this.txtTelefone.Size =
                new System.Drawing.Size(225, 25);
            this.txtTelefone.Name = "txtTelefone";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblEmail.Location =
                new System.Drawing.Point(20, 101);
            this.lblEmail.Text = "E-mail";

            this.txtEmail.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location =
                new System.Drawing.Point(70, 98);
            this.txtEmail.Size =
                new System.Drawing.Size(540, 25);
            this.txtEmail.Name = "txtEmail";

            // =========================
            // DADOS PROFISSIONAIS
            // =========================

            this.pnlDadosProfissionais.BackColor =
                System.Drawing.Color.White;
            this.pnlDadosProfissionais.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosProfissionais.Location =
                new System.Drawing.Point(25, 275);
            this.pnlDadosProfissionais.Size =
                new System.Drawing.Size(1050, 175);

            this.pnlDadosProfissionais.Controls.Add(this.lblDadosProfissionais);
            this.pnlDadosProfissionais.Controls.Add(this.lblCargo);
            this.pnlDadosProfissionais.Controls.Add(this.txtCargo);
            this.pnlDadosProfissionais.Controls.Add(this.lblSetor);
            this.pnlDadosProfissionais.Controls.Add(this.txtSetor);
            this.pnlDadosProfissionais.Controls.Add(this.lblDataAdmissao);
            this.pnlDadosProfissionais.Controls.Add(this.dtpDataAdmissao);
            this.pnlDadosProfissionais.Controls.Add(this.lblSalario);
            this.pnlDadosProfissionais.Controls.Add(this.txtSalario);
            this.pnlDadosProfissionais.Controls.Add(this.lblTipoJornada);
            this.pnlDadosProfissionais.Controls.Add(this.cmbTipoJornada);
            this.pnlDadosProfissionais.Controls.Add(this.lblEscala);
            this.pnlDadosProfissionais.Controls.Add(this.cmbEscala);
            this.pnlDadosProfissionais.Controls.Add(this.lblDiaFolga);
            this.pnlDadosProfissionais.Controls.Add(this.cmbDiaFolga);
            this.pnlDadosProfissionais.Controls.Add(this.lblDiaFolga2);
            this.pnlDadosProfissionais.Controls.Add(this.cmbDiaFolga2);
            this.pnlDadosProfissionais.Controls.Add(this.lblDataBaseEscala);
            this.pnlDadosProfissionais.Controls.Add(this.dtpDataBaseEscala);

            this.lblDadosProfissionais.AutoSize = true;
            this.lblDadosProfissionais.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lblDadosProfissionais.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblDadosProfissionais.Location =
                new System.Drawing.Point(20, 12);
            this.lblDadosProfissionais.Text =
                "Dados profissionais";

            this.lblCargo.AutoSize = true;
            this.lblCargo.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblCargo.Location =
                new System.Drawing.Point(20, 43);
            this.lblCargo.Text = "Cargo *";

            this.txtCargo.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtCargo.Location =
                new System.Drawing.Point(20, 64);
            this.txtCargo.Size =
                new System.Drawing.Size(250, 25);
            this.txtCargo.Name = "txtCargo";

            this.lblSetor.AutoSize = true;
            this.lblSetor.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblSetor.Location =
                new System.Drawing.Point(290, 43);
            this.lblSetor.Text = "Setor";

            this.txtSetor.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtSetor.Location =
                new System.Drawing.Point(290, 64);
            this.txtSetor.Size =
                new System.Drawing.Size(180, 25);
            this.txtSetor.Name = "txtSetor";

            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblDataAdmissao.Location =
                new System.Drawing.Point(490, 43);
            this.lblDataAdmissao.Text =
                "Data de admissão *";

            this.dtpDataAdmissao.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location =
                new System.Drawing.Point(490, 64);
            this.dtpDataAdmissao.Size =
                new System.Drawing.Size(145, 25);
            this.dtpDataAdmissao.Name =
                "dtpDataAdmissao";

            this.lblSalario.AutoSize = true;
            this.lblSalario.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblSalario.Location =
                new System.Drawing.Point(655, 43);
            this.lblSalario.Text = "Salário *";

            this.txtSalario.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalario.Location =
                new System.Drawing.Point(655, 64);
            this.txtSalario.Size =
                new System.Drawing.Size(145, 25);
            this.txtSalario.Name =
                "txtSalario";

            this.lblTipoJornada.AutoSize = true;
            this.lblTipoJornada.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblTipoJornada.Location =
                new System.Drawing.Point(820, 43);
            this.lblTipoJornada.Text =
                "Tipo de jornada";

            this.cmbTipoJornada.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoJornada.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoJornada.Items.AddRange(
                new object[] { "Jornada fixa", "Por escala" });
            this.cmbTipoJornada.Location =
                new System.Drawing.Point(820, 64);
            this.cmbTipoJornada.Size =
                new System.Drawing.Size(200, 25);
            this.cmbTipoJornada.Name =
                "cmbTipoJornada";

            this.lblEscala.AutoSize = true;
            this.lblEscala.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblEscala.Location =
                new System.Drawing.Point(20, 105);
            this.lblEscala.Text = "Escala *";

            this.cmbEscala.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscala.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEscala.Items.AddRange(
                new object[] { "5x2", "6x1", "12x36", "4x2", "5x1", "Outra" });
            this.cmbEscala.Location =
                new System.Drawing.Point(20, 126);
            this.cmbEscala.Size =
                new System.Drawing.Size(130, 25);
            this.cmbEscala.Name =
                "cmbEscala";

            this.lblDiaFolga.AutoSize = true;
            this.lblDiaFolga.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblDiaFolga.Location =
                new System.Drawing.Point(175, 105);
            this.lblDiaFolga.Text =
                "Folga principal";

            this.cmbDiaFolga.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaFolga.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDiaFolga.Items.AddRange(
                new object[]
                {
                    "Domingo",
                    "Segunda-feira",
                    "Terça-feira",
                    "Quarta-feira",
                    "Quinta-feira",
                    "Sexta-feira",
                    "Sábado"
                });
            this.cmbDiaFolga.Location =
                new System.Drawing.Point(175, 126);
            this.cmbDiaFolga.Size =
                new System.Drawing.Size(150, 25);
            this.cmbDiaFolga.Name =
                "cmbDiaFolga";

            this.lblDiaFolga2.AutoSize = true;
            this.lblDiaFolga2.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblDiaFolga2.Location =
                new System.Drawing.Point(350, 105);
            this.lblDiaFolga2.Text =
                "2ª folga";

            this.cmbDiaFolga2.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaFolga2.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDiaFolga2.Items.AddRange(
                new object[]
                {
                    "Domingo",
                    "Segunda-feira",
                    "Terça-feira",
                    "Quarta-feira",
                    "Quinta-feira",
                    "Sexta-feira",
                    "Sábado"
                });
            this.cmbDiaFolga2.Location =
                new System.Drawing.Point(350, 126);
            this.cmbDiaFolga2.Size =
                new System.Drawing.Size(150, 25);
            this.cmbDiaFolga2.Name =
                "cmbDiaFolga2";

            this.lblDataBaseEscala.AutoSize = true;
            this.lblDataBaseEscala.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblDataBaseEscala.Location =
                new System.Drawing.Point(525, 105);
            this.lblDataBaseEscala.Text =
                "Data-base da escala";

            this.dtpDataBaseEscala.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataBaseEscala.Location =
                new System.Drawing.Point(525, 126);
            this.dtpDataBaseEscala.Size =
                new System.Drawing.Size(145, 25);
            this.dtpDataBaseEscala.Name =
                "dtpDataBaseEscala";

            // =========================
            // JORNADA
            // =========================

            this.pnlJornada.BackColor =
                System.Drawing.Color.FromArgb(237, 246, 255);
            this.pnlJornada.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJornada.Location =
                new System.Drawing.Point(25, 465);
            this.pnlJornada.Size =
                new System.Drawing.Size(1050, 105);

            this.pnlJornada.Controls.Add(this.lblJornadaTitulo);
            this.pnlJornada.Controls.Add(this.lblJornadaSubtitulo);
            this.pnlJornada.Controls.Add(this.lblCargaHoraria);
            this.pnlJornada.Controls.Add(this.nudCargaHoraria);
            this.pnlJornada.Controls.Add(this.lblHorarioEntrada);
            this.pnlJornada.Controls.Add(this.dtpHorarioEntrada);
            this.pnlJornada.Controls.Add(this.lblHorarioSaida);
            this.pnlJornada.Controls.Add(this.dtpHorarioSaida);
            this.pnlJornada.Controls.Add(this.lblInicioIntervalo);
            this.pnlJornada.Controls.Add(this.dtpInicioIntervalo);
            this.pnlJornada.Controls.Add(this.lblFimIntervalo);
            this.pnlJornada.Controls.Add(this.dtpFimIntervalo);

            this.lblJornadaTitulo.AutoSize = true;
            this.lblJornadaTitulo.Font =
                new System.Drawing.Font("Segoe UI", 10.5F,
                System.Drawing.FontStyle.Bold);
            this.lblJornadaTitulo.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblJornadaTitulo.Location =
                new System.Drawing.Point(20, 10);
            this.lblJornadaTitulo.Text =
                "Jornada de trabalho";

            this.lblJornadaSubtitulo.AutoSize = true;
            this.lblJornadaSubtitulo.Font =
                new System.Drawing.Font("Segoe UI", 8F);
            this.lblJornadaSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(90, 120, 150);
            this.lblJornadaSubtitulo.Location =
                new System.Drawing.Point(180, 13);
            this.lblJornadaSubtitulo.Text =
                "Configure os horários e a carga horária semanal";

            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblCargaHoraria.Location =
                new System.Drawing.Point(20, 53);
            this.lblCargaHoraria.Text =
                "Carga horária semanal";

            this.nudCargaHoraria.Location =
                new System.Drawing.Point(145, 50);
            this.nudCargaHoraria.Maximum =
                new decimal(new int[] { 60, 0, 0, 0 });
            this.nudCargaHoraria.Minimum =
                new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCargaHoraria.Value =
                new decimal(new int[] { 44, 0, 0, 0 });
            this.nudCargaHoraria.Size =
                new System.Drawing.Size(60, 25);
            this.nudCargaHoraria.Name =
                "nudCargaHoraria";

            this.lblHorarioEntrada.AutoSize = true;
            this.lblHorarioEntrada.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblHorarioEntrada.Location =
                new System.Drawing.Point(240, 53);
            this.lblHorarioEntrada.Text =
                "Entrada";

            this.dtpHorarioEntrada.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioEntrada.ShowUpDown = true;
            this.dtpHorarioEntrada.Location =
                new System.Drawing.Point(295, 49);
            this.dtpHorarioEntrada.Size =
                new System.Drawing.Size(80, 25);
            this.dtpHorarioEntrada.Name =
                "dtpHorarioEntrada";
            this.dtpHorarioEntrada.Value =
                new System.DateTime(2026, 9, 8, 8, 0, 0);

            this.lblHorarioSaida.AutoSize = true;
            this.lblHorarioSaida.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblHorarioSaida.Location =
                new System.Drawing.Point(410, 53);
            this.lblHorarioSaida.Text =
                "Saída";

            this.dtpHorarioSaida.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioSaida.ShowUpDown = true;
            this.dtpHorarioSaida.Location =
                new System.Drawing.Point(450, 49);
            this.dtpHorarioSaida.Size =
                new System.Drawing.Size(85, 25);
            this.dtpHorarioSaida.Name =
                "dtpHorarioSaida";
            this.dtpHorarioSaida.Value =
                new System.DateTime(2026, 9, 8, 17, 0, 0);

            this.lblInicioIntervalo.AutoSize = true;
            this.lblInicioIntervalo.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblInicioIntervalo.Location =
                new System.Drawing.Point(570, 53);
            this.lblInicioIntervalo.Text =
                "Início intervalo";

            this.dtpInicioIntervalo.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicioIntervalo.ShowUpDown = true;
            this.dtpInicioIntervalo.Location =
                new System.Drawing.Point(665, 49);
            this.dtpInicioIntervalo.Size =
                new System.Drawing.Size(85, 25);
            this.dtpInicioIntervalo.Name =
                "dtpInicioIntervalo";
            this.dtpInicioIntervalo.Value =
                new System.DateTime(2026, 9, 8, 12, 0, 0);

            this.lblFimIntervalo.AutoSize = true;
            this.lblFimIntervalo.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblFimIntervalo.Location =
                new System.Drawing.Point(785, 53);
            this.lblFimIntervalo.Text =
                "Fim intervalo";

            this.dtpFimIntervalo.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFimIntervalo.ShowUpDown = true;
            this.dtpFimIntervalo.Location =
                new System.Drawing.Point(875, 49);
            this.dtpFimIntervalo.Size =
                new System.Drawing.Size(90, 25);
            this.dtpFimIntervalo.Name =
                "dtpFimIntervalo";
            this.dtpFimIntervalo.Value =
                new System.DateTime(2026, 9, 8, 13, 0, 0);

            // =========================
            // BENEFÍCIOS
            // =========================

            this.pnlBeneficios.BackColor =
                System.Drawing.Color.White;
            this.pnlBeneficios.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBeneficios.Location =
                new System.Drawing.Point(25, 585);
            this.pnlBeneficios.Size =
                new System.Drawing.Size(1050, 225);

            this.pnlBeneficios.Controls.Add(this.lblBeneficios);
            this.pnlBeneficios.Controls.Add(this.lblBeneficiosSubtitulo);
            this.pnlBeneficios.Controls.Add(this.lblNomeBeneficio);
            this.pnlBeneficios.Controls.Add(this.txtNomeBeneficio);
            this.pnlBeneficios.Controls.Add(this.lblTipoDesconto);
            this.pnlBeneficios.Controls.Add(this.rbPercentual);
            this.pnlBeneficios.Controls.Add(this.rbValorFixo);
            this.pnlBeneficios.Controls.Add(this.lblValorDesconto);
            this.pnlBeneficios.Controls.Add(this.nudPercentual);
            this.pnlBeneficios.Controls.Add(this.btnAdicionarBeneficio);
            this.pnlBeneficios.Controls.Add(this.dgvBeneficios);
            this.pnlBeneficios.Controls.Add(this.lblTotalDescontos);
            this.pnlBeneficios.Controls.Add(this.lblSalarioEstimado);

            this.lblBeneficios.AutoSize = true;
            this.lblBeneficios.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lblBeneficios.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblBeneficios.Location =
                new System.Drawing.Point(20, 10);
            this.lblBeneficios.Text =
                "Benefícios e descontos";

            this.lblBeneficiosSubtitulo.AutoSize = true;
            this.lblBeneficiosSubtitulo.Font =
                new System.Drawing.Font("Segoe UI", 8F);
            this.lblBeneficiosSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(105, 125, 145);
            this.lblBeneficiosSubtitulo.Location =
                new System.Drawing.Point(190, 13);
            this.lblBeneficiosSubtitulo.Text =
                "Adicione benefícios e configure os descontos";

            this.lblNomeBeneficio.AutoSize = true;
            this.lblNomeBeneficio.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblNomeBeneficio.Location =
                new System.Drawing.Point(20, 43);
            this.lblNomeBeneficio.Text =
                "Nome do benefício";

            this.txtNomeBeneficio.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNomeBeneficio.Location =
                new System.Drawing.Point(20, 64);
            this.txtNomeBeneficio.Size =
                new System.Drawing.Size(300, 24);
            this.txtNomeBeneficio.Name =
                "txtNomeBeneficio";

            this.lblTipoDesconto.AutoSize = true;
            this.lblTipoDesconto.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblTipoDesconto.Location =
                new System.Drawing.Point(345, 43);
            this.lblTipoDesconto.Text =
                "Tipo de desconto";

            this.rbPercentual.AutoSize = true;
            this.rbPercentual.Checked = true;
            this.rbPercentual.Font =
                new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbPercentual.Location =
                new System.Drawing.Point(345, 64);
            this.rbPercentual.Name =
                "rbPercentual";
            this.rbPercentual.Text =
                "Percentual (%)";

            this.rbValorFixo.AutoSize = true;
            this.rbValorFixo.Font =
                new System.Drawing.Font("Segoe UI", 8.5F);
            this.rbValorFixo.Location =
                new System.Drawing.Point(345, 88);
            this.rbValorFixo.Name =
                "rbValorFixo";
            this.rbValorFixo.Text =
                "Valor fixo (R$)";

            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            this.lblValorDesconto.Location =
                new System.Drawing.Point(530, 43);
            this.lblValorDesconto.Text =
                "Valor";

            this.nudPercentual.DecimalPlaces = 2;
            this.nudPercentual.Increment =
                new decimal(new int[] { 5, 0, 0, 65536 });
            this.nudPercentual.Maximum =
                new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudPercentual.Location =
                new System.Drawing.Point(530, 64);
            this.nudPercentual.Size =
                new System.Drawing.Size(105, 25);
            this.nudPercentual.Name =
                "nudPercentual";

            this.btnAdicionarBeneficio.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnAdicionarBeneficio.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarBeneficio.FlatAppearance.BorderSize = 0;
            this.btnAdicionarBeneficio.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnAdicionarBeneficio.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBeneficio.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btnAdicionarBeneficio.ForeColor =
                System.Drawing.Color.White;
            this.btnAdicionarBeneficio.Location =
                new System.Drawing.Point(660, 61);
            this.btnAdicionarBeneficio.Size =
                new System.Drawing.Size(140, 38);
            this.btnAdicionarBeneficio.Name =
                "btnAdicionarBeneficio";
            this.btnAdicionarBeneficio.Text =
                "+ Adicionar";

            // TABELA BENEFÍCIOS

            dgvHeader.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeader.BackColor =
                System.Drawing.Color.FromArgb(235, 242, 249);
            dgvHeader.Font =
                new System.Drawing.Font("Segoe UI", 8.5F,
                System.Drawing.FontStyle.Bold);
            dgvHeader.ForeColor =
                System.Drawing.Color.FromArgb(30, 55, 80);
            dgvHeader.SelectionBackColor =
                System.Drawing.Color.FromArgb(235, 242, 249);
            dgvHeader.SelectionForeColor =
                System.Drawing.Color.FromArgb(30, 55, 80);

            dgvCell.BackColor = System.Drawing.Color.White;
            dgvCell.Font =
                new System.Drawing.Font("Segoe UI", 8.5F);
            dgvCell.ForeColor =
                System.Drawing.Color.FromArgb(45, 60, 75);
            dgvCell.SelectionBackColor =
                System.Drawing.Color.FromArgb(225, 239, 255);
            dgvCell.SelectionForeColor =
                System.Drawing.Color.FromArgb(25, 55, 85);

            dgvAlt.BackColor =
                System.Drawing.Color.FromArgb(249, 251, 253);

            this.dgvBeneficios.AllowUserToAddRows = false;
            this.dgvBeneficios.AllowUserToDeleteRows = false;
            this.dgvBeneficios.AllowUserToResizeRows = false;
            this.dgvBeneficios.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvBeneficios.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgvBeneficios.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBeneficios.ColumnHeadersDefaultCellStyle =
                dgvHeader;
            this.dgvBeneficios.ColumnHeadersHeight = 35;
            this.dgvBeneficios.DefaultCellStyle =
                dgvCell;
            this.dgvBeneficios.AlternatingRowsDefaultCellStyle =
                dgvAlt;
            this.dgvBeneficios.EnableHeadersVisualStyles = false;
            this.dgvBeneficios.GridColor =
                System.Drawing.Color.FromArgb(225, 232, 240);
            this.dgvBeneficios.Location =
                new System.Drawing.Point(20, 120);
            this.dgvBeneficios.MultiSelect = false;
            this.dgvBeneficios.Name =
                "dgvBeneficios";
            this.dgvBeneficios.ReadOnly = true;
            this.dgvBeneficios.RowHeadersVisible = false;
            this.dgvBeneficios.RowTemplate.Height = 30;
            this.dgvBeneficios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficios.Size =
                new System.Drawing.Size(650, 88);

            this.colBeneficio.HeaderText =
                "Benefício";
            this.colBeneficio.Name =
                "colBeneficio";
            this.colBeneficio.ReadOnly = true;
            this.colBeneficio.Width = 190;

            this.colTipo.HeaderText =
                "Tipo";
            this.colTipo.Name =
                "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 120;

            this.colDesconto.HeaderText =
                "Desconto";
            this.colDesconto.Name =
                "colDesconto";
            this.colDesconto.ReadOnly = true;
            this.colDesconto.Width = 110;

            this.colValorDesconto.HeaderText =
                "Valor";
            this.colValorDesconto.Name =
                "colValorDesconto";
            this.colValorDesconto.ReadOnly = true;
            this.colValorDesconto.Width = 120;

            this.colRemoverBeneficio.HeaderText =
                "Ação";
            this.colRemoverBeneficio.Name =
                "colRemoverBeneficio";
            this.colRemoverBeneficio.ReadOnly = true;
            this.colRemoverBeneficio.Text =
                "Remover";
            this.colRemoverBeneficio.UseColumnTextForButtonValue = true;
            this.colRemoverBeneficio.Width = 90;

            this.dgvBeneficios.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colBeneficio,
                    this.colTipo,
                    this.colDesconto,
                    this.colValorDesconto,
                    this.colRemoverBeneficio
                });

            this.lblTotalDescontos.AutoSize = true;
            this.lblTotalDescontos.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.lblTotalDescontos.ForeColor =
                System.Drawing.Color.FromArgb(90, 105, 120);
            this.lblTotalDescontos.Location =
                new System.Drawing.Point(705, 135);
            this.lblTotalDescontos.Name =
                "lblTotalDescontos";
            this.lblTotalDescontos.Text =
                "Descontos: R$ 0,00";

            this.lblSalarioEstimado.AutoSize = true;
            this.lblSalarioEstimado.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.lblSalarioEstimado.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblSalarioEstimado.Location =
                new System.Drawing.Point(705, 172);
            this.lblSalarioEstimado.Name =
                "lblSalarioEstimado";
            this.lblSalarioEstimado.Text =
                "Salário estimado: R$ 0,00";

            // =========================
            // OBSERVAÇÕES
            // =========================

            this.pnlObservacoes.BackColor =
                System.Drawing.Color.White;
            this.pnlObservacoes.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlObservacoes.Location =
                new System.Drawing.Point(25, 825);
            this.pnlObservacoes.Size =
                new System.Drawing.Size(1050, 65);

            this.pnlObservacoes.Controls.Add(this.lblObservacoes);
            this.pnlObservacoes.Controls.Add(this.lblObservacoesSubtitulo);
            this.pnlObservacoes.Controls.Add(this.txtObservacoes);

            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.lblObservacoes.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblObservacoes.Location =
                new System.Drawing.Point(20, 8);
            this.lblObservacoes.Text =
                "Observações";

            this.lblObservacoesSubtitulo.AutoSize = true;
            this.lblObservacoesSubtitulo.Font =
                new System.Drawing.Font("Segoe UI", 8F);
            this.lblObservacoesSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(105, 125, 145);
            this.lblObservacoesSubtitulo.Location =
                new System.Drawing.Point(110, 11);
            this.lblObservacoesSubtitulo.Text =
                "Informações adicionais sobre o colaborador";

            this.txtObservacoes.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservacoes.Location =
                new System.Drawing.Point(20, 32);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacoes.Size =
                new System.Drawing.Size(1000, 25);
            this.txtObservacoes.Name =
                "txtObservacoes";

            // =========================
            // BOTÕES
            // =========================

            this.btnCancelar.BackColor =
                System.Drawing.Color.White;
            this.btnCancelar.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(205, 215, 225);
            this.btnCancelar.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);
            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor =
                System.Drawing.Color.FromArgb(70, 85, 100);
            this.btnCancelar.Location =
                new System.Drawing.Point(775, 900);
            this.btnCancelar.Size =
                new System.Drawing.Size(125, 40);
            this.btnCancelar.Name =
                "btnCancelar";
            this.btnCancelar.Text =
                "Cancelar";

            this.btnSalvar.BackColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnSalvar.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnSalvar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font =
                new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor =
                System.Drawing.Color.White;
            this.btnSalvar.Location =
                new System.Drawing.Point(915, 900);
            this.btnSalvar.Size =
                new System.Drawing.Size(160, 40);
            this.btnSalvar.Name =
                "btnSalvar";
            this.btnSalvar.Text =
                "Salvar funcionário";

            // =========================
            // CONTROLES DO FORM
            // =========================

            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlDadosPessoais);
            this.Controls.Add(this.pnlDadosProfissionais);
            this.Controls.Add(this.pnlJornada);
            this.Controls.Add(this.pnlBeneficios);
            this.Controls.Add(this.pnlObservacoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);

            ((System.ComponentModel.ISupportInitialize)(this.nudCargaHoraria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficios)).EndInit();

            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();

            this.pnlDadosPessoais.ResumeLayout(false);
            this.pnlDadosPessoais.PerformLayout();

            this.pnlDadosProfissionais.ResumeLayout(false);
            this.pnlDadosProfissionais.PerformLayout();

            this.pnlJornada.ResumeLayout(false);
            this.pnlJornada.PerformLayout();

            this.pnlBeneficios.ResumeLayout(false);
            this.pnlBeneficios.PerformLayout();

            this.pnlObservacoes.ResumeLayout(false);
            this.pnlObservacoes.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}