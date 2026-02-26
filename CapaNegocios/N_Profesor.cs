using CapaDatos;
using CapaEntidades;
using System;
using System.Data;

namespace CapaNegocios
{
    public class N_Profesor
    {
  
public static DataTable Listar()
        {
      
            D_Profesor Datos = new D_Profesor();
            return Datos.Listar_Profesor();
        }

        public static string Registrar(string nombre, string apellido, string especialidad, string tel, string email)
        {
            D_Profesor Datos = new D_Profesor();
            return Datos.Guardar_Profesor(nombre, apellido, especialidad, tel, email);
        }

        public static string Eliminar(int idProfesor)
        {
            D_Profesor Datos = new D_Profesor();
            return Datos.Eliminar(idProfesor);
        }

        public static string Actualizar(int id, string nombre, int idMateria)
        {
            D_Profesor Datos = new D_Profesor();
            return Datos.Actualizar(id, nombre, idMateria);
        }

        public static DataTable ObtenerMateriasYProfesores(string estudiante, string area)
        {
            D_Profesor Datos = new D_Profesor();
            
            return Datos.Listar_Profesor();
        }
        public static DataTable Buscar(string valor)
        {
            D_Profesor Datos = new D_Profesor();
        
            return Datos.Listar_Profesor(); 
        }
   

    }
}