using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasU2.BO
{
    class Ejercicio3BO
    {
        private double x;
        private double y;
        private double z;
        private double resultado;

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public double Calcular()
        {
            resultado = Math.Sqrt( (3 * Math.Pow(x, 4)) + (2 * x * Math.Pow(y,2)*z) + (5 * Math.Pow(x, 2)* y)) / 3 + (Math.Pow(x,2) * Math.Pow(y, 2) * Math.Pow(z,2)) ;
            return resultado;
        }
    }
}
