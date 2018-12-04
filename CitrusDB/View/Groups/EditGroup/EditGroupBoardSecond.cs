using System;
using System.Drawing;
using System.Windows.Forms;
using CitrusDB.Model.Entity;

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

        public string GetNameOfGroup
        {
            get => nameGroupTextBox.Text;
            private set => nameGroupTextBox.Text = value;
        }

        public Image GetGroupPhoto
        {
            get => photoPictureBox.Image;
            set => photoPictureBox.Image = value;
        }

        public ControlCollection CurrentStudentControlCollection => currentStudentsFlowPanel.Controls;

        public ControlCollection AddedStudentControlCollection => addedStudentFlowPanel.Controls;

        public Group CurrentGroup { get; private set; }

        public event Func<bool> AcceptClick;
        public event EventHandler CancelClick;
        public event EventHandler LoadGroupBoard;
        public event EventHandler ChangeAddedStudentPanelControl;
        public event EventHandler CurrentStudentSearchTextBoxChanges;
        public event EventHandler UpdateView;
        public event EventHandler SetEditingGroup;

        public void ClearView()
        {
            throw new NotImplementedException();
        }

        public void DisableAddedStudentPanel()
        {
            addedStudentFlowPanel.Enabled = false;
        }

        public void DisableCurrentStudentPanel()
        {
            currentStudentsFlowPanel.Enabled = false;
        }

        public void EnableAddedStudentPanel()
        {
            addedStudentFlowPanel.Enabled = true;
        }

        public void EnableCurrentStudentPanel()
        {
            currentStudentsFlowPanel.Enabled = true;
        }

        #endregion

        public void UpdatingView()
        {
            UpdateView?.Invoke(null, EventArgs.Empty);
        }

        public void SetGroup(Group group)
        {
            CurrentGroup = group;

            GetNameOfGroup = CurrentGroup.Name;
            GetGroupPhoto = CurrentGroup.Photo.ConvertByteArrToImage();
            photoLabel.Visible = false;

            SetEditingGroup?.Invoke(null, EventArgs.Empty);
        }

        #region Forwarding Events

        private void acceptButton_Click(object sender, EventArgs e)
        {
            AcceptClick?.Invoke();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelClick?.Invoke(sender, e);
        }

        private void EditGroupBoardSecond_Load(object sender, EventArgs e)
        {
            LoadGroupBoard?.Invoke(sender, e);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentStudentSearchTextBoxChanges?.Invoke(sender, e);
        }

        #endregion

    }
}
