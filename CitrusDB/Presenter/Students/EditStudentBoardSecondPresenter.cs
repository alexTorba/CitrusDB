using CitrusDB.View.Students.EditStuden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model;
using CitrusDB.Model.Entity;
using System.Threading;
using CitrusDB.View.Students;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter.Students
{
    class EditStudentBoardSecondPresenter : StudentBoardPresenter
    {

        readonly IEditStudentBoardSecond studentBoardSecond;

        public EditStudentBoardSecondPresenter(IEditStudentBoardSecond studentBoard, IGroupView groupView) : base(studentBoard, groupView)
        {
            studentBoardSecond = studentBoard;

            SetHandlers();
        }

        private void SetHandlers()
        {
            studentBoardSecond.AcceptButton += StudentBoardSecond_AcceptButton;
            studentBoardSecond.CancelButton += StudentBoardSecond_CancelButton;
            studentBoardSecond.SetInitGroup += StudentBoardSecond_SetInitGroup;
        }

        #region IEditStudentBoardSecond

        private void StudentBoardSecond_SetInitGroup(object sender, EntityTransferEventArgs e)
        {
            if (e.entity != null)
            {
                var group = studentBoardSecond.GroupsCollection
                                    .Cast<IGroupView>()
                                    .FirstOrDefault(g => g.Id == e.entity.Id);
                group?.SelectView();
            }
        }

        private void StudentBoardSecond_CancelButton(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void StudentBoardSecond_AcceptButton(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
