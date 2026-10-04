using RHControl.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RHControl.Forms
{
    public class FrmAlterarSenha : Form
    {
        private TextBox txtEmail;
        private TextBox txtSenhaAtual;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
        private Button btnSalvar;
        private Button btnCancelar;

        public FrmAlterarSenha()
        {
            Text = "Alterar senha";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(500, 420);
            BackColor = Color.FromArgb(244, 247, 251);
            Font = new Font("Segoe UI", 10F);

            CriarInterface();
        }

        private void CriarInterface()
        {
            Label lblTitulo = new Label
            {
                Text = "Alterar senha",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(10, 30, 50),
                AutoSize = true,
                Location = new Point(35, 28)
            };

            Label lblDescricao = new Label
            {
                Text = "Informe seus dados para criar uma nova senha.",
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(90, 100, 110),
                AutoSize = true,
                Location = new Point(37, 70)
            };

            Controls.Add(lblTitulo);
            Controls.Add(lblDescricao);

            txtEmail = CriarCampo("E-mail cadastrado", 105, false);
            txtSenhaAtual = CriarCampo("Senha atual", 165, true);
            txtNovaSenha = CriarCampo("Nova senha", 225, true);
            txtConfirmarSenha = CriarCampo("Confirmar nova senha", 285, true);

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(245, 350),
                Size = new Size(100, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(60, 70, 80),
                DialogResult = DialogResult.Cancel
            };

            btnCancelar.FlatAppearance.BorderColor =
                Color.FromArgb(200, 205, 210);

            btnSalvar = new Button
            {
                Text = "Salvar",
                Location = new Point(355, 350),
                Size = new Size(100, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 126, 255),
                ForeColor = Color.White
            };

            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += BtnSalvar_Click;

            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);

            AcceptButton = btnSalvar;
            CancelButton = btnCancelar;

            Shown += (s, e) => txtEmail.Focus();
        }

        private TextBox CriarCampo(string titulo, int y, bool senha)
        {
            Label label = new Label
            {
                Text = titulo,
                AutoSize = true,
                ForeColor = Color.FromArgb(50, 60, 70),
                Location = new Point(38, y)
            };

            TextBox caixa = new TextBox
            {
                Location = new Point(38, y + 22),
                Size = new Size(417, 30),
                BorderStyle = BorderStyle.FixedSingle
            };

            if (senha)
            {
                caixa.UseSystemPasswordChar = true;
            }
            else
            {
                caixa.Text = SessaoUsuario.Email;
            }

            Controls.Add(label);
            Controls.Add(caixa);

            return caixa;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senhaAtual = txtSenhaAtual.Text;
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Informe o e-mail cadastrado.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senhaAtual))
            {
                MessageBox.Show(
                    "Informe a senha atual.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSenhaAtual.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show(
                    "Informe a nova senha.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNovaSenha.Focus();
                return;
            }

            if (!string.Equals(
                novaSenha,
                confirmarSenha,
                StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "A confirmação da nova senha não confere.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarSenha.Focus();
                return;
            }

            if (novaSenha.Length < 6)
            {
                MessageBox.Show(
                    "A nova senha deve ter pelo menos 6 caracteres.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNovaSenha.Focus();
                return;
            }

            if (string.Equals(
                senhaAtual,
                novaSenha,
                StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "A nova senha precisa ser diferente da senha atual.",
                    "Alterar senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNovaSenha.Focus();
                return;
            }

            if (!UsuarioService.AlterarMinhaSenha(
                SessaoUsuario.Id,
                email,
                senhaAtual,
                novaSenha,
                out string mensagem))
            {
                MessageBox.Show(
                    mensagem,
                    "Não foi possível alterar a senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                "Senha alterada com sucesso.",
                "Alterar senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
