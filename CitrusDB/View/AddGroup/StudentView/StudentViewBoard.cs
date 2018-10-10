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

        public event EventHandler ClickAdd;

        public IStudentView FillView(Student student, Func<byte[], Image> converter)
        {
            Id = student.Id;
            fisrtNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;
            studentViewPhoto.Image =  converter.Invoke( student.FirstPhoto);

            return this;
        }

        public IStudentView CloneTo()
        {
            StudentViewBoard studentViewBoard = new StudentViewBoard();
            studentViewBoard.fisrtNameTextBox.Text = fisrtNameTextBox.Text;
            studentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            studentViewBoard.studentViewPhoto.Image = studentViewPhoto.Image;
            studentViewBoard.addStudentButton.Click += this.ClickAdd;

            return studentViewBoard;
        }

        #endregion
       
        public StudentViewBoard(int id, string firstName, string lastName, Image photo) : this()
        {
            this.Id = id;
            this.fisrtNameTextBox.Text = firstName;
            this.lastNameTextBox.Text = lastName;
            this.studentViewPhoto.Image = photo;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            ClickAdd?.Invoke(this, e);
        }

       
    }
}
