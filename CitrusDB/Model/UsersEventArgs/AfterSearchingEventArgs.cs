using System;

namespace CitrusDB.Model.UsersEventArgs
{
  public delegate void SearchingEventHandler(string condition, string searchCriteria, AfterSearchingEventArgs e);

  public class AfterSearchingEventArgs : EventArgs
  {
    public Action<string> Sorting { get; }
    public string ConditionSorting { get; }

    public AfterSearchingEventArgs(Action<string> sorting, string conditionSorting)
    {
      Sorting = sorting;
      ConditionSorting = conditionSorting;
    }
  }
}
