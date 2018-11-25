using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.EditStuden
{
    interface IEditStudentBoardFirst
    {
        ControlCollection StudentControlCollection { get; }

        void EnablingControlCollection();
        void DisablingControlCollection();

        event EventHandler LoadEditStudentBoardFirst;
        event EventHandler UpdateView;
        event EventHandler StudentSearchTextBoxChanges;

    }
}
