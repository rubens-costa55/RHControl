using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;

namespace RHControl.Forms
{
    public partial class FrmRecuperarSenha : Form
    {
        public FrmRecuperarSenha()
        {
            InitializeComponent();

            txtEmail.Focus();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Digite o e-mail cadastrado.",
                    "Recuperação de senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();

                command.CommandText = @"
                    SELECT Id
                    FROM Usuarios
                    WHERE lower(trim(COALESCE(Email, ''))) =
                          lower(trim($email))
                      AND Status = 'Ativo'
                    LIMIT 1;
                ";

                command.Parameters.AddWithValue("$email", email);

                object? resultado = command.ExecuteScalar();

                if (resultado == null ||
                    resultado == DBNull.Value)
                {
                    MessageBox.Show(
                        "O e-mail informado não está cadastrado no RH Control.",
                        "Recuperação de senha",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.SelectAll();
                    txtEmail.Focus();

                    return;
                }

                int usuarioId = Convert.ToInt32(resultado);

                using (var novaSenha = new FrmNovaSenha(usuarioId))
                {
                    Hide();

                    DialogResult resultadoNovaSenha =
                        novaSenha.ShowDialog(this);

                    if (resultadoNovaSenha == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        Show();
                        txtEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível verificar o e-mail.\r\n\r\n" +
                    "Detalhes: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnContinuar_Click(btnContinuar, EventArgs.Empty);
            }
        }
    }
}