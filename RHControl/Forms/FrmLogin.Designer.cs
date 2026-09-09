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

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlCampoUsuario;
        private System.Windows.Forms.Panel pnlCampoSenha;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblOrganizacao;
        private System.Windows.Forms.Label lblOrganizacaoDesc;
        private System.Windows.Forms.Label lblProdutividade;
        private System.Windows.Forms.Label lblProdutividadeDesc;
        private System.Windows.Forms.Label lblSeguranca;
        private System.Windows.Forms.Label lblSegurancaDesc;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblResultadosDesc;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Label lblLoginRodape;
        private System.Windows.Forms.CheckBox chkLembrar;
        private System.Windows.Forms.Label lblLinha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlLateral = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblOrganizacao = new System.Windows.Forms.Label();
            this.lblOrganizacaoDesc = new System.Windows.Forms.Label();
            this.lblProdutividade = new System.Windows.Forms.Label();
            this.lblProdutividadeDesc = new System.Windows.Forms.Label();
            this.lblSeguranca = new System.Windows.Forms.Label();
            this.lblSegurancaDesc = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblResultadosDesc = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();

            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCampoUsuario = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();

            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlCampoSenha = new System.Windows.Forms.Panel();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnMostrarSenha = new System.Windows.Forms.Button();

            this.chkLembrar = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEsqueciSenha = new System.Windows.Forms.Button();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblLoginRodape = new System.Windows.Forms.Label();
            this.lblRodape = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlCampoUsuario.SuspendLayout();
            this.pnlCampoSenha.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(9, 20, 36);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH Control — Gestão de Pessoas";

            // LATERAL
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(8, 71, 151);
            this.pnlLateral.Controls.Add(this.lblVersao);
            this.pnlLateral.Controls.Add(this.lblResultadosDesc);
            this.pnlLateral.Controls.Add(this.lblResultados);
            this.pnlLateral.Controls.Add(this.lblSegurancaDesc);
            this.pnlLateral.Controls.Add(this.lblSeguranca);
            this.pnlLateral.Controls.Add(this.lblProdutividadeDesc);
            this.pnlLateral.Controls.Add(this.lblProdutividade);
            this.pnlLateral.Controls.Add(this.lblOrganizacaoDesc);
            this.pnlLateral.Controls.Add(this.lblOrganizacao);
            this.pnlLateral.Controls.Add(this.lblSlogan);
            this.pnlLateral.Controls.Add(this.picLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(390, 620);
            this.pnlLateral.TabIndex = 0;

            // LOGO
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;
            this.picLogo.Location = new System.Drawing.Point(75, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(240, 190);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            // SLOGAN
            this.lblSlogan.AutoSize = false;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(52, 254);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(290, 65);
            this.lblSlogan.Text = "Gestão de Pessoas\r\nmais simples e eficiente.";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // BENEFÍCIOS
            ConfigureBenefit(this.lblOrganizacao, "●  Organização", 50, 354);
            ConfigureBenefitDesc(this.lblOrganizacaoDesc, "Processos mais eficientes", 50, 382);

            ConfigureBenefit(this.lblResultados, "●  Resultados", 207, 354);
            ConfigureBenefitDesc(this.lblResultadosDesc, "Gestão inteligente", 207, 382);

            ConfigureBenefit(this.lblProdutividade, "●  Produtividade", 50, 420);
            ConfigureBenefitDesc(this.lblProdutividadeDesc, "Equipes mais engajadas", 50, 448);

            ConfigureBenefit(this.lblSeguranca, "●  Segurança", 50, 486);
            ConfigureBenefitDesc(this.lblSegurancaDesc, "Seus dados protegidos", 50, 514);

            // VERSÃO
            this.lblVersao.AutoSize = false;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(166, 207, 250);
            this.lblVersao.Location = new System.Drawing.Point(50, 570);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(300, 24);
            this.lblVersao.Text = "RH Control  •  Gestão de Pessoas  |  Versão 1.0.0";

            // LOGIN
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(15, 32, 54);
            this.pnlLogin.Controls.Add(this.lblRodape);
            this.pnlLogin.Controls.Add(this.lblLoginRodape);
            this.pnlLogin.Controls.Add(this.lblLinha);
            this.pnlLogin.Controls.Add(this.btnEsqueciSenha);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.chkLembrar);
            this.pnlLogin.Controls.Add(this.pnlCampoSenha);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.pnlCampoUsuario);
            this.pnlLogin.Controls.Add(this.lblUsuario);
            this.pnlLogin.Controls.Add(this.lblSubtitulo);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Location = new System.Drawing.Point(440, 48);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(500, 522);
            this.pnlLogin.TabIndex = 1;

            // TÍTULO
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 50);
            this.lblTitulo.Text = "Bem-vindo!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(166, 188, 214);
            this.lblSubtitulo.Location = new System.Drawing.Point(50, 88);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(400, 25);
            this.lblSubtitulo.Text = "Faça seu login para acessar o sistema.";

            // LABEL USUÁRIO
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(50, 143);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblUsuario.Text = "Usuário";

            // CAMPO USUÁRIO
            this.pnlCampoUsuario.BackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.pnlCampoUsuario.Location = new System.Drawing.Point(50, 174);
            this.pnlCampoUsuario.Name = "pnlCampoUsuario";
            this.pnlCampoUsuario.Size = new System.Drawing.Size(400, 42);
            this.pnlCampoUsuario.TabIndex = 4;

            this.picUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picUsuario.Image = global::RHControl.Properties.Resources.ico_usuario;
            this.picUsuario.Location = new System.Drawing.Point(12, 9);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(24, 24);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabStop = false;

            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(47, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 20);
            this.txtUsuario.TabIndex = 5;

            this.pnlCampoUsuario.Controls.Add(this.txtUsuario);
            this.pnlCampoUsuario.Controls.Add(this.picUsuario);

            // LABEL SENHA
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(50, 233);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.Text = "Senha";

            // CAMPO SENHA
            this.pnlCampoSenha.BackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.pnlCampoSenha.Location = new System.Drawing.Point(50, 264);
            this.pnlCampoSenha.Name = "pnlCampoSenha";
            this.pnlCampoSenha.Size = new System.Drawing.Size(400, 42);
            this.pnlCampoSenha.TabIndex = 7;

            this.picSenha.BackColor = System.Drawing.Color.Transparent;
            this.picSenha.Image = global::RHControl.Properties.Resources.ico_senha;
            this.picSenha.Location = new System.Drawing.Point(12, 9);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSenha.TabStop = false;

            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(47, 9);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(300, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;

            this.btnMostrarSenha.BackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.btnMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarSenha.FlatAppearance.BorderSize = 0;
            this.btnMostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 46, 73);
            this.btnMostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 60, 90);
            this.btnMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarSenha.Image = global::RHControl.Properties.Resources.ico_mostrar;
            this.btnMostrarSenha.Location = new System.Drawing.Point(350, 5);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(45, 32);
            this.btnMostrarSenha.TabIndex = 9;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;

            this.pnlCampoSenha.Controls.Add(this.btnMostrarSenha);
            this.pnlCampoSenha.Controls.Add(this.txtSenha);
            this.pnlCampoSenha.Controls.Add(this.picSenha);

            // LEMBRAR
            this.chkLembrar.AutoSize = true;
            this.chkLembrar.BackColor = System.Drawing.Color.Transparent;
            this.chkLembrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLembrar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkLembrar.ForeColor = System.Drawing.Color.FromArgb(215, 225, 238);
            this.chkLembrar.Location = new System.Drawing.Point(50, 327);
            this.chkLembrar.Name = "chkLembrar";
            this.chkLembrar.Size = new System.Drawing.Size(95, 21);
            this.chkLembrar.TabIndex = 10;
            this.chkLembrar.Text = "Lembrar-me";
            this.chkLembrar.UseVisualStyleBackColor = false;

            // ESQUECI SENHA
            this.btnEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsqueciSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqueciSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEsqueciSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEsqueciSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueciSenha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(44, 177, 255);
            this.btnEsqueciSenha.Location = new System.Drawing.Point(260, 318);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(190, 30);
            this.btnEsqueciSenha.TabIndex = 11;
            this.btnEsqueciSenha.Text = "Esqueci minha senha?";
            this.btnEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEsqueciSenha.UseVisualStyleBackColor = false;

            // ENTRAR
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(18, 126, 255);
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(9, 88, 198);
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 145, 255);
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = null;
            this.btnEntrar.Location = new System.Drawing.Point(50, 370);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(400, 48);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;

            // LINHA
            this.lblLinha.AutoSize = false;
            this.lblLinha.BackColor = System.Drawing.Color.FromArgb(45, 66, 91);
            this.lblLinha.Location = new System.Drawing.Point(50, 439);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(400, 1);
            this.lblLinha.TabIndex = 13;

            // RODAPÉ
            this.lblLoginRodape.AutoSize = false;
            this.lblLoginRodape.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginRodape.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoginRodape.ForeColor = System.Drawing.Color.White;
            this.lblLoginRodape.Location = new System.Drawing.Point(50, 454);
            this.lblLoginRodape.Name = "lblLoginRodape";
            this.lblLoginRodape.Size = new System.Drawing.Size(400, 23);
            this.lblLoginRodape.Text = "RH Control  •  Gestão de Pessoas";
            this.lblLoginRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblRodape.AutoSize = false;
            this.lblRodape.BackColor = System.Drawing.Color.Transparent;
            this.lblRodape.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRodape.ForeColor = System.Drawing.Color.FromArgb(140, 163, 190);
            this.lblRodape.Location = new System.Drawing.Point(50, 480);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(400, 22);
            this.lblRodape.Text = "Organização de hoje, um futuro melhor.";
            this.lblRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();

            // CONTROLES PRINCIPAIS
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLateral);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();

            this.pnlCampoUsuario.ResumeLayout(false);
            this.pnlCampoUsuario.PerformLayout();
            this.pnlCampoSenha.ResumeLayout(false);
            this.pnlCampoSenha.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void ConfigureBenefit(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = false;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.FromArgb(224, 239, 255);
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(160, 24);
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void ConfigureBenefitDesc(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = false;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            label.ForeColor = System.Drawing.Color.FromArgb(164, 207, 251);
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(160, 22);
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
    }
}
