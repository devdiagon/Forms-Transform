using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFigurasTranslate.figure_classes
{
    internal class Rombo
    {
        //Variables de la figura
        private float lado;
        private float diagMayor;
        private float diagMenor;
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

        public Rombo()
        {
            ResetDataValues();
        }

        private void ResetDataValues()
        {
            lado = 0; diagMayor = 0; diagMenor = 0;
            perimetro = 0; area = 0;
            escala = 1; angulo = 0;
            figure = null;
            graphics = null;
            posicion = new PointF(0, 0);
        }

        private void ComputeSide()
        {
            lado = (float)Math.Sqrt(Math.Pow(diagMayor, 2) + Math.Pow(diagMenor, 2)) / 2;
        }

        private void CalculatePerimeter()
        {
            perimetro = 4 * lado;
        }

        private void CalculateArea()
        {
            area = diagMayor * diagMenor / 2;
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
            figure = Figura.CrearRombo(diagMayor,diagMenor);
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

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                diagMayor = float.Parse(txtInputA.Text);
                diagMenor = float.Parse(txtInputB.Text);

                if (diagMayor < 0 || diagMenor < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    diagMayor = 0; diagMenor = 0; lado = 0;
                    return;
                }

                if (diagMayor == diagMenor)
                {
                    MessageBox.Show("Un rombo debe tener diagonales diferentes", "mensaje de error");
                    diagMayor = 0; diagMenor = 0; lado = 0;
                    return;
                }

                ComputeSide();
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
            TextBox txtPerimeter, TextBox txtArea,
            TrackBar trbScale, PictureBox picCanvas)
        {
            ResetDataValues();

            txtInputA.Text = ""; txtInputB.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            trbScale.Value = 1;

            picCanvas.Image = null;

            txtInputA.Focus();
        }
    }
}
