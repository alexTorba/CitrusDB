using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.Entity;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups.AddGroup;
using CitrusDB.View.Students;

namespace CitrusDB.Presenter.Groups
{
    class AddGroupBoardPresenter : IDisposable
    {
        TaskInfo currentTask = null;

        readonly IAddGroupBoard addGroupBoard;
        readonly IStudentView currentStudentView;
        readonly IStudentView addedStudentView;

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView studentView,
            IStudentView addedStudentView)
        {
            this.addGroupBoard = addGroupBoard;
            this.currentStudentView = studentView;
            this.addedStudentView = addedStudentView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            addGroupBoard.SaveClick += AddGroupBoard_SaveClick;
            addGroupBoard.ClearClick += AddGroupBoard_ClearClick;
            addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            addGroupBoard.ChangeAddedStudentPanelControl += changeAddedStudentPnanelControl;
            addGroupBoard.CurrentStudentSearchTextBoxChanges += AddGroupBoard_CurrentStudentSearchTextBoxChanges;
            addGroupBoard.UpdateView += AddGroupBoard_UpdateView;

            currentStudentView.Click += AddStudentButton_Click;
            addedStudentView.Click += CancelButton_Click;
        }

        #region Event Handlers

        private async void AddGroupBoard_UpdateView(object sender, EventArgs e)
        {
            addGroupBoard.DisableCurrentStudentPanel();
            addGroupBoard.DisableAddedStudentPanel();

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

            addGroupBoard.EnableCurrentStudentPanel();
            addGroupBoard.EnableAddedStudentPanel();
        }

        private void AddGroupBoard_SaveClick(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView studentView in addGroupBoard.AddedStudentControlCollection)
                students.Add(EFGenericRepository.FindById<Student>(studentView.GetStudentId));

            Group group = new Group
            {
                Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
                Name = addGroupBoard.GetNameOfGroup,
                Students = students,
                Photo = addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
            };

            EFGenericRepository.Create(group);

            addGroupBoard.ClearView();
            addGroupBoard.AddedStudentControlCollection.Clear();
        }

        private void AddGroupBoard_ClearClick(object sender, EventArgs e)
        {
            addGroupBoard.ClearView();

            if (addGroupBoard.AddedStudentControlCollection.Count != 0)
            {
                foreach (var obj in addGroupBoard.AddedStudentControlCollection)
                {
                    Control control = obj as Control;

                    IStudentView studentView = (IStudentView)this.currentStudentView.Clone();
                    studentView.FillView(EFGenericRepository.FindById<Student>(
                        ((IStudentView)control).GetStudentId));

                    addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
                }
                addGroupBoard.AddedStudentControlCollection.Clear();
            }
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            IList<Student> students = EFGenericRepository.Get<Student>(s => s.Group == null).ToArray();

            FillInitControlCollection(students, new CancellationToken());
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //получаем studentViewBoard на котором было вызвано событие button_Click
            IStudentView studentViewBoard = (IStudentView)((Control)sender).Parent;

            //создаем addedStudentViewBoard (клонируем переданный экземпляр конкретного класса)
            IStudentView addedStudentView = (IStudentView)this.addedStudentView.Clone();
            //заполняем addedStudentViewBoard полями studentViewBoard на котороым было вызвано событие Click
            addedStudentView.FillView(EFGenericRepository.FindById<Student>(studentViewBoard.GetStudentId));

            addGroupBoard.CurrentStudentControlCollection.Remove((Control)studentViewBoard);
            addGroupBoard.AddedStudentControlCollection.Add((Control)addedStudentView);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //получаем addedStudentView на котором было вызвано событие button_Click
            IStudentView addedStudentView = (IStudentView)((Control)sender).Parent;

            IStudentView studentView = (IStudentView)this.currentStudentView.Clone();
            studentView.FillView(EFGenericRepository.FindById<Student>(addedStudentView.GetStudentId));

            addGroupBoard.AddedStudentControlCollection.Remove((Control)addedStudentView);
            addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
        }

        private void changeAddedStudentPnanelControl(object sender, EventArgs e)
        {
            addGroupBoard.CountOfAddedStudent =
                addGroupBoard.AddedStudentControlCollection.Count.ToString();
        }

        private void AddGroupBoard_CurrentStudentSearchTextBoxChanges(object sender, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchStudent, sender);
        }

        #endregion

        private async void SearchStudent(object sender, CancellationToken token)
        {
            try
            {
                addGroupBoard.DisableCurrentStudentPanel();

                Student[] result = await GetStudentWithExceptedAddedStudent((sender as TextBox).Text, token);
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
                addGroupBoard.EnableCurrentStudentPanel();
            }

            Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
        }

        /// <summary>
        /// Асинхронный выбор студентов, учитывая фильтр (searchTextBox.Text) и вычитание из результата уже добавленных студентов(addedStudentFlowPanel).
        /// </summary>
        /// <param name="condition">Условие, по которому будет формироваться выборка студентов.</param>
        /// <returns></returns>
        private async Task<Student[]> GetStudentWithExceptedAddedStudent(string condition, CancellationToken token)
        {
            return await Task.Factory.StartNew(() =>
             {
                 IEnumerable<Student> students = EFGenericRepository.Get<Student>(s => s.Group == null);

                 if (condition != string.Empty)
                     students = students
                                .Where(s => s.FirstName.ToUpperInvariant()
                                .Contains(condition.ToUpperInvariant()));

                 if (addGroupBoard.AddedStudentControlCollection.Count == 0)
                     return students.ToArray();
                 else
                 {
                     var addedStudents = addGroupBoard.AddedStudentControlCollection
                                        .Cast<IStudentView>()
                                        .Select(s => EFGenericRepository.FindById<Student>(s.GetStudentId));

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
            await addGroupBoard
                 .CurrentStudentControlCollection
                 .FillControlCollectionForSearch(students, currentStudentView, token);
        }

        private async Task AddControlsToControlCollection(IList<Student> students, CancellationToken token)
        {
            Control[] controls = null;

            await Task.Factory.StartNew(() =>
            {
                if (students.Count == 0)
                    return;

                // except exist student in both ControlCollections
                students = students
                .Where(s => !addGroupBoard.CurrentStudentControlCollection.IsContaintControl<Student>(s.Id) &&
                !addGroupBoard.AddedStudentControlCollection.IsContaintControl<Student>(s.Id))
                .ToArray();

                controls = students.CreateControlCollection(currentStudentView, token);
            });

            if (controls != null)
                addGroupBoard.CurrentStudentControlCollection.AddRange(controls);
        }

        private void FillInitControlCollection(IList<Student> students, CancellationToken token)
        {
            if (students.Count == 0)
                return;

            addGroupBoard.CurrentStudentControlCollection.AddControls(students, currentStudentView, token);

        }

        private async Task DeleteControlsFromControlCollection(IEnumerable<Student> students, CancellationToken token)
        {
            await addGroupBoard.AddedStudentControlCollection.DeleteControls(
                students,
                EFGenericRepository.Get<Student>(),
                token);

            await addGroupBoard.CurrentStudentControlCollection.DeleteControls(
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
            
            await addGroupBoard.AddedStudentControlCollection.UpdateControls(
                studentWithoutGroup,
                addedStudentView,
                token
                );

            await addGroupBoard.CurrentStudentControlCollection.UpdateControls(
                studentWithoutGroup,
                currentStudentView,
                token
                );
        }

        public void Dispose()
        {
            currentTask?.Dispose();
        }
    }
}
