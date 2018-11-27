using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students.EditStuden
{
    public partial class EditStudentBoardSecond : UserControl, IEditStudentBoardSecond
    {

        Student editStudent = null;

        public EditStudentBoardSecond()
        {
            InitializeComponent();
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

        public int ProgressBarValue
        {
            get => progressBar.Value;
            set => progressBar.Value = value;
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
        public event EventHandler AcceptButton;
        public event EventHandler CancelButton;

        #endregion

        #region Forwarding Events

        public void UpdateGroupView()
        {
            UpdateView?.Invoke(this, EventArgs.Empty);
        }

        public void SetStudent(Student student)
        {
            editStudent = student;

            if (editStudent != null)
            {
                firstNameTextbox.Text = editStudent.FirstName;
                lastNameTextbox.Text = editStudent.LastName;
                middleNameTextbox.Text = editStudent.MiddleName;
                citizenshipTextbox.Text = editStudent.Сitizenship;
                pictureBoxFirstPhoto.Image = editStudent.FirstPhoto.ConvertByteArrToImage();
                pictureBoxSecondPhoto.Image = editStudent.SecondPhoto.ConvertByteArrToImage();
                monthCalendar.SelectionRange = new SelectionRange(
                    DateTime.Parse(student.DateOfBirth), 
                    DateTime.Parse(student.DateOfBirth));
                growsComboBox.Text = editStudent.Height.ToString();
                weightComboBox.Text = editStudent.Weight.ToString();
                knowledgeOfLanguageTextbox.Text = editStudent.KnowledgeOfLanguage;
                //todo: select group in groupControlCollection
            }

            photo1Label.Visible = false;
            photo2Label.Visible = false;
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
            AcceptButton?.Invoke(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelButton?.Invoke(sender, e);
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

        public void DisableViewsPanel()
        {
            groupsFlowPanel.Enabled = false;
        }

        public void EnableViewsPanel()
        {
            groupsFlowPanel.Enabled = true;
        }

    }
}
