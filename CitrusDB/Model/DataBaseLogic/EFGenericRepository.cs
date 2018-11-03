using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model.Entity;

namespace CitrusDB.Model.DataBaseLogic
{
    static class EFGenericRepository<TEntity> where TEntity : class
    {
        static readonly CitrusDbContext context;

        static EFGenericRepository()
        {
            context = new CitrusDbContext();
            context.Database.Log = s => Console.WriteLine(s);
        }

        public static void Create(TEntity entity)
        {
            context.Set<TEntity>()
                .Add(entity);
        }

        public static void Delete(TEntity entity)
        {
            context.Set<TEntity>()
                .Remove(entity);
        }

        public static TEntity FindById(int id)
        {
            return context.Set<TEntity>()
                .Find(id);
        }

        public static IEnumerable<TEntity> Get()
        {
            //is fill local ? 
            return context.Set<TEntity>()
                .ToList();
        }

        public static IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            //is fill local ?
            return context.Set<TEntity>()
                .Where(predicate).ToList();
        }

        public static IEnumerable<TEntity> GetForRead()
        {
            return context.Set<TEntity>()
                .AsNoTracking().ToList();
        }

        public static IEnumerable<TEntity> GetForRead(Func<TEntity, bool> predicate)
        {
            return context.Set<TEntity>()
                .AsNoTracking().Where(predicate).ToList();
        }

        public static IEnumerable<TEntity> GetView()
        {
            string par = typeof(TEntity).Name.Trim();
            return context.Database
                .SqlQuery<TEntity>($"SELECT * FROM {par}").ToList();
        }

        public static void Update(TEntity entity)
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

        public static IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).Where(predicate).ToList();
        }

        public static IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        private static IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = context.Set<TEntity>().AsQueryable();

            return includeProperties
                .Aggregate(query,
                    (current, includeProperty) => current.Include(includeProperty)
                );
        }

    }
}
