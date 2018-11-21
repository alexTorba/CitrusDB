using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.View.DataBoard;

namespace CitrusDB.View
{
    public delegate void TimerHandler(Timer timer, object sender, EventArgs e);

    public partial class MainForm : Form, IMainForm
    {

        public event TimerHandler TimerTiks;

        #region IMainForm

        public void SetInitStatus()
        {
            statusTextBox.Text = statusTextBox.Tag.ToString();
        }

        public string SetStatusValue
        {
            get => statusTextBox.Text;
            set => statusTextBox.Text = value;
        }

        public event EventHandler LoadMainForm;
        public event EventHandler ClosingMainForm;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Forwarding Events

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainForm(sender, e);

            ReplaceBacklightPanel(buttonData, e);
            dataBoard.BringToFront();

            SetInitStatus();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingMainForm.Invoke(sender, e);
        }

        #endregion

        #region Event Handlers

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);
            dataBoard.BringToFront();

            ((IDataBoard)dataBoard).UpdateView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(sender, e);

            timer.Start();
            TimerTiks = editPanel.TicksGrowsHeight;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(editButton, e);
            
            editStudentBoardFirst.BringToFront();
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
            ReplaceBacklightPanel(buttonAdd, e);
            addStudentBoard.BringToFront();

            this.addStudentBoard.UpdateGroupView();
            //todo: update view
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            ReplaceBacklightPanel(buttonAdd, e);
            addGroupBoard.BringToFront();

            addGroupBoard.UpdateCurrentStudentView();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimerTiks.Invoke(sender as Timer, null, EventArgs.Empty);
        }

        #endregion

        public void InitBoard()
        {
            addStudentBoard.InitFields(this);
            dataBoard.InitDataBoard(this);
            editStudentBoardFirst.InitFields(this);
            addGroupBoard.InitGroupBoard(this);
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
            if (sender is Button currentButton)
            {
                if (currentButton.Parent == panelGroupAdd)
                    backlightPanel.Top = flowLayoutPanel1.Top + panelGroupAdd.Top;
                else if (currentButton.Parent == editPanel)
                    backlightPanel.Top = flowLayoutPanel1.Top + editPanel.Top;
                else
                {
                    backlightPanel.Height = currentButton.Height;
                    backlightPanel.Top = flowLayoutPanel1.Top + currentButton.Top;
                }
            }
        }

    }
}
