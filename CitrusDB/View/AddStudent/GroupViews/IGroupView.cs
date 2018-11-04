using System;
using System.Drawing;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.AddStudent.GroupViews
{
    public interface IGroupView : ICloneable
    {
        int Id { get; set; }
        string GroupName { get; set; }
        int CountOfStudent { get; set; }

        IGroupView FillGroup(GroupView group);

        Color FrameColor { get; set; }
    }
}
