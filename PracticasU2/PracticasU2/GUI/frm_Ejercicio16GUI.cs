using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticasU2.BO;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio16GUI : Form
    {
        Ejercicio16BO E16 = new Ejercicio16BO();
        public frm_Ejercicio16GUI()
        {
            InitializeComponent();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            E16.MoverSeleccion(this);
        }
    }
}
