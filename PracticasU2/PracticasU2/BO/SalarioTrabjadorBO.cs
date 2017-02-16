using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasU2.BO
{
    class SalarioTrabjadorBO
    {
        private double salarioMensual;
        private double incentivo;
        private double porcentaje;
        private double bonificacion;
        private double salarioNeto;

        public double SalarioMensual
        {
            get
            {
                return salarioMensual;
            }

            set
            {
                salarioMensual = value;
            }
        }

        public double Incentivo
        {
            get
            {
                return incentivo;
            }

            set
            {
                incentivo = value;
            }
        }

        public double Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }

        public double CalcularSalarioNeto()
        {
            bonificacion = (salarioMensual * porcentaje) / 100;
            salarioMensual = salarioMensual + incentivo + bonificacion;
            return salarioMensual;
        }

    }
}
