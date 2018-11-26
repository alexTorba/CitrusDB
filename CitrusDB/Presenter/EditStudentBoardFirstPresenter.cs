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
using System.Threading;
using System.Data.Entity;

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
            editStudentBoardFirst.UpdateView += EditStudentBoardFirst_UpdateView;
        }

        private async void EditStudentBoardFirst_UpdateView(object sender, EventArgs e)
        {
            editStudentBoardFirst.DisablingControlCollection();

            await AddControlsToControlCollection(
              EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Added).ToArray(),
              new CancellationToken());

            await DeleteControlsFromControlCollection(
                EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Deleted),
                new CancellationToken());

            editStudentBoardFirst.EnablingControlCollection();
        }

        private async Task AddControlsToControlCollection(IList<Student> students, CancellationToken token)
        {
            await Task.Factory.StartNew(() =>
            {
                if (students.Count == 0)
                    return;

                // except exist student in both ControlCollections
                students = students
                .Where(s => !editStudentBoardFirst.StudentControlCollection.IsContaintControl<Student>(s.Id))
                .ToArray();
            });

            editStudentBoardFirst.StudentControlCollection.AddControls(students, editStudentView, token);
        }

        private async Task DeleteControlsFromControlCollection(IEnumerable<Student> students, CancellationToken token)
        {
            await editStudentBoardFirst.StudentControlCollection
                .DeleteControls(students, EFGenericRepository.Get<Student>(), token);
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
