using System;
using System.Drawing;

using CitrusDB.Model;

namespace CitrusDB.View.EntitiesInfo.GroupInfo
{
    interface IGroupInfoForm
    {
        int Id { get; }

        string GroupName { get; set; }
        Image Photo { get; set; }
        object Students { get; set; }

        event HeaderGridMouseClick HeaderMouseClick;
        event EventHandler LoadForm;
    }
}
