using CitrusDB.Model.Entity;
using CitrusDB.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB.View.EntitiesInfo
{
    public partial class StudentInfoForm : Form, IStudentInfoForm
    {

        Image firstPhoto;
        Image secondPhoto;
        Group group;

        bool firstPhotoLock = false;
        bool secondPhotoLock = false;

        System.Threading.Timer timer;

        public StudentInfoForm(int id)
        {
            InitializeComponent();
            Id = id;

            StudentInfoFormPresenter studentInfoFormPresenter = new StudentInfoFormPresenter(this);
        }

        #region IStudentInfoForm

        public int Id { get; }
        public string FirstName { get => firstNameValue.Text; set => firstNameValue.Text = value; }
        public string LastName { get => lastNameValue.Text; set => lastNameValue.Text = value; }
        public string MiddleName { get => middleNameValue.Text; set => middleNameValue.Text = value; }
        public string DateOfBirth { get => dateOfBirthValue.Text; set => dateOfBirthValue.Text = value; }
        string IStudentInfoForm.Weight { get => weightValue.Text; set => weightValue.Text = value; }
        string IStudentInfoForm.Height { get => heightValue.Text; set => heightValue.Text = value; }
        public string Сitizenship { get => citizenshipValue.Text; set => citizenshipValue.Text = value; }
        public string KnowledgeOfLanguage { get => knowledgeOfLanguageValue.Text; set => knowledgeOfLanguageValue.Text = value; }

        public Group Group
        {
            get => group;
            set
            {
                group = value;
                groupValue.Text = group?.ToString() ?? "without group";
            }
        }

        public Image SecondPhoto { set => secondPhoto = value; }
        public Image FirstPhoto { set => firstPhoto = value; }

        public event EventHandler FormLoad;

        #endregion

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            FormLoad.Invoke(sender, e);

            SetPhoto();
        }

        private void SetPhoto()
        {
            if (secondPhoto == null)
                photoPictureBox.Image = firstPhoto;
            else
                timer = new System.Threading.Timer(ChangePhoto, null, 0, 1270);
        }

        private void ChangePhoto(object state)
        {
            if (firstPhotoLock)
            {
                photoPictureBox.Image = firstPhoto;
                firstPhotoLock = false;
                secondPhotoLock = true;
            }
            else if (secondPhotoLock == true)
            {
                photoPictureBox.Image = secondPhoto;
                firstPhotoLock = true;
                secondPhotoLock = false;
            }
        }

    }
}
