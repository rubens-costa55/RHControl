using System;
using System.Windows.Forms;
using RHControl.Services;
using Microsoft.Data.Sqlite;
using RHControl.Data;

namespace RHControl.Forms
{
    public partial class FrmNovaSenha : Form
    {
        private readonly int usuarioId;

        public FrmNovaSenha(int usuarioId)
        {
            InitializeComponent();

            this.usuarioId = usuarioId;

            txtNovaSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.UseSystemPasswordChar = true;

            txtNovaSenha.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show(
                    "Digite a nova senha.",
                    "Nova senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNovaSenha.Focus();
                return;
            }

            if (novaSenha.Length < 6)
            {
                MessageBox.Show(
                    "A nova senha deve ter pelo menos 6 caracteres.",
                    "Nova senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNovaSenha.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show(
                    "Confirme a nova senha.",
                    "Nova senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarSenha.Focus();
                return;
            }

            if (!string.Equals(
                novaSenha,
                confirmarSenha,
                StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "As senhas não coincidem.",
                    "Nova senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarSenha.SelectAll();
                txtConfirmarSenha.Focus();
                return;
            }

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();

                command.CommandText = @"
                    UPDATE Usuarios
                    SET Senha = $senha,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id
                      AND Status = 'Ativo';
                ";

                command.Parameters.AddWithValue(
                    "$senha",
                    UsuarioService.CriarHash(novaSenha));

                command.Parameters.AddWithValue(
                    "$atualizado",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                command.Parameters.AddWithValue(
                    "$id",
                    usuarioId);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas == 0)
                {
                    MessageBox.Show(
                        "Não foi possível atualizar a senha. O usuário pode estar inativo ou não existir.",
                        "Nova senha",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Senha alterada com sucesso!",
                    "Nova senha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível alterar a senha.\r\n\r\n" +
                    "Detalhes: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TxtNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnSalvar_Click(btnSalvar, EventArgs.Empty);
            }
        }

        private void TxtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnSalvar_Click(btnSalvar, EventArgs.Empty);
            }
        }
    }
}