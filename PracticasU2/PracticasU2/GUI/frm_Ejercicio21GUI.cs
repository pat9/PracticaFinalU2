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
    public partial class frm_Ejercicio21GUI : Form
    {
        Ejercicio21BO e21 = new Ejercicio21BO();
        public frm_Ejercicio21GUI()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            e21.ClaveUsuario = txt_Clave.Text;
            e21.Ingresar(this);
        }
    }
}
