using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entities
{
    public class SatinAlma
    {
        public int Id { get; set; }
        public int TedarikciId { get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
        public int PersonelId { get; set; }

    }
}
