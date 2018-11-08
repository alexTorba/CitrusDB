using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model.Entity;

namespace CitrusDB.Model.DataBaseLogic
{
    static class EFGenericRepository
    {
        static readonly DbContext context;

        static EFGenericRepository()
        {
            context = new CitrusDbContext();
            ((CitrusDbContext)context).Students.Include(s => s.Group).Load();

            context.Database.Log = s => Console.WriteLine(s);
        }

        public static void Create<TEntity>(TEntity entity) where TEntity : class
        {
            context.Set<TEntity>().Local.Add(entity);
        }

        public static void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            context.Set<TEntity>().Local
                .Remove(entity);
        }

        public static TEntity FindById<TEntity>(int id) where TEntity : class
        {
            return context.Set<TEntity>()
                .Find(id);
        }

        public static IEnumerable<TEntity> Get<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>().Local.AsEnumerable();
        }

        public static IEnumerable<TEntity> Get<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return context.Set<TEntity>().Local
                .Where(predicate);
        }

        public static IEnumerable<TEntity> GetForRead<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>()
                .AsNoTracking().AsEnumerable();
        }

        public static IEnumerable<TEntity> GetForRead<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return context.Set<TEntity>()
                .AsNoTracking().Where(predicate);
        }

        public static IEnumerable<TEntity> GetView<TEntity>() where TEntity : class
        {
            string par = typeof(TEntity).Name.Trim();
            return context.Database
                .SqlQuery<TEntity>($"SELECT * FROM {par}").AsEnumerable();
        }

        public static void Update<TEntity>(TEntity entity) where TEntity : class
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public static void SaveChanges()
        {
            context.SaveChanges();
        }

        public static async void SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public static IEnumerable<TEntity> GetWithInclude<TEntity>
            (Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
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
            IQueryable<TEntity> query = context.Set<TEntity>().AsQueryable();

            return includeProperties
                .Aggregate(query,
                    (current, includeProperty) => current.Include(includeProperty)
                );
        }

    }
}
