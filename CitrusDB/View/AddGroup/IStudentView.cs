using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.AddGroup
{
    public interface IStudentView : IEntityControlView<Student>
    {

        int GetStudentId { get; }
        string GetFristName { get; }
        string GetLastName { get; }

        event EventHandler Click;
    }
}
