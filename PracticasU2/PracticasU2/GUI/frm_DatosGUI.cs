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
    public partial class frm_DatosGUI : Form
    {
        public double numero;
        public frm_DatosGUI()
        {
            InitializeComponent();
        }

        private void frm_DatosGUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            numero = double.Parse(txt_Numero.Text);
            txt_Numero.Clear();
            txt_Numero.Focus();
            this.Hide();
        }
    }
}
