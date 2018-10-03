using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Data.Entity.SqlServer;

namespace CitrusDB
{
    class Model
    {
        StudentDB db = new StudentDB();

        public List<Student> FillDataGrid()
        {
            db.Students.Load();

            return db.Students.Local.ToList();
        }

        public void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }


        async public void AddStudentAsync(Student student)
        {
            db.Students.Add(student);
            await db.SaveChangesAsync();
        }

        public void AddGroup(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();
        }

        async public void AddGroupAsync(Group group)
        {
            db.Groups.Add(group);
            await db.SaveChangesAsync();
        }

        public byte[] ConvertImageToByteArr(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        async public Task<byte[]> ConvertImageToByteArrAsync(Image image)
        {
             return await new Task<byte[]>(() =>
             {
                 using (MemoryStream memoryStream = new MemoryStream())
                 {
                     image.Save(memoryStream, image.RawFormat);
                     return memoryStream.ToArray();
                 }
             }
            );
        }

    }
}
