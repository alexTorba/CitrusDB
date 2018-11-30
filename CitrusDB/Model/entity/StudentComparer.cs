using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity
{
    static class StudentComparer
    {
        public static bool Equals(Student x, Student y)
        { return false; }
        //{
        //    return other != null &&
        //           Id == other.Id &&
        //           FirstName == other.FirstName &&
        //           LastName == other.LastName &&
        //           MiddleName == other.MiddleName &&
        //           DateOfBirth == other.DateOfBirth &&
        //           Height == other.Height &&
        //           Weight == other.Weight &&
        //           Сitizenship == other.Сitizenship &&
        //           KnowledgeOfLanguage == other.KnowledgeOfLanguage &&
        //           EqualityComparer<byte[]>.Default.Equals(FirstPhoto, other.FirstPhoto) &&
        //           EqualityComparer<byte[]>.Default.Equals(SecondPhoto, other.SecondPhoto) &&
        //           EqualityComparer<int?>.Default.Equals(GroupId, other.GroupId) &&
        //           EqualityComparer<Group>.Default.Equals(Group, other.Group);
        //}
    }
    
}
