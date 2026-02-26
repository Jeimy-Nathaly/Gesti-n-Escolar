using CapaDatos;
using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using static CapaDatos.D_Estudiante;


namespace CapaNegocios
{
    
        public class N_Estudiante
        {
            public static DataTable Listar_Estudiantes(string cTexto)
            {
                D_Estudiante Datos = new D_Estudiante();
                return Datos.Listar_Estudiantes(cTexto);
            }

            public static string Guardar_Estudiante(int nOpcion, E_Estudiante oProp)
            {
                D_Estudiante Datos = new D_Estudiante();
                return Datos.Guardar_Estudiante(nOpcion, oProp);
            }

            public static string Eliminar_Estudiante(int nId)
            {
                D_Estudiante Datos = new D_Estudiante();
                return Datos.Eliminar_Estudiante(nId);
            }

        public static DataTable Buscar_Profesor_Y_Materia(string nombre, string area)
        {
             D_Profesor Datos = new D_Profesor();
            return Datos.Buscar_Profesor_Y_Materia(nombre, area);
        }


        public static string Registrar_Matricula(int idEstudiante, int idArea, int idMateria, string profesor)
        {
            try
            {
            
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static DataTable Listar_Para_Combo()
        {
            D_Estudiante Datos = new D_Estudiante();
  
            return Datos.Listar_Estudiantes("");
        }

    }


}

