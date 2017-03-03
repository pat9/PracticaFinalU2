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
    public partial class frm_Ejercicio19GUI : Form
    {
        Ejercicio19BO e19 = new Ejercicio19BO();
        public frm_Ejercicio19GUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            e19.Multiplos();
            txt_Multiplos.Text = e19.Multi;
        }
    }
}
