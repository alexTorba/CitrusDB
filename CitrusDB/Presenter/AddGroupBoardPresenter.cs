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

            this.addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
            this.addGroupBoard.changeAddedStudentPnanelControl += changeAddedStudentPnanelControl;
        }


        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            List<Student> students = model.GetStudents();
            List<IStudentView> rezult = studentView.CreateListIStudentView(students.Count);

            for (int i = 0; i < rezult.Count; i++)
            {
                IStudentView view = rezult[i].FillView(students[i]);
                view.ClickAdd += AddStudentButton_Click;

                addGroupBoard.currentStudentControlCollection.Add((Control)view);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            IStudentView studentViewBoard = sender as IStudentView;
            IStudentView aSV = addedStudentView.CloneTo();

            aSV.FillView(model.GetStudentById(studentViewBoard.GetStudentId));
            aSV.ClickAdd += CancelButton_Click;

            addGroupBoard.addedStudentControlCollection.Add((Control)aSV);
            addGroupBoard.currentStudentControlCollection.Remove((Control)studentViewBoard);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IStudentView addedStudentView = sender as IStudentView;

            IStudentView studentView = this.studentView.CloneTo();
            studentView.FillView(model.GetStudentById(addedStudentView.GetStudentId));
            studentView.ClickAdd += AddStudentButton_Click;

            addGroupBoard.currentStudentControlCollection.Add((Control)studentView);
            addGroupBoard.addedStudentControlCollection.Remove((Control)addedStudentView);
        }

        private void changeAddedStudentPnanelControl(object sender, EventArgs e)
        {
            this.addGroupBoard.CountOfAddedStudent = this.addGroupBoard.addedStudentControlCollection.Count.ToString();
        }
    }
}
