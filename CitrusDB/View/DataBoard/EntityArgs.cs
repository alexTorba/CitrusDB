using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
