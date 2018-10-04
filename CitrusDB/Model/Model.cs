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

        public List<Student> FillDataGrid()
        {
            return DataBase.GetStudents();
        }

        public void AddStudent(Student student)
        {
            DataBase.AddStudent(student);
        }

        //async public void AddStudentAsync(Student student)
        //{
        //    db.Students.Add(student);
        //    await db.SaveChangesAsync();
        //}

        public void AddGroup(Group group)
        {
            DataBase.AddGroup(group);
        }

        //async public void AddGroupAsync(Group group)
        //{
        //    db.Groups.Add(group);
        //    await db.SaveChangesAsync();
        //}

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

        public Image ConvertByteArrToImage(byte[] arr)
        {
            using (MemoryStream stream = new MemoryStream(arr))
            {
                return Image.FromStream(stream);
            }
        }

        public Task<Image> ConvertByteArrToImageAsync(byte[] arr)
        {
            return Task.Run(() =>
            {
                using (MemoryStream stream = new MemoryStream(arr))
                {
                    return Image.FromStream(stream);
                }
            }
            );
        }

        // can I do it ?
        public StudentViewDoard[] FillStudentViewBoards()
        {
            List<StudentViewDoard> rezult = new List<StudentViewDoard>();

            foreach (Student student in DataBase.GetStudents())
            {
                rezult.Add(new StudentViewDoard(student.FirstName, student.LastName, 
                    ConvertByteArrToImage(student.FirstPhoto)));
            }
            return rezult.ToArray();
        }

    }
}
