using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFigurasTranslate.figure_classes
{
    internal class Trapecio
    {
        //Variables de la figura
        private float baseMayor;
        private float baseMenor;
        private float lado;
        private float altura;
        private float perimetro;
        private float area;

        //Variables de transformación
        private float escala;
        private float angulo;
        private PointF posicion = new PointF(0, 0);

        //Variables para graficar
        private Pen pen = new Pen(Color.Black, 2);
        private Graphics graphics;
        private Figura figure;

        public Trapecio()
        {
            ResetDataValues();
        }

        private void ResetDataValues()
        {
            lado = 0; baseMayor = 0; baseMenor = 0;
            perimetro = 0; area = 0; altura = 0;
            escala = 1; angulo = 0;
            figure = null;
            graphics = null;
            posicion = new PointF(0, 0);
        }

        private void CalculatePerimeter()
        {
            perimetro = 2 * lado + baseMayor + baseMenor;
        }

        private void CalculateArea()
        {
            area = (baseMayor + baseMenor) * altura / 2;
        }

        private void CalculateHeight()
        {
            float baseDif = baseMayor - baseMenor;
            float numerator = (float)(Math.Pow(baseDif, 2));
            float frac = numerator / (2 * baseDif);
            altura = (float)Math.Sqrt(Math.Pow(lado, 2) - Math.Pow(frac, 2));
        }

        public void ShowData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimetro.ToString();
            txtArea.Text = area.ToString();
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

        public void RotateRight(PictureBox picCanvas)
        {
            angulo += 5;
            DrawFigure(picCanvas);
        }

        public void RotateLeft(PictureBox picCanvas)
        {
            angulo -= 5;
            DrawFigure(picCanvas);
        }

        public void ScaleFigure(PictureBox picCanvas, float scaleAmount)
        {
            escala = 1;
            escala *= scaleAmount;
            DrawFigure(picCanvas);
        }

        public void Desplazar(float desplazamientoX, float desplazamientoY)
        {
            posicion.X += desplazamientoX;
            posicion.Y += desplazamientoY;
        }

        private void DefineFigure()
        {
            figure = Figura.CrearTrapecioIsoceles(baseMayor, baseMenor, altura);
        }

        public void DrawFigure(PictureBox picCanvas)
        {
            if (figure == null) return;

            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Ubicar el centro de la figura en la pantalla
            //Se parte del centro de la pantalla y se aplican los
            // desplazamientos en X y en Y
            PointF center = new PointF(picCanvas.Width / 2f + posicion.X, picCanvas.Height / 2f + posicion.Y);

            double angleRad = (float)(angulo * Math.PI / 180);

            // Aplicar transformaciones y guardarlas en un Array
            PointF[] forma = figure.Vertices.Select(punto => {
                // Escalar
                float x = punto.X * escala;
                float y = punto.Y * escala;

                // Rotar
                float xr = (float)(x * Math.Cos(angleRad) - y * Math.Sin(angleRad));
                float yr = (float)(x * Math.Sin(angleRad) + y * Math.Cos(angleRad));

                // Trasladar el origen (centro de la figura) a la posición
                // correcta en la pantalla
                return new PointF(xr + center.X, yr + center.Y);
            }).ToArray();

            // Dibujar líneas
            for (int i = 0; i < forma.Length; i++)
            {
                graphics.DrawLine(pen, forma[i], forma[(i + 1) % forma.Length]);
            }

            picCanvas.Image = bmp;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSide)
        {
            try
            {
                baseMayor = float.Parse(txtInputA.Text);
                baseMenor = float.Parse(txtInputB.Text);
                lado = float.Parse(txtInputSide.Text);

                if (baseMayor < 0 || baseMenor < 0 || lado < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    baseMayor = 0; baseMenor = 0; lado = 0; altura = 0;
                    return;
                }

                if (baseMayor <= baseMenor)
                {
                    MessageBox.Show("La base (B) debe ser mayor a la base (b)", "mensaje de error");
                    baseMayor = 0; baseMenor = 0; lado = 0; altura = 0;
                    return;
                }

                CalculateHeight();

                if (float.IsNaN(altura) || float.IsInfinity(altura))
                {
                    MessageBox.Show("Ingreso de lados no válidos", "mensaje de error");
                    baseMayor = 0; baseMenor = 0; lado = 0; altura = 0;
                    return;
                }

                CalculateArea();
                CalculatePerimeter();
                DefineFigure();
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void InitializeData(
            TextBox txtInputA, TextBox txtInputB,
            TextBox txtInputSide,
            TextBox txtPerimeter, TextBox txtArea,
            TrackBar trbScale, PictureBox picCanvas)
        {
            ResetDataValues();

            txtInputA.Text = ""; txtInputB.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtInputSide.Text = "";
            trbScale.Value = 1;

            picCanvas.Image = null;

            txtInputA.Focus();
        }
    }
}
