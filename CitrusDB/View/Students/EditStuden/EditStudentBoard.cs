﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Presenter;
using CitrusDB.View.Students.StudentsView.EditStudentView;

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

        private void EditStudentBoardSecond_CancelButton(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.timer.Start();

                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuiсkly;
            }
        }

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
            editStudentBoardFirst.InitFields(this.mainForm);
        }

        private void EditStudentBoardFirst_LoadSecondForm(object sender, EventArgs e)
        {
            editStudentBoardSecond?.SetStudent(editStudentBoardFirst?.EditStudent);

            if (mainForm != null)
            {
                mainForm.timer.Start();

                mainForm.ClearEventHandlers();
                mainForm.TimerTiks += editStudentSecondContainerPanel.TicksGrowsWidthQuiсkly;
            }
        }
    }
}