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
    public partial class frm_Ejercicio18GUI : Form
    {
        Ejercicio18BO E18 = new Ejercicio18BO();
        public frm_Ejercicio18GUI()
        {
            InitializeComponent();
        }

        private void lbl_Jovenes_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            E18.NumEmp = int.Parse(txt_Numero.Text);
            E18.ContarEmpleados();
            txt_Jovenes.Text = E18.NumJov.ToString();
            txt_Maduros.Text = E18.NumMad.ToString();
            txt_Mayores.Text = E18.NumMay.ToString();
        }
    }
}
