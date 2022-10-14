public class Alumno
{
    static private int alumnosCreados = 10;

    private int id;
    private string nombre;
    private string apellido;
    private int dni;
    private int curso;

    public Alumno(string nombre, string apellido, int dni, int curso)
    {
        this.Id = ++alumnosCreados;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Dni = dni;
        this.Curso = curso;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Dni { get => dni; set => dni = value; }
    public int Curso { get => curso; set => curso = value; }

}