using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new(new EfCarDal());

foreach (Car car in carManager.GetAll()){
    Console.WriteLine(car.CarName +" "+ car.Description);
}

