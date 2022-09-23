static class HelperDeArchivos
{
   static public void escribirContenido(string nombre, Alumno alumno) {

        string nombreArchivo = @"c:\Repogit\Tempo\"+nombre+".csv";

        StreamWriter sw = new StreamWriter(nombreArchivo,true); // append = true
        sw.WriteLine(alumno.Id+",",alumno.Apellido+","+alumno.Nombre+","+alumno.Dni+","+alumno.Curso);
        sw.Close();
   }

   static public void limpiarContenido(string nombre) {

   }
}