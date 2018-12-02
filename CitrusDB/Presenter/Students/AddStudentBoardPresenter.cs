using System;
using System.Linq;

using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.View.Students.AddStudent;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model;
using System.Windows.Forms;
using CitrusDB.Model.Extensions;

namespace CitrusDB.Presenter.Students
{
    class AddStudentBoardPresenter : StudentBoardPresenter
    {

        IAddStudentBoard addStudentBoard;

        public AddStudentBoardPresenter(IAddStudentBoard studentBoard, IGroupView groupView) : base(studentBoard, groupView)
        {
            addStudentBoard = studentBoard;

            SetHandlers();
        }

        private void SetHandlers()
        {
            addStudentBoard.ClearButton += AddStudentBoard_ClearButton;
            addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
            addStudentBoard.GenerateButton += AddStudentBoard_GenerateButton;
        }

        #region IAddStudentBoard

        private void AddStudentBoard_GenerateButton(object sender, EventArgs e)
        {
            AddStudentBoard_ClearButton(null, EventArgs.Empty);

            (string p1, string p2) = Generate.GetPhotos();

            foreach (Control control in addStudentBoard.GetBoardControls)
            {
                if (control is TextBox textBox)
                {
                    StudentBoard_ControlEnter(textBox, EventArgs.Empty);
                    textBox.FillControl();
                }
                else if (control is ComboBox comboBox)
                {
                    StudentBoard_ControlEnter(comboBox, EventArgs.Empty);
                    comboBox.FillControl();
                    StudentBoard_ComboBoxSelectionChange(comboBox, EventArgs.Empty);
                }
                else if (control is PictureBox pictureBox)
                {
                    StudentBoard_ControlEnter(pictureBox, EventArgs.Empty);

                    if (pictureBox.Name == "pictureBoxFirstPhoto")
                        pictureBox.Load(p1);
                    else
                        pictureBox.Load(p2);

                    StudentBoard_PhotoLoaded(pictureBox, EventArgs.Empty);
                    addStudentBoard.HidePhotoLabels();
                }
                else if (control is MonthCalendar monthCalendar)
                {
                    var time = Generate.GenerateDateTime();
                    monthCalendar.SelectionRange = new SelectionRange(time, time);
                    addStudentBoard.SetInitDate();
                    monthCalendar.Select();

                    StudentBoard_MonthCalendarDateSelected(monthCalendar, EventArgs.Empty);
                }
            }
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

                Group = selectedGroup == null
                                    ? null
                                    : EFGenericRepository.FindById<Group>(selectedGroup.Id)
            };

            EFGenericRepository.Create(student);
        }

        private void AddStudentBoard_ClearButton(object sender, EventArgs e)
        {
            addStudentBoard.SetInitDate();

            addStudentBoard.ProgressBarValue = 0;

            GroupView_ClearOtherBoard(null, EventArgs.Empty);

            validate.Reset();

            addStudentBoard.ResetControls();
        }

        #endregion
    }
}
