using System;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.AddStudent.GroupViews
{
    public interface IGroupView : ICloneable
    {
        int Id { get; set; }
        string GroupName { get; set; }
        int CountOfStudent { get; set; }

        IGroupView FillGroup(CitrusDB.Model.Entity.GroupView group);

    }
}
