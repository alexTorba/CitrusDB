using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CitrusDB.Model;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.View.Students.EditStuden;
using CitrusDB.View.Students;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter.Students
{
  class EditStudentBoardFirstPresenter
  {
    private TaskInfo _currentTask;

    private readonly IEditStudentBoardFirst _editStudentBoardFirst;
    private readonly IStudentView _editStudentView;

    public EditStudentBoardFirstPresenter(IEditStudentBoardFirst editStudentBoardFirst, IStudentView editStudentView)
    {
      _editStudentBoardFirst = editStudentBoardFirst;
      _editStudentView = editStudentView;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _editStudentBoardFirst.LoadEditStudentBoardFirst += EditStudentBoardFirst_LoadEditStudentBoardFirst;
      _editStudentBoardFirst.UpdateView += EditStudentBoardFirst_UpdateView;
      _editStudentBoardFirst.StudentSearchTextBoxChanges += EditStudentBoardFirst_StudentSearchTextBoxChanges;
      _editStudentBoardFirst.OrderBy += EditStudentBoardFirst_OrderBy;

      _editStudentView.Click += EditStudentView_Click;
    }

    private async void EditStudentBoardFirst_OrderBy(object sender, OrderByEventArgs e)
    {
      var students = await _editStudentBoardFirst
        .StudentControlCollection
        .TransformControlsToEntitiesAsync<Student>(CancellationToken.None);

      if (e.IsAscending)
        students = students.OrderBy(e.OrderCriteria).ToArray();
      else
        students = students.OrderByDescending(e.OrderCriteria).ToArray();

      _editStudentBoardFirst.StudentControlCollection.Clear();

      await FillControlCollection(students, CancellationToken.None);
    }

    #region EventHandlers

    private async void EditStudentBoardFirst_UpdateView(object sender, EventArgs e)
    {
      _editStudentBoardFirst.DisablingControlCollection();

      await AddControlsToControlCollection(
        EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Added).ToArray(),
        CancellationToken.None);

      await DeleteControlsFromControlCollection(
        EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Deleted),
        CancellationToken.None);

      await UpdateControlsFromControlCollection(
        EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Modified).ToArray(),
        CancellationToken.None);

      _editStudentBoardFirst.EnablingControlCollection();
    }

    private void EditStudentBoardFirst_LoadEditStudentBoardFirst(object sender, EventArgs e)
    {
      var students = EFGenericRepository.Get<Student>().ToArray();
      var studentControls = _editStudentView.CreateListViews(students.Length);

      for (int i = 0; i < students.Length; i++)
      {
        _editStudentBoardFirst.StudentControlCollection.Add((Control) studentControls[i].FillView(students[i]));
      }
    }

    private void EditStudentBoardFirst_StudentSearchTextBoxChanges(string condition, string searchCriteria, EventArgs e)
    {
      _currentTask?.CancelTask();

      _currentTask = new TaskInfo(SearchStudent, condition, searchCriteria);
    }

    #endregion

    private async void SearchStudent(string condition, string searchCriteria, CancellationToken token)
    {
      try
      {
        var result = GetStudentsWithConditions(condition, searchCriteria);
        await FillControlCollection(result, token);
      }
      catch (OperationCanceledException canceledEx)
      {
        Console.WriteLine(canceledEx.Message);
        return;
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }

      Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
    }

    private Student[] GetStudentsWithConditions(string condition, string searchCriteria)
    {
      if (condition == string.Empty)
        return EFGenericRepository.Get<Student>().ToArray();

      return EFGenericRepository.Get<Student>()
        .Where(searchCriteria, condition)
        .ToArray();
    }

    /// <summary>
    /// Асинхронное заполнение CurrentStudentControlCollection.
    /// </summary>
    /// <param name="students">Коллекция, которая будет трансформироваться в StudentViewBoard и помещаться в CurrentStudentControlCollection</param>
    /// <returns></returns>
    private async Task FillControlCollection(IList<Student> students, CancellationToken token)
    {
      await _editStudentBoardFirst
        .StudentControlCollection
        .FillControlCollectionForSearch(students, _editStudentView, token);
    }

    private void EditStudentView_Click(object sender, EventArgs e)
    {
      _editStudentBoardFirst.EditStudent =
        EFGenericRepository.Find<Student>(((IStudentView) ((Control) sender).Parent).Id);

      _editStudentBoardFirst.LoadingSecondForm();
    }


    private async Task AddControlsToControlCollection(IList<Student> students, CancellationToken token)
    {
      await Task.Factory.StartNew(() =>
      {
        if (students.Count == 0)
          return;

        // except exist student in both ControlCollections
        students = students
          .Where(s => !_editStudentBoardFirst.StudentControlCollection.IsContainControl<Student>(s.Id))
          .ToArray();
      }, token);

      await _editStudentBoardFirst.StudentControlCollection.AddControls(students, _editStudentView, token);
    }

    private async Task DeleteControlsFromControlCollection(IEnumerable<Student> students, CancellationToken token)
    {
      await _editStudentBoardFirst.StudentControlCollection
        .DeleteControls(students, EFGenericRepository.Get<Student>(), token);
    }

    private async Task UpdateControlsFromControlCollection(IList<Student> students, CancellationToken token)
    {
      if (students.Count == 0)
        return;

      await _editStudentBoardFirst.StudentControlCollection.UpdateControls(students, _editStudentView, token);
    }
  }
}