using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Data.Entity.SqlServer;
using CitrusDB.DB;

namespace CitrusDB
{
    class Model
    {

        public List<Student> GetStudents()
        {
            return DataBase.GetStudents();
        }

        public void AddStudent(Student student)
        {
            DataBase.AddStudent(student);
        }

        public Student GetStudentById(int id)
        {
            return DataBase.GetStudentById(id);
        }
        //async public void AddStudentAsync(Student student)
        //{
        //    db.Students.Add(student);
        //    await db.SaveChangesAsync();
        //}

        public void AddGroup(Group group)
        {
            DataBase.AddGroup(group);
        }

        //async public void AddGroupAsync(Group group)
        //{
        //    db.Groups.Add(group);
        //    await db.SaveChangesAsync();
        //}

    }
}
