using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class HayvanAsiTakipDTO
    {
        public int id { get; set; }
        public int hayvanKimlikNumarasi { get; set; }
        public string ekBilgi { get; set; }
        public string cinsiyet { get; set; }
        public string renk { get; set; }
        public string turu { get; set; }
        public string cinsi { get; set; }
        public string asiBilgisi { get; set; }
        public DateTime asiTarihi { get; set; }
        public string asiYapanPersonelAdiSoyadi { get; set; }

    }
}
