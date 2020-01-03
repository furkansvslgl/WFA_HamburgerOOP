using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WFA_HamburgerOtomasyonOOP
{
    public partial class SiparisVer : Form
    {
        public SiparisVer()
        {
            InitializeComponent();
        }
       public static List<Menu> menuler = new List<Menu>()//object initializer
            {
                new Menu{Ad="Whooper",Fiyat=17},
                new Menu{Ad="Tavuk Burger",Fiyat=15},
                new Menu{Ad="Köfte Burger",Fiyat=18},
                new Menu{Ad="Pastırmalı Burger",Fiyat=20}

            };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
            {
                new Ekstra{EkstraAdi="Hardal",Fiyat=0.50m},
                new Ekstra{EkstraAdi="Ranch",Fiyat=0.50m},
                new Ekstra{EkstraAdi="BBQ",Fiyat=0.50m},
                new Ekstra{EkstraAdi="Buffalo",Fiyat=0.50m},
                new Ekstra{EkstraAdi="Ketçap",Fiyat=0.50m},
                new Ekstra{EkstraAdi="Mayonez",Fiyat=0.50m}
            };

        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public decimal toplamciro = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Örnek Kod
            //List<Menu> menuler = new List<Menu>();
            //Menu menu1 = new Menu();
            //menu1.Ad = "Whooper";
            //menu1.Fiyat = 17;

            //menuler.Add(menu1);

            //Menu menu2 = new Menu();
            //menu2.Ad = "TavukBurger";
            //menu2.Fiyat = 15;

            //menuler.Add(menu2);

            //object Initializer 
            #endregion
           

            //cmbMenu.DataSource = menuler;
            foreach (Menu m in menuler)
            {
                cmbMenu.Items.Add(m);
            }
            //aşağıdaki code uygun yapıdır.üst tarafın çalışması için menu içinde çağırırken ne gelmesi gerektiğini söyleyen override var.
            //foreach (menux m in menuler)
            //{
            //    cmbMenu.Items.Add(m.Ad + " " + m.Fiyat);
            //}

            foreach (Ekstra extra in ekstralar)
            {
                //CheckBox checkBox = new CheckBox();
                //checkBox.Text = extra.EkstraAdi;
                //flowLayoutPanel1.Controls.Add(checkBox);
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = extra.EkstraAdi, Tag = extra });
            }
        }

        private void BtnSiparisVer_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenu.SelectedItem;

            if (rbOrta.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Orta;
            }
            else if (rbBuyuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Büyük;
            }
            else
            {
                yeniSiparis.Boyutu = Boyut.King;
            }

            yeniSiparis.Ekstralar = new List<Ekstra>();

            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.Ekstralar.Add((Ekstra)item.Tag);
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(nudAdet.Value);
            yeniSiparis.Hesapla();
            mevcutSiparisler.Add(yeniSiparis);

            listBox1.Items.Add(yeniSiparis);
    

            Fonksiyon.Temizle(this.Controls);


            TutarHesapla();

        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Ücreti {TutarHesapla()}\nsatın alma işlemini tamamlamak istiyor musunuz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                MessageBox.Show("Siparişiniz Alındı");
            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }

        }

        public  decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Siparis siparis = (Siparis)listBox1.Items[i];
                toplamTutar += siparis.ToplamTutar;

            }
            toplamciro = toplamTutar;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            
            return toplamTutar;
        }

    }
}
