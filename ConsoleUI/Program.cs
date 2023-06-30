using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

// Car_GetAll();
// Car_GetCarDetails();

static void Car_GetAll()
{
    CarManager carManager = new(new EfCarDal());

    foreach (Car car in carManager.GetAll())
    {
        Console.WriteLine(car.CarName + " " + car.Description);
    }
}

static void Car_GetCarDetails()
{
    CarManager carManager = new(new EfCarDal());
    foreach (CarDetailDto carDetailDto in carManager.GetCarDetails())
    {
        System.Console.WriteLine("Car name: " + carDetailDto.CarName + " - " + "Color: " + carDetailDto.ColorName + " - " + "Brand: " + carDetailDto.BrandName);
    }
}