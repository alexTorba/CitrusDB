using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.DataBaseLogic
{
    interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity FindById(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
