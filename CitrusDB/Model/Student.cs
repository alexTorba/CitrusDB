using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public byte Age { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public string Сitizenship { get; set; }
        public string KnowledgeOfLanguage { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
