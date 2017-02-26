using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PracticasU2.Properties;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio10GUI : Form
    {
        public frm_Ejercicio10GUI()
        {
            InitializeComponent();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer(Resources.DO_C_);
            a.Play();

        }

        private void frm_Ejercicio10GUI_Load(object sender, EventArgs e)
        {

        }

        private void frm_Ejercicio10GUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == Keys.A.ToString())
            {
                SoundPlayer a = new SoundPlayer(Resources.DO_C_);
                a.Play();
            }
        }

        private void frm_Ejercicio10GUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Keys.A.ToString())
            {
                SoundPlayer a = new SoundPlayer(Resources.DO_C_);
                a.Play();
            }
        }
    }
}
