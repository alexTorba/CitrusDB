using System;
using System.Linq;

using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.View.DataBoard;

namespace CitrusDB.Presenter
{
    public class DataBoardPresenter
    {
        readonly IDataBoard dataBoard;

        public DataBoardPresenter(IDataBoard dataBoard)
        {
            this.dataBoard = dataBoard;
            this.dataBoard.LoadDataBoard += DataBoard_LoadDataBoard;
            this.dataBoard.GroupTableLoad += DataBoard_GroupTableLoad;
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.GetView<GroupView>().ToList();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.GetView<StudentView>().ToList();
        }
    }
}
