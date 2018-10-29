﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddStudent;
using CitrusDB.View.AddStudent.GroupViews;

namespace CitrusDB.Presenter
{
    class AddStudentBoardPresenter
    {

        readonly IAddStudentBoard addStudentBoard;
        readonly IGroupView groupView;
        Model.Model model = new Model.Model();
        Validate validate = new Validate();

        public AddStudentBoardPresenter(IAddStudentBoard addStudentBoard, IGroupView groupView)
        {
            this.addStudentBoard = addStudentBoard;
            this.groupView = groupView;

            this.addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
            this.addStudentBoard.LoadBoard += AddStudentBoard_LoadBoard;

            this.addStudentBoard.ControlEnter += AddStudentBoard_ControlEnter;

            this.addStudentBoard.TextBoxTextChanged += AddStudentBoard_TextBoxTextChanged;

            this.addStudentBoard.ComboBoxTextUpdate += AddStudentBoard_ComboBoxTextUpdate;
            this.addStudentBoard.ComboBoxSelectionChange += AddStudentBoard_ComboBoxSelectionChange;

            this.addStudentBoard.PhotoLoaded += AddStudentBoard_PhotoLoaded;
        }

        #region Event Handlers

        private void AddStudentBoard_PhotoLoaded(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as PictureBox);
        }

        private void AddStudentBoard_ComboBoxSelectionChange(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as ComboBox);
        }

        private void AddStudentBoard_ComboBoxTextUpdate(object sender, EventArgs e)
        {
            ControlHaveMistake(sender as ComboBox);
        }

        private void AddStudentBoard_ControlEnter(object sender, EventArgs e)
        {
            if (sender is Control control)
                validate.SetState(control.HaveMistake());
        }

        private void AddStudentBoard_TextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.CheckText())
                {
                    ControlHaveMistake(textBox);
                }
                else
                {
                    ControlIsConfirmed(textBox);
                }
            }
        }


        private void AddStudentBoard_SaveButton(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = addStudentBoard.GetFirstName,
                LastName = addStudentBoard.GetLastName,
                MiddleName = addStudentBoard.GetMiddleName,
                Сitizenship = addStudentBoard.GetCitizenship,
                FirstPhoto = addStudentBoard.GetFirstPhoto.ConvertImageToByteArr(),
                SecondPhoto = addStudentBoard.GetSecondPhoto.ConvertImageToByteArr(),
                DateOfBirth = addStudentBoard.DateOfBirth,
                Height = addStudentBoard.GetGrowth,
                Weight = addStudentBoard.GetWeight,
                KnowledgeOfLanguage = addStudentBoard.GetKnowledgeOfLanguage
            };

            model.AddStudent(student);
        }

        private void AddStudentBoard_LoadBoard(object sender, EventArgs e)
        {
            List<Model.Entity.GroupView> groups = model.GetGroupViews();
            List<IGroupView> listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Count; i++)
            {
                IGroupView groupView = listGroupViews[i].FillGroup(groups[i]);
                Control control = (Control)groupView;
                control.BackColor = System.Drawing.Color.White;

                addStudentBoard.GroupsCollection.Add(control);
            }

        }

        #endregion

        private void ControlIsConfirmed(Control control)
        {
            if (control != null)
            {
                addStudentBoard.ProgressBarValue =
                            validate.FillingProgressBarLogic(addStudentBoard.ProgressBarValue, 10);

                control.RemoveMistakeToLinkedLabel();
            }
        }

        private void ControlHaveMistake(Control control)
        {
            if (control != null)
            {
                addStudentBoard.ProgressBarValue =
                            validate.DecreaseProgressBarLogic(addStudentBoard.ProgressBarValue, 10);

                control.AddMistakeToLinkedLabel();
            }
        }

    }
}
