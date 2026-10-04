using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Forms;
using RHControl.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

            dgvFuncionarios.CellMouseUp -= DgvFuncionarios_CellMouseUp;
            dgvFuncionarios.CellMouseUp += DgvFuncionarios_CellMouseUp;

            dgvFuncionarios.CellFormatting -= DgvFuncionarios_CellFormatting;
            dgvFuncionarios.CellFormatting += DgvFuncionarios_CellFormatting;

            AplicarPermissoes();

            btnSair.Click -= BtnSair_Click;
            btnSair.Click += BtnSair_Click;

            btnDashboard.Click -= BtnDashboard_Click;
            btnDashboard.Click += BtnDashboard_Click;

            btnJornada.Click -= BtnJornadaMenu_Click;
            btnJornada.Click += BtnJornadaMenu_Click;

            btnFolha.Click -= BtnFolhaMenu_Click;
            btnFolha.Click += BtnFolhaMenu_Click;

            btnConfiguracoes.Click -= BtnConfiguracoesMenu_Click;
            btnConfiguracoes.Click += BtnConfiguracoesMenu_Click;
        }

        // =========================================================
        // PERMISSÕES
        // =========================================================

        private void AplicarPermissoes()
        {
            bool administrador = SessaoUsuario.EhAdministrador;

            // Corrige a largura do cabeçalho para acompanhar
            // exatamente a área disponível da tela.
            if (pnlCabecalho != null && pnlConteudo != null)
            {
                pnlCabecalho.Size =
                    new Size(pnlConteudo.ClientSize.Width, 112);
            }

            if (lblUsuario != null)
            {
                lblUsuario.AutoSize = false;

                lblUsuario.Font =
                    new Font("Segoe UI Semibold", 9F);

                lblUsuario.ForeColor =
                    Color.FromArgb(18, 103, 181);

                lblUsuario.Text =
                    administrador
                        ? "♙  Administrador"
                        : "♙  Usuário";

                lblUsuario.TextAlign =
                    ContentAlignment.MiddleRight;

                lblUsuario.Anchor =
                    AnchorStyles.Top |
                    AnchorStyles.Right;

                lblUsuario.Size =
                    new Size(180, 24);

                lblUsuario.Location =
                    new Point(
                        pnlCabecalho.ClientSize.Width - 205,
                        34);
            }

            btnNovoFuncionario.Visible = administrador;
            btnNovoFuncionario.Enabled = administrador;

            colEditar.Visible = administrador;
            colJornada.Visible = administrador;
            colFerias.Visible = administrador;
            colDesligar.Visible = administrador;

            colDetalhes.Visible = true;
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = Application.OpenForms
                .OfType<FrmDashboard>()
                .FirstOrDefault();

            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new FrmDashboard();
            }

            dashboard.Show();
            dashboard.BringToFront();
            Hide();
        }

        private void BtnJornadaMenu_Click(object sender, EventArgs e)
        {
            AbrirMenuForm(new FrmJornada());
        }

        private void BtnFolhaMenu_Click(object sender, EventArgs e)
        {
            AbrirMenuForm(new FrmFolhaPagamento());
        }

        private void BtnConfiguracoesMenu_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeConfigurar)
            {
                MessageBox.Show(
                    "O acesso às Configurações é exclusivo do Administrador.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            AbrirMenuForm(new FrmConfiguracoes());
        }

        private void AbrirMenuForm(Form form)
        {
            form.FormClosed += (s, args) =>
            {
                if (SessaoUsuario.Id > 0 && !IsDisposed)
                {
                    Show();
                    BringToFront();
                }
            };

            Hide();
            form.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair do RH Control?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            SessaoUsuario.Encerrar();

            FrmLogin login = Application.OpenForms
                .OfType<FrmLogin>()
                .FirstOrDefault();

            if (login == null || login.IsDisposed)
                login = new FrmLogin();

            login.Show();
            login.BringToFront();

            // Fecha o Dashboard antigo, se existir, e esta tela.
            // O Login não será fechado porque a sessão já foi encerrada.
            FrmDashboard dashboard = Application.OpenForms
                .OfType<FrmDashboard>()
                .FirstOrDefault();

            if (dashboard != null && !dashboard.IsDisposed)
            {
                dashboard.Close();
            }

            Close();
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

            AtualizarResumo();
            CarregarFuncionarios();
        }

        // =========================================================
        // ATUALIZAR RESUMO DOS FUNCIONÁRIOS
        // =========================================================

        private void AtualizarResumo()
        {
            try
            {
                using (SqliteConnection connection =
                       Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT
                            COUNT(*) AS Total,
                            COALESCE(SUM(CASE WHEN Status = 'Ativo' THEN 1 ELSE 0 END), 0) AS Ativos,
                            COALESCE(SUM(CASE WHEN Status = 'Férias' THEN 1 ELSE 0 END), 0) AS Ferias,
                            COALESCE(SUM(CASE WHEN Status = 'Afastado' THEN 1 ELSE 0 END), 0) AS Afastados,
                            COALESCE(SUM(CASE WHEN Status = 'Desligado' THEN 1 ELSE 0 END), 0) AS Desligados
                        FROM Funcionarios;
                    ";

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblResumoTotal.Text =
                                    Convert.ToInt32(reader["Total"]).ToString();

                                lblResumoAtivos.Text =
                                    Convert.ToInt32(reader["Ativos"]).ToString();

                                lblResumoFerias.Text =
                                    Convert.ToInt32(reader["Ferias"]).ToString();

                                lblResumoAfastados.Text =
                                    Convert.ToInt32(reader["Afastados"]).ToString();

                                lblResumoDesligados.Text =
                                    Convert.ToInt32(reader["Desligados"]).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mantém a tela funcionando mesmo se o resumo não puder ser calculado.
                // Os números ficam em zero até a próxima atualização bem-sucedida.
                lblResumoTotal.Text = "0";
                lblResumoAtivos.Text = "0";
                lblResumoFerias.Text = "0";
                lblResumoAfastados.Text = "0";
                lblResumoDesligados.Text = "0";
            }
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

            // Cores das ações: cada ação possui uma cor própria.
            // Mantemos também a seleção da célula com a mesma cor para
            // evitar o efeito visual de botão mudando de cor ao clicar.
            colEditar.DefaultCellStyle = CriarEstiloAcao(
                Color.FromArgb(20, 125, 235));

            colJornada.DefaultCellStyle = CriarEstiloAcao(
                Color.FromArgb(111, 66, 193));

            colFerias.DefaultCellStyle = CriarEstiloAcao(
                Color.FromArgb(230, 145, 20));

            colDetalhes.DefaultCellStyle = CriarEstiloAcao(
                Color.FromArgb(72, 92, 112));

            colDesligar.DefaultCellStyle = CriarEstiloAcao(
                Color.FromArgb(198, 40, 40));

            // Cabeçalhos das colunas de ação nunca devem assumir a cor
            // de seleção padrão do DataGridView ao clicar em uma ação.
            Color corCabecalho = Color.FromArgb(245, 247, 250);
            Color corTextoCabecalho = Color.FromArgb(45, 55, 65);

            foreach (DataGridViewColumn coluna in new DataGridViewColumn[]
            {
                colEditar,
                colJornada,
                colFerias,
                colDetalhes,
                colDesligar
            })
            {
                coluna.HeaderCell.Style.BackColor = corCabecalho;
                coluna.HeaderCell.Style.ForeColor = corTextoCabecalho;
                coluna.HeaderCell.Style.SelectionBackColor = corCabecalho;
                coluna.HeaderCell.Style.SelectionForeColor = corTextoCabecalho;
            }
        }

        private DataGridViewCellStyle CriarEstiloAcao(Color cor)
        {
            return new DataGridViewCellStyle
            {
                BackColor = cor,
                ForeColor = Color.White,
                SelectionBackColor = cor,
                SelectionForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
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
                                        "Férias",
                                        "Detalhes",
                                        "Desligar");

                                dgvFuncionarios.Rows[indice].Tag = id;
                            }
                        }
                    }
                }

                dgvFuncionarios.ClearSelection();
                dgvFuncionarios.CurrentCell = null;

                // Atualiza os indicadores gerais, independentemente do filtro selecionado.
                AtualizarResumo();
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
            if (!SessaoUsuario.EhAdministrador)
            {
                MessageBox.Show(
                    "Seu perfil possui acesso somente para visualização dos funcionários.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

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
            // ALTERAR STATUS
            // =====================================================

            if (e.ColumnIndex == colStatus.Index)
            {
                AlterarStatusFuncionario(funcionarioId, linha);
                return;
            }

            // =====================================================
            // EDITAR
            // =====================================================

            if (e.ColumnIndex == colEditar.Index)
            {
                if (!SessaoUsuario.EhAdministrador)
                {
                    MessageBox.Show(
                        "Seu perfil não possui permissão para editar funcionários.",
                        "Acesso restrito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

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
                if (!SessaoUsuario.EhAdministrador)
                {
                    MessageBox.Show(
                        "Seu perfil não possui permissão para abrir a jornada por esta tela.",
                        "Acesso restrito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

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
            // FÉRIAS
            // =====================================================

            if (e.ColumnIndex == colFerias.Index)
            {
                if (!SessaoUsuario.EhAdministrador)
                {
                    MessageBox.Show(
                        "Seu perfil não possui permissão para programar férias.",
                        "Acesso restrito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                string nome =
                    linha.Cells[colNome.Index]
                        .Value?.ToString() ?? "Funcionário";

                string status =
                    linha.Cells[colStatus.Index]
                        .Value?.ToString() ?? "";

                if (string.Equals(
                    status,
                    "Desligado",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Este funcionário está desligado.\n\n" +
                        "Não é possível programar ou alterar férias para um funcionário desligado.",
                        "Funcionário desligado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    dgvFuncionarios.ClearSelection();
                    dgvFuncionarios.CurrentCell = null;
                    return;
                }

                ProgramarFeriasFuncionario(
                    funcionarioId,
                    nome);

                dgvFuncionarios.ClearSelection();
                dgvFuncionarios.CurrentCell = null;

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
                if (!SessaoUsuario.EhAdministrador)
                {
                    MessageBox.Show(
                        "Seu perfil não possui permissão para desligar funcionários.",
                        "Acesso restrito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

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
        // ALTERAR STATUS
        // =========================================================

        private void AlterarStatusFuncionario(
            long funcionarioId,
            DataGridViewRow linha)
        {
            if (!SessaoUsuario.EhAdministrador)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para alterar o status de funcionários.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string nome = linha.Cells[colNome.Index].Value?.ToString() ?? "Funcionário";
            string statusAtual = linha.Cells[colStatus.Index].Value?.ToString() ?? "Ativo";

            using Form dialogo = new Form
            {
                Text = "Alterar status",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(420, 190),
                BackColor = Color.FromArgb(244, 247, 251)
            };

            Label lblFuncionario = new Label
            {
                AutoSize = false,
                Location = new Point(25, 20),
                Size = new Size(370, 25),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(14, 48, 82),
                Text = nome
            };

            Label lblStatus = new Label
            {
                AutoSize = true,
                Location = new Point(25, 58),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(70, 85, 100),
                Text = "Novo status:"
            };

            ComboBox cmbStatus = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(120, 54),
                Size = new Size(245, 28),
                Font = new Font("Segoe UI", 9.5F)
            };

            cmbStatus.Items.AddRange(new object[]
            {
                "Ativo",
                "Férias",
                "Afastado",
                "Desligado"
            });

            int indiceAtual = cmbStatus.Items.IndexOf(statusAtual);
            cmbStatus.SelectedIndex = indiceAtual >= 0 ? indiceAtual : 0;

            Label lblAjuda = new Label
            {
                AutoSize = false,
                Location = new Point(25, 90),
                Size = new Size(390, 24),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(105, 120, 135),
                Text = "Férias altera o status. O período de férias será definido no controle de férias."
            };

            Button btnSalvar = CriarBotaoDialogo("Salvar", new Point(235, 125), true);
            Button btnCancelar = CriarBotaoDialogo("Cancelar", new Point(320, 125), false);

            btnSalvar.Click += (s, e) =>
            {
                string novoStatus = cmbStatus.SelectedItem?.ToString() ?? statusAtual;

                if (novoStatus == statusAtual)
                {
                    dialogo.DialogResult = DialogResult.Cancel;
                    dialogo.Close();
                    return;
                }

                try
                {
                    using SqliteConnection connection = Database.GetConnection();
                    connection.Open();

                    string sql = novoStatus == "Desligado"
                        ? @"
                            UPDATE Funcionarios
                            SET Status = $Status,
                                DataDesligamento = $DataDesligamento
                            WHERE Id = $Id;"
                        : @"
                            UPDATE Funcionarios
                            SET Status = $Status,
                                DataDesligamento = NULL
                            WHERE Id = $Id;";

                    using SqliteCommand command = connection.CreateCommand();
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("$Status", novoStatus);
                    command.Parameters.AddWithValue("$Id", funcionarioId);

                    if (novoStatus == "Desligado")
                    {
                        command.Parameters.AddWithValue(
                            "$DataDesligamento",
                            DateTime.Now.ToString("yyyy-MM-dd"));
                    }

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível alterar o status.\n\n" +
                        "Erro: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                dialogo.DialogResult = DialogResult.OK;
                dialogo.Close();
            };

            btnCancelar.Click += (s, e) =>
            {
                dialogo.DialogResult = DialogResult.Cancel;
                dialogo.Close();
            };

            dialogo.Controls.Add(lblFuncionario);
            dialogo.Controls.Add(lblStatus);
            dialogo.Controls.Add(cmbStatus);
            dialogo.Controls.Add(lblAjuda);
            dialogo.Controls.Add(btnSalvar);
            dialogo.Controls.Add(btnCancelar);

            dialogo.AcceptButton = btnSalvar;
            dialogo.CancelButton = btnCancelar;

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                AtualizarResumo();
                CarregarFuncionarios();
            }
        }

        private Button CriarBotaoDialogo(
            string texto,
            Point local,
            bool principal)
        {
            Color cor = principal
                ? Color.FromArgb(20, 125, 235)
                : Color.FromArgb(105, 120, 135);

            Button botao = new Button
            {
                Text = texto,
                Location = local,
                Size = new Size(80, 36),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BackColor = cor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            botao.FlatAppearance.BorderSize = 0;
            return botao;
        }

        // =========================================================
        // FÉRIAS
        // =========================================================

        private void ProgramarFeriasFuncionario(
            long funcionarioId,
            string nome)
        {
            if (!SessaoUsuario.EhAdministrador)
                return;

            using Form dialogo = new Form
            {
                Text = "Programar férias",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = new Size(440, 275),
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            Label titulo = new Label
            {
                AutoSize = false,
                Location = new Point(20, 18),
                Size = new Size(395, 28),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(14, 48, 82),
                Text = "Programar férias"
            };

            Label lblNome = new Label
            {
                AutoSize = false,
                Location = new Point(20, 48),
                Size = new Size(395, 24),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(90, 105, 120),
                Text = nome
            };

            Label lblInicio = new Label
            {
                AutoSize = true,
                Location = new Point(20, 88),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(55, 65, 75),
                Text = "Início:"
            };

            DateTimePicker dtInicio = new DateTimePicker
            {
                Location = new Point(85, 84),
                Size = new Size(150, 28),
                Format = DateTimePickerFormat.Short,
                Font = new Font("Segoe UI", 9F)
            };

            Label lblFim = new Label
            {
                AutoSize = true,
                Location = new Point(20, 128),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(55, 65, 75),
                Text = "Fim:"
            };

            DateTimePicker dtFim = new DateTimePicker
            {
                Location = new Point(85, 124),
                Size = new Size(150, 28),
                Format = DateTimePickerFormat.Short,
                Font = new Font("Segoe UI", 9F),
                Value = DateTime.Today.AddDays(14)
            };

            Label info = new Label
            {
                AutoSize = false,
                Location = new Point(20, 165),
                Size = new Size(395, 45),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(95, 115, 135),
                Text = "O período ficará registrado no histórico de férias.\n" +
                       "O status será 'Férias' somente durante o período informado."
            };

            Button btnSalvar = new Button
            {
                Text = "Salvar férias",
                Location = new Point(220, 220),
                Size = new Size(105, 36),
                BackColor = Color.FromArgb(230, 126, 34),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnSalvar.FlatAppearance.BorderSize = 0;

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(335, 220),
                Size = new Size(80, 36),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(70, 80, 90),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(210, 220, 230);

            dialogo.Controls.AddRange(new Control[]
            {
                titulo,
                lblNome,
                lblInicio,
                dtInicio,
                lblFim,
                dtFim,
                info,
                btnSalvar,
                btnCancelar
            });

            dialogo.AcceptButton = btnSalvar;
            dialogo.CancelButton = btnCancelar;

            if (dialogo.ShowDialog(this) != DialogResult.OK)
                return;

            DateTime inicio = dtInicio.Value.Date;
            DateTime fim = dtFim.Value.Date;

            if (fim < inicio)
            {
                MessageBox.Show(
                    "A data final das férias não pode ser anterior à data inicial.",
                    "Férias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int dias = (fim - inicio).Days + 1;

            try
            {
                using SqliteConnection connection = Database.GetConnection();
                connection.Open();

                // Usa primeiro um período ainda sem datas de férias.
                long feriasId = 0;

                using (SqliteCommand localizar = connection.CreateCommand())
                {
                    localizar.CommandText = @"
                        SELECT Id
                        FROM Ferias
                        WHERE FuncionarioId = $FuncionarioId
                          AND (InicioFerias IS NULL OR TRIM(InicioFerias) = '')
                        ORDER BY DataDireito
                        LIMIT 1;";

                    localizar.Parameters.AddWithValue("$FuncionarioId", funcionarioId);
                    object resultado = localizar.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                        feriasId = Convert.ToInt64(resultado);
                }

                // Caso todos os períodos já estejam usados, cria um novo ciclo
                // anual a partir do último período cadastrado.
                if (feriasId == 0)
                {
                    DateTime dataAdmissao = DateTime.Today;

                    using (SqliteCommand cmdAdmissao = connection.CreateCommand())
                    {
                        cmdAdmissao.CommandText = @"
                            SELECT DataAdmissao
                            FROM Funcionarios
                            WHERE Id = $Id
                            LIMIT 1;";
                        cmdAdmissao.Parameters.AddWithValue("$Id", funcionarioId);
                        object resultado = cmdAdmissao.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value &&
                            DateTime.TryParse(resultado.ToString(), out DateTime admissao))
                        {
                            dataAdmissao = admissao.Date;
                        }
                    }

                    DateTime inicioAquisitivo = dataAdmissao.AddYears(Math.Max(0, DateTime.Today.Year - dataAdmissao.Year));
                    DateTime fimAquisitivo = inicioAquisitivo.AddYears(1).AddDays(-1);
                    DateTime dataDireito = fimAquisitivo.AddDays(1);
                    DateTime inicioConcessivo = dataDireito;
                    DateTime fimConcessivo = dataDireito.AddYears(1).AddDays(-1);

                    using (SqliteCommand inserir = connection.CreateCommand())
                    {
                        inserir.CommandText = @"
                            INSERT INTO Ferias
                            (FuncionarioId, InicioAquisitivo, FimAquisitivo, DataDireito,
                             InicioConcessivo, FimConcessivo, InicioFerias, FimFerias,
                             Dias, Status, Observacoes, CriadoEm)
                            VALUES
                            ($FuncionarioId, $InicioAquisitivo, $FimAquisitivo, $DataDireito,
                             $InicioConcessivo, $FimConcessivo, NULL, NULL, NULL,
                             'Em aquisição', NULL, $CriadoEm);
                            SELECT last_insert_rowid();";

                        inserir.Parameters.AddWithValue("$FuncionarioId", funcionarioId);
                        inserir.Parameters.AddWithValue("$InicioAquisitivo", inicioAquisitivo.ToString("yyyy-MM-dd"));
                        inserir.Parameters.AddWithValue("$FimAquisitivo", fimAquisitivo.ToString("yyyy-MM-dd"));
                        inserir.Parameters.AddWithValue("$DataDireito", dataDireito.ToString("yyyy-MM-dd"));
                        inserir.Parameters.AddWithValue("$InicioConcessivo", inicioConcessivo.ToString("yyyy-MM-dd"));
                        inserir.Parameters.AddWithValue("$FimConcessivo", fimConcessivo.ToString("yyyy-MM-dd"));
                        inserir.Parameters.AddWithValue("$CriadoEm", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        feriasId = Convert.ToInt64(inserir.ExecuteScalar());
                    }
                }

                using (SqliteCommand atualizar = connection.CreateCommand())
                {
                    atualizar.CommandText = @"
                        UPDATE Ferias
                        SET InicioFerias = $Inicio,
                            FimFerias = $Fim,
                            Dias = $Dias,
                            Status = 'Programadas',
                            AtualizadoEm = $AtualizadoEm
                        WHERE Id = $Id;";

                    atualizar.Parameters.AddWithValue("$Inicio", inicio.ToString("yyyy-MM-dd"));
                    atualizar.Parameters.AddWithValue("$Fim", fim.ToString("yyyy-MM-dd"));
                    atualizar.Parameters.AddWithValue("$Dias", dias);
                    atualizar.Parameters.AddWithValue("$AtualizadoEm", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    atualizar.Parameters.AddWithValue("$Id", feriasId);
                    atualizar.ExecuteNonQuery();
                }

                string statusNovo = inicio <= DateTime.Today && DateTime.Today <= fim
                    ? "Férias"
                    : "Ativo";

                using (SqliteCommand status = connection.CreateCommand())
                {
                    status.CommandText = @"
                        UPDATE Funcionarios
                        SET Status = $Status,
                            AtualizadoEm = $AtualizadoEm
                        WHERE Id = $Id;";

                    status.Parameters.AddWithValue("$Status", statusNovo);
                    status.Parameters.AddWithValue("$AtualizadoEm", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    status.Parameters.AddWithValue("$Id", funcionarioId);
                    status.ExecuteNonQuery();
                }

                MessageBox.Show(
                    $"Férias cadastradas com sucesso.\n\nPeríodo: {inicio:dd/MM/yyyy} a {fim:dd/MM/yyyy} ({dias} dias).",
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CarregarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível programar as férias.\n\n" +
                    "Erro: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DESLIGAR FUNCIONÁRIO
        // =========================================================

        private void DesligarFuncionario(
            long funcionarioId,
            string nome)
        {
            if (!SessaoUsuario.EhAdministrador)
                return;

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

        private void DgvFuncionarios_CellMouseUp(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            // A grade não deve permanecer com uma linha inteira selecionada
            // depois de clicar em uma ação ou em um funcionário.
            if (e.RowIndex >= 0)
            {
                BeginInvoke(new Action(() =>
                {
                    if (!IsDisposed && dgvFuncionarios != null)
                    {
                        dgvFuncionarios.ClearSelection();
                        dgvFuncionarios.CurrentCell = null;
                    }
                }));
            }
        }

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