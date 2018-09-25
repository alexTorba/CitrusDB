using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CitrusDB
{
    class Model
    {
        StudentDB db;
        public Model()
        {
            db = new StudentDB();
            db.Students.Load();
        }

        public List<Student> FillDataGrid()
        {
            return db.Students.Local.ToList();
            //return db.Students.ToList();
        }

    }
}
