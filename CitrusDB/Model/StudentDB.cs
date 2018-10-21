using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace CitrusDB
{

    public class StudentDB : DbContext
    {

        static StudentDB()
        {
            //Database.SetInitializer(new InitDB());
        }

        public StudentDB()
            : base("name=StudentDB")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<StudentView> StudentViews { get; set; }
        public DbSet<GroupView> GroupViews { get; set; }

    }
}