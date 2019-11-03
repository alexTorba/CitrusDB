using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CitrusDB.View.UsersElements.Dialogs;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.Extensions;

namespace CitrusDB.View.Groups.AddGroup
{
  public partial class AddGroupBoard : UserControl, IAddGroupBoard
  {
    private MainForm _mainForm;

    public AddGroupBoard()
    {
      InitializeComponent();

      comboBoxOrderBy.DataSource = new List<string>
            {
                "FirstName",
                "LastName",
                "MiddleName",
                "Height",
                "Weight",
                "Сitizenship",
                "KnowledgeOfLanguage"
            };
    }

    public void InitGroupBoard(MainForm mainForm)
    {
      _mainForm = mainForm;
    }

    #region IAddGroupBoard

    public ControlCollection CurrentStudentControlCollection => currentStudentFlowPanel.Controls;

    public ControlCollection AddedStudentControlCollection => addedStudentFlowPanel.Controls;

    public string CountOfAddedStudent
    {
      get => countOfStudentsLabel.Text;
      set => countOfStudentsLabel.Text = value;
    }

    public string GetNameOfGroup => nameGroupTextBox.Text;

    public Image GetGroupPhoto => photoPictureBox.Image;

    public void ClearView()
    {
      nameGroupTextBox.Text = string.Empty;
      photoPictureBox.Image = null;
      photoLabel.Visible = true;
    }

    public void DisableCurrentStudentPanel()
    {
      currentStudentFlowPanel.Enabled = false;
    }

    public void EnableCurrentStudentPanel()
    {
      currentStudentFlowPanel.Enabled = true;
    }

    public event EventHandler LoadGroupBoard;
    public event EventHandler ChangeAddedStudentPanelControl;
    public event EventHandler ClearClick;
    public event Func<bool> SaveClick;
    public event SearchingEventHandler CurrentStudentSearchTextBoxChanges;
    public event EventHandler UpdateView;
    public event OrderByHandler OrderBy;

    #endregion

    #region Forwarding Events

    private void AddGroupBoard_Load(object sender, EventArgs e)
    {
      LoadGroupBoard?.Invoke(sender, e);

      countOfStudentsLabel.Text = addedStudentFlowPanel.Controls.Count.ToString();

      InitComboBox();

      radioButtonAscend.Checked = true;
    }

    private void InitComboBox()
    {
      comboBoxWhere.DataSource = new List<string>
            {
                "FirstName",
                "LastName",
                "MiddleName",
                "Height",
                "Weight",
                "Сitizenship",
                "KnowledgeOfLanguage"
            };

      comboBoxOrderBy.DataSource = new List<string>
            {
                "FirstName",
                "LastName",
                "MiddleName",
                "Height",
                "Weight",
                "Сitizenship",
                "KnowledgeOfLanguage"
            };
    }

    private void addedStudentFlowPanel_ControlAdded(object sender, ControlEventArgs e)
    {
      ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
    }

    private void addedStudentFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
    {
      ChangeAddedStudentPanelControl?.Invoke(sender, EventArgs.Empty);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      _mainForm.SetStatusValue = "Clearing view..";

      ClearClick?.Invoke(sender, e);

      _mainForm.SetInitStatus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (SaveClick != null)
      {
        if (SaveClick.Invoke())
        {
          _mainForm.SetStatusValue = "Saving group..";
          new SuccessfulDialog("Group added successfully !").Show();
          _mainForm.SetInitStatus();
        }
      }
    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
      _mainForm.SetStatusValue = "Searching students..";

      CurrentStudentSearchTextBoxChanges.Invoke((sender as TextBox).Text, comboBoxWhere.SelectedItem.ToString(), null);

      _mainForm.SetInitStatus();
    }

    public void UpdateCurrentStudentView()
    {
      _mainForm.SetStatusValue = "Updating view..";

      UpdateView?.Invoke(null, EventArgs.Empty);
      currentStudentFlowPanel.Refresh();
      _mainForm.SetInitStatus();
    }

    #endregion

    #region Event Handlers

    private void addedStudentSearchTextBox_MouseClick(object sender, MouseEventArgs e)
    {
      var textBox = sender as TextBox;
      textBox.SelectionStart = 0;
      textBox.SelectionLength = textBox.Text.Length;
    }

    private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
    {
      addedStudentSearchTextBox_MouseClick(sender, e);
    }

    private void photoPictureBox_MouseClick(object sender, MouseEventArgs e)
    {
      var pictureBox = sender as PictureBox;
      var openFile = new OpenFileDialog();

      if (openFile.ShowDialog() == DialogResult.OK)
        pictureBox.Load(openFile.FileName);

      if (pictureBox.Image != null)
        photoLabel.Visible = false;
    }

    public void DisableAddedStudentPanel()
    {
      addedStudentFlowPanel.Enabled = false;
    }

    public void EnableAddedStudentPanel()
    {
      addedStudentFlowPanel.Enabled = true;
    }

    #endregion

    private void searchSettingsButton_Click(object sender, EventArgs e)
    {
      _mainForm.timer.Start();

      _mainForm.ClearEventHandlers();
      _mainForm.TimerTiks += flowPanelSearchSettings.TicksGrowsHeightQuickly;
    }

    private void buttonWhere_Click(object sender, EventArgs e)
    {
      _mainForm.timer.Start();

      _mainForm.ClearEventHandlers();
      _mainForm.TimerTiks += panelWhere.TicksGrowsHeight;
    }

    private void buttonOrderBy_Click(object sender, EventArgs e)
    {
      _mainForm.timer.Start();

      _mainForm.ClearEventHandlers();
      _mainForm.TimerTiks += panelOrderBy.TicksGrowsHeight;
    }

    private void orderByButton_Click(object sender, EventArgs e)
    {
      OrderBy?.Invoke(sender, new OrderByEventArgs(comboBoxOrderBy.SelectedItem.ToString(), radioButtonAscend.Checked));
    }
  }
}
