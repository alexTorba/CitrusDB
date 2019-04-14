using System.Collections.Generic;
using CitrusDB.Model.Entity.History;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Statistics
{
  interface IStatisticBoard
  {
    IList<GroupsHistory> GroupsHistory { get; set; }
    IList<StudentsHistory> StudentsHistory { get; set; }

    string CountOfStudent { get; set; }
    string CountOfGroup { get; set; }

    void UpdatingView();
    event EventHnadlerAsync UpdateView;
  }
}
