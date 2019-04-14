using System;

namespace CitrusDB.Model.Entity.History
{
  public class StudentsHistory : IEntityHistory
  {
    public int Id { get; set; }
    public string TypeOfOperation { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Time { get; set; }
  }
}
