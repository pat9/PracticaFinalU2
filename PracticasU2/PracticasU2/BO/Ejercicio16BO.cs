using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticasU2.GUI;

namespace PracticasU2.BO
{
    class Ejercicio16BO
    {
        
        public void MoverSeleccion(frm_Ejercicio16GUI frm16)
        {
            foreach (var itemSelect in frm16.clt_Lista1.CheckedItems)
            {
                frm16.lst_Lista2.Items.Add(itemSelect.ToString());
            }
        }
    }
}
