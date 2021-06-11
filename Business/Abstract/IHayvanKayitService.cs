using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanKayitService
    {
        List<HayvanKayit> GetAll();
        HayvanKayit GetById(int id);
        void Add(HayvanKayit hayvanKayit);
        void Delete(HayvanKayit hayvanKayit);
        void Update(HayvanKayit hayvanKayit);
        HayvanKayit GetLastAddId();
        List<HayvanKayit> getLastWeekSave();
    }
}
