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
    public class PersonelManager : IPersonelService
    {
        IPersonelDAL _personelDAL;

        public PersonelManager(IPersonelDAL personelDAL)
        {
            _personelDAL = personelDAL;
        }

        public void Add(Personel personel)
        {
            _personelDAL.Add(personel);
        }

        public void Delete(Personel personel)
        {
            _personelDAL.Delete(personel);
        }

        public Personel GetById(int id)
        {
            return _personelDAL.Get(p => p.id == id);
        }

        public List<Personel> Getll()
        {
            return _personelDAL.GetList().ToList();
        }

        public List<PersonelEkleDuzenleDTO> personelEkleDuzenleGetir()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from p in context.Personel
                             join k in context.Kullanici on p.kullaniciId equals k.id
                             join u in context.Unvan on p.unvanId equals u.id
                             select new PersonelEkleDuzenleDTO
                             {
                                 id = p.id,
                                 adiSoyadi = p.adiSoyadi,
                                 kayitTarihi = p.kayitTarihi,
                                 tcKimlikNo = p.tcKimlikNo,
                                 kullaniciId = k.id,
                                 kullaniciAdi = k.kullaniciAdi,
                                 sifre = k.sifre,
                                 unvanId = u.id,
                                 unvan = u.unvanAdi
                             };
                return result.ToList();
            }
        }

        public void Update(Personel personel)
        {
            _personelDAL.Update(personel);
        }

    }
}
