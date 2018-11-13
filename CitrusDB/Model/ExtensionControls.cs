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

        /// <summary>
        /// Delete students from ControlCollection
        /// </summary>
        /// <param name="controlCollection"></param>
        /// <param name="students">Students that was changed</param>
        /// <param name="generalStudents">Students that store in DB </param>
        /// <param name="token">Cancalation token</param>
        public static async Task DeleteControlsFromControlCollection(
            this ControlCollection controlCollection,
            IEnumerable<Student> students,
            IEnumerable<Student> generalStudents,
            CancellationToken? token)
        {
            List<Control> controls = new List<Control>();

            await Task.Run(() =>
            {
                //students that was changed in program and store in local
                if (((List<Student>)students).Count == 0)
                {
                    foreach (var student in students)
                    {
                        var control = controlCollection
                           .Cast<IStudentView>()
                           .Where(c => c.GetStudentId == student.Id)
                           .FirstOrDefault();
                        controls.Add((Control)control);
                    }
                }

                //student that doesnt store in db and was deleted 
                var studentViewsId = controlCollection
                .Cast<IStudentView>()
                .Select(sv => sv.GetStudentId);

                var studentsId = generalStudents.Select(s => s.Id);

                studentViewsId.Except(studentsId)
               .Select(id =>
                           controlCollection
                           .Cast<IStudentView>()
                           .First(st => st.GetStudentId == id)).ToList()
                                                               .ForEach(c => controls.Add((Control)c));
            });

            controls.ForEach(c => controlCollection.Remove(c));
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

        public static bool IsContaintControl(this ControlCollection controlCollection, int id)
        {
            return controlCollection.Cast<IStudentView>().FirstOrDefault(c => c.GetStudentId == id) != null
                ? true
                : false;
        }
    }
}
