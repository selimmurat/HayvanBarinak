using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sahiplendirme : IEntity
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string tel { get; set; }
        public string adres { get; set; }
        public string aciklama { get; set; }
    }
}
