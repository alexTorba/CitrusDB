using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity
{
    class EqulityEntityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.Id == y.Id)
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            var hashCode = 573123138;
            hashCode = hashCode * -1521134295 + obj.Id.GetHashCode();
            hashCode = hashCode * -1521134295 + obj.Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(obj.LastName);
            return hashCode;
        }
    }
}
