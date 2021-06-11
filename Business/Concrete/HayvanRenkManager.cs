using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HayvanRenkManager : IHayvanRenkService
    {
        IHayvanRenkDAL _hayvanRenkDAL;

        public HayvanRenkManager(IHayvanRenkDAL hayvanRenkDAL)
        {
            _hayvanRenkDAL = hayvanRenkDAL;
        }

        public void Add(HayvanRenk hayvanRenk)
        {
            _hayvanRenkDAL.Add(hayvanRenk);
        }

        public void Delete(HayvanRenk hayvanRenk)
        {
            _hayvanRenkDAL.Delete(hayvanRenk);
        }

        public HayvanRenk GetById(int id)
        {
            return _hayvanRenkDAL.Get(r => r.id == id);
        }

        public List<HayvanRenk> GetAll()
        {
            return _hayvanRenkDAL.GetList().ToList();
        }

        public void Update(HayvanRenk hayvanRenk)
        {
            _hayvanRenkDAL.Update(hayvanRenk);
        }
    }
}
