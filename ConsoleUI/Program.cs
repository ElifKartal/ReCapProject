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
            foreach (var car in carManager.GetCarDetailDto())
            {
                Console.WriteLine("Marka: " + car.BrandName + " Model: " + car.Description + " Renk: " + car.ColorName + " Günlük Fiyat: " + car.DailyPrice);
            }

        }


          
        

    }
}

