using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CitrusDB.DB
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

        public static List<StudentView> GetStudentsView()
        {
            var rezult =  db.Database.SqlQuery<StudentView>("SELECT * FROM StudentView");

            return rezult.ToList();
        }

        public static List<Student> GetStudentsWithGroup()
        {
            db.Groups.Load();
            return db.Students.Local.ToList();
        }

        public static Student GetStudentById(int id)
        {
            return db.Students.Local.First(s => s.Id == id);
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

        public static List<GroupView> GetGroupsView()
        {
            return db.Database.SqlQuery<GroupView>("SELECT * FROM GroupView").ToList();
        }

        public static List<Group> GetGroups()
        {
            if (db.Groups.Local.Count == 0)
                db.Groups.Load();

            return db.Groups.Local.ToList();
        }

        public static async Task<List<Group>> GetGroupsAsync()
        {
            return await Task<List<Group>>.Factory.StartNew(() =>
            {
                if (db.Groups.Local == null)
                    db.Groups.LoadAsync();

                return db.Groups.Local.ToList();
            });
        }

    }
}
