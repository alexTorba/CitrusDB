using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.Dialogs
{
    public partial class SuccessfulDialog : Form
    {
        public SuccessfulDialog(string message)
        {
            InitializeComponent();

            messageTextBox.Text = message;

            timeBeginPeriod(timerAccuracy);
        }

        private void SuccessfulDialog_Load(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timeEndPeriod(timerAccuracy);
            base.OnFormClosed(e);
        }

        // Pinvoke:
        private const int timerAccuracy = 10;
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        public static extern int timeEndPeriod(int msec);
    }
}
