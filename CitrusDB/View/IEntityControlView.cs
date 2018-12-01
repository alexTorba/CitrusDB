using CitrusDB.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View
{
    public interface IEntityControlView<T> : ICloneable, IEntity
          where T : IEntity
    {
        IEntityControlView<T> FillView(T entity);
        void SetCopy(IEntityControlView<T> newEntity);
    }
}
