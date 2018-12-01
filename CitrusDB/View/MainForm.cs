using System;
using System.Windows.Forms;
using CitrusDB.View.DataBoard;
using CitrusDB.View.UsersElements.FormLoading;

namespace CitrusDB.View
{
    public delegate void TimerHandler(Timer timer, object sender, EventArgs e);

    public partial class MainForm : Form, IMainForm
    {

        public LoadingForm loadingForm;
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

        public MainForm(ILoadingForm loadingForm)
        {
            InitializeComponent();

            this.loadingForm = new LoadingForm(loadingForm);
            this.loadingForm.Show();
        }

        #region Forwarding Events

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(sender, e);

            ReplaceBacklightPanel(buttonData, e);
            dataBoard?.BringToFront();

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
            editStudentBoard.UpdateView();
            editStudentBoard.BringToFront();
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

            addStudentBoard.UpdateGroupView();
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
            editStudentBoard.InitFields(this);
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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            loadingForm?.Close();
        }
    }
}
