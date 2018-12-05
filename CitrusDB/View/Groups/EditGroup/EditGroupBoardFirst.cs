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

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoardFirst : UserControl, IEditGroupBoardFirst
    {
        public event EventHandler LoadSecondForm;

        public EditGroupBoardFirst()
        {
            InitializeComponent();
        }

        #region IEditGroupBoardFirst

        public ControlCollection GroupCollection => groupFlowPanel.Controls;

        public Group EditGroup { get; set; }
        public int GroupId { get; set; }

        public event EventHandler LoadEditGroupBoardFirst;
        public event EventHandler EditGroupButtonClick;
        public event EventHandler UpdateView;
        public event EventHandler SearchBoxTextChanged;

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
            EditGroupButtonClick?.Invoke(sender, e);
        }

        private void searchGroupTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchBoxTextChanged?.Invoke(sender, EventArgs.Empty);
        }

        #endregion

    }
}
