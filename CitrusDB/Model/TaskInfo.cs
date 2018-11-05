using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CitrusDB.Model
{
    class TaskInfo
    {
        readonly Task task;
        readonly CancellationTokenSource tokenSource;

        public bool IsCurrentCompleted => task.IsCompleted;

        public TaskInfo(Action<object, CancellationToken> action, object parameter)
        {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            task = new Task(() => action.Invoke(parameter, token), token);

            Console.WriteLine($"Task{task.Id} was run !");

            task.RunSynchronously();
        }

        public void CancelTask()
        {
            tokenSource.Cancel();

            if (!task.IsCompleted)
                Console.WriteLine($"Task{task.Id} was canceld !");

            task.Dispose();
        }

    }
}
