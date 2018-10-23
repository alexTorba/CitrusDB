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

namespace CitrusDB.View.AddStudent.GroupViews
{
    public partial class GroupView : UserControl, IGroupView
    {
        public GroupView()
        {
            InitializeComponent();

            SetMouseClickHandler();
        }

        #region IGroupView

        public int Id { get; set; }

        public string GroupName { get => nameLabel.Text; set => nameLabel.Text = value; }

        public int CountOfStudent
        {
            get => int.Parse(countLabel.Text);
            set => countLabel.Text = value.ToString();
        }

        public object Clone()
        {
            IGroupView groupView = new GroupView
            {
                Id = Id,
                GroupName = GroupName,
                CountOfStudent = countLabel.Text == "" ? 0 : int.Parse(countLabel.Text)
            };

            return groupView;
        }

        public IGroupView FillGroup(CitrusDB.Model.Entity.GroupView group)
        {
            nameLabel.Text = group.Name;
            photoGroupPictureBox.Image = group.Photo.ConvertByteArrToImage();
            countLabel.Text = group.Students.ToString();
            Id = group.Id;

            return this;
        }

        #endregion

        private void SetMouseClickHandler()
        {
            foreach (Control control in Controls)
                control.MouseClick += MouseClickHandler;

            MouseClick += MouseClickHandler;
        }

        private void MouseClickHandler(object sender, MouseEventArgs e)
        {
            if (selectedPictureBox.Visible == false)
                selectedPictureBox.Visible = true;
            else selectedPictureBox.Visible = false;
        }
        
    }
}
