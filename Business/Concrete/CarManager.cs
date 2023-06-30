using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;
public class CarManager : ICarService
{
    readonly ICarDal _carDal;
    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    public void Add(Car car)
    {
        if (car.CarName.Length >= 2)
            _carDal.Add(car);
        System.Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
        
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public Car GetById(int carId)
    {
        return _carDal.Get(c => c.CarId == carId);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        return _carDal.GetCarDetails();
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }
}