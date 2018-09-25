using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    public partial class MainForm : Form, IMainForm
    {
        private bool isCollapsed;

        public object DataSource
        {
            
            get
            {
                return this.dataGrid.DataSource;
            }
            set
            {
                this.dataGrid.DataSource = value;
            }
        }

        public event EventHandler LoadMainForm;

        public MainForm()
        {
            InitializeComponent();
            isCollapsed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainForm(sender, e);
        }

        private void ReplaceBacklightPanel(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            if (currentButton != null)
            {
                if (currentButton.Tag?.ToString() == "add")
                    backlightPanel.Top = flowLayoutPanel1.Top + panelGroupAdd.Top;
                else
                {
                    this.backlightPanel.Height = currentButton.Height;
                    this.backlightPanel.Top = this.flowLayoutPanel1.Top + currentButton.Top;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);

            timer.Start();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
        }

        private void panelGroupAdd_MouseClick(object sender, MouseEventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelGroupAdd.Height += 10;
                if (panelGroupAdd.Size == panelGroupAdd.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelGroupAdd.Height -= 10;
                if (panelGroupAdd.Size == panelGroupAdd.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }

        
    }
}
