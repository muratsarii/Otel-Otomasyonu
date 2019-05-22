using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entities
{
    public class SatisDetay
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public double Miktar { get; set; }
    }
}
