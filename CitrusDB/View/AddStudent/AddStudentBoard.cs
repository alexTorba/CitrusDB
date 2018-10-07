using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Properties;

namespace CitrusDB
{
    public partial class AddStudentBoard : UserControl, IAddStudentBoard
    {
        MainForm mainForm;


        #region IAddStudentBoard

        public event EventHandler SaveButton;

        public string GetFirstName => this.firstNameTextbox.Text;

        public string GetLastName => lastNameTextbox.Text;

        public string GetMiddleName => middleNameTextbox.Text;

        public string GetCitizenship => citizenshipTextbox.Text;

        public string GetKnowledgeOfLanguage => knowledgeOfLanguageTextbox.Text;

        public string DateOfBirth => $"{daysNumericUpDown.Value.ToString()}.{monthNumericUpDown.Value.ToString()}.{yearNumericUpDown.Value.ToString()}";

        public Image GetFirstPhoto => pictureBoxFirstPhoto.Image;

        public Image GetSecondPhoto => pictureBoxSecondPhoto.Image;

        public float GetGrowth => float.Parse(growsComboBox.Text);

        public float GetWeight => float.Parse(weightComboBox.Text);

        #endregion

        public AddStudentBoard()
        {
            InitializeComponent();
        }

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void swingButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += this.swingPanel.TicksGrowsWidth;

            (sender as Button)?.ChangeImageButton(swingPanel, Resources.right, Resources.left);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Invoke(sender, e);
        }

        private void pictureBoxFirstPhoto_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
            }
            if (pictureBox.Image != null)
                this.photo1Label.Visible = false;
        }

        private void pictureBoxSecondPhoto_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
            }
            if (pictureBox.Image != null)
                this.photo2Label.Visible = false;
        }


    }
}
