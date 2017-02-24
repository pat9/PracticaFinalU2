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
    public partial class frm_SalarioTrabajadorGUI : Form
    {
        SalarioTrabjadorBO Trabajador = new SalarioTrabjadorBO();
        public frm_SalarioTrabajadorGUI()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Trabajador.SalarioMensual = double.Parse(txt_SueldoMensual.Text);
            Trabajador.Incentivo = double.Parse(txt_Incentivo.Text);

            if (rbt_10.Checked == true)
            {
                Trabajador.Porcentaje = 10;
            }
            else if (rbt_20.Checked == true)
            {
               Trabajador.Porcentaje = 20;
            }
            else
            {
                Trabajador.Porcentaje = 50;
            }

            txt_SueldoNeto.Text = Trabajador.CalcularSalarioNeto().ToString();

        }
    }
}
