using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.Controls
{
    public partial class PromptToolTip : ToolTip
    {
        private string Caption { get; set; }
        public Font Font { get; set; }

        public PromptToolTip()
        {
            InitializeComponent();

            Font = new Font("Microsoft Sans Serif", 8.25f);
            this.OwnerDraw = true;
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
            this.Popup += new PopupEventHandler(this.OnPopup);
        }

        public PromptToolTip(IContainer Cont) : base(Cont)
        {
            this.OwnerDraw = true;
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
            this.Popup += new PopupEventHandler(this.OnPopup);
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = TextRenderer.MeasureText(Caption, Font);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            var newArgs = new DrawToolTipEventArgs(e.Graphics,
                e.AssociatedWindow,
                e.AssociatedControl,
                e.Bounds,
                e.ToolTipText,
                this.BackColor,
                this.ForeColor,
             this.Font);

            newArgs.DrawBackground();
            newArgs.DrawBorder();
            newArgs.DrawText();
        }

        public void SetControlToolTip(Control control, string caption)
        {
            this.Caption = caption;
            this.SetToolTip(control, caption);
        }

    }
}
