using CitrusDB.Model.UsersEventArgs;
using System;
using System.Drawing;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Groups
{
    interface IGroupBoard
    {
        string CountOfAddedStudent { get; set; }
        string GetNameOfGroup { get; }
        Image GetGroupPhoto { get; }

        ControlCollection CurrentStudentControlCollection { get; }
        ControlCollection AddedStudentControlCollection { get; }

        void ClearView();
        void DisableCurrentStudentPanel();
        void EnableCurrentStudentPanel();
        void DisableAddedStudentPanel();
        void EnableAddedStudentPanel();

        event EventHandler LoadGroupBoard;
        event EventHandler ChangeAddedStudentPanelControl;
        event SearchingEventHandler CurrentStudentSearchTextBoxChanges;
        event EventHandler UpdateView;
    }
}
