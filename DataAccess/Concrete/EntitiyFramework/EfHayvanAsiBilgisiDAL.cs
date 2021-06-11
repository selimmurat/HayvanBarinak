using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfHayvanAsiBilgisiDAL : EfEntityRepositoryBase<HayvanAsiBilgisi, HelperContext>,IHayvanAsiBilgisiDAL
    {
    }
}
