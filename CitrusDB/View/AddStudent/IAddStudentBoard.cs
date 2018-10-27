using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.AddStudent
{
    interface IAddStudentBoard
    {
        string GetFirstName { get; }
        string GetLastName { get; }
        string GetMiddleName { get; }

        string GetCitizenship { get; }
        string GetKnowledgeOfLanguage { get; }

        string DateOfBirth { get; }
        Image GetFirstPhoto { get; }
        Image GetSecondPhoto { get; }

        float GetGrowth { get; }
        float GetWeight { get; }

        ControlCollection GroupsCollection { get; }
        int ProgressBarValue { get; set; }

        event EventHandler SaveButton;
        event EventHandler LoadBoard;
        event EventHandler TextBoxTextChanged;
        event MouseEventHandler TextBoxMouseClick;
        event Func<object, bool> IsValidate;
    }
}
