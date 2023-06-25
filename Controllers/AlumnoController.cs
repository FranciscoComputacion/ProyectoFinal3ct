using Microsoft.AspNetCore.Mvc;
using ProyectoFinal3ct.Model;
using System.Reflection.Metadata.Ecma335;

namespace ProyectoFinal3ct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnoController
    {
        public List<Alumno> lista = new List<Alumno>();
        public AlumnoController()
        {
            lista.Add(new Alumno("Carlos", "Java", 8));
            lista.Add(new Alumno("Sofia", "MongoDB", 9));
            lista.Add(new Alumno("Julio", "Java", 10));
            lista.Add(new Alumno("Tania", "MongoDB", 9));
            lista.Add(new Alumno("Pedro", "Java", 8));
            lista.Add(new Alumno("Antonio", "MongoDB", 9));
            lista.Add(new Alumno("Alverto", "Java", 10));
            lista.Add(new Alumno("Juan", "C#", 9));
            lista.Add(new Alumno("Rodrigo", "Java", 8));
            lista.Add(new Alumno("Katia", "C#", 9));

        }

        [HttpGet(Name = "GetListaAlumno")]
        public List<Alumno> ListaAlumno()
        {
            return lista;
        }

        [HttpGet]
        [Route("/Buscar")]
        public   List<Alumno>AlumnosPorCurso(string curso)

        {
             List<Alumno> respuesta = new List<Alumno>();
           foreach (Alumno alumnoActual in lista)
            {
                if (curso.Equals(alumnoActual.curso, StringComparison.OrdinalIgnoreCase))
                {
                    respuesta.Add(alumnoActual);
                    
                }
            }

            return respuesta;
            
            
                
            
        }
       
    }
}
