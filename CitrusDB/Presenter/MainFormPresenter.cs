using System;
using CitrusDB.View;

namespace CitrusDB.Presenter
{
    class MainFormPresenter
    {
        IMainForm mainFormView;
        Model.Model model = new Model.Model();

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
