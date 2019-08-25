using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DershaneOtomasyonu.Entity
{
    public class Kullanicilar : EntityBase
    {
        public string K_Adi { get; set; }
        public string Sifre { get; set; }
        public string Gorev { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal TCKN { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
    }
}
