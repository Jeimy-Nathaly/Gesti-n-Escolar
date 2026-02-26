using System;
using System.Collections.Generic;
using System.Linq;

namespace ReporteEscolar
{
    // Clase sencilla para representar al Profesor
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public string Especialidad { get; set; }
    }

    // Clase para representar al Estudiante
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        // Lista de profesores asignados a este estudiante
        public List<Profesor> Profesores { get; set; } = new List<Profesor>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creamos algunos profesores
            var prof1 = new Profesor { Nombre = "Juan Perez", Materia = "Matematicas", Especialidad = "Desarrollo" };
            var prof2 = new Profesor { Nombre = "Dra. Smith", Materia = "Base de Datos", Especialidad = "Sistemas" };
            var prof3 = new Profesor { Nombre = "Lic. Luna", Materia = "Historia", Especialidad = "Artes" };

            // 2. Creamos los estudiantes y les asignamos sus profesores directamente
            var listaEstudiantes = new List<Estudiante>
            {
                new Estudiante {
                    Id = 1,
                    Nombre = "Juan Perez",
                    Carrera = "Ingenieria",
                    Profesores = { prof1, prof2 }
                },
                new Estudiante {
                    Id = 2,
                    Nombre = "Maria Garcia",
                    Carrera = "Diseño",
                    Profesores = { prof3 }
                }
            };

            // 3. Generamos el reporte en consola
            GenerarReporte(listaEstudiantes);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void GenerarReporte(List<Estudiante> estudiantes)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("        REPORTE DE PROFESORES POR ALUMNO          ");
            Console.WriteLine("==================================================");

            foreach (var est in estudiantes)
            {
                Console.WriteLine($"\nESTUDIANTE: {est.Nombre.ToUpper()} (Carrera: {est.Carrera})");
                Console.WriteLine(new string('-', 50));

                if (est.Profesores.Count > 0)
                {
                    foreach (var prof in est.Profesores)
                    {
                        Console.WriteLine($"  > Materia: {prof.Materia,-15} | Prof: {prof.Nombre}");
                    }
                }
                else
                {
                    Console.WriteLine("  [Sin profesores asignados]");
                }
            }
            Console.WriteLine("\n==================================================");
        }
    }
}