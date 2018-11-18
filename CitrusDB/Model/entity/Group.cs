using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity
{
    public class Group : IEntity
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

    }
}
