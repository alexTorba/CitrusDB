﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitrusDB.Model.Entity;
using CitrusDB.View.EntitiesInfo;

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
            var student = model.GetStudentById(studentInfoForm.Id);

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
            studentInfoForm.GroupName = student.Group.Name;

            studentInfoForm.FirstPhoto = student.FirstPhoto.ConvertByteArrToImage();
            studentInfoForm.SecondPhoto = student.SecondPhoto.ConvertByteArrToImage();
        }

    }
}
