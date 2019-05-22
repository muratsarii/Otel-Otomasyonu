using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entities
{
    public class Urunler
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public double Miktar { get; set; }
        public int KateforiId { get; set; }
        public int BirimTipId { get; set; }
        public bool Aktif { get; set; }
    }
}
