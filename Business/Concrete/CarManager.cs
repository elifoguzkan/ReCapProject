using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.DTOs;
using Core.Utilities.Results;
using Business.Contansts;
using Core.Utilities.Result;
using Core.CrossCuttingConcerns.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this. _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult (Messages.DescriptionNameInvalid);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==1)
            {
                return new ErrorDataResult <List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult <List<Car>> (_carDal.GetAll(), Messages.ListedMessage);
        }


        public List<Color> GetAllByCars(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>>GetCarDetails()
        {
            return new SuccessDataResult <List<CarDetailDto >> (_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetAllByCars(string id) //çözümlenecek hata vermesin diye yaptım
        {
            throw new NotImplementedException();
        }

        
        public IResult Delete(Car car)
        {
            if (car.CarId==0)
            {
                return new ErrorResult(Messages.DeletedMessage);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ErrorMessage);
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice >= 0) //tamamen koşul bulamadığım için test amaçlı yapıldı
            {
                return new ErrorResult(Messages.UpdatedMessage);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ErrorMessage);
        }
    }
}
