using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DershaneOtomasyonu.Entity
{
    public class Sinif : EntityBase
    {
        public string SubeAdi { get; set; }
        public string BolumAdi { get; set; }
        public string SinifDurumu { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", SinifDurumu, BolumAdi, SubeAdi, ID);
        }
    }
}
