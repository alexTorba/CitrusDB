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

    }
}
