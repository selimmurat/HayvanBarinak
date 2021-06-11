using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class HelperContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HayvanBarinak;Trusted_Connection=true");
        }

        public DbSet<HayvanBilgileri> HayvanBilgileri { get; set; }
        public DbSet<HayvanAsiBilgisi> HayvanAsiBilgisi { get; set; }
        public DbSet<HayvanCikis> HayvanCikis { get; set; }
        public DbSet<HayvanKayit> HayvanKayit { get; set; }
        public DbSet<HayvanRenk> HayvanRenk { get; set; }
        public DbSet<HayvanTuruCinsi> HayvanTuruCinsi { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Sahiplendirme> Sahiplendirme { get; set; }
        public DbSet<Unvan> Unvan { get; set; }


    }
}
