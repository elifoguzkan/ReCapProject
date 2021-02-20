using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join o in context.Colors
                             on c.ColorId equals o.ColorId


                             select new CarDetailDto
                             {
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = o.ColorName,
                             };


               return result.ToList();
            }
;        }

       
    }
}
