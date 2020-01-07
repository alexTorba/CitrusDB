using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace CitrusDB.Model.Entity
{
  public class Group : IEntity, IComparable<Group>, IEqualityComparer<Group>
  {
    [JsonProperty("i")] public int Id { get; set; }
    [JsonProperty("n")] public string Name { get; set; }
    [JsonProperty("p")] public byte[] Photo { get; set; }

    [JsonProperty("s")] public IList<Student> Students { get; set; }

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
      return x.Id == y.Id &&
             x.Name == y.Name &&
             EqualityComparer<byte[]>.Default.Equals(x.Photo, y.Photo) &&
             x.Students.SequenceEqual(y.Students, new StudentsEqualityComparer());
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