using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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
        _carDal.Add(car);
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

    public void Update(Car car)
    {
        _carDal.Update(car);
    }
}