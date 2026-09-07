using System;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmLogin : Form
    {
        private bool senhaVisivel = false;

        public FrmLogin()
        {
            InitializeComponent();

            txtSenha.UseSystemPasswordChar = true;
            AtualizarIconeSenha();

            btnMostrarSenha.Click += BtnMostrarSenha_Click;
            btnEntrar.Click += BtnEntrar_Click;
        }

        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            txtSenha.UseSystemPasswordChar = !senhaVisivel;

            AtualizarIconeSenha();
        }

        private void AtualizarIconeSenha()
        {
            if (senhaVisivel)
            {
                btnMostrarSenha.Image =
                    Properties.Resources.ico_esconder;
            }
            else
            {
                btnMostrarSenha.Image =
                    Properties.Resources.ico_mostrar;
            }

            btnMostrarSenha.ImageAlign =
                ContentAlignment.MiddleCenter;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show(
                    "Digite seu usuário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Digite sua senha.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSenha.Focus();
                return;
            }

            // Por enquanto, qualquer usuário e senha preenchidos entram.
            // A autenticação real será ligada ao SQLite posteriormente.

            FrmDashboard dashboard = new FrmDashboard();

            dashboard.FormClosed += (s, args) =>
            {
                this.Close();
            };

            dashboard.Show();

            this.Hide();
        }
    }
}