using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConcreteUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            carManager.GetAll();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName+" "+car.BrandId+" "+car.DailyPrice+" "+car.Description);
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
