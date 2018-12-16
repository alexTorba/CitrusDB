using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.View.Groups;
using CitrusDB.View.Students;

namespace CitrusDB.Presenter.Groups
{
    abstract class GroupBoardPresenter
    {
        TaskInfo currentTask = null;
        protected readonly IGroupBoard groupBoard;
        protected readonly IStudentView currentStudentView;
        protected readonly IStudentView addedStudentView;

        public GroupBoardPresenter(IGroupBoard groupBoard, IStudentView currentStudentView, IStudentView addedStudentView)
        {
            this.groupBoard = groupBoard;
            this.currentStudentView = currentStudentView;
            this.addedStudentView = addedStudentView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            groupBoard.ChangeAddedStudentPanelControl += GroupBoard_ChangeAddedStudentPanelControl;
            groupBoard.CurrentStudentSearchTextBoxChanges += GroupBoard_CurrentStudentSearchTextBoxChanges;
            groupBoard.LoadGroupBoard += GroupBoard_LoadAddGroupBoard;
            groupBoard.UpdateView += GroupBoard_UpdateView;
            groupBoard.OrderBy += GroupBoard_OrderBy;

            currentStudentView.Click += AddStudentButton_Click;
            addedStudentView.Click += CancelButton_Click;
        }

        #region Event Handlers

        private async void GroupBoard_OrderBy(object sender, OrderByEventArgs e)
        {
            var students = await groupBoard
                                    .CurrentStudentControlCollection
                                    .TransformControlsToEntitiesAsync<Student>(CancellationToken.None);

            if (e.IsAscending)
                students = students.OrderBy(e.OrderCriteria).ToArray();
            else
                students = students.OrderByDescending(e.OrderCriteria).ToArray();

            groupBoard.CurrentStudentControlCollection.Clear();

            await FillControlCollection(students, CancellationToken.None);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //получаем addedStudentView на котором было вызвано событие button_Click
            IStudentView addedStudentView = (IStudentView)((Control)sender).Parent;

            IStudentView studentView = (IStudentView)this.currentStudentView.Clone();
            studentView.FillView(EFGenericRepository.Find<Student>(addedStudentView.Id));

            groupBoard.AddedStudentControlCollection.Remove((Control)addedStudentView);
            groupBoard.CurrentStudentControlCollection.Add((Control)studentView);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //получаем studentViewBoard на котором было вызвано событие button_Click
            IStudentView studentViewBoard = (IStudentView)((Control)sender).Parent;

            //создаем addedStudentViewBoard (клонируем переданный экземпляр конкретного класса)
            IStudentView addedStudentView = (IStudentView)this.addedStudentView.Clone();
            //заполняем addedStudentViewBoard полями studentViewBoard на котороым было вызвано событие Click
            addedStudentView.FillView(EFGenericRepository.Find<Student>(studentViewBoard.Id));

            groupBoard.CurrentStudentControlCollection.Remove((Control)studentViewBoard);
            groupBoard.AddedStudentControlCollection.Add((Control)addedStudentView);
        }

        private async void GroupBoard_UpdateView(object sender, EventArgs e)
        {
            groupBoard.DisableCurrentStudentPanel();
            groupBoard.DisableAddedStudentPanel();

            await AddControlsToControlCollection(
              EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Added, s => s.Group == null).ToArray(),
              CancellationToken.None);

            //для студентов, которые были загружены с бд и в процессе были исключены из группы
            await AddControlsToControlCollection(
                EFGenericRepository.Get<Student>(s => s.Group == null).ToArray(),
                CancellationToken.None);

            await DeleteControlsFromControlCollection(
                    EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Deleted, s => s.Group == null),
                    CancellationToken.None);

            await UpdateControlsFromControlCollection(
                EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Modified).ToArray(),
                CancellationToken.None);

            groupBoard.EnableCurrentStudentPanel();
            groupBoard.EnableAddedStudentPanel();
        }

        public virtual void GroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            IList<Student> students = EFGenericRepository.Get<Student>(s => s.Group == null).ToArray();

            FillInitControlCollection(students, CancellationToken.None);
        }

        private void GroupBoard_CurrentStudentSearchTextBoxChanges(string condition, string searchCriteria, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchStudent, condition, searchCriteria);
        }

        private void GroupBoard_ChangeAddedStudentPanelControl(object sender, EventArgs e)
        {
            groupBoard.CountOfAddedStudent =
                groupBoard.AddedStudentControlCollection.Count.ToString();
        }

        #endregion

        private async void SearchStudent(string condition, string searchCriteria, CancellationToken token)
        {
            try
            {
                groupBoard.DisableCurrentStudentPanel();

                Student[] result = await GetStudentWithExceptedAddedStudent(condition, searchCriteria, token);

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
            finally
            {
                groupBoard.EnableCurrentStudentPanel();
            }

            Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
        }

        /// <summary>
        /// Асинхронный выбор студентов, учитывая фильтр (searchTextBox.Text) и вычитание из результата уже добавленных студентов(addedStudentFlowPanel).
        /// </summary>
        /// <param name="condition">Условие, по которому будет формироваться выборка студентов.</param>
        /// <returns></returns>
        public virtual async Task<Student[]> GetStudentWithExceptedAddedStudent(string condition, string searchCriteria, CancellationToken token)
        {
            return await Task.Factory.StartNew(() =>
            {
                IEnumerable<Student> students = EFGenericRepository.Get<Student>(s => s.Group == null).ToArray();

                if (condition != string.Empty)
                    students = students
                               .Where(searchCriteria, condition);


                if (groupBoard.AddedStudentControlCollection.Count == 0)
                    return students.ToArray();
                else
                {
                    var addedStudents = groupBoard.AddedStudentControlCollection
                                       .Cast<IStudentView>()
                                       .Select(s => EFGenericRepository.Find<Student>(s.Id));

                    return students.Except(addedStudents).ToArray();
                }
            }, token);

        }

        /// <summary>
        /// Асинхронное заполнение CurrentStudentControlCollection.
        /// </summary>
        /// <param name="students">Коллекция, которая будет трансформироваться в StudentViewBoard и помещаться в CurrentStudentControlCollection</param>
        /// <returns></returns>
        private async Task FillControlCollection(IList<Student> students, CancellationToken token)
        {
            await groupBoard
                 .CurrentStudentControlCollection
                 .FillControlCollectionForSearch(students, currentStudentView, token);
        }

        private async void FillInitControlCollection(IList<Student> students, CancellationToken token)
        {
            if (students.Count == 0)
                return;

            await groupBoard.CurrentStudentControlCollection.AddControls(students, currentStudentView, token);
        }

        #region Updating

        private async Task AddControlsToControlCollection(IList<Student> students, CancellationToken token)
        {
            Control[] controls = null;

            await Task.Factory.StartNew(() =>
            {
                if (students.Count == 0)
                    return;

                // except exist student in both ControlCollections
                students = students
                .Where(s => !groupBoard.CurrentStudentControlCollection.IsContaintControl<Student>(s.Id) &&
                !groupBoard.AddedStudentControlCollection.IsContaintControl<Student>(s.Id))
                .ToArray();

                controls = students.CreateControlCollection(currentStudentView, token);
            });

            if (controls != null)
                groupBoard.CurrentStudentControlCollection.AddRange(controls);
        }

        private async Task DeleteControlsFromControlCollection(IEnumerable<Student> students, CancellationToken token)
        {
            await groupBoard.AddedStudentControlCollection.DeleteControls(
                students,
                EFGenericRepository.Get<Student>(),
                token);

            await groupBoard.CurrentStudentControlCollection.DeleteControls(
                students,
                EFGenericRepository.Get<Student>(),
                token);
        }

        private async Task UpdateControlsFromControlCollection(IList<Student> students, CancellationToken token)
        {
            if (students.Count == 0)
                return;

            await DeleteControlsFromControlCollection(students.Where(s => s.Group != null).ToArray(), token);

            var studentWithoutGroup = students.Where(s => s.Group == null).ToArray();

            await groupBoard.AddedStudentControlCollection.UpdateControls(
                studentWithoutGroup,
                addedStudentView,
                token
                );

            await groupBoard.CurrentStudentControlCollection.UpdateControls(
                studentWithoutGroup,
                currentStudentView,
                token
                );
        }

        #endregion

    }
}
