using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace CitrusDB.Presenter.Groups
{
    class EditGroupBoardFirstPresenter
    {

        TaskInfo currentTask = null;
        readonly IEditGroupBoardFirst editGroupBoardFirst;
        readonly IGroupView groupView;

        public EditGroupBoardFirstPresenter(IEditGroupBoardFirst editGroupBoardFirst, IGroupView groupView)
        {
            this.editGroupBoardFirst = editGroupBoardFirst;
            this.groupView = groupView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            editGroupBoardFirst.LoadEditGroupBoardFirst += EditGroupBoardFirst_LoadEditGroupBoardFirst;
            editGroupBoardFirst.EditGroupButtonClick += EditGroupBoardFirst_EditGroupButtonClick;
            editGroupBoardFirst.UpdateView += EditGroupBoardFirst_UpdateView;
            editGroupBoardFirst.SearchBoxTextChanged += EditGroupBoardFirst_SearchBoxTextChanged;

            groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
        }

        #region Event Handlers

        private void EditGroupBoardFirst_SearchBoxTextChanged(object sender, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchGroup, sender);
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
            foreach (var groupView in editGroupBoardFirst.GroupCollection.Cast<IGroupView>())
                groupView.ChangeColorToBase();

            if (sender is IGroupView group)
                editGroupBoardFirst.GroupId = group.Id;
        }

        private void EditGroupBoardFirst_EditGroupButtonClick(object sender, EventArgs e)
        {
            var selectedGroup = editGroupBoardFirst.GroupCollection
                .Cast<IGroupView>()
                .FirstOrDefault(gv => gv.IsSelected == true);

            if (selectedGroup != null)
            {
                editGroupBoardFirst.EditGroup = EFGenericRepository.Find<Group>(selectedGroup.Id);

                editGroupBoardFirst.LoadingSecondForm();
            }
        }

        private void EditGroupBoardFirst_LoadEditGroupBoardFirst(object sender, EventArgs e)
        {
            IList<Group> groups = EFGenericRepository.Get<Group>().ToArray();
            var listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Length; i++)
            {
                var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

                editGroupBoardFirst.GroupCollection.Add((Control)groupView);
            }
        }

        #endregion

        private async void SearchGroup(object sender, CancellationToken token)
        {
            try
            {
                Group[] result = await GetGroups((sender as TextBox).Text, token);

                await editGroupBoardFirst
                    .GroupCollection
                    .FillControlCollectionForSearch(result, groupView, token);

                editGroupBoardFirst.GroupCollection
                    .Cast<IGroupView>()
                    .FirstOrDefault(g => g.Id == editGroupBoardFirst.GroupId)
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
                .Where(s => !editGroupBoardFirst.GroupCollection.IsContaintControl<Group>(s.Id))
                .ToArray();
            });

            editGroupBoardFirst.GroupCollection.AddControls(groups, groupView, token);
        }

        private async Task DeleteControlsFromControlCollection(IList<Group> groups, CancellationToken token)
        {
            await editGroupBoardFirst.GroupCollection.DeleteControls(
                groups,
                EFGenericRepository.Get<Group>(),
                token);
        }

        private async Task UpdateControlFromControlColletion(IList<Group> groups, CancellationToken token)
        {
            await editGroupBoardFirst.GroupCollection.UpdateControls(
                groups,
                groupView,
                token);
        }

    }
}
