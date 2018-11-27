using System;
using System.Windows.Forms;
using System.Collections.Generic;

using CitrusDB.Model.Entity;
using CitrusDB.View.Students.StudentsView.StudentInfo;

namespace CitrusDB.View.Students.StudentsView.EditStudentView
{
    public partial class EditStudentViewBoard : UserControl, IStudentView, IEquatable<EditStudentViewBoard>
    {
        public int Id { get; set; }

        public EditStudentViewBoard()
        {
            InitializeComponent();
        }

        #region IStudentView

        public int GetStudentId => Id;

        public string GetFristName => firstNameTextBox.Text;

        public string GetLastName => lastNameTextBox.Text;

        public IEntityControlView<Student> FillView(Student entity)
        {
            Id = entity.Id;
            firstNameTextBox.Text = entity.FirstName;
            lastNameTextBox.Text = entity.LastName;
            studentViewPhoto.Image = entity.FirstPhoto.ConvertByteArrToImage();

            return this;
        }

        public object Clone()
        {
            EditStudentViewBoard editStudentViewBoard = new EditStudentViewBoard();
            editStudentViewBoard.firstNameTextBox.Text = firstNameTextBox.Text;
            editStudentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            editStudentViewBoard.studentViewPhoto.Image = studentViewPhoto.Image;
            editStudentViewBoard.editStudentButton.Click += editStudentButton_Click;

            return editStudentViewBoard;
        }

        public new event EventHandler Click;

        #endregion

        public bool Equals(EditStudentViewBoard obj)
        {
            return obj is EditStudentViewBoard board &&
                   Id == board.Id &&
                   GetFristName == board.GetFristName &&
                   GetLastName == board.GetLastName;
        }

        public override int GetHashCode()
        {
            var hashCode = 573123138;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetFristName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetLastName);
            return hashCode;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EditStudentViewBoard);
        }

        private void studentViewPhoto_DoubleClick(object sender, EventArgs e)
        {
            var studentInfo = new StudentInfoForm(Id);
            studentInfo.BringToFront();
            studentInfo.Show();
        }
    }
}
