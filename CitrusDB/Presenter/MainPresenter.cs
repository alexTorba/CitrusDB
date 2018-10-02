using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CitrusDB
{
    class MainPresenter
    {
        IMainForm mainFormView;
        Model model = new Model();

        public MainPresenter(IMainForm mainForm)
        {
            this.mainFormView = mainForm;
            mainFormView.LoadMainForm += MainFormView_LoadMainForm;
        }

        private void MainFormView_LoadMainForm(object sender, EventArgs e)
        {
            mainFormView.DataSource = model.FillDataGrid();

        }
    }
}
