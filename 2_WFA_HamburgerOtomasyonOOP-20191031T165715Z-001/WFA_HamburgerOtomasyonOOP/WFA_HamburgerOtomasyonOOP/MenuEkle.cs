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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtMenuAd.Text;
            menu.Fiyat = nudFiyat.Value;
            SiparisVer.menuler.Add(menu);
            MessageBox.Show("Menü eklendi");
            

        }
    }
}
