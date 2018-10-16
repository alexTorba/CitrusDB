using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    public partial class StudentViewBoard : UserControl, IStudentView
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

        new public event EventHandler Click;

        public IStudentView FillView(Student student)
        {
            Id = student.Id;
            fisrtNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;
            studentViewPhoto.Image = student.FirstPhoto.ConvertByteArrToImage();

            return this;
        }

        public IStudentView CloneTo()
        {
            StudentViewBoard studentViewBoard = new StudentViewBoard();
            studentViewBoard.fisrtNameTextBox.Text = fisrtNameTextBox.Text;
            studentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            studentViewBoard.studentViewPhoto.Image = studentViewPhoto.Image;
            studentViewBoard.addStudentButton.Click += addStudentButton_Click;

            return studentViewBoard;
        }

        #endregion

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }

    }
}
