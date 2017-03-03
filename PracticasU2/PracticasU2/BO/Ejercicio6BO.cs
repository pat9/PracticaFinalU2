using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PracticasU2.Properties;
using System.IO;
using System.Windows.Forms;

namespace PracticasU2.BO
{
    class Ejercicio6BO
    {
        private int numeroJuego = 1;
        private int dado1;
        private int dado2;
        private int total;
        private Image DadoImg;

        public int NumeroJuego
        {
            get
            {
                return numeroJuego;
            }

            set
            {
                numeroJuego = value;
            }
        }

        public int Dado1
        {
            get
            {
                return dado1;
            }

            set
            {
                dado1 = value;
            }
        }

        public int Dado2
        {
            get
            {
                return dado2;
            }

            set
            {
                dado2 = value;
            }
        }

        public int Total
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

        public void TirarDados()
        {
            Random rdn = new Random();
            dado1 = rdn.Next(1, 6);
            dado2 = rdn.Next(1, 6);
            total = dado1 + dado2;
        }
        
        public Image MostrarDado1()
        {
            DadoImg = (Bitmap)(Resources.ResourceManager.GetObject("Dado" + dado1));
            return DadoImg;
        }

        public Image MostrarDado2()
        {
            DadoImg = (Bitmap)(Resources.ResourceManager.GetObject("Dado" + dado2));
            return DadoImg;
        }


    }
}
