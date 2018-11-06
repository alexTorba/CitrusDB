using System;
using CitrusDB.View;

namespace CitrusDB.Presenter
{
    class MainFormPresenter
    {
        IMainForm mainFormView;

        public MainFormPresenter(IMainForm mainForm)
        {
            mainFormView = mainForm;
            mainFormView.LoadMainForm += MainFormView_LoadMainForm;
        }

        private void MainFormView_LoadMainForm(object sender, EventArgs e)
        {

        }
    }
}
