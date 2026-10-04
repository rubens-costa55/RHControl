using System;
using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;
using RHControl.Forms;

namespace RHControl
{
    public partial class FrmLogin : Form
    {
        private bool senhaVisivel = false;
        private bool processandoLogin = false;

        public FrmLogin()
        {
            InitializeComponent();

            txtSenha.UseSystemPasswordChar = true;
            AtualizarIconeSenha();

            btnMostrarSenha.Click += BtnMostrarSenha_Click;
            btnEntrar.Click += BtnEntrar_Click;
            btnEsqueciSenha.Click += BtnEsqueciSenha_Click;

            // X personalizado da tela de Login
            btnFechar.Click += BtnFechar_Click;

            txtUsuario.KeyDown += CampoLogin_KeyDown;
            txtSenha.KeyDown += CampoLogin_KeyDown;
        }

        // ============================================================
        // FECHAR LOGIN
        // ============================================================

        private void BtnFechar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // ============================================================
        // MOSTRAR / OCULTAR SENHA
        // ============================================================

        private void BtnMostrarSenha_Click(
            object sender,
            EventArgs e)
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

        // ============================================================
        // ENTER NOS CAMPOS
        // ============================================================

        private void CampoLogin_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                BtnEntrar_Click(
                    btnEntrar,
                    EventArgs.Empty);
            }
        }

        // ============================================================
        // LOGIN
        // ============================================================

        private void BtnEntrar_Click(
            object sender,
            EventArgs e)
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
                    UsuarioService.Autenticar(
                        usuario,
                        senha);

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

                FrmDashboard dashboard =
                    new FrmDashboard();

                dashboard.FormClosed += (s, args) =>
                {
                    SessaoUsuario.Encerrar();

                    if (!IsDisposed)
                    {
                        Show();
                        BringToFront();
                    }
                };

                dashboard.Show();

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível realizar o login.\r\n\r\n" +
                    "Detalhes: " + ex.Message,
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

        // ============================================================
        // ESQUECI MINHA SENHA
        // ============================================================

        private void BtnEsqueciSenha_Click(
            object sender,
            EventArgs e)
        {
            using (var recuperar =
                new FrmRecuperarSenha())
            {
                recuperar.ShowDialog(this);
            }
        }
    }
}