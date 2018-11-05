using System;
using System.Linq;

using CitrusDB.Model.Entity;
using CitrusDB.View.DataBoard;

namespace CitrusDB.Presenter
{
    public class DataBoardPresenter
    {
        readonly IDataBoard dataBoard;
        readonly Model.Model model;

        public DataBoardPresenter(IDataBoard dataBoard)
        {
            model = new Model.Model();

            this.dataBoard = dataBoard;
            this.dataBoard.LoadDataBoard += DataBoard_LoadDataBoard;
            this.dataBoard.GroupTableLoad += DataBoard_GroupTableLoad;
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = model.GetEntityView<GroupView>().ToList();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = model.GetEntityView<StudentView>().ToList();
        }
    }
}
