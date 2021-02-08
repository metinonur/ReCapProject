using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void DeleteById(int colorId)
        {
            _colorDal.Delete(_colorDal.Get(c=>c.ColorId==colorId));
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByColorName(string colorName)
        {
            return _colorDal.Get(c => c.ColorName == colorName);
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c=>c.ColorId==colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
