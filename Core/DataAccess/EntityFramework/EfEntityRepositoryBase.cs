using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework;
public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
where TEntity : class, IEntity, new()
where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using TContext carRentalContext = new();
        var addedEntity = carRentalContext.Entry(entity);
        addedEntity.State = EntityState.Added;
        carRentalContext.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        using TContext carRentalContext = new();
        var deletedEntity = carRentalContext.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        carRentalContext.SaveChanges();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using TContext carRentalContext = new();
        return carRentalContext.Set<TEntity>().SingleOrDefault(filter);
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        using TContext carRentalContext = new();
        return filter == null
        ? carRentalContext.Set<TEntity>().ToList()
        : carRentalContext.Set<TEntity>().Where(filter).ToList();
    }

    public void Update(TEntity entity)
    {
        using TContext carRentalContext = new();
        var updatedEntity = carRentalContext.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        carRentalContext.SaveChanges();
    }
}