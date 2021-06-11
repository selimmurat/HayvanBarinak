using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class HayvanBilgileriTurCinsiDTO
    {
        public int id { get; set; }
        public int hayvanKimlikNumarasi { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string ekBilgi { get; set; }
        public string renk { get; set; }
        public string cinsiyet { get; set; }
        public string cinsi { get; set; }
        public string turu { get; set; }
        public byte[] foto { get; set; }
    }
}
