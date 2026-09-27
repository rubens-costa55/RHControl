using System.Drawing;
using System.Windows.Forms;
using RHControl.Services;

namespace RHControl
{
    public class FrmValidarCodigo : Form
    {
        private readonly int usuarioId;
        private readonly string email;
        private Label lblTitulo = null!;
        private Label lblDescricao = null!;
        private TextBox txtCodigo = null!;
        private Button btnValidar = null!;
        private Button btnCancelar = null!;

        public FrmValidarCodigo(int usuarioId, string email)
        {
            this.usuarioId = usuarioId;
            this.email = email;
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            Text = "RH Control - Código de verificação";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(430, 300);
            BackColor = Color.White;

            lblTitulo = new Label
            {
                Text = "Código de verificação",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 30)
            };

            lblDescricao = new Label
            {
                Text = "Digite o código de 4 dígitos enviado para:\r\n" + email,
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(40, 78)
            };

            txtCodigo = new TextBox
            {
                Location = new Point(40, 145),
                Width = 350,
                Height = 40,
                Font = new Font("Segoe UI", 18),
                TextAlign = HorizontalAlignment.Center,
                MaxLength = 4
            };

            btnValidar = new Button
            {
                Text = "VALIDAR CÓDIGO",
                Location = new Point(40, 205),
                Width = 170,
                Height = 38,
                BackColor = Color.FromArgb(31, 78, 121),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnCancelar = new Button
            {
                Text = "CANCELAR",
                Location = new Point(220, 205),
                Width = 170,
                Height = 38,
                FlatStyle = FlatStyle.Flat
            };

            btnValidar.Click += BtnValidar_Click;
            btnCancelar.Click += (_, _) => Close();

            Controls.AddRange(new Control[]
            {
                lblTitulo, lblDescricao, txtCodigo,
                btnValidar, btnCancelar
            });

            AcceptButton = btnValidar;
            CancelButton = btnCancelar;
        }

        private void BtnValidar_Click(object? sender, System.EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (codigo.Length != 4)
            {
                MessageBox.Show("Digite o código de 4 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            try
            {
                var resultado = RecuperacaoSenhaService.ValidarCodigo(usuarioId, codigo);

                if (!resultado.Sucesso)
                {
                    MessageBox.Show(resultado.Mensagem, "Código de verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.SelectAll();
                    txtCodigo.Focus();
                    return;
                }

                using (var novaSenha = new FrmNovaSenha(usuarioId))
                {
                    novaSenha.ShowDialog(this);
                }

                Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível validar o código.\r\n\r\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
