using System;
using System.Windows.Forms;
using RHControl.Forms;

namespace RHControl
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            btnFuncionarios.Click += BtnFuncionarios_Click;
            btnJornada.Click += BtnJornada_Click;
            btnFolha.Click += BtnFolha_Click;
            btnConfiguracoes.Click += BtnConfiguracoes_Click;
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFuncionarios());
        }

        private void BtnJornada_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmJornada());
        }

        private void BtnFolha_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFolhaPagamento());
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmConfiguracoes());
        }

        private void AbrirForm(Form form)
        {
            form.FormClosed += (s, args) => Show();
            Hide();
            form.Show();
        }
    }
}
