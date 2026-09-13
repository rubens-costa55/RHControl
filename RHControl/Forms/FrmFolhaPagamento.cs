using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;

namespace RHControl.Forms
{
    public partial class FrmFolhaPagamento : Form
    {
        private int indiceLinhaPdf;
        private int paginaPdf;
        private bool alterandoPesquisa;

        public FrmFolhaPagamento()
        {
            InitializeComponent();

            AplicarPermissoes();

            // Eventos da tela
            btnGerarFolha.Click += btnGerarFolha_Click;
            btnFiltrar.Click += btnFiltrar_Click;
            txtPesquisar.Enter += txtPesquisar_Enter;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyDown += txtPesquisar_KeyDown;

            // Ao abrir a tela, mostra o período atual,
            // mas NÃO gera/carrega a folha automaticamente.
            PrepararPeriodoAtual();
            LimparFolhaInicial();
        }

        private void AplicarPermissoes()
        {
            // Usuário pode consultar, filtrar e exportar.
            // Apenas Administrador pode executar a ação de gerar/processar a folha.
            btnGerarFolha.Enabled = SessaoUsuario.PodeEditar;

            if (!SessaoUsuario.PodeEditar)
            {
                btnGerarFolha.Text = "Gerar Folha";
                btnGerarFolha.Cursor = Cursors.Default;
            }

            if (!SessaoUsuario.PodeExportar)
                btnImprimir.Enabled = false;
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeEditar)
            {
                MessageBox.Show(
                    "Seu perfil pode apenas consultar e exportar a folha de pagamento.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private void PrepararPeriodoAtual()
        {
            string mesAtual = DateTime.Now.ToString("MMMM", CulturaPtBr());
            mesAtual = char.ToUpper(mesAtual[0]) + mesAtual.Substring(1);

            // Seleciona o mês atual, se ele existir no ComboBox.
            int indiceMes = cmbMes.FindStringExact(mesAtual);
            if (indiceMes >= 0)
                cmbMes.SelectedIndex = indiceMes;
            else
                cmbMes.Text = mesAtual;

            // Seleciona o ano atual, se ele existir no ComboBox.
            int indiceAno = cmbAno.FindStringExact(DateTime.Now.Year.ToString());
            if (indiceAno >= 0)
                cmbAno.SelectedIndex = indiceAno;
            else
                cmbAno.Text = DateTime.Now.Year.ToString();
        }

        private bool ValidarPeriodo()
        {
            bool mesValido =
                !string.IsNullOrWhiteSpace(cmbMes.Text) &&
                !cmbMes.Text.Equals("Selecione o mês", StringComparison.OrdinalIgnoreCase) &&
                !cmbMes.Text.Equals("Selecione", StringComparison.OrdinalIgnoreCase);

            bool anoValido =
                !string.IsNullOrWhiteSpace(cmbAno.Text) &&
                !cmbAno.Text.Equals("Selecione o ano", StringComparison.OrdinalIgnoreCase) &&
                !cmbAno.Text.Equals("Selecione", StringComparison.OrdinalIgnoreCase);

            if (!mesValido || !anoValido)
            {
                MessageBox.Show(
                    "Para gerar ou filtrar a folha, selecione o mês e o ano.",
                    "Período obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (!mesValido)
                    cmbMes.Focus();
                else
                    cmbAno.Focus();

                return false;
            }

            return true;
        }

        private void LimparFolhaInicial()
        {
            dgvFuncionarios.Rows.Clear();

            lblFuncionariosValor.Text = "0";
            lblBrutoValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblDescontosValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblLiquidoValor.Text = 0m.ToString("C2", CulturaPtBr());
            lblHorasValor.Text = "0h";

            lblProcessados.Text = "0 de 0";
            progressProcessados.Value = 0;

            string mes = cmbMes.Text;
            string ano = cmbAno.Text;

            if (string.IsNullOrWhiteSpace(mes))
                mes = "Período não selecionado";

            if (string.IsNullOrWhiteSpace(ano))
                ano = "-";

            if (cmbMes.Text.Length > 0 && cmbAno.Text.Length > 0)
                lblPeriodo.Text = ObterPeriodoTexto(cmbMes.Text, cmbAno.Text);
            else
                lblPeriodo.Text = "-";

            lblGerada.Text = "-";

            lblSituacaoFolha.Text = "●  Não gerada";
            lblSituacaoFolha.ForeColor = Color.FromArgb(195, 55, 55);

            lblObservacoes.Text =
                "Selecione o mês e o ano e clique em Gerar Folha.";

            lblListaTitulo.Text =
                "Funcionários na folha (" + mes + "/" + ano + ")";

            // Placeholder da pesquisa.
            txtPesquisar.Text = "Pesquisar funcionário...";
            txtPesquisar.ForeColor = Color.FromArgb(128, 128, 128);
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
            {
                alterandoPesquisa = true;
                txtPesquisar.Clear();
                txtPesquisar.ForeColor = Color.FromArgb(45, 45, 45);
                alterandoPesquisa = false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (alterandoPesquisa)
                return;

            // O placeholder não é uma pesquisa.
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
                return;

            // Pesquisa em tempo real, mas sem validar período a cada letra.
            // Se mês/ano ainda não estiverem selecionados, apenas não pesquisa.
            if (PeriodoValidoSemMensagem())
                CarregarFolha();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            e.Handled = true;

            // Se ainda estiver com o placeholder, primeiro limpa o campo.
            if (string.Equals(
                txtPesquisar.Text,
                "Pesquisar funcionário...",
                StringComparison.OrdinalIgnoreCase))
            {
                txtPesquisar.Clear();
                txtPesquisar.ForeColor = Color.FromArgb(45, 45, 45);
                return;
            }

            if (!ValidarPeriodo())
                return;

            CarregarFolha();
        }

        private bool PeriodoValidoSemMensagem()
        {
            bool mesValido =
                !string.IsNullOrWhiteSpace(cmbMes.Text) &&
                !cmbMes.Text.Equals("Selecione o mês",
                    StringComparison.OrdinalIgnoreCase) &&
                !cmbMes.Text.Equals("Selecione",
                    StringComparison.OrdinalIgnoreCase);

            bool anoValido =
                !string.IsNullOrWhiteSpace(cmbAno.Text) &&
                !cmbAno.Text.Equals("Selecione o ano",
                    StringComparison.OrdinalIgnoreCase) &&
                !cmbAno.Text.Equals("Selecione",
                    StringComparison.OrdinalIgnoreCase);

            return mesValido && anoValido;
        }

        private void CarregarFolha()
        {
            try
            {
                dgvFuncionarios.Rows.Clear();

                using (SqliteConnection connection = Database.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT
                            f.Id,
                            f.Nome,
                            f.Cargo,
                            f.Salario,
                            f.Setor,
                            f.Status,
                            COALESCE(
                                (
                                    SELECT SUM(b.ValorDesconto)
                                    FROM BeneficiosFuncionario b
                                    WHERE b.FuncionarioId = f.Id
                                ), 0
                            ) AS TotalDescontos
                        FROM Funcionarios f
                        WHERE 1 = 1
                    ";

                    if (!string.IsNullOrWhiteSpace(txtPesquisar.Text) &&
                        !string.Equals(txtPesquisar.Text, "Pesquisar funcionário...",
                            StringComparison.OrdinalIgnoreCase))
                    {
                        sql += @"
                            AND (
                                COALESCE(f.Nome, '') LIKE $Busca
                                OR COALESCE(f.Cargo, '') LIKE $Busca
                                OR COALESCE(f.Setor, '') LIKE $Busca
                                OR COALESCE(f.Status, '') LIKE $Busca
                                OR CAST(COALESCE(f.Salario, 0) AS TEXT) LIKE $Busca
                                OR '0h' LIKE $Busca
                            ) ";
                    }

                    if (!string.IsNullOrWhiteSpace(cmbDepartamento.Text) &&
                        cmbDepartamento.Text != "Todos os departamentos")
                    {
                        sql += " AND COALESCE(f.Setor, '') = $Departamento ";
                    }

                    if (!string.IsNullOrWhiteSpace(cmbSituacao.Text) &&
                        cmbSituacao.Text != "Todos")
                    {
                        sql += " AND COALESCE(f.Status, '') = $Situacao ";
                    }

                    sql += " ORDER BY f.Nome;";

                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sql;

                        if (!string.IsNullOrWhiteSpace(txtPesquisar.Text) &&
                            !string.Equals(txtPesquisar.Text, "Pesquisar funcionário...",
                                StringComparison.OrdinalIgnoreCase))
                        {
                            command.Parameters.AddWithValue(
                                "$Busca", "%" + txtPesquisar.Text.Trim() + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(cmbDepartamento.Text) &&
                            cmbDepartamento.Text != "Todos os departamentos")
                        {
                            command.Parameters.AddWithValue(
                                "$Departamento", cmbDepartamento.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(cmbSituacao.Text) &&
                            cmbSituacao.Text != "Todos")
                        {
                            command.Parameters.AddWithValue(
                                "$Situacao", cmbSituacao.Text);
                        }

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nome = reader["Nome"]?.ToString() ?? "";
                                string cargo = reader["Cargo"]?.ToString() ?? "";
                                decimal salario = ConverterDecimal(reader["Salario"]);
                                decimal descontos = ConverterDecimal(reader["TotalDescontos"]);
                                decimal liquido = salario - descontos;
                                string status = reader["Status"]?.ToString() ?? "Ativo";

                                dgvFuncionarios.Rows.Add(
                                    nome,
                                    cargo,
                                    salario.ToString("C2", CulturaPtBr()),
                                    descontos.ToString("C2", CulturaPtBr()),
                                    liquido.ToString("C2", CulturaPtBr()),
                                    "0h",
                                    status
                                );
                            }
                        }
                    }
                }

                AtualizarResumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar a folha de pagamento.\n\n" +
                    "Erro: " + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AtualizarResumo()
        {
            int quantidade = dgvFuncionarios.Rows.Count;
            decimal bruto = 0;
            decimal descontos = 0;
            decimal liquido = 0;

            foreach (DataGridViewRow row in dgvFuncionarios.Rows)
            {
                bruto += ConverterDecimal(row.Cells["colSalario"].Value);
                descontos += ConverterDecimal(row.Cells["colDescontos"].Value);
                liquido += ConverterDecimal(row.Cells["colLiquido"].Value);
            }

            lblFuncionariosValor.Text = quantidade.ToString();
            lblBrutoValor.Text = bruto.ToString("C2", CulturaPtBr());
            lblDescontosValor.Text = descontos.ToString("C2", CulturaPtBr());
            lblLiquidoValor.Text = liquido.ToString("C2", CulturaPtBr());

            int horas = quantidade * 0;
            lblHorasValor.Text = horas.ToString() + "h";

            lblProcessados.Text = quantidade + " de " + quantidade;
            progressProcessados.Value = quantidade > 0 ? 100 : 0;

            string mes = cmbMes.Text;
            string ano = cmbAno.Text;

            if (string.IsNullOrWhiteSpace(mes))
                mes = "Setembro";

            if (string.IsNullOrWhiteSpace(ano))
                ano = DateTime.Now.Year.ToString();

            lblPeriodo.Text = ObterPeriodoTexto(mes, ano);
            lblGerada.Text = quantidade > 0
                ? DateTime.Now.ToString("dd/MM/yyyy 'às' HH:mm")
                : "-";

            lblSituacaoFolha.Text = quantidade > 0
                ? "●  Processada"
                : "●  Não gerada";

            lblSituacaoFolha.ForeColor = quantidade > 0
                ? Color.FromArgb(0, 145, 75)
                : Color.FromArgb(195, 55, 55);

            lblObservacoes.Text = quantidade > 0
                ? "Funcionários carregados para a folha."
                : "Nenhum funcionário encontrado.";

            lblListaTitulo.Text =
                "Funcionários na folha (" + mes + "/" + ano + ")";

        }

        private string ObterPeriodoTexto(string mes, string ano)
        {
            int numeroMes = Array.IndexOf(
                new[]
                {
                    "Janeiro", "Fevereiro", "Março", "Abril",
                    "Maio", "Junho", "Julho", "Agosto",
                    "Setembro", "Outubro", "Novembro", "Dezembro"
                },
                mes) + 1;

            if (numeroMes < 1)
                numeroMes = DateTime.Now.Month;

            if (!int.TryParse(ano, out int numeroAno))
                numeroAno = DateTime.Now.Year;

            DateTime inicio = new DateTime(numeroAno, numeroMes, 1);
            DateTime fim = inicio.AddMonths(1).AddDays(-1);

            return inicio.ToString("dd/MM/yyyy") +
                   " a " +
                   fim.ToString("dd/MM/yyyy");
        }

        private static CultureInfo CulturaPtBr()
        {
            return new CultureInfo("pt-BR");
        }

        private static decimal ConverterDecimal(object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return 0;

            if (valor is decimal decimalValor)
                return decimalValor;

            if (valor is double doubleValor)
                return Convert.ToDecimal(doubleValor);

            if (valor is float floatValor)
                return Convert.ToDecimal(floatValor);

            string texto = valor.ToString();

            if (decimal.TryParse(
                texto,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal resultado))
            {
                return resultado;
            }

            if (decimal.TryParse(
                texto,
                NumberStyles.Any,
                CulturaPtBr(),
                out resultado))
            {
                return resultado;
            }

            return 0;
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (!SessaoUsuario.PodeExportar)
            {
                MessageBox.Show(
                    "Seu perfil não possui permissão para exportar relatórios.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Exportar folha de pagamento em PDF";
                dialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                dialog.DefaultExt = "pdf";
                dialog.AddExtension = true;
                dialog.FileName = "Folha_Pagamento_" +
                                  DateTime.Now.ToString("yyyy_MM_dd") + ".pdf";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                string impressoraPdf = EncontrarImpressoraPdf();

                if (string.IsNullOrWhiteSpace(impressoraPdf))
                {
                    MessageBox.Show(
                        "A impressora 'Microsoft Print to PDF' não está disponível no Windows.\n\n" +
                        "Ative o recurso Microsoft Print to PDF e tente novamente.",
                        "Exportação para PDF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    indiceLinhaPdf = 0;
                    paginaPdf = 1;

                    using (PrintDocument documento = new PrintDocument())
                    {
                        documento.DocumentName = Path.GetFileName(dialog.FileName);
                        documento.PrinterSettings.PrinterName = impressoraPdf;
                        documento.PrinterSettings.PrintToFile = true;
                        documento.PrinterSettings.PrintFileName = dialog.FileName;
                        documento.DefaultPageSettings.Landscape = true;
                        documento.DefaultPageSettings.Margins =
                            new Margins(35, 35, 35, 35);
                        documento.PrintPage += Documento_PrintPage;

                        documento.Print();
                    }

                    if (File.Exists(dialog.FileName))
                    {
                        // Abre automaticamente o PDF no visualizador padrão do Windows.
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = dialog.FileName,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show(
                            "O Windows não confirmou a criação do arquivo PDF.",
                            "Exportação para PDF",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível exportar a folha para PDF.\n\n" +
                        ex.Message,
                        "Erro na exportação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string EncontrarImpressoraPdf()
        {
            foreach (string nome in PrinterSettings.InstalledPrinters)
            {
                if (nome.IndexOf(
                    "Microsoft Print to PDF",
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return nome;
                }
            }

            return null;
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = e.MarginBounds;

            Color azulEscuro = Color.FromArgb(16, 42, 67);   // #102A43
            Color azul = Color.FromArgb(25, 118, 210);      // #1976D2
            Color fundo = Color.FromArgb(244, 247, 251);   // #F4F7FB
            Color cinzaTexto = Color.FromArgb(88, 102, 115);
            Color cinzaBorda = Color.FromArgb(220, 226, 232);
            Color verde = Color.FromArgb(0, 145, 75);

            using (Font titulo = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (Font subtitulo = new Font("Segoe UI", 9F))
            using (Font secao = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font cardTitulo = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (Font cardValor = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Font cabecalho = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font texto = new Font("Segoe UI", 8F))
            using (Font textoNegrito = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font pequeno = new Font("Segoe UI", 7.5F))
            {
                float x = area.Left;
                float y = area.Top;
                float largura = area.Width;

                // Fundo geral
                using (SolidBrush fundoBrush = new SolidBrush(fundo))
                    g.FillRectangle(fundoBrush, area);

                // =====================================================
                // CABEÇALHO RH CONTROL
                // =====================================================
                Rectangle cabecalhoRect = new Rectangle(
                    area.Left, (int)y, area.Width, 78);

                using (SolidBrush brush = new SolidBrush(azulEscuro))
                    g.FillRectangle(brush, cabecalhoRect);

                using (SolidBrush brush = new SolidBrush(azul))
                    g.FillRectangle(brush,
                        area.Left, (int)y + 74, area.Width, 4);

                g.DrawString(
                    "RH CONTROL",
                    titulo,
                    Brushes.White,
                    area.Left + 18,
                    y + 10);

                g.DrawString(
                    "FOLHA DE PAGAMENTO",
                    subtitulo,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Left + 20,
                    y + 43);

                string competencia =
                    "Competência: " + cmbMes.Text + "/" + cmbAno.Text;

                string filtros =
                    "Departamento: " + cmbDepartamento.Text +
                    "  •  Situação: " + cmbSituacao.Text;

                SizeF tamanhoCompetencia =
                    g.MeasureString(competencia, subtitulo);

                g.DrawString(
                    competencia,
                    subtitulo,
                    Brushes.White,
                    area.Right - tamanhoCompetencia.Width - 18,
                    y + 20);

                SizeF tamanhoFiltros =
                    g.MeasureString(filtros, pequeno);

                g.DrawString(
                    filtros,
                    pequeno,
                    new SolidBrush(Color.FromArgb(220, 235, 250)),
                    area.Right - tamanhoFiltros.Width - 18,
                    y + 45);

                y += 98;

                // =====================================================
                // TÍTULO DA COMPETÊNCIA
                // =====================================================
                g.DrawString(
                    "Resumo da folha",
                    secao,
                    new SolidBrush(azulEscuro),
                    x,
                    y);

                y += 24;

                // =====================================================
                // CARDS
                // =====================================================
                float espacoCard = 10;
                float larguraCard = (largura - (espacoCard * 4)) / 5f;
                float alturaCard = 62;

                string[] cardTitulos =
                {
                    "FUNCIONÁRIOS",
                    "SALÁRIO BRUTO",
                    "DESCONTOS",
                    "SALÁRIO LÍQUIDO",
                    "HORAS EXTRAS"
                };

                string[] cardValores =
                {
                    lblFuncionariosValor.Text,
                    lblBrutoValor.Text,
                    lblDescontosValor.Text,
                    lblLiquidoValor.Text,
                    lblHorasValor.Text
                };

                for (int i = 0; i < 5; i++)
                {
                    float cardX = x + i * (larguraCard + espacoCard);

                    Rectangle cardRect = new Rectangle(
                        (int)cardX,
                        (int)y,
                        (int)larguraCard,
                        (int)alturaCard);

                    using (SolidBrush brush = new SolidBrush(Color.White))
                        g.FillRectangle(brush, cardRect);

                    using (Pen pen = new Pen(cinzaBorda))
                        g.DrawRectangle(pen, cardRect);

                    using (SolidBrush brush = new SolidBrush(azul))
                        g.FillRectangle(
                            brush,
                            cardRect.Left,
                            cardRect.Top,
                            4,
                            cardRect.Height);

                    g.DrawString(
                        cardTitulos[i],
                        cardTitulo,
                        new SolidBrush(cinzaTexto),
                        cardRect.Left + 12,
                        cardRect.Top + 9);

                    g.DrawString(
                        cardValores[i],
                        cardValor,
                        new SolidBrush(azulEscuro),
                        cardRect.Left + 12,
                        cardRect.Top + 29);
                }

                y += alturaCard + 26;

                // =====================================================
                // TABELA
                // =====================================================
                g.DrawString(
                    "Funcionários processados",
                    secao,
                    new SolidBrush(azulEscuro),
                    x,
                    y);

                y += 24;

                string[] cabecalhos =
                {
                    "Funcionário", "Cargo", "Bruto", "Descontos",
                    "Líquido", "Horas extras", "Situação"
                };

                float[] larguras =
                {
                    180, 155, 105, 105, 105, 105, 100
                };

                // Ajusta proporcionalmente se a soma ultrapassar a área.
                float somaLarguras = 0;
                foreach (float w in larguras)
                    somaLarguras += w;

                if (somaLarguras > largura)
                {
                    float fator = largura / somaLarguras;
                    for (int i = 0; i < larguras.Length; i++)
                        larguras[i] *= fator;
                }

                x = area.Left;

                using (SolidBrush headerBrush = new SolidBrush(azulEscuro))
                using (SolidBrush headerTextBrush = new SolidBrush(Color.White))
                {
                    for (int i = 0; i < cabecalhos.Length; i++)
                    {
                        g.FillRectangle(
                            headerBrush,
                            x,
                            y,
                            larguras[i],
                            28);

                        g.DrawString(
                            cabecalhos[i],
                            cabecalho,
                            headerTextBrush,
                            new RectangleF(
                                x + 6,
                                y + 6,
                                larguras[i] - 12,
                                20));

                        x += larguras[i];
                    }
                }

                y += 28;

                while (indiceLinhaPdf < dgvFuncionarios.Rows.Count)
                {
                    DataGridViewRow linha =
                        dgvFuncionarios.Rows[indiceLinhaPdf];

                    if (y + 25 > area.Bottom - 45)
                    {
                        DesenharRodape(g, area, paginaPdf, azulEscuro, cinzaTexto);
                        paginaPdf++;
                        e.HasMorePages = true;
                        return;
                    }

                    x = area.Left;

                    using (SolidBrush linhaBrush =
                           new SolidBrush(
                               indiceLinhaPdf % 2 == 0
                                   ? Color.White
                                   : Color.FromArgb(248, 250, 252)))
                    using (Pen linhaPen = new Pen(cinzaBorda))
                    {
                        for (int i = 0;
                             i < dgvFuncionarios.Columns.Count &&
                             i < larguras.Length;
                             i++)
                        {
                            string valor =
                                Convert.ToString(linha.Cells[i].Value) ?? "";

                            RectangleF celula = new RectangleF(
                                x,
                                y,
                                larguras[i],
                                25);

                            g.FillRectangle(linhaBrush, celula);
                            g.DrawRectangle(
                                linhaPen,
                                celula.X,
                                celula.Y,
                                celula.Width,
                                celula.Height);

                            bool situacao =
                                i == 6 &&
                                !string.IsNullOrWhiteSpace(valor);

                            Brush textoBrush =
                                situacao &&
                                valor.Equals("Ativo",
                                    StringComparison.OrdinalIgnoreCase)
                                    ? new SolidBrush(verde)
                                    : new SolidBrush(cinzaTexto);

                            Font fonteCelula =
                                situacao
                                    ? textoNegrito
                                    : texto;

                            g.DrawString(
                                valor,
                                fonteCelula,
                                textoBrush,
                                new RectangleF(
                                    x + 6,
                                    y + 5,
                                    larguras[i] - 12,
                                    17));

                            textoBrush.Dispose();
                            x += larguras[i];
                        }
                    }

                    y += 25;
                    indiceLinhaPdf++;
                }

                // =====================================================
                // RESUMO FINAL
                // =====================================================
                y += 18;

                float resumoAltura = 68;

                if (y + resumoAltura > area.Bottom - 40)
                {
                    DesenharRodape(g, area, paginaPdf, azulEscuro, cinzaTexto);
                    paginaPdf++;
                    e.HasMorePages = true;
                    return;
                }

                Rectangle resumoRect = new Rectangle(
                    area.Left,
                    (int)y,
                    area.Width,
                    (int)resumoAltura);

                using (SolidBrush brush = new SolidBrush(Color.White))
                    g.FillRectangle(brush, resumoRect);

                using (Pen pen = new Pen(cinzaBorda))
                    g.DrawRectangle(pen, resumoRect);

                using (SolidBrush brush = new SolidBrush(azul))
                    g.FillRectangle(
                        brush,
                        resumoRect.Left,
                        resumoRect.Top,
                        5,
                        resumoRect.Height);

                g.DrawString(
                    "Informações do processamento",
                    textoNegrito,
                    new SolidBrush(azulEscuro),
                    resumoRect.Left + 16,
                    resumoRect.Top + 9);

                g.DrawString(
                    "Período: " + lblPeriodo.Text +
                    "   •   Processados: " + lblProcessados.Text,
                    pequeno,
                    new SolidBrush(cinzaTexto),
                    resumoRect.Left + 16,
                    resumoRect.Top + 29);

                g.DrawString(
                    "Situação: " + lblSituacaoFolha.Text +
                    "   •   Gerada em: " + lblGerada.Text,
                    pequeno,
                    new SolidBrush(cinzaTexto),
                    resumoRect.Left + 16,
                    resumoRect.Top + 46);

                DesenharRodape(
                    g,
                    area,
                    paginaPdf,
                    azulEscuro,
                    cinzaTexto);

                e.HasMorePages = false;
                indiceLinhaPdf = 0;
                paginaPdf = 1;
            }
        }

        private void DesenharRodape(
            Graphics g,
            Rectangle area,
            int pagina,
            Color azulEscuro,
            Color cinzaTexto)
        {
            using (Font rodape = new Font("Segoe UI", 7F))
            using (Pen linha = new Pen(Color.FromArgb(220, 226, 232)))
            using (SolidBrush texto = new SolidBrush(cinzaTexto))
            using (SolidBrush marca = new SolidBrush(azulEscuro))
            {
                float y = area.Bottom - 24;

                g.DrawLine(
                    linha,
                    area.Left,
                    y,
                    area.Right,
                    y);

                g.DrawString(
                    "RH CONTROL • Gestão de Pessoas",
                    rodape,
                    marca,
                    area.Left,
                    y + 7);

                string paginaTexto = "Página " + pagina;

                SizeF tamanho =
                    g.MeasureString(paginaTexto, rodape);

                g.DrawString(
                    paginaTexto,
                    rodape,
                    texto,
                    area.Right - tamanho.Width,
                    y + 7);
            }
        }
    }
}
