namespace RHControl
{
    partial class FrmLoading
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Timer timerLoading;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblRodape = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);

            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(700, 8);
            this.pnlTopo.TabIndex = 0;

            // 
            // picLogo
            // 
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;
            this.picLogo.Location = new System.Drawing.Point(275, 55);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                24F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblTitulo.Location = new System.Drawing.Point(258, 210);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 45);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "RH Control";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                11F
            );
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.lblSubtitulo.Location = new System.Drawing.Point(272, 258);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(156, 20);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Gestão de Pessoas";

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F
            );
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblStatus.Location = new System.Drawing.Point(180, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Inicializando o sistema...";

            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(180, 330);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 12);
            this.progressBar.Style =
                System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;

            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblPorcentagem.ForeColor =
                System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblPorcentagem.Location = new System.Drawing.Point(530, 326);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(45, 20);
            this.lblPorcentagem.TabIndex = 6;
            this.lblPorcentagem.Text = "0%";
            this.lblPorcentagem.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F
            );
            this.lblRodape.ForeColor = System.Drawing.Color.Gray;
            this.lblRodape.Location = new System.Drawing.Point(258, 370);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(184, 15);
            this.lblRodape.TabIndex = 7;
            this.lblRodape.Text = "Organização de hoje, um futuro melhor.";

            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 40;

            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 410);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblRodape);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH Control";
            this.ShowInTaskbar = false;

            this.pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}