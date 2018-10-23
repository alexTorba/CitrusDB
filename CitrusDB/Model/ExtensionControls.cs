using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace CitrusDB.Model
{
    public static class ExtensionControls
    {

        public static List<T> CreateListViews<T>(this T view, int count) where T : ICloneable
        {
            List<T> views = new List<T>();
            for (int i = 0; i < count; i++)
                views.Add((T)view.Clone());

            return views;
        }

    }
}
