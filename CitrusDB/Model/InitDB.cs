using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CitrusDB
{
    class InitDB : DropCreateDatabaseAlways<StudentDB>
    {
        protected override void Seed(StudentDB context)
        {
            Student student1 = new Student
            {
                Age = 13,
                FirstName = "Max",
                LastName = "Torba",
                MiddleName = "Olegovich",
                Weight = 130,
                Height = 203,
                KnowledgeOfLanguage = "English, Russian, ",
                Сitizenship = "Ukraine"
            };
            Student student2 = new Student
            {
                Age = 20,
                FirstName = "Alex",
                LastName = "Torba",
                MiddleName = "Olegovich",
                Weight = 75,
                Height = 180,
                KnowledgeOfLanguage = "English, Russian, Ukraine",
                Сitizenship = "Ukraine"
            };

            context.Students.AddRange(new List<Student> { student1, student2 });
            context.SaveChanges();
        }
    }
}
