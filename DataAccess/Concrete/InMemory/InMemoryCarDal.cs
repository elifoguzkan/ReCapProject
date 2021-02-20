using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1523, BrandId=105, ColorId=10961,ModelYear=2015, DailyPrice=130, Description="Opel Corsa 2020"  },
                new Car{CarId=2148, BrandId=110, ColorId=90142,ModelYear=2018 , DailyPrice=690, Description="Mercedes C180"  },
                new Car{CarId=9853, BrandId=115, ColorId=85103,ModelYear=2013, DailyPrice=500, Description="BMW i8"  },
                new Car{CarId=4154, BrandId=142, ColorId=25104,ModelYear=2010, DailyPrice=300, Description="Hundai i20"  },
                new Car{CarId=2505, BrandId=185, ColorId=69105,ModelYear=2020, DailyPrice=600, Description="Mini Cooper S"  },
            };

            
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

       

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll() //veritabanındaki datayı businessa verecek
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByAllCar(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }

        
    }
}
