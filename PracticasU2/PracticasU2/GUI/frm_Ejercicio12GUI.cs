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
    public partial class frm_Ejercicio12GUI : Form
    {
        public frm_Ejercicio12GUI()
        {
            InitializeComponent();
        }

        private void btn_Transformar_Click(object sender, EventArgs e)
        {
            string b = txt_Cantidad.Text;
            for(int c = txt_Cantidad.TextLength-1; c>=0; c--)
            {
               string a = txt_Cantidad.Text.Substring(c,1);
                MessageBox.Show(c.ToString(a));
            }
        }
    }
}
