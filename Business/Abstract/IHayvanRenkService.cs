using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanRenkService
    {
        List<HayvanRenk> GetAll();
        HayvanRenk GetById(int id);
        void Add(HayvanRenk hayvanRenk);
        void Delete(HayvanRenk hayvanRenk);
        void Update(HayvanRenk hayvanRenk);
    }
}
