using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class D_Estudiante
    {

        public DataTable Listar_Estudiantes(string cTexto)
        {
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
        
                string sql = "SELECT * FROM Vw_ListarEstudiantes WHERE Nombre LIKE @txt OR Apellidos LIKE @txt";


                SqlCommand comando = new SqlCommand(sql, sqlCon);
                comando.Parameters.AddWithValue("@txt", "%" + cTexto + "%");

                sqlCon.Open();
                tabla.Load(comando.ExecuteReader());
                return tabla;
            }
            catch (Exception ex) { throw ex; }
            finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
        }


        public string Guardar_Estudiante(int nOpcion, E_Estudiante oProp)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
                string sql = nOpcion == 1 ?
                "INSERT INTO Estudiante (Nombre, Apellidos, Direccion, Telefono, Email, Id_Area_Tecnica, Estado) VALUES (@nom,@ape,@dir,@tel,@ema,@are, 1)" :
                "UPDATE Estudiante SET Nombre=@nom, Apellidos=@ape, Direccion=@dir, Telefono=@tel, Email=@ema, Id_Area_Tecnica=@are WHERE id_Estudiante=@id";

                SqlCommand comando = new SqlCommand(sql, sqlCon);
                if (nOpcion == 2) comando.Parameters.AddWithValue("@id", oProp.id_Estudiante);
                comando.Parameters.AddWithValue("@nom", oProp.Nombre);
                comando.Parameters.AddWithValue("@ape", oProp.Apellidos);
                comando.Parameters.AddWithValue("@dir", oProp.Direccion);
                comando.Parameters.AddWithValue("@tel", oProp.Telefono);
                comando.Parameters.AddWithValue("@ema", oProp.Email);
                comando.Parameters.AddWithValue("@are", oProp.Id_Area_Tecnica);

                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo realizar la operación";
            }
            catch (Exception ex) { Rpta = ex.Message; }
            finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
            return Rpta;
        }


        public string Eliminar_Estudiante(int nId)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("UPDATE Estudiante SET Estado = 0 WHERE id_Estudiante = @id", sqlCon);
                comando.Parameters.AddWithValue("@id", nId);
                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex) { Rpta = ex.Message; }
            finally { if (sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
            return Rpta;
        }
        public DataTable Listar(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_ESTUDIANTES", sqlCon); 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }


    }





}
        
    





