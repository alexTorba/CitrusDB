using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Model
{
    class Model
    {

        #region New

        public List<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            return (List<TEntity>)EFGenericRepositorySecondary<TEntity>.Get();
        }

        public List<TEntity> GetEntityView<TEntity>() where TEntity : class
        {
            return (List<TEntity>)EFGenericRepositorySecondary<TEntity>.GetView();
        }

        public TEntity GetEntityById<TEntity>(int id) where TEntity : class
        {
            return EFGenericRepositorySecondary<TEntity>.FindById(id);
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepositorySecondary<TEntity>.Create(entity);
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepositorySecondary<TEntity>.Delete(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepositorySecondary<TEntity>.Update(entity);
        }

        #endregion

        public List<Student> GetStudents()
        {
            return (List<Student>)EFGenericRepositorySecondary<Student>.Get();
            //return DataBase.GetStudents();
        }

        public List<StudentView> GetStudentsView()
        {
            return (List<StudentView>)EFGenericRepositorySecondary<StudentView>.GetView();
            //return DataBase.GetStudentsView();
        }

        public void AddStudent(Student student)
        {
            EFGenericRepositorySecondary<Student>.Create(student);
            //DataBase.AddStudent(student);
        }

        public Student GetStudentById(int id)
        {
            return EFGenericRepositorySecondary<Student>.FindById(id);
            //return DataBase.GetStudentById(id);
        }

        public List<Student> GetStudentsWithGroup()
        {
            //can work with another DbContex ??
            return DataBase.GetStudentsWithGroup();
        }

        //async public void AddStudentAsync(Student student)
        //{
        //    db.Students.Add(student);
        //    await db.SaveChangesAsync();
        //}

        public void AddGroup(Group group)
        {
            EFGenericRepositorySecondary<Group>.Create(group);
            //DataBase.AddGroup(group);
        }

        public List<GroupView> GetGroupViews()
        {
            return (List<GroupView>)EFGenericRepositorySecondary<GroupView>.GetView();
            //return DataBase.GetGroupsView();
        }

        public List<Group> GetGroups()
        {
            return (List<Group>)EFGenericRepositorySecondary<Group>.Get();
            //return DataBase.GetGroups();
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
