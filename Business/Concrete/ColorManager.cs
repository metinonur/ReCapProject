using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
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
        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult <List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == id), Messages.ColorListedByColorId);
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
