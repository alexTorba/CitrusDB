using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
    class AddGroupBoardPresenter
    {
        readonly IAddGroupBoard addGroupBoard;
        readonly Model model = new Model();

        public AddGroupBoardPresenter(IAddGroupBoard addGroupBoard)
        {
            this.addGroupBoard = addGroupBoard;

            this.addGroupBoard.LoadAddGroupBoard += AddGroupBoard_LoadAddGroupBoard;
        }

        private void AddGroupBoard_LoadAddGroupBoard(object sender, EventArgs e)
        {
            //todo: может ли модель возвращать пользовательский контрол ??
            addGroupBoard.controlCollection.AddRange(model.FillStudentViewBoards());
        }
    }
}
