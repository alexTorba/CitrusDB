using CitrusDB.Model.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

        public event EventHandler LoadForm;

        #endregion

        #region Forwarding Events

        private void GroupInfoForm_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(sender, e);

            countOfAddedValue.Text = (studentsDataGrid.DataSource as ICollection<Student>).Count.ToString(); 
        }

        #endregion

        private void studentsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
