using System;
using System.Drawing;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.AddStudent.GroupViews
{
    public interface IGroupView : IEntityControlView<Group>
    {
        string GroupName { get; set; }
        int CountOfStudent { get; set; }

        Color FrameColor { get; set; }

        bool IsSelected { get; set; }
        void ChangeColorToBase();
        event EventHandler ClearOtherBoard;

    }
}
