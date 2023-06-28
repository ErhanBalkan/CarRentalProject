using Entities.Concrete;

namespace Business.Abstract;
public interface ICarService
{
    Car GetById(int carId);
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);   
}