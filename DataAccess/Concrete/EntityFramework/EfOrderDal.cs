using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,RecapContext>,IOrderDal
    {
    }
}
