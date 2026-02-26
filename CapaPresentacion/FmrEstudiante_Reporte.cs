using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaDatos; 

namespace jnGestionEscolar
{
    public partial class FmrEstudiante_Reporte : Form
    {
        public FmrEstudiante_Reporte()
        {

            InitializeComponent();
        }

        private void FmrEstudiante_Reporte_Load(object sender, EventArgs e)
        {
            this.GenerarListado();
           

        }

        private void GenerarListado()
        {
            try
            {
                D_Estudiante datos = new D_Estudiante();
                DataTable dt = datos.Listar_Estudiantes("");

              
                this.reportViewer1.LocalReport.DataSources.Clear();

             
                ReportDataSource fuente = new ReportDataSource("DataSet_Datos", dt);

          
                this.reportViewer1.LocalReport.ReportPath = "Reporte_Es.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(fuente);

             
               
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


  
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
    }
