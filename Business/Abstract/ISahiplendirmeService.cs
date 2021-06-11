using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISahiplendirmeService
    {
        List<Sahiplendirme> Getll();
        Sahiplendirme GetById(int id);
        void Add(Sahiplendirme sahiplendirme);
        void Delete(Sahiplendirme sahiplendirme);
        void Update(Sahiplendirme sahiplendirme);
        List<HayvanSahipledirmeBilgileriDTO> hayvanSahipledirmeBilgileriDTOs(int id);
        Sahiplendirme getLastAddId();
    }
}
