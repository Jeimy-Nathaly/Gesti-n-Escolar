using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{


    public partial class FrmReporte_Materia : Form
    {

        private string _nombreEstudiante;
        private DataTable _materias;

        
        private readonly Color COLOR_PRINCIPAL = Color.FromArgb(28, 35, 49);
        private readonly Color COLOR_DORADO = Color.FromArgb(184, 134, 11);
        private readonly Color COLOR_TEXTO_SUAVE = Color.FromArgb(80, 80, 80);
        private readonly Color COLOR_FONDO_HOJA = Color.White;

        public FrmReporte_Materia(string nombre, DataTable materias)
        {
            this._nombreEstudiante = nombre;
            this._materias = materias;
            ConfigurarVentana();
        }

        private void ConfigurarVentana()
        {
            this.Size = new Size(850, 900);
            this.Text = "Comprobante Oficial de Matriculación";
            this.BackColor = Color.FromArgb(45, 45, 50);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle hojaRect = new Rectangle(50, 40, 750, 800);
            g.FillRectangle(new SolidBrush(COLOR_FONDO_HOJA), hojaRect);

            
            g.DrawRectangle(new Pen(Color.FromArgb(200, 200, 200), 1), hojaRect);
            g.DrawRectangle(new Pen(COLOR_DORADO, 2), 65, 55, 720, 770);

            Rectangle headerRect = new Rectangle(65, 55, 720, 100);
            g.FillRectangle(new SolidBrush(COLOR_PRINCIPAL), headerRect);

            using (Font fUni = new Font("Segoe UI Semibold", 18))
            using (Font fDept = new Font("Segoe UI", 10, FontStyle.Regular))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("SISTEMA DE GESTIÓN ACADÉMICA", fUni, Brushes.White, new Rectangle(65, 80, 720, 40), sf);
                g.DrawString("REGISTRO OFICIAL DE MATRICULACIÓN", fDept, new SolidBrush(COLOR_DORADO), new Rectangle(65, 113, 720, 30), sf);
            }


            int infoY = 220;
            using (Font fTitle = new Font("Segoe UI", 10, FontStyle.Bold))
            using (Font fVal = new Font("Segoe UI", 22, FontStyle.Regular))
            {
                g.DrawString("ESTUDIANTE MATRICULADO:", fTitle, new SolidBrush(COLOR_TEXTO_SUAVE), 100, infoY);
                g.DrawString(_nombreEstudiante.ToUpper(), fVal, new SolidBrush(COLOR_PRINCIPAL), 97, infoY + 25);
                g.DrawLine(new Pen(COLOR_DORADO, 3), 100, infoY + 75, 500, infoY + 75);
            }

           
            int tableY = 360;
            Rectangle tableHead = new Rectangle(100, tableY, 650, 40);
            g.FillRectangle(new SolidBrush(COLOR_PRINCIPAL), tableHead);

            using (Font fH = new Font("Segoe UI", 11, FontStyle.Bold))
            {
                g.DrawString("MATERIA / CURSO", fH, Brushes.White, 120, tableY + 10);
                g.DrawString("DOCENTE RESPONSABLE", fH, Brushes.White, 430, tableY + 10);
            }

            tableY += 40;
            using (Font fR = new Font("Segoe UI", 10))
            {
                int i = 0;
                foreach (DataRow row in _materias.Rows)
                {
                    if (i % 2 == 0) g.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 248)), 100, tableY, 650, 35);

                    string mat = row[0].ToString();
                    string prof = _materias.Columns.Count > 1 ? row[1].ToString() : "Asignación Pendiente";

                    g.DrawString(mat, fR, Brushes.Black, 120, tableY + 8);
                    g.DrawString(prof, fR, new SolidBrush(Color.DimGray), 430, tableY + 8);

                    g.DrawLine(new Pen(Color.FromArgb(230, 230, 230)), 100, tableY + 35, 750, tableY + 35);
                    tableY += 35;
                    i++;
                }
            }

           
            int stampX = 580;
            int stampY = 650;
            DibujarSelloOficial(g, stampX, stampY);

           
            using (Font fF = new Font("Segoe UI", 8))
            {
                string legal = "Este documento es un comprobante oficial de registro académico.";
                g.DrawString(legal, fF, new SolidBrush(COLOR_TEXTO_SUAVE), 100, 780);
                g.DrawString("Fecha de emisión: " + DateTime.Now.ToLongDateString(), fF, Brushes.Gray, 100, 795);
            }
        }

        private void DibujarSelloOficial(Graphics g, int x, int y)
        {
            Rectangle rectSello = new Rectangle(x, y, 120, 120);

            g.DrawEllipse(new Pen(COLOR_DORADO, 3), rectSello);
            g.DrawEllipse(new Pen(COLOR_DORADO, 1), x + 5, y + 5, 110, 110);

           
            g.FillEllipse(new SolidBrush(Color.FromArgb(15, COLOR_DORADO)), rectSello);

          
            using (Font fSelloBold = new Font("Arial", 9, FontStyle.Bold))
            using (Font fSelloSmall = new Font("Arial", 7, FontStyle.Bold))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

            
                g.DrawString("VALIDADO", fSelloSmall, new SolidBrush(COLOR_DORADO), new Rectangle(x, y + 30, 120, 20), sf);
                g.DrawString("MATRÍCULA", fSelloBold, new SolidBrush(COLOR_DORADO), new Rectangle(x, y + 45, 120, 30), sf);
                g.DrawString(DateTime.Now.Year.ToString(), fSelloBold, new SolidBrush(COLOR_DORADO), new Rectangle(x, y + 70, 120, 20), sf);
            }
        }
    }
}