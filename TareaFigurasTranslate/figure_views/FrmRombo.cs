using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFigurasTranslate.figure_views
{
    public partial class FrmRombo : Form
    {
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
        }
    }
}
