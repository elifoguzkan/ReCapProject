using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIdDal
    {
        List<Id> GetById();
        void Add(Id id);
        void Update(Id id);
        void Delete(Id id);
        List<Id> GetByAllId(int carId);
    }
}
