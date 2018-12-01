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

        public string GetFirstName
        {
            get => firstNameTextBox.Text;
            private set => firstNameTextBox.Text = value;
        }

        public string GetLastName
        {
            get => lastNameTextBox.Text;
            private set => lastNameTextBox.Text = value;
        }

        public IEntityControlView<Student> FillView(Student entity)
        {
            Id = entity.Id;
            firstNameTextBox.Text = entity.FirstName;
            lastNameTextBox.Text = entity.LastName;
            studentViewPhoto.Image = entity.FirstPhoto.ConvertByteArrToImage();

            return this;
        }

        public void SetCopy(IEntityControlView<Student> newEntity)
        {
            GetFirstName = ((EditStudentViewBoard)newEntity).GetFirstName;
            GetLastName = ((EditStudentViewBoard)newEntity).GetLastName;
            studentViewPhoto.Image = ((EditStudentViewBoard)newEntity).studentViewPhoto.Image;
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
