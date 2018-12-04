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

        private void GroupBoardSecond_SetEditingGroup(object sender, EventArgs e)
        {
            //todo: переделать в плане производит..
            groupBoardSecond.CurrentStudentControlCollection.DeleteControls(
                groupBoardSecond.CurrentGroup.Students,
                CancellationToken.None);

            groupBoardSecond.AddedStudentControlCollection.Clear();

            groupBoardSecond
                .AddedStudentControlCollection
                .AddControls(groupBoardSecond.CurrentGroup.Students,
                addedStudentView,
                CancellationToken.None);

        }

        private bool GroupBoardSecond_AcceptClick()
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView studentView in groupBoardSecond.AddedStudentControlCollection)
                students.Add(EFGenericRepository.FindById<Student>(studentView.Id));

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

        }

        public override void GroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            groupBoardSecond.CurrentStudentControlCollection.AddControls(
                EFGenericRepository.Get<Student>(s => s.Group == null).ToArray(),
                currentStudentView,
                CancellationToken.None);
        }

        #endregion

    }
}
