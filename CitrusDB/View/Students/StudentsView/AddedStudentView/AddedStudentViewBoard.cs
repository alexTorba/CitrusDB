using System;
using System.Drawing;
using System.Windows.Forms;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students.StudentsView.AddedStudentView
{
    public partial class AddedStudentViewBoard : UserControl, IStudentView
    {

        public int Id { get; set; }

        public AddedStudentViewBoard()
        {
            InitializeComponent();

            BackColor = Color.White;
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

            return this;
        }

        public object Clone()
        {
            AddedStudentViewBoard addedStudentViewBoard = new AddedStudentViewBoard();
            addedStudentViewBoard.cancelButton.Click += cancelButton_Click;
            addedStudentViewBoard.firstNameTextBox.Text = firstNameTextBox.Text;
            addedStudentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            addedStudentViewBoard.Id = Id;

            return addedStudentViewBoard;
        }

        new public event EventHandler Click;

        #endregion

        #region Forwarding Events

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, EventArgs.Empty);
        }

        #endregion

        #region Events Handler

        private void AddedStudentViewBoard_Paint(object sender, PaintEventArgs e)
        {
            firstNameTextBox.BackColor = BackColor;
            lastNameTextBox.BackColor = BackColor;
        }

        #endregion

    }
}
