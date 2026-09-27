using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using RHControl.Data;
using RHControl.Services;

namespace RHControl.Forms
{
    public class FrmEditarUsuario : Form
    {
        private readonly int idUsuario;

        private readonly Panel pnlCabecalho;
        private readonly Label lblTitulo;
        private readonly Label lblSubtitulo;
        private readonly Label lblNome;
        private readonly TextBox txtNome;
        private readonly Label lblUsuario;
        private readonly TextBox txtUsuario;
        private readonly Label lblEmail;
        private readonly TextBox txtEmail;
        private readonly Label lblTipo;
        private readonly ComboBox cmbTipoUsuario;
        private readonly Label lblSenha;
        private readonly TextBox txtSenha;
        private readonly Button btnMostrarSenha;
        private readonly Label lblConfirmarSenha;
        private readonly TextBox txtConfirmarSenha;
        private readonly Button btnMostrarConfirmacao;
        private readonly Label lblInfo;
        private readonly Button btnCancelar;
        private readonly Button btnSalvar;

        public FrmEditarUsuario(int id)
        {
            idUsuario = id;

            Text = "Editar usuário - RH Control";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(620, 650);
            BackColor = Color.FromArgb(244, 247, 251);
            Font = new Font("Segoe UI", 9F);

            pnlCabecalho = new Panel
            {
                Dock = DockStyle.Top,
                Height = 105,
                BackColor = Color.FromArgb(10, 60, 105)
            };

            lblTitulo = new Label
            {
                AutoSize = true,
                Text = "Editar usuário",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(28, 20)
            };

            lblSubtitulo = new Label
            {
                AutoSize = true,
                Text = "Atualize os dados da conta de acesso",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(205, 225, 245),
                Location = new Point(31, 65)
            };

            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(lblSubtitulo);

            lblNome = CriarLabel("Nome", 28, 130);
            txtNome = CriarTextBox(28, 153, 560);

            lblUsuario = CriarLabel("Usuário", 28, 195);
            txtUsuario = CriarTextBox(28, 218, 560);
            txtUsuario.ReadOnly = true;
            txtUsuario.BackColor = Color.FromArgb(235, 239, 244);

            lblEmail = CriarLabel("E-mail", 28, 260);
            txtEmail = CriarTextBox(28, 283, 560);

            lblTipo = CriarLabel("Tipo de usuário", 28, 325);
            cmbTipoUsuario = new ComboBox
            {
                Location = new Point(28, 348),
                Size = new Size(560, 28),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White
            };
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Usuario" });

            lblSenha = CriarLabel("Nova senha", 28, 390);
            txtSenha = CriarTextBox(28, 413, 510);
            txtSenha.UseSystemPasswordChar = true;

            btnMostrarSenha = CriarBotaoPequeno("Mostrar", 543, 412);
            btnMostrarSenha.Click += (s, e) => AlternarSenha(txtSenha, btnMostrarSenha);

            lblConfirmarSenha = CriarLabel("Confirmar nova senha", 28, 455);
            txtConfirmarSenha = CriarTextBox(28, 478, 510);
            txtConfirmarSenha.UseSystemPasswordChar = true;

            btnMostrarConfirmacao = CriarBotaoPequeno("Mostrar", 543, 477);
            btnMostrarConfirmacao.Click += (s, e) => AlternarSenha(txtConfirmarSenha, btnMostrarConfirmacao);

            lblInfo = new Label
            {
                AutoSize = false,
                Text = "Deixe a nova senha em branco para manter a senha atual.",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(80, 95, 110),
                Location = new Point(28, 518),
                Size = new Size(560, 24)
            };

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(350, 570),
                Size = new Size(112, 38),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(40, 55, 70),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(205, 215, 225);
            btnCancelar.Click += (s, e) => DialogResult = DialogResult.Cancel;

            btnSalvar = new Button
            {
                Text = "Salvar alterações",
                Location = new Point(472, 570),
                Size = new Size(116, 38),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(18, 126, 255),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += BtnSalvar_Click;

            Controls.Add(pnlCabecalho);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnMostrarSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btnMostrarConfirmacao);
            Controls.Add(lblInfo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);

            AcceptButton = btnSalvar;
            CancelButton = btnCancelar;

            Load += FrmEditarUsuario_Load;
        }

        private static Label CriarLabel(string texto, int x, int y)
        {
            return new Label
            {
                AutoSize = true,
                Text = texto,
                Location = new Point(x, y),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 48, 65)
            };
        }

        private static TextBox CriarTextBox(int x, int y, int largura)
        {
            return new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(largura, 28),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(30, 45, 60)
            };
        }

        private static Button CriarBotaoPequeno(string texto, int x, int y)
        {
            var botao = new Button
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(45, 29),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(18, 126, 255),
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            botao.FlatAppearance.BorderColor = Color.FromArgb(205, 218, 232);
            return botao;
        }

        private static void AlternarSenha(TextBox campo, Button botao)
        {
            campo.UseSystemPasswordChar = !campo.UseSystemPasswordChar;
            botao.Text = campo.UseSystemPasswordChar ? "Mostrar" : "Ocultar";
        }

        private void FrmEditarUsuario_Load(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                MessageBox.Show(
                    "Somente o Administrador principal pode editar contas existentes.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                return;
            }

            try
            {
                using var conexao = Database.GetConnection();
                conexao.Open();

                using var cmd = conexao.CreateCommand();
                cmd.CommandText = @"
                    SELECT Nome, Usuario, COALESCE(Email, ''), COALESCE(TipoUsuario, 'Usuario')
                    FROM Usuarios
                    WHERE Id = $id
                    LIMIT 1;";
                cmd.Parameters.AddWithValue("$id", idUsuario);

                using var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("A conta selecionada não foi encontrada.", "Usuários",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                txtNome.Text = reader.GetString(0);
                txtUsuario.Text = reader.GetString(1);
                txtEmail.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                string tipo = reader.IsDBNull(3) ? "Usuario" : reader.GetString(3);
                int indice = cmbTipoUsuario.Items.IndexOf(tipo);
                cmbTipoUsuario.SelectedIndex = indice >= 0 ? indice : 1;

                bool propriaConta =
                    idUsuario == SessaoUsuario.Id &&
                    SessaoUsuario.EhAdministradorPrincipal &&
                    string.Equals(txtUsuario.Text, "admin", StringComparison.OrdinalIgnoreCase);

                if (propriaConta)
                {
                    // O administrador principal só pode alterar o próprio e-mail.
                    lblTitulo.Text = "Meu e-mail";
                    lblSubtitulo.Text = "Cadastre ou altere o e-mail usado para recuperação de senha";

                    txtNome.ReadOnly = true;
                    txtNome.BackColor = Color.FromArgb(235, 239, 244);

                    txtUsuario.ReadOnly = true;
                    txtUsuario.BackColor = Color.FromArgb(235, 239, 244);

                    cmbTipoUsuario.Enabled = false;

                    txtSenha.Enabled = false;
                    txtSenha.BackColor = Color.FromArgb(235, 239, 244);
                    btnMostrarSenha.Enabled = false;

                    txtConfirmarSenha.Enabled = false;
                    txtConfirmarSenha.BackColor = Color.FromArgb(235, 239, 244);
                    btnMostrarConfirmacao.Enabled = false;

                    lblInfo.Text = "Somente o e-mail pode ser alterado. Para salvar, sua senha atual será solicitada.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar a conta.\n\n" + ex.Message,
                    "RH Control",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (!SessaoUsuario.EhAdministradorPrincipal)
            {
                MessageBox.Show("Somente o Administrador principal pode editar contas existentes.",
                    "Acesso restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool propriaConta =
                idUsuario == SessaoUsuario.Id &&
                SessaoUsuario.EhAdministradorPrincipal &&
                string.Equals(txtUsuario.Text, "admin", StringComparison.OrdinalIgnoreCase);

            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string confirmacao = txtConfirmarSenha.Text;
            string tipo = cmbTipoUsuario.SelectedItem?.ToString() ?? "Usuario";

            if (propriaConta)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show(
                        "Informe o e-mail que será usado para recuperar a senha do administrador.",
                        "E-mail do administrador",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(
                        email,
                        @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                {
                    MessageBox.Show(
                        "Informe um e-mail válido.",
                        "E-mail do administrador",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }

                using var confirmarSenha = new FrmConfirmarSenha();

                if (confirmarSenha.ShowDialog(this) != DialogResult.OK)
                    return;

                Cursor = Cursors.WaitCursor;

                try
                {
                    if (!UsuarioService.AtualizarProprioEmail(
                            idUsuario,
                            email,
                            confirmarSenha.SenhaDigitada,
                            out string mensagem))
                    {
                        MessageBox.Show(
                            mensagem,
                            "E-mail do administrador",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    SessaoUsuario.AtualizarEmail(email);

                    MessageBox.Show(
                        "E-mail do administrador atualizado com sucesso!",
                        "RH Control",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    return;
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(senha))
            {
                if (senha.Length < 6)
                {
                    MessageBox.Show("A nova senha deve ter pelo menos 6 caracteres.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Focus();
                    return;
                }

                if (!string.Equals(senha, confirmacao, StringComparison.Ordinal))
                {
                    MessageBox.Show("A confirmação da nova senha não confere.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarSenha.Focus();
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(confirmacao))
            {
                MessageBox.Show("Informe a nova senha ou deixe os dois campos em branco.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                if (!UsuarioService.AtualizarUsuario(
                    idUsuario,
                    nome,
                    email,
                    senha,
                    tipo,
                    out string mensagem))
                {
                    MessageBox.Show(mensagem, "Usuários",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Conta atualizada com sucesso!", "RH Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
