using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonelEkleDuzenleDTO
    {
        public int id { get; set; }
        public string adiSoyadi { get; set; }
        public DateTime kayitTarihi { get; set; }
        public string tcKimlikNo { get; set; }
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public int unvanId { get; set; }
        public string unvan { get; set; }
    }
}
