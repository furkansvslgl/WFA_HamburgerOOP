using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HamburgerOtomasyonOOP
{
    public class Menu
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()//çağrıldığında ad fiyat versın diye
        {
            return Ad + " " + Fiyat;
        }
        

    }
}
