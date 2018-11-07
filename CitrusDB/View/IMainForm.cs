using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View
{
    interface IMainForm
    {
        event EventHandler LoadMainForm;
        event EventHandler ClosingMainForm;
    }
}
