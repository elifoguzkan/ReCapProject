using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            return idDal.GetById();

        }


    }
}
