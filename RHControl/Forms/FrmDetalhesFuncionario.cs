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
        // FORMULÁRIO
        // ============================================================

        private void ConfigurarFormulario()
        {
            Text = "RH Control — Detalhes do Funcionário";

            StartPosition =
                FormStartPosition.CenterParent;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;
            MinimizeBox = false;

            ClientSize =
                new Size(950, 700);

            BackColor =
                Color.FromArgb(245, 247, 250);

            // ========================================================
            // CABEÇALHO
            // ========================================================

            pnlCabecalho = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(950, 90),
                BackColor = Color.White
            };

            Controls.Add(pnlCabecalho);

            lblTitulo = new Label
            {
                AutoSize = true,
                Location = new Point(30, 20),
                Font = new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(35, 45, 55),
                Text = "Detalhes do funcionário"
            };

            pnlCabecalho.Controls.Add(lblTitulo);

            lblSubtitulo = new Label
            {
                AutoSize = true,
                Location = new Point(32, 56),
                Font = new Font(
                    "Segoe UI",
                    9F),
                ForeColor =
                    Color.FromArgb(100, 110, 120),
                Text = "Visualização dos dados cadastrados"
            };

            pnlCabecalho.Controls.Add(lblSubtitulo);

            lblStatus = new Label
            {
                AutoSize = true,
                Location = new Point(800, 35),
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(25, 118, 80),
                Text = "Ativo"
            };

            pnlCabecalho.Controls.Add(lblStatus);

            // ========================================================
            // ÁREA DE CONTEÚDO
            // ========================================================

            pnlConteudo = new Panel
            {
                Location = new Point(20, 105),
                Size = new Size(910, 535),
                BackColor = Color.White,
                AutoScroll = true
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
                Location = new Point(810, 650),
                Size = new Size(120, 38),
                Text = "Fechar",
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold),
                BackColor =
                    Color.FromArgb(21, 101, 192),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnFechar.FlatAppearance.BorderSize = 0;

            btnFechar.Click +=
                (s, e) => Close();

            Controls.Add(btnFechar);
        }

        // ============================================================
        // GRUPO PESSOAL
        // ============================================================

        private void CriarGrupoPessoal()
        {
            grpPessoal = CriarGroupBox(
                "Dados pessoais",
                new Point(20, 20),
                new Size(850, 125));

            pnlConteudo.Controls.Add(grpPessoal);

            lblNome = CriarLabel(
                "Nome:",
                new Point(20, 32));

            lblCPF = CriarLabel(
                "CPF:",
                new Point(430, 32));

            lblNascimento = CriarLabel(
                "Nascimento:",
                new Point(20, 72));

            lblTelefone = CriarLabel(
                "Telefone:",
                new Point(430, 72));

            lblEmail = CriarLabel(
                "E-mail:",
                new Point(20, 102));

            grpPessoal.Controls.Add(lblNome);
            grpPessoal.Controls.Add(lblCPF);
            grpPessoal.Controls.Add(lblNascimento);
            grpPessoal.Controls.Add(lblTelefone);
            grpPessoal.Controls.Add(lblEmail);
        }

        // ============================================================
        // GRUPO PROFISSIONAL
        // ============================================================

        private void CriarGrupoProfissional()
        {
            grpProfissional = CriarGroupBox(
                "Dados profissionais",
                new Point(20, 155),
                new Size(850, 135));

            pnlConteudo.Controls.Add(grpProfissional);

            lblCargo = CriarLabel(
                "Cargo:",
                new Point(20, 32));

            lblSetor = CriarLabel(
                "Setor:",
                new Point(430, 32));

            lblAdmissao = CriarLabel(
                "Data de admissão:",
                new Point(20, 72));

            lblSalario = CriarLabel(
                "Salário:",
                new Point(430, 72));

            lblEscala = CriarLabel(
                "Escala:",
                new Point(20, 105));

            grpProfissional.Controls.Add(lblCargo);
            grpProfissional.Controls.Add(lblSetor);
            grpProfissional.Controls.Add(lblAdmissao);
            grpProfissional.Controls.Add(lblSalario);
            grpProfissional.Controls.Add(lblEscala);
        }

        // ============================================================
        // GRUPO JORNADA
        // ============================================================

        private void CriarGrupoJornada()
        {
            grpJornada = CriarGroupBox(
                "Jornada de trabalho",
                new Point(20, 300),
                new Size(850, 105));

            pnlConteudo.Controls.Add(grpJornada);

            lblCargaHoraria = CriarLabel(
                "Carga horária:",
                new Point(20, 32));

            lblEntrada = CriarLabel(
                "Entrada:",
                new Point(220, 32));

            lblSaida = CriarLabel(
                "Saída:",
                new Point(420, 32));

            lblIntervalo = CriarLabel(
                "Intervalo:",
                new Point(600, 32));

            grpJornada.Controls.Add(lblCargaHoraria);
            grpJornada.Controls.Add(lblEntrada);
            grpJornada.Controls.Add(lblSaida);
            grpJornada.Controls.Add(lblIntervalo);
        }

        // ============================================================
        // GRUPO BENEFÍCIOS
        // ============================================================

        private void CriarGrupoBeneficios()
        {
            grpBeneficios = CriarGroupBox(
                "Benefícios e descontos",
                new Point(20, 415),
                new Size(850, 150));

            pnlConteudo.Controls.Add(grpBeneficios);

            dgvBeneficios = new DataGridView
            {
                Location = new Point(15, 28),
                Size = new Size(815, 105),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                RowHeadersVisible = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal,
                EnableHeadersVisualStyles = false
            };

            dgvBeneficios.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 250);

            dgvBeneficios.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(45, 55, 65);

            dgvBeneficios.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    8.5F,
                    FontStyle.Bold);

            dgvBeneficios.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            dgvBeneficios.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvBeneficios.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 45, 55);

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
        // GRUPO OBSERVAÇÕES
        // ============================================================

        private void CriarGrupoObservacoes()
        {
            grpObservacoes = CriarGroupBox(
                "Observações",
                new Point(20, 575),
                new Size(850, 100));

            pnlConteudo.Controls.Add(grpObservacoes);

            txtObservacoes = new TextBox
            {
                Location = new Point(15, 28),
                Size = new Size(815, 55),
                Multiline = true,
                ReadOnly = true,
                BackColor = Color.FromArgb(250, 251, 253),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font(
                    "Segoe UI",
                    9F)
            };

            grpObservacoes.Controls.Add(
                txtObservacoes);
        }

        // ============================================================
        // COMPONENTES AUXILIARES
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
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold),
                ForeColor =
                    Color.FromArgb(35, 45, 55)
            };
        }

        private Label CriarLabel(
            string texto,
            Point local)
        {
            return new Label
            {
                AutoSize = true,
                Location = local,
                Font = new Font(
                    "Segoe UI",
                    9F),
                ForeColor =
                    Color.FromArgb(55, 65, 75),
                Text = texto
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

                            lblNome.Text =
                                "Nome: " + nome;

                            lblCPF.Text =
                                "CPF: " + cpf;

                            lblTelefone.Text =
                                "Telefone: " + telefone;

                            lblEmail.Text =
                                "E-mail: " + email;

                            lblCargo.Text =
                                "Cargo: " + cargo;

                            lblSetor.Text =
                                "Setor: " + setor;

                            lblEscala.Text =
                                "Escala: " + escala;

                            lblStatus.Text =
                                string.IsNullOrWhiteSpace(status)
                                    ? "Sem status"
                                    : status;

                            lblStatus.ForeColor =
                                ObterCorStatus(status);

                            // --------------------------------------------
                            // DATAS
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
                            // JORNADA
                            // --------------------------------------------

                            lblCargaHoraria.Text =
                                "Carga horária: " +
                                (reader["CargaHorariaSemanal"]
                                    ?.ToString() ?? "—") +
                                "h/semana";

                            string entrada =
                                reader["HorarioEntrada"]
                                    ?.ToString() ?? "";

                            string saida =
                                reader["HorarioSaida"]
                                    ?.ToString() ?? "";

                            string inicioIntervalo =
                                reader["InicioIntervalo"]
                                    ?.ToString() ?? "";

                            string fimIntervalo =
                                reader["FimIntervalo"]
                                    ?.ToString() ?? "";

                            lblEntrada.Text =
                                "Entrada: " +
                                (string.IsNullOrWhiteSpace(entrada)
                                    ? "—"
                                    : entrada);

                            lblSaida.Text =
                                "Saída: " +
                                (string.IsNullOrWhiteSpace(saida)
                                    ? "—"
                                    : saida);

                            lblIntervalo.Text =
                                "Intervalo: " +
                                (string.IsNullOrWhiteSpace(
                                    inicioIntervalo)
                                    ? "—"
                                    : inicioIntervalo +
                                      " às " +
                                      fimIntervalo);

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
        // BENEFÍCIOS
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
        // COR DO STATUS
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