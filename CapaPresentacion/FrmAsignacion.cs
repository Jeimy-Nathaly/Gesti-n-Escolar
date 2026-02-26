using CapaNegocios;
using jnGestionEscolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAsignacion : Form
    {
        
        private bool esNuevo = false;
        private string idSeleccionado = "";

        public FrmAsignacion()
        {
            InitializeComponent();
            AplicarDisenoEstético();
        }

        private void FrmAsignacion_Load(object sender, EventArgs e)
        {
            CargarCombosIniciales();
            ListarMatriculas();
            ConfigurarEstadoInterfaz(false);
        }

        #region Carga de Datos y Combos




        private void CargarCombosIniciales()
        {
            try
            {
              
                DataTable dtEst = N_Estudiante.Listar_Para_Combo();
                if (dtEst != null && dtEst.Rows.Count > 0)
                {
                    cmbEstudiante.DataSource = dtEst;
                    cmbEstudiante.ValueMember = dtEst.Columns[0].ColumnName;
                    cmbEstudiante.DisplayMember = "Nombre";
                }

               
                DataTable dtArea = N_AreaTecnica.Listado_Areas();
                if (dtArea != null && dtArea.Rows.Count > 0)
                {
                    cmbAreaTecnica.DataSource = dtArea;
                    cmbAreaTecnica.ValueMember = dtArea.Columns[0].ColumnName;
                    cmbAreaTecnica.DisplayMember = "Area_Tecnica";
                }

               
                DataTable dtMat = N_AreaTecnica.Listar_Materias();
                if (dtMat != null && dtMat.Rows.Count > 0)
                {
                    cmbMateria.DataSource = dtMat;
                    cmbMateria.ValueMember = dtMat.Columns[0].ColumnName;
                    cmbMateria.DisplayMember = "Nombre_Materia";
                }

                
                DataTable dtProf = N_Profesor.Listar();
                if (dtProf != null && dtProf.Rows.Count > 0)
                {
                    cmbProfesor.DataSource = dtProf;
                    cmbProfesor.ValueMember = dtProf.Columns[0].ColumnName;
                    cmbProfesor.DisplayMember = "NombreProfesor";
                }

                LimpiarSeleccionCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarColumnasEspecificas()
        {
            if (dgvDatos.Columns.Count > 0)
            {
                
                string[] columnasAOCultar = {
              
                  
                    "idareatecnica",
                  
              
                    "direccion",
                 
                    "estado",
                    "id_area_tecnica"
                };

                foreach (DataGridViewColumn col in dgvDatos.Columns)
                {
                  
                    if (columnasAOCultar.Any(c => col.Name.ToLower().Contains(c.ToLower())))
                    {
                        col.Visible = false;
                    }
                    else
                    {
                     
                        col.Visible = true;
                    }
                }

                if (dgvDatos.Columns.Contains("Area_Tecnica")) dgvDatos.Columns["Area_Tecnica"].HeaderText = "Área Técnica";
                if (dgvDatos.Columns.Contains("Nombre_Materia")) dgvDatos.Columns["Nombre_Materia"].HeaderText = "Materia";
                if (dgvDatos.Columns.Contains("NombreProfesor")) dgvDatos.Columns["NombreProfesor"].HeaderText = "Profesor";

                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ListarMatriculas()
        {
            try
            {
                dgvDatos.DataSource = N_Estudiante.Listar_Estudiantes(txtBuscar.Text.Trim());
                OcultarColumnasEspecificas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar: " + ex.Message);
            }
        }



        #endregion

        #region Lógica de Botones Laterales

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedIndex == -1 || cmbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Aviso: Debe seleccionar un estudiante y al menos una materia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            esNuevo = true;
            ConfigurarEstadoInterfaz(true);
            MessageBox.Show("Modo de registro activado. Presione Guardar para confirmar.", "Información");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarMatriculas();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (cmbEstudiante.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un estudiante primero.", "Aviso");
                    return;
                }

                if (listaTemporal.Count == 0)
                {
                    MessageBox.Show("No hay materias agregadas para mostrar en el reporte.", "Aviso");
                    return;
                }

               
                string nombreCompleto = cmbEstudiante.Text;

                DataTable dtParaReporte = new DataTable();
                dtParaReporte.Columns.Add("ASIGNATURA", typeof(string));
                dtParaReporte.Columns.Add("PROFESOR", typeof(string));

            
                foreach (var item in listaTemporal)
                {
                    dtParaReporte.Rows.Add(item.NombreMateria, item.NombreProfesor);
                }

                if (dtParaReporte.Rows.Count > 0)
                {
                
                    FrmReporte_Materia rpt = new FrmReporte_Materia(nombreCompleto, dtParaReporte);
                    rpt.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        #endregion

        #region Lógica de Botones Centrales

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var mat in listaTemporal)
                {
                  
                }
                MessageBox.Show("Todas las materias fueron asignadas.");
                listaTemporal.Clear();
                lstMateriasAgregadas.Items.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            ConfigurarEstadoInterfaz(false);
            LimpiarSeleccionCombos();
        }

        #endregion

        #region Ayudantes de Interfaz

        private void ConfigurarEstadoInterfaz(bool editando)
        {
            btnGuardar.Enabled = editando;
            btnCancelar.Enabled = editando;
            btnNuevo.Enabled = !editando;
            btnEliminar.Enabled = !editando;
            btnReporte.Enabled = !editando;
        }

        private void LimpiarSeleccionCombos()
        {
            cmbEstudiante.SelectedIndex = -1;
            cmbAreaTecnica.SelectedIndex = -1;
            cmbMateria.SelectedIndex = -1;
            cmbProfesor.SelectedIndex = -1;
        }

        private void LimpiarSoloDetalle()
        {
            cmbMateria.SelectedIndex = -1;
            cmbProfesor.SelectedIndex = -1;
            cmbMateria.Focus();
        }

        Color beigeFormulario = Color.FromArgb(225, 198, 153);

        private void AplicarDisenoEstético()
        {
            Color azulOscuroHeader = Color.FromArgb(28, 35, 49);
            Color colorLineas = Color.FromArgb(200, 200, 200); 

            
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.FixedSingle;

           
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvDatos.GridColor = colorLineas;

            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.EnableHeadersVisualStyles = false;

           
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = azulOscuroHeader;
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle = headerStyle;

           
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            rowStyle.SelectionBackColor = beigeFormulario; 
            rowStyle.SelectionForeColor = Color.Black;

            dgvDatos.DefaultCellStyle = rowStyle;
            dgvDatos.AlternatingRowsDefaultCellStyle.SelectionBackColor = beigeFormulario;
        }

        #endregion

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarSeleccionCombos();
            txtBuscar.Clear();
            esNuevo = false;
            ConfigurarEstadoInterfaz(false);
            ListarMatriculas();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DialogResult opcion = MessageBox.Show("¿Desea eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    idSeleccionado = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                    ListarMatriculas();
                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public class MateriaAsignada
        {
            public int IdMateria { get; set; }
            public string NombreMateria { get; set; }
            public string NombreProfesor { get; set; }
        }

       
        private List<MateriaAsignada> listaTemporal = new List<MateriaAsignada>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedIndex == -1) return;

            
            listaTemporal.Add(new MateriaAsignada
            {
                IdMateria = (int)cmbMateria.SelectedValue,
                NombreMateria = cmbMateria.Text,
                NombreProfesor = cmbProfesor.Text
            });

           
            lstMateriasAgregadas.Items.Add($"{cmbMateria.Text} - {cmbProfesor.Text}");

            MessageBox.Show("Materia añadida a la lista.");
        }

        private void lstMateriasAgregadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}