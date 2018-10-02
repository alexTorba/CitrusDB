using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;

namespace CitrusDB
{
    class InitDB : DropCreateDatabaseAlways<StudentDB>
    {
        protected override void Seed(StudentDB context)
        {
            FileStream stream = new FileStream(@"C:\Users\Александр\Documents\Visual Studio 2015\Projects\PrisonerWinF\prisonersPhoto\1\2-Ф.jpg", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            Student student1 = new Student
            {
                DateOfBirth = 13.ToString(),
                FirstName = "Max",
                LastName = "Torba",
                MiddleName = "Olegovich",
                Weight = 130,
                Height = 203,
                KnowledgeOfLanguage = "English, Russian, ",
                Сitizenship = "Ukraine"
            };
            student1.FirstPhoto = new byte[stream.Length];

            stream.Read(student1.FirstPhoto, 0, student1.FirstPhoto.Length);

            context.Students.AddRange(new List<Student> { student1 });
            context.SaveChanges();
        }
    }
}
