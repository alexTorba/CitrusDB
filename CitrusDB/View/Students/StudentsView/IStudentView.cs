using System;

using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students
{
    public interface IStudentView : IEntityControlView<Student>
    {

        int GetStudentId { get; }
        string GetFristName { get; }
        string GetLastName { get; }

        event EventHandler Click;
    }
}
