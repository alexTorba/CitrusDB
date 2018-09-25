using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
    interface IMainForm
    {
        event EventHandler LoadMainForm;
        object DataSource { get; set; }
    }
}
