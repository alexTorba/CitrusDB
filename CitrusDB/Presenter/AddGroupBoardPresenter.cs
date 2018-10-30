using System;
using System.Collections.Generic;
using System.Linq;
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

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView studentView,
            IStudentView addedStudentView)
        {
            this.addGroupBoard = addGroupBoard;
            this.studentView = studentView;
            this.addedStudentView = addedStudentView;

            SetHandlers();
        }

        #region Event Handlers

        private void AddGroupBoard_SaveClick(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView student in addGroupBoard.AddedStudentControlCollection)
                students.Add(model.GetStudentById(student.GetStudentId));

            Group group = new Group
            {
                Name = addGroupBoard.GetNameOfGroup,
                Students = students,
                Photo = addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
            };

            model.AddGroup(group);

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
                    studentView.FillView(model.GetStudentById(((IStudentView)control).GetStudentId));

                    addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
                }
                addGroupBoard.AddedStudentControlCollection.Clear();
            }
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = model.GetStudents();
            FillControlCollection(students);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //получаем studentViewBoard на котором было вызвано событие button_Click
            IStudentView studentViewBoard = (IStudentView)((Control)sender).Parent;

            //создаем addedStudentViewBoard (клонируем переданный экземпляр конкретного класса)
            IStudentView addedStudentView = (IStudentView)this.addedStudentView.Clone();
            //заполняем addedStudentViewBoard полями studentViewBoard на котороым было вызвано событие Click
            addedStudentView.FillView(model.GetStudentById(studentViewBoard.GetStudentId));
            addedStudentView.Click += CancelButton_Click;

            addGroupBoard.CurrentStudentControlCollection.Remove((Control)studentViewBoard);
            addGroupBoard.AddedStudentControlCollection.Add((Control)addedStudentView);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //получаем addedStudentView на котором было вызвано событие button_Click
            IStudentView addedStudentView = (IStudentView)((Control)sender).Parent;

            IStudentView studentView = (IStudentView)this.studentView.Clone();
            studentView.FillView(model.GetStudentById(addedStudentView.GetStudentId));
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
            TextBox textBox = sender as TextBox;

            var students = model.GetStudents()
                                .Where(s => s.FirstName.ToUpperInvariant()
                                             .Contains(textBox.Text.ToUpperInvariant()));

            var addedStudent = addGroupBoard.AddedStudentControlCollection
                                            .Cast<IStudentView>()
                                            .Select(s => model.GetStudentById(s.GetStudentId));

            var result = students.Except(addedStudent).ToList();

            addGroupBoard.CurrentStudentControlCollection.Clear();
            FillControlCollection(result);
        }

        #endregion

        private void SetHandlers()
        {
            addGroupBoard.SaveClick += AddGroupBoard_SaveClick;
            addGroupBoard.ClearClick += AddGroupBoard_ClearClick;
            addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            addGroupBoard.ChangeAddedStudentPanelControl += changeAddedStudentPnanelControl;
            addGroupBoard.CurrentStudentSearchTextBoxChanges += AddGroupBoard_CurrentStudentSearchTextBoxChanges;
        }

        private void FillControlCollection(List<Student> students)
        {
            List<IStudentView> rezult = studentView.CreateListViews(students.Count);

            for (int i = 0; i < rezult.Count; i++)
            {
                IStudentView view = rezult[i].FillView(students[i]);
                view.Click += AddStudentButton_Click;

                addGroupBoard.CurrentStudentControlCollection.Add((Control)view);
            }
        }

    }
}
