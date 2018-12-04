using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity
{
    public class Group : IEntity, IComparable<Group>, IEqualityComparer<Group>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }

        public IList<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Group other)
        {
            return Name.CompareTo(other.Name);
        }

        public void SetCopy(Group group)
        {
            Id = group.Id;
            Name = group.Name;
            Photo = group.Photo;
            Students = group.Students;
        }

        public bool Equals(Group x, Group y)
        {
            if (x.Id == y.Id &&
               x.Name == y.Name &&
               EqualityComparer<byte[]>.Default.Equals(x.Photo, y.Photo) &&
               x.Students.SequenceEqual(y.Students, new StudentsEqualityComarer()))
                return true;

            return false;
        }

        public int GetHashCode(Group obj)
        {
            var hashCode = 888452537;
            hashCode = hashCode * -1521134295 + obj.Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.Name);

            return hashCode;
        }

    }
}
