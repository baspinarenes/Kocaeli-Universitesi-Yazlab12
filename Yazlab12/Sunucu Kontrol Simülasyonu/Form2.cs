using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Panel tutucu;
        int bilgileriGosterilecekSunucununIndeksi;
        List<Sunucu> sunucularinListesi;
        Thread guiGuncelleThread;
        Panel bilgileriGosterilecekPanel;

        System.Windows.Forms.Timer guiGuncelleThreadTimer;

        public Form2(Panel bilgileriGosterilecekPanel, int bilgileriGosterilecekSunucununIndeksi, List<Sunucu> sunucular)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.bilgileriGosterilecekPanel = bilgileriGosterilecekPanel;
            this.bilgileriGosterilecekSunucununIndeksi = bilgileriGosterilecekSunucununIndeksi;
            tutucu = bilgileriGosterilecekPanel;
            sunucularinListesi = sunucular;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guiGuncelleThreadTimer = new System.Windows.Forms.Timer();
            guiGuncelleThreadTimer.Interval = 1;
            guiGuncelleThreadTimer.Tick += GuiGuncelleTimer_Tick;

            Form first = (Form)Application.OpenForms["Form1"];
            this.Location = new System.Drawing.Point(first.Location.X + 641, first.Location.Y + 57);

            foreach (Label p in bilgileriGosterilecekPanel.Controls.OfType<Label>())
            {
                Form2labelBaslik.Text = p.Text;
            }

            guiGuncelleThread = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                            {
                                guiGuncelleThreadTimer.Start();
                            });

            });
            guiGuncelleThread.Start();
        }

        private void GuiGuncelleTimer_Tick(object sender, EventArgs e)
        {
            if (Form1.sunuculariTutanListe[bilgileriGosterilecekSunucununIndeksi] != null)
            {
                foreach (Label p in bilgileriGosterilecekPanel.Controls.OfType<Label>())
                {
                    Form2labelBaslik.Text = p.Text;
                }

                foreach (BunifuCircleProgressbar p in tutucu.Controls.OfType<BunifuCircleProgressbar>())
                {
                    Form2kapasiteProgressBar.Value = p.Value;
                }

                Form2labelKapasiteDegeri.Text = Form1.sunuculariTutanListe[bilgileriGosterilecekSunucununIndeksi].kapasite.ToString();
                Form2labelCevaplananIstekDegeri.Text = Form1.sunuculariTutanListe[bilgileriGosterilecekSunucununIndeksi].cevaplananIstek.ToString();
                Form2labelGelenIstekDegeri.Text = Form1.sunuculariTutanListe[bilgileriGosterilecekSunucununIndeksi].gelenIstek.ToString();
                Form2labelBekleyenIstekDegeri.Text = Form1.sunuculariTutanListe[bilgileriGosterilecekSunucununIndeksi].bekleyenIstek.ToString();
            }
            else
            {
                Form2labelBaslik.Text = "null";
                Form2kapasiteProgressBar.Value = 0;
                Form2labelKapasiteDegeri.Text = "null";
                Form2labelCevaplananIstekDegeri.Text = "null";
                Form2labelGelenIstekDegeri.Text = "null";
                Form2labelBekleyenIstekDegeri.Text = "null";
            }
        }

        private void Form2CikisButonu_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            guiGuncelleThread.Abort();
            this.Dispose();
        }
    }
}