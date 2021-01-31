using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;

namespace ConcreteUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç Numarsı : " + car.Id);
                Console.WriteLine("Marka : " + car.BrandId);
                Console.WriteLine("Renk : " + car.ColorId);
                Console.WriteLine("Model : " + car.ModelYear);
                Console.WriteLine("Günlük Ücret : " + car.DailyPrice);
                Console.WriteLine("Açıklama : " + car.Description);
                Console.WriteLine("*********************************************************************");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
