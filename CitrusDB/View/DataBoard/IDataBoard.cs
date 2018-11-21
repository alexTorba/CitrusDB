using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CitrusDB.Model.Entity;
using CitrusDB.Model;

namespace CitrusDB.View.DataBoard
{
    public interface IDataBoard
    {
        event EventHandler LoadDataBoard;
        event EventHandler GroupTableLoad;
        event HeaderGridMouseClick HeaderMouseClick;
        event EventHandler DeleteEntity;

        SelectedEntity SelectedEntity { get; set; }

        void UpdateView();

        object GetDataSource { get; set; }
    }
}
