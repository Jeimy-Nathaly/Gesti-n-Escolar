namespace CapaPresentacion
{
    partial class frmEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAreaTecnica = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbAreaTecnica = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnProfesores = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 146);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(196, 28);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(137, 201);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(196, 28);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 261);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(196, 28);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(651, 146);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(196, 28);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(651, 211);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(196, 28);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(116, 412);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(715, 28);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgv_estudiantes
            // 
            this.dgv_estudiantes.AllowUserToAddRows = false;
            this.dgv_estudiantes.AllowUserToDeleteRows = false;
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiantes.Location = new System.Drawing.Point(23, 446);
            this.dgv_estudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.ReadOnly = true;
            this.dgv_estudiantes.RowHeadersWidth = 51;
            this.dgv_estudiantes.RowTemplate.Height = 24;
            this.dgv_estudiantes.Size = new System.Drawing.Size(872, 312);
            this.dgv_estudiantes.TabIndex = 14;
            this.dgv_estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 154);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(26, 209);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(109, 20);
            this.lblApellidos.TabIndex = 16;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 269);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(109, 20);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(494, 149);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(99, 20);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(494, 209);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 121);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Unispace", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(255, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gestión de Estudiantes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnMateria);
            this.panel2.Controls.Add(this.BtnProfesores);
            this.panel2.Controls.Add(this.BtnReporte);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Location = new System.Drawing.Point(928, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 767);
            this.panel2.TabIndex = 21;
            // 
            // lblAreaTecnica
            // 
            this.lblAreaTecnica.AutoSize = true;
            this.lblAreaTecnica.Location = new System.Drawing.Point(494, 269);
            this.lblAreaTecnica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaTecnica.Name = "lblAreaTecnica";
            this.lblAreaTecnica.Size = new System.Drawing.Size(139, 20);
            this.lblAreaTecnica.TabIndex = 22;
            this.lblAreaTecnica.Text = "Area Tecnica:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(29, 419);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblBuscar.TabIndex = 23;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnBuscar.Location = new System.Drawing.Point(842, 407);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbAreaTecnica
            // 
            this.cmbAreaTecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaTecnica.FormattingEnabled = true;
            this.cmbAreaTecnica.Items.AddRange(new object[] {
            "Informática",
            "Contabilidad",
            "Electricidad",
            "Enfermería",
            "Gastronomia"});
            this.cmbAreaTecnica.Location = new System.Drawing.Point(651, 269);
            this.cmbAreaTecnica.Name = "cmbAreaTecnica";
            this.cmbAreaTecnica.Size = new System.Drawing.Size(199, 28);
            this.cmbAreaTecnica.TabIndex = 26;
            this.cmbAreaTecnica.SelectedIndexChanged += new System.EventHandler(this.cmbAreaTecnica_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.buscar1;
            this.pictureBox3.Location = new System.Drawing.Point(852, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.BtnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesores.ForeColor = System.Drawing.Color.White;
            this.BtnProfesores.Image = global::CapaPresentacion.Properties.Resources.School_Director;
            this.BtnProfesores.Location = new System.Drawing.Point(18, 446);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(264, 60);
            this.BtnProfesores.TabIndex = 32;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnProfesores.UseVisualStyleBackColor = false;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click_1);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Image = global::CapaPresentacion.Properties.Resources.Upload;
            this.BtnReporte.Location = new System.Drawing.Point(18, 373);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(263, 57);
            this.BtnReporte.TabIndex = 30;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.pantalla1;
            this.pictureBox2.Location = new System.Drawing.Point(103, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.New_File;
            this.btnNuevo.Location = new System.Drawing.Point(16, 154);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(265, 64);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::CapaPresentacion.Properties.Resources.UPDATE;
            this.btnActualizar.Location = new System.Drawing.Point(16, 235);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(265, 54);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.Trash;
            this.btnEliminar.Location = new System.Drawing.Point(16, 304);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(265, 53);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.Emergency_Exit;
            this.btnSalir.Location = new System.Drawing.Point(20, 670);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(263, 64);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.empleados;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.Close;
            this.btnCancelar.Location = new System.Drawing.Point(330, 328);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(224, 57);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.Upload;
            this.btnGuardar.Location = new System.Drawing.Point(91, 328);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 57);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(152)))));
            this.btnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateria.ForeColor = System.Drawing.Color.White;
            this.btnMateria.Image = global::CapaPresentacion.Properties.Resources.Upload;
            this.btnMateria.Location = new System.Drawing.Point(21, 522);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(263, 60);
            this.btnMateria.TabIndex = 33;
            this.btnMateria.Text = "Asignacion";
            this.btnMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMateria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMateria.UseVisualStyleBackColor = false;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 778);
            this.Controls.Add(this.cmbAreaTecnica);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblAreaTecnica);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgv_estudiantes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstudiante";
            this.Text = "frmEstudiante";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAreaTecnica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbAreaTecnica;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnProfesores;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMateria;
    }
}
