﻿using System;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Students
{
  public interface IStudentView : IEntityControlView<Student>
  {
    string GetFirstName { get; }
    string GetLastName { get; }

    event EventHandler Click;
  }
}
