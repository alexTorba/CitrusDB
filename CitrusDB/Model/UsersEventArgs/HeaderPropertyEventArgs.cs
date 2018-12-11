using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.UsersEventArgs
{
    public delegate void HeaderGridMouseClickHandler(object sender, HeaderPropertyEventArgs e);

    public class HeaderPropertyEventArgs : EventArgs
    {
        public string SelectedHeader { get; }
        public bool isAscending { get; }
        public HeaderPropertyEventArgs(string selectedHeader, bool isAscending)
        {
            SelectedHeader = selectedHeader;
            this.isAscending = isAscending;
        }

    }
}
