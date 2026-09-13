using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;

namespace RHControl.Forms
{
    public partial class FrmConfiguracoes : Form
    {
        private string? caminhoLogoSelecionado;

        public FrmConfiguracoes()
        {
            if (!SessaoUsuario.EhAdministrador)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para acessar as Configurações.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                BeginInvoke(new Action(Close));
                return;
            }

            InitializeComponent();

            try
            {
                // Mantém a logo no executável mesmo que o Designer não a carregue.
                picLogoSistema.Image = RHControl.Properties.Resources.logorh;
            }
            catch { }

            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            Load += FrmConfiguracoes_Load;

            btnSalvar.Click += BtnSalvar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnSelecionarLogo.Click += BtnSelecionarLogo_Click;
            btnRemoverLogo.Click += BtnRemoverLogo_Click;
            btnEditarResumo.Click += BtnEditarResumo_Click;
            btnExcluirResumo.Click += BtnExcluirResumo_Click;
            rdbBeneficioPercentual.CheckedChanged += (s, e) => AtualizarRotulosAdicionais();
            rdbBeneficioValor.CheckedChanged += (s, e) => AtualizarRotulosAdicionais();
            rdbDescontoPercentual.CheckedChanged += (s, e) => AtualizarRotulosAdicionais();
            rdbDescontoValor.CheckedChanged += (s, e) => AtualizarRotulosAdicionais();
            dgvResumoFolha.SelectionChanged += (s, e) => AtualizarEstadoBotoesResumo();

            btnDashboard.Click += (s, e) => AbrirTela(new FrmDashboard());
            btnFuncionarios.Click += (s, e) => AbrirTela(new FrmFuncionarios());
            btnJornada.Click += (s, e) => AbrirTela(new FrmJornada());
            btnFolha.Click += (s, e) => AbrirTela(new FrmFolhaPagamento());

            btnAbaEmpresa.Click += (s, e) => SelecionarAba(0);
            btnAbaFolha.Click += (s, e) => SelecionarAba(1);
            btnAbaSistema.Click += (s, e) => SelecionarAba(2);
            btnAbaUsuario.Click += (s, e) => SelecionarAba(3);
            btnAbaBackup.Click += (s, e) => SelecionarAba(4);

            btnNovaConta.Click += BtnNovaConta_Click;
            btnEditarUsuario.Click += BtnEditarUsuario_Click;
            btnInativarUsuario.Click += BtnInativarUsuario_Click;
            btnExcluirUsuario.Click += BtnExcluirUsuario_Click;
            dgvUsuarios.SelectionChanged += (s, e) => AtualizarEstadoBotoesUsuarios();
        }

        private void FrmConfiguracoes_Load(object? sender, EventArgs e)
        {
            CarregarConfiguracoes();
            AtualizarResumoFolha();
            CarregarUsuarios();
            AplicarPermissoesUsuarios();
            AtualizarEstadoBotoesUsuarios();
            SelecionarAba(0);
        }

        private void SelecionarAba(int indice)
        {
            pnlEmpresa.Visible = indice == 0;
            pnlFolha.Visible = indice == 1;
            pnlSistema.Visible = indice == 2;
            pnlUsuario.Visible = indice == 3;
            pnlBackup.Visible = indice == 4;

            if (indice == 0) pnlEmpresa.BringToFront();
            else if (indice == 1) pnlFolha.BringToFront();
            else if (indice == 2) pnlSistema.BringToFront();
            else if (indice == 3) pnlUsuario.BringToFront();
            else if (indice == 4) pnlBackup.BringToFront();

            ConfigurarAba(btnAbaEmpresa, indice == 0);
            ConfigurarAba(btnAbaFolha, indice == 1);
            ConfigurarAba(btnAbaSistema, indice == 2);
            ConfigurarAba(btnAbaUsuario, indice == 3);
            ConfigurarAba(btnAbaBackup, indice == 4);
        }

        private static void ConfigurarAba(Button botao, bool ativa)
        {
            botao.BackColor = ativa ? Color.FromArgb(30, 130, 215) : Color.FromArgb(244, 247, 251);
            botao.ForeColor = ativa ? Color.White : Color.FromArgb(8, 42, 78);
            botao.FlatAppearance.BorderColor = ativa ? Color.FromArgb(30, 130, 215) : Color.FromArgb(205, 218, 232);
        }

        private void CarregarConfiguracoes()
        {
            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();
                CriarTabelaConfiguracoesSeNecessario(conexao);

                txtNomeEmpresa.Text = ObterValor(conexao, "NomeEmpresa") ?? "";
                txtCnpj.Text = ObterValor(conexao, "CNPJ") ?? "";
                txtTelefone.Text = ObterValor(conexao, "Telefone") ?? "";
                txtEmail.Text = ObterValor(conexao, "Email") ?? "";
                txtEndereco.Text = ObterValor(conexao, "Endereco") ?? "";
                txtBairro.Text = ObterValor(conexao, "Bairro") ?? "";
                txtCidade.Text = ObterValor(conexao, "Cidade") ?? "";
                cmbUf.Text = ObterValor(conexao, "UF") ?? "";
                txtCep.Text = ObterValor(conexao, "CEP") ?? "";
                txtInscricaoEstadual.Text = ObterValor(conexao, "InscricaoEstadual") ?? "";
                txtInscricaoMunicipal.Text = ObterValor(conexao, "InscricaoMunicipal") ?? "";
                txtSite.Text = ObterValor(conexao, "Site") ?? "";

                nudDiaPagamento.Value = LerDecimal(conexao, "Folha_DiaPagamento", 5, 1, 31);
                nudDiaAdiantamento.Value = LerDecimal(conexao, "Folha_DiaAdiantamento", 20, 1, 31);
                nudPercentualAdiantamento.Value = LerDecimal(conexao, "Folha_PercentualAdiantamento", 40, 0, 100);
                nudDescontoVA.Value = LerDecimal(conexao, "Folha_DescontoVA", 0, 0, 100);
                nudDescontoPlano.Value = LerDecimal(conexao, "Folha_DescontoPlano", 0, 0, 100);
                nudDescontoVT.Value = LerDecimal(conexao, "Folha_DescontoVT", 0, 0, 100);
                txtBeneficioAdicional.Text = ObterValor(conexao, "Folha_BeneficioAdicionalNome") ?? "";
                nudValorBeneficio.Value = LerDecimal(conexao, "Folha_BeneficioAdicionalValor", 0, 0, 100000);
                string tipoBeneficio = ObterValor(conexao, "Folha_BeneficioAdicionalTipo") ?? "P";
                rdbBeneficioPercentual.Checked = tipoBeneficio != "R";
                rdbBeneficioValor.Checked = tipoBeneficio == "R";
                txtDescontoAdicional.Text = ObterValor(conexao, "Folha_DescontoAdicionalNome") ?? "";
                nudValorDescontoAdicional.Value = LerDecimal(conexao, "Folha_DescontoAdicionalValor", 0, 0, 100000);
                string tipoDesconto = ObterValor(conexao, "Folha_DescontoAdicionalTipo") ?? "P";
                rdbDescontoPercentual.Checked = tipoDesconto != "R";
                rdbDescontoValor.Checked = tipoDesconto == "R";
                AtualizarRotulosAdicionais();
                chkCalcularINSS.Checked = LerBool(conexao, "Folha_CalcularINSS", true);
                chkCalcularIRRF.Checked = LerBool(conexao, "Folha_CalcularIRRF", true);

                string? logo = ObterValor(conexao, "LogoEmpresa");

                if (!string.IsNullOrWhiteSpace(logo) && File.Exists(logo))
                {
                    caminhoLogoSelecionado = logo;
                    picLogo.Image = CarregarImagemSemBloquearArquivo(logo);
                }
                else
                {
                    caminhoLogoSelecionado = null;
                    picLogo.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar as configurações.\n\n" + ex.Message,
                    "RH Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void CriarTabelaConfiguracoesSeNecessario(SqliteConnection conexao)
        {
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Configuracoes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Chave TEXT NOT NULL UNIQUE,
                    Valor TEXT NULL
                );";
            cmd.ExecuteNonQuery();
        }

        private static string? ObterValor(SqliteConnection conexao, string chave)
        {
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = "SELECT Valor FROM Configuracoes WHERE Chave = $chave LIMIT 1;";
            cmd.Parameters.AddWithValue("$chave", chave);
            return cmd.ExecuteScalar()?.ToString();
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeEmpresa.Text))
            {
                MessageBox.Show("Informe o Nome da Empresa.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeEmpresa.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCnpj.Text))
            {
                MessageBox.Show("Informe o CNPJ.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCnpj.Focus();
                return;
            }

            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();
                CriarTabelaConfiguracoesSeNecessario(conexao);

                SalvarCampo(conexao, "NomeEmpresa", txtNomeEmpresa.Text.Trim());
                SalvarCampo(conexao, "CNPJ", txtCnpj.Text.Trim());
                SalvarCampo(conexao, "Telefone", txtTelefone.Text.Trim());
                SalvarCampo(conexao, "Email", txtEmail.Text.Trim());
                SalvarCampo(conexao, "Endereco", txtEndereco.Text.Trim());
                SalvarCampo(conexao, "Bairro", txtBairro.Text.Trim());
                SalvarCampo(conexao, "Cidade", txtCidade.Text.Trim());
                SalvarCampo(conexao, "UF", cmbUf.Text.Trim());
                SalvarCampo(conexao, "CEP", txtCep.Text.Trim());
                SalvarCampo(conexao, "InscricaoEstadual", txtInscricaoEstadual.Text.Trim());
                SalvarCampo(conexao, "InscricaoMunicipal", txtInscricaoMunicipal.Text.Trim());
                SalvarCampo(conexao, "Site", txtSite.Text.Trim());

                SalvarCampo(conexao, "Folha_DiaPagamento", nudDiaPagamento.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_DiaAdiantamento", nudDiaAdiantamento.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_PercentualAdiantamento", nudPercentualAdiantamento.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_DescontoVA", nudDescontoVA.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_DescontoPlano", nudDescontoPlano.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_DescontoVT", nudDescontoVT.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_BeneficioAdicionalNome", txtBeneficioAdicional.Text.Trim());
                SalvarCampo(conexao, "Folha_BeneficioAdicionalValor", nudValorBeneficio.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_BeneficioAdicionalTipo", rdbBeneficioValor.Checked ? "R" : "P");
                SalvarCampo(conexao, "Folha_DescontoAdicionalNome", txtDescontoAdicional.Text.Trim());
                SalvarCampo(conexao, "Folha_DescontoAdicionalValor", nudValorDescontoAdicional.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                SalvarCampo(conexao, "Folha_DescontoAdicionalTipo", rdbDescontoValor.Checked ? "R" : "P");
                SalvarCampo(conexao, "Folha_CalcularINSS", chkCalcularINSS.Checked ? "1" : "0");
                SalvarCampo(conexao, "Folha_CalcularIRRF", chkCalcularIRRF.Checked ? "1" : "0");

                SalvarCampo(conexao, "LogoEmpresa", caminhoLogoSelecionado ?? "");

                AtualizarResumoFolha();

                MessageBox.Show("Configurações salvas com sucesso!", "RH Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar as configurações.\n\n" + ex.Message,
                    "RH Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal LerDecimal(SqliteConnection conexao, string chave, decimal padrao, decimal minimo, decimal maximo)
        {
            string? valor = ObterValor(conexao, chave);

            if (decimal.TryParse(valor,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal resultado))
            {
                if (resultado < minimo) return minimo;
                if (resultado > maximo) return maximo;
                return resultado;
            }

            return padrao;
        }

        private static bool LerBool(SqliteConnection conexao, string chave, bool padrao)
        {
            string? valor = ObterValor(conexao, chave);

            if (valor == "1" || string.Equals(valor, "true", StringComparison.OrdinalIgnoreCase))
                return true;

            if (valor == "0" || string.Equals(valor, "false", StringComparison.OrdinalIgnoreCase))
                return false;

            return padrao;
        }

        private void AtualizarRotulosAdicionais()
        {
            lblValorBeneficio.Text = rdbBeneficioValor.Checked ? "Valor (R$)" : "Valor (%)";
            lblValorDescontoAdicional.Text = rdbDescontoValor.Checked ? "Valor (R$)" : "Valor (%)";
        }

        private void AtualizarResumoFolha()
        {
            dgvResumoFolha.Columns.Clear();
            dgvResumoFolha.Rows.Clear();

            dgvResumoFolha.Columns.Add("Tipo", "Tipo");
            dgvResumoFolha.Columns.Add("Descricao", "Descrição");
            dgvResumoFolha.Columns.Add("Valor", "Valor");

            dgvResumoFolha.Columns["Tipo"]!.FillWeight = 28;
            dgvResumoFolha.Columns["Descricao"]!.FillWeight = 52;
            dgvResumoFolha.Columns["Valor"]!.FillWeight = 30;

            AdicionarResumo("Geral", "Dia do pagamento", nudDiaPagamento.Value.ToString("0"));
            AdicionarResumo("Geral", "Dia do adiantamento", nudDiaAdiantamento.Value.ToString("0"));
            AdicionarResumo("Geral", "% de adiantamento", nudPercentualAdiantamento.Value.ToString("0.00") + "%");

            AdicionarResumo("Desconto", "Vale-alimentação (VA)", nudDescontoVA.Value.ToString("0.00") + "%");
            AdicionarResumo("Desconto", "Plano de saúde", nudDescontoPlano.Value.ToString("0.00") + "%");
            AdicionarResumo("Desconto", "Vale-transporte (VT)", nudDescontoVT.Value.ToString("0.00") + "%");

            if (!string.IsNullOrWhiteSpace(txtBeneficioAdicional.Text))
                AdicionarResumo("Benefício", txtBeneficioAdicional.Text.Trim(), FormatarAdicional(nudValorBeneficio.Value, rdbBeneficioValor.Checked));

            if (!string.IsNullOrWhiteSpace(txtDescontoAdicional.Text))
                AdicionarResumo("Desconto", txtDescontoAdicional.Text.Trim(), FormatarAdicional(nudValorDescontoAdicional.Value, rdbDescontoValor.Checked));

            AdicionarResumo("Encargo", "Calcular INSS", chkCalcularINSS.Checked ? "Sim" : "Não");
            AdicionarResumo("Encargo", "Calcular IRRF", chkCalcularIRRF.Checked ? "Sim" : "Não");

            if (dgvResumoFolha.Rows.Count > 0)
                dgvResumoFolha.Rows[0].Selected = true;

            AtualizarEstadoBotoesResumo();
        }

        private static string FormatarAdicional(decimal valor, bool valorFixo)
        {
            return valorFixo
                ? "R$ " + valor.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                : valor.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) + "%";
        }

        private void AdicionarResumo(string tipo, string descricao, string valor)
        {
            int indice = dgvResumoFolha.Rows.Add(tipo, descricao, valor);
            dgvResumoFolha.Rows[indice].Tag = tipo + "|" + descricao;
        }

        private void AtualizarEstadoBotoesResumo()
        {
            bool selecionado = dgvResumoFolha.CurrentRow != null && !dgvResumoFolha.CurrentRow.IsNewRow;
            btnEditarResumo.Enabled = selecionado;
            btnExcluirResumo.Enabled = selecionado;
        }

        private void BtnEditarResumo_Click(object? sender, EventArgs e)
        {
            if (dgvResumoFolha.CurrentRow == null)
                return;

            string descricao = dgvResumoFolha.CurrentRow.Cells["Descricao"].Value?.ToString() ?? "";

            if (descricao == "Dia do pagamento")
            {
                nudDiaPagamento.Focus();
            }
            else if (descricao == "Dia do adiantamento")
            {
                nudDiaAdiantamento.Focus();
            }
            else if (descricao == "% de adiantamento")
            {
                nudPercentualAdiantamento.Focus();
            }
            else if (descricao == "Vale-alimentação (VA)")
            {
                nudDescontoVA.Focus();
            }
            else if (descricao == "Plano de saúde")
            {
                nudDescontoPlano.Focus();
            }
            else if (descricao == "Vale-transporte (VT)")
            {
                nudDescontoVT.Focus();
            }
            else if (descricao == "Calcular INSS")
            {
                chkCalcularINSS.Focus();
            }
            else if (descricao == "Calcular IRRF")
            {
                chkCalcularIRRF.Focus();
            }
            else if (!string.IsNullOrWhiteSpace(txtBeneficioAdicional.Text) &&
                     string.Equals(descricao, txtBeneficioAdicional.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                txtBeneficioAdicional.Focus();
                txtBeneficioAdicional.SelectAll();
            }
            else if (!string.IsNullOrWhiteSpace(txtDescontoAdicional.Text) &&
                     string.Equals(descricao, txtDescontoAdicional.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                txtDescontoAdicional.Focus();
                txtDescontoAdicional.SelectAll();
            }

            dgvResumoFolha.ClearSelection();
        }

        private void BtnExcluirResumo_Click(object? sender, EventArgs e)
        {
            if (dgvResumoFolha.CurrentRow == null)
                return;

            string descricao = dgvResumoFolha.CurrentRow.Cells["Descricao"].Value?.ToString() ?? "";

            DialogResult confirmacao = MessageBox.Show(
                "Deseja realmente excluir/resetar o item selecionado?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            if (descricao == "Dia do pagamento")
                nudDiaPagamento.Value = 5;
            else if (descricao == "Dia do adiantamento")
                nudDiaAdiantamento.Value = 20;
            else if (descricao == "% de adiantamento")
                nudPercentualAdiantamento.Value = 0;
            else if (descricao == "Vale-alimentação (VA)")
                nudDescontoVA.Value = 0;
            else if (descricao == "Plano de saúde")
                nudDescontoPlano.Value = 0;
            else if (descricao == "Vale-transporte (VT)")
                nudDescontoVT.Value = 0;
            else if (!string.IsNullOrWhiteSpace(txtBeneficioAdicional.Text) &&
                     string.Equals(descricao, txtBeneficioAdicional.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                txtBeneficioAdicional.Clear();
                nudValorBeneficio.Value = 0;
                rdbBeneficioPercentual.Checked = true;
            }
            else if (!string.IsNullOrWhiteSpace(txtDescontoAdicional.Text) &&
                     string.Equals(descricao, txtDescontoAdicional.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                txtDescontoAdicional.Clear();
                nudValorDescontoAdicional.Value = 0;
                rdbDescontoPercentual.Checked = true;
            }
            else if (descricao == "Calcular INSS")
                chkCalcularINSS.Checked = false;
            else if (descricao == "Calcular IRRF")
                chkCalcularIRRF.Checked = false;

            AtualizarResumoFolha();
        }

        private static void SalvarCampo(SqliteConnection conexao, string chave, string valor)
        {
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Configuracoes (Chave, Valor)
                VALUES ($chave, $valor)
                ON CONFLICT(Chave) DO UPDATE SET Valor = excluded.Valor;";
            cmd.Parameters.AddWithValue("$chave", chave);
            cmd.Parameters.AddWithValue("$valor", valor ?? "");
            cmd.ExecuteNonQuery();
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            CarregarConfiguracoes();
        }

        private void BtnSelecionarLogo_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Selecionar logo da empresa",
                Filter = "Imagens|*.png;*.jpg;*.jpeg|Todos os arquivos|*.*",
                Multiselect = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string pastaData = Path.Combine(AppContext.BaseDirectory, "Data");
                Directory.CreateDirectory(pastaData);

                string extensao = Path.GetExtension(dialog.FileName).ToLowerInvariant();
                string destino = Path.Combine(pastaData, "LogoEmpresa" + extensao);

                File.Copy(dialog.FileName, destino, true);

                caminhoLogoSelecionado = destino;
                picLogo.Image = CarregarImagemSemBloquearArquivo(destino);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível selecionar a logo.\n\n" + ex.Message,
                    "RH Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoverLogo_Click(object? sender, EventArgs e)
        {
            caminhoLogoSelecionado = null;
            picLogo.Image = null;
        }

        private static Image CarregarImagemSemBloquearArquivo(string caminho)
        {
            using var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var imagem = Image.FromStream(stream);
            return new Bitmap(imagem);
        }


        public void AtualizarListaUsuarios()
        {
            CarregarUsuarios();
            AtualizarEstadoBotoesUsuarios();
        }

        private void CarregarUsuarios()
        {
            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();

                using var cmd = conexao.CreateCommand();
                cmd.CommandText = @"
                    SELECT Id, Nome, Usuario, Email, TipoUsuario, Status, UltimoAcesso
                    FROM Usuarios
                    ORDER BY Nome;";

                using var reader = cmd.ExecuteReader();

                dgvUsuarios.Columns.Clear();
                dgvUsuarios.Rows.Clear();

                dgvUsuarios.Columns.Add("Id", "ID");
                dgvUsuarios.Columns.Add("Nome", "Nome");
                dgvUsuarios.Columns.Add("Usuario", "Usuário");
                dgvUsuarios.Columns.Add("Email", "E-mail");
                dgvUsuarios.Columns.Add("TipoUsuario", "Tipo de usuário");
                dgvUsuarios.Columns.Add("Status", "Status");
                dgvUsuarios.Columns.Add("UltimoAcesso", "Último acesso");

                dgvUsuarios.Columns["Id"]!.FillWeight = 10;
                dgvUsuarios.Columns["Nome"]!.FillWeight = 25;
                dgvUsuarios.Columns["Usuario"]!.FillWeight = 18;
                dgvUsuarios.Columns["Email"]!.FillWeight = 25;
                dgvUsuarios.Columns["TipoUsuario"]!.FillWeight = 18;
                dgvUsuarios.Columns["Status"]!.FillWeight = 15;
                dgvUsuarios.Columns["UltimoAcesso"]!.FillWeight = 20;

                while (reader.Read())
                {
                    string ultimoAcesso = reader.IsDBNull(6)
                        ? "Nunca"
                        : reader.GetString(6);

                    int linha = dgvUsuarios.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.IsDBNull(3) ? "" : reader.GetString(3),
                        reader.IsDBNull(4) ? "Usuario" : reader.GetString(4),
                        reader.IsDBNull(5) ? "Ativo" : reader.GetString(5),
                        string.IsNullOrWhiteSpace(ultimoAcesso) ? "Nunca" : ultimoAcesso);

                    dgvUsuarios.Rows[linha].Tag = reader.GetInt32(0);
                }

                if (dgvUsuarios.Rows.Count > 0)
                    dgvUsuarios.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar as contas de usuário.\n\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void AplicarPermissoesUsuarios()
        {
            bool administradorPrincipal = SessaoUsuario.EhAdministradorPrincipal;

            // Somente o administrador principal pode gerenciar contas existentes.
            // Novos administradores podem somente criar contas do tipo Usuário.
            btnNovaConta.Enabled = SessaoUsuario.EhAdministrador;
            btnEditarUsuario.Enabled = false;
            btnInativarUsuario.Enabled = false;
            btnExcluirUsuario.Enabled = false;

            if (SessaoUsuario.EhAdministrador && !administradorPrincipal)
            {
                // O botão continua disponível porque este administrador pode
                // criar contas, mas apenas do tipo Usuário.
                btnNovaConta.Enabled = true;
            }
        }

        private void AtualizarEstadoBotoesUsuarios()
        {
            bool selecionado = dgvUsuarios.CurrentRow != null &&
                                !dgvUsuarios.CurrentRow.IsNewRow;

            // Apenas o administrador principal pode alterar/inativar/excluir
            // contas. A própria conta e a conta "admin" nunca podem ser alvo
            // dessas ações.
            if (!SessaoUsuario.EhAdministradorPrincipal || !selecionado)
            {
                btnEditarUsuario.Enabled = false;
                btnInativarUsuario.Enabled = false;
                btnExcluirUsuario.Enabled = false;
                return;
            }

            int? id = ObterIdUsuarioSelecionado();
            bool ehPropriaConta = id.HasValue && id.Value == SessaoUsuario.Id;
            string usuarioSelecionado = dgvUsuarios.CurrentRow?.Cells["Usuario"].Value?.ToString() ?? "";
            bool ehAdminPrincipal = string.Equals(usuarioSelecionado, "admin", StringComparison.OrdinalIgnoreCase);

            bool podeAlterar = !ehPropriaConta && !ehAdminPrincipal;
            btnEditarUsuario.Enabled = podeAlterar;
            btnInativarUsuario.Enabled = podeAlterar;
            btnExcluirUsuario.Enabled = podeAlterar;
        }

        private int? ObterIdUsuarioSelecionado()
        {
            if (dgvUsuarios.CurrentRow?.Tag == null)
                return null;

            return int.TryParse(dgvUsuarios.CurrentRow.Tag.ToString(), out int id)
                ? id
                : null;
        }

        private void BtnNovaConta_Click(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministrador)
            {
                MessageBox.Show(
                    "Somente um Administrador pode criar contas de acesso.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using var tela = new FrmCadastroUsuario();
            if (tela.ShowDialog(this) == DialogResult.OK)
                CarregarUsuarios();
        }

        private void BtnEditarUsuario_Click(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                MessageBox.Show(
                    "Somente o Administrador principal pode editar contas existentes.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "A edição de conta será adicionada na próxima parte desta etapa.",
                "Usuários",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnInativarUsuario_Click(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                MessageBox.Show(
                    "Somente o Administrador principal pode alterar o status das contas.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int? id = ObterIdUsuarioSelecionado();
            if (!id.HasValue)
                return;

            if (id.Value == SessaoUsuario.Id)
            {
                MessageBox.Show(
                    "Você não pode inativar a própria conta enquanto estiver conectado.",
                    "Ação não permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string usuarioAlvo = dgvUsuarios.CurrentRow?.Cells["Usuario"].Value?.ToString() ?? "";
            if (string.Equals(usuarioAlvo, "admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "A conta administradora principal (admin) é protegida e nunca pode ser inativada.",
                    "Ação não permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string statusAtual = dgvUsuarios.CurrentRow?.Cells["Status"].Value?.ToString() ?? "Ativo";
            string novoStatus = string.Equals(statusAtual, "Ativo", StringComparison.OrdinalIgnoreCase)
                ? "Inativo"
                : "Ativo";

            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();

                using var cmd = conexao.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Usuarios
                    SET Status = $status,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id;";

                cmd.Parameters.AddWithValue("$status", novoStatus);
                cmd.Parameters.AddWithValue("$atualizado", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("$id", id.Value);
                cmd.ExecuteNonQuery();

                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível alterar o status da conta.\n\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnExcluirUsuario_Click(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                MessageBox.Show(
                    "Somente o Administrador principal pode excluir contas.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int? id = ObterIdUsuarioSelecionado();
            if (!id.HasValue)
                return;

            if (id.Value == SessaoUsuario.Id)
            {
                MessageBox.Show(
                    "Você não pode excluir a própria conta enquanto estiver conectado.",
                    "Ação não permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string usuarioAlvo = dgvUsuarios.CurrentRow?.Cells["Usuario"].Value?.ToString() ?? "";
            if (string.Equals(usuarioAlvo, "admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "A conta administradora principal (admin) é protegida e nunca pode ser excluída.",
                    "Ação não permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string nome = dgvUsuarios.CurrentRow?.Cells["Nome"].Value?.ToString() ?? "esta conta";

            if (MessageBox.Show(
                $"Deseja realmente excluir a conta de {nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();

                using var cmd = conexao.CreateCommand();
                cmd.CommandText = "DELETE FROM Usuarios WHERE Id = $id;";
                cmd.Parameters.AddWithValue("$id", id.Value);
                cmd.ExecuteNonQuery();

                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível excluir a conta.\n\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AbrirTela(Form tela)
        {
            Hide();
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.FormClosed += (s, e) => Close();
            tela.Show();
        }
    }
}
