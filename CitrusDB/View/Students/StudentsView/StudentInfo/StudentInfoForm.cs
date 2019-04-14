using System;
using System.Drawing;
using System.Windows.Forms;

using CitrusDB.Model.Entity;
using CitrusDB.Presenter;
using CitrusDB.Presenter.Students;
using CitrusDB.View.Groups.GroupsView.GroupInfo;

namespace CitrusDB.View.Students.StudentsView.StudentInfo
{
  public partial class StudentInfoForm : Form, IStudentInfoForm
  {
    private Image _firstPhoto;
    private Image _secondPhoto;
    private Group _group;

    private bool _firstPhotoLock = true;
    private bool _secondPhotoLock = false;

    System.Threading.Timer timer;

    public StudentInfoForm(int id)
    {
      InitializeComponent();

      Id = id;
      _firstPhotoLock = true;
      _secondPhotoLock = false;

      var studentInfoFormPresenter = new StudentInfoFormPresenter(this);
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
      get => _group;
      set
      {
        _group = value;
        groupValue.Text = _group?.ToString() ?? "without group";
      }
    }

    public Image FirstPhoto { set => _firstPhoto = value; }
    public Image SecondPhoto { set => _secondPhoto = value; }

    public event EventHandler FormLoad;

    #endregion

    private void StudentInfoForm_Load(object sender, EventArgs e)
    {
      FormLoad.Invoke(sender, e);

      SetPhoto();
    }

    private void SetPhoto()
    {
      if (_secondPhoto == null || _firstPhoto == null)
        photoPictureBox.Image = _firstPhoto;
      else
        timer = new System.Threading.Timer(ChangePhoto, null, 0, 1270);
    }

    private void ChangePhoto(object state)
    {
      if (_firstPhotoLock)
      {
        photoPictureBox.Image = _firstPhoto;
        _firstPhotoLock = false;
        _secondPhotoLock = true;
      }
      else if (_secondPhotoLock == true)
      {
        photoPictureBox.Image = _secondPhoto;
        _firstPhotoLock = true;
        _secondPhotoLock = false;
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void groupValue_MouseEnter(object sender, EventArgs e)
    {
      ((Label)sender).ForeColor = Color.Blue;
    }

    private void groupValue_MouseLeave(object sender, EventArgs e)
    {
      ((Label)sender).ForeColor = Color.FromKnownColor(KnownColor.ControlText);
    }

    private void groupValue_Click(object sender, EventArgs e)
    {
      if (_group == null)
        return;

      new GroupInfoForm(_group.Id).ShowDialog();
    }
  }
}
