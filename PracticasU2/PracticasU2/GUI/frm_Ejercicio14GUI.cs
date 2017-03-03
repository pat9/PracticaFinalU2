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
    public partial class frm_Ejercicio14GUI : Form
    {
        Ejercicio14BO objE14 = new Ejercicio14BO();
        public frm_Ejercicio14GUI()
        {
            InitializeComponent();
        }

        private void frm_Ejercicio14GUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_ApeMat.Clear();
            txt_ApePat.Clear();
            txt_Direccion.Clear();
            txt_mail.Clear();
            txt_Matricula.Clear();
            txt_Movil.Clear();
            txt_Nombres.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            objE14.ApeMat = txt_ApeMat.Text;
            objE14.ApePat = txt_ApePat.Text;
            objE14.Barrio = txt_Barrio.Text;
            objE14.Direccion = txt_Direccion.Text;
            objE14.Email = txt_mail.Text;
            objE14.Informacion = rtb_Info.Text;
            objE14.Matricula = int.Parse(txt_Matricula.Text);
            objE14.Nacimiento = DateTime.Parse(dtp_FechaNac.Text);
            objE14.Nombres = txt_Nombres.Text;
            if(rbt_Hombre.Checked)
            {
                objE14.Sexo = true;
            }
            else if(rbt_Mujer.Checked)
            {
                objE14.Sexo = false;
            }
            objE14.TelefonoFijo = txt_Fijo.Text;
            objE14.TelefonoMovil = txt_Movil.Text;

            dgt_Alumnos.Rows.Add(objE14.Matricula, objE14.Nombres, objE14.ApePat,
                                 objE14.ApeMat, objE14.Nacimiento, objE14.Direccion,
                                 objE14.Sexo, objE14.Barrio, objE14.TelefonoMovil, 
                                 objE14.TelefonoFijo, txt_mail.Text, objE14.Informacion);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            dgt_Alumnos.Rows.RemoveAt(dgt_Alumnos.CurrentRow.Index);
        }
    }
}
