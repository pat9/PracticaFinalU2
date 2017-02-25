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
    public partial class frm_Ejercicio4GUI : Form
    {
        Ejercicio4BO objE4 = new Ejercicio4BO();
        public frm_Ejercicio4GUI()
        {
            InitializeComponent();
            txt_Num1.Text = "0";
            txt_Num2.Text = "0";
        }

        public void AsignarNumeros()
        {
            objE4.Num1 = double.Parse(txt_Num1.Text);
            objE4.Num2 = double.Parse(txt_Num2.Text);
        }

        private void rbt_Suma_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_Suma.Checked == true)
            {
                AsignarNumeros();
                txt_Resultado.Text =  objE4.Sumar().ToString();
            }

        }

        private void rbt_Resta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Resta.Checked == true)
            {
                AsignarNumeros();
                txt_Resultado.Text = objE4.Resta().ToString();
            }
        }

        private void rbt_Multipliacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Multipliacion.Checked == true)
            {
                AsignarNumeros();
                txt_Resultado.Text = objE4.Multiplicacion().ToString();
            }
        }

        private void rbt_Division_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Division.Checked == true)
            {
                AsignarNumeros();
                txt_Resultado.Text = objE4.Division().ToString();
            }
        }
    }
}
