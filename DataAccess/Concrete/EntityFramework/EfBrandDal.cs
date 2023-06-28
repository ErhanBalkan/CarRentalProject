using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class EfBrandDal : IBrandDal
{
    public void Add(Brand entity)
    {
        using CarRentalContext carRentalContext = new();
        var addedEntity = carRentalContext.Entry(entity);
        addedEntity.State = EntityState.Added;
        carRentalContext.SaveChanges();
    }

    public void Delete(Brand entity)
    {
        using CarRentalContext carRentalContext = new();
        var deletedEntity = carRentalContext.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        carRentalContext.SaveChanges();
    }

    public Brand Get(Expression<Func<Brand, bool>> filter)
    {
        using CarRentalContext carRentalContext = new();
        return carRentalContext.Set<Brand>().SingleOrDefault(filter);
    }

    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    {
        using CarRentalContext carRentalContext = new();
        return filter == null
        ? carRentalContext.Set<Brand>().ToList()
        : carRentalContext.Set<Brand>().Where(filter).ToList();
    }

    public void Update(Brand entity)
    {
        using CarRentalContext carRentalContext = new();
        var updatedEntity = carRentalContext.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        carRentalContext.SaveChanges();
    }
}