using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.UsersEventArgs
{
    public delegate void OrderByHandler(object sender, OrderByEventArgs e);

    public class OrderByEventArgs : EventArgs
    {
        public string OrderCriteria { get; }
        public bool IsAscending { get; }

        public OrderByEventArgs(string orderCriteria, bool isAscending)
        {
            OrderCriteria = orderCriteria;
            this.IsAscending = isAscending;
        }

    }
}
