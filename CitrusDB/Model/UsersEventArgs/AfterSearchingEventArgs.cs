using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.UsersEventArgs
{

    public delegate void SearchingEventHandler(string condition, string searchCriteria, AfterSearchingEventArgs e);

    public class AfterSearchingEventArgs : EventArgs
    {
        public readonly Action<string> sorting;
        public readonly string conditionSorting;

        public AfterSearchingEventArgs(Action<string> sorting, string conditionSorting)
        {
            this.sorting = sorting ?? null;
            this.conditionSorting = conditionSorting;
        }
    }
}
