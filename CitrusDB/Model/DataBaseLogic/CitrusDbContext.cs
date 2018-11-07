using System;
using System.Data.Entity;
using System.Data.SqlClient;
using CitrusDB.Model.Entity;

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

        //public DbSet<StudentView> StudentViews { get; set; }
        //public DbSet<GroupView> GroupViews { get; set; }

    }
}