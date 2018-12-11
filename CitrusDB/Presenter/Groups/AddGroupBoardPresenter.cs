using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CitrusDB.Model;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups;
using CitrusDB.View.Groups.AddGroup;
using CitrusDB.View.Students;

namespace CitrusDB.Presenter.Groups
{
    class AddGroupBoardPresenter : GroupBoardPresenter
    {
        readonly IAddGroupBoard addGroupBoard;

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard, IStudentView currentStudentView, IStudentView addedStudentView) 
            : base(addGroupBoard, currentStudentView, addedStudentView)
        {
            this.addGroupBoard = addGroupBoard;

            SetHandlers();
        }

        private void SetHandlers()
        {
            addGroupBoard.ClearClick += AddGroupBoard_ClearClick;
            addGroupBoard.SaveClick += AddGroupBoard_SaveClick;
        }

        #region Event Handlers

        private void AddGroupBoard_SaveClick(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            foreach (IStudentView studentView in addGroupBoard.AddedStudentControlCollection)
                students.Add(EFGenericRepository.Find<Student>(studentView.Id));

            Group group = new Group
            {
                Id = new Random(Guid.NewGuid().GetHashCode()).Next(),
                Name = addGroupBoard.GetNameOfGroup,
                Students = students,
                Photo = addGroupBoard.GetGroupPhoto.ConvertImageToByteArr()
            };

            EFGenericRepository.Create(group);

            addGroupBoard.ClearView();
            addGroupBoard.AddedStudentControlCollection.Clear();
        }

        private void AddGroupBoard_ClearClick(object sender, EventArgs e)
        {
            addGroupBoard.ClearView();

            if (addGroupBoard.AddedStudentControlCollection.Count != 0)
            {
                foreach (var obj in addGroupBoard.AddedStudentControlCollection)
                {
                    Control control = obj as Control;

                    IStudentView studentView = (IStudentView)this.currentStudentView.Clone();
                    studentView.FillView(EFGenericRepository.Find<Student>(
                        ((IStudentView)control).Id));

                    addGroupBoard.CurrentStudentControlCollection.Add((Control)studentView);
                }
                addGroupBoard.AddedStudentControlCollection.Clear();
            }
        }

        #endregion

    }
}
