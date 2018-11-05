using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using System.Linq.Expressions;

namespace CitrusDB.Model
{
    class Model
    {

        #region New

        public IEnumerable<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            return EFGenericRepository<TEntity>.Get();
        }

        public IEnumerable<TEntity> GetEntities<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return EFGenericRepository<TEntity>.Get(predicate);
        }

        public IEnumerable<TEntity> GetEntityView<TEntity>() where TEntity : class
        {
            return EFGenericRepository<TEntity>.GetView();
        }

        public TEntity GetEntityById<TEntity>(int id) where TEntity : class
        {
            if (id < 0)
                return null;
            return EFGenericRepository<TEntity>.FindById(id);
        }

        public IEnumerable<TEntity> GetWithInclude<TEntity>(params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
        {
            return EFGenericRepository<TEntity>.GetWithInclude(includeProperties);
        }

        public IEnumerable<TEntity> GetWithInclude<TEntity>(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class
        {
            return EFGenericRepository<TEntity>.GetWithInclude(predicate, includeProperties);
        }


        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepository<TEntity>.Create(entity);
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepository<TEntity>.Delete(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            EFGenericRepository<TEntity>.Update(entity);
        }

        #endregion

        //delete after marge with async_logic branch.
        #region Old db logic (DataBase.cs)

        public List<Student> GetStudents()
        {
            return (List<Student>)EFGenericRepository<Student>.Get();
            //return DataBase.GetStudents();
        }

        public List<StudentView> GetStudentsView()
        {
            return (List<StudentView>)EFGenericRepository<StudentView>.GetView();
            //return DataBase.GetStudentsView();
        }

        public void AddStudent(Student student)
        {
            EFGenericRepository<Student>.Create(student);
            //DataBase.AddStudent(student);
        }

        public Student GetStudentById(int id)
        {
            return EFGenericRepository<Student>.FindById(id);
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
            EFGenericRepository<Group>.Create(group);
            //DataBase.AddGroup(group);
        }

        public List<GroupView> GetGroupViews()
        {
            return (List<GroupView>)EFGenericRepository<GroupView>.GetView();
            //return DataBase.GetGroupsView();
        }

        public List<Group> GetGroups()
        {
            return (List<Group>)EFGenericRepository<Group>.Get();
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

        #endregion

    }
}
