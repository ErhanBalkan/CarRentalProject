using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class EfColorDal : IColorDal
{
    public void Add(Color entity)
    {
        using CarRentalContext carRentalContext = new();
        var addedEntity = carRentalContext.Entry(entity);
        addedEntity.State = EntityState.Added;
        carRentalContext.SaveChanges();
    }

    public void Delete(Color entity)
    {
        using CarRentalContext carRentalContext = new();
        var deletedEntity = carRentalContext.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        carRentalContext.SaveChanges();
    }

    public Color Get(Expression<Func<Color, bool>> filter)
    {
        using CarRentalContext carRentalContext = new();
        return carRentalContext.Set<Color>().SingleOrDefault(filter);
    }

    public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
    {
        using CarRentalContext carRentalContext = new();
        return filter == null
        ? carRentalContext.Set<Color>().ToList()
        : carRentalContext.Set<Color>().Where(filter).ToList();
    }

    public void Update(Color entity)
    {
        using CarRentalContext carRentalContext = new();
        var updatedEntity = carRentalContext.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        carRentalContext.SaveChanges();
    }
}