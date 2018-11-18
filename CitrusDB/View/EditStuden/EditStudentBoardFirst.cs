using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.EditStuden
{
    public partial class editStudentBoardFirst : UserControl
    {
        MainForm mainForm;

        public editStudentBoardFirst()
        {
            InitializeComponent();
        }

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += optionFlowPanel.TicksGrowsWidth;
            mainForm.TimerTiks += flowLayoutPanel1.TicksGrowsWidth;
        }
    }
}
