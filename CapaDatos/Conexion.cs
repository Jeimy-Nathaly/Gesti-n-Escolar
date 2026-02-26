using System.Data.SqlClient;


namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection
            {
             
                ConnectionString = @"Server=R4MZZX\JEIMYN; Database=Gestion_Escolar; Integrated Security=True"
            };
            return Cadena;
        }
        public static Conexion CrearInstancia() => new Conexion();
    }
}

