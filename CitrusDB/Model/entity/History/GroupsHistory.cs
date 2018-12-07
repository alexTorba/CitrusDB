using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity.History
{
    public class GroupsHistory : IEntityHistory
    {
        public int Id { get; set; }
        public string TypeOfOperation { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
