using System;
using System.Windows.Forms;

using CitrusDB.Presenter;
using CitrusDB.View;
using CitrusDB.View.AddGroup.AddedStudentView;
using CitrusDB.View.AddGroup.StudentView;
using CitrusDB.View.AddStudent.GroupViews;
using CitrusDB.View.EditStuden.EditStudentView;
using CitrusDB.View.UsersElements.FormLoading;

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

            MainForm mainForm = new MainForm(new LoadingMainForm());
            mainForm.InitBoard();

            var mainPresenter = new MainFormPresenter(mainForm);

            var addStudentBoardPresenter = new AddStudentBoardPresenter(mainForm.addStudentBoard, new GroupViewBoard());

            var dataBoardPresenter = new DataBoardPresenter(mainForm.dataBoard);

            var addGroupBoardPresenter = new AddGroupBoardPresenter(
                mainForm.addGroupBoard, new StudentViewBoard(), new AddedStudentViewBoard());

            var editStudentBoardFirstPresenter = new EditStudentBoardFirstPresenter(mainForm.editStudentBoardFirst, new EditStudentViewBoard());

            Application.Run(mainForm);
            Console.ReadKey();
        }

    }
}
