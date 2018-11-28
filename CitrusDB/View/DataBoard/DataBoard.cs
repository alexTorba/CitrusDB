using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CitrusDB.Properties;
using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.Students.StudentsView.StudentInfo;
using CitrusDB.View.Groups.GroupsView.GroupInfo;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.DataBoard
{
    public partial class DataBoard : UserControl, IDataBoard
    {

        MainForm mainForm;

        public DataBoard()
        {
            InitializeComponent();
        }

        #region IDataBoard

        public object GetDataSource
        {
            get => dataGrid.DataSource;
            set => dataGrid.DataSource = value;
        }

        public SelectedEntity SelectedEntity { get; set; }

        public void UpdateView()
        {
            if (radioButtonGroup.Checked == true)
                GroupTableLoad?.Invoke(null, EventArgs.Empty);
            else LoadDataBoard?.Invoke(null, EventArgs.Empty);
        }

        public void DisablingGrid()
        {
            dataGrid.Enabled = false;
        }

        public void EnablingGrid()
        {
            dataGrid.Enabled = true;
        }

        public event EventHandler LoadDataBoard;
        public event EventHandler GroupTableLoad;
        public event EventHandler DeleteEntity;
        public event HeaderGridMouseClickHandler HeaderMouseClick;
        public event EventHandler SearchBoxTextChanged;

        #endregion

        #region Forwarding Events

        private void DataBoard_Load(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.SetStatusValue = "Loading data..";

            LoadDataBoard?.Invoke(null, EventArgs.Empty);

            radioButtonStudent.Checked = true;

            if (dataGrid.Columns["Id"] != null)
                dataGrid.Columns["Id"].Visible = false;

            mainForm?.SetInitStatus();
        }

        private void radioButtonGroup_MouseClick(object sender, MouseEventArgs e)
        {
            GroupTableLoad?.Invoke(sender, e);
            dataGrid.Columns["Id"].Visible = false;
            ((DataGridViewImageColumn)dataGrid.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.Columns["Photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchBoxTextChanged?.Invoke(sender, e);

            if (dataGrid.Columns["Id"] != null)
                dataGrid.Columns["Id"].Visible = false;
        }

        #endregion

        #region Event Handlers

        private void collapsedData_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += generPanelOptions.TicksGrowsWidth;

            (sender as Button)?.ChangeImageButton(generPanelOptions, Resources.left, Resources.right);
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelTables.TicksGrowsHeight;
        }

        private void radioButtonStudent_MouseClick(object sender, MouseEventArgs e)
        {
            DataBoard_Load(sender, EventArgs.Empty);
            radioButtonStudent.Checked = true;
        }

        #endregion

        public void InitDataBoard(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void dataGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            dataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
            contextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.SetStatusValue = "Showing info..";

            int id = (int)dataGrid.SelectedCells[0].Value;

            if (dataGrid.DataSource is ICollection<StudentView>)
                new StudentInfoForm(id).Show();
            else new GroupInfoForm(id).Show();

            mainForm.SetInitStatus();
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            infoToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.SetStatusValue = "Deleting entity..";

            var sel = dataGrid.SelectedRows[0].DataBoundItem;
            DeleteEntity?.Invoke(null, new EntityArgs(sel));
            UpdateView();

            mainForm.SetInitStatus();
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedHeader = dataGrid.Columns[e.ColumnIndex].DataPropertyName;
            if (selectedHeader == "Photo")
                return;

            HeaderMouseClick?.Invoke(sender,
                new HeaderPropertyEventArgs(dataGrid.Columns[e.ColumnIndex].DataPropertyName));
        }

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
                SelectedEntity = SelectedEntity.Group;
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
                SelectedEntity = SelectedEntity.Student;
        }

    }
}
