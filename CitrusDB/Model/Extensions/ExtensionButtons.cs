using System.Drawing;
using System.Windows.Forms;

namespace CitrusDB.Model.Extensions
{
    public static class ExtensionButtons
    {

        public static void ChangeImageButton(this Button button, Panel panel, Bitmap collapsed, Bitmap unfolded)
        {
            if ((bool)panel.Tag == false)
                button.Image = unfolded;
            else button.Image = collapsed;
        }

    }
}
