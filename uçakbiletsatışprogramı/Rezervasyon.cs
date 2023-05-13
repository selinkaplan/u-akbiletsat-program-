using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uçakbiletsatışprogramı
{
    internal class Rezervasyon
    {


        public string AdSoyad { get; set; }
        public Ucak Ucak { get; set; }
        public Lokasyon KalkisYeri { get; set; }
        public Lokasyon VarisYeri { get; set; }
        public DateTime KalkisTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public bool OnaylandiMi { get; set; }
    }
}






    

