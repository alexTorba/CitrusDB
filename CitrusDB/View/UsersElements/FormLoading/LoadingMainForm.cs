using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements.FormLoading
{
    public partial class LoadingMainForm : Form, ILoadingForm
    {
        public LoadingMainForm()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            Close();
        }

        public void ShowForm()
        {
            ShowDialog();
        }
    }
}
