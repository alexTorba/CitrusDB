using System;
using CitrusDB.View;
using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Presenter
{
  class MainFormPresenter
  {
    private readonly IMainForm _mainForm;

    public MainFormPresenter(IMainForm mainForm)
    {
      _mainForm = mainForm;

      _mainForm.LoadMainForm += MainFormView_LoadMainForm;
      _mainForm.ClosingMainForm += MainForm_ClosingMainForm;
    }

    private static void MainForm_ClosingMainForm(object sender, EventArgs e)
    {
      EFGenericRepository.SaveChanges();
    }

    private static void MainFormView_LoadMainForm(object sender, EventArgs e)
    {
    }
  }
}