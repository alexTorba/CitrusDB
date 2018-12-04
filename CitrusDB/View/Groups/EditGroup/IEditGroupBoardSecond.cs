using CitrusDB.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View.Groups.EditGroup
{
    interface IEditGroupBoardSecond : IGroupBoard
    {
        Group CurrentGroup { get; }

        event EventHandler SetEditingGroup;
        event Func<bool> AcceptClick;
        event EventHandler CancelClick;
    }
}
