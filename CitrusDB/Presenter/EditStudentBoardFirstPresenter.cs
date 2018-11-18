using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.View;
using CitrusDB.View.EditStuden;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using System.Windows.Forms;

namespace CitrusDB.Presenter
{
    class EditStudentBoardFirstPresenter
    {

        TaskInfo taskInfo;

        readonly IEditStudentBoardFirst editStudentBoardFirst;
        readonly IStudentView editStudentView;

        public EditStudentBoardFirstPresenter(IEditStudentBoardFirst editStudentBoardFirst, IStudentView editStudentView)
        {
            this.editStudentBoardFirst = editStudentBoardFirst;
            this.editStudentView = editStudentView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            editStudentBoardFirst.LoadEditStudentBoardFirst += EditStudentBoardFirst_LoadEditStudentBoardFirst;
        }

        private void EditStudentBoardFirst_LoadEditStudentBoardFirst(object sender, EventArgs e)
        {
            var students = EFGenericRepository.Get<Student>().ToArray();
            var studentControls = editStudentView.CreateListViews(students.Length);

            for (int i = 0; i < students.Length; i++)
            {
                editStudentBoardFirst.StudentControlCollection.Add((Control)studentControls[i].FillView(students[i]));
            }

        }
    }
}
