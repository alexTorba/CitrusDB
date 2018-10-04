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
    public delegate void TimerHandler(Timer timer, object sender, EventArgs e);

    public partial class MainForm : Form, IMainForm
    {

        #region IMainForm

        public event EventHandler LoadMainForm;

        #endregion

        public event TimerHandler TimerTiks;


        public MainForm()
        {
            InitializeComponent();
        }

        public void InitBoard()
        {
            this.addStudentBoard1.InitFields(this);
            this.dataBoard.InitDataBoard(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainForm(sender, e);

            dataBoard.BringToFront();
        }

        #region buttons handler

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
            dataBoard.BringToFront();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);


            timer.Start();
            TimerTiks = panelGroupAdd.TicksGrowsHeight;
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            this.addStudentBoard1.BringToFront();
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            this.TimerTiks.Invoke(sender as Timer, null, EventArgs.Empty);
        }


        public void ClearEventHandlers()
        {
            if (TimerTiks != null)
            {
                foreach (Delegate d in TimerTiks.GetInvocationList())
                {
                    TimerTiks -= (TimerHandler)d;
                }
            }
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

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            addGroupBoard.BringToFront();
        }

        //
    }
}
