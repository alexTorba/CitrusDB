using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.DataBaseLogic
{
    class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        readonly DbContext context;
        readonly DbSet<TEntity> dbSet;

        public EFGenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public TEntity FindById(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public async void SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
