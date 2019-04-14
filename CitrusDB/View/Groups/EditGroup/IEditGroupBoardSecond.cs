using CitrusDB.Model.Entity;
using System;

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
