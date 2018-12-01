using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.View.Students.StudentsView.StudentInfo;

namespace CitrusDB.View.Students.StudentsView.StudentView
{
    public partial class StudentViewBoard : UserControl, IStudentView, IEquatable<StudentViewBoard>
    {

        public int Id { get; set; }

        public StudentViewBoard()
        {
            InitializeComponent();
        }

        #region IStudentView

        public string GetFirstName
        {
            get => fisrtNameTextBox.Text;
            private set => fisrtNameTextBox.Text = value;
        }

        public string GetLastName
        {
            get => lastNameTextBox.Text;
            private set => lastNameTextBox.Text = value;
        }

        public IEntityControlView<Student> FillView(Student entity)
        {
            Id = entity.Id;
            GetFirstName = entity.FirstName;
            GetLastName = entity.LastName;
            studentViewPhoto.Image = entity.FirstPhoto.ConvertByteArrToImage();

            return this;
        }

        public void SetCopy(IEntityControlView<Student> newEntity)
        {
            GetFirstName = ((StudentViewBoard)newEntity).GetFirstName;
            GetLastName = ((StudentViewBoard)newEntity).GetLastName;
            studentViewPhoto.Image = ((StudentViewBoard)newEntity).studentViewPhoto.Image;
        }

        public object Clone()
        {
            StudentViewBoard studentViewBoard = new StudentViewBoard();
            studentViewBoard.fisrtNameTextBox.Text = fisrtNameTextBox.Text;
            studentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            studentViewBoard.studentViewPhoto.Image = studentViewPhoto.Image;
            studentViewBoard.addStudentButton.Click += addStudentButton_Click;

            return studentViewBoard;
        }

        public new event EventHandler Click;

        #endregion

        #region Forwarding Events

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }

        public bool Equals(StudentViewBoard obj)
        {
            return obj is StudentViewBoard board &&
                   Id == board.Id &&
                   GetFirstName == board.GetFirstName &&
                   GetLastName == board.GetLastName;
        }

        public override int GetHashCode()
        {
            var hashCode = 573123138;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetFirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetLastName);
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as StudentViewBoard);
        }

        #endregion

        private void studentViewPhoto_DoubleClick(object sender, EventArgs e)
        {
            var studentInfo = new StudentInfoForm(Id);
            studentInfo.BringToFront();
            studentInfo.Show();
        }

        
    }
}
