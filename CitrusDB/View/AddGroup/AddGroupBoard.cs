using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    public partial class AddGroupBoard : UserControl, IAddGroupBoard
    {
        #region IAddGroupBoard

        public ControlCollection controlCollection => this.currentStudentFlowPanel.Controls;

        public event EventHandler LoadAddGroupBoard;

        #endregion

        public AddGroupBoard()
        {
            InitializeComponent();

            //currentStudentFlowPanel.Controls.Add(new StudentViewDoard());
        }

        private void AddGroupBoard_Load(object sender, EventArgs e)
        {
            LoadAddGroupBoard?.Invoke(sender, e);
        }
    }
}
