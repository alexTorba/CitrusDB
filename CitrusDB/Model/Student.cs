using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
     public class Student
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
    }
}
