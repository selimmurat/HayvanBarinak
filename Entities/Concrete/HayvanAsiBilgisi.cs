using Core.Entities;
using System;

namespace Entities
{
    public class HayvanAsiBilgisi : IEntity
    {
        public int id { get; set; }
        public int hayvanId { get; set; }
        public string asiBilgisi { get; set; }
        public DateTime asiTarihi { get; set; }
        public int asiYapanPersonelId { get; set; }
    }
}
