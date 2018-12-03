using System;

namespace CitrusDB.View.Groups.AddGroup
{
    interface IAddGroupBoard : IGroupBoard
    {
        event EventHandler ClearClick;
        event EventHandler SaveClick;
    }
}
