using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConcreteUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            ColorManager colorManager  = new ColorManager(new EFColorDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());

            carManager.GetAll();
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }
            Console.WriteLine("---------------Renk Listesi--------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            
            
              






            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Araç Numarsı : " + car.CarId);
            //    Console.WriteLine("Marka : " + car.BrandId);
            //    Console.WriteLine("Renk : " + car.ColorId);
            //    Console.WriteLine("Model : " + car.ModelYear);
            //    Console.WriteLine("Günlük Ücret : " + car.DailyPrice);
            //    Console.WriteLine("Açıklama : " + car.Description);
            //    Console.WriteLine("*********************************************************************");
            //}

          
        }
    }
}
