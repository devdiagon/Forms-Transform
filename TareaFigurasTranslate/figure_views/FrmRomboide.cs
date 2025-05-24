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
    public partial class FrmRomboide : Form
    {
        private Romboide ObjRomboide = new Romboide();
        private static FrmRomboide instance;

        public static FrmRomboide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRomboide();
            }
            return instance;
        }
        public FrmRomboide()
        {
            InitializeComponent();
            ObjRomboide.InitializeData(txtInputA, txtInputB,txtInputHeight, txtPerimeter, txtArea, trbScale, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRomboide.ReadData(txtInputA, txtInputB, txtInputHeight);
            ObjRomboide.ShowData(txtPerimeter, txtArea);
            ObjRomboide.DrawFigure(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtInputA, txtInputB, txtInputHeight, txtPerimeter, txtArea, trbScale, picCanvas);

            lblScaleValue.Text = "0.00";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            ObjRomboide.CloseForm(this);
        }
        private void scaleScroll(object sender, EventArgs e)
        {
            float escala = (trbScale.Value);

            if (escala <= 0)
            {
                escala = 1;
            }

            lblScaleValue.Text = $"{escala:0.00}";
            ObjRomboide.ScaleFigure(picCanvas, escala);
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            ObjRomboide.RotateLeft(picCanvas);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            ObjRomboide.RotateRight(picCanvas);
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
                    ObjRomboide.Desplazar(0, -desplazamiento);
                    break;
                case Keys.Down:
                    ObjRomboide.Desplazar(0, desplazamiento);
                    break;
                case Keys.Left:
                    ObjRomboide.Desplazar(-desplazamiento, 0);
                    break;
                case Keys.Right:
                    ObjRomboide.Desplazar(desplazamiento, 0);
                    break;
            }
            ObjRomboide.DrawFigure(picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            picCanvas.Focus();
        }
    }
}
