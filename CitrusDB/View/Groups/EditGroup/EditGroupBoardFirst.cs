using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.Groups.EditGroup
{
    public partial class EditGroupBoardFirst : UserControl, IEditGroupBoardFirst
    {
        public EditGroupBoardFirst()
        {
            InitializeComponent();
        }

        #region IEditGroupBoardFirst

        public ControlCollection GroupCollection => groupFlowPanel.Controls;

        public event EventHandler LoadEditGroupBoardFirst;

        #endregion

        #region Forwarding Events

        private void EditGroupBoardFirst_Load(object sender, EventArgs e)
        {
            LoadEditGroupBoardFirst?.Invoke(sender, e);
        }

        #endregion

    }
}
