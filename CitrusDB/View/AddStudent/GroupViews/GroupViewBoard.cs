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
    public partial class GroupViewBoard : UserControl, IGroupView
    {

        Color initColor;

        public GroupViewBoard()
        {
            InitializeComponent();

            SetMouseClickHandler();

            initColor = colorSeparator1.LineColor;
            FrameColor = Color.Green;
        }

        #region IGroupView

        public int Id { get; set; }

        public string GroupName { get => nameLabel.Text; set => nameLabel.Text = value; }

        public int CountOfStudent
        {
            get => int.Parse(countLabel.Text);
            set => countLabel.Text = value.ToString();
        }

        public Color FrameColor { get; set; }

        public object Clone()
        {
            IGroupView groupView = new GroupViewBoard
            {
                Id = Id,
                GroupName = GroupName,
                CountOfStudent = countLabel.Text == "" ? 0 : int.Parse(countLabel.Text)
            };

            return groupView;
        }

        public IGroupView FillGroup(GroupView group)
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
                control.Click += MouseClickHandler;

            Click += MouseClickHandler;
        }

        private void MouseClickHandler(object sender, EventArgs e)
        {
            if (colorSeparator1.LineColor == initColor)
                ChangeColor(Color.LimeGreen);
            else
                ChangeColor(initColor);
        }

        private void ChangeColor(Color color)
        {
            colorSeparator1.LineColor = color;
            colorSeparator2.LineColor = color;
            colorSeparator3.LineColor = color;
            colorSeparator4.LineColor = color;
        }

        private void colorSeparator4_Load(object sender, EventArgs e)
        {

        }
    }
}
