using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CitrusDB.View.Groups.EditGroup;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using System.Windows.Forms;
using System.Threading;
using System.Data.Entity;
using CitrusDB.Model;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter.Groups
{
  class EditGroupBoardFirstPresenter
  {
    private TaskInfo _currentTask = null;
    private readonly IEditGroupBoardFirst _editGroupBoardFirst;
    private readonly IGroupView _groupView;

    public EditGroupBoardFirstPresenter(IEditGroupBoardFirst editGroupBoardFirst, IGroupView groupView)
    {
      _editGroupBoardFirst = editGroupBoardFirst;
      _groupView = groupView;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _editGroupBoardFirst.LoadEditGroupBoardFirst += EditGroupBoardFirst_LoadEditGroupBoardFirst;
      _editGroupBoardFirst.EditGroupButtonClick += EditGroupBoardFirst_EditGroupButtonClick;
      _editGroupBoardFirst.UpdateView += EditGroupBoardFirst_UpdateView;
      _editGroupBoardFirst.SearchBoxTextChanged += EditGroupBoardFirst_SearchBoxTextChanged;
      _editGroupBoardFirst.OrderBy += EditGroupBoardFirst_OrderBy;

      _groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
    }

    #region Event Handlers

    private async void EditGroupBoardFirst_OrderBy(object sender, OrderByEventArgs e)
    {
      var groups = await _editGroupBoardFirst
                                  .GroupCollection
                                  .TransformControlsToEntitiesAsync<Group>(CancellationToken.None);

      if (e.IsAscending)
        groups = groups.OrderBy(e.OrderCriteria).ToArray();
      else
        groups = groups.OrderByDescending(e.OrderCriteria).ToArray();

      _editGroupBoardFirst.GroupCollection.Clear();

      await _editGroupBoardFirst.GroupCollection.AddControls(groups, _groupView, CancellationToken.None);

      _editGroupBoardFirst.GroupCollection
              .Cast<IGroupView>()
              .FirstOrDefault(g => g.Id == _editGroupBoardFirst.GroupId)
              ?.SelectView();
    }

    private void EditGroupBoardFirst_SearchBoxTextChanged(object sender, EventArgs e)
    {
      _currentTask?.CancelTask();

      _currentTask = new TaskInfo(SearchGroup, sender);
    }

    private async void EditGroupBoardFirst_UpdateView(object sender, EventArgs e)
    {
      await AddControlsToControlCollection(
            EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Added).ToArray(),
            CancellationToken.None);

      await DeleteControlsFromControlCollection(
           EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Deleted).ToArray(),
          CancellationToken.None);

      await UpdateControlFromControlColletion(
          EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Modified).ToArray(),
          CancellationToken.None);
    }

    private void GroupView_ClearOtherBoard(object sender, EventArgs e)
    {
      foreach (var groupView in _editGroupBoardFirst.GroupCollection.Cast<IGroupView>())
        groupView.ChangeColorToBase();

      if (sender is IGroupView group)
        _editGroupBoardFirst.GroupId = group.Id;
    }

    private void EditGroupBoardFirst_EditGroupButtonClick(object sender, EventArgs e)
    {
      var selectedGroup = _editGroupBoardFirst.GroupCollection
          .Cast<IGroupView>()
          .FirstOrDefault(gv => gv.IsSelected == true);

      if (selectedGroup != null)
      {
        _editGroupBoardFirst.EditGroup = EFGenericRepository.Find<Group>(selectedGroup.Id);

        _editGroupBoardFirst.LoadingSecondForm();
      }
    }

    private void EditGroupBoardFirst_LoadEditGroupBoardFirst(object sender, EventArgs e)
    {
      var groups = (IList<Group>)EFGenericRepository.Get<Group>().ToList();
      var listGroupViews = _groupView.CreateListViews(groups.Count);

      for (int i = 0; i < listGroupViews.Length; i++)
      {
        var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

        _editGroupBoardFirst.GroupCollection.Add((Control)groupView);
      }
    }

    #endregion

    private async void SearchGroup(object sender, CancellationToken token)
    {
      try
      {
        var result = await GetGroups((sender as TextBox).Text, token);

        await _editGroupBoardFirst
            .GroupCollection
            .FillControlCollectionForSearch(result, _groupView, token);

        _editGroupBoardFirst.GroupCollection
            .Cast<IGroupView>()
            .FirstOrDefault(g => g.Id == _editGroupBoardFirst.GroupId)
            ?.SelectView();
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
        .Where(s => !_editGroupBoardFirst.GroupCollection.IsContainControl<Group>(s.Id))
        .ToArray();
      });

      await _editGroupBoardFirst.GroupCollection.AddControls(groups, _groupView, token);
    }

    private async Task DeleteControlsFromControlCollection(IList<Group> groups, CancellationToken token)
    {
      await _editGroupBoardFirst.GroupCollection.DeleteControls(
          groups,
          EFGenericRepository.Get<Group>(),
          token);
    }

    private async Task UpdateControlFromControlColletion(IList<Group> groups, CancellationToken token)
    {
      await _editGroupBoardFirst.GroupCollection.UpdateControls(
          groups,
          _groupView,
          token);
    }
  }
}
