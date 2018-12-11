using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CitrusDB.Properties;
using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Students.StudentsView.StudentInfo;
using CitrusDB.View.Groups.GroupsView.GroupInfo;

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
        public Type TypeOfSelectedEntity { get; private set; }

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
        public event SearchingEventHandler SearchBoxTextChanged;
        public event EventHandler ChangeEntity;
        public event GetEntityBySelectedViewHandler GetEntityBySelectedView;

        #endregion

        #region Forwarding Events

        private void DataBoard_Load(object sender, EventArgs e)
        {
            radioButtonStudent_MouseClick(null, null);

            radioButtonAscend.Checked = true;
        }

        private void radioButtonGroup_MouseClick(object sender, MouseEventArgs e)
        {
            GroupTableLoad?.Invoke(sender, e);
            dataGrid.Columns["Id"].Visible = false;
            ((DataGridViewImageColumn)dataGrid.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.Columns["Photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            comboBoxFilters.DataSource = new List<string>
            {
                "Name"
            };

            SetSizeGrid();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(((TextBox)sender).Text, new AfterSearchingEventArgs(null, null));
        }

        #endregion

        private void SetSizeGrid()
        {
            if (dataGrid != null && dataGrid?.Rows.Count != 0)
            {

                int width = 0;
                foreach (DataGridViewCell cell in dataGrid.Rows[0].Cells)
                    width += cell.Size.Width;

                dataGrid.Size = new Size(width, dataGrid.Size.Height);
            }
        }

        private void Search(string conditionFilter, AfterSearchingEventArgs e)
        {
            if (conditionFilter == "Search..")
                SearchBoxTextChanged?.Invoke("", comboBoxFilters.SelectedValue.ToString(), e);
            else
                SearchBoxTextChanged?.Invoke(conditionFilter, comboBoxFilters.SelectedItem.ToString(), e);


            if (dataGrid.Columns["Id"] != null)
                dataGrid.Columns["Id"].Visible = false;
        }

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
            LoadDataBoard?.Invoke(null, EventArgs.Empty);

            radioButtonStudent.Checked = true;

            if (dataGrid.Columns["Id"] != null)
                dataGrid.Columns["Id"].Visible = false;

            SetSizeGrid();

            comboBoxFilters.DataSource = new List<string>
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

            Search(searchTextBox.Text,
                new AfterSearchingEventArgs(SortingTable, dataGrid.Tag?.ToString())
                  );

            mainForm.SetInitStatus();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object selectedEntityView = dataGrid.SelectedRows[0].DataBoundItem;
            IEntity selectedEntity = GetEntityBySelectedView?.Invoke(null, new EntityTransferEventArgs((IEntity)selectedEntityView));

            if (selectedEntity != null)
                ChangeEntity?.Invoke(null, new EntityArgs(selectedEntity));
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedHeader = dataGrid.Columns[e.ColumnIndex].DataPropertyName;

            if (selectedHeader == "Photo")
                return;

            dataGrid.Tag = selectedHeader;

            SortingTable(selectedHeader);
        }

        private void SortingTable(string conditionSorting)
        {
            if (conditionSorting == null)
                return;

            HeaderMouseClick?.Invoke(dataGrid, new HeaderPropertyEventArgs(conditionSorting));
        }

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                SelectedEntity = SelectedEntity.Group;
                TypeOfSelectedEntity = typeof(Group);
            }
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                SelectedEntity = SelectedEntity.Student;
                TypeOfSelectedEntity = typeof(Student);
            }
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
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

    }
}
