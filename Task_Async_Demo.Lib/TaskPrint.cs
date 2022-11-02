namespace Task_Async_Demo.Lib;

public static class TaskPrint
{
    private static void TaskPrintAction(string msg, Action<string> action, CancellationToken? token = null)
    {
        for (int i = 0; i < 10; i++)
        {
            if (token != null && (bool)token?.IsCancellationRequested) return;

            action(msg);
            Thread.Sleep(1000);
        }
    }
    
    public static void TaskPrintRed(string msg, CancellationToken? token = null)
    { 
        var console = new ConsolePrint(); 
        TaskPrintAction(msg, console.PrintRed, token);
    }
    
    public static void TaskPrintGreen(string msg, CancellationToken? token = null)
    {
        var console = new ConsolePrint();
        TaskPrintAction(msg, console.PrintGreen, token);
    }
}