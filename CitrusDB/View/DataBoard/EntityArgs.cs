using System;

namespace CitrusDB.View.DataBoard
{
  class EntityArgs : EventArgs
  {
    public object Entity { get; }

    public EntityArgs(object entity)
    {
      Entity = entity;
    }
  }
}
