using NLog;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    private static void Main(string[] args)
    {
        Logger.Info("Inicio de ejecución del programa");

        string? opcion;
        do {
            Console.Clear();
            Console.WriteLine("\n¿Qué operación desea realizar?\n");
            Console.WriteLine("(R)egistrar Alumnos    (B)orrar Lista    (S)alir\n");
            try {
                opcion = Console.ReadLine()!.ToLower();
            }
            catch (Exception) {
                Logger.Debug("Ingreso de cód. de operación");
                opcion = "z";
            }
            if (opcion == "r")
                registrarAlumnos(seleccionarCurso());
            if (opcion == "b")
                HelperDeArchivos.limpiar(seleccionarCurso());
        } while (opcion != "s");
    }

    public static int seleccionarCurso() 
    {
        int nro = 9;
        do {
            Console.WriteLine("\nCursos disponibles, seleccione el número correspondiente:");
            Console.WriteLine("\n(1) Atletismo \n(2) Fútbol \n(3) Voley");
            try {
                nro = Convert.ToUInt16(Console.ReadLine()!);
            }
            catch (Exception ex) {
                Logger.Debug(ex,"Elegir curso: cód. inválido");
                nro = 9;
            }
        } while (nro != 1 && nro != 2 && nro != 3 && nro != 55); // 55 prueba para que falle 

        return nro;
    }

    public static void registrarAlumnos(int curso) 
    {
        string? opcion;
        Alumno nuevo;
        string nombre, apellido;
        int dni;
        do {
            try {
                Console.WriteLine("\n--- Nuevo Alumno ---\n");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Apellido:");
                apellido = Console.ReadLine();
                Console.WriteLine("DNI:");
                dni = Convert.ToInt32(Console.ReadLine());

                nuevo = new Alumno(nombre,apellido,dni,curso);
                HelperDeArchivos.escribir(curso,nuevo);

                Console.WriteLine("\nAlumno guardado... ¿Desea registrar otro alumno?(s/n)");
                opcion = Console.ReadLine()!.ToLower();
            }
            catch (Exception e) {
                Logger.Debug(e,"Ingreso de datos del alumno");
                opcion = "s";
            }
        } while (opcion != "n");
    }
}
