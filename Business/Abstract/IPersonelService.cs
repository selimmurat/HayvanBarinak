using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> Getll();
        Personel GetById(int id);
        void Add(Personel personel);
        void Delete(Personel personel);
        void Update(Personel personel);
        List<PersonelEkleDuzenleDTO> personelEkleDuzenleGetir();
    }
}
