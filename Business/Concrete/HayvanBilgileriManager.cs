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
    public class HayvanBilgileriManager : IHayvanBilgileriService
    {
        IHayvanBilgileriDAL _hayvanBilgileriDAL;

        public HayvanBilgileriManager(IHayvanBilgileriDAL hayvanBilgileriDAL)
        {
            _hayvanBilgileriDAL = hayvanBilgileriDAL;
        }

        public void Add(HayvanBilgileri hayvanBilgileri)
        {
            _hayvanBilgileriDAL.Add(hayvanBilgileri);
        }

        public void Delete(HayvanBilgileri hayvanBilgileri)
        {
            _hayvanBilgileriDAL.Delete(hayvanBilgileri);
        }

        public HayvanBilgileri GetById(int id)
        {
            return _hayvanBilgileriDAL.Get(h => h.id == id);
        }

        public List<HayvanBilgileri> GetAll()
        {
            return _hayvanBilgileriDAL.GetList().ToList();
        }

        public void Update(HayvanBilgileri hayvanBilgileri)
        {
            _hayvanBilgileriDAL.Update(hayvanBilgileri);
        }

        public List<HayvanBilgileriTurCinsiDTO> getHayvanTurCinsSayilarıAlma()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from s in context.HayvanBilgileri
                             join c in context.HayvanTuruCinsi on s.turId equals c.id
                             join r in context.HayvanRenk on s.renkId equals r.id
                             select new HayvanBilgileriTurCinsiDTO
                             {
                                 id = s.id,
                                 hayvanKimlikNumarasi = s.hayvanKimlikNumarasi,
                                 dogumTarihi = s.dogumTarihi,
                                 renk = r.renk,
                                 ekBilgi = s.ekBilgi,
                                 cinsiyet = s.cinsiyet,
                                 cinsi = c.cinsi,
                                 turu = c.turu,
                                 foto = s.foto

                             };
                return result.ToList();
            }
        }
    }
}