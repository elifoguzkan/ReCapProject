using Business.Abstract;
using Business.Contansts;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal=rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if(rental.ReturnDate==DateTime.Now.AddHours(-3))
            {
                return new SuccessResult(Messages.RentalAdded);
            }
            _rentalDal.Add(rental);
            return new ErrorResult(Messages.RentalError);
            
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
