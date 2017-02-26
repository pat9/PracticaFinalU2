using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio8GUI : Form
    {
        Random rdn = new Random();
        int turno; 
        public frm_Ejercicio8GUI()
        {
            InitializeComponent();
            turno = rdn.Next(1, 2);
        }

        private void PonerBoton(Button btn)
        {
            if (turno == 1)
            {
                btn.ForeColor = Color.Blue;
                btn.Text = "X";
                turno = 2;
            }
            else
            {
                btn.ForeColor = Color.Red;
                btn.Text = "O";
                turno = 1;
            }
        }


        private void btn_Turno_Click(object sender, EventArgs e)
        {
            
            if (turno == 1)
            {
                btn_Turno.ForeColor = Color.Blue;
                btn_Turno.Text = "X";
            }
            else
            {
                btn_Turno.ForeColor = Color.Red;
                btn_Turno.Text = "O";
            }
        }

        private void btn_P1_Click(object sender, EventArgs e)
        {
            PonerBoton(btn_P1);
        }

       
        private void btn_P2_Click(object sender, EventArgs e)
        {
            PonerBoton(btn_P2);
        }
    }
}
