using System.Drawing;
using System.Windows.Forms;

namespace RHControl.Forms
{
    partial class FrmNovaSenha
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblInstrucao;
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
        private Button btnSalvar;
        private Button btnCancelar;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);

            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nova senha";

            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = false;
            this.lblInstrucao.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.lblInstrucao.Location = new System.Drawing.Point(43, 78);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(390, 45);
            this.lblInstrucao.TabIndex = 1;
            this.lblInstrucao.Text =
                "Digite sua nova senha e confirme para concluir a recuperação.";

            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.lblNovaSenha.Location = new System.Drawing.Point(43, 140);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(75, 19);
            this.lblNovaSenha.TabIndex = 2;
            this.lblNovaSenha.Text = "Nova senha";

            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.txtNovaSenha.Location = new System.Drawing.Point(43, 165);
            this.txtNovaSenha.MaxLength = 100;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(390, 27);
            this.txtNovaSenha.TabIndex = 3;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            this.txtNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNovaSenha_KeyDown);

            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.lblConfirmarSenha.Location = new System.Drawing.Point(43, 210);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(128, 19);
            this.lblConfirmarSenha.TabIndex = 4;
            this.lblConfirmarSenha.Text = "Confirmar nova senha";

            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.txtConfirmarSenha.Location = new System.Drawing.Point(43, 235);
            this.txtConfirmarSenha.MaxLength = 100;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(390, 27);
            this.txtConfirmarSenha.TabIndex = 5;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmarSenha_KeyDown);

            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);

            this.btnCancelar.Location = new System.Drawing.Point(43, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);

            this.btnSalvar.Location = new System.Drawing.Point(253, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(180, 40);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar nova senha";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);

            // 
            // FrmNovaSenha
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova senha";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}