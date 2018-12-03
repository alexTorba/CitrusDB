using System;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Groups.EditGroup
{
    interface IEditGroupBoardFirst
    {
        ControlCollection GroupCollection { get; }

        event EventHandler LoadEditGroupBoardFirst;
    }
}
