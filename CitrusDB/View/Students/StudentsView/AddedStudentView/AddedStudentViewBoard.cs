using System;
using System.Drawing;
using System.Windows.Forms;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students.StudentsView.AddedStudentView
{
  public partial class AddedStudentViewBoard : UserControl, IStudentView
  {
    public AddedStudentViewBoard()
    {
      InitializeComponent();

      BackColor = Color.White;
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

    public int Id { get; set; }

    public IEntityControlView<Student> FillView(Student entity)
    {
      Id = entity.Id;
      firstNameTextBox.Text = entity.FirstName;
      lastNameTextBox.Text = entity.LastName;

      return this;
    }

    public object Clone()
    {
      var addedStudentViewBoard = new AddedStudentViewBoard();
      addedStudentViewBoard.cancelButton.Click += cancelButton_Click;
      addedStudentViewBoard.firstNameTextBox.Text = firstNameTextBox.Text;
      addedStudentViewBoard.lastNameTextBox.Text = lastNameTextBox.Text;
      addedStudentViewBoard.Id = Id;

      return addedStudentViewBoard;
    }

    public void SetCopy(IEntityControlView<Student> newEntity)
    {
      GetFirstName = ((AddedStudentViewBoard)newEntity).GetFirstName;
      GetLastName = ((AddedStudentViewBoard)newEntity).GetLastName;
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
