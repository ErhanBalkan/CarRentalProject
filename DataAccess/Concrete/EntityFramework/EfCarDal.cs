using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;
public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using CarRentalContext context = new();
        var result = from c in context.Cars
                     join clr in context.Colors
                     on c.ColorId equals clr.ColorId
                     join b in context.Brands
                     on c.BrandId equals b.BrandId
                     select new CarDetailDto{
                        BrandName = b.BrandName,
                        CarName = c.CarName,
                        ColorName = clr.ColorName,
                        DailyPrice = c.DailyPrice
                     };
                     return result.ToList();
    }
}