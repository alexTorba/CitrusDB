using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace CitrusDB
{
    interface IDataBoard
    {
        event EventHandler LoadDataBoard;
        BunifuCustomDataGrid GetDataGrid { get;}
    }
}
