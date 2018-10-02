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

namespace CitrusDB
{
    public partial class DataBoard : UserControl, IDataBoard
    {
        MainForm mainForm;


        #region IDataBoard

        public BunifuCustomDataGrid GetDataGrid { get => dataGrid; }

        public event EventHandler LoadDataBoard;

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
            //DataBoardPresenter dataBoardPresenter = new DataBoardPresenter(this);

            LoadDataBoard?.Invoke(sender, e);
        }

        private void collapsedData_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += generPanelOptions.TicksGrowsWidth;
        }

       
        private void buttonTables_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelTables.TicksGrowsHeight;
        }

    }
}
