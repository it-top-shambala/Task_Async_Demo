using Task_Async_Demo.Lib;

var cts = new CancellationTokenSource();
var cancelToken = cts.Token;

var task = TaskPrint.TaskPrintRedA("=", cancelToken);
task.Start();

Console.Write("Для отмены вывода нажмите клавишу 'C'");
var cancelKey = Console.ReadKey();
if (cancelKey.Key == ConsoleKey.C)
{
    cts.Cancel();
}

switch (task.Status)
{
    case TaskStatus.Canceled:
        Console.WriteLine("Задача была отменена");
        break;
    case TaskStatus.RanToCompletion:
        Console.WriteLine("Задача была выполнена до конца");
        break;
    case TaskStatus.Created:
        Console.WriteLine(nameof(TaskStatus.Created));
        break;
    case TaskStatus.WaitingForActivation:
        Console.WriteLine(nameof(TaskStatus.WaitingForActivation));
        break;
    case TaskStatus.WaitingToRun:
        Console.WriteLine(nameof(TaskStatus.WaitingToRun));
        break;
    case TaskStatus.Running:
        Console.WriteLine(nameof(TaskStatus.Running));
        break;
    case TaskStatus.WaitingForChildrenToComplete:
        Console.WriteLine(nameof(TaskStatus.WaitingForChildrenToComplete));
        break;
    case TaskStatus.Faulted:
        Console.WriteLine(nameof(TaskStatus.Faulted));
        break;
    default:
        throw new ArgumentOutOfRangeException();
}

Console.ReadKey();