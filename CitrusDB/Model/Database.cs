using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CitrusDB
{
    static class DataBase
    {
        static readonly StudentDB db;
        static DataBase()
        {
            db = new StudentDB();
            db.Students.Load();
        }

        public static List<Student> GetStudents()
        {
            return db.Students.Local.ToList();
        }

        public static void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void AddGroup(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();
        }

    }
}
