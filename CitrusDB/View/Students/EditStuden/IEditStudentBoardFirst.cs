using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Students.EditStuden
{
    interface IEditStudentBoardFirst
    {

        Student EditStudent { get; set; }

        ControlCollection StudentControlCollection { get; }

        void EnablingControlCollection();
        void DisablingControlCollection();

        void LoadingSecondForm();

        event EventHandler LoadEditStudentBoardFirst;
        event EventHandler UpdateView;
        event SearchingEventHandler StudentSearchTextBoxChanges;

    }
}
