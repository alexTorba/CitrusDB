using System;

namespace CitrusDB.Model.Entity.History
{
  public class GroupsHistory : IEntityHistory
  {
    public int Id { get; set; }
    public string TypeOfOperation { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
  }
}
