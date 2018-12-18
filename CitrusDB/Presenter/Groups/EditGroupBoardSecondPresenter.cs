using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.View.Groups;
using CitrusDB.View.Groups.EditGroup;
using CitrusDB.View.Students;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using System.Threading;
using CitrusDB.View.Students.StudentsView.AddedStudentView;

namespace CitrusDB.Presenter.Groups
{
    class EditGroupBoardSecondPresenter : GroupBoardPresenter
    {
        readonly IEditGroupBoardSecond groupBoardSecond;

        public EditGroupBoardSecondPresenter(IEditGroupBoardSecond groupBoardSecond, IStudentView currentStudentView, IStudentView addedStudentView)
            : base(groupBoardSecond, currentStudentView, addedStudentView)
        {
            this.groupBoardSecond = groupBoardSecond;

            SetHandlers();
        }

        private void SetHandlers()
        {
            groupBoardSecond.AcceptClick += GroupBoardSecond_AcceptClick;
            groupBoardSecond.CancelClick += GroupBoardSecond_CancelClick;
            groupBoardSecond.SetEditingGroup += GroupBoardSecond_SetEditingGroup;
        }

        #region Event Handlers

        private async void GroupBoardSecond_SetEditingGroup(object sender, EventArgs e)
        {
            groupBoardSecond.CurrentStudentControlCollection.DeleteControls(
                groupBoardSecond.CurrentGroup.Students,
                CancellationToken.None);

            groupBoardSecond.AddedStudentControlCollection.Clear();

            await groupBoardSecond
                .AddedStudentControlCollection
                .AddControls(groupBoardSecond.CurrentGroup.Students,
                addedStudentView,
                CancellationToken.None);
        }

        private bool GroupBoardSecond_AcceptClick()
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView studentView in groupBoardSecond.AddedStudentControlCollection)
                students.Add(EFGenericRepository.Find<Student>(studentView.Id));

            Group group = new Group
            {
                Id = groupBoardSecond.CurrentGroup.Id,
                Name = groupBoardSecond.GetNameOfGroup,
                Students = students,
                Photo = groupBoardSecond.GetGroupPhoto.SetPhoto(groupBoardSecond.CurrentGroup.Photo)
            };

            if (!group.Equals(groupBoardSecond.CurrentGroup, group))
            {
                groupBoardSecond.CurrentGroup.SetCopy(group);
                EFGenericRepository.Update(groupBoardSecond.CurrentGroup);
                return true;
            }

            return false;
        }

        private void GroupBoardSecond_CancelClick(object sender, EventArgs e)
        {
            //todo ??
            foreach (var addedStudentView in groupBoardSecond.AddedStudentControlCollection.Cast<AddedStudentViewBoard>().ToArray())
            {
                if (EFGenericRepository.Find<Student>(addedStudentView.Id).Group == null)
                {
                    CancelButton_Click(addedStudentView, EventArgs.Empty);
                }
            }
        }

        public override async void GroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            await groupBoardSecond.CurrentStudentControlCollection.AddControls(
                EFGenericRepository.Get<Student>(s => s.Group == null).ToArray(),
                currentStudentView,
                CancellationToken.None);
        }

        public async override Task<Student[]> GetStudentWithExceptedAddedStudent(string condition, string searchCriteria, CancellationToken token)
        {
            return await Task.Factory.StartNew(() =>
            {
                IEnumerable<Student> students = EFGenericRepository.Get<Student>(s => s.Group == null).ToArray();

                var existGroup = EFGenericRepository.Get<Group>(g => g.Name == groupBoard.GetNameOfGroup).FirstOrDefault();
                IEnumerable<Student> currentStudent = existGroup?.Students;
                if (currentStudent != null)
                    students = students.Union(currentStudent);

                if (condition != string.Empty)
                    students = students
                               .Where(searchCriteria, condition);


                if (groupBoard.AddedStudentControlCollection.Count == 0)
                    return students.ToArray();
                else
                {
                    var addedStudents = groupBoard.AddedStudentControlCollection
                                       .Cast<IStudentView>()
                                       .Select(s => EFGenericRepository.Find<Student>(s.Id));

                    return students.Except(addedStudents).ToArray();
                }
            }, token);
        }

        #endregion

    }
}
