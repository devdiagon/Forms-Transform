using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFigurasTranslate.figure_classes;

namespace TareaFigurasTranslate.figure_views
{
    public partial class FrmRombo : Form
    {
        private Rombo ObjRombo = new Rombo();
        private static FrmRombo instance;

        public static FrmRombo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRombo();
            }
            return instance;
        }
        private FrmRombo()
        {
            InitializeComponent();
            ObjRombo.InitializeData(txtInputA, txtInputB, txtPerimeter, txtArea, trbScale, picCanvas);

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRombo.ReadData(txtInputA, txtInputB);
            ObjRombo.ShowData(txtPerimeter, txtArea);
            ObjRombo.DrawFigure(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRombo.InitializeData(txtInputA, txtInputB, txtPerimeter, txtArea, trbScale, picCanvas);

            lblScaleValue.Text = "0.00";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            ObjRombo.CloseForm(this);
        }
        private void scaleScroll(object sender, EventArgs e)
        {
            float escala = (trbScale.Value);

            if (escala <= 0)
            {
                escala = 1;
            }

            lblScaleValue.Text = $"{escala:0.00}";
            ObjRombo.ScaleFigure(picCanvas, escala);
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            ObjRombo.RotateLeft(picCanvas);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            ObjRombo.RotateRight(picCanvas);
        }

        private void pic_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Indica que las teclas deben tratarse como de entrada (no navegación)
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }

            float desplazamiento = 10f;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    ObjRombo.Desplazar(0, -desplazamiento);
                    break;
                case Keys.Down:
                    ObjRombo.Desplazar(0, desplazamiento);
                    break;
                case Keys.Left:
                    ObjRombo.Desplazar(-desplazamiento, 0);
                    break;
                case Keys.Right:
                    ObjRombo.Desplazar(desplazamiento, 0);
                    break;
            }
            ObjRombo.DrawFigure(picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            picCanvas.Focus();
        }
    }
}
