using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_GectiKaldı
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
       

        public Ogrenci(string ad, string soyad, int vize, int final)
        {
            Ad = ad;
            Soyad = soyad;
            Vize = vize;
            Final = final;
        }
        public string NotHesapla()
        {
            Final = (Final * 70) / 100;
            Vize = (Vize * 30) / 100;
            int not = Vize + Final;
            if (not>=70)
            {
                return "Geçti";
            }
            else
            {
                return "Kaldı";
            }
        }

        public override string ToString()
        {
            return this.Ad + " " + this.Soyad + " " + NotHesapla();
        }
    }
}
