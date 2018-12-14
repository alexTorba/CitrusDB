using System;
using System.Drawing;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups.GroupsView.GroupInfo;

namespace CitrusDB.View.Groups.GroupsView.GroupViews
{
    public partial class GroupViewBoard : UserControl, IGroupView
    {

        public GroupViewBoard()
        {
            InitializeComponent();

            SetMouseClickHandler();

            InitColor = Parent?.BackColor ?? colorSeparator1.LineColor;
            SelectedColor = Color.LimeGreen;
        }

        public GroupViewBoard(Color selectedColor) : this()
        {
            this.SelectedColor = selectedColor;
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

        public Color SelectedColor { get; set; }
        public Color InitColor { get; set; }

        public object Clone()
        {
            IGroupView groupView = new GroupViewBoard
            {
                Id = Id,
                GroupName = GroupName,
                CountOfStudent = countLabel?.Text == "" ? 0 : countLabel != null ? int.Parse(countLabel.Text) : 0,
            };
            groupView.ClearOtherBoard += ClearOtherBoard;
            groupView.SelectedColor = SelectedColor;
            groupView.InitColor = InitColor;

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
            colorSeparator1.LineColor = InitColor;
            colorSeparator2.LineColor = InitColor;
            colorSeparator3.LineColor = InitColor;
            colorSeparator4.LineColor = InitColor;

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
            if (colorSeparator1.LineColor == InitColor)
            {
                ResetOtherBoard();
                ChangeColor(SelectedColor);
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

            ChangeColor(SelectedColor);
            IsSelected = true;
        }

        private void ChangeColor(Color color)
        {
            colorSeparator1.LineColor = color;
            colorSeparator2.LineColor = color;
            colorSeparator3.LineColor = color;
            colorSeparator4.LineColor = color;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseClickHandler(null, EventArgs.Empty);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupInfoForm(Id).ShowDialog();
        }

    }
}
