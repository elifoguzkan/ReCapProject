using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand ,RecapContext>, IBrandDal
    {
       
    }
}
