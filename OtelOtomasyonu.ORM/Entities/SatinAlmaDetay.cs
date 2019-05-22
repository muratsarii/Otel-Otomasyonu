using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entities
{
    public class SatinAlmaDetay
    {
        public int SatinAlmaId { get; set; }
        public int Urunıd { get; set; }
        public double Miktar { get; set; }
        public decimal AlisFiyati { get; set; }
    }
}
