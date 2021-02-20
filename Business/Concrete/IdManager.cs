using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class IdManager : IIdService
    {
        IIdDal idDal;

        public IdManager(IIdDal idDal)
        {
            this.idDal = idDal;
        }

        public List<Id> GetById()
        {
            throw new NotImplementedException();

        }
    }
}
