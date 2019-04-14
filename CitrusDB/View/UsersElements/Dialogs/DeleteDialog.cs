using System;
using System.Windows.Forms;

namespace CitrusDB.View.UsersElements
{
  public partial class DeleteDialog : Form
  {
    public bool IsDeleteMembers
    {
      get
      {
        if (DialogResult == DialogResult.OK)
          return deleteMembersRadioButton.Checked;

        return false;
      }
    }

    public DeleteDialog()
    {
      InitializeComponent();
    }

    private void DeleteDialog_Load(object sender, EventArgs e)
    {
      keepMembersRadioButton.Checked = true;
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
