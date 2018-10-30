﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddGroup;

namespace CitrusDB.Presenter
{
    class AddGroupBoardPresenter
    {
        readonly IAddGroupBoard addGroupBoard;
        readonly IStudentView studentView;
        readonly IStudentView addedStudentView;
        readonly Model.Model model = new Model.Model();
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();


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
            //todo: реализовать отмену неактуальной задачи.
            List<Student> students = new List<Student>();

            foreach (IStudentView student in addGroupBoard.AddedStudentControlCollection)
                students.Add(model.GetEntityById<Student>(student.GetStudentId));

            Group group = new Group
            {
                Name = addGroupBoard.GetNameOfGroup,
                Students = students,
                Photo = addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
            };

            model.Add(group);

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
                    studentView.FillView(model.GetEntityById<Student>(((IStudentView)control).GetStudentId));

                    addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
                }
                addGroupBoard.AddedStudentControlCollection.Clear();
            }
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = model.GetEntities<Student>();
            FillControlCollection(students);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //получаем studentViewBoard на котором было вызвано событие button_Click
            IStudentView studentViewBoard = (IStudentView)((Control)sender).Parent;

            //создаем addedStudentViewBoard (клонируем переданный экземпляр конкретного класса)
            IStudentView addedStudentView = (IStudentView)this.addedStudentView.Clone();
            //заполняем addedStudentViewBoard полями studentViewBoard на котороым было вызвано событие Click
            addedStudentView.FillView(model.GetEntityById<Student>(studentViewBoard.GetStudentId));
            addedStudentView.Click += CancelButton_Click;

            addGroupBoard.CurrentStudentControlCollection.Remove((Control)studentViewBoard);
            addGroupBoard.AddedStudentControlCollection.Add((Control)addedStudentView);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //получаем addedStudentView на котором было вызвано событие button_Click
            IStudentView addedStudentView = (IStudentView)((Control)sender).Parent;

            IStudentView studentView = (IStudentView)this.studentView.Clone();
            studentView.FillView(model.GetEntityById<Student>(addedStudentView.GetStudentId));
            studentView.Click += AddStudentButton_Click;

            addGroupBoard.AddedStudentControlCollection.Remove((Control)addedStudentView);
            addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
        }

        private void changeAddedStudentPnanelControl(object sender, EventArgs e)
        {
            addGroupBoard.CountOfAddedStudent =
                addGroupBoard.AddedStudentControlCollection.Count.ToString();
        }

        private async void AddGroupBoard_CurrentStudentSearchTextBoxChanges(object sender, EventArgs e)
        {
            addGroupBoard.DisableCurrentStudentPanel();

            List<Student> result = await GetStudentWithFilterExceptAddedStudent((sender as TextBox).Text);

            addGroupBoard.CurrentStudentControlCollection.Clear();

            await FillControlCollection(result);

            addGroupBoard.EnableCurrentStudentPanel();
        }

        #endregion

        /// <summary>
        /// Асинхронный выбор студентов, учитывая фильтр (searchTextBox.Text) и вычитание из результата уже добавленных студентов(addedStudentFlowPanel).
        /// </summary>
        /// <param name="condition">Условие, по которому будет формироваться выборка студентов.</param>
        /// <returns></returns>
        private async Task<List<Student>> GetStudentWithFilterExceptAddedStudent(string condition)
        {
            return await Task.Factory.StartNew(() =>
             {
                 IEnumerable<Student> students;

                 if (condition == string.Empty)
                     students = model.GetEntities<Student>();
                 else
                     students = model.GetEntities<Student>()
                                     .Where(s => s.FirstName.ToUpperInvariant()
                                                  .Contains(condition.ToUpperInvariant()));

                 var addedStudent = addGroupBoard.AddedStudentControlCollection
                                                 .Cast<IStudentView>()
                                                 .Select(s => model.GetEntityById<Student>(s.GetStudentId));

                 return students.Except(addedStudent).ToList();
             });
        }

        /// <summary>
        /// Асинхронное заполнение CurrentStudentControlCollection.
        /// </summary>
        /// <param name="students">Коллекция, которая будет трансформироваться в StudentViewBoard и помещаться в CurrentStudentControlCollection</param>
        /// <returns></returns>
        private async Task FillControlCollection(List<Student> students)
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
            });

            addGroupBoard.CurrentStudentControlCollection.AddRange(controls.ToArray());
        }


    }
}
