using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    public interface IStudentView
    {
        IStudentView FillView(Student student, Func<byte[], Image> converter);
        IStudentView CloneTo();

        event EventHandler ClickAdd;
    }
}
