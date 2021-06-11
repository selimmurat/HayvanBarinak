using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HayvanBilgileri : IEntity
    {
        public int id { get; set; }
        public int hayvanKimlikNumarasi { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string ekBilgi { get; set; }
        public byte[] foto { get; set; }
        public string cinsiyet { get; set; }
        public int renkId { get; set; }
        public int turId { get; set; }
        public int cikisId { get; set; }
        public int kayitId { get; set; }
    }
}
