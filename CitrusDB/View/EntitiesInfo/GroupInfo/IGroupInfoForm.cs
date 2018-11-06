using CitrusDB.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View.EntitiesInfo.GroupInfo
{
    interface IGroupInfoForm
    {
        int Id { get; }

        string Name { get; set; }
        Image Photo { get; set; }
        object Students { get; set; }

        event EventHandler LoadForm;
    }
}
