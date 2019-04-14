using CitrusDB.Model.Entity;
using System;

namespace CitrusDB.View
{
  public interface IEntityControlView<T> : ICloneable, IEntity
        where T : IEntity
  {
    IEntityControlView<T> FillView(T entity);
    void SetCopy(IEntityControlView<T> newEntity);
  }
}
