using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PracticasU2.Properties;

namespace PracticasU2.BO
{
    class CartaBO
    {
        Random rdn = new Random();
        private int ganadosJ1, ganadosJ2;
        private int nCarta1, nCarta2, nCarta3, nCarta4, nCarta5, nCartaPC;
        private string carta1, carta2, carta3, carta4, carta5 , CartaPC;
        private Image imgCarta1, imgCarta2, imgCarta3, imgCarta4, imgCarta5, imgCartaPC;

        public Image ImgCarta1
        {
            get
            {
                return imgCarta1;
            }

            set
            {
                imgCarta1 = value;
            }
        }

        public Image ImgCarta2
        {
            get
            {
                return imgCarta2;
            }

            set
            {
                imgCarta2 = value;
            }
        }

        public Image ImgCarta3
        {
            get
            {
                return imgCarta3;
            }

            set
            {
                imgCarta3 = value;
            }
        }

        public Image ImgCarta4
        {
            get
            {
                return imgCarta4;
            }

            set
            {
                imgCarta4 = value;
            }
        }

        public Image ImgCarta5
        {
            get
            {
                return imgCarta5;
            }

            set
            {
                imgCarta5 = value;
            }
        }

        public int NCarta1
        {
            get
            {
                return nCarta1;
            }

            set
            {
                nCarta1 = value;
            }
        }

        public int NCarta2
        {
            get
            {
                return nCarta2;
            }

            set
            {
                nCarta2 = value;
            }
        }

        public int NCarta3
        {
            get
            {
                return nCarta3;
            }

            set
            {
                nCarta3 = value;
            }
        }

        public int NCarta4
        {
            get
            {
                return nCarta4;
            }

            set
            {
                nCarta4 = value;
            }
        }

        public int NCarta5
        {
            get
            {
                return nCarta5;
            }

            set
            {
                nCarta5 = value;
            }
        }

        public int NCartaPC
        {
            get
            {
                return nCartaPC;
            }

            set
            {
                nCartaPC = value;
            }
        }

        public Image ImgCartaPC
        {
            get
            {
                return imgCartaPC;
            }

            set
            {
                imgCartaPC = value;
            }
        }

        public int GanadosJ1
        {
            get
            {
                return ganadosJ1;
            }

            set
            {
                ganadosJ1 = value;
            }
        }

        public int GanadosJ2
        {
            get
            {
                return ganadosJ2;
            }

            set
            {
                ganadosJ2 = value;
            }
        }

        public void EscojerCarta()
        {
            /*
             * El numero de carta va del 1 al 13
             * 1 = as,  11 = J, 12 = Q, 13 = K
             * 
             * Tipo 1 = Corazon, 2 = Dimanates, 3 = Trebol, 4= Picas
             *  
             */

            nCarta1 = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));
            nCarta2 = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));
            nCarta3 = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));
            nCarta4 = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));
            nCarta5 = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));

            carta1 = "_" + nCarta1 + "_" + rdn.Next(1, 4);
            carta2 = "_" + nCarta2 + "_" + rdn.Next(1, 4);
            carta3 = "_" + nCarta3 + "_" + rdn.Next(1, 4);
            carta4 = "_" + nCarta4 + "_" + rdn.Next(1, 4);
            carta5 = "_" + nCarta5 + "_" + rdn.Next(1, 4);


        }

        public void AsignarImagenes()
        {
            ImgCarta1 = (Bitmap)Resources.ResourceManager.GetObject(carta1);
            ImgCarta2 = (Bitmap)Resources.ResourceManager.GetObject(carta2);
            ImgCarta3 = (Bitmap)Resources.ResourceManager.GetObject(carta3);
            ImgCarta4 = (Bitmap)Resources.ResourceManager.GetObject(carta4);
            ImgCarta5 = (Bitmap)Resources.ResourceManager.GetObject(carta5);
        }

        public void ElegirMaquina()
        {
            nCartaPC = rdn.Next(rdn.Next(1, 6), rdn.Next(7, 13));
            CartaPC = "_" + nCartaPC + "_" + rdn.Next(1, 4);
            imgCartaPC = (Bitmap)Resources.ResourceManager.GetObject(CartaPC);
        }

        public int CompararCartas(int opUsuario)
        {
            if(opUsuario > nCartaPC)
            {
                GanadosJ1++;
                return 1;
            }
            else if(nCartaPC > opUsuario)
            {
                GanadosJ2++;
                return 0;
            }
            else
            {
                return 2;
            }
        }


    }
}
