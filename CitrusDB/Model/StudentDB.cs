using System;
using System.Data.Entity;
using System.Linq;

namespace CitrusDB
{

    public class StudentDB : DbContext
    {

        public StudentDB()
            : base("name=StudentDB")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }


}