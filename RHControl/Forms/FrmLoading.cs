using System;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmLoading : Form
    {
        private int progresso = 0;

        public FrmLoading()
        {
            InitializeComponent();

            timerLoading.Tick += TimerLoading_Tick;
            timerLoading.Start();
        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            progresso += 2;

            progressBar.Value = progresso;
            lblPorcentagem.Text = progresso + "%";

            if (progresso < 25)
            {
                lblStatus.Text = "Inicializando o sistema...";
            }
            else if (progresso < 50)
            {
                lblStatus.Text = "Verificando banco de dados...";
            }
            else if (progresso < 70)
            {
                lblStatus.Text = "Carregando configurações...";
            }
            else if (progresso < 90)
            {
                lblStatus.Text = "Carregando módulos...";
            }
            else
            {
                lblStatus.Text = "Preparando o sistema...";
            }

            if (progresso >= 100)
            {
                timerLoading.Stop();

                FrmLogin login = new FrmLogin();

                login.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                login.Show();
                this.Hide();
            }
        }
    }
}