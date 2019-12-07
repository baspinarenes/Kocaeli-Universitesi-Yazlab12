namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Form2labelKapasite = new System.Windows.Forms.Label();
            this.Form2labelGelenIstek = new System.Windows.Forms.Label();
            this.Form2labelCevaplananIstek = new System.Windows.Forms.Label();
            this.Form2labelBaslik = new System.Windows.Forms.Label();
            this.Form2kapasiteProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Form2labelKapasiteDegeri = new System.Windows.Forms.Label();
            this.Form2labelGelenIstekDegeri = new System.Windows.Forms.Label();
            this.Form2labelCevaplananIstekDegeri = new System.Windows.Forms.Label();
            this.Form2CikisButonu = new Bunifu.Framework.UI.BunifuImageButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Form2labelBekleyenIstek = new System.Windows.Forms.Label();
            this.Form2labelBekleyenIstekDegeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Form2CikisButonu)).BeginInit();
            this.SuspendLayout();
            // 
            // Form2labelKapasite
            // 
            this.Form2labelKapasite.AutoSize = true;
            this.Form2labelKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelKapasite.ForeColor = System.Drawing.Color.White;
            this.Form2labelKapasite.Location = new System.Drawing.Point(68, 242);
            this.Form2labelKapasite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelKapasite.Name = "Form2labelKapasite";
            this.Form2labelKapasite.Size = new System.Drawing.Size(73, 18);
            this.Form2labelKapasite.TabIndex = 10;
            this.Form2labelKapasite.Text = "Kapasite: ";
            // 
            // Form2labelGelenIstek
            // 
            this.Form2labelGelenIstek.AutoSize = true;
            this.Form2labelGelenIstek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelGelenIstek.ForeColor = System.Drawing.Color.White;
            this.Form2labelGelenIstek.Location = new System.Drawing.Point(68, 272);
            this.Form2labelGelenIstek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelGelenIstek.Name = "Form2labelGelenIstek";
            this.Form2labelGelenIstek.Size = new System.Drawing.Size(86, 18);
            this.Form2labelGelenIstek.TabIndex = 11;
            this.Form2labelGelenIstek.Text = "Gelen Istek:";
            // 
            // Form2labelCevaplananIstek
            // 
            this.Form2labelCevaplananIstek.AutoSize = true;
            this.Form2labelCevaplananIstek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelCevaplananIstek.ForeColor = System.Drawing.Color.White;
            this.Form2labelCevaplananIstek.Location = new System.Drawing.Point(68, 303);
            this.Form2labelCevaplananIstek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelCevaplananIstek.Name = "Form2labelCevaplananIstek";
            this.Form2labelCevaplananIstek.Size = new System.Drawing.Size(124, 18);
            this.Form2labelCevaplananIstek.TabIndex = 12;
            this.Form2labelCevaplananIstek.Text = "Cevaplanan Istek:";
            // 
            // Form2labelBaslik
            // 
            this.Form2labelBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelBaslik.ForeColor = System.Drawing.Color.White;
            this.Form2labelBaslik.Location = new System.Drawing.Point(-3, 73);
            this.Form2labelBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelBaslik.Name = "Form2labelBaslik";
            this.Form2labelBaslik.Size = new System.Drawing.Size(297, 19);
            this.Form2labelBaslik.TabIndex = 28;
            this.Form2labelBaslik.Text = "Ana Sunucu";
            this.Form2labelBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2kapasiteProgressBar
            // 
            this.Form2kapasiteProgressBar.animated = false;
            this.Form2kapasiteProgressBar.animationIterval = 5;
            this.Form2kapasiteProgressBar.animationSpeed = 300;
            this.Form2kapasiteProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Form2kapasiteProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Form2kapasiteProgressBar.BackgroundImage")));
            this.Form2kapasiteProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Form2kapasiteProgressBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.Form2kapasiteProgressBar.LabelVisible = true;
            this.Form2kapasiteProgressBar.LineProgressThickness = 8;
            this.Form2kapasiteProgressBar.LineThickness = 5;
            this.Form2kapasiteProgressBar.Location = new System.Drawing.Point(81, 99);
            this.Form2kapasiteProgressBar.Margin = new System.Windows.Forms.Padding(8, 7, 11, 7);
            this.Form2kapasiteProgressBar.MaxValue = 100;
            this.Form2kapasiteProgressBar.Name = "Form2kapasiteProgressBar";
            this.Form2kapasiteProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Form2kapasiteProgressBar.ProgressColor = System.Drawing.Color.Red;
            this.Form2kapasiteProgressBar.Size = new System.Drawing.Size(126, 126);
            this.Form2kapasiteProgressBar.TabIndex = 29;
            this.Form2kapasiteProgressBar.Value = 100;
            // 
            // Form2labelKapasiteDegeri
            // 
            this.Form2labelKapasiteDegeri.AutoSize = true;
            this.Form2labelKapasiteDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelKapasiteDegeri.ForeColor = System.Drawing.Color.White;
            this.Form2labelKapasiteDegeri.Location = new System.Drawing.Point(200, 242);
            this.Form2labelKapasiteDegeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelKapasiteDegeri.Name = "Form2labelKapasiteDegeri";
            this.Form2labelKapasiteDegeri.Size = new System.Drawing.Size(16, 18);
            this.Form2labelKapasiteDegeri.TabIndex = 30;
            this.Form2labelKapasiteDegeri.Text = "0";
            // 
            // Form2labelGelenIstekDegeri
            // 
            this.Form2labelGelenIstekDegeri.AutoSize = true;
            this.Form2labelGelenIstekDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelGelenIstekDegeri.ForeColor = System.Drawing.Color.White;
            this.Form2labelGelenIstekDegeri.Location = new System.Drawing.Point(200, 272);
            this.Form2labelGelenIstekDegeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelGelenIstekDegeri.Name = "Form2labelGelenIstekDegeri";
            this.Form2labelGelenIstekDegeri.Size = new System.Drawing.Size(16, 18);
            this.Form2labelGelenIstekDegeri.TabIndex = 31;
            this.Form2labelGelenIstekDegeri.Text = "0";
            // 
            // Form2labelCevaplananIstekDegeri
            // 
            this.Form2labelCevaplananIstekDegeri.AutoSize = true;
            this.Form2labelCevaplananIstekDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelCevaplananIstekDegeri.ForeColor = System.Drawing.Color.White;
            this.Form2labelCevaplananIstekDegeri.Location = new System.Drawing.Point(200, 303);
            this.Form2labelCevaplananIstekDegeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelCevaplananIstekDegeri.Name = "Form2labelCevaplananIstekDegeri";
            this.Form2labelCevaplananIstekDegeri.Size = new System.Drawing.Size(16, 18);
            this.Form2labelCevaplananIstekDegeri.TabIndex = 32;
            this.Form2labelCevaplananIstekDegeri.Text = "0";
            // 
            // Form2CikisButonu
            // 
            this.Form2CikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Form2CikisButonu.Image = ((System.Drawing.Image)(resources.GetObject("Form2CikisButonu.Image")));
            this.Form2CikisButonu.ImageActive = null;
            this.Form2CikisButonu.Location = new System.Drawing.Point(241, 10);
            this.Form2CikisButonu.Margin = new System.Windows.Forms.Padding(2);
            this.Form2CikisButonu.Name = "Form2CikisButonu";
            this.Form2CikisButonu.Size = new System.Drawing.Size(38, 37);
            this.Form2CikisButonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Form2CikisButonu.TabIndex = 34;
            this.Form2CikisButonu.TabStop = false;
            this.Form2CikisButonu.Zoom = 10;
            this.Form2CikisButonu.Click += new System.EventHandler(this.Form2CikisButonu_Click);
            // 
            // Form2labelBekleyenIstek
            // 
            this.Form2labelBekleyenIstek.AutoSize = true;
            this.Form2labelBekleyenIstek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelBekleyenIstek.ForeColor = System.Drawing.Color.White;
            this.Form2labelBekleyenIstek.Location = new System.Drawing.Point(68, 332);
            this.Form2labelBekleyenIstek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelBekleyenIstek.Name = "Form2labelBekleyenIstek";
            this.Form2labelBekleyenIstek.Size = new System.Drawing.Size(107, 18);
            this.Form2labelBekleyenIstek.TabIndex = 35;
            this.Form2labelBekleyenIstek.Text = "Bekleyen Istek:";
            // 
            // Form2labelBekleyenIstekDegeri
            // 
            this.Form2labelBekleyenIstekDegeri.AutoSize = true;
            this.Form2labelBekleyenIstekDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Form2labelBekleyenIstekDegeri.ForeColor = System.Drawing.Color.White;
            this.Form2labelBekleyenIstekDegeri.Location = new System.Drawing.Point(200, 332);
            this.Form2labelBekleyenIstekDegeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Form2labelBekleyenIstekDegeri.Name = "Form2labelBekleyenIstekDegeri";
            this.Form2labelBekleyenIstekDegeri.Size = new System.Drawing.Size(16, 18);
            this.Form2labelBekleyenIstekDegeri.TabIndex = 36;
            this.Form2labelBekleyenIstekDegeri.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(290, 394);
            this.Controls.Add(this.Form2labelBekleyenIstekDegeri);
            this.Controls.Add(this.Form2labelBekleyenIstek);
            this.Controls.Add(this.Form2CikisButonu);
            this.Controls.Add(this.Form2labelCevaplananIstekDegeri);
            this.Controls.Add(this.Form2labelGelenIstekDegeri);
            this.Controls.Add(this.Form2labelKapasiteDegeri);
            this.Controls.Add(this.Form2kapasiteProgressBar);
            this.Controls.Add(this.Form2labelBaslik);
            this.Controls.Add(this.Form2labelCevaplananIstek);
            this.Controls.Add(this.Form2labelGelenIstek);
            this.Controls.Add(this.Form2labelKapasite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form2CikisButonu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Form2labelKapasite;
        private System.Windows.Forms.Label Form2labelGelenIstek;
        private System.Windows.Forms.Label Form2labelCevaplananIstek;
        private System.Windows.Forms.Label Form2labelBaslik;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Form2kapasiteProgressBar;
        private System.Windows.Forms.Label Form2labelKapasiteDegeri;
        private System.Windows.Forms.Label Form2labelGelenIstekDegeri;
        private System.Windows.Forms.Label Form2labelCevaplananIstekDegeri;
        private Bunifu.Framework.UI.BunifuImageButton Form2CikisButonu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Form2labelBekleyenIstek;
        private System.Windows.Forms.Label Form2labelBekleyenIstekDegeri;
    }
}