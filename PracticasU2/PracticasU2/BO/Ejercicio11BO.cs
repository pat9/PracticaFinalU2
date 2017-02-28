using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasU2.BO
{
    class Ejercicio11BO
    {
        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        string tiempo;

        public int Segundos
        {
            get
            {
                return segundos;
            }

            set
            {
                segundos = value;
            }
        }

        public int Minutos
        {
            get
            {
                return minutos;
            }

            set
            {
                minutos = value;
            }
        }

        public int Horas
        {
            get
            {
                return horas;
            }

            set
            {
                horas = value;
            }
        }

        public string Tiempo
        {
            get
            {
                return tiempo;
            }

            set
            {
                tiempo = value;
            }
        }

        public string ActualizarTiempo()
        {
            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }
            if (minutos == 60)
            {
                horas++;
                minutos = 0;
            }
            tiempo = horas + ":" + minutos + ":" + segundos;
            return tiempo;
        }

    }
}
