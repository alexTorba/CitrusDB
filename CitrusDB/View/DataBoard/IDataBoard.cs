using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace CitrusDB.View.DataBoard
{
    public interface IDataBoard
    {
        event EventHandler LoadDataBoard;
        event EventHandler GroupTableLoad;
        void UpdateView();

        object GetDataSource { get; set; }
    }
}
