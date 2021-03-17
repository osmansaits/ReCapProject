using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //Class içinde Metot dışında tanımlanan değişkenlere global değişken denir.
        List<Car> _cars;
        public InMemoryCarDal()
        {   //Veri tabanından gelen verileri temsil eden ürünlerdir.
            _cars = new List<Car>
            {
                new Car{Id = 1, BrantId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = "100$", Description = "Audi A8"},
                new Car{Id = 2, BrantId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = "100$", Description = "Audi A8"},
                new Car{Id = 3, BrantId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = "90$", Description = "Wolksvagen"},
                new Car{Id = 4, BrantId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = "100$", Description = "Audi A8"},
                new Car{Id = 5, BrantId = 3, ColorId = 3, ModelYear = 2021, DailyPrice = "100$", Description = "Mercedes"},
                new Car{Id = 6, BrantId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = "85$", Description = "Wolksvagen"},
             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int id)
        {
           return _cars.Where(c => c.Id == id).ToList();
        }

        
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrantId = car.BrantId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
