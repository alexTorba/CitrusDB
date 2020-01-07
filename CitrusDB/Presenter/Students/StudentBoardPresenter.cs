using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.View.Students;
using CitrusDB.Model.Extensions;
using System.Windows.Forms;
using System.Data.Entity;

namespace CitrusDB.Presenter.Students
{
  abstract class StudentBoardPresenter
  {
    private TaskInfo _currentTask;
    protected readonly Validate Validate = new Validate();
    private readonly IStudentBoard _studentBoard;
    private readonly IGroupView _groupView;

    protected StudentBoardPresenter(IStudentBoard studentBoard, IGroupView groupView)
    {
      _studentBoard = studentBoard;
      _groupView = groupView;

      SetHandlers();
    }

    private void SetHandlers()
    {
      #region StudentBoard

      _studentBoard.ComboBoxSelectionChange += StudentBoard_ComboBoxSelectionChange;
      _studentBoard.ComboBoxTextUpdate += StudentBoard_ComboBoxTextUpdate;

      _studentBoard.ControlEnter += StudentBoard_ControlEnter;

      _studentBoard.LoadBoard += StudentBoard_LoadBoard;

      _studentBoard.MonthCalendarDateChange += StudentBoard_MonthCalendarDateChange;
      _studentBoard.MonthCalendarDateSelected += StudentBoard_MonthCalendarDateSelected;
      _studentBoard.MonthCalendarEnter += StudentBoard_MonthCalendarEnter;

      _studentBoard.PhotoLoaded += StudentBoard_PhotoLoaded;

      _studentBoard.SearchBox_TextChange += StudentBoard_SearchBox_TextChange;
      _studentBoard.TextBoxTextChanged += StudentBoard_TextBoxTextChanged;

      _studentBoard.UpdateView += StudentBoard_UpdateView;

      #endregion

      _groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
    }

    #region IStudentBoard

    protected void GroupView_ClearOtherBoard(object sender, EventArgs e)
    {
      foreach (var groupView in _studentBoard.GroupsCollection.Cast<IGroupView>())
        groupView.ChangeColorToBase();

      if (sender is IGroupView view)
        _studentBoard.GroupId = view.Id;
    }

    private async void StudentBoard_UpdateView(object sender, EventArgs e)
    {
      await AddControlsToControlCollection(
            EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Added).ToArray(),
            CancellationToken.None);

      await DeleteControlsFromControlCollection(
           EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Deleted).ToArray(),
          CancellationToken.None);

      await UpdateControlFromControlCollection(
          EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Modified).ToArray(),
          CancellationToken.None);
    }

    private void StudentBoard_TextBoxTextChanged(object sender, EventArgs e)
    {
      if (sender is TextBox textBox)
      {
        if (textBox.CheckText())
        {
          ControlHaveMistake(textBox);
        }
        else
        {
          ControlIsConfirmed(textBox);
        }
      }
    }

    private void StudentBoard_SearchBox_TextChange(object sender, EventArgs e)
    {
      _currentTask?.CancelTask();

      _currentTask = new TaskInfo(SearchGroup, sender);
    }

    protected void StudentBoard_PhotoLoaded(object sender, EventArgs e)
    {
      ControlIsConfirmed(sender as PictureBox);
    }

    private void StudentBoard_MonthCalendarEnter(object sender, EventArgs e)
    {
      if (sender is MonthCalendar monthCalendar)
      {
        Validate.SetState(monthCalendar.SelectionRange.ToString() == monthCalendar.Tag.ToString(), true);
      }
    }

    protected void StudentBoard_MonthCalendarDateSelected(object sender, EventArgs e)
    {
      ControlIsConfirmed(sender as MonthCalendar);
    }

    private void StudentBoard_MonthCalendarDateChange(object sender, EventArgs e)
    {
      ControlIsConfirmed(sender as MonthCalendar);
    }

    private void StudentBoard_LoadBoard(object sender, EventArgs e)
    {
      var groups = (IList<Group>)EFGenericRepository.Get<Group>().ToList();
      var listGroupViews = _groupView.CreateListViews(groups.Count);

      for (var i = 0; i < listGroupViews.Length; i++)
      {
        var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

        _studentBoard.GroupsCollection.Add((Control)groupView);
      }
    }

    protected void StudentBoard_ControlEnter(object sender, EventArgs e)
    {
      if (sender is Control control)
        Validate.SetState(control.HaveMistake());
    }

    private void StudentBoard_ComboBoxTextUpdate(object sender, EventArgs e)
    {
      ControlHaveMistake(sender as ComboBox);
    }

    protected void StudentBoard_ComboBoxSelectionChange(object sender, EventArgs e)
    {
      ControlIsConfirmed(sender as ComboBox);
    }

    #endregion

    private async void SearchGroup(object sender, CancellationToken token)
    {
      try
      {
        _studentBoard.DisableViewsPanel();

        var result = await GetGroups((sender as TextBox).Text, token);

        await _studentBoard.GroupsCollection.FillControlCollectionForSearch(result, _groupView, token);

        _studentBoard.GroupsCollection
            .Cast<IGroupView>()
            .FirstOrDefault(g => g.Id == _studentBoard.GroupId)
            ?.SelectView();
      }
      catch (OperationCanceledException canceledEx)
      {
        Console.WriteLine(canceledEx.Message);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        if (_studentBoard.ProgressBarValue == 100)
          _studentBoard.EnableViewsPanel();
      }
    }

    private async Task<Group[]> GetGroups(string conditions, CancellationToken token)
    {
      return await Task.Run(() =>
      {
        if (conditions != string.Empty)
          return EFGenericRepository.Get<Group>(s => s.Name.ToUpperInvariant()
                                                     .Contains(conditions.ToUpperInvariant()))
                                                     .ToArray();

        return EFGenericRepository.Get<Group>().ToArray();
      }, token);
    }

    private async Task AddControlsToControlCollection(IList<Group> groups, CancellationToken token)
    {
      await Task.Run(() =>
      {
        if (groups.Count == 0)
          return;

        // except exist group in ControlCollections
        groups = groups
        .Where(s => !_studentBoard.GroupsCollection.IsContainControl<Group>(s.Id))
        .ToArray();
      }, token);

      await _studentBoard.GroupsCollection.AddControls(groups, _groupView, token);
    }

    private async Task DeleteControlsFromControlCollection(IList<Group> groups, CancellationToken token)
    {
      await _studentBoard.GroupsCollection.DeleteControls(
          groups,
          EFGenericRepository.Get<Group>(),
          token);
    }

    private async Task UpdateControlFromControlCollection(IList<Group> groups, CancellationToken token)
    {
      await _studentBoard.GroupsCollection.UpdateControls(
          groups,
          _groupView,
          token);
    }

    private void ControlIsConfirmed(Control control)
    {
      if (control == null) 
        return;
      
      _studentBoard.ProgressBarValue = Validate.FillingProgressBarLogic(_studentBoard.ProgressBarValue, 10);
      control.RemoveMistakeToLinkedLabel();
    }

    private void ControlHaveMistake(Control control)
    {
      if (control == null) 
        return;
      
      _studentBoard.ProgressBarValue = Validate.DecreaseProgressBarLogic(_studentBoard.ProgressBarValue, 10);
      control.AddMistakeToLinkedLabel();
    }
  }
}
