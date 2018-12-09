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

namespace CitrusDB.View.Statistics
{
    public partial class StatisticBoard : UserControl, IStatisticBoard
    {
        MainForm mainForm;
        StringBuilder builder = new StringBuilder();

        public StatisticBoard()
        {
            InitializeComponent();

            SetChartAreasSettings();
        }

        #region IStatisticBoard

        public IList<GroupsHistory> GroupsHistory { get; set; }
        public IList<StudentsHistory> StudentsHistory { get; set; }
        public string CountOfStudent { get => generalStudentsValue.Text; set => generalStudentsValue.Text = value; }
        public string CountOfGroup { get => generalGroupsValue.Text; set => generalGroupsValue.Text = value; }

        public event EventHnadlerAsync UpdateView;

        public async void UpdatingView()
        {
            await UpdateView?.Invoke(null, EventArgs.Empty);
            studentButton_Click(null, EventArgs.Empty);
            chart.Update();
            chart.UpdateAnnotations();
        }

        #endregion

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void collapsedButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += logContainerPanel.TicksGrowsWidthQuiсkly;

            (sender as Button)?.ChangeImageButton(logContainerPanel, Resources.left, Resources.right);

        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            logTextBox.Text = "";

            SetValueLabels("students", (IList<IEntityHistory>)StudentsHistory);
            SetChart("Student", (IList<IEntityHistory>)StudentsHistory);
            SetLog((IList<IEntityHistory>)StudentsHistory);
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
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

            chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddDays(-5).ToOADate();
            chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddDays(1).ToOADate();
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
            builder.Clear();

            if (entityHistory is IList<GroupsHistory> groupsHistory)
            {
                foreach (var item in groupsHistory)
                {
                    builder.Insert(0, $"  {item.Name,-20} \t {item.TypeOfOperation,-20} \t {item.Time,-20}" + Environment.NewLine);
                }
            }
            else if (entityHistory is IList<StudentsHistory> studentHistory)
            {
                foreach (var item in studentHistory)
                {
                    builder.Insert(0, $"  {item.FirstName,-20} \t {item.LastName,-20} \t {item.TypeOfOperation,-20} \t {item.Time,-20}" + Environment.NewLine);
                }
            }

            logTextBox.Text = builder.ToString();
        }

    }
}
