using System;
using System.Drawing;
using System.Windows.Forms;

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoardSecond : UserControl, IEditGroupBoardSecond
    {
        public EditGroupBoardSecond()
        {
            InitializeComponent();
        }

        #region IEditGroupBoardSecond

        public string CountOfAddedStudent
        {
            get => countOfStudentsLabel.Text;
            set => countOfStudentsLabel.Text = value;
        }

        public string GetNameOfGroup => nameGroupTextBox.Text;

        public Image GetGroupPhoto => photoPictureBox.Image;

        public ControlCollection CurrentStudentControlCollection => currentStudentsFlowPanel.Controls;

        public ControlCollection AddedStudentControlCollection => addedStudentFlowPanel.Controls;

        public event EventHandler AcceptClick;
        public event EventHandler CancelClick;
        public event EventHandler LoadAddGroupBoard;
        public event EventHandler ChangeAddedStudentPanelControl;
        public event EventHandler CurrentStudentSearchTextBoxChanges;
        public event EventHandler UpdateView;

        public void ClearView()
        {
            throw new NotImplementedException();
        }

        public void DisableAddedStudentPanel()
        {
            throw new NotImplementedException();
        }

        public void DisableCurrentStudentPanel()
        {
            throw new NotImplementedException();
        }

        public void EnableAddedStudentPanel()
        {
            throw new NotImplementedException();
        }

        public void EnableCurrentStudentPanel()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Forwarding Events

        private void acceptButton_Click(object sender, EventArgs e)
        {
            AcceptClick?.Invoke(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelClick?.Invoke(sender, e);
        }

        private void EditGroupBoardSecond_Load(object sender, EventArgs e)
        {
            LoadAddGroupBoard?.Invoke(sender, e);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentStudentSearchTextBoxChanges?.Invoke(sender, e);
        }

        #endregion

    }
}
