using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddStudent;
using CitrusDB.View.AddStudent.GroupViews;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Extensions;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CitrusDB.Presenter
{
    class AddStudentBoardPresenter
    {

        TaskInfo currentTask = null;

        readonly IAddStudentBoard addStudentBoard;
        readonly IGroupView groupView;
        Validate validate = new Validate();

        public AddStudentBoardPresenter(IAddStudentBoard addStudentBoard, IGroupView groupView)
        {
            this.addStudentBoard = addStudentBoard;
            this.groupView = groupView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            groupView.ClearOtherBoard += GroupView_ClearOtherBoard;

            addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
            addStudentBoard.ClearButton += AddStudentBoard_ClearButton;
            addStudentBoard.GenerateButton += AddStudentBoard_GenerateButton;

            addStudentBoard.LoadBoard += AddStudentBoard_LoadBoard;
            addStudentBoard.ControlEnter += AddStudentBoard_ControlEnter;

            addStudentBoard.TextBoxTextChanged += AddStudentBoard_TextBoxTextChanged;

            addStudentBoard.ComboBoxTextUpdate += AddStudentBoard_ComboBoxTextUpdate;
            addStudentBoard.ComboBoxSelectionChange += AddStudentBoard_ComboBoxSelectionChange;

            addStudentBoard.PhotoLoaded += AddStudentBoard_PhotoLoaded;

            addStudentBoard.UpdateView += AddStudentBoard_UpdateView;

            addStudentBoard.SearchBox_TextChange += AddStudentBoard_SearchBox_TextChange;

            addStudentBoard.MonthCalendarDateChange += AddStudentBoard_MonthCalendarDateChange;
            addStudentBoard.MonthCalendarDateSelected += AddStudentBoard_MonthCalendarDateSelected;
            addStudentBoard.MonthCalendarEnter += AddStudentBoard_MonthCalendarEnter;
        }

        #region Event Handlers

        private void AddStudentBoard_SearchBox_TextChange(object sender, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchGroup, sender);
        }

        private async void SearchGroup(object sender, CancellationToken token)
        {
            try
            {
                addStudentBoard.DisableViewsPanel();

                Group[] result = await GetGroups((sender as TextBox).Text, token);

                await addStudentBoard.GroupsCollection.FillControlCollectionForSearch(result, groupView, token);
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
                if (addStudentBoard.ProgressBarValue == 100)
                    addStudentBoard.EnableViewsPanel();
            }
        }

        private async void AddStudentBoard_UpdateView(object sender, EventArgs e)
        {
            await AddControlsToControlCollection(
                  EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Added).ToArray(),
                  new CancellationToken());

            await DeleteControlsFromControlCollection(
                 EFGenericRepository.GetEntitiesWithState<Group>(EntityState.Deleted).ToArray(),
                 new CancellationToken());
        }

        private void GroupView_ClearOtherBoard(object sender, EventArgs e)
        {
            foreach (var groupView in addStudentBoard.GroupsCollection.Cast<IGroupView>())
                groupView.ChangeColorToBase();
        }

        private void AddStudentBoard_GenerateButton(object sender, EventArgs e)
        {
            AddStudentBoard_ClearButton(null, EventArgs.Empty);

            (string p1, string p2) = Generate.GetPhotos();

            foreach (Control control in addStudentBoard.GetBoardControls)
            {
                if (control is TextBox textBox)
                {
                    AddStudentBoard_ControlEnter(textBox, EventArgs.Empty);
                    textBox.FillControl();
                }
                else if (control is ComboBox comboBox)
                {
                    AddStudentBoard_ControlEnter(comboBox, EventArgs.Empty);
                    comboBox.FillControl();
                    AddStudentBoard_ComboBoxSelectionChange(comboBox, EventArgs.Empty);
                }
                else if (control is PictureBox pictureBox)
                {
                    AddStudentBoard_ControlEnter(pictureBox, EventArgs.Empty);

                    if (pictureBox.Name == "pictureBoxFirstPhoto")
                        pictureBox.Load(p1);
                    else
                        pictureBox.Load(p2);

                    AddStudentBoard_PhotoLoaded(pictureBox, EventArgs.Empty);
                    addStudentBoard.HidePhotoLabels();
                }
                else if (control is MonthCalendar monthCalendar)
                {
                    var time = Generate.GenerateDateTime();
                    monthCalendar.SelectionRange = new SelectionRange(time, time);
                    addStudentBoard.SetInitDate();
                    monthCalendar.Select();

                    AddStudentBoard_MonthCalendarDateSelected(monthCalendar, EventArgs.Empty);
                }
            }
        }

        #region MonthCalendar

        private void AddStudentBoard_MonthCalendarEnter(object sender, EventArgs e)
        {
            if (sender is MonthCalendar monthCalendar)
            {
                validate.SetState(monthCalendar.SelectionRange.ToString() == monthCalendar.Tag.ToString(), true);
            }
        }

        private void AddStudentBoard_MonthCalendarDateSelected(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as MonthCalendar);
        }

        private void AddStudentBoard_MonthCalendarDateChange(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as MonthCalendar);
        }

        #endregion

        #region ComboBox

        private void AddStudentBoard_ComboBoxSelectionChange(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as ComboBox);
        }

        private void AddStudentBoard_ComboBoxTextUpdate(object sender, EventArgs e)
        {
            ControlHaveMistake(sender as ComboBox);
        }

        #endregion

        #region TextBox

        private void AddStudentBoard_TextBoxTextChanged(object sender, EventArgs e)
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

        #endregion

        #region Buttons

        private void AddStudentBoard_ClearButton(object sender, EventArgs e)
        {
            addStudentBoard.SetInitDate();

            addStudentBoard.ProgressBarValue = 0;

            GroupView_ClearOtherBoard(null, EventArgs.Empty);

            validate.Reset();

            addStudentBoard.ResetControls();
        }

        private void AddStudentBoard_SaveButton(object sender, EventArgs e)
        {
            var selectedGroup = addStudentBoard.GroupsCollection
                .Cast<IGroupView>()
                .FirstOrDefault(gv => gv.IsSelected == true);

            Student student = new Student
            {
                Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
                FirstName = addStudentBoard.GetFirstName.Trim(),
                LastName = addStudentBoard.GetLastName.Trim(),
                MiddleName = addStudentBoard.GetMiddleName.Trim(),
                Сitizenship = addStudentBoard.GetCitizenship.Trim(),
                FirstPhoto = addStudentBoard.GetFirstPhoto.ConvertImageToByteArr(),
                SecondPhoto = addStudentBoard.GetSecondPhoto.ConvertImageToByteArr(),
                DateOfBirth = addStudentBoard.DateOfBirth.Trim(),
                Height = addStudentBoard.GetGrowth,
                Weight = addStudentBoard.GetWeight,
                KnowledgeOfLanguage = addStudentBoard.GetKnowledgeOfLanguage.Trim(),
                Group = selectedGroup == null ? null : EFGenericRepository.FindById<Group>(selectedGroup.Id)
            };

            EFGenericRepository.Create(student);
        }

        #endregion

        #region PictureBox

        private void AddStudentBoard_PhotoLoaded(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as PictureBox);
        }

        #endregion

        private void AddStudentBoard_ControlEnter(object sender, EventArgs e)
        {
            if (sender is Control control)
                validate.SetState(control.HaveMistake());
        }

        private void AddStudentBoard_LoadBoard(object sender, EventArgs e)
        {
            IList<Group> groups = EFGenericRepository.Get<Group>().ToArray();
            var listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Length; i++)
            {
                var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

                addStudentBoard.GroupsCollection.Add((Control)groupView);
            }
        }

        #endregion

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
                .Where(s => !addStudentBoard.GroupsCollection.IsContaintControl<Group>(s.Id))
                .ToArray();
            });

            addStudentBoard.GroupsCollection.AddControls(groups, groupView, token);
        }

        private async Task DeleteControlsFromControlCollection(IList<Group> groups, CancellationToken token)
        {
            await addStudentBoard.GroupsCollection.DeleteControls(
                groups, 
                EFGenericRepository.Get<Group>(),
                token);
        }

        private void ControlIsConfirmed(Control control)
        {
            if (control != null)
            {
                addStudentBoard.ProgressBarValue =
                            validate.FillingProgressBarLogic(addStudentBoard.ProgressBarValue, 10);

                control.RemoveMistakeToLinkedLabel();
            }
        }

        private void ControlHaveMistake(Control control)
        {
            if (control != null)
            {
                addStudentBoard.ProgressBarValue =
                            validate.DecreaseProgressBarLogic(addStudentBoard.ProgressBarValue, 10);

                control.AddMistakeToLinkedLabel();
            }
        }

    }
}
