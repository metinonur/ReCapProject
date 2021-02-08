using Business.Abstract;
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
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Add(Car car) 
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0) _carDal.Add(car);
            else Console.WriteLine("Araba ismi minimum 2 karakter olmalı ve günlük ücreti sıfırdan büyük olmalı");
        }
        public void Delete(Car car) 
        {
            _carDal.Delete(car);
        }
        public void GetCarsByBrandId(int brandId) 
        {
            _carDal.GetAll(c=> c.BrandId==brandId);
        }
        public void GetCarsByColorId(int colorId) 
        {
            _carDal.GetAll(c => c.ColorId == colorId);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
