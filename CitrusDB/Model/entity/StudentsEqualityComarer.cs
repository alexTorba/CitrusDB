using System.Collections.Generic;

namespace CitrusDB.Model.Entity
{
  class StudentsEqualityComarer : IEqualityComparer<Student>
  {
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
  }
}