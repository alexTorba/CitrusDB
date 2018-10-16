using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    class AddGroupBoardPresenter
    {
        readonly IAddGroupBoard addGroupBoard;
        readonly IStudentView studentView;
        readonly IStudentView addedStudentView;
        readonly Model model = new Model();

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView studentView,
            IStudentView addedStudentView)
        {
            this.addGroupBoard = addGroupBoard;
            this.studentView = studentView;
            this.addedStudentView = addedStudentView;

            this.addGroupBoard.SaveClick += AddGroupBoard_SaveClick;
            this.addGroupBoard.ClearClick += AddGroupBoard_ClearClick;
            this.addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            this.addGroupBoard.ChangeAddedStudentPanelControl += changeAddedStudentPnanelControl;
            this.addGroupBoard.CurrentStudentSearchTextBoxChanges += AddGroupBoard_CurrentStudentSearchTextBoxChanges;

        }


        private void AddGroupBoard_SaveClick(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView student in addGroupBoard.AddedStudentControlCollection)
                students.Add(model.GetStudentById(student.GetStudentId));

            Group group = new Group
            {
                Name = addGroupBoard.GetNameOfGroup,
                Students = students
            };

            model.AddGroup(group);

            MessageBox.Show("Added group was sucessfule");
        }

        private void AddGroupBoard_ClearClick(object sender, EventArgs e)
        {
            //todo: clear logic
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = model.GetStudents();
            List<IStudentView> rezult = studentView.CreateListIStudentView(students.Count);

            for (int i = 0; i < rezult.Count; i++)
            {
                IStudentView view = rezult[i].FillView(students[i]);
                view.Click += AddStudentButton_Click;

                addGroupBoard.CurrentStudentControlCollection.Add((Control)view);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //получаем studentViewBoard на котором было вызвано событие button_Click
            IStudentView studentViewBoard = (IStudentView)((Control)sender).Parent;

            //создаем addedStudentViewBoard (клонируем переданный экземпляр конкретного класса)
            IStudentView addedStudentView = this.addedStudentView.CloneTo();
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

            IStudentView studentView = this.studentView.CloneTo();
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
            //todo: сделать сортировку flowPanel без удаления данных (при повторном запросе коллекция пустая)
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                var collection = addGroupBoard.CurrentStudentControlCollection
                    .Cast<IStudentView>()
                    .Where(s => s.GetFristName.Contains(textBox.Text))
                    .Cast<Control>()
                    .ToArray();

                addGroupBoard.CurrentStudentControlCollection.Clear();
                addGroupBoard.CurrentStudentControlCollection.AddRange(collection);
            }
        }

    }
}
