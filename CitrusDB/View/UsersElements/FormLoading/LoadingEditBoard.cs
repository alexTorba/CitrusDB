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
    public partial class LoadingEditBoard : Form, ILoadingForm
    {
        public LoadingEditBoard()
        {
            InitializeComponent();
        }

        public bool isCompleted { get; set; }

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
