using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> Getll();
        Kullanici GetById(int id);
        void Add(Kullanici kullanici);
        void Delete(Kullanici kullanici);
        void Update(Kullanici kullanici);
        KullaniciUnvanDTO login(string kullaniciAdi, string sifre);
    }
}
