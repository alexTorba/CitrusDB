using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading;

using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;

namespace CitrusDB.Model.DataBaseLogic
{
  public static class EFGenericRepository
  {
    private static readonly DbContext _context;

    static EFGenericRepository()
    {
      _context = new CitrusDbContext();
      ((CitrusDbContext)_context).Students.Include(s => s.Group).Load();

      _context.Database.Log = s => Console.WriteLine(s);
    }

    public static void SetDetached<TEntity>(TEntity entity) where TEntity : class, IEntity
    {
      _context.Entry(entity).State = EntityState.Detached;
    }

    public static void SetUnchanged<TEntity>(TEntity entity) where TEntity : class, IEntity
    {
      _context.Entry(entity).State = EntityState.Unchanged;
    }

    public static void Create<TEntity>(TEntity entity) where TEntity : class
    {
      _context.Set<TEntity>().Local.Add(entity);
    }

    public static void Delete<TEntity>(TEntity entity) where TEntity : class
    {
      _context.Set<TEntity>().Local
          .Remove(entity);
    }

    public static void DeleteRange<TEntity>(IList<TEntity> entities) where TEntity : class
    {
      var local = _context.Set<TEntity>().Local;
      foreach (var entity in entities.ToArray())
      {
        local.Remove(entity);
      }
    }

    public static TEntity Find<TEntity>(int id) where TEntity : class, IEntity
    {
      return _context.Set<TEntity>().Local
          .FirstOrDefault(e => e.Id == id);
    }

    public static IEnumerable<TEntity> Get<TEntity>() where TEntity : class
    {
      return _context.Set<TEntity>().Local.AsEnumerable();
    }

    public static IEnumerable<TEntity> Get<TEntity>(Func<TEntity, bool> predicate)
        where TEntity : class
    {
      return _context.Set<TEntity>().Local
          .Where(predicate);
    }

    public static IEnumerable<TEntity> Get<TEntity>(string searchCriteria, string filter)
        where TEntity : class
    {
      if (string.IsNullOrEmpty(filter))
        return Get<TEntity>();

      return _context.Set<TEntity>().Local
          .Where(searchCriteria, filter);
    }

    public static IEnumerable<TEntity> GetWithLoad<TEntity>() where TEntity : class
    {
      _context.Set<TEntity>().Load();
      return _context.Set<TEntity>().Local.AsEnumerable();
    }

    public static IEnumerable<TEntity> GetWithLoad<TEntity>(Func<TEntity, bool> predicate)
        where TEntity : class
    {
      _context.Set<TEntity>().Load();
      return _context.Set<TEntity>().Local
          .Where(predicate);
    }

    public static IEnumerable<TEntity> GetForRead<TEntity>() where TEntity : class
    {
      return _context.Set<TEntity>()
          .AsNoTracking().AsEnumerable();
    }

    public static IEnumerable<TEntity> GetForRead<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
    {
      return _context.Set<TEntity>()
          .AsNoTracking().Where(predicate);
    }

    public static void Update<TEntity>(TEntity entity) where TEntity : class
    {
      _context.Entry(entity).State = EntityState.Modified;
    }

    public static void SaveChanges()
    {
      SetUpdatedEntitiesInLocalToAdding();

      _context.SaveChanges();
    }

    private static void SetUpdatedEntitiesInLocalToAdding()
    {
      _context.Set<Student>().Local.ToList().ForEach(s =>
      {
        if (s.Id >= 100000000 && _context.Entry(s).State == EntityState.Modified)
          _context.Entry(s).State = EntityState.Added;
      });

      _context.Set<Group>().Local.ToList().ForEach(g =>
      {
        if (g.Id >= 100000000 && _context.Entry(g).State == EntityState.Modified)
          _context.Entry(g).State = EntityState.Added;
      });
    }

    public static async Task SaveChangesAsync()
    {
      SetUpdatedEntitiesInLocalToAdding();
      await _context.SaveChangesAsync();
    }

    public static int CountOfEntities<TEntity>() where TEntity : class, IEntity
    {
      return _context.Set<TEntity>().Local.Count;
    }

    public static async Task<IEnumerable<IEntity>> GetEntityBySearch(
       SelectedEntity selectedEntity,
       string condition,
       CancellationToken token)
    {
      return await Task.Run(() =>
      {
        switch (selectedEntity)
        {
          case SelectedEntity.Group:
            {
              if (condition == string.Empty)
                return (IEnumerable<IEntity>)Get<Group>();
              return Get<Group>(g => g.Name.ToUpperInvariant()
                                          .Contains(condition.ToUpperInvariant()));
            }
          case SelectedEntity.Student:
            {
              if (condition == string.Empty)
                return Get<Student>();
              return Get<Student>(s => s.FirstName.ToUpperInvariant()
                                            .Contains(condition.ToUpperInvariant()));
            }
          default:
            return null;
        }
      }, token);
    }

    public static IEnumerable<TEntity> GetEntitiesWithState<TEntity>(EntityState entityState)
        where TEntity : class, IEntity
    {
      if (entityState == EntityState.Deleted)
        return _context.Set<TEntity>()
                            .AsEnumerable()
                            .Where(t => _context.Entry(t).State == entityState).ToList();
      else
        return _context.Set<TEntity>().Local
                            .Where(t => _context.Entry(t).State == entityState).ToList();
    }

    public static IEnumerable<TEntity> GetEntitiesWithState<TEntity>(
        EntityState entityState,
        Func<TEntity, bool> predicate)
        where TEntity : class, IEntity
    {
      if (entityState == EntityState.Deleted)
        return _context.Set<TEntity>()
                            .AsEnumerable()
                            .Where(predicate)
                            .Where(t => _context.Entry(t).State == entityState).ToList();
      else
        return _context.Set<TEntity>().Local
                            .Where(predicate)
                            .Where(t => _context.Entry(t).State == entityState).ToList();
    }

    public static IEnumerable<TEntity> GetWithInclude<TEntity>
        (Func<TEntity, bool> predicate,
        params Expression<Func<TEntity, object>>[] includeProperties)
        where TEntity : class
    {
      return Include(includeProperties).Where(predicate);
    }

    public static IEnumerable<TEntity> GetWithInclude<TEntity>
        (params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
    {
      return Include(includeProperties).AsEnumerable();
    }

    private static IQueryable<TEntity> Include<TEntity>
        (params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
    {
      IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();

      return includeProperties
          .Aggregate(query,
              (current, includeProperty) => current.Include(includeProperty)
          );
    }

  }
}
