using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.UsersElements;

namespace CitrusDB.View.AddGroup.StudentView
{
    public partial class StudentViewBoard : UserControl, IStudentView, IEquatable<StudentViewBoard>
    {

        public int Id { get; set; }

        public StudentViewBoard()
        {
            InitializeComponent();
        }

        #region IStudentView

        public int GetStudentId => Id;

        public string GetFristName => fisrtNameTextBox.Text;

        public string GetLastName => lastNameTextBox.Text;

        public IStudentView FillView(Student student)
        {
            Id = student.Id;
            fisrtNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;
            studentViewPhoto.Image = student.FirstPhoto.ConvertByteArrToImage();

            return this;
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

        public override bool Equals(object obj)
        {
            return Equals(obj as StudentViewBoard);
        }

        public bool Equals(StudentViewBoard other)
        {
            return other != null &&
                   Id == other.Id &&
                   GetStudentId == other.GetStudentId &&
                   GetFristName == other.GetFristName &&
                   GetLastName == other.GetLastName;
        }

        public override int GetHashCode()
        {
            var hashCode = -618884727;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + GetStudentId.GetHashCode();
            return hashCode;
        }

        #endregion

    }
}
