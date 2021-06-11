using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanBilgileriService
    {
        List<HayvanBilgileri> GetAll();
        HayvanBilgileri GetById(int id);
        void Add(HayvanBilgileri hayvanBilgileri);
        void Delete(HayvanBilgileri hayvanBilgileri);
        void Update(HayvanBilgileri hayvanBilgileri);
        List<HayvanBilgileriTurCinsiDTO> getHayvanTurCinsSayilarıAlma();
        
    }
}
