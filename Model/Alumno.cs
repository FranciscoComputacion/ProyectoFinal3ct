namespace ProyectoFinal3ct.Model
{
    public class Alumno
    {
       public  string nombre { get; set; }
        public string curso { get; set; }
        public int calificacion { get; set; }

        public Alumno()
        {

        }

        public Alumno(string nombre, string curso, int calificacion)
        {
            this.nombre = nombre;
            this.curso = curso;
            this.calificacion = calificacion;
        }
    }
}
