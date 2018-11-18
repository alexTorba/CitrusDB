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

        private void TicksGrowsWidth(Timer timer, object sender, EventArgs e)
        {
            if (!(bool)generPanelOptions.Tag)
            {
                generPanelOptions.Width += 10;
                studentFlowLayoutPanel.Width -= 10;
                if (generPanelOptions.MaximumSize.Width == generPanelOptions.Width)
                {
                    timer.Stop();
                    generPanelOptions.Tag = true;
                }
            }
            else
            {
                generPanelOptions.Width -= 10;
                studentFlowLayoutPanel.Width += 10;

                if (generPanelOptions.MinimumSize.Width == generPanelOptions.Width)
                {
                    timer.Stop();
                    generPanelOptions.Tag = false;
                }
            }
        }

        private void collapsedButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();

            mainForm.TimerTiks += TicksGrowsWidth;
        }
    }
}
