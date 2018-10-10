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

        readonly Model model = new Model();

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView studentView)
        {
            this.addGroupBoard = addGroupBoard;
            this.studentView = studentView;

            this.addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            this.addGroupBoard.changeAddedStudentPnanelControl += changeAddedStudentPnanelControl;
        }


        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = model.GetStudents();
            List<IStudentView> rezult2 = studentView.CreateListIStudentView(students.Count);

            for (int i = 0; i < rezult2.Count; i++)
            {
                IStudentView view = rezult2[i].FillView(students[i], model.ConvertByteArrToImage);
                view.ClickAdd += AddStudentButton_Click;

                addGroupBoard.currentStudentControlCollection.Add((Control)view);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //todo: использовать интерфейсы вместо конкретных вью (презентер не знает о вью)
            StudentViewBoard studentViewBoard = sender as StudentViewBoard;

            AddedStudentViewBoard addedStudentView = new AddedStudentViewBoard();
            addedStudentView.firstNameTextBox.Text = studentViewBoard.fisrtNameTextBox.Text;
            addedStudentView.lastNameTextBox.Text = studentViewBoard.lastNameTextBox.Text;
            addedStudentView.Id = studentViewBoard.Id;
            addedStudentView.ClickCancel += CancelButton_Click;
            addedStudentView.BackColor = System.Drawing.Color.White;

            addGroupBoard.addedStudentControlCollection.Add(addedStudentView);
            addGroupBoard.currentStudentControlCollection.Remove(studentViewBoard);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddedStudentViewBoard addedStudentView = sender as AddedStudentViewBoard;

            Student student = model.GetStudentById(addedStudentView.Id);

            StudentViewBoard studentView = new StudentViewBoard(student.Id, student.FirstName, student.LastName, model.ConvertByteArrToImage(student.FirstPhoto));
            studentView.ClickAdd += AddStudentButton_Click;

            addGroupBoard.currentStudentControlCollection.Add(studentView);
            addGroupBoard.addedStudentControlCollection.Remove(addedStudentView);
        }

        private void changeAddedStudentPnanelControl(object sender, EventArgs e)
        {
            this.addGroupBoard.CountOfAddedStudent = this.addGroupBoard.addedStudentControlCollection.Count.ToString();
        }
    }
}
