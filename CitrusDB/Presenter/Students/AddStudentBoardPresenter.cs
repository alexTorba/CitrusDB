using System;
using System.Linq;
using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.View.Students.AddStudent;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model;
using System.Windows.Forms;
using CitrusDB.Model.Extensions;
using System.Threading;

namespace CitrusDB.Presenter.Students
{
  class AddStudentBoardPresenter : StudentBoardPresenter
  {
    private readonly IAddStudentBoard _addStudentBoard;
    private readonly IGroupView _groupView;

    public AddStudentBoardPresenter(IAddStudentBoard studentBoard, IGroupView groupView) : base(studentBoard, groupView)
    {
      _addStudentBoard = studentBoard;
      _groupView = groupView;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _addStudentBoard.ClearButton += AddStudentBoard_ClearButton;
      _addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
      _addStudentBoard.GenerateButton += AddStudentBoard_GenerateButton;
    }

    #region IAddStudentBoard

    private void AddStudentBoard_GenerateButton(object sender, EventArgs e)
    {
      AddStudentBoard_ClearButton(null, EventArgs.Empty);

      var (p1, p2) = Generate.GetPhotos();

      foreach (Control control in _addStudentBoard.GetBoardControls)
      {
        switch (control)
        {
          case TextBox textBox:
            StudentBoard_ControlEnter(textBox, EventArgs.Empty);
            textBox.FillControl();
            break;
          case ComboBox comboBox:
            StudentBoard_ControlEnter(comboBox, EventArgs.Empty);
            comboBox.FillControl();
            StudentBoard_ComboBoxSelectionChange(comboBox, EventArgs.Empty);
            break;
          case PictureBox pictureBox:
          {
            StudentBoard_ControlEnter(pictureBox, EventArgs.Empty);

            if (pictureBox.Name == "pictureBoxFirstPhoto")
              pictureBox.Load(p1);
            else
              pictureBox.Load(p2);

            StudentBoard_PhotoLoaded(pictureBox, EventArgs.Empty);
            _addStudentBoard.HidePhotoLabels();
            break;
          }
          case MonthCalendar monthCalendar:
          {
            var time = Generate.GenerateDateTime();
            monthCalendar.SelectionRange = new SelectionRange(time, time);
            _addStudentBoard.SetInitDate();
            monthCalendar.Select();

            StudentBoard_MonthCalendarDateSelected(monthCalendar, EventArgs.Empty);
            break;
          }
        }
      }
    }

    private async void AddStudentBoard_SaveButton(object sender, EventArgs e)
    {
      var selectedGroupView = _addStudentBoard.GroupsCollection
        .Cast<IGroupView>()
        .FirstOrDefault(gv => gv.IsSelected);

      var student = new Student
      {
        Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
        FirstName = _addStudentBoard.GetFirstName.Trim(),
        LastName = _addStudentBoard.GetLastName.Trim(),
        MiddleName = _addStudentBoard.GetMiddleName.Trim(),
        Сitizenship = _addStudentBoard.GetCitizenship.Trim(),
        FirstPhoto = _addStudentBoard.GetFirstPhoto.ConvertImageToByteArr(),
        SecondPhoto = _addStudentBoard.GetSecondPhoto.ConvertImageToByteArr(),
        DateOfBirth = _addStudentBoard.DateOfBirth.Trim(),
        Height = _addStudentBoard.GetGrowth,
        Weight = _addStudentBoard.GetWeight,
        KnowledgeOfLanguage = _addStudentBoard.GetKnowledgeOfLanguage.Trim(),

        GroupId = selectedGroupView?.Id
      };

      EFGenericRepository.Create(student);

      // todo: ? (now without group)
      // if (selectedGroup != null)
      // {
      //   await _addStudentBoard.GroupsCollection.UpdateControls(new[] {selectedGroup}, _groupView,
      //     CancellationToken.None);
      //   EFGenericRepository.Update(selectedGroup);
      // }
    }

    private void AddStudentBoard_ClearButton(object sender, EventArgs e)
    {
      _addStudentBoard.SetInitDate();

      _addStudentBoard.ProgressBarValue = 0;

      GroupView_ClearOtherBoard(null, EventArgs.Empty);

      Validate.Reset();

      _addStudentBoard.ResetControls();
    }

    #endregion
  }
}