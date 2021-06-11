using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Personel : IEntity
    {
        public int id { get; set; }
        public string adiSoyadi { get; set; }
        public DateTime kayitTarihi { get; set; }
        public string tcKimlikNo { get; set; }
        public int kullaniciId { get; set; }
        public int unvanId { get; set; }
    }
}
