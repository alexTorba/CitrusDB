using System;
using System.Data.Entity;
using System.Linq;

namespace CitrusDB
{
    internal class StudentDB : DbContext
    {
        static StudentDB()
        {
            Database.SetInitializer(new InitDB());
        }

        public StudentDB()
            : base("name=StudentDB")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
}