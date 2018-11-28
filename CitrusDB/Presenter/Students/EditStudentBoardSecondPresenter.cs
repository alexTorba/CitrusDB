using CitrusDB.View.Students.EditStuden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using CitrusDB.Model;
using CitrusDB.Model.Entity;
using System.Threading;

namespace CitrusDB.Presenter.Students
{
    class EditStudentBoardSecondPresenter
    {

        TaskInfo currentTask = null;

        IEditStudentBoardSecond editStudentBoardSecond;
        IGroupView groupView;
        Validate validate = new Validate();

        public EditStudentBoardSecondPresenter(IEditStudentBoardSecond editStudentBoardSecond, IGroupView groupView)
        {
            this.editStudentBoardSecond = editStudentBoardSecond;
            this.groupView = groupView;

            SetHandlers();
        }

        private void SetHandlers()
        {
            editStudentBoardSecond.AcceptButton += EditStudentBoardSecond_AcceptButton;
            editStudentBoardSecond.CancelButton += EditStudentBoardSecond_CancelButton;

            editStudentBoardSecond.ComboBoxSelectionChange += EditStudentBoardSecond_ComboBoxSelectionChange;
            editStudentBoardSecond.ComboBoxTextUpdate += EditStudentBoardSecond_ComboBoxTextUpdate;

            editStudentBoardSecond.ControlEnter += EditStudentBoardSecond_ControlEnter;

            editStudentBoardSecond.LoadBoard += EditStudentBoardSecond_LoadBoard;

            editStudentBoardSecond.MonthCalendarDateChange += EditStudentBoardSecond_MonthCalendarDateChange;
            editStudentBoardSecond.MonthCalendarDateSelected += EditStudentBoardSecond_MonthCalendarDateSelected;
            editStudentBoardSecond.MonthCalendarEnter += EditStudentBoardSecond_MonthCalendarEnter;

            editStudentBoardSecond.PhotoLoaded += EditStudentBoardSecond_PhotoLoaded;
            editStudentBoardSecond.SearchBox_TextChange += EditStudentBoardSecond_SearchBox_TextChange;

            editStudentBoardSecond.TextBoxTextChanged += EditStudentBoardSecond_TextBoxTextChanged;

            editStudentBoardSecond.UpdateView += EditStudentBoardSecond_UpdateView;

        }

        #region Event Handlers

        private void EditStudentBoardSecond_UpdateView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_TextBoxTextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_SearchBox_TextChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_PhotoLoaded(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_MonthCalendarEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_MonthCalendarDateSelected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_MonthCalendarDateChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_LoadBoard(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_ControlEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_ComboBoxTextUpdate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_ComboBoxSelectionChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_CancelButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStudentBoardSecond_AcceptButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
