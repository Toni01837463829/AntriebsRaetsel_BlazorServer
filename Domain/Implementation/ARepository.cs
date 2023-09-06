using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repos.Interface;
using Model.Configurations;

namespace Repos.Implementation;

public  abstract class ARepository<TEntity> : IRepository<TEntity> 
    where TEntity : class
{
    protected readonly AntriebsContext AntriebsContext;
    protected readonly DbSet<TEntity> Table;

    protected ARepository(AntriebsContext antriebsContext)
    {
        AntriebsContext = antriebsContext;
        Table = antriebsContext.Set<TEntity>();
    }

    public TEntity Create(TEntity t)
    {
        Table.Add(t);
        AntriebsContext.SaveChanges();
        return t;
    }

    public List<TEntity> CreateRange(List<TEntity> list)
    {
        Table.AddRange(list);
        AntriebsContext.SaveChanges();
        return list;
    }

    public void Update(TEntity t)
    {
        AntriebsContext.ChangeTracker.Clear();
        Table.Update(t);
        AntriebsContext.SaveChanges();
    }

    public void UpdateRange(List<TEntity> list)
    {
        Table.UpdateRange(list);
        AntriebsContext.SaveChanges();
    }

    public TEntity? Read(int id) => Table.Find(id);

    public List<TEntity> Read(Expression<Func<TEntity, bool>> filter)
        => Table.Where(filter).ToList();

    public List<TEntity> Read(int start, int count)
        => Table.Skip(start)
            .Take(count)
            .ToList();

    public List<TEntity> ReadAll() => Table.ToList();

    public void Delete(TEntity t)
    {
        Table.Remove(t);
        AntriebsContext.SaveChanges();
    }
}