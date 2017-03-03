using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasU2.BO
{
    class Ejercicio21BO
    {
        private string claveUsuario;
        private int intentos;
        private bool interruptor;

        public string ClaveUsuario
        {
            get
            {
                return claveUsuario;
            }

            set
            {
                claveUsuario = value;
            }
        }

        public void Ingresar(Form frm)
        {
            if (claveUsuario == "Csharp")
            {
                MessageBox.Show("bien");
                frm.Hide();
            }
            else
            {
                intentos++;
                MessageBox.Show("MAL");
                if (intentos >= 3)
                {
                    MessageBox.Show("Sin intentos");
                    frm.Hide();
                }
            }
        }

    }
}
