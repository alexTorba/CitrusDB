using CitrusDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.FormLoading
{
    public class LoadingForm
    {
        readonly ILoadingForm loadingForm;

        public LoadingForm(ILoadingForm loadingForm)
        {
            this.loadingForm = loadingForm;
        }

        public async void Show()
        {
            await Task.Run(() => loadingForm.ShowForm());
        }

        public void Close()
        {
            if (!loadingForm.isCompleted)
            {
                ((Form)loadingForm).Invoke((MethodInvoker)delegate
                {
                    loadingForm.isCompleted = true;
                    loadingForm.CloseForm();
                    ((Form)loadingForm).Dispose();
                });
            }
        }

    }
}
