namespace RHControl
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox picLogo;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnMostrarSenha;

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEsqueciSenha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLateral = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            picUsuario = new PictureBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            picSenha = new PictureBox();
            txtSenha = new TextBox();
            btnMostrarSenha = new Button();
            btnEntrar = new Button();
            btnEsqueciSenha = new Button();
            pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(21, 101, 192);
            pnlLateral.Controls.Add(picLogo);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(300, 580);
            pnlLateral.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logorh;
            picLogo.Location = new Point(40, 170);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(220, 220);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(21, 101, 192);
            lblTitulo.Location = new Point(430, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Acesso ao sistema";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(430, 140);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(236, 19);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Entre com seus dados para continuar";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(51, 51, 51);
            lblUsuario.Location = new Point(430, 210);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário";
            // 
            // picUsuario
            // 
            picUsuario.BackColor = Color.Transparent;
            picUsuario.Image = Properties.Resources.ico_usuario;
            picUsuario.Location = new Point(395, 238);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(28, 28);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 5;
            picUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(430, 235);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(51, 51, 51);
            lblSenha.Location = new Point(430, 295);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 19);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // picSenha
            // 
            picSenha.BackColor = Color.Transparent;
            picSenha.Image = Properties.Resources.ico_senha;
            picSenha.Location = new Point(395, 323);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(28, 28);
            picSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picSenha.TabIndex = 8;
            picSenha.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(430, 320);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(260, 27);
            txtSenha.TabIndex = 9;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnMostrarSenha
            // 
            btnMostrarSenha.BackColor = Color.White;
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.FlatAppearance.BorderSize = 0;
            btnMostrarSenha.FlatAppearance.MouseDownBackColor = Color.White;
            btnMostrarSenha.FlatAppearance.MouseOverBackColor = Color.White;
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.Image = Properties.Resources.ico_mostrar;
            btnMostrarSenha.Location = new Point(690, 320);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(40, 27);
            btnMostrarSenha.TabIndex = 10;
            btnMostrarSenha.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(21, 101, 192);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 71, 161);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Image = Properties.Resources.ico_entrar;
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(430, 375);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Padding = new Padding(10, 0, 0, 0);
            btnEntrar.Size = new Size(300, 42);
            btnEntrar.TabIndex = 11;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.BackColor = Color.Transparent;
            btnEsqueciSenha.Cursor = Cursors.Hand;
            btnEsqueciSenha.FlatAppearance.BorderSize = 0;
            btnEsqueciSenha.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEsqueciSenha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEsqueciSenha.FlatStyle = FlatStyle.Flat;
            btnEsqueciSenha.Font = new Font("Segoe UI", 9.5F);
            btnEsqueciSenha.ForeColor = Color.FromArgb(21, 101, 192);
            btnEsqueciSenha.Image = Properties.Resources.ico_esqueci;
            btnEsqueciSenha.ImageAlign = ContentAlignment.MiddleLeft;
            btnEsqueciSenha.Location = new Point(475, 430);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(210, 32);
            btnEsqueciSenha.TabIndex = 12;
            btnEsqueciSenha.Text = "Esqueci minha senha";
            btnEsqueciSenha.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 580);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnMostrarSenha);
            Controls.Add(txtSenha);
            Controls.Add(picSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(picUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RH Control — Gestão de Pessoas";
            pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}