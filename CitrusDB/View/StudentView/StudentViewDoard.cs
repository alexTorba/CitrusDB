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
    public partial class StudentViewDoard : UserControl
    {
        public StudentViewDoard()
        {
            InitializeComponent();
        }

        public StudentViewDoard(string firstName, string lastName, Image photo) : this()
        {
            this.fisrtNameTextBox.Text = firstName;
            this.lastNameTextBox.Text = lastName;
            this.studentViewPhoto.Image = photo;
        }

    }
}
