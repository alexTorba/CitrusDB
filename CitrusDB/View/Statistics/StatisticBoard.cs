using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using CitrusDB.Model.Entity.History;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.Extensions;
using CitrusDB.Properties;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Statistics
{
  public partial class StatisticBoard : UserControl, IStatisticBoard
  {
    private MainForm _mainForm;
    private StringBuilder _builder;

    private int _initMinDate = -5;
    private int _initMaxDate = 1;
    private SelectedEntity _selectedEntity;

    public StatisticBoard()
    {
      InitializeComponent();

      SetChartAreasSettings();

      pictureBoxLoadingAnimation.Enabled = false;
      _builder = new StringBuilder();
    }

    #region IStatisticBoard

    public IList<GroupsHistory> GroupsHistory { get; set; }
    public IList<StudentsHistory> StudentsHistory { get; set; }
    public string CountOfStudent { get => generalStudentsValue.Text; set => generalStudentsValue.Text = value; }
    public string CountOfGroup { get => generalGroupsValue.Text; set => generalGroupsValue.Text = value; }

    public event EventHandlerAsync UpdateView;

    public async void UpdatingView()
    {
      pictureBoxLoadingAnimation.Enabled = true;
      updatingLabel.Visible = true;

      await UpdateView?.Invoke(null, EventArgs.Empty);
      studentButton_Click(null, EventArgs.Empty);
      chart.Update();
      chart.UpdateAnnotations();

      updatingLabel.Visible = false;
      pictureBoxLoadingAnimation.Enabled = false;
    }

    #endregion

    public void InitFields(MainForm mainForm)
    {
      _mainForm = mainForm;
    }

    private void collapsedButton_Click(object sender, EventArgs e)
    {
      _mainForm.timer.Start();

      _mainForm.ClearEventHandlers();
      _mainForm.TimerTiks += logContainerPanel.TicksGrowsWidthQuickly;

      (sender as Button)?.ChangeImageButton(logContainerPanel, Resources.left, Resources.right);
    }

    private void studentButton_Click(object sender, EventArgs e)
    {
      _selectedEntity = SelectedEntity.Student;

      chart.Series.Clear();
      logTextBox.Text = "";

      SetValueLabels("students", (IList<IEntityHistory>)StudentsHistory);
      SetChart("Student", (IList<IEntityHistory>)StudentsHistory);
      SetLog((IList<IEntityHistory>)StudentsHistory);
    }

    private void groupButton_Click(object sender, EventArgs e)
    {
      _selectedEntity = SelectedEntity.Group;

      chart.Series.Clear();
      logTextBox.Text = "";

      SetValueLabels("groups", (IList<IEntityHistory>)GroupsHistory);
      SetChart("Group", (IList<IEntityHistory>)GroupsHistory);
      SetLog((IList<IEntityHistory>)GroupsHistory);
    }

    private void SetChartAreasSettings()
    {
      chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
      chart.ChartAreas[0].AxisX.Interval = 1;
      chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
      chart.ChartAreas[0].AxisX.IntervalOffset = 1;

      chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(_initMinDate).ToOADate();
      chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddDays(_initMaxDate).ToOADate();
    }

    private void SetChart(string nameOfEntity, IList<IEntityHistory> entityHistory)
    {
      var dateModels = (from st in entityHistory
                        group st by new { st.TypeOfOperation, Time = st.Time.Date } into g
                        select new DateModel
                        {
                          Count = g.Count(),
                          TypeOfOperation = g.Key.TypeOfOperation,
                          Time = g.Key.Time
                        }).ToArray();

      chart.CreateSeries("Added " + nameOfEntity,
          Color.Green,
          dateModels.Where(s => s.TypeOfOperation == "Inserting").ToArray());

      chart.CreateSeries("Updated " + nameOfEntity,
          Color.Blue,
          dateModels.Where(s => s.TypeOfOperation == "Updating").ToArray());

      chart.CreateSeries("Deleted " + nameOfEntity,
          Color.Red,
          dateModels.Where(s => s.TypeOfOperation == "Deleting").ToArray());
    }

    private void SetValueLabels(string nameOfEntities, IList<IEntityHistory> entityHistories)
    {
      addedTodayLabel.Text = $"Added {nameOfEntities} :";
      deletedTodayLabel.Text = $"Deleted {nameOfEntities} :";
      updatedTodayLabel.Text = $"Updated {nameOfEntities} :";

      var historiesToday = entityHistories.Where(eh => eh.Time.Date == DateTime.Now.Date).ToArray();

      addedTodayValue.Text = historiesToday
          .Where(sh => sh.TypeOfOperation == "Inserting")
          .Count().ToString();

      deletedTodatValue.Text = historiesToday
          .Where(sh => sh.TypeOfOperation == "Deleting")
          .Count().ToString();

      updatedTodayValue.Text = historiesToday
          .Where(sh => sh.TypeOfOperation == "Updating")
          .Count().ToString();
    }

    private void SetLog(IList<IEntityHistory> entityHistory)
    {
      _builder.Clear();

      switch (entityHistory)
      {
        case IList<GroupsHistory> groupsHistory:
          foreach (var item in groupsHistory)
          {
            _builder.Insert(0, $"  {item.Name,-20} \t {item.TypeOfOperation,-20} \t {item.Time,-20}" + Environment.NewLine);
          }
          break;

        case IList<StudentsHistory> studentHistory:
          foreach (var item in studentHistory)
          {
            _builder.Insert(0, $"  {item.FirstName,-20} \t {item.LastName,-20} \t {item.TypeOfOperation,-20} \t {item.Time,-20}" + Environment.NewLine);
          }
          break;
      }

      logTextBox.Text = _builder.ToString();
    }

    private void laterButton_Click(object sender, EventArgs e)
    {
      chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(++_initMinDate).ToOADate();
      chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddDays(++_initMaxDate).ToOADate();

      if (_selectedEntity == SelectedEntity.Student)
        SetChart("Student", (IList<IEntityHistory>)StudentsHistory);
      else if (_selectedEntity == SelectedEntity.Group)
        SetChart("Group", (IList<IEntityHistory>)GroupsHistory);
    }

    private void earlierButton_Click(object sender, EventArgs e)
    {
      chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(--_initMinDate).ToOADate();
      chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddDays(--_initMaxDate).ToOADate();

      if (_selectedEntity == SelectedEntity.Student)
        SetChart("Student", (IList<IEntityHistory>)StudentsHistory);
      else if (_selectedEntity == SelectedEntity.Group)
        SetChart("Group", (IList<IEntityHistory>)GroupsHistory);
    }
  }
}
