using System;
using System.Linq;

using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model;
using CitrusDB.View.DataBoard;
using CitrusDB.Model.Extensions;

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

            this.dataBoard.DeleteEntity += DataBoard_DeleteEntity;
        }

        private void DataBoard_DeleteEntity(object sender, EventArgs e)
        {
            if (((EntityArgs)e).Entity is StudentView studentView)
                EFGenericRepository.Delete(EFGenericRepository.FindById<Student>(studentView.Id));
            if (((EntityArgs)e).Entity is GroupView groupView)
                EFGenericRepository.Delete(EFGenericRepository.FindById<Group>(groupView.Id));
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Group>().GetViews<Group, GroupView>().ToList();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Student>().GetViews<Student, StudentView>().ToList();
        }
    }
}
