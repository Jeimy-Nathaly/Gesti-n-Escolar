using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jnGestionEscolar
{
    public partial class FrmProfesor_Reporte : Form
    {
        string cadenaConexion = @"Server=R4MZZX\JEIMYN; Database=Gestion_Escolar; Integrated Security=True";

        public FrmProfesor_Reporte()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Reporte_Load(object sender, EventArgs e)
        {
          
            CargarReporteDirecto();
        }


        private void CargarReporteDirecto()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    
                    string query = @"SELECT IdProfesor, Nombre, Apellido, Especialidad 
                                   FROM Profesores";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                  
                    reportViewer1.LocalReport.DataSources.Clear();

                 
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
