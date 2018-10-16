﻿using System;
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
    public partial class AddGroupBoard : UserControl, IAddGroupBoard
    {

        public AddGroupBoard()
        {
            InitializeComponent();
        }

        #region IAddGroupBoard

        public ControlCollection CurrentStudentControlCollection => currentStudentFlowPanel.Controls;

        public ControlCollection AddedStudentControlCollection => addedStudentFlowPanel.Controls;

        public string CountOfAddedStudent
        {
            get => countOfStudentsLabel.Text;
            set => countOfStudentsLabel.Text = value;
        }

        public string GetNameOfGroup => nameGroupTextBox.Text;

        public Image GetGroupPhoto => photoPictureBox.Image;

        public event EventHandler LoadAddGroupBoard;
        public event EventHandler ChangeAddedStudentPanelControl;
        public event EventHandler ClearClick;
        public event EventHandler SaveClick;
        public event EventHandler CurrentStudentSearchTextBoxChanges;

        #endregion

        #region Forwarding Events

        private void AddGroupBoard_Load(object sender, EventArgs e)
        {
            LoadAddGroupBoard?.Invoke(sender, e);

            countOfStudentsLabel.Text = addedStudentFlowPanel.Controls.Count.ToString();
        }

        private void addedStudentFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
        }

        private void addedStudentFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameGroupTextBox.Text = string.Empty;
            photoPictureBox.Image = null;

            ClearClick?.Invoke(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(sender, e);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentStudentSearchTextBoxChanges.Invoke(sender, e);
        }

        #endregion

        private void addedStudentSearchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            addedStudentSearchTextBox_MouseClick(sender, e);
        }

        private void photoPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFile.FileName);
            }

            if (pictureBox.Image != null)
                this.photoLabel.Visible = false;
        }

    }
}
