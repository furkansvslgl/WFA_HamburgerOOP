using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HamburgerOtomasyonOOP
{
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public Boyut Boyutu { get; set; }
        public List<Ekstra> Ekstralar { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.Fiyat;
            
            switch (Boyutu)
            {
                case Boyut.Orta:
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case Boyut.King:
                    ToplamTutar += ToplamTutar * 0.20m;
                    break;
            }

            foreach (Ekstra ekstra in Ekstralar)
            {

                ToplamTutar += ekstra.Fiyat;//direk toplamtutar+=1 ; de diyebilirdik ama ekstra fiyatları deişebilir ondan bçöyle yapıldı.  
            }

            ToplamTutar = ToplamTutar * Adet;

        }

        public override string ToString()
        {
            if (Ekstralar.Count < 1)
            {
                //return string.Format("{0} Menu, x{1} Adet, {2} Boys, Toplam:{3}", SeciliMenusu.Ad, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));

                return $"{SeciliMenusu.Ad} Menu {Adet} Adet {Boyutu.ToString()} Boy, Toplam:{ToplamTutar}";
            }
            else
            {
                string extraMalzemeler = null;
                foreach (Ekstra item in Ekstralar)
                {
                    extraMalzemeler += item.EkstraAdi + " ";
                }
                return $"{SeciliMenusu.Ad} Menu {Adet} Adet {Boyutu.ToString()} Boy, Ekstralar: {extraMalzemeler} - Toplam:{ToplamTutar}";
            }
            
        }
    }
}
