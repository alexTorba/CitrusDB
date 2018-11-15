using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddStudent;
using CitrusDB.View.AddStudent.GroupViews;
using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Presenter
{
    class AddStudentBoardPresenter
    {

        readonly IAddStudentBoard addStudentBoard;
        readonly IGroupView groupView;
        Validate validate = new Validate();

        public AddStudentBoardPresenter(IAddStudentBoard addStudentBoard, IGroupView groupView)
        {
            this.addStudentBoard = addStudentBoard;
            this.groupView = groupView;

            this.addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
            this.addStudentBoard.ClearButton += AddStudentBoard_ClearButton;
            this.addStudentBoard.GenerateButton += AddStudentBoard_GenerateButton;

            this.addStudentBoard.LoadBoard += AddStudentBoard_LoadBoard;
            this.addStudentBoard.ControlEnter += AddStudentBoard_ControlEnter;

            this.addStudentBoard.TextBoxTextChanged += AddStudentBoard_TextBoxTextChanged;

            this.addStudentBoard.ComboBoxTextUpdate += AddStudentBoard_ComboBoxTextUpdate;
            this.addStudentBoard.ComboBoxSelectionChange += AddStudentBoard_ComboBoxSelectionChange;

            this.addStudentBoard.PhotoLoaded += AddStudentBoard_PhotoLoaded;

            this.addStudentBoard.NumericUDValueChanged += AddStudentBoard_NumericUDValueChanged;
            this.addStudentBoard.NumericUDValueEnter += AddStudentBoard_NumericUDValueEnter;
        }

        #region Event Handlers

        private void GroupView_ClearOtherBoard(object sender, EventArgs e)
        {
            foreach (var groupView in addStudentBoard.GroupsCollection.Cast<IGroupView>())
                groupView.ChangeColorToBase();
        }

        private void AddStudentBoard_GenerateButton(object sender, EventArgs e)
        {
            (string p1, string p2) = Generate.GetPhotos();

            //numbericUD
            validate.SetState(addStudentBoard.DateOfBirth == addStudentBoard.InitDateOfBirth, true);
            addStudentBoard.DateOfBirth = Generate.GetDateOfBirth();
            addStudentBoard.ProgressBarValue =
                            validate.FillingProgressBarLogic(addStudentBoard.ProgressBarValue, 10);

            foreach (Control control in addStudentBoard.GetBoardControls)
            {
                if (control is TextBox textBox)
                {
                    AddStudentBoard_ControlEnter(textBox, EventArgs.Empty);
                    textBox.FillControl();
                }
                else if (control is ComboBox comboBox)
                {
                    AddStudentBoard_ControlEnter(comboBox, EventArgs.Empty);
                    comboBox.FillControl();
                    AddStudentBoard_ComboBoxSelectionChange(comboBox, EventArgs.Empty);
                }
                else if (control is PictureBox pictureBox)
                {
                    AddStudentBoard_ControlEnter(pictureBox, EventArgs.Empty);

                    if (pictureBox.Name == "pictureBoxFirstPhoto")
                        pictureBox.Load(p1);
                    else
                        pictureBox.Load(p2);

                    AddStudentBoard_PhotoLoaded(pictureBox, EventArgs.Empty);
                    addStudentBoard.HidePhotoLabels();
                }
            }
        }

        #region NumericUP

        private void AddStudentBoard_NumericUDValueEnter(object sender, EventArgs e)
        {
            validate.SetState(addStudentBoard.DateOfBirth == addStudentBoard.InitDateOfBirth, true);
        }

        private void AddStudentBoard_NumericUDValueChanged(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as NumericUpDown);
        }

        #endregion

        #region ComboBox

        private void AddStudentBoard_ComboBoxSelectionChange(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as ComboBox);
        }

        private void AddStudentBoard_ComboBoxTextUpdate(object sender, EventArgs e)
        {
            ControlHaveMistake(sender as ComboBox);
        }

        #endregion

        #region TextBox

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

        #endregion

        #region Buttons

        private void AddStudentBoard_ClearButton(object sender, EventArgs e)
        {
            addStudentBoard.DateOfBirth = addStudentBoard.InitDateOfBirth;
            addStudentBoard.ProgressBarValue = 0;
            GroupView_ClearOtherBoard(null, EventArgs.Empty);
            validate.Reset();
        }

        private void AddStudentBoard_SaveButton(object sender, EventArgs e)
        {
            var selectedGroup = addStudentBoard.GroupsCollection
                .Cast<IGroupView>()
                .FirstOrDefault(gv => gv.IsSelected == true);

            Student student = new Student
            {
                Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
                FirstName = addStudentBoard.GetFirstName.Trim(),
                LastName = addStudentBoard.GetLastName.Trim(),
                MiddleName = addStudentBoard.GetMiddleName.Trim(),
                Сitizenship = addStudentBoard.GetCitizenship.Trim(),
                FirstPhoto = addStudentBoard.GetFirstPhoto.ConvertImageToByteArr(),
                SecondPhoto = addStudentBoard.GetSecondPhoto.ConvertImageToByteArr(),
                DateOfBirth = addStudentBoard.DateOfBirth.Trim(),
                Height = addStudentBoard.GetGrowth,
                Weight = addStudentBoard.GetWeight,
                KnowledgeOfLanguage = addStudentBoard.GetKnowledgeOfLanguage.Trim(),
                Group = EFGenericRepository.FindById<Group>(selectedGroup.Id) ?? null
            };

            EFGenericRepository.Create(student);
            AddStudentBoard_ClearButton(null, EventArgs.Empty);

            MessageBox.Show("Added student was successful !");
        }

        #endregion

        #region PictureBox

        private void AddStudentBoard_PhotoLoaded(object sender, EventArgs e)
        {
            ControlIsConfirmed(sender as PictureBox);
        }

        #endregion

        private void AddStudentBoard_ControlEnter(object sender, EventArgs e)
        {
            if (sender is Control control)
                validate.SetState(control.HaveMistake());
        }

        private void AddStudentBoard_LoadBoard(object sender, EventArgs e)
        {
            List<Group> groups = EFGenericRepository.Get<Group>().ToList();
            List<IGroupView> listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Count; i++)
            {
                IGroupView groupView = listGroupViews[i].FillGroup(groups[i]);
                groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
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
