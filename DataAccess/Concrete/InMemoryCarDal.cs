using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=2,ModelYear=2012,DailyPrice=300,Description="Ayağını yerden keser"},
                new Car {Id=2,BrandId=2,ColorId=1,ModelYear=2015,DailyPrice=350,Description="Doblo"},
                new Car {Id=3,BrandId=1,ColorId=2,ModelYear=2013,DailyPrice=325,Description="Ayağını yerden keser2"},
                new Car {Id=4,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=450,Description="Sportif"},
                new Car {Id=5,BrandId=3,ColorId=4,ModelYear=2020,DailyPrice=475,Description="Konforlu geniş"}
            };
        }


        public void Add(Car car)
        {
           
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetByID(Car car)
        {
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;

        }
    }
}
