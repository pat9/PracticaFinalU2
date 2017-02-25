using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasU2.BO
{
    class Ejercicio4BO
    {
        private double num1;
        private double num2;
        private double resultado;

        public double Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }

        public double Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public double Sumar()
        {
            resultado = num1 + num2;
            return resultado;
        }

        public double Resta()
        {
            resultado = num1 - num2;
            return resultado;
        }

        public double Multiplicacion()
        {
            resultado = num1 * num2;
            return resultado;
        }

        public double Division()
        {
            resultado = num1 / num2;
            return resultado;
        }

    }
}
