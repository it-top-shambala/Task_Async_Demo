using Task_Async_Demo.Lib;

var cts = new CancellationTokenSource();
var cancelToken = cts.Token;

var taskRed = new Task(() => TaskPrint.TaskPrintRed("+", cancelToken), cancelToken);
var taskGreen = new Task(() => TaskPrint.TaskPrintGreen("-", cancelToken), cancelToken);

taskRed.Start();
taskGreen.Start();

Console.Write("Для отмены вывода нажмите клавишу 'C'");
var cancelKey = Console.ReadKey();
if (cancelKey.Key == ConsoleKey.C)
{
    cts.Cancel();
}

Console.ReadKey();