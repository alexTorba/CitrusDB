using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
    public class DataBoardPresenter
    {
        IDataBoard dataBoard;
        Model model;

        public DataBoardPresenter(IDataBoard dataBoard)
        {
            model = new Model();

            this.dataBoard = dataBoard;
            this.dataBoard.LoadDataBoard += DataBoard_LoadDataBoard;
            this.dataBoard.GroupTableLoad += DataBoard_GroupTableLoad;
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = model.GetGroupViews();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = model.GetStudentsView();
        }
    }
}
