using System;
using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Students.EditStuden
{
  interface IEditStudentBoardSecond : IStudentBoard
  {
    Student CurrentStudent { get; }

    event Func<bool> AcceptButton;
    event EventHandler CancelButton;

    event EntityTransferHandler SetInitGroup;
  }
}
