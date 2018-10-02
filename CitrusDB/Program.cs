using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitrusDB
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            mainForm.InitBoard();

            MainPresenter mainPresenter = new MainPresenter(mainForm);
            AddStudentBoardPresenter addStudentBoardPresenter = new AddStudentBoardPresenter(mainForm.addStudentBoard1);
            DataBoardPresenter dataBoardPresenter = new DataBoardPresenter(mainForm.dataBoard);

            Application.Run(mainForm);
        }
    }
}
