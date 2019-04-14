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
    private readonly ILoadingForm _loadingForm;

    public LoadingForm(ILoadingForm loadingForm)
    {
      _loadingForm = loadingForm;
    }

    public async void Show()
    {
      await Task.Run(() => _loadingForm.ShowForm());
    }

    public void Close()
    {
      if (!_loadingForm.isCompleted)
      {
        ((Form)_loadingForm).Invoke((MethodInvoker)delegate
        {
          _loadingForm.isCompleted = true;
          _loadingForm.CloseForm();
          ((Form)_loadingForm).Dispose();
        });
      }
    }
  }
}
