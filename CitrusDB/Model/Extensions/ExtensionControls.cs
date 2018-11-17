using CitrusDB.Model.Entity;
using CitrusDB.View.AddGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.Control;

namespace CitrusDB.Model.Extensions
{
    public static class ExtensionControls
    {

        public static T[] CreateListViews<T>(this T view, int count) where T : ICloneable
        {
            T[] arr = new T[count];

            for (int i = 0; i < count; i++)
                arr[i] = (T)view.Clone();

            return arr;
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

        public static bool HaveMistake<T>(this T control) where T : Control
        {
            switch (control)
            {
                case TextBox textBox:
                    {
                        var label = textBox.Parent.Controls
                            .OfType<Label>()
                            .Where(l => l.Name == textBox.Tag.ToString())
                            .FirstOrDefault();

                        if ((label?.Text.Contains("*") ?? false) || textBox.Text.Length == 0)
                            return true;

                        break;
                    }

                case ComboBox comboBox:
                    {
                        if (string.IsNullOrWhiteSpace(comboBox.Text))
                            return true;

                        break;
                    }

                case PictureBox pictureBox:
                    {
                        if (pictureBox.Image == null)
                            return true;

                        break;
                    }
                default:
                    break;
            }

            return false;
        }

        public static void AddMistakeToLinkedLabel<T>(this T control) where T : Control
        {
            var label = control.Parent.Controls
                .OfType<Label>()
                .Where(l => l.Name == control.Tag.ToString())
                .First();

            if (!label.Text.Contains("*"))
            {
                label.Text += "*";

                if (control is TextBox textBox)
                    textBox.ForeColor = System.Drawing.Color.Red;
            }
        }

        public static void RemoveMistakeToLinkedLabel<T>(this T control) where T : Control
        {
            var label = control.Parent.Controls
                .OfType<Label>()
                .Where(l => l.Name == control.Tag?.ToString())
                .FirstOrDefault();

            if (label?.Text.Contains("*") ?? false)
            {
                label.Text = label.Text.Remove(label.Text.Length - 1, 1);
                control.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
            }
        }

        public static void FillControl(this Control control)
        {
            if (control is ComboBox comboBox)
            {
                comboBox.SelectedItem =
                    comboBox.Items[new Random((int)DateTime.Now.Ticks).Next(0, comboBox.Items.Count - 1)];

            }
            else
            {
                control.Text = (string)typeof(Generate).
                GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name.ToUpperInvariant().Contains(control.Name.ToUpperInvariant()))
                .FirstOrDefault()?
                .Invoke(null, null);
            }
        }
       
    }
}
