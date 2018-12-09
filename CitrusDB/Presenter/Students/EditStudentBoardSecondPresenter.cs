using System;
using System.Linq;

using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Students.EditStuden;
using CitrusDB.View.Groups.GroupsView.GroupViews;

namespace CitrusDB.Presenter.Students
{
    class EditStudentBoardSecondPresenter : StudentBoardPresenter
    {

        readonly IEditStudentBoardSecond studentBoardSecond;

        public EditStudentBoardSecondPresenter(IEditStudentBoardSecond studentBoard, IGroupView groupView)
            : base(studentBoard, groupView)
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
            if (studentBoardSecond.GroupsCollection.Count == 0)
            {
                return;
            }
            else
            {
                ((IGroupView)studentBoardSecond.GroupsCollection[0]).ResetOtherBoard();

                if (e.entity != null)
                {
                    var group = studentBoardSecond.GroupsCollection
                                        .Cast<IGroupView>()
                                        .FirstOrDefault(g => g.Id == e.entity.Id);

                    group?.SelectView();
                }
            }
        }

        private void StudentBoardSecond_CancelButton(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private bool StudentBoardSecond_AcceptButton()
        {
            var selectedGroup = studentBoardSecond.GroupsCollection
                .Cast<IGroupView>()
                .FirstOrDefault(gv => gv.IsSelected == true);

            Student editStudent = new Student
            {
                Id = studentBoardSecond.CurrentStudent.Id,
                FirstName = studentBoardSecond.GetFirstName,
                LastName = studentBoardSecond.GetLastName,
                MiddleName = studentBoardSecond.GetMiddleName,
                DateOfBirth = studentBoardSecond.DateOfBirth,
                Height = studentBoardSecond.GetGrowth,
                Weight = studentBoardSecond.GetWeight,
                Сitizenship = studentBoardSecond.GetCitizenship,
                KnowledgeOfLanguage = studentBoardSecond.GetKnowledgeOfLanguage,

                FirstPhoto = studentBoardSecond.GetFirstPhoto.SetPhoto(studentBoardSecond.CurrentStudent.FirstPhoto),

                SecondPhoto = studentBoardSecond.GetSecondPhoto.SetPhoto(studentBoardSecond.CurrentStudent.SecondPhoto),

                Group = selectedGroup == null
                                     ? null
                                     : EFGenericRepository.FindById<Group>(selectedGroup.Id)
            };

            bool isEquality = new StudentsEqualityComarer()
                .Equals(editStudent, studentBoardSecond.CurrentStudent);

            if (!isEquality)
            {
                studentBoardSecond.CurrentStudent.SetCopy(editStudent);
                EFGenericRepository.Update(studentBoardSecond.CurrentStudent);
                return true;
            }

            return false;
        }

        #endregion

    }
}
