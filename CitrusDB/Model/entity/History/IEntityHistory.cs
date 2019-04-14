using System;

namespace CitrusDB.Model.Entity.History
{
  public interface IEntityHistory
  {
    int Id { get; set; }
    string TypeOfOperation { get; set; }
    DateTime Time { get; set; }
  }
}
