using System;

namespace CitrusDB.View
{
  interface IMainForm
  {
    string SetStatusValue { get; set; }
    void SetInitStatus();
    event EventHandler LoadMainForm;
    event EventHandler ClosingMainForm;
  }
}
