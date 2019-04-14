using System;
using System.Drawing;

using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students.StudentsView.StudentInfo
{
  interface IStudentInfoForm
  {
    int Id { get; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string MiddleName { get; set; }
    string DateOfBirth { get; set; }
    string Height { get; set; }
    string Weight { get; set; }
    string Сitizenship { get; set; }
    string KnowledgeOfLanguage { get; set; }

    Group Group { get; set; }

    Image FirstPhoto { set; }
    Image SecondPhoto { set; }

    event EventHandler FormLoad;
  }
}
