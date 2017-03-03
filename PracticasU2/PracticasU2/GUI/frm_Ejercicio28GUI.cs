using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticasU2.Properties;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio28GUI : Form
    {
        public frm_Ejercicio28GUI()
        {
            InitializeComponent();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirForms(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio1GUI E1 = new frm_Ejercicio1GUI();
            AbrirForms(E1);

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio2GUI E2 = new frm_Ejercicio2GUI();
            AbrirForms(E2);
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio3GUI E3 = new frm_Ejercicio3GUI();
            AbrirForms(E3);
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio3GUI E4 = new frm_Ejercicio3GUI();
            AbrirForms(E4);
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio5GUI E5 = new frm_Ejercicio5GUI();
            AbrirForms(E5);
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio6GUI E6 = new frm_Ejercicio6GUI();
            AbrirForms(E6);
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio7GUI E7 = new frm_Ejercicio7GUI();
            AbrirForms(E7);
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio8GUI E8 = new frm_Ejercicio8GUI();
            AbrirForms(E8);
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio9GUI E9 = new frm_Ejercicio9GUI();
            AbrirForms(E9);
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio10GUI E10 = new frm_Ejercicio10GUI();
            AbrirForms(E10);
        }

        private void ejercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio11GUI E11 = new frm_Ejercicio11GUI();
            AbrirForms(E11);
        }

        private void ejercicio14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio12GUI E12 = new frm_Ejercicio12GUI();
            AbrirForms(E12);
        }

        private void ejercico16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio16GUI E16 = new frm_Ejercicio16GUI();
            AbrirForms(E16);
        }

        private void ejercicio18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio18GUI E18 = new frm_Ejercicio18GUI();
            AbrirForms(E18);
        }

        private void ejercicio19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio19GUI E19 = new frm_Ejercicio19GUI();
            AbrirForms(E19);
        }

        private void ejercicio21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ejercicio21GUI E21 = new frm_Ejercicio21GUI();
            AbrirForms(E21);
        }
    }
}
