using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements
{
  public class CirclusButton : Button
  {
    protected override void OnPaint(PaintEventArgs pevent)
    {
      GraphicsPath graphics = new GraphicsPath();
      graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
      Region = new Region(graphics);
      base.OnPaint(pevent);
    }
  }
}
