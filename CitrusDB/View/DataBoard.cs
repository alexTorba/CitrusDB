using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View
{
    public partial class DataBoard : UserControl
    {

        private bool isCollapsed = false;
        public DataBoard()
        {
            InitializeComponent();
        }

        private void collapsedData_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                this.panelGroup.Width -= 10;
                if(panelGroup.Width <= panelGroup.MinimumSize.Width)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                this.panelGroup.Width += 10;
                if (panelGroup.Width >= panelGroup.MaximumSize.Width)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
