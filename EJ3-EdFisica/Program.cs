using NLog;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    private static void Main(string[] args)
    {
        Logger.Trace("Inicio de ejecución del programa");
        //Plantilla menu principal:
        string? opcion;
        do {
            Console.Clear();
            Console.WriteLine("\n¿Qué operación desea realizar?\n");
            Console.WriteLine("(I)ngresar Alumno    (B)orrar    (S)alir\n");
            try {
                opcion = Console.ReadLine()!.ToLower();
            }
            catch (Exception) {
                opcion = "z";
            }
            if (opcion == "i")
                cargarLista();
            if (opcion == "b")
                borrarLista();
        } while (opcion != "s");

    }
}

