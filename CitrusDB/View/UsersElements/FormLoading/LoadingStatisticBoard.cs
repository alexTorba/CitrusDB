using System.Drawing;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.FormLoading
{
  public partial class LoadingStatisticBoard : Form, ILoadingForm
  {
    public LoadingStatisticBoard()
    {
      InitializeComponent();
    }

    public LoadingStatisticBoard(Size size, Point location)
    {
      //Size = size;
      //Location = location;
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
