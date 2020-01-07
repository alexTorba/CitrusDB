using System.Collections.Generic;
using Newtonsoft.Json;

namespace CitrusDB.Model.Entity
{
  public class Student : IEntity, IEqualityComparer<Student>
  {
    [JsonProperty("i")] public int Id { get; set; }
    [JsonProperty("f")] public string FirstName { get; set; }
    [JsonProperty("l")] public string LastName { get; set; }
    [JsonProperty("m")] public string MiddleName { get; set; }
    [JsonProperty("d")] public string DateOfBirth { get; set; }
    [JsonProperty("h")] public float Height { get; set; }
    [JsonProperty("w")] public float Weight { get; set; }

    [JsonProperty("c")] public string Сitizenship { get; set; }
    [JsonProperty("k")] public string KnowledgeOfLanguage { get; set; }

    [JsonProperty("fp")] public byte[] FirstPhoto { get; set; }
    [JsonProperty("sp")] public byte[] SecondPhoto { get; set; }

    [JsonProperty("gi")] public int? GroupId { get; set; }

    public bool Equals(Student x, Student y)
    {
      return x.FirstName == y.FirstName &&
             x.LastName == y.LastName &&
             x.MiddleName == y.MiddleName &&
             x.DateOfBirth == y.DateOfBirth &&
             x.Height == y.Height &&
             x.Weight == y.Weight &&
             x.Сitizenship == y.Сitizenship &&
             x.KnowledgeOfLanguage == y.KnowledgeOfLanguage &&
             EqualityComparer<byte[]>.Default.Equals(x.FirstPhoto, y.FirstPhoto) &&
             EqualityComparer<byte[]>.Default.Equals(x.SecondPhoto, y.SecondPhoto);
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
    }
  }
}