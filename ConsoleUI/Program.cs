using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (Car car in carManager.GetAll())
{
    System.Console.WriteLine(car.CarName);
}