using System;

using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Students.EditStuden
{
    interface IEditStudentBoardSecond : IStudentBoard
    {
        event EventHandler AcceptButton;
        event EventHandler CancelButton;

        event EntityTransferHandler SetInitGroup;        
    }
}
