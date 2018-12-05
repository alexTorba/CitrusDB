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

        protected TaskInfo currentTask = null;
        readonly IStudentBoard studentBoard;
        readonly IGroupView groupView;
        protected readonly Validate validate = new Validate();

        public StudentBoardPresenter(IStudentBoard studentBoard, IGroupView groupView)
        {
            this.studentBoard = studentBoard;
            this.groupView = groupView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            #region StudentBoard

            studentBoard.ComboBoxSelectionChange += StudentBoard_ComboBoxSelectionChange;
            studentBoard.ComboBoxTextUpdate += StudentBoard_ComboBoxTextUpdate;

            studentBoard.ControlEnter += StudentBoard_ControlEnter;

            studentBoard.LoadBoard += StudentBoard_LoadBoard;

            studentBoard.MonthCalendarDateChange += StudentBoard_MonthCalendarDateChange;
            studentBoard.MonthCalendarDateSelected += StudentBoard_MonthCalendarDateSelected;
            studentBoard.MonthCalendarEnter += StudentBoard_MonthCalendarEnter;

            studentBoard.PhotoLoaded += StudentBoard_PhotoLoaded;

            studentBoard.SearchBox_TextChange += StudentBoard_SearchBox_TextChange;
            studentBoard.TextBoxTextChanged += StudentBoard_TextBoxTextChanged;

            studentBoard.UpdateView += StudentBoard_UpdateView;

            #endregion

            groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
        }

        #region IStudentBoard

        protected void GroupView_ClearOtherBoard(object sender, EventArgs e)
        {
            foreach (var groupView in studentBoard.GroupsCollection.Cast<IGroupView>())
                groupView.ChangeColorToBase();

            if (sender is IGroupView view)
                studentBoard.GroupId = view.Id;

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
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchGroup, sender);
        }

        protected void StudentBoard_PhotoLoaded(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as PictureBox);
        }

        private void StudentBoard_MonthCalendarEnter(object sender, EventArgs e)
        {
            if (sender is MonthCalendar monthCalendar)
            {
                validate.SetState(monthCalendar.SelectionRange.ToString() == monthCalendar.Tag.ToString(), true);
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
            IList<Group> groups = EFGenericRepository.Get<Group>().ToArray();
            var listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Length; i++)
            {
                var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

                studentBoard.GroupsCollection.Add((Control)groupView);
            }
        }

        protected void StudentBoard_ControlEnter(object sender, EventArgs e)
        {
            if (sender is Control control)
                validate.SetState(control.HaveMistake());
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
                studentBoard.DisableViewsPanel();

                Group[] result = await GetGroups((sender as TextBox).Text, token);

                await studentBoard.GroupsCollection.FillControlCollectionForSearch(result, groupView, token);

                studentBoard.GroupsCollection
                    .Cast<IGroupView>()
                    .FirstOrDefault(g => g.Id == studentBoard.GroupId)
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
            finally
            {
                if (studentBoard.ProgressBarValue == 100)
                    studentBoard.EnableViewsPanel();
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
                .Where(s => !studentBoard.GroupsCollection.IsContaintControl<Group>(s.Id))
                .ToArray();
            });

            studentBoard.GroupsCollection.AddControls(groups, groupView, token);
        }

        private async Task DeleteControlsFromControlCollection(IList<Group> groups, CancellationToken token)
        {
            await studentBoard.GroupsCollection.DeleteControls(
                groups,
                EFGenericRepository.Get<Group>(),
                token);
        }

        private async Task UpdateControlFromControlCollection(IList<Group> groups, CancellationToken token)
        {
            await studentBoard.GroupsCollection.UpdateControls(
                groups,
                groupView,
                token);
        }

        private void ControlIsConfirmed(Control control)
        {
            if (control != null)
            {
                studentBoard.ProgressBarValue =
                            validate.FillingProgressBarLogic(studentBoard.ProgressBarValue, 10);

                control.RemoveMistakeToLinkedLabel();
            }
        }

        private void ControlHaveMistake(Control control)
        {
            if (control != null)
            {
                studentBoard.ProgressBarValue =
                            validate.DecreaseProgressBarLogic(studentBoard.ProgressBarValue, 10);

                control.AddMistakeToLinkedLabel();
            }
        }

    }
}
