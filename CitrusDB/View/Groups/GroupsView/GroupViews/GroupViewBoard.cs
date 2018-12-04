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

namespace CitrusDB.View.Groups.GroupsView.GroupViews
{
    public partial class GroupViewBoard : UserControl, IGroupView
    {

        public GroupViewBoard()
        {
            InitializeComponent();

            SetMouseClickHandler();

            initColor = Parent?.BackColor ?? colorSeparator1.LineColor;
            selectedColor = Color.LimeGreen;
        }

        public GroupViewBoard(Color selectedColor) : this()
        {
            this.selectedColor = selectedColor;
        }

        #region IGroupView

        public int Id { get; set; }

        public string GroupName { get => nameLabel?.Text; private set => nameLabel.Text = value; }

        public int CountOfStudent
        {
            get => int.Parse(countLabel.Text);
            set => countLabel.Text = value.ToString();
        }

        public bool IsSelected { get; set; }

        public Color selectedColor { get; set; }
        public Color initColor { get; set; }

        public object Clone()
        {
            IGroupView groupView = new GroupViewBoard
            {
                Id = Id,
                GroupName = GroupName,
                CountOfStudent = countLabel?.Text == "" ? 0 : countLabel != null ? int.Parse(countLabel.Text) : 0,
            };
            groupView.ClearOtherBoard += ClearOtherBoard;
            groupView.selectedColor = selectedColor;
            groupView.initColor = initColor;

            return groupView;
        }

        public IEntityControlView<Group> FillView(Group entity)
        {
            Id = entity.Id;
            nameLabel.Text = entity.Name;
            photoGroupPictureBox.Image = entity.Photo.ConvertByteArrToImage();
            countLabel.Text = entity.Students.Count.ToString();
            BackColor = System.Drawing.Color.White;
            return this;
        }

        public void SetCopy(IEntityControlView<Group> newEntity)
        {
            GroupName = ((GroupViewBoard)newEntity).GroupName;
            photoGroupPictureBox.Image = ((GroupViewBoard)newEntity).photoGroupPictureBox.Image;
            CountOfStudent = ((GroupViewBoard)newEntity).CountOfStudent;
        }

        public void ChangeColorToBase()
        {
            colorSeparator1.LineColor = initColor;
            colorSeparator2.LineColor = initColor;
            colorSeparator3.LineColor = initColor;
            colorSeparator4.LineColor = initColor;

            IsSelected = false;
        }

        public event EventHandler ClearOtherBoard;

        #endregion

        public void ResetOtherBoard()
        {
            ClearOtherBoard?.Invoke(this, EventArgs.Empty);
        }

        private void SetMouseClickHandler()
        {
            foreach (Control control in Controls)
                control.Click += MouseClickHandler;

            Click += MouseClickHandler;
        }

        private void MouseClickHandler(object sender, EventArgs e)
        {
            if (colorSeparator1.LineColor == initColor)
            {
                ResetOtherBoard();
                ChangeColor(selectedColor);
                IsSelected = true;
            }
            else
            {
                ChangeColorToBase();
                IsSelected = false;
            }
        }

        public void SelectView()
        {
            ResetOtherBoard();

            ChangeColor(selectedColor);
            IsSelected = true;
        }

        private void ChangeColor(Color color)
        {
            colorSeparator1.LineColor = color;
            colorSeparator2.LineColor = color;
            colorSeparator3.LineColor = color;
            colorSeparator4.LineColor = color;
        }

    }
}
