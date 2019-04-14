using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.Controls
{
  public partial class PromptToolTip : ToolTip
  {
    private string _caption;

    public Font Font { get; set; }

    public PromptToolTip()
    {
      InitializeComponent();

      Font = new Font("Microsoft Sans Serif", 8.25f);
      OwnerDraw = true;
      Draw += new DrawToolTipEventHandler(this.OnDraw);
      Popup += new PopupEventHandler(this.OnPopup);
    }

    public PromptToolTip(IContainer Cont) : base(Cont)
    {
      OwnerDraw = true;
      Draw += new DrawToolTipEventHandler(this.OnDraw);
      Popup += new PopupEventHandler(this.OnPopup);
    }

    private void OnPopup(object sender, PopupEventArgs e)
    {
      e.ToolTipSize = TextRenderer.MeasureText(_caption, Font);
    }

    private void OnDraw(object sender, DrawToolTipEventArgs e)
    {
      var newArgs = new DrawToolTipEventArgs(e.Graphics,
          e.AssociatedWindow,
          e.AssociatedControl,
          e.Bounds,
          e.ToolTipText,
          BackColor,
          ForeColor,
          Font);

      newArgs.DrawBackground();
      newArgs.DrawBorder();
      newArgs.DrawText();
    }

    public void SetControlToolTip(Control control, string caption)
    {
      _caption = caption;
      SetToolTip(control, caption);
    }
  }
}
