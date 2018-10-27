using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

using CitrusDB.Properties;

namespace CitrusDB.View.AddStudent
{
    public partial class AddStudentBoard : UserControl, IAddStudentBoard
    {
        MainForm mainForm;

        public AddStudentBoard()
        {
            InitializeComponent();

            SetTextBoxHandlerHandlers();
            progressBar.Value = 0;
        }

        #region IAddStudentBoard

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

        public ControlCollection GroupsCollection => groupsFlowPanel.Controls;

        public int ProgressBarValue
        {
            get => progressBar.Value;
            set => progressBar.Value = value;
        }

        public event EventHandler SaveButton;
        public event EventHandler LoadBoard;
        public event EventHandler TextBoxTextChanged;
        public event MouseEventHandler TextBoxMouseClick;
        public event Func<object, bool> IsValidate;

        #endregion

        #region Forwarding Events

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Invoke(sender, e);
        }

        private void AddStudentBoard_Load(object sender, EventArgs e)
        {
            LoadBoard?.Invoke(sender, e);
        }

        private void TextBoxTextChangedHandler(object sender, EventArgs e)
        {
            TextBoxTextChanged.Invoke(sender, e);
        }

        private void TextBoxMouseClickHandler(object sender, MouseEventArgs e)
        {
            TextBoxMouseClick.Invoke(sender, e);
        }

        #endregion

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void swingButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += swingPanel.TicksGrowsWidth;

            (sender as Button)?.ChangeImageButton(swingPanel, Resources.right, Resources.left);
        }

        private void pictureBoxFirstPhoto_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
                LoadPhoto(pictureBox, photo1Label);
        }

        private void pictureBoxSecondPhoto_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
                LoadPhoto(pictureBox, photo2Label);
        }

        private void LoadPhoto(PictureBox pictureBox, Label photoLabel)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Load(openFileDialog.FileName);

            if (pictureBox.Image != null)
                photoLabel.Visible = false;
        }

        private void progressBar_ProgressChanged(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                saveButton.Enabled = true;
                groupsFlowPanel.Enabled = true;
                searchPanel.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
                groupsFlowPanel.Enabled = false;
                searchPanel.Enabled = false;
            }
        }

        private void SetTextBoxHandlerHandlers()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.TextChanged += TextBoxTextChangedHandler;
                textBox.MouseClick += TextBoxMouseClickHandler;
            }
        }

    }
}
