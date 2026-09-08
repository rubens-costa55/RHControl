using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;
using RHControl.Data;
using RHControl.Services;

namespace RHControl
{
    public partial class FrmFuncionarios : Form
    {
        private string filtroAtual = "Todos";

        public FrmFuncionarios()
        {
            InitializeComponent();

            // =========================================================
            // EVENTOS
            // =========================================================

            btnNovoFuncionario.Click -= BtnNovoFuncionario_Click;
            btnNovoFuncionario.Click += BtnNovoFuncionario_Click;

            Load -= FrmFuncionarios_Load;
            Load += FrmFuncionarios_Load;

            txtBusca.TextChanged -= TxtBusca_TextChanged;
            txtBusca.TextChanged += TxtBusca_TextChanged;

            btnTodos.Click -= BtnTodos_Click;
            btnTodos.Click += BtnTodos_Click;

            btnAtivos.Click -= BtnAtivos_Click;
            btnAtivos.Click += BtnAtivos_Click;

            btnFerias.Click -= BtnFerias_Click;
            btnFerias.Click += BtnFerias_Click;

            btnAfastados.Click -= BtnAfastados_Click;
            btnAfastados.Click += BtnAfastados_Click;

            btnDesligados.Click -= BtnDesligados_Click;
            btnDesligados.Click += BtnDesligados_Click;

            dgvFuncionarios.CellContentClick -= DgvFuncionarios_CellContentClick;
            dgvFuncionarios.CellContentClick += DgvFuncionarios_CellContentClick;

            dgvFuncionarios.CellFormatting -= DgvFuncionarios_CellFormatting;
            dgvFuncionarios.CellFormatting += DgvFuncionarios_CellFormatting;
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            ConfigurarTabela();

            AtualizarFiltroVisual();

            // Sincroniza automaticamente os períodos de férias
            // de acordo com a data de admissão dos funcionários.
            try
            {
                FeriasService.SincronizarFerias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível sincronizar as férias automaticamente.\n\n" +
                    "Erro: " + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            CarregarFuncionarios();
        }

        // =========================================================
        // CONFIGURAR TABELA
        // =========================================================

        private void ConfigurarTabela()
        {
            dgvFuncionarios.ClearSelection();
            dgvFuncionarios.CurrentCell = null;

            dgvFuncionarios.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 247, 250);

            dgvFuncionarios.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(45, 55, 65);

            dgvFuncionarios.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvFuncionarios.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 45, 55);

            dgvFuncionarios.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvFuncionarios.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 45, 55);
        }

        // =========================================================
        // CARREGAR FUNCIONÁRIOS
        // =========================================================

        private void CarregarFuncionarios()
        {
            try
            {
                dgvFuncionarios.Rows.Clear();

                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT
                            Id,
                            Nome,
                            CPF,
                            Cargo,
                            Setor,
                            DataAdmissao,
                            Status
                        FROM Funcionarios
                        WHERE
                            (
                                $Busca = ''
                                OR Nome LIKE $BuscaLike
                                OR CPF LIKE $BuscaLike
                                OR Cargo LIKE $BuscaLike
                                OR Setor LIKE $BuscaLike
                            )
                            AND
                            (
                                $Filtro = 'Todos'
                                OR Status = $Filtro
                            )
                        ORDER BY Nome;
                    ";

                    using (SqliteCommand command =
                           connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        string busca =
                            txtBusca.Text.Trim();

                        command.Parameters.AddWithValue(
                            "$Busca",
                            busca);

                        command.Parameters.AddWithValue(
                            "$BuscaLike",
                            "%" + busca + "%");

                        command.Parameters.AddWithValue(
                            "$Filtro",
                            filtroAtual);

                        using (SqliteDataReader reader =
                               command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                long id =
                                    Convert.ToInt64(reader["Id"]);

                                string nome =
                                    reader["Nome"]?.ToString() ?? "";

                                string cargo =
                                    reader["Cargo"]?.ToString() ?? "";

                                string setor =
                                    reader["Setor"]?.ToString() ?? "";

                                string dataAdmissao = "";

                                if (DateTime.TryParse(
                                    reader["DataAdmissao"]?.ToString(),
                                    out DateTime data))
                                {
                                    dataAdmissao =
                                        data.ToString("dd/MM/yyyy");
                                }

                                string status =
                                    reader["Status"]?.ToString() ?? "";

                                int indice =
                                    dgvFuncionarios.Rows.Add(
                                        nome,
                                        cargo,
                                        setor,
                                        dataAdmissao,
                                        status,
                                        "Editar",
                                        "Jornada",
                                        "Detalhes",
                                        "Desligar");

                                dgvFuncionarios.Rows[indice].Tag = id;
                            }
                        }
                    }
                }

                dgvFuncionarios.ClearSelection();
                dgvFuncionarios.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os funcionários.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // PESQUISA
        // =========================================================

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        // =========================================================
        // FILTROS
        // =========================================================

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            filtroAtual = "Todos";

            AtualizarFiltroVisual();
            CarregarFuncionarios();
        }

        private void BtnAtivos_Click(object sender, EventArgs e)
        {
            filtroAtual = "Ativo";

            AtualizarFiltroVisual();
            CarregarFuncionarios();
        }

        private void BtnFerias_Click(object sender, EventArgs e)
        {
            filtroAtual = "Férias";

            AtualizarFiltroVisual();
            CarregarFuncionarios();
        }

        private void BtnAfastados_Click(object sender, EventArgs e)
        {
            filtroAtual = "Afastado";

            AtualizarFiltroVisual();
            CarregarFuncionarios();
        }

        private void BtnDesligados_Click(object sender, EventArgs e)
        {
            filtroAtual = "Desligado";

            AtualizarFiltroVisual();
            CarregarFuncionarios();
        }

        // =========================================================
        // VISUAL DOS FILTROS
        // =========================================================

        private void AtualizarFiltroVisual()
        {
            ConfigurarBotaoFiltro(
                btnTodos,
                filtroAtual == "Todos");

            ConfigurarBotaoFiltro(
                btnAtivos,
                filtroAtual == "Ativo");

            ConfigurarBotaoFiltro(
                btnFerias,
                filtroAtual == "Férias");

            ConfigurarBotaoFiltro(
                btnAfastados,
                filtroAtual == "Afastado");

            ConfigurarBotaoFiltro(
                btnDesligados,
                filtroAtual == "Desligado");
        }

        private void ConfigurarBotaoFiltro(
            Button botao,
            bool ativo)
        {
            if (ativo)
            {
                botao.BackColor =
                    Color.FromArgb(21, 101, 192);

                botao.ForeColor =
                    Color.White;

                botao.FlatAppearance.BorderSize = 0;

                botao.Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold);
            }
            else
            {
                botao.BackColor =
                    Color.White;

                botao.ForeColor =
                    Color.FromArgb(50, 60, 70);

                botao.FlatAppearance.BorderColor =
                    Color.FromArgb(220, 225, 230);

                botao.FlatAppearance.BorderSize = 1;

                botao.Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Regular);
            }
        }

        // =========================================================
        // NOVO FUNCIONÁRIO
        // =========================================================

        private void BtnNovoFuncionario_Click(
            object sender,
            EventArgs e)
        {
            using (FrmCadastroFuncionario cadastro =
                   new FrmCadastroFuncionario())
            {
                cadastro.ShowDialog(this);
            }

            // Depois de cadastrar, gera os períodos de férias
            // automaticamente pela data de admissão.
            try
            {
                FeriasService.SincronizarFerias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "O funcionário foi salvo, mas não foi possível " +
                    "sincronizar as férias.\n\n" +
                    "Erro: " + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            CarregarFuncionarios();
        }

        // =========================================================
        // AÇÕES DA TABELA
        // =========================================================

        private void DgvFuncionarios_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.RowIndex >= dgvFuncionarios.Rows.Count)
                return;

            DataGridViewRow linha =
                dgvFuncionarios.Rows[e.RowIndex];

            if (linha.Tag == null)
                return;

            long funcionarioId =
                Convert.ToInt64(linha.Tag);

            // =====================================================
            // EDITAR
            // =====================================================

            if (e.ColumnIndex == colEditar.Index)
            {
                using (FrmCadastroFuncionario cadastro =
                       new FrmCadastroFuncionario(funcionarioId))
                {
                    cadastro.ShowDialog(this);
                }

                try
                {
                    FeriasService.SincronizarFerias();
                }
                catch
                {
                    // O cadastro já foi realizado.
                    // A sincronização será tentada novamente
                    // na próxima abertura da tela.
                }

                CarregarFuncionarios();

                return;
            }

            // =====================================================
            // JORNADA
            // =====================================================

            if (e.ColumnIndex == colJornada.Index)
            {
                FrmJornada jornada =
                    new FrmJornada();

                jornada.FormClosed += (s, args) =>
                {
                    this.Show();
                    CarregarFuncionarios();
                };

                this.Hide();
                jornada.Show();

                return;
            }

            // =====================================================
            // DETALHES
            // =====================================================

            if (e.ColumnIndex == colDetalhes.Index)
            {
                try
                {
                    FrmDetalhesFuncionario detalhes =
                        new FrmDetalhesFuncionario(funcionarioId);

                    detalhes.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível abrir os detalhes do funcionário.\n\n" +
                        "Erro: " + ex.Message,
                        "RH Control",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                return;
            }

            // =====================================================
            // DESLIGAR
            // =====================================================

            if (e.ColumnIndex == colDesligar.Index)
            {
                string nome =
                    linha.Cells[colNome.Index]
                        .Value?.ToString() ?? "";

                DesligarFuncionario(
                    funcionarioId,
                    nome);

                return;
            }
        }

        // =========================================================
        // DESLIGAR FUNCIONÁRIO
        // =========================================================

        private void DesligarFuncionario(
            long funcionarioId,
            string nome)
        {
            DialogResult resposta =
                MessageBox.Show(
                    "Deseja realmente desligar o funcionário?\n\n" +
                    nome +
                    "\n\n" +
                    "O cadastro será mantido no sistema e o status " +
                    "será alterado para \"Desligado\".",
                    "Confirmar desligamento",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            try
            {
                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        UPDATE Funcionarios
                        SET
                            Status = 'Desligado',
                            DataDesligamento = $DataDesligamento
                        WHERE Id = $Id;
                    ";

                    using (SqliteCommand command =
                           connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        command.Parameters.AddWithValue(
                            "$Id",
                            funcionarioId);

                        command.Parameters.AddWithValue(
                            "$DataDesligamento",
                            DateTime.Now.ToString("yyyy-MM-dd"));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Funcionário desligado com sucesso.",
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CarregarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível desligar o funcionário.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CORES DO STATUS
        // =========================================================

        private void DgvFuncionarios_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex != colStatus.Index)
                return;

            string status =
                e.Value?.ToString() ?? "";

            if (status.Equals(
                "Ativo",
                StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor =
                    Color.FromArgb(25, 118, 80);
            }
            else if (status.Equals(
                "Férias",
                StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor =
                    Color.FromArgb(230, 126, 34);
            }
            else if (status.Equals(
                "Afastado",
                StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor =
                    Color.FromArgb(117, 117, 117);
            }
            else if (status.Equals(
                "Desligado",
                StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor =
                    Color.FromArgb(198, 40, 40);
            }
        }
    }
}