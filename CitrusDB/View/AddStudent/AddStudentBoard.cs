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

            SetTextBoxHandlers();
            SetComboBoxHandlers();
            SetNumericUpDownHandlers();

            progressBar.Value = 0;
        }

        #region IAddStudentBoard

        public string GetFirstName => firstNameTextbox.Text;

        public string GetLastName => lastNameTextbox.Text;

        public string GetMiddleName => middleNameTextbox.Text;

        public string GetCitizenship => citizenshipTextbox.Text;

        public string GetKnowledgeOfLanguage => knowledgeOfLanguageTextbox.Text;

        public string InitDateOfBirth =>
            $"{daysNumericUpDown.Minimum.ToString()}.{monthNumericUpDown.Minimum.ToString()}.{yearNumericUpDown.Minimum.ToString()}";

        public string DateOfBirth
        {
            get
            {
                return $"{daysNumericUpDown.Value.ToString()}.{monthNumericUpDown.Value.ToString()}.{yearNumericUpDown.Value.ToString()}";
            }
            set
            {
                var data = value.Trim().Split('.');
                daysNumericUpDown.Value = decimal.Parse(data[0]);
                monthNumericUpDown.Value = decimal.Parse(data[1]);
                yearNumericUpDown.Value = decimal.Parse(data[2]);
            }
        }

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

        public ControlCollection GetBoardControls => Controls;

        public event EventHandler SaveButton;
        public event EventHandler LoadBoard;
        public event EventHandler GenerateButton;

        public event EventHandler TextBoxTextChanged;
        public event EventHandler ControlEnter;

        public event EventHandler ComboBoxSelectionChange;
        public event EventHandler ComboBoxTextUpdate;
        public event EventHandler ComboBoxTextChanged;

        public event EventHandler PhotoLoaded;
        public event EventHandler ClearButton;

        public event EventHandler NumericUDValueChanged;
        public event EventHandler NumericUDValueEnter;

        #endregion

        #region Forwarding Events

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButton?.Invoke(sender, e);
        }

        private void AddStudentBoard_Load(object sender, EventArgs e)
        {
            LoadBoard?.Invoke(sender, e);
        }

        private void TextBoxTextChangedHandler(object sender, EventArgs e)
        {
            TextBoxTextChanged?.Invoke(sender, e);
        }

        private void ControlEnterHandler(object sender, EventArgs e)
        {
            ControlEnter?.Invoke(sender, e);
        }

        private void ComboBoxSelectionChangeHandler(object sender, EventArgs e)
        {
            ComboBoxSelectionChange?.Invoke(sender, e);
        }

        private void ComboBoxTextUpdateHandler(object sender, EventArgs e)
        {
            ComboBoxTextUpdate?.Invoke(sender, e);

            (sender as ComboBox).Text = string.Empty;
        }

        private void pictureBoxFirstPhoto_Click(object sender, EventArgs e)
        {
            ControlEnter?.Invoke(sender, e);

            if (LoadPhoto((sender as PictureBox), photo1Label))
                PhotoLoaded?.Invoke(sender, e);
        }

        private void pictureBoxSecondPhoto_Click(object sender, EventArgs e)
        {
            ControlEnter?.Invoke(sender, e);

            if (LoadPhoto((sender as PictureBox), photo2Label))
                PhotoLoaded?.Invoke(sender, e);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = string.Empty;

                if (control is ComboBox comboBox)
                    comboBox.SelectedText = string.Empty;
            }

            pictureBoxFirstPhoto.Image = null;
            pictureBoxSecondPhoto.Image = null;
            photo1Label.Visible = true;
            photo2Label.Visible = true;

            ClearButton?.Invoke(sender, e);
        }

        private void NumericUpDownValueChangedHandler(object sender, EventArgs e)
        {
            NumericUDValueChanged?.Invoke(sender, e);
        }

        private void NumericUpDownValueEnterHandler(object sender, EventArgs e)
        {
            NumericUDValueEnter?.Invoke(sender, e);
        }

        #endregion

        #region Event Handlers

        private void swingButton_Click(object sender, EventArgs e)
        {
            mainForm.timer.Start();

            mainForm.ClearEventHandlers();
            mainForm.TimerTiks += swingPanel.TicksGrowsWidth;

            (sender as Button)?.ChangeImageButton(swingPanel, Resources.right, Resources.left);
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

        #endregion

        public void InitFields(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private bool LoadPhoto(PictureBox pictureBox, Label photoLabel)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);

                if (pictureBox.Image != null)
                    photoLabel.Visible = false;

                return true;
            }

            return false;
        }

        private void SetTextBoxHandlers()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.TextChanged += TextBoxTextChangedHandler;
                textBox.Enter += ControlEnterHandler;
            }
        }

        private void SetComboBoxHandlers()
        {
            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.Enter += ControlEnterHandler;
                comboBox.TextUpdate += ComboBoxTextUpdateHandler;
                comboBox.SelectionChangeCommitted += ComboBoxSelectionChangeHandler;
            }
        }

        private void SetNumericUpDownHandlers()
        {
            foreach (NumericUpDown numericUpDown in Controls.OfType<NumericUpDown>())
            {
                numericUpDown.ValueChanged += NumericUpDownValueChangedHandler;
                numericUpDown.Enter += NumericUpDownValueEnterHandler;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateButton.Invoke(sender, e);
        }

        public void HidePhotoLabels()
        {
            photo1Label.Visible = false;
            photo2Label.Visible = false;
        }
    }
}
