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
    public partial class StudentViewBoard : UserControl
    {
        public int Id { get; set; }

        public StudentViewBoard()
        {
            InitializeComponent();
        }

        public event EventHandler ClickAdd;

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
