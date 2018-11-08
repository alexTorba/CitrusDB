using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.AddGroup
{
    interface IAddGroupBoard
    {
        string CountOfAddedStudent { get; set; }
        string GetNameOfGroup { get; }
        Image GetGroupPhoto { get; }

        ControlCollection CurrentStudentControlCollection { get; }
        ControlCollection AddedStudentControlCollection { get; }

        void ClearView();
        void DisableCurrentStudentPanel();
        void EnableCurrentStudentPanel();

        event EventHandler LoadAddGroupBoard;
        event EventHandler ChangeAddedStudentPanelControl;
        event EventHandler ClearClick;
        event EventHandler SaveClick;
        event EventHandler CurrentStudentSearchTextBoxChanges;
        event EventHandler UpdateView;
    }
}
