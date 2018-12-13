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
using CitrusDB.View.Students;
using CitrusDB.View.Groups.GroupsView.GroupViews;
using System.Runtime.ExceptionServices;
using System.Reflection;

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
            dataBoard.GetEntityBySelectedView += DataBoard_GetEntityBySelectedView;
            dataBoard.DeleteEntity += DataBoard_DeleteEntity;

            dataBoard.SearchBoxTextChanged += DataBoard_SearchBoxTextChanged;
        }

        private IEntity DataBoard_GetEntityBySelectedView(object sender, EntityTransferEventArgs e)
        {
            var selectedView = e.entity;

            if (selectedView is StudentView studentView)
            {
                return EFGenericRepository.Find<Student>(studentView.Id);
            }
            else if (selectedView is GroupView groupView)
            {
                return EFGenericRepository.Find<Group>(groupView.Id);
            }
            return null;
        }

        private void DataBoard_SearchBoxTextChanged(string condition, string searchCriteria, EventArgs e)
        {
            currentTask?.CancelTask();

            currentTask = new TaskInfo(SearchEntities,
                condition, searchCriteria,
                ((AfterSearchingEventArgs)e)?.sorting,
                ((AfterSearchingEventArgs)e)?.conditionSorting);
        }

        private void SearchEntities(string conditionFilter, string searchCriteria, Action<string> sorting, string conditionSorting, CancellationToken token)
        {
            Type resultType = dataBoard.GetDataSource.GetType().UnderlyingSystemType.GetElementType();

            GetMethod("FillDataSource", resultType)
                .Invoke(this, new object[] { searchCriteria, conditionFilter, sorting, conditionSorting, token });
        }

        private async void FillDataSource<TResult>(string searchCriteria, string conditionFilter, Action<string> sorting, string conditionSorting, CancellationToken token)
            where TResult : class, IEntity
        {
            try
            {
                var task = GetMethod("GetViews", dataBoard.TypeOfSelectedEntity, typeof(TResult))
                    .Invoke(null, new object[] { searchCriteria, conditionFilter, token });

                dataBoard.GetDataSource = await (Task<TResult[]>)task;
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
            sorting?.Invoke(conditionSorting);
            Console.WriteLine("SUCCESSFULLY");
        }

        private MethodInfo GetMethod(string name, params Type[] types)
        {
            var method = GetType()
               .GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
               .MakeGenericMethod(types);

            return method;
        }

        private static async Task<TResult[]> GetViews<TEntity, TResult>(string searchCriteria, string conditionFilter, CancellationToken token)
            where TEntity : class, IEntity
            where TResult : class, IEntity
        {

            return await Task.Factory.StartNew(() =>
            {
                return EFGenericRepository.Get<TEntity>(searchCriteria, conditionFilter).GetViews<TEntity, TResult>().ToArray();
            }, token);
        }

        private void DataBoard_HeaderMouseClick(object sender, OrderByEventArgs e)
        {
            Type type = dataBoard.GetDataSource.GetType().UnderlyingSystemType.GetElementType();

            GetMethod("OrderData", type).Invoke(this, new object[] { e.OrderCriteria, e.IsAscending });
        }

        private void OrderData<TEntity>(string filter, bool isAscending)
            where TEntity : class, IEntity
        {
            if (isAscending)
            {
                dataBoard.GetDataSource = ((ICollection<TEntity>)dataBoard.GetDataSource)
                                                .OrderBy(filter)
                                                .ToArray();
            }
            else
            {
                dataBoard.GetDataSource = ((ICollection<TEntity>)dataBoard.GetDataSource)
                                                .OrderByDescending(filter)
                                                .ToArray();
            }
        }

        private void DataBoard_DeleteEntity(object sender, EventArgs e)
        {
            if (((EntityArgs)e).Entity is StudentView studentView)
            {
                var studentToDelete = EFGenericRepository.Find<Student>(studentView.Id);

                if (studentToDelete.Group != null)
                    EFGenericRepository.Update(studentToDelete.Group);

                EFGenericRepository.Delete(studentToDelete);
            }
            else if (((EntityArgs)e).Entity is GroupView groupView)
            {
                var deleteDialog = new DeleteDialog();
                if (deleteDialog.ShowDialog() == DialogResult.OK)
                {
                    var retiringGroup = EFGenericRepository.Find<Group>(groupView.Id);
                    if (deleteDialog.IsDeleteMembers)
                        EFGenericRepository.DeleteRange(retiringGroup.Students);

                    EFGenericRepository.Delete(retiringGroup);
                }
            }
        }

        private void DataBoard_GroupTableLoad(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Group>().GetViews<Group, GroupView>().ToArray();
        }

        private void DataBoard_LoadDataBoard(object sender, EventArgs e)
        {
            dataBoard.GetDataSource = EFGenericRepository.Get<Student>().GetViews<Student, StudentView>().ToArray();
        }
    }
}
