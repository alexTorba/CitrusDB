﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using CitrusDB.Model.Entity;
using CitrusDB.Model;
using CitrusDB.View.Students.StudentsView.StudentInfo;

namespace CitrusDB.View.Groups.GroupsView.GroupInfo
{

    public partial class GroupInfoForm : Form, IGroupInfoForm
    {
        public GroupInfoForm(int id)
        {
            InitializeComponent();

            Id = id;

            Presenter.GroupInfoFormPresenter groupInfoFormPresenter = new Presenter.GroupInfoFormPresenter(this);
        }

        #region IGroupInfoForm

        public int Id { get; }

        public Image Photo
        {
            get => photoPictureBox.Image;
            set => photoPictureBox.Image = value;
        }

        public object Students
        {
            get => studentsDataGrid.DataSource;
            set => studentsDataGrid.DataSource = value;
        }
        public string GroupName
        {
            get => groupNameValue.Text;
            set => groupNameValue.Text = value;
        }

        public void DisablingGrid()
        {
            studentsDataGrid.Enabled = false;
        }

        public void EnablingGrid()
        {
            studentsDataGrid.Enabled = true;
        }

        public event EventHandler LoadForm;
        public event HeaderGridMouseClick HeaderMouseClick;
        public event EventHandler SearchTextChanged;

        #endregion

        #region Forwarding Events

        private void GroupInfoForm_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(sender, e);

            countOfAddedValue.Text = (studentsDataGrid.DataSource as IEnumerable<StudentView>).Count().ToString();
            CustomizeTableDisplaying();    
        }

        private void CustomizeTableDisplaying()
        {
            studentsDataGrid.Columns["Id"].Visible = false;
            studentsDataGrid.Columns["Group"].Visible = false;
        }

        private void studentsDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HeaderMouseClick?.Invoke(sender, 
                new HeaderPropertyEventArgs(studentsDataGrid.Columns[e.ColumnIndex].DataPropertyName));
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(sender, e);
            CustomizeTableDisplaying();
        }

        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studentsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)studentsDataGrid.SelectedCells[0].Value;
            new StudentInfoForm(id).ShowDialog();
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }
    }
}