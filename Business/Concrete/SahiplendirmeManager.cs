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
    public class SahiplendirmeManager : ISahiplendirmeService
    {
        ISahiplendirmeDAL _sahiplendirmeDAL;

        public SahiplendirmeManager(ISahiplendirmeDAL sahiplendirmeDAL)
        {
            _sahiplendirmeDAL = sahiplendirmeDAL;
        }

        public void Add(Sahiplendirme sahiplendirme)
        {
            _sahiplendirmeDAL.Add(sahiplendirme);
        }

        public void Delete(Sahiplendirme sahiplendirme)
        {
            _sahiplendirmeDAL.Delete(sahiplendirme);
        }

        public Sahiplendirme GetById(int id)
        {
            return _sahiplendirmeDAL.Get(s => s.id == id);
        }

        public List<Sahiplendirme> Getll()
        {
            return _sahiplendirmeDAL.GetList().ToList();
        }

        public void Update(Sahiplendirme sahiplendirme)
        {
            _sahiplendirmeDAL.Update(sahiplendirme);
        }

        public List<HayvanSahipledirmeBilgileriDTO> hayvanSahipledirmeBilgileriDTOs(int id)
        {
            using (HelperContext context = new HelperContext())
            {
                var result = (from h in context.HayvanBilgileri
                              join hr in context.HayvanRenk on h.renkId equals hr.id
                              join ht in context.HayvanTuruCinsi on h.turId equals ht.id
                              join hc in context.HayvanCikis on h.cikisId equals hc.id
                              join p in context.Personel on hc.cikisPersonelId equals p.id
                              join s in context.Sahiplendirme on hc.sahiplendirmeId equals s.id
                              where h.id == id
                              select new HayvanSahipledirmeBilgileriDTO
                              {
                                  hayvanId = h.id,
                                  hayvanKimlikNo = h.hayvanKimlikNumarasi,
                                  dogumTarihi = h.dogumTarihi,
                                  ekBilgi = h.ekBilgi,
                                  cinsiyet = h.cinsiyet,
                                  renk = hr.renk,
                                  turu = ht.turu,
                                  cinsi = ht.cinsi,
                                  hayvanCikisId = hc.id,
                                  hayvanCikisTarihi = hc.cikisTarihi,
                                  cikisYapanPersonelId = p.id,
                                  cikisNedeni = hc.cikisNedeni,
                                  sahiplendirmeId = s.id,
                                  sahipAdiSoyadi = s.adi + " " + s.soyadi,
                                  telNo = s.tel,
                                  adres = s.adres,
                                  aciklama = s.aciklama
                              }).ToList();
                return result;
            }
        }

        public Sahiplendirme getLastAddId()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from k in context.Sahiplendirme
                             orderby k.id descending
                             select k;
                return result.First();
            }
        }
    }
}
