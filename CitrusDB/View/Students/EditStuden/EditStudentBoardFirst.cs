using System;
using System.Windows.Forms;

using CitrusDB.Properties;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using System.Collections.Generic;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Students.EditStuden
{
    public partial class EditStudentBoardFirst : UserControl, IEditStudentBoardFirst
    {

        MainForm mainForm = null;
        public bool isSecondFormOpened;

        public EditStudentBoardFirst()
        {
            InitializeComponent();
        }

        #region IEditStudentBoardFirst

        public ControlCollection StudentControlCollection => studentFlowLayoutPanel.Controls;

        public Student EditStudent { get; set; }

        public void EnablingControlCollection()
        {
            studentFlowLayoutPanel.Enabled = true;
        }

        public void DisablingControlCollection()
        {
            studentFlowLayoutPanel.Enabled = false;
        }

        public void LoadingSecondForm()
        {
            isSecondFormOpened = false;
            LoadSecondForm?.Invoke(null, EventArgs.Empty);
        }

        public event EventHandler LoadEditStudentBoardFirst;
        public event EventHandler UpdateView;
        public event SearchingEventHandler StudentSearchTextBoxChanges;
        public event EventHandler LoadSecondForm;
        public event OrderByHandler OrderBy;

        #endregion

        #region Forwarding Events

        public void UpdatingView()
        {
            UpdateView?.Invoke(null, EventArgs.Empty);
        }

        private void editStudentBoardFirst_Load(object sender, EventArgs e)
        {
            LoadEditStudentBoardFirst?.Invoke(sender, e);

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

            radioButtonAscend.Checked = true;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            StudentSearchTextBoxChanges?.Invoke((sender as TextBox).Text, comboBoxWhere.SelectedItem.ToString(), null);
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            OrderBy?.Invoke(sender, new OrderByEventArgs(comboBoxOrderBy.SelectedItem.ToString(), radioButtonAscend.Checked));
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

            mainForm.TimerTiks += TicksGrowsWidth;

            (sender as Button)?.ChangeImageButton(generPanelOptions, Resources.left, Resources.right);
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

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }

        private void searchSettingsButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += flowPanelSearchSettings.TicksGrowsHeightQuiсkly;
        }

        private void buttonWhere_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelWhere.TicksGrowsHeight;
        }

        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += panelOrderBy.TicksGrowsHeight;
        }

    }
}
