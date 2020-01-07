using System;
using System.Globalization;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Students.StudentsView.StudentInfo;

namespace CitrusDB.Presenter.Students
{
  class StudentInfoFormPresenter
  {
    private readonly IStudentInfoForm _studentInfoForm;

    public StudentInfoFormPresenter(IStudentInfoForm studentInfoForm)
    {
      _studentInfoForm = studentInfoForm;

      _studentInfoForm.FormLoad += StudentInfoForm_FormLoad;
    }

    private void StudentInfoForm_FormLoad(object sender, EventArgs e)
    {
      var student = EFGenericRepository.Find<Student>(_studentInfoForm.Id);

      FillView(student);
    }

    private void FillView(Student student)
    {
      _studentInfoForm.FirstName = student.FirstName;
      _studentInfoForm.LastName = student.LastName;
      _studentInfoForm.MiddleName = student.MiddleName;
      _studentInfoForm.Weight = student.Weight.ToString(CultureInfo.InvariantCulture);
      _studentInfoForm.Height = student.Height.ToString(CultureInfo.InvariantCulture);
      _studentInfoForm.Сitizenship = student.Сitizenship;
      _studentInfoForm.KnowledgeOfLanguage = student.KnowledgeOfLanguage;
      _studentInfoForm.DateOfBirth = student.DateOfBirth;
      // _studentInfoForm.Group = student.Group == null ? null : EFGenericRepository.Find<Group>(student.Group.Id);

      _studentInfoForm.FirstPhoto = student.FirstPhoto.ConvertByteArrToImage();
      _studentInfoForm.SecondPhoto = student.SecondPhoto.ConvertByteArrToImage();
    }
  }
}