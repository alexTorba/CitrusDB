using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CitrusDB.View.AddGroup;
using CitrusDB.View.AddStudent.GroupVIew;

namespace CitrusDB.Model
{
    public static class ExtensionControls
    {

        public static List<IStudentView> CreateListIStudentView(this IStudentView studentView, int count)
        {
            List<IStudentView> studentViews = new List<IStudentView>();
            for (int i = 0; i < count; i++)
                studentViews.Add(studentView.CloneTo());

            return studentViews;
        }

        public static List<IGroupView> CreateListIGroupView(this IGroupView groupView, int count)
        {
            List<IGroupView> groupViews = new List<IGroupView>();
            for (int i = 0; i < count; i++)
                groupViews.Add(groupView.CloneTo());

            return groupViews;
        }

    }
}
