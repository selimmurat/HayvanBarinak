using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HayvanTuruCinsiManager : IHayvanTuruCinsiService
    {
        IHayvanTuruCinsiDAL _hayvanTuruCinsiDAL;

        public HayvanTuruCinsiManager(IHayvanTuruCinsiDAL hayvanTuruCinsiDAL)
        {
            _hayvanTuruCinsiDAL = hayvanTuruCinsiDAL;
        }

        public void Add(HayvanTuruCinsi hayvanTuruCinsi)
        {
            _hayvanTuruCinsiDAL.Add(hayvanTuruCinsi);
        }

        public void Delete(HayvanTuruCinsi hayvanTuruCinsi)
        {
            _hayvanTuruCinsiDAL.Delete(hayvanTuruCinsi);
        }

        public HayvanTuruCinsi GetById(int id)
        {
            return _hayvanTuruCinsiDAL.Get(c => c.id == id);
        }

        public List<HayvanTuruCinsi> GetAll()
        {
            return _hayvanTuruCinsiDAL.GetList().ToList();
        }

        public void Update(HayvanTuruCinsi hayvanTuruCinsi)
        {
            _hayvanTuruCinsiDAL.Update(hayvanTuruCinsi);
        }
    }
}
