using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups.AddGroup;
using CitrusDB.View.Students;

namespace CitrusDB.Presenter.Groups
{
  class AddGroupBoardPresenter : GroupBoardPresenter
  {
    private readonly IAddGroupBoard _addGroupBoard;

    public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView currentStudentView,
      IStudentView addedStudentView)
      : base(addGroupBoard, currentStudentView, addedStudentView)
    {
      _addGroupBoard = addGroupBoard;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _addGroupBoard.ClearClick += AddGroupBoard_ClearClick;
      _addGroupBoard.SaveClick += AddGroupBoard_SaveClick;
    }

    #region Event Handlers

    private bool AddGroupBoard_SaveClick()
    {
      if (string.IsNullOrWhiteSpace(_addGroupBoard.GetNameOfGroup) ||
          _addGroupBoard.GetGroupPhoto == null ||
          _addGroupBoard.AddedStudentControlCollection.Count == 0)
        return false;

      var students = new List<Student>();

      foreach (IStudentView studentView in _addGroupBoard.AddedStudentControlCollection)
        students.Add(EFGenericRepository.Find<Student>(studentView.Id));

      var group = new Group
      {
        Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
        Name = _addGroupBoard.GetNameOfGroup,
        Students = students,
        Photo = _addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
      };

      EFGenericRepository.Create(group);

      _addGroupBoard.ClearView();
      _addGroupBoard.AddedStudentControlCollection.Clear();

      return true;
    }

    private void AddGroupBoard_ClearClick(object sender, EventArgs e)
    {
      _addGroupBoard.ClearView();

      if (_addGroupBoard.AddedStudentControlCollection.Count != 0)
      {
        foreach (var obj in _addGroupBoard.AddedStudentControlCollection)
        {
          var control = obj as Control;

          var studentView = (IStudentView) currentStudentView.Clone();
          studentView.FillView(EFGenericRepository.Find<Student>(
            ((IStudentView) control).Id));

          _addGroupBoard.CurrentStudentControlCollection.Add((Control) studentView);
        }

        _addGroupBoard.AddedStudentControlCollection.Clear();
      }
    }

    #endregion
  }
}