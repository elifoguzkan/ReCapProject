using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this. _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
         }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
