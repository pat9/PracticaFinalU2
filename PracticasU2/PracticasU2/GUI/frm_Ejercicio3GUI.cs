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
    public partial class frm_Ejercicio3GUI : Form
    {
        Ejercicio3BO objE3 = new Ejercicio3BO();
        public frm_Ejercicio3GUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            objE3.X = double.Parse(txt_X.Text);
            objE3.Y = double.Parse(txt_Y.Text);
            objE3.Z = double.Parse(txt_Z.Text);

            txt_Resultado.Text = objE3.Calcular().ToString();
        }
    }
}
