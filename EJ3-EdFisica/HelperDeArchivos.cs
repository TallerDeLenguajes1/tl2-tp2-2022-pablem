static public class HelperDeArchivos
{
   static public string[] cursos = {"Atletismo.csv","Futbol.csv","Voley.csv"}; 

   static public void escribir(int N, Alumno alumno) 
   {
      N--;
      StreamWriter sw = new StreamWriter(cursos[N],true); // append = true
      sw.WriteLine(alumno.Id+","+alumno.Apellido+","+alumno.Nombre+","+alumno.Dni+","+alumno.Curso);
      sw.Close();
   }

   static public void limpiar(int N) 
   {
      N--;
      if (File.Exists(cursos[N]))
      {
         FileStream fs = new FileStream(cursos[N], FileMode.Truncate);
         fs.Close();   
      }
   }
}