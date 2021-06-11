using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HayvanTuruCinsi : IEntity
    {
        public int id { get; set; }
        public string turu { get; set; }
        public string cinsi { get; set; }
    }
}
