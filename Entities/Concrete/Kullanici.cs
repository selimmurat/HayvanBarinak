using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int id { get; set; }
        public int unvanId { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
