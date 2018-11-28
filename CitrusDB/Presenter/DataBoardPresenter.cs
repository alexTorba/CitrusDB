using System;
using System.Linq;
using System.Threading;

using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.Model;
using CitrusDB.View.DataBoard;
using CitrusDB.Model.Extensions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using CitrusDB.View.UsersElements;
using CitrusDB.Model.UsersEventArgs;

namespace CitrusDB.Presenter
{
    public class DataBoardPresenter
    {
        readonly IDataBoard dataBoard;
        TaskInfo currentTask;

        public DataBoardPresenter(IDataBoard dataBoard)
        {
            this.dataBoard = dataBoard;

            SetHandlers();
        }

        private void SetHandlers()
        {
            dataBoard.LoadDataBoard += DataBoard_LoadDataBoard;
            dataBoard.GroupTableLoad += DataBoard_GroupTableLoad;
            dataBoard.HeaderMouseClick += DataBoard_HeaderMouseClick;

            dataBoard.DeleteEntity += DataBoard_DeleteEntity;

            dataBoard.SearchBoxTextChanged += DataBoard_SearchBoxTextChanged;
        }

        private void DataBoard_SearchBoxTextChanged(object sender, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchEntities, sender);
        }

        private void SearchEntities(object sender, CancellationToken token)
        {
            try
            {
                //dataBoard.DisablingGrid();

                GetEntityBySearch(dataBoard.SelectedEntity, (sender as TextBox).Text, token);
            }
            catch (TaskCanceledException canceledEx)
            {
                Console.WriteLine(canceledEx.Message);
                return;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                //dataBoard.EnablingGrid();
            }
            Console.WriteLine("SUCCESSFULLY");
        }

        private async void GetEntityBySearch(SelectedEntity selectedEntity, string condition, CancellationToken token)
        {
            IEnumerable<StudentView> studentViewResult = null;
            IEnumerable<GroupView> groupViewResult = null;
            if (selectedEntity == SelectedEntity.Student)
            {
                await Task.Run(() =>
                {
                    if (condition == string.Empty)
                        studentViewResult = EFGenericRepository.Get<Student>().GetViews<Student, StudentView>();

                    studentViewResult = EFGenericRepository.Get<Student>(s => s.FirstName
                                                            .ToUpperInvariant()
                                                            .Contains(condition.ToUpperInvariant()))
                                                            .GetViews<Student, StudentView>();
                }, token);
            }
            else if (selectedEntity == SelectedEntity.Group)
            {
                await Task.Run(() =>
                {
                    if (condition == string.Empty)
                        groupViewResult = EFGenericRepository.Get<Group>().GetViews<Group, GroupView>();

                    groupViewResult = EFGenericRepository.Get<Group>(g => g.Name
                                                          .ToUpperInvariant()
                                                          .Contains(condition.ToUpperInvariant()))
                                                          .GetViews<Group, GroupView>();
                }, token);
            }
            if (studentViewResult != null)
                dataBoard.GetDataSource = studentViewResult.ToArray();
            else if (groupViewResult != null)
                dataBoard.GetDataSource = groupViewResult.ToArray();
        }

        private async void TransformResultToEntityView(IEnumerable<IEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(300);

                if (dataBoard.SelectedEntity == SelectedEntity.Group)
                {
                    dataBoard.GetDataSource = (await ((IEnumerable<Group>)result).GetViewsAsync<Group, GroupView>(token)).ToArray();
                }
                else if (dataBoard.SelectedEntity == SelectedEntity.Student)
                {
                    var res = await ((IEnumerable<Student>)result).GetViewsAsync<Student, StudentView>(token);
                    dataBoard.GetDataSource = res.ToArray();
                }
            }
            catch (TaskCanceledException)
            {
                return;
            }
        }


        private void DataBoard_HeaderMouseClick(object sender, HeaderPropertyEventArgs e)
        {
            if (dataBoard.SelectedEntity == SelectedEntity.Student)
                dataBoard.GetDataSource = ((ICollection<StudentView>)dataBoard.GetDataSource)
                                            .OrderBy(e.SelectedHeader)
                                            .ToList();

            else if (dataBoard.SelectedEntity == SelectedEntity.Group)
                dataBoard.GetDataSource = ((ICollection<GroupView>)dataBoard.GetDataSource)
                                            .OrderBy(e.SelectedHeader)
                                            .ToList();
        }

        private void DataBoard_DeleteEntity(object sender, EventArgs e)
        {
            if (((EntityArgs)e).Entity is StudentView studentView)
            {
                EFGenericRepository.Delete(EFGenericRepository.FindById<Student>(studentView.Id));
            }
            if (((EntityArgs)e).Entity is GroupView groupView)
            {
                var deleteDialog = new DeleteDialog();
                if (deleteDialog.ShowDialog() == DialogResult.OK)
                {
                    var retiringGroup = EFGenericRepository.FindById<Group>(groupView.Id);
                    if (deleteDialog.IsDeleteMembers)
                        EFGenericRepository.DeleteRange(retiringGroup.Students);

                    EFGenericRepository.Delete(retiringGroup);
                }
            }
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Group>().GetViews<Group, GroupView>().ToList();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Student>().GetViews<Student, StudentView>().ToList();
        }
    }
}
