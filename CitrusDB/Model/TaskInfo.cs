using System;
using System.Threading;
using System.Threading.Tasks;

namespace CitrusDB.Model
{
  class TaskInfo : IDisposable
  {
    private readonly Task _task;
    private readonly CancellationTokenSource _tokenSource;

    public bool IsCurrentCompleted => _task.IsCompleted;

    public TaskInfo(Action<object, CancellationToken> action, object parameter)
    {
      _tokenSource = new CancellationTokenSource();
      var token = _tokenSource.Token;

      _task = new Task(() => action.Invoke(parameter, token), token);

      Console.WriteLine($"Task{_task.Id} was run !");

      _task.RunSynchronously();
    }

    public TaskInfo(Action<string, string, CancellationToken> action, string conditionFilter, string searchCriteria)
    {
      _tokenSource = new CancellationTokenSource();
      var token = _tokenSource.Token;

      _task = new Task(() => action.Invoke(conditionFilter, searchCriteria, token), token);

      Console.WriteLine($"Task{_task.Id} was run !");

      _task.RunSynchronously();
    }

    public TaskInfo(Action<string, string, Action<string>, string, CancellationToken> action, string conditionFilter, string searchCriteria, Action<string> sorting, string conditionSorting)
    {
      _tokenSource = new CancellationTokenSource();
      var token = _tokenSource.Token;

      _task = new Task(() => action.Invoke(conditionFilter, searchCriteria, sorting, conditionSorting, token), token);

      Console.WriteLine($"Task{_task.Id} was run !");

      _task.RunSynchronously();
    }

    public void CancelTask()
    {
      _tokenSource.Cancel();

      if (!_task.IsCompleted)
        Console.WriteLine($"Task{_task.Id} was canceld !");

      _task.Dispose();
    }

    public void Dispose()
    {
      _task.Dispose();
      _tokenSource.Dispose();
    }
  }
}
