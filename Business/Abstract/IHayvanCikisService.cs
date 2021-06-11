using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanCikisService
    {
        List<HayvanCikis> GetAll();
        HayvanCikis GetById(int id);
        void Add(HayvanCikis hayvanCikis);
        void Delete(HayvanCikis hayvanCikis);
        void Update(HayvanCikis hayvanCikis);
        HayvanCikis getLastAddId();
    }
}
