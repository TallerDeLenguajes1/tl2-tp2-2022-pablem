
using NLog;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        Console.WriteLine("Hello world!");
        Logger.Info("Goodbye cruel world");
        Logger.Debug("Goodbye cruel world");
    }
}  
