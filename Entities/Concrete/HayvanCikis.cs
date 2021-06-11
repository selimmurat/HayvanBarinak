using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class HayvanCikis:IEntity
    {
        public int id { get; set; }
        public DateTime cikisTarihi { get; set; }
        public int cikisPersonelId { get; set; }
        public string cikisNedeni { get; set; }
        public int sahiplendirmeId { get; set; }
    }
}
