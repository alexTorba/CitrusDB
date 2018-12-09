using System;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoard : UserControl
    {

        MainForm mainForm;

        public EditGroupBoard()
        {
            InitializeComponent();

            editGroupBoardFirst.LoadSecondForm += EditGroupBoardFirst_LoadSecondForm;
            editGroupBoardSecond.CancelClick += EditGroupBoardSecond_CancelClick;
        }

        public void UpdateView()
        {
            editGroupBoardFirst.UpdatingView();
            editGroupBoardSecond.UpdatingView();
        }

        private void EditGroupBoardSecond_CancelClick(object sender, EventArgs e)
        {
            editGroupBoardFirst.isSecondBoardOpened = false;
            editGroupBoardFirst.UpdatingView();

            if (mainForm != null)
            {
                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += panelEditGroupBoardSecond.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        public void LoadSecondForm(Group group)
        {
            editGroupBoardSecond?.SetGroup(group);

            if (mainForm != null && !editGroupBoardFirst.isSecondBoardOpened)
            {
                editGroupBoardFirst.isSecondBoardOpened = true;

                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += panelEditGroupBoardSecond.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        private void EditGroupBoardFirst_LoadSecondForm(object sender, EventArgs e)
        {
            LoadSecondForm(editGroupBoardFirst?.EditGroup);
        }

        public void InitField(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        

    }
}
