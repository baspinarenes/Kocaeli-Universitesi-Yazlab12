namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelProgramAdi = new System.Windows.Forms.Label();
            this.panelSunucular = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSunucular = new System.Windows.Forms.FlowLayoutPanel();
            this.kapatDugmesi = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanelMenü = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.kapatDugmesi)).BeginInit();
            this.flowLayoutPanelMenü.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProgramAdi
            // 
            this.labelProgramAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.labelProgramAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProgramAdi.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProgramAdi.ForeColor = System.Drawing.Color.White;
            this.labelProgramAdi.Location = new System.Drawing.Point(0, 0);
            this.labelProgramAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgramAdi.Name = "labelProgramAdi";
            this.labelProgramAdi.Size = new System.Drawing.Size(640, 57);
            this.labelProgramAdi.TabIndex = 0;
            this.labelProgramAdi.Text = "SUNUCU KONTROL ODASI";
            this.labelProgramAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProgramAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelProgramAdi_MouseDown);
            this.labelProgramAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelProgramAdi_MouseMove);
            this.labelProgramAdi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelProgramAdi_MouseUp);
            // 
            // panelSunucular
            // 
            this.panelSunucular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelSunucular.Location = new System.Drawing.Point(112, 57);
            this.panelSunucular.Margin = new System.Windows.Forms.Padding(0);
            this.panelSunucular.Name = "panelSunucular";
            this.panelSunucular.Size = new System.Drawing.Size(505, 342);
            this.panelSunucular.TabIndex = 17;
            this.panelSunucular.Visible = false;
            // 
            // flowLayoutPanelSunucular
            // 
            this.flowLayoutPanelSunucular.AutoScroll = true;
            this.flowLayoutPanelSunucular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.flowLayoutPanelSunucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSunucular.Location = new System.Drawing.Point(147, 57);
            this.flowLayoutPanelSunucular.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSunucular.Name = "flowLayoutPanelSunucular";
            this.flowLayoutPanelSunucular.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanelSunucular.Size = new System.Drawing.Size(493, 394);
            this.flowLayoutPanelSunucular.TabIndex = 5;
            // 
            // kapatDugmesi
            // 
            this.kapatDugmesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.kapatDugmesi.Image = ((System.Drawing.Image)(resources.GetObject("kapatDugmesi.Image")));
            this.kapatDugmesi.ImageActive = null;
            this.kapatDugmesi.Location = new System.Drawing.Point(595, 11);
            this.kapatDugmesi.Margin = new System.Windows.Forms.Padding(2);
            this.kapatDugmesi.Name = "kapatDugmesi";
            this.kapatDugmesi.Size = new System.Drawing.Size(34, 36);
            this.kapatDugmesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kapatDugmesi.TabIndex = 19;
            this.kapatDugmesi.TabStop = false;
            this.kapatDugmesi.Zoom = 10;
            this.kapatDugmesi.Click += new System.EventHandler(this.kapatDugmesi_Click);
            // 
            // flowLayoutPanelMenü
            // 
            this.flowLayoutPanelMenü.AutoScroll = true;
            this.flowLayoutPanelMenü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.flowLayoutPanelMenü.Controls.Add(this.bunifuCustomLabel1);
            this.flowLayoutPanelMenü.Controls.Add(this.label6);
            this.flowLayoutPanelMenü.Controls.Add(this.label1);
            this.flowLayoutPanelMenü.Controls.Add(this.label2);
            this.flowLayoutPanelMenü.Controls.Add(this.label3);
            this.flowLayoutPanelMenü.Controls.Add(this.label4);
            this.flowLayoutPanelMenü.Controls.Add(this.label5);
            this.flowLayoutPanelMenü.Controls.Add(this.label8);
            this.flowLayoutPanelMenü.Controls.Add(this.label10);
            this.flowLayoutPanelMenü.Controls.Add(this.label12);
            this.flowLayoutPanelMenü.Controls.Add(this.label7);
            this.flowLayoutPanelMenü.Controls.Add(this.splitter1);
            this.flowLayoutPanelMenü.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenü.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMenü.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanelMenü.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMenü.Name = "flowLayoutPanelMenü";
            this.flowLayoutPanelMenü.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelMenü.Size = new System.Drawing.Size(147, 394);
            this.flowLayoutPanelMenü.TabIndex = 1;
            this.flowLayoutPanelMenü.WrapContents = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(147, 38);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "Sunucu Bilgileri";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "\r\nÇalışan Alt Sunucu Threadi:\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Alt Sunucu Sayısı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 22;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thread Sayısı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 24;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Alt Sunucu Thread Sayısı:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(3, 252);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(141, 33);
            this.label10.TabIndex = 33;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "Geçen Süre:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 309);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(141, 27);
            this.label7.TabIndex = 32;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 339);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 5);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 451);
            this.Controls.Add(this.kapatDugmesi);
            this.Controls.Add(this.flowLayoutPanelSunucular);
            this.Controls.Add(this.flowLayoutPanelMenü);
            this.Controls.Add(this.labelProgramAdi);
            this.Controls.Add(this.panelSunucular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sunucular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.kapatDugmesi)).EndInit();
            this.flowLayoutPanelMenü.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProgramAdi;
        private System.Windows.Forms.Panel panelSunucular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSunucular;
        private Bunifu.Framework.UI.BunifuImageButton kapatDugmesi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenü;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label8;
    }
}

