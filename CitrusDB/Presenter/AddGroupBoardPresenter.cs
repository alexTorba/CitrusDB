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
        readonly Model model = new Model();

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard)
        {
            this.addGroupBoard = addGroupBoard;

            this.addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            this.addGroupBoard.changeAddedStudentPnanelControl += changeAddedStudentPnanelControl;
        }


        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            //create view in Presenter ??
            List<StudentViewBoard> rezult = new List<StudentViewBoard>();

            foreach (Student student in model.GetStudents())
            {
                StudentViewBoard studentViewBoard = new StudentViewBoard(student.Id, student.FirstName, student.LastName,
                    model.ConvertByteArrToImage(student.FirstPhoto));

                studentViewBoard.ClickAdd += AddStudentButton_Click;

                rezult.Add(studentViewBoard);
            }

            addGroupBoard.currentStudentControlCollection.AddRange(rezult.ToArray());
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
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
