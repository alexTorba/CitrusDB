using System;

namespace CitrusDB.View.Statistics
{
  public class DateModel
  {
    public string TypeOfOperation { get; set; }
    public DateTime Time { get; set; }
    public int Count { get; set; }
  }
}
