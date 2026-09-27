using System;
using System.Drawing;
using System.Windows.Forms;

namespace RHControl.Forms
{
    public class FrmConfirmarSenha : Form
    {
        private readonly TextBox txtSenha;
        private readonly Button btnConfirmar;
        private readonly Button btnCancelar;

        public string SenhaDigitada => txtSenha.Text;

        public FrmConfirmarSenha()
        {
            Text = "Confirmar alteração - RH Control";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(430, 225);
            BackColor = Color.FromArgb(244, 247, 251);
            Font = new Font("Segoe UI", 9F);

            Label lblTitulo = new Label
            {
                AutoSize = true,
                Text = "Confirmar alteração",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(8, 42, 78),
                Location = new Point(28, 25)
            };

            Label lblDescricao = new Label
            {
                AutoSize = false,
                Text = "Para alterar o e-mail do Administrador, digite a senha atual.",
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(75, 95, 115),
                Location = new Point(30, 68),
                Size = new Size(370, 42)
            };

            Label lblSenha = new Label
            {
                AutoSize = true,
                Text = "Senha atual",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 48, 65),
                Location = new Point(30, 112)
            };

            txtSenha = new TextBox
            {
                Location = new Point(30, 136),
                Size = new Size(370, 28),
                BorderStyle = BorderStyle.FixedSingle,
                UseSystemPasswordChar = true
            };

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(188, 178),
                Size = new Size(100, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(40, 55, 70),
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(205, 215, 225);

            btnConfirmar = new Button
            {
                Text = "Confirmar",
                Location = new Point(300, 178),
                Size = new Size(100, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 126, 255),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnConfirmar.FlatAppearance.BorderSize = 0;

            btnCancelar.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            btnConfirmar.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show(
                        "Digite sua senha atual.",
                        "Confirmação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtSenha.Focus();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.Add(lblTitulo);
            Controls.Add(lblDescricao);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);

            AcceptButton = btnConfirmar;
            CancelButton = btnCancelar;
        }
    }
}
