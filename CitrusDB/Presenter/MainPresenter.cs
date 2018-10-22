using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.View;

namespace CitrusDB.Presenter
{
    class MainPresenter
    {
        IMainForm mainFormView;
        Model.Model model = new Model.Model();

        public MainPresenter(IMainForm mainForm)
        {
            this.mainFormView = mainForm;
            mainFormView.LoadMainForm += MainFormView_LoadMainForm;
        }

        private void MainFormView_LoadMainForm(object sender, EventArgs e)
        {

        }
    }
}
