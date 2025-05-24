using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFigurasTranslate.figure_classes
{
    internal class Romboide
    {
        //Variables de la figura
        private float ladoBase;
        private float ladoOblicuo;
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

        public Romboide()
        {
            ResetDataValues();
        }

        private void ResetDataValues()
        {
            altura = 0; ladoBase = 0; ladoOblicuo = 0;
            perimetro = 0; area = 0;
            escala = 1; angulo = 0;
            figure = null;
            graphics = null;
            posicion = new PointF(0, 0);
        }

        private void CalculatePerimeter()
        {
            perimetro = 2 * ladoBase + 2 * ladoOblicuo;
        }

        private void CalculateArea()
        {
            area = ladoBase * altura;
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
            figure = Figura.CrearRomboide(ladoBase, altura);
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

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputHeight)
        {
            try
            {
                ladoBase = float.Parse(txtInputA.Text);
                ladoOblicuo = float.Parse(txtInputB.Text);
                altura = float.Parse(txtInputHeight.Text);

                if (ladoBase < 0 || ladoOblicuo < 0 ||  altura < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    ladoBase = 0; ladoOblicuo = 0; altura = 0;
                    return;
                }

                if (ladoBase == ladoOblicuo)
                {
                    MessageBox.Show("Un romboide tiene sus lados (a) y (b) diferentes", "mensaje de error");
                    ladoBase = 0; ladoOblicuo = 0; altura = 0;
                    return;
                }

                if (ladoOblicuo <= altura)
                {
                    MessageBox.Show("El lado oblicuo (b) debe ser mayor que la altura", "mensaje de error");
                    ladoBase = 0; ladoOblicuo = 0; altura = 0;
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
            TextBox txtInputHeight,
            TextBox txtPerimeter, TextBox txtArea,
            TrackBar trbScale, PictureBox picCanvas)
        {
            ResetDataValues();

            txtInputA.Text = ""; txtInputB.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtInputHeight.Text = "";
            trbScale.Value = 1;

            picCanvas.Image = null;

            txtInputA.Focus();
        }
    }
}
