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
    public partial class frm_Ejercicio7GUI : Form
    {
        Ejercicio7BO objE7 = new Ejercicio7BO();
        public frm_Ejercicio7GUI()
        {
            InitializeComponent();
        }

        private void lst_Articulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            objE7.CodigoArt = lst_Articulos.Text;
            objE7.BuscarArticulo();
            txt_CantArt.Text = objE7.CantidadArt.ToString();
            txt_CodArt.Text = objE7.CodigoArt;
            txt_NombreArt.Text = objE7.NombreArt;
            txt_PrecioArt.Text = objE7.PrecioArt.ToString();
            pic_Imagen.Image = objE7.AsignarImagen();
            pic_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
