using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HamburgerOtomasyonOOP
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        decimal topdeger = 0;
        int adets = 0;
        private void Siparisler_Load(object sender, EventArgs e)
        {
            foreach(Siparis sp in SiparisVer.mevcutSiparisler)
            {
                topdeger += sp.ToplamTutar;
                
            }
            label1.Text = topdeger.ToString();
            int sayac = 0;
            foreach(Siparis sp in SiparisVer.mevcutSiparisler)
            {
                sayac++;
                adets += sp.Adet;
            }
            label2.Text = "sipariş sayısı : " + sayac.ToString() ;
            label4.Text = adets.ToString();
            decimal eksfiyat = 0;
            foreach (Siparis sp in SiparisVer.mevcutSiparisler)
            {
                foreach(Ekstra eks in sp.Ekstralar)
                {
                    eksfiyat += eks.Fiyat;
                }
            }
            label3.Text= eksfiyat.ToString();
        }
    }
}
