using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Color\tYear\tBrand\tDescription\tDaily Price\n");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.ColorName + "\t" + car.ModelYear + "\t" + car.BrandName + "\t" + car.Description + "\t\t" + car.DailyPrice);
            }





        }
    }
}

