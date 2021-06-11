using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanAsiBilgisiService
    {
        List<HayvanAsiBilgisi> GetAll();
        List<HayvanAsiTakipDTO> GetById(int id);
        void Add(HayvanAsiBilgisi hayvanBilgisi);
        void Delete(HayvanAsiBilgisi hayvanBilgisi);
        void Update(HayvanAsiBilgisi hayvanBilgisi);
    }
}
