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
using CitrusDB.View.AddGroup;

namespace CitrusDB.View.AddGroup.AddedStudentView
{
    public partial class AddedStudentViewBoard : UserControl, IStudentView
    {

        private int Id { get; set; }

        public AddedStudentViewBoard()
        {
            InitializeComponent();

            BackColor = Color.White;
        }

        #region IStudentView

        public int GetStudentId => Id;

        public string GetFristName => firstNameTextBox.Text;

        public string GetLastName => lastNameTextBox.Text;

        new public event EventHandler Click;

        public IStudentView FillView(Student student)
        {
            Id = student.Id;
            firstNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName;

            return this;
        }

        public IStudentView CloneTo()
        {
            AddedStudentViewBoard addedStudentViewBoard = new AddedStudentViewBoard();
            addedStudentViewBoard.cancelButton.Click += cancelButton_Click;
            addedStudentViewBoard.firstNameTextBox.Text = firstNameTextBox.Text;
            addedStudentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
            addedStudentViewBoard.Id = Id;

            return addedStudentViewBoard;
        }

        #endregion

        private void AddedStudentViewBoard_Paint(object sender, PaintEventArgs e)
        {
            firstNameTextBox.BackColor = BackColor;
            lastNameTextBox.BackColor = BackColor;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, EventArgs.Empty);
        }

        //public override bool Equals(object obj)
        //{
        //    var board = obj as AddedStudentViewBoard;
        //    return board != null &&
        //           Id == board.Id &&
        //           GetStudentId == board.GetStudentId &&
        //           GetFristName == board.GetFristName &&
        //           GetLastName == board.GetLastName &&
        //           EqualityComparer<IContainer>.Default.Equals(components, board.components) &&
        //           EqualityComparer<TextBox>.Default.Equals(firstNameTextBox, board.firstNameTextBox) &&
        //           EqualityComparer<TextBox>.Default.Equals(lastNameTextBox, board.lastNameTextBox) &&
        //           EqualityComparer<CirclusButton>.Default.Equals(cancelButton, board.cancelButton);
        //}

        //public override int GetHashCode()
        //{
        //    var hashCode = 1741701297;
        //    hashCode = hashCode * -1521134295 + Id.GetHashCode();
        //    hashCode = hashCode * -1521134295 + GetStudentId.GetHashCode();
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetFristName);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetLastName);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<IContainer>.Default.GetHashCode(components);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<TextBox>.Default.GetHashCode(firstNameTextBox);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<TextBox>.Default.GetHashCode(lastNameTextBox);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<CirclusButton>.Default.GetHashCode(cancelButton);
        //    return hashCode;
        //}
    }
}
