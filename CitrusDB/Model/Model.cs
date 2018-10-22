using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Data.Entity.SqlServer;

using CitrusDB.Model.Entity;
using CitrusDB.Model.DB;

namespace CitrusDB.Model
{
    class Model
    {

        public List<Student> GetStudents()
        {
            return DataBase.GetStudents();
        }

        public List<StudentView> GetStudentsView()
        {
            return DataBase.GetStudentsView();
        }

        public void AddStudent(Student student)
        {
            DataBase.AddStudent(student);
        }

        public Student GetStudentById(int id)
        {
            return DataBase.GetStudentById(id);
        }

        public List<Student> GetStudentsWithGroup()
        {
            return DataBase.GetStudentsWithGroup();
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

        public List<GroupView> GetGroupViews()
        {
            return DataBase.GetGroupsView();
        }

        public List<Group> GetGroups()
        {
            return DataBase.GetGroups();
        }

        public async Task<List<Group>> GetGroupsAsync()
        {
            return await DataBase.GetGroupsAsync();
        }

        //async public void AddGroupAsync(Group group)
        //{
        //    db.Groups.Add(group);
        //    await db.SaveChangesAsync();
        //}

    }
}
