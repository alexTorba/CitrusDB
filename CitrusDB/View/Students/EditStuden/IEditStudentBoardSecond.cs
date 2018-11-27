using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View.Students.EditStuden
{
    interface IEditStudentBoardSecond : IStudentBoard
    {
        event EventHandler AcceptButton;
        event EventHandler CancelButton;
    }
}
