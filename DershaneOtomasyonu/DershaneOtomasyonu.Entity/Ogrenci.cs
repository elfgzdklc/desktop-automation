using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DershaneOtomasyonu.Entity
{
    public class Ogrenci : EntityBase
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal TCKN { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string VeliAdi { get; set; }
        public string VeliTelefonu { get; set; }
        public int SinifID { get; set; }

        public override string ToString()
        {
            return " >" + Adi + "  " + Soyadi + "  [TC:" + TCKN + "]";
        }
    }
}
