using NLog;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    private static void Main(string[] args)
    {
        Logger.Trace("Inicio de ejecución del programa");

    }
}

