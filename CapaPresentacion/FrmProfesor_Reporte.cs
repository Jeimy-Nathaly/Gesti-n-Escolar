using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jnGestionEscolar
{

  
    public partial class FrmProfesor_Reporte : Form
    {
        private ComboBox cbEstudiante;
        private ComboBox cbProfesor;
        private ComboBox cbMateria;
        private Button btnGenerar;

        // Constructor que recibe la data para el reporte
        public FrmProfesor_Reporte(DataTable datos, string estudiante, string area)
        {
            // Configuración del Formulario (Ventana)
            this.Text = "Reporte Oficial de Carga Académica - Visualización Directa";
            this.Size = new Size(850, 900);
            this.BackColor = Color.FromArgb(60, 63, 65); // Fondo gris oscuro para resaltar la "hoja"
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Panel que simula la hoja A4
            Panel hojaBlanca = new Panel
            {
                Size = new Size(740, 800),
                BackColor = Color.White,
                Location = new Point(45, 30),
                Padding = new Padding(50)
            };

            // --- DISEÑO DEL ENCABEZADO ---

            Label lblInstitucion = new Label
            {
                Text = "UNIVERSIDAD TECNOLÓGICA NACIONAL\nDEPARTAMENTO DE CONTROL ACADÉMICO",
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                ForeColor = Color.MidnightBlue,
                Location = new Point(50, 40),
                Size = new Size(640, 50),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblSubtitulo = new Label
            {
                Text = "REPORTE DE ASIGNACIÓN DE CÁTEDRA - CICLO 2024",
                Font = new Font("Arial", 10, FontStyle.Underline),
                Location = new Point(50, 100),
                Size = new Size(640, 25),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // --- TABLA DE DATOS (MATERIA Y PROFESOR) ---

            DataGridView dgvDatos = new DataGridView
            {
                Location = new Point(50, 160),
                Size = new Size(640, 400),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                GridColor = Color.LightGray,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Estilo de celdas y cabeceras
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvDatos.RowTemplate.Height = 35;

            // Columnas solicitadas
            dgvDatos.Columns.Add("materia", "ASIGNATURA / MATERIA");
            dgvDatos.Columns.Add("profesor", "PROFESOR TITULAR");

            // Datos realistas simulando una base de datos
            dgvDatos.Rows.Add("CÁLCULO DIFERENCIAL E INTEGRAL", "DR. ROBERTO HERNÁNDEZ ZAVALA");
            dgvDatos.Rows.Add("SISTEMAS OPERATIVOS I", "ING. MARÍA EUGENIA LÓPEZ");
            dgvDatos.Rows.Add("BASES DE DATOS AVANZADAS", "MTRO. CARLOS RUIZ ESPARZA");
            dgvDatos.Rows.Add("INTELIGENCIA ARTIFICIAL", "DRA. ELENA PÉREZ MONTERO");
            dgvDatos.Rows.Add("REDES DE COMPUTADORA II", "ING. RICARDO SÁNCHEZ SOLÍS");
            dgvDatos.Rows.Add("PROGRAMACIÓN ORIENTADA A OBJETOS", "MTRA. CLAUDIA JIMÉNEZ");
            dgvDatos.Rows.Add("ÉTICA PROFESIONAL", "LIC. FERNANDO VALLE");

            // Ajuste de altura dinámica
            dgvDatos.Height = dgvDatos.ColumnHeadersHeight + (dgvDatos.RowTemplate.Height * dgvDatos.Rows.Count) + 3;

            // --- PIE DE PÁGINA Y VALIDACIÓN ---

            Label lblFecha = new Label
            {
                Text = "Fecha de emisión: " + DateTime.Now.ToString("f"),
                Font = new Font("Arial", 8, FontStyle.Italic),
                Location = new Point(50, 680),
                Size = new Size(640, 20)
            };

            Panel lineaFirma = new Panel
            {
                BackColor = Color.Black,
                Size = new Size(250, 1),
                Location = new Point(245, 740)
            };

            Label lblFirma = new Label
            {
                Text = "FIRMA Y SELLO DE REGISTRO",
                Font = new Font("Arial", 8, FontStyle.Bold),
                Location = new Point(245, 745),
                Size = new Size(250, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Ensamblaje del reporte
            hojaBlanca.Controls.Add(lblInstitucion);
            hojaBlanca.Controls.Add(lblSubtitulo);
            hojaBlanca.Controls.Add(dgvDatos);
            hojaBlanca.Controls.Add(lblFecha);
            hojaBlanca.Controls.Add(lineaFirma);
            hojaBlanca.Controls.Add(lblFirma);

            this.Controls.Add(hojaBlanca);
        }
    }
}


