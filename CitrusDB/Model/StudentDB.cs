using System;
using System.Data.Entity;
using System.Linq;

namespace CitrusDB
{
    internal class StudentDB : DbContext
    {
        static StudentDB()
        {
            //Database.SetInitializer(new InitDB());
        }

        public StudentDB()
            : base("StudentDB")
        {
        }

        public  DbSet<Student> Students { get; set; }
        public  DbSet<Group> Groups { get; set; }
    }
}