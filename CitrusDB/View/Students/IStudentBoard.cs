using System;
using System.Drawing;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Students
{
  interface IStudentBoard
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

    int GroupId { get; set; }

    void DisableViewsPanel();
    void EnableViewsPanel();

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
  }
}
