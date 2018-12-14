using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;
using System;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Groups.EditGroup
{
    interface IEditGroupBoardFirst
    {
        Group EditGroup { get; set; }
        ControlCollection GroupCollection { get; }

        void LoadingSecondForm();

        int GroupId { get; set; }
        event EventHandler SearchBoxTextChanged;
        event EventHandler UpdateView;
        event EventHandler EditGroupButtonClick;
        event EventHandler LoadEditGroupBoardFirst;
        event OrderByHandler OrderBy;
    }
}
