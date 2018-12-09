using System;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;

namespace CitrusDB.View.Students.EditStuden
{
    public partial class EditStudentBoard : UserControl
    {

        MainForm mainForm = null;

        public EditStudentBoard()
        {
            InitializeComponent();

            editStudentBoardFirst.LoadSecondForm += EditStudentBoardFirst_LoadSecondForm;
            editStudentBoardSecond.CancelButton += EditStudentBoardSecond_CancelButton;
        }

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
            editStudentBoardFirst?.InitFields(this.mainForm);
        }

        public void UpdateView()
        {
            editStudentBoardFirst.UpdatingView();
            editStudentBoardSecond.UpdateGroupView();
        }

        private void EditStudentBoardSecond_CancelButton(object sender, EventArgs e)
        {
            editStudentBoardFirst.UpdatingView();
            editStudentBoardFirst.isSecondFormOpened = false;
            if (mainForm != null)
            {
                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        public void LoadSecondForm(Student students)
        {
            editStudentBoardSecond?.SetStudent(students);

            if (mainForm != null && !editStudentBoardFirst.isSecondFormOpened)
            {
                editStudentBoardFirst.isSecondFormOpened = true;

                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuiсkly;

                mainForm.timer.Start();
            }
        }

        private void EditStudentBoardFirst_LoadSecondForm(object sender, EventArgs e)
        {
            LoadSecondForm(editStudentBoardFirst?.EditStudent);
        }

    }
}
