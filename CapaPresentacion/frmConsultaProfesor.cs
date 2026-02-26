
using CapaDatos;
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
    public partial class frmConsultaProfesor : Form
    {
        private bool esNuevo = false;
        Color azulOscuro = Color.FromArgb(12, 13, 44);
        Color colorSalmon = Color.FromArgb(243, 156, 129);

        public frmConsultaProfesor()
        {
            InitializeComponent();
            FormatearDataGridView();

        }

        private void frmConsultaProfesor_Load(object sender, EventArgs e)
        {
            CargarCombosIniciales();
            ListarProfesores();
            ConfigurarEstado(false);
        }

   

        private void CargarCombosIniciales()
        {
            try
            {
                DataTable dtMaterias = N_AreaTecnica.Listar_Materias();
                if (dtMaterias != null)
                {
                    cboMateria.DataSource = dtMaterias;
                    cboMateria.DisplayMember = "Nombre_Materia";
                    cboMateria.ValueMember = "id_Materia";
                }

                DataTable dtEst = N_Estudiante.Listar_Estudiantes("");
                if (dtEst != null)
                {
                    cboEstudiantes.DataSource = dtEst;
                    cboEstudiantes.DisplayMember = "Nombre";
                    cboEstudiantes.ValueMember = "IdEstudiante";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error carga inicial: " + ex.Message);
            }
        }

        private void ListarProfesores()
        {
            try
            {
                DataTable dt = N_Profesor.Listar();
                dgvListado.DataSource = dt;

       
                foreach (DataGridViewColumn col in dgvListado.Columns)
                {
                    col.Visible = true;
                }

           
                if (dgvListado.Columns.Contains("NombreProfesor"))
                {
                    dgvListado.Columns["NombreProfesor"].Visible = true;
                    dgvListado.Columns["NombreProfesor"].HeaderText = "Profesor";
                }

                if (dgvListado.Columns.Contains("Especialidad"))
                {
                    dgvListado.Columns["Especialidad"].Visible = false;
                    dgvListado.Columns["Especialidad"].HeaderText = "Especialidad";
                }

                if (dgvListado.Columns.Contains("Telefono"))
                {
                    dgvListado.Columns["Telefono"].Visible = false;
                    dgvListado.Columns["Telefono"].HeaderText = "Telefono";
                }
                if (dgvListado.Columns.Contains("NombreMateria"))
                {
                    dgvListado.Columns["NombreMateria"].Visible = true;
                    dgvListado.Columns["NombreMateria"].HeaderText = "Materia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListado.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdProfesor"].Value);
                    string rpta = N_Profesor.Eliminar(id);

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Eliminado con éxito", "Sistema");
                        ListarProfesores();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del profesor.");
                    return;
                }

                string rpta = "";
                if (this.esNuevo)
                {
                 
                    rpta = N_Profesor.Registrar(txtNombre.Text.Trim(), "General", "000-0000000-0", "000-000-0000", "correo@ejemplo.com");
                }
                else
                {
                 
                    int id = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdProfesor"].Value);
                    int idMateria = Convert.ToInt32(cboMateria.SelectedValue);
                    rpta = N_Profesor.Actualizar(id, txtNombre.Text.Trim(), idMateria);
                }

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Datos guardados correctamente.");
                    ConfigurarEstado(false);
                    ListarProfesores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

     

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.esNuevo = true;
            LimpiarCampos();
            ConfigurarEstado(true);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.esNuevo = false;
            LimpiarCampos();
            ConfigurarEstado(false);
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
    }
        

       

        private void ConfigurarEstado(bool editando)
        {
            txtNombre.Enabled = editando;
            cboMateria.Enabled = editando;
            btnGuardar.Enabled = editando;
            btnCancelar.Enabled = editando;
            btnNuevo.Enabled = !editando;
            btnEliminar.Enabled = !editando;

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            if (cboMateria.Items.Count > 0) cboMateria.SelectedIndex = 0;
        }

        private void FormatearDataGridView()
        {
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.AllowUserToAddRows = false;
            dgvListado.ReadOnly = true;
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = azulOscuro;
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
           
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (cboEstudiantes.Items.Count > 0) cboEstudiantes.SelectedIndex = 0;
            if (cmbAreaBusqueda.Items.Count > 0) cmbAreaBusqueda.SelectedIndex = 0;
            ListarProfesores(); 
            cboEstudiantes.Focus();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            EjecutarBusqueda();
        }

        #region Busqueda Especializada

        private void EjecutarBusqueda()
        {
            try
            {
                string criterio = cboEstudiantes.Text.Trim();
                string area = cmbAreaBusqueda.Text;

                if (string.IsNullOrEmpty(criterio))
                {
                    ListarProfesores();
                    return;
                }

            
                DataTable dtResultado = N_Estudiante.Buscar_Profesor_Y_Materia(criterio, area);

                if (dtResultado != null)
                {
                    dgvListado.DataSource = dtResultado;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en búsqueda dinámica: " + ex.Message);
            }
        }

        #endregion

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
            string estudianteSeleccionado = cboEstudiantes.Text;
            string areaSeleccionada = cmbAreaBusqueda.Text;

            DataTable dt = CapaNegocios.N_Profesor.ObtenerMateriasYProfesores(estudianteSeleccionado, areaSeleccionada);

           
            FrmProfesor_Reporte frm = new FrmProfesor_Reporte(dt, estudianteSeleccionado, areaSeleccionada);
            frm.ShowDialog();


        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.esNuevo = false;
                txtNombre.Text = Convert.ToString(dgvListado.CurrentRow.Cells["NombrePro1"].Value);
                
                ConfigurarEstado(true); 
                try
                {
                  
                    dgvListado.DataSource = N_Profesor.Listar();

               
                    if (dgvListado.Columns.Count > 0)
                    {
                    

                        foreach (DataGridViewColumn col in dgvListado.Columns)
                        {
                          
                            if (col.Name == "Nombre_Materia" || col.Name == "Profesor" || col.Name == "Nombre_Profesor")
                            {
                                col.Visible = true;
                            }
                            else
                            {
                                col.Visible = false;
                            }
                        }

        
                        dgvListado.Columns["Profesor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

