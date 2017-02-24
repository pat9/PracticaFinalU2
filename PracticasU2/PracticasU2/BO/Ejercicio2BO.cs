using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasU2.BO
{
    class Ejercicio2BO
    {
        private int numeroLibros;
        private double total;

        public int NumeroLibros
        {
            get
            {
                return numeroLibros;
            }

            set
            {
                numeroLibros = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public void CalcularNumeroLibros(int valor)
        {
            NumeroLibros = NumeroLibros + valor;
        }

        public void CalcularTotal(double valor)
        {
            Total = Total + valor;
        }

    }
}
