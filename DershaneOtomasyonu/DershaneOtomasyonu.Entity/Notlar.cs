using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DershaneOtomasyonu.Entity
{
    public class Notlar : EntityBase
    {
        public int OgrenciID { get; set; }
        public DateTime SinavTarihi { get; set; }
        public decimal Notu { get; set; }
        public string SinavAdi { get; set; }

    }
}
