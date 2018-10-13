using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    public static class ExtensionControls
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

        public static void ChangeImageButton(this Button button, Panel panel, Bitmap collapsed, Bitmap unfolded)
        {
            if ((bool)panel.Tag == false)
                button.Image = unfolded;
            else button.Image = collapsed;
        }

        public static List<IStudentView> CreateListIStudentView(this IStudentView studentView, int count)
        {
            List<IStudentView> studentViews = new List<IStudentView>();
            for (int i = 0; i < count; i++)
                studentViews.Add(studentView.CloneTo());

            return studentViews;
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
            using (MemoryStream stream = new MemoryStream(arr))
            {
                return Image.FromStream(stream);
            }
        }


    }
}
