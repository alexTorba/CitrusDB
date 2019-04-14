using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups.GroupsView.GroupInfo;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter.Groups
{
  class GroupInfoFormPresenter
  {
    private readonly IGroupInfoForm _groupInfoForm;
    private TaskInfo _currentTask;

    public GroupInfoFormPresenter(IGroupInfoForm groupInfoForm)
    {
      _groupInfoForm = groupInfoForm;

      _groupInfoForm.LoadForm += GroupInfoForm_LoadForm;
      _groupInfoForm.HeaderMouseClick += GroupInfoForm_HeaderMouseClick;
      _groupInfoForm.SearchTextChanged += GroupInfoForm_SearchTextChanged;
    }

    private void GroupInfoForm_SearchTextChanged(object sender, EventArgs e)
    {
      _currentTask?.CancelTask();

      _currentTask = new TaskInfo(SearchStudent, sender);
    }

    private async void SearchStudent(object sender, CancellationToken token)
    {
      try
      {
        _groupInfoForm.DisablingGrid();

        _groupInfoForm.Students = await GetStudent((sender as TextBox).Text, token);
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
      finally
      {
        _groupInfoForm.EnablingGrid();
      }
      Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
    }

    private async Task<IEnumerable<StudentView>> GetStudent(string conditions, CancellationToken token)
    {
      return await Task.Run(() =>
      {
        if (conditions != string.Empty)
          return EFGenericRepository.Find<Group>(_groupInfoForm.Id)
                                                  .Students
                                                  .GetViews<Student, StudentView>()
                                                  .Where(s => s.FirstName.ToUpperInvariant()
                                                  .Contains(conditions.ToUpperInvariant()))
                                                  .ToArray();

        return EFGenericRepository.Find<Group>(_groupInfoForm.Id)
                          .Students
                          .GetViews<Student, StudentView>()
                          .ToArray();
      }, token);
    }

    private void GroupInfoForm_HeaderMouseClick(object sender, OrderByEventArgs e)
    {
      _groupInfoForm.Students = ((ICollection<StudentView>)_groupInfoForm.Students)
                                          .OrderBy(e.OrderCriteria)
                                          .ToList();
    }

    private void GroupInfoForm_LoadForm(object sender, EventArgs e)
    {
      var group = EFGenericRepository.Find<Group>(_groupInfoForm.Id);
      _groupInfoForm.GroupName = group.Name;
      _groupInfoForm.Photo = group.Photo.ConvertByteArrToImage();
      _groupInfoForm.Students = group.Students.GetViews<Student, StudentView>().ToList();
    }
  }
}
