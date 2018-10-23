using System;
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

        public AddStudentBoardPresenter(IAddStudentBoard addStudentBoard, IGroupView groupView)
        {
            this.addStudentBoard = addStudentBoard;
            this.groupView = groupView;

            this.addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
            this.addStudentBoard.LoadBoard += AddStudentBoard_LoadBoard;
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

    }
}
