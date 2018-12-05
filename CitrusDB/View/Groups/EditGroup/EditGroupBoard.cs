using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            editGroupBoardFirst.UpdatingView();

            if (mainForm != null)
            {
                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += panelEditGroupBoardSecond.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        private void EditGroupBoardFirst_LoadSecondForm(object sender, EventArgs e)
        {
            editGroupBoardSecond?.SetGroup(editGroupBoardFirst?.EditGroup);

            if (mainForm != null)
            {
                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += panelEditGroupBoardSecond.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        public void InitField(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        

    }
}
