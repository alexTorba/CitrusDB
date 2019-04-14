using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.FormLoading
{
  public partial class LoadingMainForm : Form, ILoadingForm
  {
    public LoadingMainForm()
    {
      InitializeComponent();
    }

    public bool isCompleted { get; set; }

    public void CloseForm()
    {
      Close();
    }

    public void ShowForm()
    {
      ShowDialog();
    }
  }
}
