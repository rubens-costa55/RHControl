namespace RHControl.Forms
{
    partial class FrmCadastroUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Button btnMostrarConfirmacao;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.Panel pnlPermissao;
        private System.Windows.Forms.Label lblPermissaoTexto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblIcone = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnMostrarConfirmacao = new System.Windows.Forms.Button();

            this.lblPermissao = new System.Windows.Forms.Label();
            this.pnlPermissao = new System.Windows.Forms.Panel();
            this.lblPermissaoTexto = new System.Windows.Forms.Label();

            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();

            this.pnlPrincipal.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlPermissao.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            this.ClientSize = new System.Drawing.Size(620, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH Control — Nova conta";

            // Principal
            this.Controls.Add(this.pnlPrincipal);
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(this.btnSalvar);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.pnlPermissao);
            this.pnlPrincipal.Controls.Add(this.lblPermissao);
            this.pnlPrincipal.Controls.Add(this.btnMostrarConfirmacao);
            this.pnlPrincipal.Controls.Add(this.txtConfirmarSenha);
            this.pnlPrincipal.Controls.Add(this.lblConfirmarSenha);
            this.pnlPrincipal.Controls.Add(this.btnMostrarSenha);
            this.pnlPrincipal.Controls.Add(this.txtSenha);
            this.pnlPrincipal.Controls.Add(this.lblSenha);
            this.pnlPrincipal.Controls.Add(this.cmbTipoUsuario);
            this.pnlPrincipal.Controls.Add(this.lblTipo);
            this.pnlPrincipal.Controls.Add(this.txtEmail);
            this.pnlPrincipal.Controls.Add(this.lblEmail);
            this.pnlPrincipal.Controls.Add(this.txtUsuario);
            this.pnlPrincipal.Controls.Add(this.lblUsuario);
            this.pnlPrincipal.Controls.Add(this.txtNome);
            this.pnlPrincipal.Controls.Add(this.lblNome);
            this.pnlPrincipal.Controls.Add(this.pnlCabecalho);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(620, 620);

            // Cabeçalho
            this.pnlCabecalho.BackColor = System.Drawing.Color.White;
            this.pnlCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabecalho.Location = new System.Drawing.Point(28, 24);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(564, 84);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblIcone);

            this.lblIcone.BackColor = System.Drawing.Color.FromArgb(232, 241, 251);
            this.lblIcone.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblIcone.ForeColor = System.Drawing.Color.FromArgb(25, 125, 210);
            this.lblIcone.Location = new System.Drawing.Point(16, 16);
            this.lblIcone.Size = new System.Drawing.Size(52, 52);
            this.lblIcone.Text = "♟";
            this.lblIcone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(8, 42, 78);
            this.lblTitulo.Location = new System.Drawing.Point(82, 17);
            this.lblTitulo.Text = "Nova conta";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(75, 110, 145);
            this.lblSubtitulo.Location = new System.Drawing.Point(84, 46);
            this.lblSubtitulo.Text = "Cadastre uma nova conta de acesso ao RH Control.";

            // Nome
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblNome.Location = new System.Drawing.Point(28, 128);
            this.lblNome.Text = "Nome completo *";

            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNome.Location = new System.Drawing.Point(28, 150);
            this.txtNome.Size = new System.Drawing.Size(564, 26);
            this.txtNome.TabIndex = 1;

            // Usuário
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblUsuario.Location = new System.Drawing.Point(28, 188);
            this.lblUsuario.Text = "Usuário *";

            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsuario.Location = new System.Drawing.Point(28, 210);
            this.txtUsuario.Size = new System.Drawing.Size(270, 26);
            this.txtUsuario.TabIndex = 2;

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblEmail.Location = new System.Drawing.Point(318, 188);
            this.lblEmail.Text = "E-mail";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(318, 210);
            this.txtEmail.Size = new System.Drawing.Size(274, 26);
            this.txtEmail.TabIndex = 3;

            // Tipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblTipo.Location = new System.Drawing.Point(28, 248);
            this.lblTipo.Text = "Tipo de usuário *";

            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
                "Administrador",
                "Usuario"
            });
            this.cmbTipoUsuario.Location = new System.Drawing.Point(28, 270);
            this.cmbTipoUsuario.Size = new System.Drawing.Size(270, 25);
            this.cmbTipoUsuario.TabIndex = 4;
            this.cmbTipoUsuario.SelectedIndex = 1;

            // Senha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblSenha.Location = new System.Drawing.Point(318, 248);
            this.lblSenha.Text = "Senha *";

            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSenha.Location = new System.Drawing.Point(318, 270);
            this.txtSenha.Size = new System.Drawing.Size(228, 26);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;

            this.btnMostrarSenha.BackColor = System.Drawing.Color.White;
            this.btnMostrarSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 218, 232);
            this.btnMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarSenha.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.btnMostrarSenha.Location = new System.Drawing.Point(548, 270);
            this.btnMostrarSenha.Size = new System.Drawing.Size(44, 26);
            this.btnMostrarSenha.Text = "◉";
            this.btnMostrarSenha.UseVisualStyleBackColor = false;

            // Confirmar
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblConfirmarSenha.Location = new System.Drawing.Point(28, 308);
            this.lblConfirmarSenha.Text = "Confirmar senha *";

            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(28, 330);
            this.txtConfirmarSenha.Size = new System.Drawing.Size(228, 26);
            this.txtConfirmarSenha.TabIndex = 6;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;

            this.btnMostrarConfirmacao.BackColor = System.Drawing.Color.White;
            this.btnMostrarConfirmacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 218, 232);
            this.btnMostrarConfirmacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarConfirmacao.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.btnMostrarConfirmacao.Location = new System.Drawing.Point(258, 330);
            this.btnMostrarConfirmacao.Size = new System.Drawing.Size(44, 26);
            this.btnMostrarConfirmacao.Text = "◉";
            this.btnMostrarConfirmacao.UseVisualStyleBackColor = false;

            // Permissão
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPermissao.ForeColor = System.Drawing.Color.FromArgb(15, 50, 85);
            this.lblPermissao.Location = new System.Drawing.Point(318, 308);
            this.lblPermissao.Text = "Permissão";

            this.pnlPermissao.BackColor = System.Drawing.Color.FromArgb(232, 241, 251);
            this.pnlPermissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPermissao.Location = new System.Drawing.Point(318, 330);
            this.pnlPermissao.Size = new System.Drawing.Size(274, 70);
            this.pnlPermissao.Controls.Add(this.lblPermissaoTexto);

            this.lblPermissaoTexto.AutoSize = false;
            this.lblPermissaoTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPermissaoTexto.ForeColor = System.Drawing.Color.FromArgb(45, 80, 115);
            this.lblPermissaoTexto.Location = new System.Drawing.Point(12, 9);
            this.lblPermissaoTexto.Size = new System.Drawing.Size(248, 50);
            this.lblPermissaoTexto.Text = "Administrador: acesso completo.\r\nUsuário: somente visualização e exportação.";
            this.lblPermissaoTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Cancelar
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 205, 220);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(8, 42, 78);
            this.btnCancelar.Location = new System.Drawing.Point(318, 520);
            this.btnCancelar.Size = new System.Drawing.Size(130, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            // Salvar
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(30, 130, 215);
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(458, 520);
            this.btnSalvar.Size = new System.Drawing.Size(134, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar conta";
            this.btnSalvar.UseVisualStyleBackColor = false;

            this.pnlPermissao.ResumeLayout(false);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
