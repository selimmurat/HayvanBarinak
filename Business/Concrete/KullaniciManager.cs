using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDAL _kullaniciDAL;

        public KullaniciManager(IKullaniciDAL kullaniciDAL)
        {
            _kullaniciDAL = kullaniciDAL;
        }

        public void Add(Kullanici kullanici)
        {
            _kullaniciDAL.Add(kullanici);
        }

        public void Delete(Kullanici kullanici)
        {
            _kullaniciDAL.Delete(kullanici);
        }

        public Kullanici GetById(int id)
        {
            return _kullaniciDAL.Get(k => k.id == id);
        }

        public List<Kullanici> Getll()
        {
            return _kullaniciDAL.GetList().ToList();
        }

        public void Update(Kullanici kullanici)
        {
            _kullaniciDAL.Update(kullanici);
        }

        public KullaniciUnvanDTO login(string kullaniciAdi, string sifre)
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from k in context.Kullanici
                             join u in context.Unvan on k.unvanId equals u.id
                             join p in context.Personel on k.id equals p.kullaniciId
                             where k.kullaniciAdi == kullaniciAdi && k.sifre == sifre
                             select new KullaniciUnvanDTO
                             {
                                 id = k.id,
                                 kullaniciAdi = k.kullaniciAdi,
                                 adiSoyadi = p.adiSoyadi,
                                 sifre = k.sifre,                                 
                                 unvan = u.unvanAdi
                             };
                return result.SingleOrDefault();
            }
        }
        public Kullanici GetLastAddId()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from k in context.Kullanici
                             orderby k.id descending
                             select k;
                return result.First();
            }
        }
    }
}
