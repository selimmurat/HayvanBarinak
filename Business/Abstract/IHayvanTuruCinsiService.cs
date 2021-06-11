using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanTuruCinsiService
    {
        List<HayvanTuruCinsi> GetAll();
        HayvanTuruCinsi GetById(int id);
        void Add(HayvanTuruCinsi hayvanTuruCinsi);
        void Delete(HayvanTuruCinsi hayvanTuruCinsi);
        void Update(HayvanTuruCinsi hayvanTuruCinsi);
    }
}
