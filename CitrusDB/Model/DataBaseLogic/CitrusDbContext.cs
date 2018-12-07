using System;
using System.Data.Entity;
using System.Data.SqlClient;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Entity.History;

namespace CitrusDB.Model.DataBaseLogic
{

    public class CitrusDbContext : DbContext
    {

        public CitrusDbContext()
            : base("name=StudentDB")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupsHistory> GroupsHistories { get; set; }
        public DbSet<StudentsHistory> StudentsHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ChangeStudentCRUDToStoredProcedure(modelBuilder);
            ChangecGroupCRUDToStoredProcedure(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        static void ChangeStudentCRUDToStoredProcedure(DbModelBuilder modelBuilder)
        {
            //INSERT
            modelBuilder.Entity<Student>()
                .MapToStoredProcedures(s => s.Insert(sp => sp.HasName("InsertStudent")
                  .Parameter(p => p.FirstName, "firstName")
                  .Parameter(p => p.LastName, "lastName")
                  .Parameter(p => p.MiddleName, "middleName")
                  .Parameter(p => p.DateOfBirth, "dateOfBirth")
                  .Parameter(p => p.Height, "height")
                  .Parameter(p => p.Weight, "weight")
                  .Parameter(p => p.Сitizenship, "citizenship")
                  .Parameter(p => p.KnowledgeOfLanguage, "knowledgeOfLanguage")
                  .Parameter(p => p.FirstPhoto, "firstPhoto")
                  .Parameter(p => p.SecondPhoto, "secondPhoto")
                  .Parameter(p => p.GroupId, "groupId")
                  .Result(rs => rs.Id, "Id")
                ));

            //DELETE
            modelBuilder.Entity<Student>()
                .MapToStoredProcedures(s => s.Delete(sp => sp.HasName("DeleteStudent")
                 .Parameter(p => p.Id, "Id")
                ));

            //Update
            modelBuilder.Entity<Student>()
                .MapToStoredProcedures(s => s.Update(sp => sp.HasName("UpdateStudent")
                  .Parameter(p => p.Id, "Id")
                  .Parameter(p => p.FirstName, "firstName")
                  .Parameter(p => p.LastName, "lastName")
                  .Parameter(p => p.MiddleName, "middleName")
                  .Parameter(p => p.DateOfBirth, "dateOfBirth")
                  .Parameter(p => p.Height, "height")
                  .Parameter(p => p.Weight, "weight")
                  .Parameter(p => p.Сitizenship, "citizenship")
                  .Parameter(p => p.KnowledgeOfLanguage, "knowledgeOfLanguage")
                  .Parameter(p => p.FirstPhoto, "firstPhoto")
                  .Parameter(p => p.SecondPhoto, "secondPhoto")
                  .Parameter(p => p.GroupId, "groupId")
                ));
        }

        static void ChangecGroupCRUDToStoredProcedure(DbModelBuilder modelBuilder)
        {
            //INSERT
            modelBuilder.Entity<Group>()
                .MapToStoredProcedures(s => s.Insert(sp => sp.HasName("InsertGroup")
                  .Parameter(p => p.Name, "Name")
                  .Parameter(p => p.Photo, "Photo")
                  .Result(rs => rs.Id, "Id")
                ));

            //DELETE
            modelBuilder.Entity<Group>()
                .MapToStoredProcedures(s => s.Delete(sp => sp.HasName("DeleteGroup")
                 .Parameter(p => p.Id, "Id")
                ));

            //Update
            modelBuilder.Entity<Group>()
                .MapToStoredProcedures(s => s.Update(sp => sp.HasName("UpdateGroup")
                  .Parameter(p => p.Id, "Id")
                  .Parameter(p => p.Name, "Name")
                  .Parameter(p => p.Photo, "Photo")
                ));
        }

    }
}