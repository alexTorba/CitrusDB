using System;
using System.Windows.Forms;

namespace CitrusDB.Model.Extensions
{
  public static class ExtensionPanels
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

    public static void TicksGrowsHeightQuiсkly(this Panel panel, Timer timer, object sender, EventArgs e)
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
        panel.Height -= 20;
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
  }
}
