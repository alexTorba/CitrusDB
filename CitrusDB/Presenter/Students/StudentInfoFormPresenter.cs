using System;

using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.View.Students.StudentsView.StudentInfo;

namespace CitrusDB.Presenter.Students
{

    class StudentInfoFormPresenter
    {
        readonly IStudentInfoForm studentInfoForm;

        public StudentInfoFormPresenter(IStudentInfoForm studentInfoForm)
        {
            this.studentInfoForm = studentInfoForm;

            this.studentInfoForm.FormLoad += StudentInfoForm_FormLoad;
        }

        private void StudentInfoForm_FormLoad(object sender, EventArgs e)
        {
            var student = EFGenericRepository.FindById<Student>(studentInfoForm.Id);

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
            studentInfoForm.Group = student.Group == null ? null : EFGenericRepository.FindById<Group>(student.Group.Id);

            studentInfoForm.FirstPhoto = student.FirstPhoto.ConvertByteArrToImage();
            studentInfoForm.SecondPhoto = student.SecondPhoto.ConvertByteArrToImage();
        }

    }
}
