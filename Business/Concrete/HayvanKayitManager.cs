using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class HayvanKayitManager : IHayvanKayitService
    {
        IHayvanKayitDAL _hayvanKayitDAL;

        public HayvanKayitManager(IHayvanKayitDAL hayvanKayitDAL)
        {
            _hayvanKayitDAL = hayvanKayitDAL;
        }

        public void Add(HayvanKayit hayvanKayit)
        {
            _hayvanKayitDAL.Add(hayvanKayit);
        }

        public void Delete(HayvanKayit hayvanKayit)
        {
            _hayvanKayitDAL.Delete(hayvanKayit);
        }

        public HayvanKayit GetById(int id)
        {
            return _hayvanKayitDAL.Get(k => k.id == id);
        }

        public HayvanKayit GetLastAddId()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from k in context.HayvanKayit
                             orderby k.id descending
                             select k;
                return result.First();
            }
        }

        public List<HayvanKayit> GetAll()
        {
            return _hayvanKayitDAL.GetList().ToList();
        }

        public void Update(HayvanKayit hayvanKayit)
        {
            _hayvanKayitDAL.Update(hayvanKayit);
        }

        public List<HayvanKayit> getLastWeekSave()
        {
            // son 1 hafta içerisinde kaydedilen hayvanları listeledik.
            return _hayvanKayitDAL.GetList().Where(k => k.kayitTarihi >= DateTime.Now.AddDays(-7)).ToList();
        }
    }
}

