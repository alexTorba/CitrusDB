using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitrusDB.View.Groups.EditGroup;
using CitrusDB.View.Students;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using System.Threading;
using CitrusDB.View.Students.StudentsView.AddedStudentView;

namespace CitrusDB.Presenter.Groups
{
  class EditGroupBoardSecondPresenter : GroupBoardPresenter
  {
    private readonly IEditGroupBoardSecond _groupBoardSecond;

    public EditGroupBoardSecondPresenter(IEditGroupBoardSecond groupBoardSecond, IStudentView currentStudentView, IStudentView addedStudentView)
        : base(groupBoardSecond, currentStudentView, addedStudentView)
    {
      _groupBoardSecond = groupBoardSecond;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _groupBoardSecond.AcceptClick += GroupBoardSecond_AcceptClick;
      _groupBoardSecond.CancelClick += GroupBoardSecond_CancelClick;
      _groupBoardSecond.SetEditingGroup += GroupBoardSecond_SetEditingGroup;
    }

    #region Event Handlers

    private async void GroupBoardSecond_SetEditingGroup(object sender, EventArgs e)
    {
      _groupBoardSecond.CurrentStudentControlCollection.DeleteControls(
          _groupBoardSecond.CurrentGroup.Students,
          CancellationToken.None);

      _groupBoardSecond.AddedStudentControlCollection.Clear();

      await _groupBoardSecond
          .AddedStudentControlCollection
          .AddControls(_groupBoardSecond.CurrentGroup.Students,
          addedStudentView,
          CancellationToken.None);
    }

    private bool GroupBoardSecond_AcceptClick()
    {
      var students = new List<Student>();

      foreach (IStudentView studentView in _groupBoardSecond.AddedStudentControlCollection)
        students.Add(EFGenericRepository.Find<Student>(studentView.Id));

      var group = new Group
      {
        Id = _groupBoardSecond.CurrentGroup.Id,
        Name = _groupBoardSecond.GetNameOfGroup,
        Students = students,
        Photo = _groupBoardSecond.GetGroupPhoto.SetPhoto(_groupBoardSecond.CurrentGroup.Photo)
      };

      if (!group.Equals(_groupBoardSecond.CurrentGroup, group))
      {
        _groupBoardSecond.CurrentGroup.SetCopy(group);
        EFGenericRepository.Update(_groupBoardSecond.CurrentGroup);
        return true;
      }

      return false;
    }

    private void GroupBoardSecond_CancelClick(object sender, EventArgs e)
    {
      //todo ??
      foreach (var addedStudentView in _groupBoardSecond.AddedStudentControlCollection.Cast<AddedStudentViewBoard>().ToArray())
      {
        if (EFGenericRepository.Find<Student>(addedStudentView.Id).Group == null)
        {
          CancelButton_Click(addedStudentView, EventArgs.Empty);
        }
      }
    }

    public override async void GroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
    {
      await _groupBoardSecond.CurrentStudentControlCollection.AddControls(
          EFGenericRepository.Get<Student>(s => s.Group == null).ToArray(),
          currentStudentView,
          CancellationToken.None);
    }

    public async override Task<Student[]> GetStudentWithExceptedAddedStudent(string condition, string searchCriteria, CancellationToken token)
    {
      return await Task.Factory.StartNew(() =>
      {
        var students = (IEnumerable<Student>)EFGenericRepository.Get<Student>(s => s.Group == null).ToArray();

        var existGroup = EFGenericRepository.Get<Group>(g => g.Name == groupBoard.GetNameOfGroup).FirstOrDefault();
        var currentStudent = existGroup?.Students;
        if (currentStudent != null)
          students = students.Union(currentStudent);

        if (condition != string.Empty)
          students = students.Where(searchCriteria, condition);


        if (groupBoard.AddedStudentControlCollection.Count == 0)
          return students.ToArray();
        
        var addedStudents = groupBoard.AddedStudentControlCollection
          .Cast<IStudentView>()
          .Select(s => EFGenericRepository.Find<Student>(s.Id));

        return students.Except(addedStudents).ToArray();
      }, token);
    }

    #endregion
  }
}
