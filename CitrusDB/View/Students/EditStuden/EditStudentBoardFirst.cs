using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.View.UsersElements.FormLoading;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students.EditStuden
{
    public partial class EditStudentBoardFirst : UserControl, IEditStudentBoardFirst
    {

        MainForm mainForm = null;
        public bool isSecondFormOpened;

        public EditStudentBoardFirst()
        {
            InitializeComponent();
        }

        #region IEditStudentBoardFirst

        public ControlCollection StudentControlCollection => studentFlowLayoutPanel.Controls;

        public Student EditStudent { get; set; }

        public void EnablingControlCollection()
        {
            studentFlowLayoutPanel.Enabled = true;
        }

        public void DisablingControlCollection()
        {
            studentFlowLayoutPanel.Enabled = false;
        }

        public void LoadingSecondForm()
        {
            isSecondFormOpened = false;
            LoadSecondForm?.Invoke(null, EventArgs.Empty);
        }

        public event EventHandler LoadEditStudentBoardFirst;
        public event EventHandler UpdateView;
        public event EventHandler StudentSearchTextBoxChanges;
        public event EventHandler LoadSecondForm;

        #endregion

        #region Forwarding Events

        public void UpdatingView()
        {
            UpdateView?.Invoke(null, EventArgs.Empty);
        }

        private void editStudentBoardFirst_Load(object sender, EventArgs e)
        {
            LoadEditStudentBoardFirst?.Invoke(sender, e);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            StudentSearchTextBoxChanges?.Invoke(sender, e);
        }

        #endregion

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }


        private void collapsedButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();

            mainForm.TimerTiks += TicksGrowsWidth;
        }

        private void TicksGrowsWidth(Timer timer, object sender, EventArgs e)
        {
            if (!(bool)generPanelOptions.Tag)
            {
                generPanelOptions.Width += 10;
                studentFlowLayoutPanel.Width -= 10;
                if (generPanelOptions.MaximumSize.Width == generPanelOptions.Width)
                {
                    timer.Stop();
                    generPanelOptions.Tag = true;
                }
            }
            else
            {
                generPanelOptions.Width -= 10;
                studentFlowLayoutPanel.Width += 10;

                if (generPanelOptions.MinimumSize.Width == generPanelOptions.Width)
                {
                    timer.Stop();
                    generPanelOptions.Tag = false;
                }
            }
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }

    }
}
