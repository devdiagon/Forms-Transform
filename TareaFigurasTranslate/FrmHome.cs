using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFigurasTranslate.figure_views;

namespace TareaFigurasTranslate
{
    public partial class FrmHome : Form
    {
        private FrmRombo frmRombo;
        public FrmHome()
        {
            InitializeComponent();
            frmRombo = FrmRombo.GetInstance();
            placeForm(frmRombo);
        }

        private void placeForm(Form formulario)
        {
            pnlWrapper.Controls.Clear();                       // Quita los formulario del panel
            formulario.TopLevel = false;                       // Evita que el fomrulario se abra como ventana independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita botones de minimizar, maximizar, cerrar y ajuste
            formulario.Dock = DockStyle.Fill;                  // El formulario se expande en el panel
            pnlWrapper.Controls.Add(formulario);               // Muestra el formulario en el panel
            formulario.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = FrmRombo.GetInstance();
            placeForm(frmRombo);
        }
    }
}
