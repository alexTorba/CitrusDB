using System;

using CitrusDB.View;
using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Presenter
{
    class MainFormPresenter
    {
        IMainForm mainForm;

        public MainFormPresenter(IMainForm mainForm)
        {
            this.mainForm = mainForm;

            this.mainForm.LoadMainForm += MainFormView_LoadMainForm;
            this.mainForm.ClosingMainForm += MainForm_ClosingMainForm;
        }

        private void MainForm_ClosingMainForm(object sender, EventArgs e)
        {
            EFGenericRepository.SaveChanges();
        }

        private void MainFormView_LoadMainForm(object sender, EventArgs e)
        {
        }
    }
}
