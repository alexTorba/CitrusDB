using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity
{
    public class Student : IEntity, IEqualityComparer<Student>
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public string Сitizenship { get; set; }
        public string KnowledgeOfLanguage { get; set; }

        public byte[] FirstPhoto { get; set; }
        public byte[] SecondPhoto { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public bool Equals(Student x, Student y)
        {
            if (x.FirstName == y.FirstName &&
                x.LastName == y.LastName &&
                x.MiddleName == y.MiddleName &&
                x.DateOfBirth == y.DateOfBirth &&
                x.Height == y.Height &&
                x.Weight == y.Weight &&
                x.Сitizenship == y.Сitizenship &&
                x.KnowledgeOfLanguage == y.KnowledgeOfLanguage &&
                 EqualityComparer<byte[]>.Default.Equals(x.FirstPhoto, y.FirstPhoto) &&
                 EqualityComparer<byte[]>.Default.Equals(x.SecondPhoto, y.SecondPhoto) &&
                 x.Group?.Id == y.Group?.Id)
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            var hashCode = 888452537;
            hashCode = hashCode * -1521134295 + obj.Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.LastName);

            return hashCode;
        }

        public void SetCopy(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            MiddleName = student.MiddleName;
            DateOfBirth = student.DateOfBirth;
            Height = student.Height;
            Weight = student.Weight;
            Сitizenship = student.Сitizenship;
            KnowledgeOfLanguage = student.KnowledgeOfLanguage;
            FirstPhoto = student.FirstPhoto;
            SecondPhoto = student.SecondPhoto;
            Group = student.Group;
        }
    }
}
