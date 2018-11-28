using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CitrusDB.Model;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model.Extensions;
using CitrusDB.View.Groups.GroupsView.GroupInfo;

namespace CitrusDB.Presenter.Groups
{
    class GroupInfoFormPresenter
    {

        readonly IGroupInfoForm groupInfoForm;
        TaskInfo currentTask;

        public GroupInfoFormPresenter(IGroupInfoForm groupInfoForm)
        {
            this.groupInfoForm = groupInfoForm;

            this.groupInfoForm.LoadForm += GroupInfoForm_LoadForm;
            this.groupInfoForm.HeaderMouseClick += GroupInfoForm_HeaderMouseClick;
            this.groupInfoForm.SearchTextChanged += GroupInfoForm_SearchTextChanged;
        }

        private void GroupInfoForm_SearchTextChanged(object sender, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchStudent, sender);
        }

        private async void SearchStudent(object sender, CancellationToken token)
        {
            try
            {
                groupInfoForm.DisablingGrid();

                groupInfoForm.Students = await GetStudent((sender as TextBox).Text, token);
            }
            catch (OperationCanceledException canceledEx)
            {
                Console.WriteLine(canceledEx.Message);
                return;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                groupInfoForm.EnablingGrid();
            }
            Console.WriteLine($"SUCCESSFUL" + Environment.NewLine);
        }

        private async Task<IEnumerable<StudentView>> GetStudent(string conditions, CancellationToken token)
        {
            return await Task.Run(() =>
            {
                if (conditions != string.Empty)
                    return EFGenericRepository.FindById<Group>(groupInfoForm.Id)
                                                      .Students
                                                      .GetViews<Student, StudentView>()
                                                      .Where(s => s.FirstName.ToUpperInvariant()
                                                      .Contains(conditions.ToUpperInvariant()))
                                                      .ToArray();

                return EFGenericRepository.FindById<Group>(groupInfoForm.Id)
                            .Students
                            .GetViews<Student, StudentView>()
                            .ToArray();
            }, token);
        }

        private void GroupInfoForm_HeaderMouseClick(object sender, HeaderPropertyEventArgs e)
        {
            groupInfoForm.Students = ((ICollection<StudentView>)groupInfoForm.Students)
                                                .OrderBy(e.SelectedHeader)
                                                .ToList();
        }

        private void GroupInfoForm_LoadForm(object sender, EventArgs e)
        {
            var group = EFGenericRepository.FindById<Group>(groupInfoForm.Id);
            groupInfoForm.GroupName = group.Name;
            groupInfoForm.Photo = group.Photo.ConvertByteArrToImage();
            groupInfoForm.Students = group.Students.GetViews<Student, StudentView>().ToList();
        }
    }
}
