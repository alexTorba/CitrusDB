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
using CitrusDB.Model.DataBaseLogic;
using System.Drawing;

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

        private void StudentBoardSecond_AcceptButton(object sender, EventArgs e)
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

                FirstPhoto = SetPhoto(studentBoardSecond.GetFirstPhoto, studentBoardSecond.CurrentStudent.FirstPhoto),

                SecondPhoto = SetPhoto(studentBoardSecond.GetSecondPhoto, studentBoardSecond.CurrentStudent.SecondPhoto),

                Group = selectedGroup == null ? null : EFGenericRepository.FindById<Group>(selectedGroup.Id)
            };

            if (!editStudent.Equals(studentBoardSecond.CurrentStudent, editStudent))
            {
                studentBoardSecond.CurrentStudent.SetCopy(editStudent);
                EFGenericRepository.Update(studentBoardSecond.CurrentStudent);
            }

        }

        #endregion

        private byte[] SetPhoto(Image editPhoto, byte[] initPhoto)
        {
            try
            {
                return editPhoto.ConvertImageToByteArr();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return initPhoto;
            }
        }

    }
}
