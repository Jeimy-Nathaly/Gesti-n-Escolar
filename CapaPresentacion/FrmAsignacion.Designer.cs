namespace CapaPresentacion
{
    partial class FrmAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacion));
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAreaTecnica = new System.Windows.Forms.ComboBox();
            this.lblAreaTecnica = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstMateriasAgregadas = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.AutoCompleteCustomSource.AddRange(new string[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Items.AddRange(new object[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbEstudiante.Location = new System.Drawing.Point(167, 180);
            this.cmbEstudiante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(208, 23);
            this.cmbEstudiante.TabIndex = 67;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(424, 316);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(207, 68);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(907, 808);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(22, 12);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 248);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 21);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "Profesor:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(420, 247);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(98, 21);
            this.lblMateria.TabIndex = 65;
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.AutoCompleteCustomSource.AddRange(new string[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbMateria.Location = new System.Drawing.Point(585, 252);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(208, 23);
            this.cmbMateria.TabIndex = 64;
            // 
            // cmbAreaTecnica
            // 
            this.cmbAreaTecnica.AutoCompleteCustomSource.AddRange(new string[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbAreaTecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaTecnica.FormattingEnabled = true;
            this.cmbAreaTecnica.Items.AddRange(new object[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbAreaTecnica.Location = new System.Drawing.Point(585, 188);
            this.cmbAreaTecnica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAreaTecnica.Name = "cmbAreaTecnica";
            this.cmbAreaTecnica.Size = new System.Drawing.Size(208, 23);
            this.cmbAreaTecnica.TabIndex = 60;
            // 
            // lblAreaTecnica
            // 
            this.lblAreaTecnica.AutoSize = true;
            this.lblAreaTecnica.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTecnica.Location = new System.Drawing.Point(420, 184);
            this.lblAreaTecnica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaTecnica.Name = "lblAreaTecnica";
            this.lblAreaTecnica.Size = new System.Drawing.Size(153, 21);
            this.lblAreaTecnica.TabIndex = 59;
            this.lblAreaTecnica.Text = "Area Tecnica:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.BtnLimpiar);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Location = new System.Drawing.Point(937, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 816);
            this.panel2.TabIndex = 58;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(24, 555);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(271, 66);
            this.btnReporte.TabIndex = 55;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(24, 471);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(271, 66);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(24, 381);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(271, 66);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(24, 200);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(271, 66);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(24, 294);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(271, 66);
            this.BtnLimpiar.TabIndex = 36;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(30, 725);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(271, 64);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-28, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 114);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Unispace", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(401, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 48);
            this.label8.TabIndex = 0;
            this.label8.Text = "Matriculacion";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(18, 184);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(142, 21);
            this.lblEstudiante.TabIndex = 56;
            this.lblEstudiante.Text = "Estudiantes:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 438);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(785, 387);
            this.dgvDatos.TabIndex = 55;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.AutoCompleteCustomSource.AddRange(new string[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Items.AddRange(new object[] {
            "Administración",
            "Administración Pública",
            "Aduanas",
            "Aeronáutica",
            "Agricultura",
            "Agronegocios",
            "Animación",
            "Antropología",
            "Apoyo Emocional",
            "Apoyo Técnico",
            "Aprendizaje Temprano",
            "Arqueología",
            "Arquitectura",
            "Arte",
            "Artes",
            "Artes Escénicas",
            "Artes Marciales",
            "Atención al Cliente",
            "Aviación",
            "Biodiversidad",
            "Biología",
            "Biología Marina",
            "Calidad",
            "Ciencia",
            "Ciencias",
            "Climatología",
            "Cocina",
            "Comercio Exterior",
            "Comunicación",
            "Construcción",
            "Contabilidad",
            "Control de Calidad",
            "Creatividad",
            "Criminología",
            "Cuidado Ambiental",
            "Cultura",
            "Defensa",
            "Defensa Personal",
            "Deportes",
            "Derecho",
            "Desarrollo Infantil",
            "Desarrollo Personal",
            "Desarrollo Rural",
            "Diplomacia",
            "Disciplina",
            "Diseño de Imagen",
            "Diseño de Modas",
            "Diseño Gráfico",
            "Diseño Interior",
            "Ecología",
            "Educación",
            "Educación Física",
            "Educación Inicial",
            "Electricidad",
            "Electricidad Industrial",
            "Electrónica",
            "Emprendimiento",
            "Energía",
            "Enfermería",
            "Entrenamiento",
            "Espectáculo",
            "Espectáculos",
            "Estimulación Infantil",
            "Estimulación Temprana",
            "Estrategia",
            "Exploración",
            "Farmacia",
            "Filosofía",
            "Finanzas",
            "Física",
            "Fuerza Industrial",
            "Gastronomía",
            "Geología",
            "Gestión",
            "Gestión Ambiental",
            "Gestión Artística",
            "Gestión Comunitaria",
            "Gestión Costera",
            "Gestión del Tiempo",
            "Gestión Emocional",
            "Gestión Empresarial",
            "Gestión Hídrica",
            "Guía Turística",
            "Historia",
            "Hotelería",
            "Imagen Personal",
            "Informática",
            "Ingeniería",
            "Ingeniería Mecánica",
            "Inteligencia",
            "Inventiva",
            "Investigación",
            "Justicia Social",
            "Liderazgo",
            "Logística",
            "Mantenimiento",
            "Marketing",
            "Marketing Digital",
            "Mecánica",
            "Mercadeo",
            "Mineralogía",
            "Moda",
            "Motivación",
            "Música",
            "Natación",
            "Navegación",
            "Negocios",
            "Nutrición",
            "Orientación",
            "Procesos Industriales",
            "Programación",
            "Protección Animal",
            "Psicología",
            "Química",
            "Reciclaje",
            "Recreación",
            "Recursos Hídricos",
            "Recursos Humanos",
            "Redes",
            "Relaciones Humanas",
            "Relaciones Internacionales",
            "Relaciones Públicas",
            "Robótica",
            "Salud",
            "Seguridad",
            "Seguridad Industrial",
            "Seguridad Informática",
            "Sociología",
            "Soporte Técnico",
            "Suerte",
            "Supervivencia",
            "Tecnología",
            "Trabajo Social",
            "Transporte",
            "Turismo",
            "Ventas",
            "Veterinaria",
            "Vigilancia"});
            this.cmbProfesor.Location = new System.Drawing.Point(167, 248);
            this.cmbProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(208, 23);
            this.cmbProfesor.TabIndex = 69;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(20, 398);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblBuscar.TabIndex = 71;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(119, 398);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(690, 23);
            this.txtBuscar.TabIndex = 70;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(157, 316);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(207, 68);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstMateriasAgregadas
            // 
            this.lstMateriasAgregadas.FormattingEnabled = true;
            this.lstMateriasAgregadas.ItemHeight = 15;
            this.lstMateriasAgregadas.Location = new System.Drawing.Point(886, 806);
            this.lstMateriasAgregadas.Name = "lstMateriasAgregadas";
            this.lstMateriasAgregadas.Size = new System.Drawing.Size(14, 19);
            this.lstMateriasAgregadas.TabIndex = 73;
            this.lstMateriasAgregadas.SelectedIndexChanged += new System.EventHandler(this.lstMateriasAgregadas_SelectedIndexChanged);
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 832);
            this.Controls.Add(this.lstMateriasAgregadas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbAreaTecnica);
            this.Controls.Add(this.lblAreaTecnica);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.dgvDatos);
            this.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAsignacion";
            this.Text = "FrmAsignacion";
            this.Load += new System.EventHandler(this.FrmAsignacion_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbAreaTecnica;
        private System.Windows.Forms.Label lblAreaTecnica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstMateriasAgregadas;
    }
}