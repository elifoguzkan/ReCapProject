using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryIdDal : IIdDal

    {
        List<Id> _ids;
        public InMemoryIdDal()
        {
            _ids = new List<Id>
            {
                
                new Id{CarId=1956, ModelId=001, BrandName="Opel Corsa"},
                new Id{CarId=2875, ModelId=002, BrandName="Mercedes Benz"},
                new Id{CarId=3225, ModelId=003, BrandName="BMW"},
                new Id{CarId=4012, ModelId=004, BrandName="Hundai"},
                new Id{CarId=5896, ModelId=005, BrandName="Mini Cooper"},


            };
           
           
        }

        public void Add(Id id)
        {
            _ids.Add(id);
        }

        public void Delete(Id id)
        {
            Id idToDelete = _ids.SingleOrDefault(i => i.CarId == i.CarId);
            _ids.Remove(idToDelete);
        }

        public List<Id> GetByAllId(int carId)
        {
            return _ids.Where(i => i.CarId == carId).ToList();
        }

        public List<Id> GetById()
        {
            return _ids;
        }

        public void Update(Id id)
        {
            Id idToUpdate = _ids.SingleOrDefault(i => i.CarId == i.CarId);
            idToUpdate.CarId = id.CarId;
            idToUpdate.ModelId = id.ModelId;
            idToUpdate.BrandName = id.BrandName;
        }
    
    }
}
