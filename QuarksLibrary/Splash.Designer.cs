namespace QuarksLibrary
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.splashProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 1000;
            this.splashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splashProgress
            // 
            this.splashProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splashProgress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.splashProgress.Location = new System.Drawing.Point(0, 444);
            this.splashProgress.Name = "splashProgress";
            this.splashProgress.Size = new System.Drawing.Size(621, 10);
            this.splashProgress.Step = 50;
            this.splashProgress.TabIndex = 0;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.splashProgress);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.ProgressBar splashProgress;
    }
}