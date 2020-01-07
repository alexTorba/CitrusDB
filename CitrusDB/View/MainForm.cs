using System;
using System.Windows.Forms;

using CitrusDB.Model.Extensions;
using CitrusDB.Model.Entity;
using CitrusDB.View.DataBoard;
using CitrusDB.View.UsersElements.FormLoading;

namespace CitrusDB.View
{
  public delegate void TimerHandler(Timer timer, object sender, EventArgs e);

  public partial class MainForm : Form, IMainForm
  {
    #region fields

    public Panel dragPanel;
    public PictureBox pictureBox1;
    public Label label1;
    public Button buttonExit;
    public Button button1;
    public Button rollUpButton;
    public Button buttonData;
    public Panel backlightPanel;
    public Button buttonAboutUs;
    public Button buttonSettings;
    public Button buttonStatistics;
    public Button buttonAdd;
    public Panel panelGroupAdd;
    public PictureBox pictureBox2;
    public Button buttonGroup;
    public Button buttonStudent;
    public PictureBox pictureBox3;
    public Panel panel1;
    public FlowLayoutPanel flowLayoutPanel1;
    public BindingSource studentBindingSource;
    public Bunifu.Framework.UI.BunifuDragControl dragControl;
    public Panel editPanel;
    public Button editButton;
    public PictureBox pictureBox4;
    public PictureBox pictureBox5;
    public Button editStudentButton;
    public Button editGroupButton;
    public Panel panel2;
    public Timer timer;
    public CitrusDB.View.DataBoard.DataBoard dataBoard;
    public Students.AddStudent.AddStudentBoard addStudentBoard;
    public Groups.AddGroup.AddGroupBoard addGroupBoard;
    public Students.EditStuden.EditStudentBoard editStudentBoard;
    public Groups.EditGroup.EditGroupBoard editGroupBoard;
    public Statistics.StatisticBoard statisticBoard;
    public AboutUs.AboutUsBoard aboutUsBoard;
    public TextBox statusTextBox;
    
    #endregion

    private readonly LoadingForm _loadingForm;
    
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

      dataBoard.ChangeEntity += DataBoard_ChangeEntity;

      _loadingForm = new LoadingForm(loadingForm);
      _loadingForm.Show();
    }

    private void DataBoard_ChangeEntity(object sender, EventArgs e)
    {
      if (((EntityArgs)e).Entity is Student student)
      {
        editStudentButton_Click(null, EventArgs.Empty);
        editStudentBoard.LoadSecondForm(student);
      }
      else if (((EntityArgs)e).Entity is Group group)
      {
        editGroupButton_Click(null, EventArgs.Empty);
        editGroupBoard.LoadSecondForm(group);
      }
    }

    #region Forwarding Events

    private void MainForm_Load(object sender, EventArgs e)
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

    private void editGroupButton_Click(object sender, EventArgs e)
    {
      ReplaceBacklightPanel(editButton, e);

      editGroupBoard.UpdateView();
      editGroupBoard.BringToFront();
    }

    private void buttonStatistics_Click(object sender, EventArgs e)
    {
      ReplaceBacklightPanel(sender, e);

      statisticBoard.UpdatingView();

      statisticBoard.BringToFront();
    }

    private void buttonSettings_Click(object sender, EventArgs e)
    {
      ReplaceBacklightPanel(sender, e);
    }

    private void buttonAboutUs_Click(object sender, EventArgs e)
    {
      ReplaceBacklightPanel(sender, e);
      aboutUsBoard.BringToFront();
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
      dataBoard.InitDataBoard(this);
      addStudentBoard.InitFields(this);
      addGroupBoard.InitGroupBoard(this);
      editStudentBoard.InitFields(this);
      editGroupBoard.InitField(this);
      statisticBoard.InitFields(this);
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
      _loadingForm?.Close();
    }

    private void rollUpButton_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }
  }
}
