using CapaDatos;
using System.Data;
using static CapaNegocios.N_AreaTecnica;
using System;

namespace CapaNegocios
{
    public class N_AreaTecnica
    {
        
        public static DataTable Listado_Areas()
        {
            D_AreaTecnica Datos = new D_AreaTecnica();
            return Datos.Listado_Areas();
        }

        
            public static DataTable Listar_Materias()
            {
                return new D_AreaTecnica().Listar_Materias();
            }
        

            public static DataTable Listar_Profesores()
            {
                return new D_Profesor_Extendida().Listar_Profesores();
            }

        public static DataTable Listar()
        {
            return new DataTable();
        }

    }
}