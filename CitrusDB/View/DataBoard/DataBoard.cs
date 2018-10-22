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
                GroupTableLoad.Invoke(null, EventArgs.Empty);
            else LoadDataBoard.Invoke(null, EventArgs.Empty);
        }

        public event EventHandler LoadDataBoard;
        public event EventHandler GroupTableLoad;

        #endregion

        public DataBoard()
        {
            InitializeComponent();
        }

        public void InitDataBoard(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void DataBoard_Load(object sender, EventArgs e)
        {
            LoadDataBoard?.Invoke(sender, e);
            radioButtonStudent.Checked = true;
        }

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

        private void radioButtonGroup_MouseClick(object sender, MouseEventArgs e)
        {
            GroupTableLoad?.Invoke(sender, e);

            dataGrid.Columns["Id"].Visible = false;
            ((DataGridViewImageColumn)dataGrid.Columns["Photo"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.Columns["Photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void radioButtonStudent_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDataBoard?.Invoke(sender, e);
            dataGrid.Columns["Id"].Visible = false;
        }

    }
}
