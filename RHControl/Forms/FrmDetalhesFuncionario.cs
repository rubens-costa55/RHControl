using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using RHControl.Data;

namespace RHControl
{
    public class FrmDetalhesFuncionario : Form
    {
        private readonly long funcionarioId;

        private Panel pnlCabecalho;
        private Panel pnlConteudo;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblStatus;

        private GroupBox grpPessoal;
        private GroupBox grpProfissional;
        private GroupBox grpJornada;
        private GroupBox grpBeneficios;
        private GroupBox grpObservacoes;

        private Label lblNome;
        private Label lblCPF;
        private Label lblNascimento;
        private Label lblTelefone;
        private Label lblEmail;

        private Label lblCargo;
        private Label lblSetor;
        private Label lblAdmissao;
        private Label lblSalario;
        private Label lblEscala;

        private Label lblCargaHoraria;
        private Label lblEntrada;
        private Label lblSaida;
        private Label lblIntervalo;

        private DataGridView dgvBeneficios;

        private TextBox txtObservacoes;

        private Button btnFechar;

        public FrmDetalhesFuncionario(long funcionarioId)
        {
            this.funcionarioId = funcionarioId;

            ConfigurarFormulario();
            CarregarFuncionario();
        }

        // ============================================================
        // CONFIGURAÇÃO DO FORMULÁRIO
        // ============================================================

        private void ConfigurarFormulario()
        {
            Text = "RH Control — Detalhes do Funcionário";

            StartPosition = FormStartPosition.CenterParent;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;
            MinimizeBox = false;

            ClientSize = new Size(1050, 800);

            BackColor = Color.FromArgb(244, 247, 251);

            // ========================================================
            // CABEÇALHO
            // ========================================================

            pnlCabecalho = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(1050, 110),
                BackColor = Color.FromArgb(10, 60, 105)
            };

            Controls.Add(pnlCabecalho);

            lblTitulo = new Label
            {
                AutoSize = true,
                Location = new Point(38, 20),
                Font = new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold),
                ForeColor = Color.White,
                Text = "Detalhes do funcionário"
            };

            pnlCabecalho.Controls.Add(lblTitulo);

            lblSubtitulo = new Label
            {
                AutoSize = true,
                Location = new Point(41, 66),
                Font = new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Regular),
                ForeColor = Color.FromArgb(205, 225, 245),
                Text = "Visualização completa das informações cadastradas"
            };

            pnlCabecalho.Controls.Add(lblSubtitulo);

            // ========================================================
            // STATUS
            // ========================================================

            lblStatus = new Label
            {
                AutoSize = false,
                Location = new Point(875, 31),
                Size = new Size(140, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(25, 118, 80),
                Text = "Ativo"
            };

            pnlCabecalho.Controls.Add(lblStatus);

            // ========================================================
            // CONTEÚDO
            // ========================================================

            pnlConteudo = new Panel
            {
                Location = new Point(20, 125),
                Size = new Size(1010, 640),
                BackColor = Color.Transparent,
                AutoScroll = false
            };

            Controls.Add(pnlConteudo);

            CriarGrupoPessoal();
            CriarGrupoProfissional();
            CriarGrupoJornada();
            CriarGrupoBeneficios();
            CriarGrupoObservacoes();

            // ========================================================
            // BOTÃO FECHAR
            // ========================================================

            btnFechar = new Button
            {
                Location = new Point(900, 755),
                Size = new Size(130, 40),
                Text = "Fechar",
                Font = new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold),
                BackColor = Color.FromArgb(21, 101, 192),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnFechar.FlatAppearance.BorderSize = 0;

            btnFechar.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(25, 118, 210);

            btnFechar.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(13, 71, 161);

            btnFechar.Click += (s, e) =>
            {
                Close();
            };

            Controls.Add(btnFechar);
        }

        // ============================================================
        // DADOS PESSOAIS
        // ============================================================

        private void CriarGrupoPessoal()
        {
            grpPessoal = CriarGroupBox(
                "DADOS PESSOAIS",
                new Point(15, 10),
                new Size(960, 125));

            pnlConteudo.Controls.Add(grpPessoal);

            lblNome = CriarLabel(
                "Nome:",
                new Point(25, 35),
                420);

            lblCPF = CriarLabel(
                "CPF:",
                new Point(490, 35),
                400);

            lblNascimento = CriarLabel(
                "Nascimento:",
                new Point(25, 68),
                420);

            lblTelefone = CriarLabel(
                "Telefone:",
                new Point(490, 68),
                400);

            lblEmail = CriarLabel(
                "E-mail:",
                new Point(25, 101),
                850);

            grpPessoal.Controls.AddRange(
                new Control[]
                {
                    lblNome,
                    lblCPF,
                    lblNascimento,
                    lblTelefone,
                    lblEmail
                });
        }

        // ============================================================
        // DADOS PROFISSIONAIS
        // ============================================================

        private void CriarGrupoProfissional()
        {
            grpProfissional = CriarGroupBox(
                "DADOS PROFISSIONAIS",
                new Point(15, 145),
                new Size(960, 125));

            pnlConteudo.Controls.Add(grpProfissional);

            lblCargo = CriarLabel(
                "Cargo:",
                new Point(25, 35),
                420);

            lblSetor = CriarLabel(
                "Setor:",
                new Point(490, 35),
                400);

            lblAdmissao = CriarLabel(
                "Data de admissão:",
                new Point(25, 68),
                420);

            lblSalario = CriarLabel(
                "Salário:",
                new Point(490, 68),
                400);

            lblEscala = CriarLabel(
                "Escala:",
                new Point(25, 101),
                850);

            grpProfissional.Controls.AddRange(
                new Control[]
                {
                    lblCargo,
                    lblSetor,
                    lblAdmissao,
                    lblSalario,
                    lblEscala
                });
        }

        // ============================================================
        // JORNADA
        // ============================================================

        private void CriarGrupoJornada()
        {
            grpJornada = CriarGroupBox(
                "JORNADA DE TRABALHO",
                new Point(15, 280),
                new Size(960, 105));

            pnlConteudo.Controls.Add(grpJornada);

            lblCargaHoraria = CriarLabel(
                "Carga horária:",
                new Point(25, 38),
                180);

            lblEntrada = CriarLabel(
                "Entrada:",
                new Point(220, 38),
                180);

            lblSaida = CriarLabel(
                "Saída:",
                new Point(415, 38),
                180);

            lblIntervalo = CriarLabel(
                "Intervalo:",
                new Point(610, 38),
                300);

            grpJornada.Controls.AddRange(
                new Control[]
                {
                    lblCargaHoraria,
                    lblEntrada,
                    lblSaida,
                    lblIntervalo
                });
        }

        // ============================================================
        // BENEFÍCIOS
        // ============================================================

        private void CriarGrupoBeneficios()
        {
            grpBeneficios = CriarGroupBox(
                "BENEFÍCIOS E DESCONTOS",
                new Point(15, 395),
                new Size(960, 125));

            pnlConteudo.Controls.Add(grpBeneficios);

            dgvBeneficios = new DataGridView
            {
                Location = new Point(20, 30),
                Size = new Size(915, 80),

                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,

                ReadOnly = true,
                MultiSelect = false,

                RowHeadersVisible = false,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,

                BackgroundColor = Color.White,

                BorderStyle =
                    BorderStyle.FixedSingle,

                CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal,

                EnableHeadersVisualStyles = false,

                GridColor =
                    Color.FromArgb(225, 232, 240)
            };

            dgvBeneficios.ColumnHeadersHeight = 25;

            dgvBeneficios.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(235, 242, 249),

                    ForeColor =
                        Color.FromArgb(35, 55, 75),

                    Font =
                        new Font(
                            "Segoe UI",
                            8.5F,
                            FontStyle.Bold),

                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft
                };

            dgvBeneficios.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,

                    ForeColor =
                        Color.FromArgb(50, 65, 80),

                    Font =
                        new Font(
                            "Segoe UI",
                            8.5F),

                    SelectionBackColor =
                        Color.FromArgb(225, 239, 255),

                    SelectionForeColor =
                        Color.FromArgb(30, 55, 80)
                };

            dgvBeneficios.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(249, 251, 253)
                };

            dgvBeneficios.Columns.Add(
                "Nome",
                "Benefício");

            dgvBeneficios.Columns.Add(
                "Tipo",
                "Tipo");

            dgvBeneficios.Columns.Add(
                "Valor",
                "Desconto");

            grpBeneficios.Controls.Add(
                dgvBeneficios);
        }

        // ============================================================
        // OBSERVAÇÕES
        // ============================================================

        private void CriarGrupoObservacoes()
        {
            grpObservacoes = CriarGroupBox(
                "OBSERVAÇÕES",
                new Point(15, 530),
                new Size(960, 105));

            pnlConteudo.Controls.Add(grpObservacoes);

            txtObservacoes = new TextBox
            {
                Location = new Point(20, 30),
                Size = new Size(915, 60),

                Multiline = true,

                ReadOnly = true,

                BackColor =
                    Color.FromArgb(249, 251, 253),

                ForeColor =
                    Color.FromArgb(55, 65, 75),

                BorderStyle =
                    BorderStyle.FixedSingle,

                Font =
                    new Font(
                        "Segoe UI",
                        9F),

                ScrollBars =
                    ScrollBars.Vertical
            };

            grpObservacoes.Controls.Add(
                txtObservacoes);
        }

        // ============================================================
        // GROUPBOX
        // ============================================================

        private GroupBox CriarGroupBox(
            string titulo,
            Point local,
            Size tamanho)
        {
            return new GroupBox
            {
                Text = titulo,

                Location = local,

                Size = tamanho,

                Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold),

                ForeColor =
                    Color.FromArgb(
                        21,
                        101,
                        192),

                BackColor =
                    Color.White
            };
        }

        // ============================================================
        // LABEL
        // ============================================================

        private Label CriarLabel(
            string texto,
            Point local,
            int largura)
        {
            return new Label
            {
                AutoSize = false,

                Location = local,

                Size =
                    new Size(
                        largura,
                        25),

                Font =
                    new Font(
                        "Segoe UI",
                        9.5F,
                        FontStyle.Bold),

                ForeColor =
                    Color.FromArgb(
                        55,
                        65,
                        75),

                Text = texto,

                TextAlign =
                    ContentAlignment.MiddleLeft
            };
        }

        // ============================================================
        // CARREGAR FUNCIONÁRIO
        // ============================================================

        private void CarregarFuncionario()
        {
            try
            {
                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT
                            Nome,
                            CPF,
                            DataNascimento,
                            Telefone,
                            Email,
                            Cargo,
                            Setor,
                            DataAdmissao,
                            Salario,
                            Escala,
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

                            string nome =
                                reader["Nome"]?.ToString() ?? "";

                            string cpf =
                                reader["CPF"]?.ToString() ?? "";

                            string telefone =
                                reader["Telefone"]?.ToString() ?? "";

                            string email =
                                reader["Email"]?.ToString() ?? "";

                            string cargo =
                                reader["Cargo"]?.ToString() ?? "";

                            string setor =
                                reader["Setor"]?.ToString() ?? "";

                            string escala =
                                reader["Escala"]?.ToString() ?? "";

                            string status =
                                reader["Status"]?.ToString() ?? "";

                            string observacoes =
                                reader["Observacoes"]?.ToString() ?? "";

                            // --------------------------------------------
                            // DADOS PESSOAIS
                            // --------------------------------------------

                            lblNome.Text =
                                "Nome: " + nome;

                            lblCPF.Text =
                                "CPF: " +
                                (string.IsNullOrWhiteSpace(cpf)
                                    ? "—"
                                    : cpf);

                            lblTelefone.Text =
                                "Telefone: " +
                                (string.IsNullOrWhiteSpace(telefone)
                                    ? "—"
                                    : telefone);

                            lblEmail.Text =
                                "E-mail: " +
                                (string.IsNullOrWhiteSpace(email)
                                    ? "—"
                                    : email);

                            // --------------------------------------------
                            // DADOS PROFISSIONAIS
                            // --------------------------------------------

                            lblCargo.Text =
                                "Cargo: " +
                                (string.IsNullOrWhiteSpace(cargo)
                                    ? "—"
                                    : cargo);

                            lblSetor.Text =
                                "Setor: " +
                                (string.IsNullOrWhiteSpace(setor)
                                    ? "—"
                                    : setor);

                            lblEscala.Text =
                                "Escala: " +
                                (string.IsNullOrWhiteSpace(escala)
                                    ? "—"
                                    : escala);

                            // --------------------------------------------
                            // STATUS
                            // --------------------------------------------

                            lblStatus.Text =
                                string.IsNullOrWhiteSpace(status)
                                    ? "Sem status"
                                    : status;

                            lblStatus.BackColor =
                                ObterCorStatus(status);

                            lblStatus.ForeColor =
                                Color.White;

                            // --------------------------------------------
                            // DATA DE NASCIMENTO
                            // --------------------------------------------

                            if (DateTime.TryParse(
                                reader["DataNascimento"]?.ToString(),
                                out DateTime nascimento))
                            {
                                lblNascimento.Text =
                                    "Nascimento: " +
                                    nascimento.ToString(
                                        "dd/MM/yyyy");
                            }
                            else
                            {
                                lblNascimento.Text =
                                    "Nascimento: —";
                            }

                            // --------------------------------------------
                            // DATA DE ADMISSÃO
                            // --------------------------------------------

                            if (DateTime.TryParse(
                                reader["DataAdmissao"]?.ToString(),
                                out DateTime admissao))
                            {
                                lblAdmissao.Text =
                                    "Data de admissão: " +
                                    admissao.ToString(
                                        "dd/MM/yyyy");
                            }
                            else
                            {
                                lblAdmissao.Text =
                                    "Data de admissão: —";
                            }

                            // --------------------------------------------
                            // SALÁRIO
                            // --------------------------------------------

                            if (decimal.TryParse(
                                reader["Salario"]?.ToString(),
                                NumberStyles.Any,
                                CultureInfo.InvariantCulture,
                                out decimal salario))
                            {
                                lblSalario.Text =
                                    "Salário: " +
                                    salario.ToString(
                                        "C2",
                                        new CultureInfo("pt-BR"));
                            }
                            else
                            {
                                lblSalario.Text =
                                    "Salário: —";
                            }

                            // --------------------------------------------
                            // CARGA HORÁRIA
                            // --------------------------------------------

                            string carga =
                                reader["CargaHorariaSemanal"]
                                    ?.ToString() ?? "";

                            lblCargaHoraria.Text =
                                "Carga horária: " +
                                (string.IsNullOrWhiteSpace(carga)
                                    ? "—"
                                    : carga + "h/semana");

                            // --------------------------------------------
                            // HORÁRIO DE ENTRADA
                            // --------------------------------------------

                            string entrada =
                                reader["HorarioEntrada"]
                                    ?.ToString() ?? "";

                            lblEntrada.Text =
                                "Entrada: " +
                                (string.IsNullOrWhiteSpace(entrada)
                                    ? "—"
                                    : entrada);

                            // --------------------------------------------
                            // HORÁRIO DE SAÍDA
                            // --------------------------------------------

                            string saida =
                                reader["HorarioSaida"]
                                    ?.ToString() ?? "";

                            lblSaida.Text =
                                "Saída: " +
                                (string.IsNullOrWhiteSpace(saida)
                                    ? "—"
                                    : saida);

                            // --------------------------------------------
                            // INTERVALO
                            // --------------------------------------------

                            string inicioIntervalo =
                                reader["InicioIntervalo"]
                                    ?.ToString() ?? "";

                            string fimIntervalo =
                                reader["FimIntervalo"]
                                    ?.ToString() ?? "";

                            if (!string.IsNullOrWhiteSpace(
                                    inicioIntervalo) &&
                                !string.IsNullOrWhiteSpace(
                                    fimIntervalo))
                            {
                                lblIntervalo.Text =
                                    "Intervalo: " +
                                    inicioIntervalo +
                                    " às " +
                                    fimIntervalo;
                            }
                            else
                            {
                                lblIntervalo.Text =
                                    "Intervalo: —";
                            }

                            // --------------------------------------------
                            // OBSERVAÇÕES
                            // --------------------------------------------

                            txtObservacoes.Text =
                                string.IsNullOrWhiteSpace(
                                    observacoes)
                                    ? "Nenhuma observação cadastrada."
                                    : observacoes;
                        }
                    }

                    CarregarBeneficios(
                        connection,
                        funcionarioId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os detalhes do funcionário.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        // ============================================================
        // CARREGAR BENEFÍCIOS
        // ============================================================

        private void CarregarBeneficios(
            SqliteConnection connection,
            long id)
        {
            dgvBeneficios.Rows.Clear();

            string sql = @"
                SELECT
                    NomeBeneficio,
                    PercentualDesconto,
                    ValorDesconto
                FROM BeneficiosFuncionario
                WHERE FuncionarioId = $Id
                ORDER BY rowid;
            ";

            using (SqliteCommand command =
                   connection.CreateCommand())
            {
                command.CommandText = sql;

                command.Parameters.AddWithValue(
                    "$Id",
                    id);

                using (SqliteDataReader reader =
                       command.ExecuteReader())
                {
                    CultureInfo cultura =
                        new CultureInfo("pt-BR");

                    while (reader.Read())
                    {
                        string nome =
                            reader["NomeBeneficio"]
                                ?.ToString() ?? "";

                        decimal percentual = 0;
                        decimal valor = 0;

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
                            out valor);

                        string tipo;
                        string desconto;

                        if (percentual > 0)
                        {
                            tipo =
                                percentual.ToString(
                                    "0.00",
                                    cultura) + "%";

                            desconto =
                                valor.ToString(
                                    "C2",
                                    cultura);
                        }
                        else
                        {
                            tipo =
                                "Valor fixo";

                            desconto =
                                valor.ToString(
                                    "C2",
                                    cultura);
                        }

                        dgvBeneficios.Rows.Add(
                            nome,
                            tipo,
                            desconto);
                    }
                }
            }

            dgvBeneficios.ClearSelection();
            dgvBeneficios.CurrentCell = null;
        }

        // ============================================================
        // CORES DO STATUS
        // ============================================================

        private Color ObterCorStatus(
            string status)
        {
            if (status.Equals(
                "Ativo",
                StringComparison.OrdinalIgnoreCase))
            {
                return Color.FromArgb(
                    25,
                    118,
                    80);
            }

            if (status.Equals(
                "Férias",
                StringComparison.OrdinalIgnoreCase))
            {
                return Color.FromArgb(
                    230,
                    126,
                    34);
            }

            if (status.Equals(
                "Afastado",
                StringComparison.OrdinalIgnoreCase))
            {
                return Color.FromArgb(
                    117,
                    117,
                    117);
            }

            if (status.Equals(
                "Desligado",
                StringComparison.OrdinalIgnoreCase))
            {
                return Color.FromArgb(
                    198,
                    40,
                    40);
            }

            return Color.FromArgb(
                21,
                101,
                192);
        }
    }
}