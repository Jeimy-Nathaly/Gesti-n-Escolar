using System;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
  
    public class D_Profesor
    {
     
            public string Guardar_Profesor(string nombre, string apellido, string especialidad, string tel, string email)
            {
                string rpta = "";
                SqlConnection sqlCon = new SqlConnection();
                try
                {
                    sqlCon = Conexion.CrearInstancia().CrearConexion();
                    string sql = "INSERT INTO Profesor (NombreProfesor, ApellidoProfesor, Especialidad, Telefono, Email) VALUES (@nom, @ape, @esp, @tel, @ema)";
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    cmd.Parameters.AddWithValue("@nom", nombre);
                    cmd.Parameters.AddWithValue("@ape", apellido);
                    cmd.Parameters.AddWithValue("@esp", especialidad);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@ema", email);
                    sqlCon.Open();
                    rpta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "Error";
                }
                catch (Exception ex) { rpta = ex.Message; }
                finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
                return rpta;
            }
            public DataTable Buscar_Profesor_Y_Materia(string nombreEstudiante, string areaTecnica)
            {
                DataTable dtResultado = new DataTable();
                SqlConnection sqlCon = new SqlConnection();

                try
                {

                    sqlCon = Conexion.CrearInstancia().CrearConexion();


                    SqlCommand comando = new SqlCommand("USP_Buscar_Profesor_Y_Materia", sqlCon);

                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombreEstudiante;
                    comando.Parameters.Add("@area", SqlDbType.VarChar).Value = areaTecnica;

                    sqlCon.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    dtResultado.Load(leer);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error al consultar los datos: " + ex.Message);
                }
                finally
                {

                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }

                return dtResultado;


            }

  
        public DataTable Listar_Profesor()
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
                string sql = "SELECT * FROM Profesor";
                SqlCommand comando = new SqlCommand(sql, sqlCon);
                sqlCon.Open();
                tabla.Load(comando.ExecuteReader());
                return tabla;
            }
            catch (Exception ex) { throw ex; }
            finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
        }


        public string Eliminar(int IdProfesor)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
       
                string sql = "DELETE FROM Profesor WHERE IdProfesor = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@id", IdProfesor);
                sqlCon.Open();
                rpta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar";
            }
            catch (Exception ex) { rpta = ex.Message; }
            finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
            return rpta;
        }

        public string Actualizar(int id, string nombre, int idMateria)
{
    string rpta = "";
    SqlConnection sqlCon = new SqlConnection();
    try
    {
        sqlCon = Conexion.CrearInstancia().CrearConexion();
   
        string sql = "UPDATE Profesor SET NombreProfesor = @nom = IdMateria = @idMat WHERE IdProfesor = @id";
        
        SqlCommand cmd = new SqlCommand(sql, sqlCon);
        cmd.Parameters.AddWithValue("@nom", nombre);
        cmd.Parameters.AddWithValue("@idMat", idMateria);
        cmd.Parameters.AddWithValue("@id", id);
        
        sqlCon.Open();
        rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar";
    }
    catch (Exception ex) { rpta = ex.Message; }
    finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
    return rpta;
}
    }
    }
