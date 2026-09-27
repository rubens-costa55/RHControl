using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;

namespace RHControl
{
    public class FrmRecuperarSenha : Form
    {
        private Label lblTitulo = null!;
        private Label lblDescricao = null!;
        private Label lblEmail = null!;
        private TextBox txtEmail = null!;
        private Button btnEnviar = null!;
        private Button btnVoltar = null!;

        public FrmRecuperarSenha()
        {
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            Text = "RH Control - Recuperar senha";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(430, 280);
            BackColor = Color.White;

            lblTitulo = new Label
            {
                Text = "Recuperar senha",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 30)
            };

            lblDescricao = new Label
            {
                Text = "Informe o e-mail cadastrado no RH Control.\r\nEnviaremos um código de 4 dígitos.",
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(40, 75)
            };

            lblEmail = new Label
            {
                Text = "E-mail",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 135)
            };

            txtEmail = new TextBox
            {
                Location = new Point(40, 160),
                Width = 350,
                Height = 30,
                Font = new Font("Segoe UI", 11)
            };

            btnEnviar = new Button
            {
                Text = "ENVIAR CÓDIGO",
                Location = new Point(40, 210),
                Width = 170,
                Height = 38,
                BackColor = Color.FromArgb(31, 78, 121),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnVoltar = new Button
            {
                Text = "VOLTAR",
                Location = new Point(220, 210),
                Width = 170,
                Height = 38,
                FlatStyle = FlatStyle.Flat
            };

            btnEnviar.Click += BtnEnviar_Click;
            btnVoltar.Click += (_, _) => Close();

            Controls.AddRange(new Control[]
            {
                lblTitulo, lblDescricao, lblEmail,
                txtEmail, btnEnviar, btnVoltar
            });

            AcceptButton = btnEnviar;
            CancelButton = btnVoltar;
        }

        private void BtnEnviar_Click(object? sender, System.EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Informe seu e-mail.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                btnEnviar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var resultado = RecuperacaoSenhaService.SolicitarCodigo(email);

                if (!resultado.Sucesso)
                {
                    MessageBox.Show(resultado.Mensagem, "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "Enviamos um código de 4 dígitos para o seu e-mail.\r\n\r\nO código é válido por 10 minutos.",
                    "Código enviado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                using (var validar = new FrmValidarCodigo(resultado.UsuarioId, resultado.Email))
                {
                    validar.ShowDialog(this);
                }

                Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível iniciar a recuperação.\r\n\r\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnEnviar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
