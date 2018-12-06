using System;

using CitrusDB.Model.Entity;

namespace CitrusDB.Model.UsersEventArgs
{

    public delegate void EntityTransferHandler(object sender, EntityTransferEventArgs e);
    public delegate IEntity GetEntityBySelectedViewHandler(object sender, EntityTransferEventArgs e);

    public class EntityTransferEventArgs : EventArgs
    {
        public IEntity entity;

        public EntityTransferEventArgs(IEntity entity)
        {
            this.entity = entity;
        }
    }
}
