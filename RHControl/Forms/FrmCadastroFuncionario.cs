using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using RHControl.Data;

namespace RHControl
{
    public partial class FrmCadastroFuncionario : Form
    {
        // ============================================================
        // BENEFÍCIO
        // ============================================================

        private class Beneficio
        {
            public string Nome { get; set; } = "";
            public bool EhPercentual { get; set; }
            public decimal ValorInformado { get; set; }
            public decimal ValorDesconto { get; set; }
        }

        // ============================================================
        // VARIÁVEIS
        // ============================================================

        private readonly List<Beneficio> beneficios = new();

        // Null = novo funcionário
        // Valor = edição de funcionário existente
        private long? funcionarioIdEdicao = null;

        // Mantém o status original durante uma edição
        private string statusAtual = "Ativo";

        // ============================================================
        // CONSTRUTOR - NOVO FUNCIONÁRIO
        // ============================================================

        public FrmCadastroFuncionario()
        {
            InitializeComponent();

            // Título e textos do modo NOVO
            Text = "RH Control — Novo Funcionário";

            lblTitulo.Text = "Novo Funcionário";

            lblSubtitulo.Text =
                "Cadastre as informações pessoais e profissionais do colaborador";

            btnSalvar.Text = "Salvar funcionário";

            cmbTipoJornada.SelectedIndex = 0;
            dtpDataBaseEscala.Value = dtpDataAdmissao.Value;

            ConfigurarEventos();

            rbPercentual.Checked = true;

            AtualizarInterfaceTipoDesconto();
            AtualizarCalculos();
        }

        // ============================================================
        // CONSTRUTOR - EDITAR FUNCIONÁRIO
        // ============================================================

        public FrmCadastroFuncionario(long funcionarioId)
        {
            InitializeComponent();

            // Título e textos do modo EDITAR
            Text = "RH Control — Editar Funcionário";

            lblTitulo.Text = "Editar dados do funcionário";

            lblSubtitulo.Text =
                "Atualize as informações pessoais e profissionais do colaborador";

            btnSalvar.Text = "Salvar alterações";

            cmbTipoJornada.SelectedIndex = 0;
            dtpDataBaseEscala.Value = dtpDataAdmissao.Value;

            ConfigurarEventos();

            rbPercentual.Checked = true;

            AtualizarInterfaceTipoDesconto();
            AtualizarCalculos();

            funcionarioIdEdicao = funcionarioId;

            CarregarFuncionario(funcionarioId);
        }

        // ============================================================
        // EVENTOS
        // ============================================================

        private void ConfigurarEventos()
        {
            // Garante que cada evento fique registrado apenas uma vez

            btnCancelar.Click -= BtnCancelar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            btnSalvar.Click -= BtnSalvar_Click;
            btnSalvar.Click += BtnSalvar_Click;

            btnAdicionarBeneficio.Click -= BtnAdicionarBeneficio_Click;
            btnAdicionarBeneficio.Click += BtnAdicionarBeneficio_Click;

            dgvBeneficios.CellContentClick -= DgvBeneficios_CellContentClick;
            dgvBeneficios.CellContentClick += DgvBeneficios_CellContentClick;

            txtSalario.TextChanged -= TxtSalario_TextChanged;
            txtSalario.TextChanged += TxtSalario_TextChanged;

            rbPercentual.CheckedChanged -= RbTipoDesconto_CheckedChanged;
            rbPercentual.CheckedChanged += RbTipoDesconto_CheckedChanged;

            rbValorFixo.CheckedChanged -= RbTipoDesconto_CheckedChanged;
            rbValorFixo.CheckedChanged += RbTipoDesconto_CheckedChanged;

            cmbTipoJornada.SelectedIndexChanged -= CmbTipoJornada_SelectedIndexChanged;
            cmbTipoJornada.SelectedIndexChanged += CmbTipoJornada_SelectedIndexChanged;

            cmbEscala.SelectedIndexChanged -= CmbEscala_SelectedIndexChanged;
            cmbEscala.SelectedIndexChanged += CmbEscala_SelectedIndexChanged;

            dtpDataAdmissao.ValueChanged -= DtpDataAdmissao_ValueChanged;
            dtpDataAdmissao.ValueChanged += DtpDataAdmissao_ValueChanged;

            AtualizarInterfaceJornada();
        }

        // ============================================================
        // CANCELAR
        // ============================================================

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ============================================================
        // JORNADA / ESCALA
        // ============================================================

        private void CmbTipoJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterfaceJornada();
        }

        private void CmbEscala_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterfaceJornada();
        }

        private void DtpDataAdmissao_ValueChanged(object sender, EventArgs e)
        {
            // Para um novo funcionário, a data-base acompanha a admissão.
            // Na edição, a data-base salva no banco é preservada.
            if (!funcionarioIdEdicao.HasValue)
                dtpDataBaseEscala.Value = dtpDataAdmissao.Value;
        }

        private void AtualizarInterfaceJornada()
        {
            string escala = cmbEscala.SelectedItem?.ToString()
                ?? cmbEscala.Text
                ?? "";

            bool porEscala =
                string.Equals(
                    cmbTipoJornada.SelectedItem?.ToString(),
                    "Por escala",
                    StringComparison.OrdinalIgnoreCase);

            // A 2ª folga é utilizada principalmente no 5x2.
            bool usarSegundaFolga =
                escala.Equals("5x2", StringComparison.OrdinalIgnoreCase);

            cmbDiaFolga.Enabled =
                porEscala ||
                !string.IsNullOrWhiteSpace(escala);

            cmbDiaFolga2.Enabled =
                usarSegundaFolga;

            lblDiaFolga2.ForeColor =
                cmbDiaFolga2.Enabled
                    ? System.Drawing.Color.FromArgb(35, 45, 55)
                    : System.Drawing.Color.FromArgb(160, 165, 170);

            // Escalas rotativas precisam da data-base.
            dtpDataBaseEscala.Enabled = porEscala;

            lblDataBaseEscala.ForeColor =
                porEscala
                    ? System.Drawing.Color.FromArgb(35, 45, 55)
                    : System.Drawing.Color.FromArgb(160, 165, 170);

            if (!cmbDiaFolga2.Enabled)
                cmbDiaFolga2.SelectedIndex = -1;
        }

        // ============================================================
        // SALÁRIO
        // ============================================================

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {
            AtualizarCalculos();
        }

        private decimal ObterSalario()
        {
            string texto = txtSalario.Text
                .Replace("R$", "")
                .Trim();

            if (decimal.TryParse(
                texto,
                NumberStyles.Number,
                new CultureInfo("pt-BR"),
                out decimal salario))
            {
                return salario;
            }

            texto = texto.Replace(".", "");

            if (decimal.TryParse(
                texto,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out salario))
            {
                return salario;
            }

            return 0;
        }

        // ============================================================
        // TIPO DE DESCONTO
        // ============================================================

        private void RbTipoDesconto_CheckedChanged(
            object sender,
            EventArgs e)
        {
            AtualizarInterfaceTipoDesconto();
        }

        private void AtualizarInterfaceTipoDesconto()
        {
            if (rbPercentual.Checked)
            {
                nudPercentual.Minimum = 0;
                nudPercentual.Maximum = 100;
                nudPercentual.DecimalPlaces = 2;
                nudPercentual.Increment = 0.5M;
            }
            else
            {
                nudPercentual.Minimum = 0;
                nudPercentual.Maximum = 1000000;
                nudPercentual.DecimalPlaces = 2;
                nudPercentual.Increment = 10;
            }
        }

        // ============================================================
        // ADICIONAR BENEFÍCIO
        // ============================================================

        private void BtnAdicionarBeneficio_Click(
            object sender,
            EventArgs e)
        {
            string nome = txtNomeBeneficio.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show(
                    "Informe o nome do benefício.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNomeBeneficio.Focus();
                return;
            }

            decimal valorInformado = nudPercentual.Value;

            if (valorInformado <= 0)
            {
                MessageBox.Show(
                    rbPercentual.Checked
                        ? "Informe o percentual do benefício."
                        : "Informe o valor do benefício.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudPercentual.Focus();
                return;
            }

            decimal salario = ObterSalario();

            if (salario <= 0)
            {
                MessageBox.Show(
                    "Informe primeiro um salário válido.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSalario.Focus();
                return;
            }

            bool ehPercentual = rbPercentual.Checked;

            decimal valorDesconto;

            if (ehPercentual)
            {
                valorDesconto =
                    salario * valorInformado / 100;
            }
            else
            {
                valorDesconto =
                    valorInformado;
            }

            Beneficio beneficio = new Beneficio
            {
                Nome = nome,
                EhPercentual = ehPercentual,
                ValorInformado = valorInformado,
                ValorDesconto = valorDesconto
            };

            beneficios.Add(beneficio);

            AtualizarTabelaBeneficios();

            txtNomeBeneficio.Clear();
            nudPercentual.Value = 0;

            txtNomeBeneficio.Focus();
        }

        // ============================================================
        // ATUALIZAR TABELA DE BENEFÍCIOS
        // ============================================================

        private void AtualizarTabelaBeneficios()
        {
            dgvBeneficios.Rows.Clear();

            CultureInfo cultura =
                new CultureInfo("pt-BR");

            foreach (Beneficio beneficio in beneficios)
            {
                string tipo;
                string valorInformado;

                if (beneficio.EhPercentual)
                {
                    tipo = "Percentual";

                    valorInformado =
                        beneficio.ValorInformado
                            .ToString("0.00", cultura) + "%";
                }
                else
                {
                    tipo = "Valor fixo";

                    valorInformado =
                        beneficio.ValorInformado
                            .ToString("C2", cultura);
                }

                dgvBeneficios.Rows.Add(
                    beneficio.Nome,
                    tipo,
                    valorInformado,
                    beneficio.ValorDesconto
                        .ToString("C2", cultura),
                    "Remover");
            }

            AtualizarCalculos();

            dgvBeneficios.ClearSelection();
            dgvBeneficios.CurrentCell = null;
        }

        // ============================================================
        // REMOVER BENEFÍCIO
        // ============================================================

        private void DgvBeneficios_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex ==
                colRemoverBeneficio.Index)
            {
                if (e.RowIndex >= beneficios.Count)
                    return;

                beneficios.RemoveAt(e.RowIndex);

                AtualizarTabelaBeneficios();
            }
        }

        // ============================================================
        // CÁLCULOS
        // ============================================================

        private void AtualizarCalculos()
        {
            decimal salario =
                ObterSalario();

            decimal totalDescontos = 0;

            CultureInfo cultura =
                new CultureInfo("pt-BR");

            foreach (Beneficio beneficio in beneficios)
            {
                if (beneficio.EhPercentual)
                {
                    beneficio.ValorDesconto =
                        salario *
                        beneficio.ValorInformado /
                        100;
                }
                else
                {
                    beneficio.ValorDesconto =
                        beneficio.ValorInformado;
                }

                totalDescontos +=
                    beneficio.ValorDesconto;
            }

            decimal salarioEstimado =
                salario - totalDescontos;

            lblTotalDescontos.Text =
                "Descontos: " +
                totalDescontos.ToString(
                    "C2",
                    cultura);

            lblSalarioEstimado.Text =
                "Salário estimado: " +
                salarioEstimado.ToString(
                    "C2",
                    cultura);

            if (dgvBeneficios.Rows.Count > 0)
            {
                for (int i = 0;
                     i < beneficios.Count;
                     i++)
                {
                    if (i >= dgvBeneficios.Rows.Count)
                        break;

                    dgvBeneficios.Rows[i]
                        .Cells[3]
                        .Value =
                        beneficios[i]
                            .ValorDesconto
                            .ToString(
                                "C2",
                                cultura);
                }
            }
        }

        // ============================================================
        // CARREGAR FUNCIONÁRIO PARA EDIÇÃO
        // ============================================================

        private void CarregarFuncionario(long funcionarioId)
        {
            try
            {
                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT
                            Id,
                            Nome,
                            CPF,
                            DataNascimento,
                            Telefone,
                            Email,
                            Cargo,
                            Setor,
                            DataAdmissao,
                            Salario,
                            TipoJornada,
                            Escala,
                            DiaFolga,
                            DiaFolga2,
                            DataBaseEscala,
                            CargaHorariaSemanal,
                            HorarioEntrada,
                            HorarioSaida,
                            InicioIntervalo,
                            FimIntervalo,
                            Status,
                            Observacoes
                        FROM Funcionarios
                        WHERE Id = $Id;
                    ";

                    using (SqliteCommand command =
                           connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        command.Parameters.AddWithValue(
                            "$Id",
                            funcionarioId);

                        using (SqliteDataReader reader =
                               command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Funcionário não encontrado.",
                                    "RH Control",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                Close();
                                return;
                            }

                            txtNome.Text =
                                reader["Nome"]?.ToString() ?? "";

                            txtCPF.Text =
                                reader["CPF"]?.ToString() ?? "";

                            if (DateTime.TryParse(
                                reader["DataNascimento"]?.ToString(),
                                out DateTime dataNascimento))
                            {
                                dtpDataNascimento.Value =
                                    dataNascimento;
                            }

                            txtTelefone.Text =
                                reader["Telefone"]?.ToString() ?? "";

                            txtEmail.Text =
                                reader["Email"]?.ToString() ?? "";

                            txtCargo.Text =
                                reader["Cargo"]?.ToString() ?? "";

                            txtSetor.Text =
                                reader["Setor"]?.ToString() ?? "";

                            if (DateTime.TryParse(
                                reader["DataAdmissao"]?.ToString(),
                                out DateTime dataAdmissao))
                            {
                                dtpDataAdmissao.Value =
                                    dataAdmissao;
                            }

                            if (decimal.TryParse(
                                reader["Salario"]?.ToString(),
                                NumberStyles.Any,
                                CultureInfo.InvariantCulture,
                                out decimal salario))
                            {
                                txtSalario.Text =
                                    salario.ToString(
                                        "N2",
                                        new CultureInfo("pt-BR"));
                            }

                            string tipoJornada =
                                reader["TipoJornada"]?.ToString()
                                ?? "Jornada fixa";

                            int indiceTipoJornada =
                                cmbTipoJornada.Items.IndexOf(
                                    tipoJornada);

                            if (indiceTipoJornada >= 0)
                                cmbTipoJornada.SelectedIndex =
                                    indiceTipoJornada;
                            else
                                cmbTipoJornada.Text =
                                    tipoJornada;

                            string escala =
                                reader["Escala"]?.ToString() ?? "";

                            if (!string.IsNullOrWhiteSpace(escala))
                            {
                                int indice =
                                    cmbEscala.Items.IndexOf(
                                        escala);

                                if (indice >= 0)
                                    cmbEscala.SelectedIndex =
                                        indice;
                                else
                                    cmbEscala.Text =
                                        escala;
                            }

                            string diaFolga =
                                reader["DiaFolga"]?.ToString() ?? "";

                            SelecionarComboTexto(
                                cmbDiaFolga,
                                diaFolga);

                            string diaFolga2 =
                                reader["DiaFolga2"]?.ToString() ?? "";

                            SelecionarComboTexto(
                                cmbDiaFolga2,
                                diaFolga2);

                            if (DateTime.TryParse(
                                reader["DataBaseEscala"]?.ToString(),
                                out DateTime dataBaseEscala))
                            {
                                dtpDataBaseEscala.Value =
                                    dataBaseEscala;
                            }
                            else
                            {
                                dtpDataBaseEscala.Value =
                                    dtpDataAdmissao.Value;
                            }

                            AtualizarInterfaceJornada();

                            if (int.TryParse(
                                reader["CargaHorariaSemanal"]?.ToString(),
                                out int cargaHoraria))
                            {
                                if (cargaHoraria >=
                                    nudCargaHoraria.Minimum &&
                                    cargaHoraria <=
                                    nudCargaHoraria.Maximum)
                                {
                                    nudCargaHoraria.Value =
                                        cargaHoraria;
                                }
                            }

                            DefinirHorario(
                                dtpHorarioEntrada,
                                reader["HorarioEntrada"]);

                            DefinirHorario(
                                dtpHorarioSaida,
                                reader["HorarioSaida"]);

                            DefinirHorario(
                                dtpInicioIntervalo,
                                reader["InicioIntervalo"]);

                            DefinirHorario(
                                dtpFimIntervalo,
                                reader["FimIntervalo"]);

                            statusAtual =
                                reader["Status"]?.ToString()
                                ?? "Ativo";

                            txtObservacoes.Text =
                                reader["Observacoes"]?.ToString()
                                ?? "";
                        }
                    }

                    CarregarBeneficios(
                        connection,
                        funcionarioId);
                }

                btnSalvar.Text =
                    "Salvar alterações";

                AtualizarTabelaBeneficios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os dados do funcionário.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        // ============================================================
        // SELECIONAR COMBO
        // ============================================================

        private void SelecionarComboTexto(
            ComboBox combo,
            string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                combo.SelectedIndex = -1;
                return;
            }

            int indice =
                combo.Items.IndexOf(texto);

            if (indice >= 0)
                combo.SelectedIndex = indice;
            else
                combo.Text = texto;
        }

        // ============================================================
        // DEFINIR HORÁRIO
        // ============================================================

        private void DefinirHorario(
            DateTimePicker controle,
            object valor)
        {
            string horario =
                valor?.ToString() ?? "";

            if (TimeSpan.TryParse(
                horario,
                out TimeSpan hora))
            {
                DateTime data =
                    DateTime.Today.Add(hora);

                controle.Value = data;
            }
        }

        // ============================================================
        // CARREGAR BENEFÍCIOS
        // ============================================================

        private void CarregarBeneficios(
            SqliteConnection connection,
            long funcionarioId)
        {
            beneficios.Clear();

            string sql = @"
                SELECT
                    NomeBeneficio,
                    PercentualDesconto,
                    ValorDesconto
                FROM BeneficiosFuncionario
                WHERE FuncionarioId = $FuncionarioId
                ORDER BY rowid;
            ";

            using (SqliteCommand command =
                   connection.CreateCommand())
            {
                command.CommandText = sql;

                command.Parameters.AddWithValue(
                    "$FuncionarioId",
                    funcionarioId);

                using (SqliteDataReader reader =
                       command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome =
                            reader["NomeBeneficio"]
                                ?.ToString() ?? "";

                        decimal percentual = 0;
                        decimal valorDesconto = 0;

                        decimal.TryParse(
                            reader["PercentualDesconto"]
                                ?.ToString(),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out percentual);

                        decimal.TryParse(
                            reader["ValorDesconto"]
                                ?.ToString(),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out valorDesconto);

                        // Na estrutura atual do banco:
                        // percentual > 0 = percentual
                        // percentual = 0 = valor fixo

                        bool ehPercentual =
                            percentual > 0;

                        decimal valorInformado;

                        if (ehPercentual)
                        {
                            valorInformado =
                                percentual;
                        }
                        else
                        {
                            valorInformado =
                                valorDesconto;
                        }

                        beneficios.Add(
                            new Beneficio
                            {
                                Nome = nome,
                                EhPercentual =
                                    ehPercentual,
                                ValorInformado =
                                    valorInformado,
                                ValorDesconto =
                                    valorDesconto
                            });
                    }
                }
            }
        }

        // ============================================================
        // SALVAR FUNCIONÁRIO
        // ============================================================

        private void BtnSalvar_Click(
            object sender,
            EventArgs e)
        {
            // --------------------------------------------------------
            // VALIDAÇÕES
            // --------------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show(
                    "Informe o nome completo do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show(
                    "Informe o cargo do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCargo.Focus();
                return;
            }

            decimal salario =
                ObterSalario();

            if (salario <= 0)
            {
                MessageBox.Show(
                    "Informe um salário válido.\n\nExemplo: 2500,00",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSalario.Focus();
                return;
            }

            if (cmbEscala.SelectedIndex == -1 &&
                string.IsNullOrWhiteSpace(cmbEscala.Text))
            {
                MessageBox.Show(
                    "Selecione a escala do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEscala.Focus();
                return;
            }

            try
            {
                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    using (SqliteTransaction transaction =
                           connection.BeginTransaction())
                    {
                        long funcionarioId;

                        // =================================================
                        // NOVO FUNCIONÁRIO
                        // =================================================

                        if (!funcionarioIdEdicao.HasValue)
                        {
                            string sqlFuncionario = @"
                                INSERT INTO Funcionarios
                                (
                                    Nome,
                                    CPF,
                                    DataNascimento,
                                    Telefone,
                                    Email,
                                    Cargo,
                                    Setor,
                                    DataAdmissao,
                                    Salario,
                                    TipoJornada,
                                    Escala,
                                    DiaFolga,
                                    DiaFolga2,
                                    DataBaseEscala,
                                    CargaHorariaSemanal,
                                    HorarioEntrada,
                                    HorarioSaida,
                                    InicioIntervalo,
                                    FimIntervalo,
                                    Status,
                                    Observacoes,
                                    CriadoEm
                                )
                                VALUES
                                (
                                    $Nome,
                                    $CPF,
                                    $DataNascimento,
                                    $Telefone,
                                    $Email,
                                    $Cargo,
                                    $Setor,
                                    $DataAdmissao,
                                    $Salario,
                                    $TipoJornada,
                                    $Escala,
                                    $DiaFolga,
                                    $DiaFolga2,
                                    $DataBaseEscala,
                                    $CargaHorariaSemanal,
                                    $HorarioEntrada,
                                    $HorarioSaida,
                                    $InicioIntervalo,
                                    $FimIntervalo,
                                    $Status,
                                    $Observacoes,
                                    $CriadoEm
                                );
                            ";

                            using (SqliteCommand command =
                                   connection.CreateCommand())
                            {
                                command.Transaction =
                                    transaction;

                                command.CommandText =
                                    sqlFuncionario;

                                PreencherParametrosFuncionario(
                                    command,
                                    salario,
                                    "Ativo");

                                command.ExecuteNonQuery();
                            }

                            using (SqliteCommand idCommand =
                                   connection.CreateCommand())
                            {
                                idCommand.Transaction =
                                    transaction;

                                idCommand.CommandText =
                                    "SELECT last_insert_rowid();";

                                object resultado =
                                    idCommand.ExecuteScalar();

                                funcionarioId =
                                    Convert.ToInt64(resultado);
                            }

                            if (funcionarioId <= 0)
                            {
                                throw new Exception(
                                    "Não foi possível obter o ID do funcionário cadastrado.");
                            }
                        }

                        // =================================================
                        // EDITAR FUNCIONÁRIO
                        // =================================================

                        else
                        {
                            funcionarioId =
                                funcionarioIdEdicao.Value;

                            string sqlFuncionario = @"
                                UPDATE Funcionarios
                                SET
                                    Nome = $Nome,
                                    CPF = $CPF,
                                    DataNascimento = $DataNascimento,
                                    Telefone = $Telefone,
                                    Email = $Email,
                                    Cargo = $Cargo,
                                    Setor = $Setor,
                                    DataAdmissao = $DataAdmissao,
                                    Salario = $Salario,
                                    TipoJornada = $TipoJornada,
                                    Escala = $Escala,
                                    DiaFolga = $DiaFolga,
                                    DiaFolga2 = $DiaFolga2,
                                    DataBaseEscala = $DataBaseEscala,
                                    CargaHorariaSemanal = $CargaHorariaSemanal,
                                    HorarioEntrada = $HorarioEntrada,
                                    HorarioSaida = $HorarioSaida,
                                    InicioIntervalo = $InicioIntervalo,
                                    FimIntervalo = $FimIntervalo,
                                    Status = $Status,
                                    Observacoes = $Observacoes
                                WHERE Id = $Id;
                            ";

                            using (SqliteCommand command =
                                   connection.CreateCommand())
                            {
                                command.Transaction =
                                    transaction;

                                command.CommandText =
                                    sqlFuncionario;

                                PreencherParametrosFuncionario(
                                    command,
                                    salario,
                                    statusAtual);

                                command.Parameters.AddWithValue(
                                    "$Id",
                                    funcionarioId);

                                command.ExecuteNonQuery();
                            }

                            // Remove os benefícios antigos
                            // para gravar a versão atualizada.

                            string sqlExcluirBeneficios = @"
                                DELETE FROM BeneficiosFuncionario
                                WHERE FuncionarioId = $FuncionarioId;
                            ";

                            using (SqliteCommand command =
                                   connection.CreateCommand())
                            {
                                command.Transaction =
                                    transaction;

                                command.CommandText =
                                    sqlExcluirBeneficios;

                                command.Parameters.AddWithValue(
                                    "$FuncionarioId",
                                    funcionarioId);

                                command.ExecuteNonQuery();
                            }
                        }

                        // =================================================
                        // GRAVAR BENEFÍCIOS
                        // =================================================

                        foreach (Beneficio beneficio
                                 in beneficios)
                        {
                            string sqlBeneficio = @"
                                INSERT INTO BeneficiosFuncionario
                                (
                                    FuncionarioId,
                                    NomeBeneficio,
                                    PercentualDesconto,
                                    ValorDesconto
                                )
                                VALUES
                                (
                                    $FuncionarioId,
                                    $NomeBeneficio,
                                    $PercentualDesconto,
                                    $ValorDesconto
                                );
                            ";

                            using (SqliteCommand command =
                                   connection.CreateCommand())
                            {
                                command.Transaction =
                                    transaction;

                                command.CommandText =
                                    sqlBeneficio;

                                command.Parameters.AddWithValue(
                                    "$FuncionarioId",
                                    funcionarioId);

                                command.Parameters.AddWithValue(
                                    "$NomeBeneficio",
                                    beneficio.Nome);

                                decimal percentual =
                                    beneficio.EhPercentual
                                        ? beneficio.ValorInformado
                                        : 0;

                                command.Parameters.AddWithValue(
                                    "$PercentualDesconto",
                                    Convert.ToDouble(
                                        percentual));

                                command.Parameters.AddWithValue(
                                    "$ValorDesconto",
                                    Convert.ToDouble(
                                        beneficio.ValorDesconto));

                                command.ExecuteNonQuery();
                            }
                        }

                        // =================================================
                        // CONFIRMA TUDO
                        // =================================================

                        transaction.Commit();
                    }
                }

                MessageBox.Show(
                    funcionarioIdEdicao.HasValue
                        ? "Funcionário atualizado com sucesso!"
                        : "Funcionário cadastrado com sucesso!",
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível salvar o funcionário.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // PARÂMETROS DO FUNCIONÁRIO
        // ============================================================

        private void PreencherParametrosFuncionario(
            SqliteCommand command,
            decimal salario,
            string status)
        {
            command.Parameters.AddWithValue(
                "$Nome",
                txtNome.Text.Trim());

            command.Parameters.AddWithValue(
                "$CPF",
                txtCPF.Text.Trim());

            command.Parameters.AddWithValue(
                "$DataNascimento",
                dtpDataNascimento.Value.ToString(
                    "yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$Telefone",
                txtTelefone.Text.Trim());

            command.Parameters.AddWithValue(
                "$Email",
                txtEmail.Text.Trim());

            command.Parameters.AddWithValue(
                "$Cargo",
                txtCargo.Text.Trim());

            command.Parameters.AddWithValue(
                "$Setor",
                txtSetor.Text.Trim());

            command.Parameters.AddWithValue(
                "$DataAdmissao",
                dtpDataAdmissao.Value.ToString(
                    "yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$Salario",
                Convert.ToDouble(salario));

            command.Parameters.AddWithValue(
                "$TipoJornada",
                cmbTipoJornada.SelectedItem?.ToString()
                ?? cmbTipoJornada.Text
                ?? "Jornada fixa");

            command.Parameters.AddWithValue(
                "$Escala",
                cmbEscala.SelectedItem?.ToString()
                ?? cmbEscala.Text
                ?? "");

            command.Parameters.AddWithValue(
                "$DiaFolga",
                cmbDiaFolga.SelectedItem?.ToString()
                ?? cmbDiaFolga.Text
                ?? "");

            command.Parameters.AddWithValue(
                "$DiaFolga2",
                cmbDiaFolga2.Enabled
                    ? (cmbDiaFolga2.SelectedItem?.ToString()
                        ?? cmbDiaFolga2.Text
                        ?? "")
                    : "");

            command.Parameters.AddWithValue(
                "$DataBaseEscala",
                dtpDataBaseEscala.Value.ToString(
                    "yyyy-MM-dd"));

            command.Parameters.AddWithValue(
                "$CargaHorariaSemanal",
                Convert.ToInt32(
                    nudCargaHoraria.Value));

            command.Parameters.AddWithValue(
                "$HorarioEntrada",
                dtpHorarioEntrada.Value.ToString(
                    "HH:mm"));

            command.Parameters.AddWithValue(
                "$HorarioSaida",
                dtpHorarioSaida.Value.ToString(
                    "HH:mm"));

            command.Parameters.AddWithValue(
                "$InicioIntervalo",
                dtpInicioIntervalo.Value.ToString(
                    "HH:mm"));

            command.Parameters.AddWithValue(
                "$FimIntervalo",
                dtpFimIntervalo.Value.ToString(
                    "HH:mm"));

            command.Parameters.AddWithValue(
                "$Status",
                status);

            command.Parameters.AddWithValue(
                "$Observacoes",
                txtObservacoes.Text.Trim());

            command.Parameters.AddWithValue(
                "$CriadoEm",
                DateTime.Now.ToString(
                    "yyyy-MM-dd HH:mm:ss"));
        }
    }
}