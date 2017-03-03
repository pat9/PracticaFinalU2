using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticasU2.GUI;

namespace PracticasU2.BO
{
    class Ejercicio18BO
    {
        frm_DatosGUI dato = new frm_DatosGUI();

        private int numEmp;
        private int numJov;
        private int numMad;
        private int numMay;

        public int NumEmp
        {
            get
            {
                return numEmp;
            }

            set
            {
                numEmp = value;
            }
        }

        public int NumJov
        {
            get
            {
                return numJov;
            }

            set
            {
                numJov = value;
            }
        }

        public int NumMad
        {
            get
            {
                return numMad;
            }

            set
            {
                numMad = value;
            }
        }

        public int NumMay
        {
            get
            {
                return numMay;
            }

            set
            {
                numMay = value;
            }
        }

        public void ContarEmpleados()
        {
            int cont = 1; 
            while(cont <= numEmp)
            {
                dato.ShowDialog();
                if (dato.numero >=  18 && dato.numero <= 65 && dato.numero >= 0)
                {
                    if(dato.numero <22)
                    {
                        numJov++;
                    }
                    else if(dato.numero >=22 && dato.numero <=50)
                    {
                        numMad++;
                    }
                    else if(dato.numero>50)
                    {
                        numMay++;
                    }
                    cont++;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("La edad no es valida intente de nuevo");
                }
                
            }
        }
    }
}
