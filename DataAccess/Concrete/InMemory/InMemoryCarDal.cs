using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;
public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;
    public InMemoryCarDal()
    {
        _cars = new List<Car>{
            new Car{CarId=1,BrandId=1,ColorId=1,CarName="Egea",ModelYear=2023,DailyPrice=5000,Description="1.4 Fire"},
            new Car{CarId=2,BrandId=2,ColorId=1,CarName="Clio",ModelYear=2021,DailyPrice=4000,Description="1.5 Joy"},
            new Car{CarId=3,BrandId=1,ColorId=1,CarName="Fiorino",ModelYear=2023,DailyPrice=2300,Description="1.3 Multijet Emotion"},
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
        throw new NotImplementedException();
    }

    public Car GetById(int carId)
    {
        return _cars.SingleOrDefault(c => c.CarId == carId);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.CarName = car.CarName;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Description = car.Description;
        carToUpdate.ModelYear = car.ModelYear;
    }
}