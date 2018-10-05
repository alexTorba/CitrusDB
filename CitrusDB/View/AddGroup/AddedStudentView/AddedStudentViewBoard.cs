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
    public partial class AddedStudentViewBoard : UserControl
    {
        public int Id { get; set; }

        public event EventHandler ClickCancel;

        public AddedStudentViewBoard()
        {
            InitializeComponent();
        }

        private void AddedStudentViewBoard_Paint(object sender, PaintEventArgs e)
        {
            this.firstNameTextBox.BackColor = this.BackColor;
            this.lastNameTextBox.BackColor = this.BackColor;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClickCancel?.Invoke(this, EventArgs.Empty);
        }
    }
}
