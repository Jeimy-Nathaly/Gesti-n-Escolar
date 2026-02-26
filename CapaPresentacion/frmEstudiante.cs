using CapaEntidades;
using CapaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;
using jnGestionEscolar;

namespace CapaPresentacion
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }
        int nOpcion = 0;
        int nIdEstudiante = 0;

        private void Estado_Texto(bool lEstado)
        {
            txtNombre.ReadOnly = !lEstado; txtApellidos.ReadOnly = !lEstado;
            txtDireccion.ReadOnly = !lEstado; txtTelefono.ReadOnly = !lEstado;
            txtEmail.ReadOnly = !lEstado; cmbAreaTecnica.Enabled = lEstado; 
        }

        private void Estado_Botones(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnEliminar.Enabled = lEstado;
            btnSalir.Enabled = lEstado;

        
            btnGuardar.Visible = !lEstado;
            btnCancelar.Visible = !lEstado;
        }

        private void Limpiar_Texto()
        {
            txtNombre.Clear(); txtApellidos.Clear(); txtDireccion.Clear();
            txtTelefono.Clear(); txtEmail.Clear(); cmbAreaTecnica.SelectedIndex = -1;
        }

        private void Cargar_Estudiantes(string cTexto)
        {
         
            dgv_estudiantes.DataSource = N_Estudiante.Listar_Estudiantes(cTexto);
            this.Formato_dgv();
        }



        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            nOpcion = 1;
            this.Estado_Texto(true);
            this.Estado_Botones(false); 
            this.Limpiar_Texto();
            txtNombre.Focus();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {


            if (nIdEstudiante == 0)
            {
                MessageBox.Show("Primero selecciona a alguien en la tabla");
            }
            else
            {
                nOpcion = 2; 
                this.Estado_Texto(true); 
                this.Estado_Botones(false); 
                txtNombre.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Texto(false);
            this.Estado_Botones(true); 
            this.Limpiar_Texto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (txtNombre.Text == "" || cmbAreaTecnica.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos", "Aviso");
                return;
            }

            E_Estudiante oEst = new E_Estudiante();
            oEst.id_Estudiante = nIdEstudiante;

            oEst.Nombre = txtNombre.Text;
            oEst.Apellidos = txtApellidos.Text;
            oEst.Direccion = txtDireccion.Text;
            oEst.Telefono = txtTelefono.Text;
            oEst.Email = txtEmail.Text; 
            oEst.Id_Area_Tecnica = Convert.ToInt32(cmbAreaTecnica.SelectedValue);

            string Rpta = N_Estudiante.Guardar_Estudiante(nOpcion, oEst);

            if (Rpta == "OK")
            {
                this.Cargar_Estudiantes("%");
                this.Estado_Texto(false);
                this.Estado_Botones(true);
                this.Limpiar_Texto();
                MessageBox.Show("¡Listo! Datos modificados.");
            }

            else
            {
                MessageBox.Show("Error: " + Rpta);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nIdEstudiante == 0) MessageBox.Show("Seleccione un registro");
            else
            {
                N_Estudiante.Eliminar_Estudiante(nIdEstudiante);
                this.Cargar_Estudiantes("%");
                MessageBox.Show("Eliminado");
            }
        }

        private void dgv_estudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nIdEstudiante = Convert.ToInt32(dgv_estudiantes.CurrentRow.Cells["idEstudiante"].Value);
            txtNombre.Text = dgv_estudiantes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgv_estudiantes.CurrentRow.Cells["Apellidos"].Value.ToString();
            txtDireccion.Text = dgv_estudiantes.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgv_estudiantes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtEmail.Text = dgv_estudiantes.CurrentRow.Cells["Email"].Value.ToString();
           
            cmbAreaTecnica.SelectedValue = dgv_estudiantes.CurrentRow.Cells["IdAreaTecnica"].Value;

           
            nIdEstudiante = Convert.ToInt32(dgv_estudiantes.CurrentRow.Cells["idEstudiante"].Value);
          
         
            nIdEstudiante = Convert.ToInt32(dgv_estudiantes.CurrentRow.Cells["idEstudiante"].Value);



        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Cargar_Estudiantes(txtBuscar.Text);
            this.Cargar_Estudiantes(txtBuscar.Text.Trim());
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
       
            this.Cargar_Estudiantes("%");
            this.Llenar_Combo_Areas();
            this.Cargar_Estudiantes("%");
            this.Formato_dgv();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Desea salir del sistema?", "Confirmar",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Opcion == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cargar_Estudiantes(txtBuscar.Text.Trim());
        }

        private void cmbAreaTecnica_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Llenar_Combo_Areas()
        {
            cmbAreaTecnica.DataSource = N_AreaTecnica.Listado_Areas();
            cmbAreaTecnica.ValueMember = "Id_Area_Tecnica";
            cmbAreaTecnica.DisplayMember = "Area_Tecnica";
        }


        private void Formato_dgv()
        {
            
            dgv_estudiantes.Columns["Nombre"].HeaderText = "NOMBRE";
            dgv_estudiantes.Columns["Apellidos"].HeaderText = "APELLIDOS";
            dgv_estudiantes.Columns["AreaTecnica"].HeaderText = "ÁREA TÉCNICA";
            dgv_estudiantes.Columns["Telefono"].HeaderText = "TELÉFONO";

            dgv_estudiantes.ReadOnly = true;
            dgv_estudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_estudiantes.AllowUserToAddRows = false; 

      
            dgv_estudiantes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan; 
            dgv_estudiantes.EnableHeadersVisualStyles = false;
            dgv_estudiantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 15, 73); 
            dgv_estudiantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_estudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


      
            if (dgv_estudiantes.Columns.Count > 0)
            {
               
                if (dgv_estudiantes.Columns.Contains("idEstudiante")) dgv_estudiantes.Columns["idEstudiante"].Visible = true;
                if (dgv_estudiantes.Columns.Contains("IdAreaTecnica")) dgv_estudiantes.Columns["IdAreaTecnica"].Visible = false;
                if (dgv_estudiantes.Columns.Contains("Estado")) dgv_estudiantes.Columns["Estado"].Visible = false;

            
                if (dgv_estudiantes.Columns.Contains("Nombre")) dgv_estudiantes.Columns["Nombre"].HeaderText = "NOMBRE";
                if (dgv_estudiantes.Columns.Contains("Apellidos")) dgv_estudiantes.Columns["Apellidos"].HeaderText = "APELLIDOS";
                if (dgv_estudiantes.Columns.Contains("Area_Tecnica")) dgv_estudiantes.Columns["Area_Tecnica"].HeaderText = "ÁREA TÉCNICA";

        
                dgv_estudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_estudiantes.ReadOnly = true;
                dgv_estudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_estudiantes.AllowUserToAddRows = false;
            }



        }



        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            jnGestionEscolar.FmrEstudiante_Reporte reporte = new jnGestionEscolar.FmrEstudiante_Reporte();

           
            reporte.ShowDialog();
        }

        private void BtnProfesores_Click_1(object sender, EventArgs e)
        {
            frmConsultaProfesor ventana = new frmConsultaProfesor();
            ventana.ShowDialog();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            FrmAsignacion ventana = new FrmAsignacion();
            ventana.ShowDialog();
        }
    }
    }
   
    
    

