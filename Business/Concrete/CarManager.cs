using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal ;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult < List < Car >> (_carDal.GetAll(),Messages.CarListed);
        }
        public IResult Add(Car car) 
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            else if (car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.DailyPriceNotEnough);
            }
            else
            {
                return new SuccessResult(Messages.CarAdded);
            }
        }
        public IResult Delete(Car car) 
        {
            return new SuccessResult(Messages.CarDeleted);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId) 
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=> c.BrandId==brandId),Messages.CarListedByBrandId);
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId) 
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId),Messages.CarListedByColorID);
        }
        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdated);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarDetailListed);
        }

        public IDataResult<List<Car>> GetById(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId == carId), Messages.CarListedByCarId);
        }
    }
}
