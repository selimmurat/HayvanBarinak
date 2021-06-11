using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class HayvanSahipledirmeBilgileriDTO
    {
        public int hayvanId { get; set; }
        public int hayvanKimlikNo { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string ekBilgi { get; set; }
        public string cinsiyet { get; set; }
        public string renk { get; set; }
        public string turu { get; set; }
        public string cinsi { get; set; }
        public int hayvanCikisId { get; set; }
        public DateTime hayvanCikisTarihi { get; set; }
        public int cikisYapanPersonelId { get; set; }
        public string cikisNedeni { get; set; }
        public int sahiplendirmeId { get; set; }
        public string sahipAdiSoyadi { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; }
        public string aciklama { get; set; }
    }
}
