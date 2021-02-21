using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
            new Car() { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description ="Renault Megane",ModelYear =2000},
            new Car() { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 250, Description ="BMW X5",  ModelYear =2005 },
            new Car() { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 200, Description = "Mercedes ", ModelYear = 2010},
            new Car() { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 130, Description = "Opel Astra", ModelYear = 2017},
            new Car() { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 50, Description = "Tofaş", ModelYear = 1995} };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;

        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.CarId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
