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
using PracticasU2.BO;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio10GUI : Form
    {
        Ejercicio10BO Piano = new Ejercicio10BO();
        public frm_Ejercicio10GUI()
        {
            InitializeComponent();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            PresionarTecla("DO", btn_C, "C");
        }

        private void frm_Ejercicio10GUI_Load(object sender, EventArgs e)
        {

        }

        private void PresionarTecla(string Nota, Button btn, string label)
        {
            Piano.ReproducirSonido(Nota);
            btn.Select();
            lbl_Nota.Text = label;
        }

        private void frm_Ejercicio10GUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                PresionarTecla("DO", btn_C, "C");
            }
            else if (e.KeyCode == Keys.W)
            {
                PresionarTecla("DOS", btn_CS, "C#"); 
            }
            else if (e.KeyCode == Keys.S)
            {
                PresionarTecla("RE", btn_D, "D");
            }
            else if (e.KeyCode == Keys.E)
            {
                PresionarTecla("RES", btn_DS, "D#");
            }
            else if (e.KeyCode == Keys.D)
            {
                PresionarTecla("MI", btn_E, "E");
            }
            else if (e.KeyCode == Keys.F)
            {
                PresionarTecla("FA", btn_F, "F");
            }
            else if (e.KeyCode == Keys.T)
            {
                PresionarTecla("FAS", btn_FS, "F#");
            }
            else if (e.KeyCode == Keys.G)
            {
                PresionarTecla("SOL", btn_G, "G");
            }
            else if (e.KeyCode == Keys.Y)
            {
                PresionarTecla("SOLS", btn_GS, "G#");
            }
            else if(e.KeyCode == Keys.H)
            {
                PresionarTecla("LA", btn_A, "A");
            }
            else if(e.KeyCode == Keys.U)
            {
               PresionarTecla("SIS", btn_BbS, "Bb#");
            }
            else if(e.KeyCode == Keys.J)
            {
                PresionarTecla("SI", btn_B, "B");
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            PresionarTecla("RE", btn_D, "D");
        }

        private void btn_DS_Click(object sender, EventArgs e)
        {
            PresionarTecla("RES", btn_DS, "D#");
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            PresionarTecla("MI", btn_E, "E");
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            PresionarTecla("FA", btn_F, "F");
        }

        private void btn_FS_Click(object sender, EventArgs e)
        {
            PresionarTecla("FAS", btn_FS, "F#");
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            PresionarTecla("SOL", btn_G, "G");
        }

        private void btn_GS_Click(object sender, EventArgs e)
        {
            PresionarTecla("SOLS", btn_GS, "G#");
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            PresionarTecla("LA", btn_A, "A");
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            PresionarTecla("SIS", btn_BbS, "Bb#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PresionarTecla("SIS", btn_BbS, "Bb#");
        }

        private void btn_CS_Click(object sender, EventArgs e)
        {
            PresionarTecla("DOS", btn_CS, "C#");
        }
    }
}
