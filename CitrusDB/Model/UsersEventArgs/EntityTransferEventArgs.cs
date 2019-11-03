using System;
using System.Threading.Tasks;
using CitrusDB.Model.Entity;

namespace CitrusDB.Model.UsersEventArgs
{
  public delegate void EntityTransferHandler(object sender, EntityTransferEventArgs e);

  public delegate IEntity GetEntityBySelectedViewHandler(object sender, EntityTransferEventArgs e);

  public delegate Task EventHandlerAsync(object sender, EventArgs e);

  public class EntityTransferEventArgs : EventArgs
  {
    public IEntity Entity { get; }

    public EntityTransferEventArgs(IEntity entity)
    {
      Entity = entity;
    }
  }
}
