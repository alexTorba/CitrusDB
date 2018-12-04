﻿using CitrusDB.Model.Entity;
using System;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Groups.EditGroup
{
    interface IEditGroupBoardFirst
    {
        Group EditGroup { get; set; }
        ControlCollection GroupCollection { get; }

        void LoadingSecondForm();

        event EventHandler EditGroupButtonClick;
        event EventHandler LoadEditGroupBoardFirst;
    }
}