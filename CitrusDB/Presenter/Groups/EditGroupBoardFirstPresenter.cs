using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.View.Groups.EditGroup;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using System.Windows.Forms;

namespace CitrusDB.Presenter.Groups
{
    class EditGroupBoardFirstPresenter
    {
        readonly IEditGroupBoardFirst editGroupBoardFirst;
        readonly IGroupView groupView;

        public EditGroupBoardFirstPresenter(IEditGroupBoardFirst editGroupBoardFirst, IGroupView groupView)
        {
            this.editGroupBoardFirst = editGroupBoardFirst;
            this.groupView = groupView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            editGroupBoardFirst.LoadEditGroupBoardFirst += EditGroupBoardFirst_LoadEditGroupBoardFirst;
            editGroupBoardFirst.EditGroupButtonClick += EditGroupBoardFirst_EditGroupButtonClick;

            groupView.ClearOtherBoard += GroupView_ClearOtherBoard;
        }


        #region Event Handlers

        private void GroupView_ClearOtherBoard(object sender, EventArgs e)
        {
            foreach (var groupView in editGroupBoardFirst.GroupCollection.Cast<IGroupView>())
                groupView.ChangeColorToBase();

            //todo: ??
            //if (sender is IGroupView view)
            //    studentBoard.GroupId = view.Id;
        }

        private void EditGroupBoardFirst_EditGroupButtonClick(object sender, EventArgs e)
        {
            var selectedGroup= editGroupBoardFirst.GroupCollection
                .Cast<IGroupView>()
                .FirstOrDefault(gv => gv.IsSelected == true);

            editGroupBoardFirst.EditGroup = EFGenericRepository.FindById<Group>(selectedGroup.Id);

            editGroupBoardFirst.LoadingSecondForm();
        }

        private void EditGroupBoardFirst_LoadEditGroupBoardFirst(object sender, EventArgs e)
        {
            IList<Group> groups = EFGenericRepository.Get<Group>().ToArray();
            var listGroupViews = groupView.CreateListViews(groups.Count);

            for (int i = 0; i < listGroupViews.Length; i++)
            {
                var groupView = (IGroupView)listGroupViews[i].FillView(groups[i]);

                editGroupBoardFirst.GroupCollection.Add((Control)groupView);
            }
        }

        #endregion

    }
}
