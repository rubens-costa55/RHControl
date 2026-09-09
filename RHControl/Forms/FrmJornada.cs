using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmJornada : Form
    {
        private long? funcionarioSelecionadoId;
        private string tipoJornada = "Jornada fixa";
        private string escala = "";
        private string diaFolga = "";
        private string diaFolga2 = "";
        private DateTime dataBaseEscala = DateTime.Today;
        private DateTime dataAdmissao = DateTime.Today;

        // Férias programadas do funcionário selecionado.
        private readonly List<(DateTime Inicio, DateTime Fim)> feriasProgramadas = new();
        private readonly List<DateTime> datasDireitoFerias = new();

        private readonly Dictionary<long, string> funcionarios = new();

        private readonly Color corTrabalho = Color.FromArgb(227, 242, 253);
        private readonly Color corFolga = Color.FromArgb(238, 238, 238);
        private readonly Color corPagamento = Color.FromArgb(232, 245, 233);
        private readonly Color corAdiantamento = Color.FromArgb(243, 229, 245);
        private readonly Color corFeriado = Color.FromArgb(255, 235, 238);
        private readonly Color corHoje = Color.FromArgb(21, 101, 192);
        private readonly Color corFerias = Color.FromArgb(255, 243, 224);

        public FrmJornada()
        {
            InitializeComponent();

            ConfigurarEventos();

            // Garante que os períodos de férias sejam criados/atualizados
            // automaticamente a partir da data de admissão.
            FeriasService.SincronizarFerias();

            CarregarMeses();
            CarregarAnos();
            CarregarFuncionarios();

            cmbMes.SelectedIndex = DateTime.Today.Month - 1;
            cmbAno.SelectedItem = DateTime.Today.Year;

            AtualizarDadosFuncionario();
            AtualizarCalendario();
        }

        private void ConfigurarEventos()
        {
            cmbFuncionario.SelectedIndexChanged += (s, e) =>
            {
                AtualizarDadosFuncionario();
                AtualizarCalendario();
            };

            cmbMes.SelectedIndexChanged += (s, e) => AtualizarCalendario();
            cmbAno.SelectedIndexChanged += (s, e) => AtualizarCalendario();

            btnAtualizar.Click += (s, e) =>
            {
                // Reconsulta o banco. Isso faz as alterações do cadastro
                // aparecerem imediatamente no calendário.
                CarregarFuncionarios();
                AtualizarDadosFuncionario();
                AtualizarCalendario();
            };

            btnMesAnterior.Click += (s, e) =>
            {
                if (cmbMes.SelectedIndex > 0)
                    cmbMes.SelectedIndex--;
                else
                {
                    cmbMes.SelectedIndex = 11;
                    if (cmbAno.SelectedItem is int ano)
                        cmbAno.SelectedItem = ano - 1;
                }
            };

            btnProximoMes.Click += (s, e) =>
            {
                if (cmbMes.SelectedIndex < 11)
                    cmbMes.SelectedIndex++;
                else
                {
                    cmbMes.SelectedIndex = 0;
                    if (cmbAno.SelectedItem is int ano)
                        cmbAno.SelectedItem = ano + 1;
                }
            };
        }

        private void CarregarMeses()
        {
            cmbMes.Items.Clear();

            string[] meses =
            {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto",
                "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            cmbMes.Items.AddRange(meses);
        }

        private void CarregarAnos()
        {
            cmbAno.Items.Clear();

            int anoAtual = DateTime.Today.Year;

            for (int ano = anoAtual - 5; ano <= anoAtual + 5; ano++)
                cmbAno.Items.Add(ano);
        }

        private void CarregarFuncionarios()
        {
            long idAnterior = funcionarioSelecionadoId ?? -1;

            funcionarios.Clear();

            using (SqliteConnection connection = Database.GetConnection())
            {
                connection.Open();

                string sql = @"
                    SELECT Id, Nome
                    FROM Funcionarios
                    WHERE Status <> 'Desligado'
                       OR Status IS NULL
                    ORDER BY Nome;";

                using SqliteCommand command = connection.CreateCommand();
                command.CommandText = sql;

                using SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader["Id"]);
                    string nome = reader["Nome"]?.ToString() ?? "";

                    funcionarios[id] = nome;
                }
            }

            cmbFuncionario.Items.Clear();
            cmbFuncionario.Items.Add("Todos os funcionários");

            foreach (KeyValuePair<long, string> item in funcionarios)
                cmbFuncionario.Items.Add(item.Value);

            if (idAnterior > 0 && funcionarios.ContainsKey(idAnterior))
            {
                int indice = 1;

                foreach (KeyValuePair<long, string> item in funcionarios)
                {
                    if (item.Key == idAnterior)
                    {
                        cmbFuncionario.SelectedIndex = indice;
                        return;
                    }

                    indice++;
                }
            }

            // Se ainda não havia funcionário selecionado,
            // abre o calendário com o primeiro funcionário.
            // Assim a escala cadastrada já é aplicada ao calendário.
            if (cmbFuncionario.Items.Count > 1)
                cmbFuncionario.SelectedIndex = 1;
            else if (cmbFuncionario.Items.Count > 0)
                cmbFuncionario.SelectedIndex = 0;
        }

        private void AtualizarDadosFuncionario()
        {
            funcionarioSelecionadoId = null;
            tipoJornada = "Jornada fixa";
            escala = "";
            diaFolga = "";
            diaFolga2 = "";
            dataBaseEscala = DateTime.Today;
            dataAdmissao = DateTime.Today;
            feriasProgramadas.Clear();
            datasDireitoFerias.Clear();

            if (cmbFuncionario.SelectedIndex <= 0)
            {
                this.Text = "RH Control — Jornada / Calendário";
                return;
            }

            string nomeSelecionado = cmbFuncionario.SelectedItem?.ToString() ?? "";

            foreach (KeyValuePair<long, string> item in funcionarios)
            {
                if (string.Equals(item.Value, nomeSelecionado, StringComparison.OrdinalIgnoreCase))
                {
                    funcionarioSelecionadoId = item.Key;
                    break;
                }
            }

            if (!funcionarioSelecionadoId.HasValue)
                return;

            using SqliteConnection connection = Database.GetConnection();
            connection.Open();

            string sql = @"
                SELECT
                    TipoJornada,
                    Escala,
                    DiaFolga,
                    DiaFolga2,
                    DataBaseEscala,
                    DataAdmissao
                FROM Funcionarios
                WHERE Id = $Id;";

            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("$Id", funcionarioSelecionadoId.Value);

            using SqliteDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return;

            tipoJornada = reader["TipoJornada"]?.ToString() ?? "Jornada fixa";
            escala = reader["Escala"]?.ToString() ?? "";
            diaFolga = reader["DiaFolga"]?.ToString() ?? "";
            diaFolga2 = reader["DiaFolga2"]?.ToString() ?? "";

            if (DateTime.TryParse(
                reader["DataBaseEscala"]?.ToString(),
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime baseEscala))
            {
                dataBaseEscala = baseEscala;
            }

            if (DateTime.TryParse(
                reader["DataAdmissao"]?.ToString(),
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime admissao))
            {
                dataAdmissao = admissao;
            }

            if (dataBaseEscala == DateTime.MinValue)
                dataBaseEscala = dataAdmissao;

            CarregarFeriasFuncionario();

            lblMesAno.Text =
                $"{ObterNomeMes()} {ObterAno()}";

            // Mantém a tela sempre sincronizada com o cadastro.
            this.Text =
                funcionarioSelecionadoId.HasValue
                    ? $"Jornada — {nomeSelecionado}"
                    : "Jornada / Calendário";
        }

        private int ObterAno()
        {
            if (cmbAno.SelectedItem is int ano)
                return ano;

            if (int.TryParse(cmbAno.Text, out ano))
                return ano;

            return DateTime.Today.Year;
        }

        private string ObterNomeMes()
        {
            if (cmbMes.SelectedItem != null)
                return cmbMes.SelectedItem.ToString() ?? "";

            return DateTime.Today.ToString("MMMM",
                new CultureInfo("pt-BR"));
        }

        private static bool TentarConverterData(object valor, out DateTime data)
        {
            string texto = valor?.ToString() ?? "";

            if (DateTime.TryParseExact(
                texto,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out data))
            {
                return true;
            }

            if (DateTime.TryParse(
                texto,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out data))
            {
                return true;
            }

            return DateTime.TryParse(
                texto,
                new CultureInfo("pt-BR"),
                DateTimeStyles.None,
                out data);
        }

        private void CarregarFeriasFuncionario()
        {
            feriasProgramadas.Clear();
            datasDireitoFerias.Clear();

            if (!funcionarioSelecionadoId.HasValue)
                return;

            using SqliteConnection connection = Database.GetConnection();
            connection.Open();

            string sql = @"
                SELECT
                    DataDireito,
                    InicioFerias,
                    FimFerias
                FROM Ferias
                WHERE FuncionarioId = $FuncionarioId
                ORDER BY DataDireito;";

            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue(
                "$FuncionarioId",
                funcionarioSelecionadoId.Value);

            using SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (TentarConverterData(reader["DataDireito"], out DateTime direito))
                    datasDireitoFerias.Add(direito.Date);

                if (TentarConverterData(reader["InicioFerias"], out DateTime inicio) &&
                    TentarConverterData(reader["FimFerias"], out DateTime fim) &&
                    fim.Date >= inicio.Date)
                {
                    feriasProgramadas.Add((inicio.Date, fim.Date));
                }
            }
        }

        private bool EhFerias(DateTime data)
        {
            data = data.Date;

            foreach ((DateTime Inicio, DateTime Fim) periodo in feriasProgramadas)
            {
                if (data >= periodo.Inicio && data <= periodo.Fim)
                    return true;
            }

            return false;
        }

        private bool EhDataDireitoFerias(DateTime data)
        {
            return datasDireitoFerias.Contains(data.Date);
        }

        private string ObterInfoFerias(DateTime data)
        {
            foreach ((DateTime Inicio, DateTime Fim) periodo in feriasProgramadas)
            {
                if (data.Date >= periodo.Inicio && data.Date <= periodo.Fim)
                    return $"Férias programadas: {periodo.Inicio:dd/MM/yyyy} a {periodo.Fim:dd/MM/yyyy}";
            }

            if (EhDataDireitoFerias(data))
                return "Direito a férias adquirido nesta data";

            return "";
        }

        private void AtualizarCalendario()
        {
            if (tblCalendario == null)
                return;

            int mes = cmbMes.SelectedIndex + 1;

            if (mes < 1 || mes > 12)
                mes = DateTime.Today.Month;

            int ano = ObterAno();

            lblMesAno.Text =
                $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes).ToUpper()} {ano}";

            PrepararTabelaCalendario(ano, mes);
            MontarDiasCalendario(ano, mes);
            AtualizarResumo(ano, mes);
            AtualizarEventos(ano, mes);
        }

        private int ObterQuantidadeLinhasCalendario(int ano, int mes)
        {
            DateTime primeiroDia = new DateTime(ano, mes, 1);

            int deslocamento =
                ((int)primeiroDia.DayOfWeek + 6) % 7;

            int quantidadeDias =
                DateTime.DaysInMonth(ano, mes);

            int semanas =
                (int)Math.Ceiling(
                    (deslocamento + quantidadeDias) / 7.0);

            return semanas;
        }

        private void PrepararTabelaCalendario(int ano, int mes)
        {
            int semanas =
                ObterQuantidadeLinhasCalendario(ano, mes);

            tblCalendario.SuspendLayout();

            tblCalendario.Controls.Clear();
            tblCalendario.RowStyles.Clear();
            tblCalendario.ColumnStyles.Clear();

            tblCalendario.ColumnCount = 7;
            tblCalendario.RowCount = semanas + 1;

            for (int coluna = 0; coluna < 7; coluna++)
            {
                tblCalendario.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        14.285714f));
            }

            // Cabeçalho dos dias.
            tblCalendario.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    34F));

            // As semanas ocupam TODO o espaço restante.
            float alturaSemana =
                100F / semanas;

            for (int linha = 0; linha < semanas; linha++)
            {
                tblCalendario.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        alturaSemana));
            }

            string[] dias =
            {
                "SEG", "TER", "QUA", "QUI", "SEX", "SÁB", "DOM"
            };

            for (int i = 0; i < dias.Length; i++)
            {
                Label lbl = new Label
                {
                    Text = dias[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(70, 70, 70),
                    Margin = new Padding(1)
                };

                tblCalendario.Controls.Add(lbl, i, 0);
            }

            tblCalendario.ResumeLayout();
        }

        private void MontarDiasCalendario(int ano, int mes)
        {
            DateTime primeiroDia =
                new DateTime(ano, mes, 1);

            int quantidadeDias =
                DateTime.DaysInMonth(ano, mes);

            int deslocamento =
                ((int)primeiroDia.DayOfWeek + 6) % 7;

            for (int dia = 1;
                 dia <= quantidadeDias;
                 dia++)
            {
                DateTime data =
                    new DateTime(ano, mes, dia);

                int indice =
                    deslocamento + dia - 1;

                int coluna =
                    indice % 7;

                int linha =
                    (indice / 7) + 1;

                Button botao =
                    CriarBotaoDia(data);

                tblCalendario.Controls.Add(
                    botao,
                    coluna,
                    linha);
            }
        }

        private Button CriarBotaoDia(DateTime data)
        {
            bool ferias = EhFerias(data);
            bool feriado = EhFeriado(data);
            bool folga = EhFolga(data);
            bool trabalho = !folga && !feriado && !ferias;
            bool hoje = data.Date == DateTime.Today;

            Button botao = new Button
            {
                Text = ferias ? $"{data.Day}\nFÉRIAS" : data.Day.ToString(),
                Dock = DockStyle.Fill,
                Margin = new Padding(2),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", ferias ? 8.5F : 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(8, 6, 3, 3),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                Tag = data
            };

            botao.FlatAppearance.BorderSize = hoje ? 2 : 1;

            if (ferias)
            {
                botao.BackColor = corFerias;
                botao.ForeColor = Color.FromArgb(230, 126, 34);
                botao.FlatAppearance.BorderColor =
                    Color.FromArgb(255, 204, 128);
            }
            else if (feriado)
            {
                botao.BackColor = corFeriado;
                botao.ForeColor = Color.FromArgb(183, 28, 28);
                botao.FlatAppearance.BorderColor =
                    Color.FromArgb(239, 154, 154);
            }
            else if (folga)
            {
                botao.BackColor = corFolga;
                botao.ForeColor = Color.FromArgb(90, 90, 90);
                botao.FlatAppearance.BorderColor =
                    Color.FromArgb(210, 210, 210);
            }
            else
            {
                botao.BackColor = corTrabalho;
                botao.ForeColor = Color.FromArgb(21, 101, 192);
                botao.FlatAppearance.BorderColor =
                    Color.FromArgb(187, 222, 251);
            }

            if (!ferias && EhAdiantamento(data))
            {
                botao.BackColor = corAdiantamento;
                botao.ForeColor = Color.FromArgb(106, 27, 154);
            }

            if (!ferias && EhPagamento(data))
            {
                botao.BackColor = corPagamento;
                botao.ForeColor = Color.FromArgb(46, 125, 50);
            }

            if (hoje)
            {
                botao.FlatAppearance.BorderColor = corHoje;
                botao.FlatAppearance.BorderSize = 2;
            }

            botao.Click += (s, e) =>
            {
                MostrarDetalhesDia(data);
            };

            return botao;
        }

        private bool EhFolga(DateTime data)
        {
            if (data.Date < dataAdmissao.Date)
                return false;

            string diaSemana = ObterDiaSemana(data.DayOfWeek);

            // As folgas informadas no cadastro têm prioridade.
            if (!string.IsNullOrWhiteSpace(diaFolga) &&
                string.Equals(diaSemana, diaFolga,
                    StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (!string.IsNullOrWhiteSpace(diaFolga2) &&
                string.Equals(diaSemana, diaFolga2,
                    StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (string.Equals(tipoJornada, "Jornada fixa",
                StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(escala))
                return false;

            DateTime baseEscala =
                dataBaseEscala.Date >= dataAdmissao.Date
                    ? dataBaseEscala.Date
                    : dataAdmissao.Date;

            int diferenca = (data.Date - baseEscala.Date).Days;

            if (diferenca < 0)
                return false;

            switch (escala.Trim().ToLowerInvariant())
            {
                case "5x2":
                    return (diferenca % 7) >= 5;

                case "6x1":
                    return (diferenca % 7) == 6;

                case "12x36":
                    return (diferenca % 2) == 1;

                case "4x2":
                    return (diferenca % 6) >= 4;

                case "5x1":
                    return (diferenca % 6) == 5;

                default:
                    return false;
            }
        }

        private string ObterDiaSemana(DayOfWeek dia)
        {
            return dia switch
            {
                DayOfWeek.Sunday => "Domingo",
                DayOfWeek.Monday => "Segunda-feira",
                DayOfWeek.Tuesday => "Terça-feira",
                DayOfWeek.Wednesday => "Quarta-feira",
                DayOfWeek.Thursday => "Quinta-feira",
                DayOfWeek.Friday => "Sexta-feira",
                DayOfWeek.Saturday => "Sábado",
                _ => ""
            };
        }

        private bool EhFeriado(DateTime data)
        {
            int mes = data.Month;
            int dia = data.Day;

            return (mes == 1 && dia == 1) ||
                   (mes == 4 && dia == 21) ||
                   (mes == 5 && dia == 1) ||
                   (mes == 9 && dia == 7) ||
                   (mes == 10 && dia == 12) ||
                   (mes == 11 && dia == 2) ||
                   (mes == 11 && dia == 15) ||
                   (mes == 11 && dia == 20) ||
                   (mes == 12 && dia == 25);
        }

        private bool EhAdiantamento(DateTime data)
        {
            return data.Day == 20;
        }

        private bool EhPagamento(DateTime data)
        {
            return data == ObterQuintoDiaUtilDoMes(data.Year, data.Month);
        }

        private DateTime ObterQuintoDiaUtilDoMes(int ano, int mes)
        {
            DateTime data = new DateTime(ano, mes, 1);
            int contador = 0;

            while (true)
            {
                // Para a regra padrão utilizada no sistema,
                // segunda a sábado são considerados dias úteis.
                if (data.DayOfWeek != DayOfWeek.Sunday)
                    contador++;

                if (contador == 5)
                    return data;

                data = data.AddDays(1);
            }
        }

        private void AtualizarResumo(int ano, int mes)
        {
            DateTime inicio = new DateTime(ano, mes, 1);
            int totalDias = DateTime.DaysInMonth(ano, mes);

            int diasUteis = 0;
            int diasTrabalhados = 0;
            int folgas = 0;
            int ferias = 0;
            int faltas = 0;
            double horas = 0;

            bool calendarioIndividual =
                funcionarioSelecionadoId.HasValue;

            for (int dia = 1; dia <= totalDias; dia++)
            {
                DateTime data = new DateTime(ano, mes, dia);

                if (data.DayOfWeek != DayOfWeek.Sunday &&
                    !EhFeriado(data))
                {
                    diasUteis++;
                }

                if (calendarioIndividual)
                {
                    if (EhFerias(data))
                    {
                        ferias++;
                    }
                    else if (EhFolga(data))
                    {
                        folgas++;
                    }
                    else if (data >= dataAdmissao &&
                             !EhFeriado(data))
                    {
                        diasTrabalhados++;
                        horas += ObterHorasDiarias();
                    }
                }
            }

            lblDiasUteis.Text = $"Dias úteis: {diasUteis}";
            lblDiasTrabalhados.Text =
                $"Trabalhados: {diasTrabalhados}";
            lblFolgas.Text = $"Folgas: {folgas}";
            lblFerias.Text = $"Férias: {ferias}";
            lblFaltas.Text = $"Faltas: {faltas}";
            lblHoras.Text =
                $"Horas previstas: {FormatarHoras(horas)}";
        }

        private double ObterHorasDiarias()
        {
            if (!funcionarioSelecionadoId.HasValue)
                return 8;

            using SqliteConnection connection = Database.GetConnection();
            connection.Open();

            string sql = @"
                SELECT
                    HorarioEntrada,
                    HorarioSaida,
                    InicioIntervalo,
                    FimIntervalo
                FROM Funcionarios
                WHERE Id = $Id;";

            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue(
                "$Id", funcionarioSelecionadoId.Value);

            using SqliteDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return 8;

            if (!TimeSpan.TryParse(
                reader["HorarioEntrada"]?.ToString(),
                out TimeSpan entrada))
                return 8;

            if (!TimeSpan.TryParse(
                reader["HorarioSaida"]?.ToString(),
                out TimeSpan saida))
                return 8;

            double total = (saida - entrada).TotalHours;

            if (TimeSpan.TryParse(
                reader["InicioIntervalo"]?.ToString(),
                out TimeSpan inicioIntervalo) &&
                TimeSpan.TryParse(
                reader["FimIntervalo"]?.ToString(),
                out TimeSpan fimIntervalo))
            {
                total -= (fimIntervalo - inicioIntervalo).TotalHours;
            }

            return total > 0 ? total : 8;
        }

        private string FormatarHoras(double horas)
        {
            int horasInteiras = (int)Math.Floor(horas);
            int minutos = (int)Math.Round(
                (horas - horasInteiras) * 60);

            if (minutos == 60)
            {
                horasInteiras++;
                minutos = 0;
            }

            return $"{horasInteiras:00}h{minutos:00}";
        }

        private void AtualizarEventos(int ano, int mes)
        {
            Label[] datas =
            {
                lblEvento1Data,
                lblEvento2Data,
                lblEvento3Data,
                lblEvento4Data,
                lblEvento5Data
            };

            Label[] titulos =
            {
                lblEvento1Titulo,
                lblEvento2Titulo,
                lblEvento3Titulo,
                lblEvento4Titulo,
                lblEvento5Titulo
            };

            Label[] infos =
            {
                lblEvento1Info,
                lblEvento2Info,
                lblEvento3Info,
                lblEvento4Info,
                lblEvento5Info
            };

            for (int i = 0; i < 5; i++)
            {
                datas[i].Text = "";
                titulos[i].Text = "";
                infos[i].Text = "";
            }

            List<(DateTime Data, string Titulo, string Info)> eventos = new();

            DateTime pagamento =
                ObterQuintoDiaUtilDoMes(ano, mes);

            eventos.Add((
                pagamento,
                "Pagamento",
                "5º dia útil — previsão de pagamento"));

            DateTime adiantamento =
                new DateTime(ano, mes, 20);

            eventos.Add((
                adiantamento,
                "Adiantamento",
                "Previsão de adiantamento"));

            if (funcionarioSelecionadoId.HasValue)
            {
                eventos.Add((
                    dataBaseEscala,
                    "Data-base da escala",
                    $"Escala {escala} — folga: {diaFolga}"));

                DateTime admissao =
                    dataAdmissao.Date;

                if (admissao.Year == ano &&
                    admissao.Month == mes)
                {
                    eventos.Add((
                        admissao,
                        "Admissão",
                        "Data de admissão do funcionário"));
                }
            }

            if (funcionarioSelecionadoId.HasValue)
            {
                foreach (DateTime direito in datasDireitoFerias)
                {
                    if (direito.Year == ano && direito.Month == mes)
                    {
                        eventos.Add((
                            direito,
                            "Direito a férias",
                            "Período aquisitivo concluído — férias disponíveis"));
                    }
                }

                foreach ((DateTime Inicio, DateTime Fim) periodo in feriasProgramadas)
                {
                    if (periodo.Inicio.Year == ano && periodo.Inicio.Month == mes)
                    {
                        eventos.Add((
                            periodo.Inicio,
                            "Início das férias",
                            $"Férias programadas até {periodo.Fim:dd/MM/yyyy}"));
                    }
                }
            }

            eventos.Sort((a, b) =>
                a.Data.CompareTo(b.Data));

            for (int i = 0; i < Math.Min(5, eventos.Count); i++)
            {
                datas[i].Text =
                    eventos[i].Data.ToString("dd/MM");

                titulos[i].Text =
                    eventos[i].Titulo;

                infos[i].Text =
                    eventos[i].Info;
            }
        }

        private void MostrarDetalhesDia(DateTime data)
        {
            lblDataSelecionada.Text =
                data.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                    new CultureInfo("pt-BR"));

            string situacao;

            if (EhFerias(data))
                situacao = "FÉRIAS";
            else if (EhFeriado(data))
                situacao = "FERIADO";
            else if (EhFolga(data))
                situacao = "FOLGA";
            else
                situacao = "TRABALHO";

            string eventos = "";

            string infoFerias = ObterInfoFerias(data);
            if (!string.IsNullOrWhiteSpace(infoFerias))
                eventos += $"\n• {infoFerias}";

            if (EhPagamento(data) && !EhFerias(data))
                eventos += "\n• Pagamento — 5º dia útil";

            if (EhAdiantamento(data) && !EhFerias(data))
                eventos += "\n• Adiantamento — dia 20";

            if (funcionarioSelecionadoId.HasValue &&
                data.Date == dataBaseEscala.Date)
            {
                eventos +=
                    $"\n• Data-base da escala — {escala}";
            }

            MessageBox.Show(
                $"Data: {data:dd/MM/yyyy}\n" +
                $"Situação: {situacao}\n" +
                $"Escala: {escala}\n" +
                $"Folga principal: {diaFolga}" +
                (string.IsNullOrWhiteSpace(diaFolga2)
                    ? ""
                    : $"\nSegunda folga: {diaFolga2}") +
                eventos,
                "Detalhes da jornada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
