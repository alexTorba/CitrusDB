using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace CitrusDB.View.Students.AddStudent
{
    interface IAddStudentBoard : IStudentBoard
    {
        ControlCollection GetBoardControls { get; }

        event EventHandler SaveButton;
        event EventHandler ClearButton;
        event EventHandler GenerateButton;

        void ResetControls();
        void SetInitDate();
        void HidePhotoLabels();
        
    }
}
