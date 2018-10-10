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

        public ControlCollection currentStudentControlCollection => currentStudentFlowPanel.Controls;

        public ControlCollection addedStudentControlCollection => addedStudentFlowPanel.Controls;

        public string CountOfAddedStudent { get => countOfStudentsLabel.Text; set => countOfStudentsLabel.Text = value; }

        public event EventHandler LoadAddGroupBoard;
        public event EventHandler changeAddedStudentPnanelControl;

        #endregion

        MainForm mainForm;

        public void InitBoard(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public AddGroupBoard()
        {
            InitializeComponent();
        }

        private void AddGroupBoard_Load(object sender, EventArgs e)
        {
            LoadAddGroupBoard?.Invoke(sender, e);

            countOfStudentsLabel.Text = addedStudentFlowPanel.Controls.Count.ToString();
        }

        private void addedStudentFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            changeAddedStudentPnanelControl(sender, EventArgs.Empty);
        }

        private void addedStudentFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            changeAddedStudentPnanelControl(sender, EventArgs.Empty);
        }
      
    }
}
