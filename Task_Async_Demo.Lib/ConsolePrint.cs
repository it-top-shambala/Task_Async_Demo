namespace Task_Async_Demo.Lib;

public class ConsolePrint
{
    private void Print(string msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
        Console.ResetColor();
    }

    public void PrintRed(string msg)
    {
        Print(msg, ConsoleColor.Red);
    }

    public void PrintGreen(string msg)
    {
        Print(msg, ConsoleColor.Green);
    }
}