﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.View.UsersElements.Dialogs;

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoardSecond : UserControl, IEditGroupBoardSecond
    {
        MainForm mainForm;
        public EditGroupBoardSecond()
        {
            InitializeComponent();
        }

        public void InitFileds(MainForm mainForm)
        {
            this.mainForm = mainForm;
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
        public event SearchingEventHandler CurrentStudentSearchTextBoxChanges;
        public event EventHandler UpdateView;
        public event EventHandler SetEditingGroup;
        public event OrderByHandler OrderBy;

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
            if (new SuccessfulDialog("Changes accepted successfully !").ShowDialog() == DialogResult.OK)
                cancelButton_Click(null, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelClick?.Invoke(sender, e);
        }

        private void EditGroupBoardSecond_Load(object sender, EventArgs e)
        {
            LoadGroupBoard?.Invoke(sender, e);

            InitComboBox();

            radioButtonAscend.Checked = true;
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentStudentSearchTextBoxChanges?.Invoke((sender as TextBox).Text,comboBoxWhere.SelectedItem.ToString(), null);
        }

        private void addedStudentFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
        }

        private void addedStudentFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            OrderBy?.Invoke(sender, new OrderByEventArgs(comboBoxOrderBy.SelectedItem.ToString(), radioButtonAscend.Checked));
        }

        #endregion

        private void InitComboBox()
        {
            comboBoxOrderBy.DataSource = new List<string>
            {
                "FirstName",
                "LastName",
                "MiddleName",
                "Height",
                "Weight",
                "Сitizenship",
                "KnowledgeOfLanguage"
            };

            comboBoxWhere.DataSource = new List<string>
            {
                "FirstName",
                "LastName",
                "MiddleName",
                "Height",
                "Weight",
                "Сitizenship",
                "KnowledgeOfLanguage"
            };
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
                pictureBox.Load(openFile.FileName);

            if (pictureBox.Image != null)
                photoLabel.Visible = false;
        }

        private void searchSettingsButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += flowPanelSearchSettings.TicksGrowsHeightQuiсkly;
        }

        private void buttonWhere_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelWhere.TicksGrowsHeight;
        }

        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelOrderBy.TicksGrowsHeight;
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }

    }
}
