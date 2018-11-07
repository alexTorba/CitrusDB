using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddGroup;
using CitrusDB.View.AddGroup.StudentView;
using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Presenter
{
    class AddGroupBoardPresenter : IDisposable
    {
        readonly IAddGroupBoard addGroupBoard;
        readonly IStudentView studentView;
        readonly IStudentView addedStudentView;

        TaskInfo currentTask = null;

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView studentView,
            IStudentView addedStudentView)
        {
            this.addGroupBoard = addGroupBoard;
            this.studentView = studentView;
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
        }

        #region Event Handlers

        private void AddGroupBoard_SaveClick(object sender, EventArgs e)
        {
            //todo: нужно ли сихнронизировать задачи в момент добавления в currentControlCol (может быть запрос с двойным результатом)
            List<Student> students = new List<Student>();

            foreach (IStudentView student in addGroupBoard.AddedStudentControlCollection)
                students.Add(EFGenericRepository.FindById<Student>(student.GetStudentId));

            Group group = new Group
            {
                Name = addGroupBoard.GetNameOfGroup,
                Students = students,
                Photo = addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
            };

            EFGenericRepository.Create(group);
            //EFGenericRepository.SaveChanges();
            MessageBox.Show("Added group was sucessfule");
        }

        private void AddGroupBoard_ClearClick(object sender, EventArgs e)
        {
            addGroupBoard.ClearView(); 

            if (addGroupBoard.AddedStudentControlCollection.Count != 0)
            {
                foreach (var obj in addGroupBoard.AddedStudentControlCollection)
                {
                    Control control = obj as Control;

                    IStudentView studentView = (IStudentView)this.studentView.Clone();
                    studentView.FillView(EFGenericRepository.FindById<Student>(
                        ((IStudentView)control).GetStudentId));

                    addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
                }
                addGroupBoard.AddedStudentControlCollection.Clear();
            }
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = EFGenericRepository.Get<Student>().ToList();

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
            addedStudentView.Click += CancelButton_Click;

            addGroupBoard.CurrentStudentControlCollection.Remove((Control)studentViewBoard);
            addGroupBoard.AddedStudentControlCollection.Add((Control)addedStudentView);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //получаем addedStudentView на котором было вызвано событие button_Click
            IStudentView addedStudentView = (IStudentView)((Control)sender).Parent;

            IStudentView studentView = (IStudentView)this.studentView.Clone();
            studentView.FillView(EFGenericRepository.FindById<Student>(addedStudentView.GetStudentId));
            studentView.Click += AddStudentButton_Click;

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

                List<Student> result = await GetStudentWithExceptedAddedStudent((sender as TextBox).Text, token);

                await FillControlCollection(result, token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
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
        private async Task<List<Student>> GetStudentWithExceptedAddedStudent(string condition, CancellationToken token)
        {
            return await Task.Factory.StartNew(() =>
             {

                 IEnumerable<Student> students = EFGenericRepository.Get<Student>();

                 if (condition != string.Empty)
                     students = students
                                .Where(s => s.FirstName.ToUpperInvariant()
                                .Contains(condition.ToUpperInvariant()));

                 var addedStudent = addGroupBoard.AddedStudentControlCollection
                                    .Cast<IStudentView>()
                                    .Select(s => EFGenericRepository.FindById<Student>(s.GetStudentId));

                 return students.Except(addedStudent).ToList();
             }, token);

        }

        /// <summary>
        /// Асинхронное заполнение CurrentStudentControlCollection.
        /// </summary>
        /// <param name="students">Коллекция, которая будет трансформироваться в StudentViewBoard и помещаться в CurrentStudentControlCollection</param>
        /// <returns></returns>
        private async Task FillControlCollection(List<Student> students, CancellationToken token)
        {
            var controls = await CreateControlCollection(students, token);

            if (await СollectionEqualityTest(controls)) return;

            addGroupBoard.CurrentStudentControlCollection.Clear();

            addGroupBoard.CurrentStudentControlCollection.AddRange(controls.ToArray());
        }

        private async void FillInitControlCollection(List<Student> students, CancellationToken token)
        {
            var controls = await CreateControlCollection(students, token);

            addGroupBoard.CurrentStudentControlCollection.AddRange(controls.ToArray());
        }

        private async Task<bool> СollectionEqualityTest(List<Control> newControls)
        {
            return await Task<bool>.Factory.StartNew(() =>
            {
                var current = addGroupBoard.CurrentStudentControlCollection.Cast<Control>();

                int countSameValues = current.Count() == newControls.Count()
                                   ? current.Except(newControls).Count()
                                   : -1;

                Console.WriteLine($"countSameValues - {countSameValues}");
                if (countSameValues == 0)
                    return true;

                return false;
            });
        }

        private async Task<List<Control>> CreateControlCollection(List<Student> students, CancellationToken token)
        {
            List<Control> controls = new List<Control>();

            await Task.Factory.StartNew(() =>
            {
                List<IStudentView> rezult = studentView.CreateListViews(students.Count);

                for (int i = 0; i < rezult.Count; i++)
                {
                    IStudentView view = rezult[i].FillView(students[i]);
                    view.Click += AddStudentButton_Click;

                    controls.Add((Control)view);
                }
            }, token);

            return controls;
        }

        public void Dispose()
        {
            currentTask?.Dispose();
        }
    }
}
