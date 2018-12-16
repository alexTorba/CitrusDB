﻿using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.Model.Extensions;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.View.Students.EditStuden;
using CitrusDB.View.Students;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter.Students
{
    class EditStudentBoardFirstPresenter
    {

        TaskInfo currentTask;

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
            editStudentBoardFirst.StudentSearchTextBoxChanges += EditStudentBoardFirst_StudentSearchTextBoxChanges;
            editStudentBoardFirst.OrderBy += EditStudentBoardFirst_OrderBy;

            editStudentView.Click += EditStudentView_Click;
        }

        private async void EditStudentBoardFirst_OrderBy(object sender, OrderByEventArgs e)
        {
            IList<Student> students = await editStudentBoardFirst
                  .StudentControlCollection
                  .TransformControlsToEntitiesAsync<Student>(CancellationToken.None);

            if (e.IsAscending)
                students = students.OrderBy(e.OrderCriteria).ToArray();
            else
                students = students.OrderByDescending(e.OrderCriteria).ToArray();

            editStudentBoardFirst.StudentControlCollection.Clear();

            await FillControlCollection(students, CancellationToken.None);
        }

        #region EventHandlers

        private async void EditStudentBoardFirst_UpdateView(object sender, EventArgs e)
        {
            editStudentBoardFirst.DisablingControlCollection();

            await AddControlsToControlCollection(
              EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Added).ToArray(),
              CancellationToken.None);

            await DeleteControlsFromControlCollection(
                EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Deleted),
                CancellationToken.None);

            await UpdateControlsFromControlCollection(
                EFGenericRepository.GetEntitiesWithState<Student>(EntityState.Modified).ToArray(),
                CancellationToken.None);

            editStudentBoardFirst.EnablingControlCollection();
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

        private void EditStudentBoardFirst_StudentSearchTextBoxChanges(string condition, string searchCriteria, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchStudent, condition, searchCriteria);
        }

        #endregion

        private async void SearchStudent(string condition, string searchCriteria, CancellationToken token)
        {
            try
            {
                Student[] result = GetStudentsWithConditions(condition, searchCriteria);
                await FillControlCollection(result, token);
            }
            catch (OperationCanceledException canceledEx)
            {
                Console.WriteLine(canceledEx.Message);
                return;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
        }

        private Student[] GetStudentsWithConditions(string condition, string searchCriteria)
        {
            if (condition == string.Empty)
                return EFGenericRepository.Get<Student>().ToArray();

            return EFGenericRepository.Get<Student>()
                                            .Where(searchCriteria, condition)
                                            .ToArray();
        }

        /// <summary>
        /// Асинхронное заполнение CurrentStudentControlCollection.
        /// </summary>
        /// <param name="students">Коллекция, которая будет трансформироваться в StudentViewBoard и помещаться в CurrentStudentControlCollection</param>
        /// <returns></returns>
        private async Task FillControlCollection(IList<Student> students, CancellationToken token)
        {
            await editStudentBoardFirst
                 .StudentControlCollection
                 .FillControlCollectionForSearch(students, editStudentView, token);
        }

        private void EditStudentView_Click(object sender, EventArgs e)
        {
            editStudentBoardFirst.EditStudent = EFGenericRepository.Find<Student>(((IStudentView)((Control)sender).Parent).Id);

            editStudentBoardFirst.LoadingSecondForm();
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

           await editStudentBoardFirst.StudentControlCollection.AddControls(students, editStudentView, token);
        }

        private async Task DeleteControlsFromControlCollection(IEnumerable<Student> students, CancellationToken token)
        {
            await editStudentBoardFirst.StudentControlCollection
                .DeleteControls(students, EFGenericRepository.Get<Student>(), token);
        }

        private async Task UpdateControlsFromControlCollection(IList<Student> students, CancellationToken token)
        {
            if (students.Count == 0)
                return;

            await editStudentBoardFirst.StudentControlCollection.UpdateControls(
                students,
                editStudentView,
                token
                );
        }

    }
}
