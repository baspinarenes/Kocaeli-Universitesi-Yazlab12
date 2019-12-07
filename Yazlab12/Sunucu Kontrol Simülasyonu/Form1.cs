using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Değişken tanımlamaları
        int milisaniye = 0;
        int altSunucuSayisi; //Toplam o zamana kadar oluşmuş alt sunucu sayısı.
        int mov, movX, movY; //Formu hareket ettirmek için.
        Random rastgeleSayiNesnesi = new Random();
        int rastgeleSayi;


        int threadSleepDegeri = 100;
        int anaSunucuGelmeSuresi = 200;
        int anaSunucuCevaplamaSuresi = 500;
        int altSunucuGelmeSuresi = 300;
        int altSunucuCevaplamaSuresi = 500;

        //Liste tanımlamaları
        List<Panel> panelleriTutanListe = new List<Panel>();
        public static List<Sunucu> sunuculariTutanListe = new List<Sunucu>();
        List<Thread> kalıcıThreadlerinListesi = new List<Thread>();
        List<Thread> altSunucuThreadlerinListesi = new List<Thread>();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //Yasal olmayan threadlerin çalışabilmesi için.
            altSunucuSayisi = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("En"); //Hata yazılarının İngilizce olması için.
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            altSunucuThreadlerinListesi.Add(null); // ileride sunucuların numarası 1 den başladığı için kafa karıştırmaması açısından 0. indise null atadık.

            //Pencere başlığı olmadan formu hareket ettirmek için.
            //Hareket ettirmeyle ilgili komutlar projede sadece tasarımı değiştirdiği için internetten alınmıştır.
            //İlgili video için: https://www.youtube.com/watch?v=9OhepjBKcMY



            Thread AnaSunucuThread = new Thread(AnaSunucuThreadFonksiyonu);
            AnaSunucuThread.Name = "AnaSunucuThread";
            kalıcıThreadlerinListesi.Add(AnaSunucuThread);
            AnaSunucuThread.Start();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////THREAD FONKSİYONLARI////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void AnaSunucuThreadFonksiyonu()
        {
            while (true)
            {
                Console.WriteLine(string.Format("\n{0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));
                milisaniye += 100;
                if (milisaniye == 100)
                {
                    panelleriTutanListe.Add(AnaSunucuPanelOlustur());
                    Sunucu gecici1 = new Sunucu(
                        sunucuNo: 0,
                        kapasite: 10000
                        );
                    sunuculariTutanListe.Add(gecici1);

                    panelleriTutanListe.Add(AltSunucuPanelOlustur());
                    Sunucu gecici2 = new Sunucu(
                       sunucuNo: 1,
                        kapasite: 5000
                        );
                    sunuculariTutanListe.Add(gecici2);

                    panelleriTutanListe.Add(AltSunucuPanelOlustur());
                    Sunucu gecici3 = new Sunucu(
                        sunucuNo: 2,
                        kapasite: 5000
                        );
                    sunuculariTutanListe.Add(gecici3);
                }

                AnaSunucuGelenGidenKontrolFonksiyonu();

                for (int i = altSunucuThreadlerinListesi.Count; i < sunuculariTutanListe.Count; i++)
                {
                    if (sunuculariTutanListe[i] != null)
                    {
                        Thread gecici = new Thread(AltSunucuGelenGidenKontrolFonksiyonu);
                        gecici.Name = "AltSunucu" + sunuculariTutanListe[i].sunucuNo.ToString();
                        gecici.Priority = ThreadPriority.Highest;
                        altSunucuThreadlerinListesi.Add(gecici);
                        gecici.Start();
                    }
                }

                //Threadleri birer kez çalıştırmak için kısıtladık.

                if (kalıcıThreadlerinListesi.Count == 1)
                {
                    Thread AltSunucuOlusturucuThread = new Thread(AltSunucuOlusturucuThreadFonksiyonu);
                    AltSunucuOlusturucuThread.Name = "AltSunucuOlusturucuThread";
                    AltSunucuOlusturucuThread.Priority = ThreadPriority.Normal;
                    kalıcıThreadlerinListesi.Add(AltSunucuOlusturucuThread);
                    AltSunucuOlusturucuThread.Start();
                }

                if (kalıcıThreadlerinListesi.Count == 2)
                {
                    Thread SunucuTakipThread = new Thread(SunucuTakipThreadFonksiyonu);
                    SunucuTakipThread.Name = "SunucuTakipThread";
                    SunucuTakipThread.Priority = ThreadPriority.Lowest;
                    kalıcıThreadlerinListesi.Add(SunucuTakipThread);
                    SunucuTakipThread.Start();
                }

                Thread.Sleep(threadSleepDegeri);
            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////YARDIMCI FONKSİYONLAR///////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private void AnaSunucuGelenGidenKontrolFonksiyonu()
        {
            rastgeleSayi = rastgeleSayiNesnesi.Next(1, 100);
            if (milisaniye % anaSunucuGelmeSuresi == 0 && (sunuculariTutanListe[0].bekleyenIstek + rastgeleSayi) <= sunuculariTutanListe[0].kapasite)
            {
                //Console.WriteLine(string.Format("Ana Sunucu Geldi: {0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));
                //Console.WriteLine(string.Format("Ana Sunucu Gelen İstek Sayısı: {0}", rastgeleSayi));
                sunuculariTutanListe[0].gelenIstek += rastgeleSayi;
                sunuculariTutanListe[0].bekleyenIstek += rastgeleSayi;
            }

            if (milisaniye % anaSunucuCevaplamaSuresi == 0)
            {
                //Console.WriteLine(string.Format("Ana Sunucu Cevaplandı: {0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));
                rastgeleSayi = rastgeleSayiNesnesi.Next(1, 50);

                if (sunuculariTutanListe[0].bekleyenIstek >= rastgeleSayi)
                {
                    //Console.WriteLine(string.Format("Ana Sunucu Cevaplanan İstek Sayısı: {0}", rastgeleSayi));
                    sunuculariTutanListe[0].cevaplananIstek += rastgeleSayi;
                    sunuculariTutanListe[0].bekleyenIstek -= rastgeleSayi;
                }
                else if (sunuculariTutanListe[0].bekleyenIstek < rastgeleSayi && sunuculariTutanListe[0].bekleyenIstek >= 0)
                {
                    //Console.WriteLine(string.Format("Ana Sunucu Cevaplanan İstek Sayısı: {0}", sunuculariTutanListe[0].bekleyenIstek));
                    sunuculariTutanListe[0].cevaplananIstek += sunuculariTutanListe[0].bekleyenIstek;
                    sunuculariTutanListe[0].bekleyenIstek -= sunuculariTutanListe[0].bekleyenIstek;
                }
            }
        }

        private void AltSunucuGelenGidenKontrolFonksiyonu()
        {
            while (true)
            {
                Console.WriteLine(string.Format("{0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));

                LabelGuncelle(label1, Thread.CurrentThread.Name);

                //Hangi thread çalışıyorsa adının sonundaki sayıya göre sunucu listesinden işlem yaparız.

                String sayi = Thread.CurrentThread.Name.Substring(9);
                int no;
                Int32.TryParse(sayi, out no);

                if (milisaniye % altSunucuGelmeSuresi == 0)
                {
                    //Console.WriteLine(string.Format("Alt Sunucu Geldi: {0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));
                    if (sunuculariTutanListe[no] != null)
                    {
                        if (sunuculariTutanListe[no].sunucuNo != 0)
                        {
                            rastgeleSayi = rastgeleSayiNesnesi.Next(1, 50);
                            if (rastgeleSayi <= sunuculariTutanListe[0].bekleyenIstek)
                            {
                                //Console.WriteLine(string.Format("Alt Sunucu Gelen İstek Sayısı: {0}", rastgeleSayi));
                                sunuculariTutanListe[no].gelenIstek += rastgeleSayi;
                                sunuculariTutanListe[0].bekleyenIstek -= rastgeleSayi;
                                sunuculariTutanListe[no].bekleyenIstek += rastgeleSayi;
                            }

                            else
                            {
                                //Console.WriteLine(string.Format("Alt Sunucu Gelen İstek Sayısı: {0}", sunuculariTutanListe[0].bekleyenIstek));
                                sunuculariTutanListe[no].gelenIstek += sunuculariTutanListe[0].bekleyenIstek;
                                sunuculariTutanListe[0].bekleyenIstek -= sunuculariTutanListe[0].bekleyenIstek;
                                sunuculariTutanListe[no].bekleyenIstek += sunuculariTutanListe[0].bekleyenIstek;
                            }
                        }
                    }
                }

                if (milisaniye % altSunucuCevaplamaSuresi == 0)
                {
                    //Console.WriteLine(string.Format("Alt Sunucu Cevaplandı: {0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));
                    if (sunuculariTutanListe[no] != null)
                    {
                        rastgeleSayi = rastgeleSayiNesnesi.Next(1, 50);
                        if (sunuculariTutanListe[no].sunucuNo != 0 && rastgeleSayi <= sunuculariTutanListe[no].bekleyenIstek)
                        {
                            //Console.WriteLine(string.Format("Alt Sunucu Gelen İstek Sayısı: {0}", rastgeleSayi));

                            sunuculariTutanListe[no].cevaplananIstek += rastgeleSayi;
                            sunuculariTutanListe[no].bekleyenIstek -= rastgeleSayi;
                        }
                    }
                }
                Thread.Sleep(threadSleepDegeri);
            }

        }

        private void SunucuTakipThreadFonksiyonu()
        {
            while (true)
            {
                Console.WriteLine(string.Format("{0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));

                LabelGuncelle(label3, ((sunuculariTutanListe.FindAll(item => item != null).Count - 1).ToString()) + " sunucu"); //Alt sunucu sayısı
                LabelGuncelle(label5, (altSunucuThreadlerinListesi.FindAll(item => item != null).Count + kalıcıThreadlerinListesi.Count).ToString() + " thread"); //Oluşturduğumuz thread sayısı
                LabelGuncelle(label7, string.Format("{0} ms", milisaniye.ToString())); //Geçen toplam süre
                LabelGuncelle(label10, altSunucuThreadlerinListesi.FindAll(item => item != null).Count.ToString() + " thread"); //Alt sunucu threadi sayısı

                for (int i = 0; i < panelleriTutanListe.Count; i++)
                {
                    if (panelleriTutanListe[i] != null)
                        foreach (BunifuCircleProgressbar tb in panelleriTutanListe[i].Controls.OfType<BunifuCircleProgressbar>())
                        {
                            int deger = (int)(sunuculariTutanListe[i].DolulukOrani());
                            if (deger <= 100)
                                tb.Value = deger;
                        }
                }

                Thread.Sleep(threadSleepDegeri);
            }

        }


        private void AltSunucuOlusturucuThreadFonksiyonu()
        {
            while (true)
            {
                Console.WriteLine(string.Format("{0,-27}{1,12}", Thread.CurrentThread.Name, DateTime.Now.ToString("HH:mm:ss.fff")));

                List<int> bolunecekSunucularinIndeksleri = new List<int>();
                List<int> silinecekSunucularinIndeksleri = new List<int>();

                for (int i = 0; i < sunuculariTutanListe.Count; i++)
                {
                    if (sunuculariTutanListe[i] != null)
                    {
                        if (sunuculariTutanListe[i].sunucuNo != 0 && sunuculariTutanListe[i].DolulukOrani() >= 70)
                        {
                            bolunecekSunucularinIndeksleri.Add(sunuculariTutanListe[i].sunucuNo);
                        }

                        if (sunuculariTutanListe[i].sunucuNo != 0 && sunuculariTutanListe.Count > 3 && sunuculariTutanListe[i].DolulukOrani() <= 0)
                        {
                            silinecekSunucularinIndeksleri.Add(sunuculariTutanListe[i].sunucuNo);
                        }
                    }

                    foreach (int indeks in bolunecekSunucularinIndeksleri)
                    {
                        panelleriTutanListe.Add(AltSunucuPanelOlustur());
                        int yeniSunucuyaDevredilenIstek = (int)(sunuculariTutanListe[indeks].bekleyenIstek / 2.0f);

                        sunuculariTutanListe.Add(new Sunucu(
                            sunucuNo: altSunucuSayisi,
                            kapasite: 5000,
                            bekleyenIstek: yeniSunucuyaDevredilenIstek,
                            gelenToplamIstek: yeniSunucuyaDevredilenIstek
                        ));

                        sunuculariTutanListe[indeks].bekleyenIstek -= yeniSunucuyaDevredilenIstek;
                        sunuculariTutanListe[indeks].cevaplananIstek += yeniSunucuyaDevredilenIstek;
                    }

                    bolunecekSunucularinIndeksleri = new List<int>();

                    foreach (int indeks in silinecekSunucularinIndeksleri)
                    {
                        if (sunuculariTutanListe[indeks] != null)
                        {
                            altSunucuThreadlerinListesi[indeks].Abort();
                            altSunucuThreadlerinListesi[indeks] = null;
                            if (Handle != IntPtr.Zero)
                                flowLayoutPanelSunucular.Controls["sunucuPanel" + indeks.ToString()].Visible = false;
                            //this.BeginInvoke(new MethodInvoker(flowLayoutPanelSunucular.Controls["sunucuPanel" + indeks.ToString()].Dispose));

                            panelleriTutanListe[indeks] = null;
                            sunuculariTutanListe[indeks] = null;
                        }
                    }

                    silinecekSunucularinIndeksleri = new List<int>();
                }

                Thread.Sleep(threadSleepDegeri);
            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////GUİ ELEMANI İŞLEMLERİ///////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private Panel AnaSunucuPanelOlustur()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

            Panel sunucuPaneli = new Panel
            {
                Margin = new System.Windows.Forms.Padding(0, 10, 15, 5),
                Name = "sunucuPanel0",
                Size = new System.Drawing.Size(100, 115)
            };

            Label sunucuLabel = new Label
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(0, 0),
                Name = "sunucuLabel0",
                Size = new System.Drawing.Size(100, 15),
                Text = "Ana Sunucu",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            sunucuLabel.Click += new System.EventHandler(this.labelSunucuKisa_Click);
            sunucuPaneli.Controls.Add(sunucuLabel);

            BunifuCircleProgressbar sunucuYuzde = new BunifuCircleProgressbar
            {
                animated = false,
                animationIterval = 5,
                animationSpeed = 300,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60))))),
                BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sunucuYuzde.BackgroundImage"))),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.SeaGreen,
                LabelVisible = true,
                LineProgressThickness = 6,
                LineThickness = 4,
                Location = new System.Drawing.Point(0, 20),
                Margin = new System.Windows.Forms.Padding(11, 9, 15, 9),
                MaxValue = 100,
                Name = "sunucuYuzde",
                ProgressBackColor = System.Drawing.Color.Gainsboro,
                ProgressColor = System.Drawing.Color.Red,
                Size = new System.Drawing.Size(100, 100),
                TabIndex = 0,
                Value = 0
            };
            sunucuPaneli.Controls.Add(sunucuYuzde);

            flowLayoutPanelSunucular.BeginInvoke((Action)(() =>
            {
                flowLayoutPanelSunucular.Controls.Add(sunucuPaneli);
            }));

            return sunucuPaneli;
        }

        private Panel AltSunucuPanelOlustur()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

            altSunucuSayisi++;

            Panel altSunucuPaneli = new Panel
            {
                Margin = new System.Windows.Forms.Padding(0, 10, 15, 5),
                Name = "sunucuPanel" + altSunucuSayisi.ToString(),
                Size = new System.Drawing.Size(100, 115)
            };

            Label altSunucuLabel = new Label
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(0, 0),
                Name = "sunucuLabel" + altSunucuSayisi.ToString(),
                Size = new System.Drawing.Size(100, 15),
                Text = "Alt Sunucu " + altSunucuSayisi.ToString(),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            altSunucuLabel.Click += new System.EventHandler(this.labelSunucuKisa_Click);
            altSunucuPaneli.Controls.Add(altSunucuLabel);

            BunifuCircleProgressbar altSunucuYuzde = new BunifuCircleProgressbar
            {
                animated = false,
                animationIterval = 5,
                animationSpeed = 300,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60))))),
                BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sunucuYuzde.BackgroundImage"))),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.SeaGreen,
                LabelVisible = true,
                LineProgressThickness = 6,
                LineThickness = 4,
                Location = new System.Drawing.Point(0, 20),
                Margin = new System.Windows.Forms.Padding(11, 9, 15, 9),
                MaxValue = 100,
                Name = "sunucuYuzde" + altSunucuSayisi.ToString(),
                ProgressBackColor = System.Drawing.Color.Gainsboro,
                ProgressColor = System.Drawing.Color.Red,
                Size = new System.Drawing.Size(100, 100),
                TabIndex = 0,
                Value = 0
            };
            altSunucuPaneli.Controls.Add(altSunucuYuzde);

            this.BeginInvoke((Action)(() =>
            {
                flowLayoutPanelSunucular.Controls.Add(altSunucuPaneli);
            }));


            return altSunucuPaneli;
        }

        private void labelSunucuKisa_Click(object sender, EventArgs e)
        {
            Form bilgiEkranı = (Form)Application.OpenForms["Form2"];
            if (bilgiEkranı != null)
            {
                //second.BeginInvoke(new MethodInvoker(second.Close));
                bilgiEkranı.Controls.Clear();
                bilgiEkranı.Close();
            }

            String labelAdi = ((Label)sender).Name.Substring(11);

            int sunucuNo;
            Int32.TryParse(labelAdi, out sunucuNo);

            Form2 form2 = new Form2(panelleriTutanListe[sunucuNo], sunucuNo, sunuculariTutanListe);
            form2.Show();


        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

            Form bilgiEkranı = (Form)Application.OpenForms["Form2"];
            if (bilgiEkranı != null)
                bilgiEkranı.Location = new Point(Location.X + 641, Location.Y + 57);
        }

        private void labelProgramAdi_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void kapatDugmesi_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }

        private void labelProgramAdi_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void labelProgramAdi_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        //https://stackoverflow.com/questions/7827961/how-can-i-handle-crossthreadmessagingexception
        private void LabelGuncelle(Label label, String yazi)
        {
            if (label.InvokeRequired)
            { label.Invoke(new Action<Label, String>(LabelGuncelle), new object[] { label, yazi }); }
            else
            { label.Text = yazi; }
        }

    }


    ///////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////SUNUCU SINIFI/////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////


    public class Sunucu
    {
        public int sunucuNo;
        public double kapasite;
        public double gelenIstek;
        public double cevaplananIstek;
        public double bekleyenIstek;

        public Sunucu(int sunucuNo, int kapasite, double gelenToplamIstek = 0, double cevaplananIstek = 0, double bekleyenIstek = 0)
        {
            this.sunucuNo = sunucuNo;
            this.kapasite = kapasite;
            this.gelenIstek = gelenToplamIstek;
            this.cevaplananIstek = cevaplananIstek;
            this.bekleyenIstek = bekleyenIstek;
        }

        public int DolulukOrani()
        {
            int doluluk = (int)((this.bekleyenIstek) / this.kapasite * 100.0f);
            return doluluk;
        }
    }
}
