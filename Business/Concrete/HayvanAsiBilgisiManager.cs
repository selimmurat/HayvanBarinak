using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HayvanAsiBilgisiManager : IHayvanAsiBilgisiService
    {
        IHayvanAsiBilgisiDAL _hayvanAsiBilgisiDAL;

        public HayvanAsiBilgisiManager(IHayvanAsiBilgisiDAL hayvanAsiBilgisiDAL)
        {
            _hayvanAsiBilgisiDAL = hayvanAsiBilgisiDAL;
        }


        public void Add(HayvanAsiBilgisi hayvanAsiBilgisi)
        {
            _hayvanAsiBilgisiDAL.Add(hayvanAsiBilgisi);
        }

        public void Delete(HayvanAsiBilgisi hayvanAsiBilgisi)
        {
            _hayvanAsiBilgisiDAL.Delete(hayvanAsiBilgisi);
        }

        public List<HayvanAsiBilgisi> GetAll()
        {
            return _hayvanAsiBilgisiDAL.GetList().ToList();
        }

        public List<HayvanAsiTakipDTO> GetById(int id)
        {
            using (HelperContext context = new HelperContext())
            {
                var result = (from h in context.HayvanAsiBilgisi
                              join hb in context.HayvanBilgileri on h.hayvanId equals hb.id
                              join p in context.Personel on h.asiYapanPersonelId equals p.id
                              where h.hayvanId==id
                              select new HayvanAsiTakipDTO
                              {
                                  id = h.id,
                                  hayvanKimlikNumarasi = hb.hayvanKimlikNumarasi,
                                  asiBilgisi = h.asiBilgisi,
                                  asiTarihi = h.asiTarihi,
                                  asiYapanPersonelAdiSoyadi = p.adiSoyadi

                              }).ToList();
                return result.ToList();
            }

        }

        public void Update(HayvanAsiBilgisi hayvanAsiBilgisi)
        {
            _hayvanAsiBilgisiDAL.Update(hayvanAsiBilgisi);
        }
        public List<HayvanAsiTakipDTO> hayvanAsiTakipDTOs()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = (from h in context.HayvanBilgileri
                              join hk in context.HayvanAsiBilgisi on h.id equals hk.hayvanId into hyAsiBilgisi
                              from hknew in hyAsiBilgisi.DefaultIfEmpty()
                              join hr in context.HayvanRenk on h.renkId equals hr.id
                              join p in context.Personel on hknew.asiYapanPersonelId equals p.id into hyAsiPersonel
                              from asiPersonel in hyAsiPersonel.DefaultIfEmpty()
                              join t in context.HayvanTuruCinsi on h.turId equals t.id

                              select new HayvanAsiTakipDTO
                              {
                                  id = h.id,
                                  hayvanKimlikNumarasi = h.hayvanKimlikNumarasi,
                                  ekBilgi = h.ekBilgi,
                                  cinsiyet = h.cinsiyet,
                                  renk = hr.renk,
                                  turu = t.turu,
                                  cinsi = t.cinsi,
                                  asiBilgisi = hknew.asiBilgisi,
                                  asiTarihi = hknew.asiTarihi,
                                  asiYapanPersonelAdiSoyadi = asiPersonel.adiSoyadi,
                              }).ToList();
                return result;

            }
        }
    }
}
