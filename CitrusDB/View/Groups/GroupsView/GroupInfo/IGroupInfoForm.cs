﻿using System;
using System.Drawing;

using CitrusDB.Model;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.Groups.GroupsView.GroupInfo
{
    interface IGroupInfoForm
    {
        int Id { get; }

        string GroupName { get; set; }
        Image Photo { get; set; }
        object Students { get; set; }

        void DisablingGrid();
        void EnablingGrid();

        event EventHandler SearchTextChanged;
        event HeaderGridMouseClickHandler HeaderMouseClick;
        event EventHandler LoadForm;
    }
}
