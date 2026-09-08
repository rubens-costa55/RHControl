using System;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            btnFuncionarios.Click += BtnFuncionarios_Click;
            btnJornada.Click += BtnJornada_Click;
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionarios funcionarios = new FrmFuncionarios();

            funcionarios.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            funcionarios.Show();
        }

        private void BtnJornada_Click(object sender, EventArgs e)
        {
            FrmJornada jornada = new FrmJornada();

            jornada.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            jornada.Show();
        }
    }
}