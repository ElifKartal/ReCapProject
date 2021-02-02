using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,BrandName="Skoda",ColorId=1, ModelYear=2010,DailyPrice=200,Description="Aile"},
                new Car{CarId=2,BrandId=2,BrandName="Ferrari",ColorId=2, ModelYear=2015,DailyPrice=500,Description="Spor"},
                new Car{CarId=3,BrandId=3,BrandName="Ford",ColorId=3, ModelYear=2019,DailyPrice=100,Description="Aile"},
                new Car{CarId=4,BrandId=4,BrandName="Bmw",ColorId=4, ModelYear=2020,DailyPrice=250,Description="Spor"}
            };
        }

        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.BrandName = car.BrandName;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ColorName = car.ColorName;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
