using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public static bool CheckText<T>(this T control) where T : Control
        {
            Regex regex = new Regex(@"[\d+$%';:&#@!?]");
            if (regex.IsMatch(control.Text) ||
                control.Text.Length < 3 ||
                string.IsNullOrEmpty(control.Text))
                return true;

            return false;
        }

        public static void AddMistakeToLinkedLabel<T>(this T control) where T : Control
        {
            var label = control.Parent.Controls
                .OfType<Label>()
                .Where(l => l.Name == control.Tag.ToString())
                .First();

            if (!label.Text.Contains("*"))
                label.Text += "*";
        }

        public static bool HaveMistake<T>(this T control) where T : Control
        {
            var label = control.Parent.Controls
                .OfType<Label>()
                .Where(l => l.Name == control.Tag.ToString())
                .First();

            if (label.Text.Contains("*"))
                return true;

            return false;
        }

        public static void RemoveMistakeToLinkedLabel<T>(this T control) where T : Control
        {
            var label = control.Parent.Controls
                .OfType<Label>()
                .Where(l => l.Name == control.Tag.ToString())
                .First();

            if (label.Text.Contains("*"))
                label.Text = label.Text.Remove(label.Text.Length - 1, 1);
        }
    }
}
