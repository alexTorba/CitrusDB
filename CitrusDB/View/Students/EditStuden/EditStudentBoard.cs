using System;
using System.Windows.Forms;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;

namespace CitrusDB.View.Students.EditStuden
{
  public partial class EditStudentBoard : UserControl
  {
    private MainForm _mainForm;
    private Panel editStudentSecondContainerPanel;
    public EditStudentBoardFirst editStudentBoardFirst;
    public EditStudentBoardSecond editStudentBoardSecond;

    public EditStudentBoard()
    {
      InitializeComponent();

      editStudentBoardFirst.LoadSecondForm += EditStudentBoardFirst_LoadSecondForm;
      editStudentBoardSecond.CancelButton += EditStudentBoardSecond_CancelButton;
    }

    public void InitFields(MainForm mainForm)
    {
      _mainForm = mainForm;
      editStudentBoardFirst?.InitFields(_mainForm);
    }

    public void UpdateView()
    {
      editStudentBoardFirst.UpdatingView();
      editStudentBoardSecond.UpdateGroupView();
    }

    private void EditStudentBoardSecond_CancelButton(object sender, EventArgs e)
    {
      editStudentBoardFirst.UpdatingView();
      editStudentBoardFirst.isSecondFormOpened = false;
      if (_mainForm != null)
      {
        _mainForm.ClearEventHandlers();
        _mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuickly;

        _mainForm.timer.Start();
      }
    }

    public void LoadSecondForm(Student students)
    {
      editStudentBoardSecond?.SetStudent(students);

      if (_mainForm != null && !editStudentBoardFirst.isSecondFormOpened)
      {
        editStudentBoardFirst.isSecondFormOpened = true;

        _mainForm.ClearEventHandlers();
        _mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuickly;

        _mainForm.timer.Start();
      }
    }

    private void EditStudentBoardFirst_LoadSecondForm(object sender, EventArgs e)
    {
      LoadSecondForm(editStudentBoardFirst?.EditStudent);
    }
  }
}