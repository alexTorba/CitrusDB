using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.View.Statistics;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity.History;
using CitrusDB.Model.Entity;

namespace CitrusDB.Presenter
{
    class StatisticBoardPresenter
    {
        readonly IStatisticBoard statisticBoard;

        public StatisticBoardPresenter(IStatisticBoard statisticBoard)
        {
            this.statisticBoard = statisticBoard;

            SetHandlers();
        }

        private void SetHandlers()
        {
            statisticBoard.UpdateView += StatisticBoard_UpdateView;
        }

        private async Task StatisticBoard_UpdateView(object sender, EventArgs e)
        {
            await EFGenericRepository.SaveChangesAsync();

            statisticBoard.GroupsHistory = EFGenericRepository.GetWithLoad<GroupsHistory>().ToArray();
            statisticBoard.StudentsHistory = EFGenericRepository.GetWithLoad<StudentsHistory>().ToArray();
            statisticBoard.CountOfGroup = EFGenericRepository.CountOfEntities<Group>().ToString();
            statisticBoard.CountOfStudent = EFGenericRepository.CountOfEntities<Student>().ToString();
        }
    }
}
