using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HayvanKayit:IEntity
    {
        public int id { get; set; }
        public int kaydedenPersonelId { get; set; }
        public DateTime kayitTarihi { get; set; }
        public string gelisNedeni { get; set; }
    }
}
