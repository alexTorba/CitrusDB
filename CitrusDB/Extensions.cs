using CitrusDB.Model.Entity.History;
using CitrusDB.View.Statistics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            if (arr == null)
                return null;
            using (MemoryStream stream = new MemoryStream(arr))
            {
                return Image.FromStream(stream);
            }
        }

        public static byte[] SetPhoto(this Image editPhoto, byte[] initPhoto)
        {
            try
            {
                return editPhoto.ConvertImageToByteArr();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return initPhoto;
            }
        }

        public static void CreateSeries(this Chart chart, string name, Color color, IList<DateModel> dateModels)
        {
            var series = new Series
            {
                ChartType = SeriesChartType.Line,
                Color = color,
                Name = name
            };

            foreach (DateModel date in dateModels)
                series.Points.AddXY(date.Time, date.Count);

            chart.Series.Add(series);
            chart.Series[name].XValueType = ChartValueType.DateTime;
        }

    }
}
