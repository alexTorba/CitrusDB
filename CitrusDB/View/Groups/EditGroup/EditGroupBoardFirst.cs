using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoardFirst : UserControl, IEditGroupBoardFirst
    {
        public event EventHandler LoadSecondForm;
        public bool isSecondBoardOpened;
        MainForm mainForm;

        public EditGroupBoardFirst()
        {
            InitializeComponent();
        }

        public void InitField(MainForm mainForm)
        {
            this.mainForm = mainForm;

            SetSearchSettings();
        }

        #region IEditGroupBoardFirst

        public ControlCollection GroupCollection => groupFlowPanel.Controls;

        public Group EditGroup { get; set; }
        public int GroupId { get; set; }

        public event EventHandler LoadEditGroupBoardFirst;
        public event EventHandler EditGroupButtonClick;
        public event EventHandler UpdateView;
        public event EventHandler SearchBoxTextChanged;
        public event OrderByHandler OrderBy;

        public void LoadingSecondForm()
        {
            LoadSecondForm?.Invoke(null, EventArgs.Empty);
        }

        #endregion

        #region Forwarding Events

        public void UpdatingView()
        {
            UpdateView?.Invoke(null, EventArgs.Empty);
        }

        public void LoadSecondFormHandler()
        {
            LoadSecondForm?.Invoke(null, EventArgs.Empty);
        }

        private void EditGroupBoardFirst_Load(object sender, EventArgs e)
        {
            LoadEditGroupBoardFirst?.Invoke(sender, e);
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            isSecondBoardOpened = false;
            EditGroupButtonClick?.Invoke(sender, e);
        }

        private void searchGroupTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchBoxTextChanged?.Invoke(sender, EventArgs.Empty);
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            OrderBy?.Invoke(sender, new OrderByEventArgs(comboBoxOrderBy.SelectedItem.ToString(), radioButtonAscend.Checked));
        }

        #endregion

        private void SetSearchSettings()
        {
            comboBoxOrderBy.DataSource = new List<string>
            {
                "Name"
            };

            comboBoxWhere.DataSource = new List<string>
            {
                "Name"
            };

            radioButtonAscend.Checked = true;
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
