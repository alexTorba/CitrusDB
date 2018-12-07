using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Entity.History
{
    public interface IEntityHistory
    {
        int Id { get; set; }
        string TypeOfOperation { get; set; }
        DateTime Time { get; set; }
    }
}
