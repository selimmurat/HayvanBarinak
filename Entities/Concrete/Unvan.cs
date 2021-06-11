using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Unvan : IEntity
    {
        public int id { get; set; }
        public string unvanAdi { get; set; }
    }
}
