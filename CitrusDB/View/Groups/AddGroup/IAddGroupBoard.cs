using System;

namespace CitrusDB.View.Groups.AddGroup
{
    interface IAddGroupBoard : IGroupBoard
    {
        event EventHandler ClearClick;
        event Func<bool> SaveClick;
    }
}
