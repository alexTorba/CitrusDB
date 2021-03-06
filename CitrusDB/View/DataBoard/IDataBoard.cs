﻿using System;
using CitrusDB.Model.Entity;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.View.DataBoard
{
  public interface IDataBoard
  {
    event EventHandler LoadDataBoard;
    event EventHandler GroupTableLoad;
    event OrderByHandler HeaderMouseClick;
    event EventHandler ChangeEntity;
    event EventHandler DeleteEntity;
    event SearchingEventHandler SearchBoxTextChanged;
    event GetEntityBySelectedViewHandler GetEntityBySelectedView;
    SelectedEntity SelectedEntity { get; set; }
    Type TypeOfSelectedEntity { get; }

    void UpdateView();
    void DisablingGrid();
    void EnablingGrid();

    object GetDataSource { get; set; }
  }
}
