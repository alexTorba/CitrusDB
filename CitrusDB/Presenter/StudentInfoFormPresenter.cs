using System;
using CitrusDB.Model.Entity;
using CitrusDB.View.EntitiesInfo;
using CitrusDB.View.EntitiesInfo.StudentInfo;

namespace CitrusDB.Presenter
{
    class StudentInfoFormPresenter
    {

        readonly Model.Model model = new Model.Model();
        readonly IStudentInfoForm studentInfoForm;

        public StudentInfoFormPresenter(IStudentInfoForm studentInfoForm)
        {
            this.studentInfoForm = studentInfoForm;

            this.studentInfoForm.FormLoad += StudentInfoForm_FormLoad;
        }

        private void StudentInfoForm_FormLoad(object sender, EventArgs e)
        {
            var student = model.GetEntityById<Student>(studentInfoForm.Id);

            FillView(student);
        }

        private void FillView(Student student)
        {
            studentInfoForm.FirstName = student.FirstName;
            studentInfoForm.LastName = student.LastName;
            studentInfoForm.MiddleName = student.MiddleName;
            studentInfoForm.Weight = student.Weight.ToString();
            studentInfoForm.Height = student.Height.ToString();
            studentInfoForm.Сitizenship = student.Сitizenship;
            studentInfoForm.KnowledgeOfLanguage = student.KnowledgeOfLanguage;
            studentInfoForm.DateOfBirth = student.DateOfBirth;
            studentInfoForm.Group = model.GetEntityById<Group>(student.GroupId ?? -1);

            studentInfoForm.FirstPhoto = student.FirstPhoto.ConvertByteArrToImage();
            studentInfoForm.SecondPhoto = student.SecondPhoto.ConvertByteArrToImage();
        }

    }
}
