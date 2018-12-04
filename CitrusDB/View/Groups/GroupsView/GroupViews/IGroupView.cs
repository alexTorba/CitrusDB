using System;
using System.Drawing;
using CitrusDB.Model.Entity;

namespace CitrusDB.View.Groups.GroupsView.GroupViews
{ 
    public interface IGroupView : IEntityControlView<Group>
    {

        string GroupName { get; }
        int CountOfStudent { get; set; }
        bool IsSelected { get; set; }
        Color selectedColor { get; set; }
        Color initColor { get; set; }

        void ChangeColorToBase();
        void SelectView();
        void ResetOtherBoard();

        event EventHandler ClearOtherBoard;

    }
}
