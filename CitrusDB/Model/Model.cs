using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using System.IO;

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

        public void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public byte[] ConvertImageToByteArr(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }

        }

    }
}
