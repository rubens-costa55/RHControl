using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;

namespace RHControl
{
    public class FrmNovaSenha : Form
    {
        private readonly int usuarioId;
        private Label lblTitulo = null!;
        private Label lblDescricao = null!;
        private Label lblNovaSenha = null!;
        private Label lblConfirmar = null!;
        private TextBox txtNovaSenha = null!;
        private TextBox txtConfirmarSenha = null!;
        private Button btnSalvar = null!;
        private Button btnCancelar = null!;

        public FrmNovaSenha(int usuarioId)
        {
            this.usuarioId = usuarioId;
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            Text = "RH Control - Nova senha";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(430, 350);
            BackColor = Color.White;

            lblTitulo = new Label
            {
                Text = "Criar nova senha",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 30)
            };

            lblDescricao = new Label
            {
                Text = "Digite sua nova senha para acessar o RH Control.",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(40, 75)
            };

            lblNovaSenha = new Label
            {
                Text = "Nova senha",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 125)
            };

            txtNovaSenha = new TextBox
            {
                Location = new Point(40, 150),
                Width = 350,
                Height = 30,
                Font = new Font("Segoe UI", 11),
                UseSystemPasswordChar = true
            };

            lblConfirmar = new Label
            {
                Text = "Confirmar nova senha",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 190)
            };

            txtConfirmarSenha = new TextBox
            {
                Location = new Point(40, 215),
                Width = 350,
                Height = 30,
                Font = new Font("Segoe UI", 11),
                UseSystemPasswordChar = true
            };

            btnSalvar = new Button
            {
                Text = "ALTERAR SENHA",
                Location = new Point(40, 270),
                Width = 170,
                Height = 38,
                BackColor = Color.FromArgb(31, 78, 121),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnCancelar = new Button
            {
                Text = "CANCELAR",
                Location = new Point(220, 270),
                Width = 170,
                Height = 38,
                FlatStyle = FlatStyle.Flat
            };

            btnSalvar.Click += BtnSalvar_Click;
            btnCancelar.Click += (_, _) => Close();

            Controls.AddRange(new Control[]
            {
                lblTitulo, lblDescricao, lblNovaSenha,
                txtNovaSenha, lblConfirmar, txtConfirmarSenha,
                btnSalvar, btnCancelar
            });

            AcceptButton = btnSalvar;
            CancelButton = btnCancelar;
        }

        private void BtnSalvar_Click(object? sender, System.EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text;
            string confirmacao = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Digite a nova senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNovaSenha.Focus();
                return;
            }

            if (novaSenha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNovaSenha.Focus();
                return;
            }

            if (novaSenha != confirmacao)
            {
                MessageBox.Show("As senhas não são iguais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.SelectAll();
                txtConfirmarSenha.Focus();
                return;
            }

            try
            {
                if (!RecuperacaoSenhaService.AlterarSenha(usuarioId, novaSenha, out string mensagem))
                {
                    MessageBox.Show(mensagem, "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "Senha alterada com sucesso!\r\n\r\nAgora você já pode entrar no RH Control com a nova senha.",
                    "Senha alterada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível alterar a senha.\r\n\r\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
