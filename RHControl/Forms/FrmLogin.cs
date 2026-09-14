using System;
using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;

namespace RHControl
{
    public partial class FrmLogin : Form
    {
        private bool senhaVisivel = false;
        private bool processandoLogin = false;

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FrmLogin()
        {
            InitializeComponent();

            txtSenha.UseSystemPasswordChar = true;
            AtualizarIconeSenha();

            btnMostrarSenha.Click += BtnMostrarSenha_Click;
            btnEntrar.Click += BtnEntrar_Click;
            btnEsqueciSenha.Click += BtnEsqueciSenha_Click;
            btnFechar.Click += BtnFechar_Click;

            txtUsuario.KeyDown += CampoLogin_KeyDown;
            txtSenha.KeyDown += CampoLogin_KeyDown;
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
                btnMostrarSenha.Image = Properties.Resources.ico_esconder;
            else
                btnMostrarSenha.Image = Properties.Resources.ico_mostrar;

            btnMostrarSenha.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void CampoLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnEntrar_Click(btnEntrar, EventArgs.Empty);
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (processandoLogin)
                return;

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

            try
            {
                processandoLogin = true;
                btnEntrar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                UsuarioService.ResultadoLogin resultado =
                    UsuarioService.Autenticar(usuario, senha);

                if (!resultado.Sucesso)
                {
                    MessageBox.Show(
                        resultado.Mensagem,
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSenha.SelectAll();
                    txtSenha.Focus();
                    return;
                }

                SessaoUsuario.Iniciar(
                    resultado.Id,
                    resultado.Nome,
                    resultado.Usuario,
                    resultado.Email,
                    resultado.TipoUsuario,
                    resultado.UltimoAcesso);

                FrmDashboard dashboard = new FrmDashboard();

                dashboard.FormClosed += (s, args) =>
                {
                    if (SessaoUsuario.Id > 0)
                    {
                        SessaoUsuario.Encerrar();
                        this.Close();
                    }
                    else
                    {
                        // Logout: o Login permanece aberto para novo acesso.
                        this.Show();
                        this.BringToFront();
                    }
                };

                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível realizar o login.\r\n\r\nDetalhes: " + ex.Message,
                    "Erro de login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    processandoLogin = false;
                    btnEntrar.Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void BtnEsqueciSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "A recuperação de senha será disponibilizada na etapa de gerenciamento de usuários.\r\n\r\nPor enquanto, solicite a redefinição ao administrador do sistema.",
                "Recuperação de senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
