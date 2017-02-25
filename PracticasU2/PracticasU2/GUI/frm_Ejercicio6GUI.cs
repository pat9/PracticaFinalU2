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
    public partial class frm_Ejercicio6GUI : Form
    {
        Ejercicio6BO objE6 = new Ejercicio6BO();
        public frm_Ejercicio6GUI()
        {
            InitializeComponent();
        }

        private void dgt_Juegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_LanzarDatos_Click(object sender, EventArgs e)
        {
            objE6.TirarDados();
            pic_Dado1.Image = objE6.MostrarDado1();
            pic_Dado2.Image = objE6.MostrarDado2();
            dgt_Juegos.Rows.Add(objE6.NumeroJuego++, objE6.Dado1, objE6.Dado2, objE6.Total);
        }
    }
}
