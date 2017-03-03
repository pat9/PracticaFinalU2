using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticasU2.GUI;

namespace PracticasU2.BO
{
    class Ejercicio19BO
    {
        frm_DatosGUI dato = new frm_DatosGUI();
        private string multi;

        public string Multi
        {
            get
            {
                return multi;
            }

            set
            {
                multi = value;
            }
        }

        public void Multiplos()
        {
            for(int count= 1; count<=10; count++)
            {
                dato.ShowDialog();
                if(dato.numero % 7 == 0)
                {
                    multi = multi + ", " + dato.numero;
                }
            }
        }
    }
}
