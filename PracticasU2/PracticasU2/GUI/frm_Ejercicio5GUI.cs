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
    public partial class frm_Ejercicio5GUI : Form
    {
        public frm_Ejercicio5GUI()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            lst_LibroCompra.Items.Add(lst_Libros.SelectedItem);
            lst_Libros.Items.Remove(lst_Libros.SelectedItem);
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            lst_Libros.Items.Add(lst_LibroCompra.SelectedItem);
            lst_LibroCompra.Items.Remove(lst_LibroCompra.SelectedItem);
        }
    }
}
