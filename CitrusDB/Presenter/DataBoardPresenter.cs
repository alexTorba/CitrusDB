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

        public DataBoardPresenter(DataBoard dataBoard)
        {
            model = new Model();

            this.dataBoard = dataBoard;
            this.dataBoard.LoadDataBoard += DataBoard_LoadDataBoard;
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataGrid.DataSource = model.FillDataGrid();
        }
    }
}
