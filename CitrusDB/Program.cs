using System;
using System.Windows.Forms;

using CitrusDB.Presenter;
using CitrusDB.Presenter.Groups;
using CitrusDB.Presenter.Students;
using CitrusDB.View;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.View.Students.StudentsView.AddedStudentView;
using CitrusDB.View.Students.StudentsView.EditStudentView;
using CitrusDB.View.Students.StudentsView.StudentView;
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

            var editStudentBoardFirstPresenter =
                new EditStudentBoardFirstPresenter(mainForm.editStudentBoard.editStudentBoardFirst, new EditStudentViewBoard());

            //todo: 
            //var editStudentBoardSecondPresenter =
            //    new EditStudentBoardSecondPresenter(mainForm.editStudentBoard.editStudentBoardSecond, new GroupViewBoard());

            Application.Run(mainForm);
            Console.ReadKey();
        }

    }
}
