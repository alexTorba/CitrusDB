using System;
using System.Linq;
using System.Threading.Tasks;

using CitrusDB.View.Statistics;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity.History;
using CitrusDB.Model.Entity;

namespace CitrusDB.Presenter
{
  class StatisticBoardPresenter
  {
   private readonly IStatisticBoard _statisticBoard;

    public StatisticBoardPresenter(IStatisticBoard statisticBoard)
    {
      _statisticBoard = statisticBoard;

      SetHandlers();
    }

    private void SetHandlers()
    {
      _statisticBoard.UpdateView += StatisticBoard_UpdateView;
    }

    private async Task StatisticBoard_UpdateView(object sender, EventArgs e)
    {
      await EFGenericRepository.SaveChangesAsync();

      _statisticBoard.GroupsHistory = EFGenericRepository.GetWithLoad<GroupsHistory>().ToArray();
      _statisticBoard.StudentsHistory = EFGenericRepository.GetWithLoad<StudentsHistory>().ToArray();
      _statisticBoard.CountOfGroup = EFGenericRepository.CountOfEntities<Group>().ToString();
      _statisticBoard.CountOfStudent = EFGenericRepository.CountOfEntities<Student>().ToString();
    }
  }
}
