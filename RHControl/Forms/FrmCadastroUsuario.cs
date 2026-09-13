using System;
using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;

namespace RHControl.Forms
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();

            AplicarPermissaoCriacao();

            txtSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.UseSystemPasswordChar = true;

            btnCancelar.Click += BtnCancelar_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnMostrarSenha.Click += BtnMostrarSenha_Click;
            btnMostrarConfirmacao.Click += BtnMostrarConfirmacao_Click;
        }

        private void AplicarPermissaoCriacao()
        {
            if (!SessaoUsuario.EhAdministrador)
            {
                BeginInvoke(new Action(Close));
                return;
            }

            if (SessaoUsuario.EhAdministradorPrincipal)
            {
                // Administrador principal pode escolher Administrador ou Usuário.
                return;
            }

            // Novos administradores podem criar somente contas Usuário.
            cmbTipoUsuario.Items.Clear();
            cmbTipoUsuario.Items.Add("Usuario");
            cmbTipoUsuario.SelectedIndex = 0;
            cmbTipoUsuario.Enabled = false;

            lblPermissaoTexto.Text =
                "Seu perfil de Administrador permite criar novas contas apenas do tipo Usuário.";
        }

        private void BtnMostrarSenha_Click(object? sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void BtnMostrarConfirmacao_Click(object? sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !txtConfirmarSenha.UseSystemPasswordChar;
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string confirmacao = txtConfirmarSenha.Text;
            string tipo = cmbTipoUsuario.SelectedItem?.ToString() ?? "Usuario";

            if (!SessaoUsuario.EhAdministrador)
            {
                MessageBox.Show(
                    "Somente um Administrador pode criar contas.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Somente o administrador principal pode criar outro administrador.
            if (!SessaoUsuario.EhAdministradorPrincipal)
                tipo = "Usuario";

            if (string.IsNullOrWhiteSpace(nome))
            {
                Avisar("Informe o nome do usuário.", txtNome);
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                Avisar("Informe o nome de acesso (usuário).", txtUsuario);
                return;
            }

            if (usuario.Contains(" "))
            {
                Avisar("O usuário não pode conter espaços.", txtUsuario);
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                Avisar("Informe a senha.", txtSenha);
                return;
            }

            if (senha.Length < 6)
            {
                Avisar("A senha deve ter pelo menos 6 caracteres.", txtSenha);
                return;
            }

            if (!string.Equals(senha, confirmacao, StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "A confirmação de senha não confere.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtConfirmarSenha.SelectAll();
                txtConfirmarSenha.Focus();
                return;
            }

            if (tipo != "Administrador" && tipo != "Usuario")
                tipo = "Usuario";

            if (!UsuarioService.CriarUsuario(
                    nome,
                    usuario,
                    email,
                    senha,
                    tipo,
                    out string mensagem))
            {
                MessageBox.Show(
                    mensagem,
                    "Não foi possível salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Conta criada com sucesso!",
                "RH Control",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private static void Avisar(string mensagem, Control controle)
        {
            MessageBox.Show(
                mensagem,
                "Validação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            controle.Focus();
        }
    }
}
