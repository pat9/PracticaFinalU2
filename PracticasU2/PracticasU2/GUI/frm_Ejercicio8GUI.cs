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
    public partial class frm_Ejercicio8GUI : Form
    {
        Ejercicio8BO objE8 = new Ejercicio8BO();
        public frm_Ejercicio8GUI()
        {
            InitializeComponent();
        }
 
        private void btn_Turno_Click(object sender, EventArgs e)
        {
        }

        private void btn_P1_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P1);
            objE8.Verificar(this);
        }


        private void btn_P2_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P2);
            objE8.Verificar(this);

        }

        private void frm_Ejercicio8GUI_Load(object sender, EventArgs e)
        {
            objE8.BtnActual = btn_Turno;
        }

        private void btn_P3_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P3);
            objE8.Verificar(this);
        }

        private void btn_P4_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P4);
            objE8.Verificar(this);
        }

        private void btn_P5_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P5);
            objE8.Verificar(this);
        }

        private void btn_P6_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P6);
            objE8.Verificar(this);
        }

        private void btn_P7_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P7);
            objE8.Verificar(this);
        }

        private void btn_P8_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P8);
            objE8.Verificar(this);
        }

        private void btn_P9_Click(object sender, EventArgs e)
        {
            objE8.CambiarBoton(btn_P9);
            objE8.Verificar(this);
        }

        private void lbl_PuntosJ1_Click(object sender, EventArgs e)
        {

        }

        private void grb_Juego_EnabledChanged(object sender, EventArgs e)
        {
            lbl_PuntosJ1.Text = objE8.GanadosJ1.ToString();
            lbl_PuntosJ2.Text = objE8.GanadosJ2.ToString();
            if(!grb_Juego.Enabled && MessageBox.Show("¿Jugar otra vez?", "Gato", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                objE8.ReiniciarJuego(this);
                grb_Juego.Enabled = true;
            }
        }
    }
}
