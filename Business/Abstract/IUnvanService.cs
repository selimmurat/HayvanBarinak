using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnvanService
    {
        List<Unvan> Getll();
        Unvan GetById(int id);
        void Add(Unvan unvan);
        void Delete(Unvan unvan);
        void Update(Unvan unvan);
    }
}
