using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnvanManager : IUnvanService
    {
        IUnvanDAL _unvanDAL;

        public UnvanManager(IUnvanDAL unvanDAL)
        {
            _unvanDAL = unvanDAL;
        }

        public void Add(Unvan unvan)
        {
            _unvanDAL.Add(unvan);
        }

        public void Delete(Unvan unvan)
        {
            _unvanDAL.Delete(unvan);
        }

        public Unvan GetById(int id)
        {
            return _unvanDAL.Get(u => u.id == id);
        }

        public List<Unvan> Getll()
        {
            return _unvanDAL.GetList().ToList();
        }

        public void Update(Unvan unvan)
        {
            _unvanDAL.Update(unvan);
        }
    }
}
