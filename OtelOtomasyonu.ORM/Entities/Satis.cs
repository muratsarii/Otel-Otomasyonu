using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entities
{
    public class Satis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
        public int OdaId { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
