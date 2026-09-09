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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RH Control";
            this.TopMost = true;

            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Size = new System.Drawing.Size(760, 6);

            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::RHControl.Properties.Resources.logorh;
            this.picLogo.Location = new System.Drawing.Point(280, 42);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 175);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(80, 220);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 46);
            this.lblTitulo.Text = "RH Control";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitulo.Location = new System.Drawing.Point(80, 264);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 26);
            this.lblSubtitulo.Text = "Gestão de Pessoas";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblStatus.Location = new System.Drawing.Point(110, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(540, 24);
            this.lblStatus.Text = "Inicializando o sistema...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.progressBar.Location = new System.Drawing.Point(145, 340);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(470, 8);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;

            this.lblPorcentagem.AutoSize = false;
            this.lblPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPorcentagem.ForeColor = System.Drawing.Color.FromArgb(96, 165, 250);
            this.lblPorcentagem.Location = new System.Drawing.Point(625, 332);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(45, 24);
            this.lblPorcentagem.Text = "0%";
            this.lblPorcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblRodape.AutoSize = false;
            this.lblRodape.BackColor = System.Drawing.Color.Transparent;
            this.lblRodape.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRodape.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRodape.Location = new System.Drawing.Point(80, 382);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(600, 24);
            this.lblRodape.Text = "Organização de hoje, um futuro melhor.";
            this.lblRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.timerLoading.Interval = 40;

            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlTopo);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}