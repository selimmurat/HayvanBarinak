using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KullaniciUnvanDTO
    {
        public int id { get; set; }
        public string adiSoyadi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string unvan { get; set; }
    }
}
