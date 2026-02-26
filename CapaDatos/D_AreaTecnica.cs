using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_AreaTecnica
    {
        public DataTable Listado_Areas()
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
         
                SqlCommand Comando = new SqlCommand("SELECT Id_Area_Tecnica, Area_Tecnica FROM Area_Tecnica", SqlCon);
                SqlCon.Open();
                Tabla.Load(Comando.ExecuteReader());
                return Tabla;
            }
            catch (Exception ex) { throw ex; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public DataTable Listar_Materias()
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
             
                string sql = "SELECT id_Materia, Nombre_Materia FROM Materia";
                SqlCommand Comando = new SqlCommand(sql, SqlCon);
                SqlCon.Open();
                Tabla.Load(Comando.ExecuteReader());
                return Tabla;
            }
            catch (Exception ex) { throw ex; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public string Guardar_Materia(string nombre)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                string sql = "INSERT INTO Materia (NombreMateria, Estado) VALUES (@nom, 1)";
                SqlCommand Comando = new SqlCommand(sql, SqlCon);
                Comando.Parameters.AddWithValue("@nom", nombre);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "Error";
            }
            catch (Exception ex) { Rpta = ex.Message; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
            return Rpta;
        }
    }

    public class D_Profesor_Extendida
    {
        public DataTable Listar_Profesores()
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
       
                string sql = "SELECT Id_Profesor, (NombreProfesor + ' ' + ApellidoProfesor) as NombreCompleto FROM Profesor";
                SqlCommand Comando = new SqlCommand(sql, SqlCon);
                SqlCon.Open();
                Tabla.Load(Comando.ExecuteReader());
                return Tabla;
            }
            catch (Exception ex) { throw ex; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }



    }
}
