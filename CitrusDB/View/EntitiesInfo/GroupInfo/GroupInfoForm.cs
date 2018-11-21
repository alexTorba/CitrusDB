using CitrusDB.Model.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using CitrusDB.View.EntitiesInfo.StudentInfo;
using CitrusDB.Model;

namespace CitrusDB.View.EntitiesInfo.GroupInfo
{
    public partial class GroupInfoForm : Form, IGroupInfoForm
    {
        public GroupInfoForm(int id)
        {
            InitializeComponent();

            Id = id;

            Presenter.GroupInfoFormPresenter groupInfoFormPresenter = new Presenter.GroupInfoFormPresenter(this);
        }

        #region IGroupInfoForm

        public int Id { get; }

        public Image Photo
        {
            get => photoPictureBox.Image;
            set => photoPictureBox.Image = value;
        }

        public object Students
        {
            get => studentsDataGrid.DataSource;
            set => studentsDataGrid.DataSource = value;
        }
        public string GroupName
        {
            get => groupNameValue.Text;
            set => groupNameValue.Text = value;
        }

        public event EventHandler LoadForm;
        public event HeaderGridMouseClick HeaderMouseClick;

        #endregion

        #region Forwarding Events

        private void GroupInfoForm_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(sender, e);

            countOfAddedValue.Text = (studentsDataGrid.DataSource as IEnumerable<StudentView>).Count().ToString();
            studentsDataGrid.Columns["Id"].Visible = false;
            studentsDataGrid.Columns["Group"].Visible = false;
        }

        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studentsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)studentsDataGrid.SelectedCells[0].Value;
            new StudentInfoForm(id).ShowDialog();
        }

        private void studentsDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HeaderMouseClick.Invoke(sender, 
                new HeaderPropertyEventArgs(studentsDataGrid.Columns[e.ColumnIndex].DataPropertyName));
        }
    }
}
