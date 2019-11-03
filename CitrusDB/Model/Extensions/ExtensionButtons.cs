using System.Drawing;
using System.Windows.Forms;

namespace CitrusDB.Model.Extensions
{
  public static class ExtensionButtons
  {
    public static void ChangeImageButton(this Button button, Panel panel, Bitmap collapsed, Bitmap unfolded)
    {
      button.Image = (bool) panel.Tag == false ? unfolded : collapsed;
    }
  }
}