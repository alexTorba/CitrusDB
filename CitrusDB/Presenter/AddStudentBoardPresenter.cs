using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.AddStudent;

namespace CitrusDB.Presenter
{
    class AddStudentBoardPresenter
    {
        readonly IAddStudentBoard addStudentBoard;
        Model.Model model = new Model.Model();

        public AddStudentBoardPresenter(AddStudentBoard addStudentBoard)
        {
            this.addStudentBoard = addStudentBoard;

            this.addStudentBoard.SaveButton += AddStudentBoard_SaveButton;
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
    }
}
