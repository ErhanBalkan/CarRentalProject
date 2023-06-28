using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class EfCarDal : ICarDal
{
    public void Add(Car entity)
    {
        using CarRentalContext carRentalContext = new();
        var addedEntity = carRentalContext.Entry(entity);
        addedEntity.State = EntityState.Added;
        carRentalContext.SaveChanges();
    }

    public void Delete(Car entity)
    {
        using CarRentalContext carRentalContext = new();
        var deletedEntity = carRentalContext.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        carRentalContext.SaveChanges();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        using CarRentalContext carRentalContext = new();
        return carRentalContext.Set<Car>().SingleOrDefault(filter);
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        using CarRentalContext carRentalContext = new();
        return filter == null 
        ? carRentalContext.Set<Car>().ToList()
        : carRentalContext.Set<Car>().Where(filter).ToList();
    }

    public void Update(Car entity)
    {
        using CarRentalContext carRentalContext = new();
        var updatedEntity = carRentalContext.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        carRentalContext.SaveChanges();
    }
}