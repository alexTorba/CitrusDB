using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using CitrusDB.Model.Extensions;
using CitrusDB.View.UsersElements.Dialogs;

namespace CitrusDB.View.Students.EditStuden
{
    public partial class EditStudentBoardSecond : UserControl, IEditStudentBoardSecond
    {

        public EditStudentBoardSecond()
        {
            InitializeComponent();

            SetTextBoxHandlers();
            SetComboBoxHandlers();

            progressBar.Value = 0;
        }

        #region IEditStudentBoardSecond

        public string GetFirstName => firstNameTextbox.Text;

        public string GetLastName => lastNameTextbox.Text;

        public string GetMiddleName => middleNameTextbox.Text;

        public string GetCitizenship => citizenshipTextbox.Text;

        public string GetKnowledgeOfLanguage => knowledgeOfLanguageTextbox.Text;

        public string DateOfBirth => monthCalendar.SelectionStart.ToShortDateString();

        public Image GetFirstPhoto => pictureBoxFirstPhoto.Image;

        public Image GetSecondPhoto => pictureBoxSecondPhoto.Image;

        public float GetGrowth => float.Parse(growsComboBox.Text);

        public float GetWeight => float.Parse(weightComboBox.Text);

        public ControlCollection GroupsCollection => groupsFlowPanel.Controls;

        public int GroupId { get; set; }

        public int ProgressBarValue
        {
            get => progressBar.Value;
            set => progressBar.Value = value;
        }

        public Student CurrentStudent { get; private set; }

        public void DisableViewsPanel()
        {
            groupsFlowPanel.Enabled = false;
        }

        public void EnableViewsPanel()
        {
            groupsFlowPanel.Enabled = true;
        }

        public event EventHandler LoadBoard;

        public event EventHandler TextBoxTextChanged;
        public event EventHandler ControlEnter;

        public event EventHandler ComboBoxSelectionChange;
        public event EventHandler ComboBoxTextUpdate;

        public event EventHandler MonthCalendarEnter;
        public event EventHandler MonthCalendarDateChange;
        public event EventHandler MonthCalendarDateSelected;

        public event EventHandler PhotoLoaded;

        public event EventHandler UpdateView;
        public event EventHandler SearchBox_TextChange;

        public event Func<bool> AcceptButton;
        public event EventHandler CancelButton;

        public event EntityTransferHandler SetInitGroup;

        #endregion

        #region Forwarding Events

        public void UpdateGroupView()
        {
            UpdateView?.Invoke(this, EventArgs.Empty);
        }

        public void SetStudent(Student student)
        {
            CurrentStudent = student;

            if (CurrentStudent != null)
            {
                firstNameTextbox.Text = CurrentStudent.FirstName;
                lastNameTextbox.Text = CurrentStudent.LastName;
                middleNameTextbox.Text = CurrentStudent.MiddleName;
                citizenshipTextbox.Text = CurrentStudent.Сitizenship;
                pictureBoxFirstPhoto.Image = CurrentStudent.FirstPhoto.ConvertByteArrToImage();
                pictureBoxSecondPhoto.Image = CurrentStudent.SecondPhoto.ConvertByteArrToImage();

                monthCalendar.SelectionRange = new SelectionRange(
                    DateTime.Parse(student.DateOfBirth),
                    DateTime.Parse(student.DateOfBirth));

                growsComboBox.Text = CurrentStudent.Height.ToString();
                weightComboBox.Text = CurrentStudent.Weight.ToString();
                knowledgeOfLanguageTextbox.Text = CurrentStudent.KnowledgeOfLanguage;

                SetInitGroup?.Invoke(this, new EntityTransferEventArgs(CurrentStudent.Group));
            }

            HidePhotoLabels();

            progressBar.Value = 100;
        }

        private void EditStudentBoardSecond_Load(object sender, EventArgs e)
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

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendarDateChange?.Invoke(sender, e);
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendarDateSelected?.Invoke(sender, e);
        }

        private void monthCalendar_Enter(object sender, EventArgs e)
        {
            MonthCalendarEnter?.Invoke(sender, e);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (AcceptButton?.Invoke() ?? false)
                if (new SuccessfulDialog("Changes accepted successfully !").ShowDialog() == DialogResult.OK)
                    cancelButton_Click(null, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelButton?.Invoke(sender, e);
        }

        private void searchGroupTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchBox_TextChange?.Invoke(sender, e);
        }

        #endregion

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

        public void HidePhotoLabels()
        {
            photo1Label.Visible = false;
            photo2Label.Visible = false;
        }

        private void progressBar_ProgressChanged(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                groupsFlowPanel.Enabled = true;
                searchPanel.Enabled = true;
                acceptButton.Enabled = true;
            }
            else
            {
                groupsFlowPanel.Enabled = false;
                searchPanel.Enabled = false;
                acceptButton.Enabled = false;
            }
        }

        private void searchGroupTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }
    }
}
