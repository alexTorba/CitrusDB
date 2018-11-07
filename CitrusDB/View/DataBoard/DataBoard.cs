using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

using CitrusDB.Properties;
using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.EntitiesInfo.StudentInfo;
using CitrusDB.View.EntitiesInfo.GroupInfo;

namespace CitrusDB.View.DataBoard
{
    public partial class DataBoard : UserControl, IDataBoard
    {

        MainForm mainForm;

        #region IDataBoard

        public object GetDataSource
        {
            get => dataGrid.DataSource;
            set => dataGrid.DataSource = value;
        }

        public void UpdateView()
        {
            if (radioButtonGroup.Checked == true)
                GroupTableLoad?.Invoke(null, EventArgs.Empty);
            else LoadDataBoard?.Invoke(null, EventArgs.Empty);
        }

        public event EventHandler LoadDataBoard;
        public event EventHandler GroupTableLoad;

        #endregion

        public DataBoard()
        {
            InitializeComponent();
        }

        #region Forwarding Events

        private void DataBoard_Load(object sender, EventArgs e)
        {
            LoadDataBoard?.Invoke(null, EventArgs.Empty);

            radioButtonStudent.Checked = true;

            //if (dataGrid.Columns["Id"] != null)
            //    dataGrid.Columns["Id"].Visible = false;
        }

        private void radioButtonGroup_MouseClick(object sender, MouseEventArgs e)
        {
            GroupTableLoad?.Invoke(sender, e);

            dataGrid.Columns["Id"].Visible = false;
            ((DataGridViewImageColumn)dataGrid.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.Columns["Photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
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
            int id = (int)dataGrid.SelectedCells[0].Value;

            if (dataGrid.DataSource is ICollection<StudentView>)
                new StudentInfoForm(id).ShowDialog();
            else new GroupInfoForm(id).ShowDialog();
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            infoToolStripMenuItem_Click(sender, e);
        }

    }
}
