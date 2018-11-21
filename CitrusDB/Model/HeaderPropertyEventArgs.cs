using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model
{
    public delegate void HeaderGridMouseClick(object sender, HeaderPropertyEventArgs e);

    public class HeaderPropertyEventArgs : EventArgs
    {
        public string SelectedHeader { get; }

        public HeaderPropertyEventArgs(string selectedHeader)
        {
            SelectedHeader = selectedHeader;
        }

    }
}
