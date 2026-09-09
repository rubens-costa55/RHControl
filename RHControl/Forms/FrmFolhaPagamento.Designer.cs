using System.Drawing;
using System.Windows.Forms;

namespace RHControl.Forms
{
    partial class FrmFolhaPagamento
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlMenu;
        private PictureBox picLogo;
        private Label lblNomeSistema;
        private Label lblSubtituloMenu;
        private Button btnDashboard;
        private Button btnFuncionarios;
        private Button btnJornada;
        private Button btnFolha;
        private Button btnConfiguracoes;
        private Label lblVersao;

        private Panel pnlConteudo;
        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;

        private Panel pnlFiltros;
        private Label lblMes;
        private Label lblAno;
        private Label lblDepartamento;
        private Label lblSituacaoFiltro;
        private ComboBox cmbMes;
        private ComboBox cmbAno;
        private ComboBox cmbDepartamento;
        private ComboBox cmbSituacao;
        private Button btnFiltrar;

        private Panel pnlCardFuncionarios;
        private Panel pnlCardBruto;
        private Panel pnlCardDescontos;
        private Panel pnlCardLiquido;
        private Panel pnlCardHoras;

        private Label lblCardFuncionariosTitulo;
        private Label lblFuncionariosValor;
        private Label lblFuncionariosInfo;
        private Label lblCardBrutoTitulo;
        private Label lblBrutoValor;
        private Label lblBrutoInfo;
        private Label lblCardDescontosTitulo;
        private Label lblDescontosValor;
        private Label lblDescontosInfo;
        private Label lblCardLiquidoTitulo;
        private Label lblLiquidoValor;
        private Label lblLiquidoInfo;
        private Label lblCardHorasTitulo;
        private Label lblHorasValor;
        private Label lblHorasInfo;

        private Panel pnlLista;
        private Label lblListaTitulo;
        private TextBox txtPesquisar;
        private DataGridView dgvFuncionarios;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCargo;
        private DataGridViewTextBoxColumn colSalario;
        private DataGridViewTextBoxColumn colDescontos;
        private DataGridViewTextBoxColumn colLiquido;
        private DataGridViewTextBoxColumn colHorasExtras;
        private DataGridViewTextBoxColumn colStatus;

        private Panel pnlResumo;
        private Label lblResumoTitulo;
        private Label lblPeriodoTitulo;
        private Label lblPeriodo;
        private Label lblProcessadosTitulo;
        private Label lblProcessados;
        private ProgressBar progressProcessados;
        private Label lblGeradaTitulo;
        private Label lblGerada;
        private Label lblSituacaoTitulo;
        private Label lblSituacaoFolha;
        private Label lblObservacoesTitulo;
        private Label lblObservacoes;

        private Panel pnlAcoes;
        private Button btnGerarFolha;
        private Button btnRelatorioSintetico;
        private Button btnRelatorioAnalitico;
        private Button btnImprimir;
        private Button btnExportar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlMenu = new Panel();
            this.picLogo = new PictureBox();
            this.lblNomeSistema = new Label();
            this.lblSubtituloMenu = new Label();
            this.btnDashboard = new Button();
            this.btnFuncionarios = new Button();
            this.btnJornada = new Button();
            this.btnFolha = new Button();
            this.btnConfiguracoes = new Button();
            this.lblVersao = new Label();

            this.pnlConteudo = new Panel();
            this.pnlCabecalho = new Panel();
            this.lblTitulo = new Label();
            this.lblSubtitulo = new Label();
            this.lblUsuario = new Label();

            this.pnlFiltros = new Panel();
            this.lblMes = new Label();
            this.lblAno = new Label();
            this.lblDepartamento = new Label();
            this.lblSituacaoFiltro = new Label();
            this.cmbMes = new ComboBox();
            this.cmbAno = new ComboBox();
            this.cmbDepartamento = new ComboBox();
            this.cmbSituacao = new ComboBox();
            this.btnFiltrar = new Button();

            this.pnlCardFuncionarios = new Panel();
            this.pnlCardBruto = new Panel();
            this.pnlCardDescontos = new Panel();
            this.pnlCardLiquido = new Panel();
            this.pnlCardHoras = new Panel();

            this.lblCardFuncionariosTitulo = new Label();
            this.lblFuncionariosValor = new Label();
            this.lblFuncionariosInfo = new Label();
            this.lblCardBrutoTitulo = new Label();
            this.lblBrutoValor = new Label();
            this.lblBrutoInfo = new Label();
            this.lblCardDescontosTitulo = new Label();
            this.lblDescontosValor = new Label();
            this.lblDescontosInfo = new Label();
            this.lblCardLiquidoTitulo = new Label();
            this.lblLiquidoValor = new Label();
            this.lblLiquidoInfo = new Label();
            this.lblCardHorasTitulo = new Label();
            this.lblHorasValor = new Label();
            this.lblHorasInfo = new Label();

            this.pnlLista = new Panel();
            this.lblListaTitulo = new Label();
            this.txtPesquisar = new TextBox();
            this.dgvFuncionarios = new DataGridView();
            this.colNome = new DataGridViewTextBoxColumn();
            this.colCargo = new DataGridViewTextBoxColumn();
            this.colSalario = new DataGridViewTextBoxColumn();
            this.colDescontos = new DataGridViewTextBoxColumn();
            this.colLiquido = new DataGridViewTextBoxColumn();
            this.colHorasExtras = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewTextBoxColumn();

            this.pnlResumo = new Panel();
            this.lblResumoTitulo = new Label();
            this.lblPeriodoTitulo = new Label();
            this.lblPeriodo = new Label();
            this.lblProcessadosTitulo = new Label();
            this.lblProcessados = new Label();
            this.progressProcessados = new ProgressBar();
            this.lblGeradaTitulo = new Label();
            this.lblGerada = new Label();
            this.lblSituacaoTitulo = new Label();
            this.lblSituacaoFolha = new Label();
            this.lblObservacoesTitulo = new Label();
            this.lblObservacoes = new Label();

            this.pnlAcoes = new Panel();
            this.btnGerarFolha = new Button();
            this.btnRelatorioSintetico = new Button();
            this.btnRelatorioAnalitico = new Button();
            this.btnImprimir = new Button();
            this.btnExportar = new Button();

            // FORM
            this.SuspendLayout();
            this.Text = "Folha de Pagamento — RH Control";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1260, 760);
            this.MinimumSize = new Size(1100, 680);
            this.BackColor = Color.FromArgb(246, 248, 251);
            this.Font = new Font("Segoe UI", 9F);

            // MENU
            this.pnlMenu.BackColor = Color.FromArgb(15, 73, 116);
            this.pnlMenu.Dock = DockStyle.Left;
            this.pnlMenu.Width = 215;
            this.pnlMenu.Controls.AddRange(new Control[] {
                this.picLogo, this.lblNomeSistema, this.lblSubtituloMenu,
                this.btnDashboard, this.btnFuncionarios, this.btnJornada,
                this.btnFolha, this.btnConfiguracoes, this.lblVersao
            });

            this.picLogo.BackColor = Color.FromArgb(15, 73, 116);
            this.picLogo.Location = new Point(52, 36);
            this.picLogo.Size = new Size(110, 86);
            this.picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;

            this.lblNomeSistema.AutoSize = false;
            this.lblNomeSistema.Text = "RH CONTROL";
            this.lblNomeSistema.ForeColor = Color.White;
            this.lblNomeSistema.Font = new Font("Segoe UI Semibold", 17F);
            this.lblNomeSistema.TextAlign = ContentAlignment.MiddleCenter;
            this.lblNomeSistema.Location = new Point(15, 126);
            this.lblNomeSistema.Size = new Size(185, 32);

            this.lblSubtituloMenu.AutoSize = false;
            this.lblSubtituloMenu.Text = "GESTÃO DE PESSOAS";
            this.lblSubtituloMenu.ForeColor = Color.FromArgb(205, 224, 240);
            this.lblSubtituloMenu.Font = new Font("Segoe UI", 8F);
            this.lblSubtituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSubtituloMenu.Location = new Point(15, 154);
            this.lblSubtituloMenu.Size = new Size(185, 22);

            ConfigurarMenuButton(this.btnDashboard, "⌂   Dashboard", 210);
            ConfigurarMenuButton(this.btnFuncionarios, "♙   Funcionários", 258);
            ConfigurarMenuButton(this.btnJornada, "▣   Jornada / Calendário", 306);
            ConfigurarMenuButton(this.btnFolha, "▤   Folha / Relatórios", 354);
            this.btnFolha.BackColor = Color.FromArgb(31, 126, 215);
            this.btnFolha.ForeColor = Color.White;
            ConfigurarMenuButton(this.btnConfiguracoes, "⚙   Configurações", 402);

            this.lblVersao.AutoSize = false;
            this.lblVersao.Text = "RH Control • v1.0";
            this.lblVersao.ForeColor = Color.FromArgb(190, 211, 228);
            this.lblVersao.Font = new Font("Segoe UI", 8F);
            this.lblVersao.TextAlign = ContentAlignment.MiddleCenter;
            this.lblVersao.Location = new Point(15, 700);
            this.lblVersao.Size = new Size(185, 25);
            this.lblVersao.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            // CONTEÚDO
            this.pnlConteudo.Dock = DockStyle.Fill;
            this.pnlConteudo.BackColor = Color.FromArgb(246, 248, 251);
            this.pnlConteudo.Padding = new Padding(22, 0, 18, 16);
            this.pnlConteudo.Controls.Add(this.pnlAcoes);
            this.pnlConteudo.Controls.Add(this.pnlResumo);
            this.pnlConteudo.Controls.Add(this.pnlLista);
            this.pnlConteudo.Controls.Add(this.pnlCardHoras);
            this.pnlConteudo.Controls.Add(this.pnlCardLiquido);
            this.pnlConteudo.Controls.Add(this.pnlCardDescontos);
            this.pnlConteudo.Controls.Add(this.pnlCardBruto);
            this.pnlConteudo.Controls.Add(this.pnlCardFuncionarios);
            this.pnlConteudo.Controls.Add(this.pnlFiltros);
            this.pnlConteudo.Controls.Add(this.pnlCabecalho);

            // CABEÇALHO
            this.pnlCabecalho.Dock = DockStyle.Top;
            this.pnlCabecalho.Height = 92;
            this.pnlCabecalho.BackColor = Color.White;
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Controls.Add(this.lblUsuario);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Text = "Folha de Pagamento";
            this.lblTitulo.Font = new Font("Segoe UI Semibold", 24F);
            this.lblTitulo.ForeColor = Color.FromArgb(15, 56, 92);
            this.lblTitulo.Location = new Point(24, 17);

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Text = "Processamento da folha, relatórios e informações financeiras";
            this.lblSubtitulo.Font = new Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = Color.FromArgb(105, 118, 132);
            this.lblSubtitulo.Location = new Point(26, 58);

            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Text = "♙  Administrador";
            this.lblUsuario.Font = new Font("Segoe UI Semibold", 9F);
            this.lblUsuario.ForeColor = Color.FromArgb(18, 103, 181);
            this.lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblUsuario.Location = new Point(1025, 34);

            // FILTROS
            this.pnlFiltros.Dock = DockStyle.Top;
            this.pnlFiltros.Height = 92;
            this.pnlFiltros.BackColor = Color.White;
            this.pnlFiltros.Padding = new Padding(18, 12, 12, 10);

            ConfigurarLabel(this.lblMes, "Mês", 18, 10);
            ConfigurarLabel(this.lblAno, "Ano", 178, 10);
            ConfigurarLabel(this.lblDepartamento, "Departamento", 328, 10);
            ConfigurarLabel(this.lblSituacaoFiltro, "Situação", 550, 10);

            ConfigurarCombo(this.cmbMes, 18, 32, 128, "Setembro");
            ConfigurarCombo(this.cmbAno, 178, 32, 110, "2026");
            ConfigurarCombo(this.cmbDepartamento, 328, 32, 195, "Todos os departamentos");
            ConfigurarCombo(this.cmbSituacao, 550, 32, 160, "Todos");

            this.btnFiltrar.Text = "⌕  Filtrar";
            this.btnFiltrar.Location = new Point(725, 30);
            this.btnFiltrar.Size = new Size(105, 38);
            this.btnFiltrar.BackColor = Color.FromArgb(31, 126, 215);
            this.btnFiltrar.ForeColor = Color.White;
            this.btnFiltrar.FlatStyle = FlatStyle.Flat;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.Font = new Font("Segoe UI Semibold", 9F);
            this.btnFiltrar.Cursor = Cursors.Hand;
            this.pnlFiltros.Controls.AddRange(new Control[] {
                this.lblMes, this.lblAno, this.lblDepartamento, this.lblSituacaoFiltro,
                this.cmbMes, this.cmbAno, this.cmbDepartamento, this.cmbSituacao,
                this.btnFiltrar
            });

            // CARDS
            ConfigurarCard(this.pnlCardFuncionarios, 0, "♙", "Funcionários", "25", "Ativos no período");
            ConfigurarCard(this.pnlCardBruto, 1, "$", "Salário bruto", "R$ 87.450,00", "Total de proventos");
            ConfigurarCard(this.pnlCardDescontos, 2, "−", "Descontos", "R$ 18.320,00", "Total de descontos");
            ConfigurarCard(this.pnlCardLiquido, 3, "▣", "Salário líquido", "R$ 69.130,00", "Total a pagar");
            ConfigurarCard(this.pnlCardHoras, 4, "◷", "Horas extras", "320h", "Total no período");

            // LISTA
            this.pnlLista.BackColor = Color.White;
            this.pnlLista.BorderStyle = BorderStyle.FixedSingle;
            this.pnlLista.Location = new Point(22, 360);
            this.pnlLista.Size = new Size(790, 235);
            this.pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            this.pnlLista.Controls.Add(this.dgvFuncionarios);
            this.pnlLista.Controls.Add(this.txtPesquisar);
            this.pnlLista.Controls.Add(this.lblListaTitulo);

            this.lblListaTitulo.AutoSize = true;
            this.lblListaTitulo.Text = "Funcionários na folha (Setembro/2026)";
            this.lblListaTitulo.Font = new Font("Segoe UI Semibold", 12F);
            this.lblListaTitulo.ForeColor = Color.FromArgb(20, 55, 87);
            this.lblListaTitulo.Location = new Point(18, 15);

            this.txtPesquisar.Text = "Pesquisar funcionário...";
            this.txtPesquisar.ForeColor = Color.Gray;
            this.txtPesquisar.Location = new Point(535, 12);
            this.txtPesquisar.Size = new Size(205, 27);
            this.txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.dgvFuncionarios.Location = new Point(14, 48);
            this.dgvFuncionarios.Size = new Size(760, 170);
            this.dgvFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.BackgroundColor = Color.White;
            this.dgvFuncionarios.BorderStyle = BorderStyle.None;
            this.dgvFuncionarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 247, 250);
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(55, 68, 82);
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 8.5F);
            this.dgvFuncionarios.ColumnHeadersHeight = 34;
            this.dgvFuncionarios.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F);
            this.dgvFuncionarios.DefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 65);
            this.dgvFuncionarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 242, 252);
            this.dgvFuncionarios.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 55, 85);
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.AutoGenerateColumns = false;
            this.dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] {
                this.colNome, this.colCargo, this.colSalario, this.colDescontos,
                this.colLiquido, this.colHorasExtras, this.colStatus
            });

            ConfigurarColuna(this.colNome, "Funcionário", 150);
            ConfigurarColuna(this.colCargo, "Cargo", 115);
            ConfigurarColuna(this.colSalario, "Bruto", 90);
            ConfigurarColuna(this.colDescontos, "Descontos", 90);
            ConfigurarColuna(this.colLiquido, "Líquido", 90);
            ConfigurarColuna(this.colHorasExtras, "Horas extras", 85);
            ConfigurarColuna(this.colStatus, "Situação", 85);

            // RESUMO
            this.pnlResumo.BackColor = Color.White;
            this.pnlResumo.BorderStyle = BorderStyle.FixedSingle;
            this.pnlResumo.Location = new Point(824, 360);
            this.pnlResumo.Size = new Size(250, 235);
            this.pnlResumo.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            this.pnlResumo.Controls.AddRange(new Control[] {
                this.lblResumoTitulo, this.lblPeriodoTitulo, this.lblPeriodo,
                this.lblProcessadosTitulo, this.lblProcessados, this.progressProcessados,
                this.lblGeradaTitulo, this.lblGerada, this.lblSituacaoTitulo,
                this.lblSituacaoFolha, this.lblObservacoesTitulo, this.lblObservacoes
            });

            ConfigurarResumoLabel(this.lblResumoTitulo, "Resumo do período", 18, 14, 12F, true);
            ConfigurarResumoLabel(this.lblPeriodoTitulo, "Período de referência", 18, 46, 7.5F, false);
            ConfigurarResumoLabel(this.lblPeriodo, "01/09/2026 a 30/09/2026", 18, 62, 8.5F, true);
            ConfigurarResumoLabel(this.lblProcessadosTitulo, "Funcionários processados", 18, 91, 7.5F, false);
            ConfigurarResumoLabel(this.lblProcessados, "25 de 25", 18, 107, 8.5F, true);

            this.progressProcessados.Location = new Point(18, 126);
            this.progressProcessados.Size = new Size(210, 8);
            this.progressProcessados.Value = 100;

            ConfigurarResumoLabel(this.lblGeradaTitulo, "Folha gerada em", 18, 143, 7.5F, false);
            ConfigurarResumoLabel(this.lblGerada, "28/09/2026 às 14:32", 18, 159, 8.5F, true);
            ConfigurarResumoLabel(this.lblSituacaoTitulo, "Situação da folha", 18, 184, 7.5F, false);
            ConfigurarResumoLabel(this.lblSituacaoFolha, "●  Processada", 18, 200, 8.5F, true);
            this.lblSituacaoFolha.ForeColor = Color.FromArgb(0, 145, 75);
            ConfigurarResumoLabel(this.lblObservacoesTitulo, "Observações", 18, 222, 7.5F, false);
            this.lblObservacoes.Text = "Folha processada sem inconsistências.";
            this.lblObservacoes.Font = new Font("Segoe UI Semibold", 7.5F);
            this.lblObservacoes.ForeColor = Color.FromArgb(35, 55, 75);
            this.lblObservacoes.Location = new Point(18, 238);
            this.lblObservacoes.Size = new Size(215, 30);

            // AÇÕES
            this.pnlAcoes.BackColor = Color.White;
            this.pnlAcoes.BorderStyle = BorderStyle.FixedSingle;
            this.pnlAcoes.Dock = DockStyle.Bottom;
            this.pnlAcoes.Height = 70;
            this.pnlAcoes.Padding = new Padding(10);
            this.pnlAcoes.Controls.AddRange(new Control[] {
                this.btnGerarFolha, this.btnRelatorioSintetico, this.btnRelatorioAnalitico,
                this.btnImprimir, this.btnExportar
            });

            ConfigurarAcao(this.btnGerarFolha, "▣  Gerar Folha", 10, true, 145);
            ConfigurarAcao(this.btnRelatorioSintetico, "■  Relatório Sintético", 165, false, 155);
            ConfigurarAcao(this.btnRelatorioAnalitico, "▤  Relatório Analítico", 330, false, 160);
            ConfigurarAcao(this.btnImprimir, "▣  Imprimir", 500, false, 130);
            ConfigurarAcao(this.btnExportar, "⇩  Exportar", 640, false, 130);

            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.ResumeLayout(false);
        }

        private void ConfigurarMenuButton(Button b, string texto, int y)
        {
            b.BackColor = Color.FromArgb(15, 73, 116);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 96, 145);
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 111, 165);
            b.ForeColor = Color.FromArgb(235, 242, 248);
            b.Font = new Font("Segoe UI", 9F);
            b.Text = texto;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Padding = new Padding(18, 0, 0, 0);
            b.Location = new Point(10, y);
            b.Size = new Size(195, 42);
            b.Cursor = Cursors.Hand;
            b.FlatAppearance.BorderColor = Color.Transparent;
            this.pnlMenu.Controls.Add(b);
        }

        private void ConfigurarLabel(Label l, string texto, int x, int y)
        {
            l.AutoSize = true;
            l.Text = texto;
            l.Font = new Font("Segoe UI Semibold", 8F);
            l.ForeColor = Color.FromArgb(75, 88, 102);
            l.Location = new Point(x, y);
        }

        private void ConfigurarCombo(ComboBox c, int x, int y, int w, string texto)
        {
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            c.Location = new Point(x, y);
            c.Size = new Size(w, 28);
            c.Font = new Font("Segoe UI", 8.5F);
            c.Items.Add(texto);
            c.SelectedIndex = 0;
        }

        private void ConfigurarCard(Panel p, int indice, string icone, string titulo, string valor, string info)
        {
            int x = 0;
            int w = 150;
            int gap = 12;
            x = 22 + indice * (w + gap);

            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Location = new Point(x, 202);
            p.Size = new Size(w, 108);
            p.Controls.Add(new Label());
            p.Controls.Add(new Label());
            p.Controls.Add(new Label());

            Label icon = p.Controls[2] as Label;
            Label title = p.Controls[1] as Label;
            Label valueLabel = p.Controls[0] as Label;

            icon.Text = icone;
            icon.TextAlign = ContentAlignment.MiddleCenter;
            icon.BackColor = Color.FromArgb(235, 243, 252);
            icon.ForeColor = Color.FromArgb(20, 105, 185);
            icon.Font = new Font("Segoe UI Semibold", 13F);
            icon.Location = new Point(12, 16);
            icon.Size = new Size(38, 38);

            title.Text = titulo;
            title.Font = new Font("Segoe UI", 7.5F);
            title.ForeColor = Color.FromArgb(105, 116, 130);
            title.Location = new Point(58, 15);
            title.Size = new Size(82, 18);

            valueLabel.Text = valor;
            valueLabel.Font = new Font("Segoe UI Semibold", 11F);
            valueLabel.ForeColor = Color.FromArgb(18, 77, 125);
            valueLabel.Location = new Point(58, 34);
            valueLabel.Size = new Size(82, 24);
            valueLabel.AutoEllipsis = true;

            Label infoLabel = new Label();
            infoLabel.Text = info;
            infoLabel.Font = new Font("Segoe UI", 7.5F);
            infoLabel.ForeColor = Color.FromArgb(115, 125, 138);
            infoLabel.Location = new Point(12, 77);
            infoLabel.Size = new Size(126, 18);
            infoLabel.AutoEllipsis = true;
            p.Controls.Add(infoLabel);

            if (indice == 2)
                valueLabel.ForeColor = Color.FromArgb(195, 55, 55);
        }

        private void ConfigurarColuna(DataGridViewTextBoxColumn c, string header, int width)
        {
            c.HeaderText = header;
            c.Width = width;
            c.ReadOnly = true;
        }

        private void ConfigurarResumoLabel(Label l, string texto, int x, int y, float tamanho, bool destaque)
        {
            l.AutoSize = false;
            l.Text = texto;
            l.Font = new Font(destaque ? "Segoe UI Semibold" : "Segoe UI", tamanho);
            l.ForeColor = destaque ? Color.FromArgb(18, 77, 125) : Color.FromArgb(105, 116, 130);
            l.Location = new Point(x, y);
            l.Size = new Size(215, destaque ? 20 : 15);
        }

        private void ConfigurarAcao(Button b, string texto, int x, bool principal, int w)
        {
            b.Text = texto;
            b.Location = new Point(x, 10);
            b.Size = new Size(w, 38);
            b.Font = new Font("Segoe UI Semibold", 8.5F);
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;

            if (principal)
            {
                b.BackColor = Color.FromArgb(31, 126, 215);
                b.ForeColor = Color.White;
                b.FlatAppearance.BorderColor = Color.FromArgb(31, 126, 215);
            }
            else
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(31, 91, 145);
                b.FlatAppearance.BorderColor = Color.FromArgb(205, 216, 227);
            }
        }
    }
}
