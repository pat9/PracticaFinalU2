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
    public partial class frm_Ejercicio2GUI : Form
    {
        Ejercicio2BO ObjetoE2 = new Ejercicio2BO();
        public frm_Ejercicio2GUI()
        {
            InitializeComponent();
        }

        private void grb_Libros_Enter(object sender, EventArgs e)
        {

        }

        private void chk_Libro1_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheck(chk_Libro1, 250);
        }

        private void chk_Libro2_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheck(chk_Libro2, 150);
        }


        private void chk_Libro3_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheck(chk_Libro3, 300);
        }

        private void chk_Libro4_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheck(chk_Libro4, 150);
        }

        private void chk_Libro5_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCheck(chk_Libro5, 160);
        }

        private void VerificarCheck(CheckBox chk, double ValorLibro)
        {
            if (chk.Checked == true)
            {
                ObjetoE2.CalcularNumeroLibros(1);
                ObjetoE2.CalcularTotal(ValorLibro);
            }
            else
            {
                ObjetoE2.CalcularNumeroLibros(-1);
                ObjetoE2.CalcularTotal(-ValorLibro);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            txt_NumLib.Text = ObjetoE2.NumeroLibros + " Libros";
            txt_Total.Text = ObjetoE2.Total.ToString();
        }
    }
}
