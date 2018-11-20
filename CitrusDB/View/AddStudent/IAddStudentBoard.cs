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

        ControlCollection GetBoardControls { get; }

        event EventHandler SaveButton;
        event EventHandler ClearButton;
        event EventHandler GenerateButton;

        event EventHandler LoadBoard;
        event EventHandler TextBoxTextChanged;
        event EventHandler ControlEnter;

        event EventHandler ComboBoxSelectionChange;
        event EventHandler ComboBoxTextUpdate;

        event EventHandler MonthCalendarEnter;
        event EventHandler MonthCalendarDateChange;
        event EventHandler MonthCalendarDateSelected;

        event EventHandler PhotoLoaded;

        event EventHandler UpdateView;

        event EventHandler SearchBox_TextChange;

        void ResetControls();
        void SetInitDate();
        void HidePhotoLabels();
        void DisableViewsPanel();
        void EnableViewsPanel();
    }
}
