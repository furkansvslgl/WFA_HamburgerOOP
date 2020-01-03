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
    public partial class HamburgerOtomasyon : Form
    {
        public HamburgerOtomasyon()
        {
            InitializeComponent();
        }
        MenuEkle menuEkleForm = new MenuEkle();
        SiparisVer SiparisForm = new SiparisVer();
        Siparisler siparişlerform = new Siparisler();
        private void MenuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (menuEkleForm.IsDisposed)
            {
                menuEkleForm = new MenuEkle();
            }
            menuEkleForm.Show();
            menuEkleForm.MdiParent = this;
        }

        private void SiparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SiparisForm.IsDisposed)
            {
                SiparisForm = new SiparisVer();
            }
            SiparisForm.Show();
            SiparisForm.MdiParent = this;
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(siparişlerform.IsDisposed)
            {
                siparişlerform = new Siparisler();
            }
            siparişlerform.Show();
            siparişlerform.MdiParent = this;
        }
    }
}
