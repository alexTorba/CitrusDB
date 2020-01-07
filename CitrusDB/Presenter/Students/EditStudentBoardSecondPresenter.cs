using System;
using System.Linq;

using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Students.EditStuden;
using CitrusDB.View.Groups.GroupsView.GroupViews;

namespace CitrusDB.Presenter.Students
{
  class EditStudentBoardSecondPresenter : StudentBoardPresenter
  {
    private readonly IEditStudentBoardSecond _studentBoardSecond;

    public EditStudentBoardSecondPresenter(IEditStudentBoardSecond studentBoard, IGroupView groupView)
        : base(studentBoard, groupView)
    {
      _studentBoardSecond = studentBoard;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _studentBoardSecond.AcceptButton += StudentBoardSecond_AcceptButton;
      _studentBoardSecond.CancelButton += StudentBoardSecond_CancelButton;
      _studentBoardSecond.SetInitGroup += StudentBoardSecond_SetInitGroup;
    }

    #region IEditStudentBoardSecond

    private void StudentBoardSecond_SetInitGroup(object sender, EntityTransferEventArgs e)
    {
      if (_studentBoardSecond.GroupsCollection.Count == 0)
      {
        return;
      }
      else
      {
        ((IGroupView)_studentBoardSecond.GroupsCollection[0]).ResetOtherBoard();

        if (e.Entity != null)
        {
          var group = _studentBoardSecond.GroupsCollection
                              .Cast<IGroupView>()
                              .FirstOrDefault(g => g.Id == e.Entity.Id);

          group?.SelectView();
        }
      }
    }

    private void StudentBoardSecond_CancelButton(object sender, EventArgs e)
    {
      //throw new NotImplementedException();
    }

    private bool StudentBoardSecond_AcceptButton()
    {
      var selectedGroup = _studentBoardSecond.GroupsCollection
          .Cast<IGroupView>()
          .FirstOrDefault(gv => gv.IsSelected == true);

      var editStudent = new Student
      {
        Id = _studentBoardSecond.CurrentStudent.Id,
        FirstName = _studentBoardSecond.GetFirstName,
        LastName = _studentBoardSecond.GetLastName,
        MiddleName = _studentBoardSecond.GetMiddleName,
        DateOfBirth = _studentBoardSecond.DateOfBirth,
        Height = _studentBoardSecond.GetGrowth,
        Weight = _studentBoardSecond.GetWeight,
        Сitizenship = _studentBoardSecond.GetCitizenship,
        KnowledgeOfLanguage = _studentBoardSecond.GetKnowledgeOfLanguage,

        FirstPhoto = _studentBoardSecond.GetFirstPhoto.SetPhoto(_studentBoardSecond.CurrentStudent.FirstPhoto),

        SecondPhoto = _studentBoardSecond.GetSecondPhoto.SetPhoto(_studentBoardSecond.CurrentStudent.SecondPhoto),

        GroupId = selectedGroup?.Id
      };

      var isEquality = new StudentsEqualityComparer()
          .Equals(editStudent, _studentBoardSecond.CurrentStudent);

      if (isEquality) 
        return false;
      
      _studentBoardSecond.CurrentStudent.SetCopy(editStudent);
      EFGenericRepository.Update(_studentBoardSecond.CurrentStudent);
      return true;
    }

    #endregion
  }
}
