using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Services;

namespace RHControl.Forms
{
    public class FrmEditarEmailAdmin : Form
    {
        private const string PrefixoHash = "PBKDF2$";

        private readonly int idUsuario;
        private TextBox txtEmail = null!;
        private TextBox txtSenha = null!;
        private Button btnSalvar = null!;

        public FrmEditarEmailAdmin(int id)
        {
            idUsuario = id;
            ConfigurarTela();
            CarregarEmail();
        }

        private void ConfigurarTela()
        {
            Text = "RH Control - E-mail do Administrador";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(520, 330);
            BackColor = Color.FromArgb(244, 247, 251);
            Font = new Font("Segoe UI", 9F);

            Panel cabecalho = new Panel
            {
                Dock = DockStyle.Top,
                Height = 92,
                BackColor = Color.FromArgb(10, 60, 105)
            };

            cabecalho.Controls.Add(new Label
            {
                AutoSize = true,
                Text = "E-mail do Administrador",
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(24, 18)
            });

            cabecalho.Controls.Add(new Label
            {
                AutoSize = true,
                Text = "Cadastre o e-mail para recuperação de senha",
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(210, 230, 248),
                Location = new Point(27, 58)
            });

            Controls.Add(cabecalho);

            Controls.Add(new Label
            {
                AutoSize = true,
                Text = "E-mail",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 48, 65),
                Location = new Point(30, 120)
            });

            txtEmail = new TextBox
            {
                Location = new Point(30, 144),
                Size = new Size(460, 30),
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle
            };

            Controls.Add(txtEmail);

            Controls.Add(new Label
            {
                AutoSize = false,
                Text = "Para confirmar a alteração, informe a senha atual do administrador.",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(80, 95, 110),
                Location = new Point(30, 186),
                Size = new Size(460, 25)
            });

            txtSenha = new TextBox
            {
                Location = new Point(30, 214),
                Size = new Size(460, 30),
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                UseSystemPasswordChar = true
            };

            Controls.Add(txtSenha);

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(270, 270),
                Size = new Size(105, 36),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(40, 55, 70),
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(205, 215, 225);
            btnCancelar.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            btnSalvar = new Button
            {
                Text = "Salvar e-mail",
                Location = new Point(385, 270),
                Size = new Size(105, 36),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 126, 255),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += BtnSalvar_Click;

            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);

            AcceptButton = btnSalvar;
            CancelButton = btnCancelar;
        }

        private void CarregarEmail()
        {
            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT COALESCE(Email, '')
                    FROM Usuarios
                    WHERE Id = $id
                      AND lower(Usuario) = 'admin'
                    LIMIT 1;";
                command.Parameters.AddWithValue("$id", idUsuario);

                txtEmail.Text = command.ExecuteScalar()?.ToString() ?? string.Empty;
                txtEmail.Focus();
                txtEmail.SelectionStart = txtEmail.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o e-mail do administrador.\r\n\r\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Informe o e-mail do administrador.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!ValidarEmail(email))
            {
                MessageBox.Show(
                    "Informe um e-mail válido.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Digite a senha atual do administrador para confirmar.",
                    "Confirmação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            btnSalvar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                using var connection = Database.GetConnection();
                connection.Open();

                string senhaBanco;

                using (var buscar = connection.CreateCommand())
                {
                    buscar.CommandText = @"
                        SELECT Senha
                        FROM Usuarios
                        WHERE Id = $id
                          AND lower(Usuario) = 'admin'
                          AND Status = 'Ativo'
                        LIMIT 1;";
                    buscar.Parameters.AddWithValue("$id", idUsuario);

                    object? resultado = buscar.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show(
                            "A conta admin não foi encontrada.",
                            "RH Control",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    senhaBanco = resultado.ToString() ?? string.Empty;
                }

                if (!VerificarSenha(senha, senhaBanco))
                {
                    MessageBox.Show(
                        "A senha atual está incorreta. O e-mail não foi alterado.",
                        "Senha incorreta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtSenha.SelectAll();
                    txtSenha.Focus();
                    return;
                }

                using var atualizar = connection.CreateCommand();
                atualizar.CommandText = @"
                    UPDATE Usuarios
                    SET Email = $email,
                        AtualizadoEm = $atualizado
                    WHERE Id = $id
                      AND lower(Usuario) = 'admin';";

                atualizar.Parameters.AddWithValue("$email", email);
                atualizar.Parameters.AddWithValue(
                    "$atualizado",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                atualizar.Parameters.AddWithValue("$id", idUsuario);

                int linhas = atualizar.ExecuteNonQuery();

                if (linhas != 1)
                {
                    MessageBox.Show(
                        "Não foi possível salvar o e-mail.",
                        "RH Control",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "E-mail do administrador atualizado com sucesso!",
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível salvar o e-mail.\r\n\r\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSalvar.Enabled = true;
            }
        }

        private static bool ValidarEmail(string email)
        {
            try
            {
                var endereco = new System.Net.Mail.MailAddress(email);
                return string.Equals(endereco.Address, email, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private static bool VerificarSenha(string senha, string valorBanco)
        {
            if (string.IsNullOrEmpty(valorBanco))
                return false;

            // Compatibilidade com senha antiga em texto, caso ainda exista.
            if (!valorBanco.StartsWith(PrefixoHash, StringComparison.Ordinal))
                return string.Equals(senha, valorBanco, StringComparison.Ordinal);

            string[] partes = valorBanco.Split('$');

            if (partes.Length != 4 ||
                !int.TryParse(partes[1], out int iteracoes))
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(partes[2]);
                byte[] hashEsperado = Convert.FromBase64String(partes[3]);

                using var pbkdf2 = new Rfc2898DeriveBytes(
                    senha,
                    salt,
                    iteracoes,
                    HashAlgorithmName.SHA256);

                byte[] hashAtual = pbkdf2.GetBytes(hashEsperado.Length);

                return CryptographicOperations.FixedTimeEquals(
                    hashAtual,
                    hashEsperado);
            }
            catch
            {
                return false;
            }
        }
    }
}
