using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HayvanCikisManager : IHayvanCikisService
    {
        IHayvanCikisDAL _hayvanCikisDAL;

        public HayvanCikisManager(IHayvanCikisDAL hayvanCikisDAL)
        {
            _hayvanCikisDAL = hayvanCikisDAL;
        }

        public void Add(HayvanCikis hayvanCikis)
        {
            _hayvanCikisDAL.Add(hayvanCikis);
        }

        public void Delete(HayvanCikis hayvanCikis)
        {
            _hayvanCikisDAL.Delete(hayvanCikis);
        }

        public List<HayvanCikis> GetAll()
        {
            return _hayvanCikisDAL.GetList().ToList();
        }

        public HayvanCikis GetById(int id)
        {
            return _hayvanCikisDAL.Get(c => c.id == id);
        }

        public HayvanCikis getLastAddId()
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from k in context.HayvanCikis
                             orderby k.id descending
                             select k;
                return result.First();
            }
        }

        public void Update(HayvanCikis hayvanCikis)
        {
            _hayvanCikisDAL.Update(hayvanCikis);
        }
    }
}
