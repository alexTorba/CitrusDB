using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CitrusDB
{
    static class Extensions
    {

        public static void TicksGrowsHeight(this Panel panel, Timer timer, object sender, EventArgs e)
        {
            if (!(bool)panel.Tag)
            {
                panel.Height += 10;
                if (panel.MaximumSize.Height == panel.Height)
                {
                    timer.Stop();
                    panel.Tag = true;
                }
            }
            else
            {
                panel.Height -= 10;
                if (panel.MinimumSize.Height == panel.Height)
                {
                    timer.Stop();
                    panel.Tag = false;
                }
            }
        }

        public static void TicksGrowsWidth(this Panel panel, Timer timer, object sender, EventArgs e)
        {
            if (!(bool)panel.Tag)
            {
                panel.Width += 10;
                if (panel.MaximumSize.Width == panel.Width)
                {
                    timer.Stop();
                    panel.Tag = true;
                }
            }
            else
            {
                panel.Width -= 10;
                if (panel.MinimumSize.Width == panel.Width)
                {
                    timer.Stop();
                    panel.Tag = false;
                }
            }
        }

        public static void TicksGrowsWidthQuiсkly(this Panel panel, Timer timer, object sender, EventArgs e)
        {
            if (!(bool)panel.Tag)
            {
                panel.Width += 19;
                if (panel.MaximumSize.Width == panel.Width)
                {
                    timer.Stop();
                    panel.Tag = true;
                }
            }
            else
            {
                panel.Width -= 26;
                if (panel.MinimumSize.Width == panel.Width)
                {
                    timer.Stop();
                    panel.Tag = false;
                }
            }
        }

        public static void ChangeImageButton(this Button button, Panel panel, Bitmap collapsed, Bitmap unfolded)
        {
            if ((bool)panel.Tag == false)
                button.Image = unfolded;
            else button.Image = collapsed;
        }

        public static byte[] ConvertImageToByteArr(this Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        public static Image ConvertByteArrToImage(this byte[] arr)
        {
            if(arr == null)
                return null;
            using (MemoryStream stream = new MemoryStream(arr))
            {
                return Image.FromStream(stream);
            }
        }

    }
}
