using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraficosDeFunciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                Expresiones.Evaluador ie = new Expresiones.Evaluador(txtExpresion.Text);
                double resul = ie.Evaluar(double.Parse(txtX.Text));
                MessageBox.Show(resul.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cmdDibujar_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                double xMin = double.Parse(txtXMin.Text);
                double xMax = double.Parse(txtXMax.Text);
                double yMin = double.Parse(txtYMin.Text);
                double yMax = double.Parse(txtYMax.Text);

                Expresiones.Evaluador ie = new Expresiones.Evaluador(txtExpresion.Text);

                int iMax = pictureBox1.ClientRectangle.Width;
                int jMax = pictureBox1.ClientRectangle.Height;
                List<Point> puntos = new List<Point>();
                for (int i = 0; i < iMax; i++)
                {
                    double x = ((xMax - xMin) / iMax) * i + xMin;
                    double y;
                    try
                    {
                        y = ie.Evaluar(x);
                        int j = Convert.ToInt32((0 - jMax) / (yMax - yMin) * (y - yMin) + jMax);
                        puntos.Add(new Point(i, j));
                    }
                    catch (Exception)
                    {
                    }
                }
                e.Graphics.DrawLines(Pens.Red, puntos.ToArray());
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
