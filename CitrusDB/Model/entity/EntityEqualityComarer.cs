using System.Collections.Generic;

namespace CitrusDB.Model.Entity
{
  class EntityEqualityComarer<T> : IEqualityComparer<T> where T : IEntity
  {
    public bool Equals(T x, T y)
    {
      if (x.Id == y.Id)
        return true;

      return false;
    }

    public int GetHashCode(T obj)
    {
      return obj.Id.GetHashCode();
    }
  }
}
