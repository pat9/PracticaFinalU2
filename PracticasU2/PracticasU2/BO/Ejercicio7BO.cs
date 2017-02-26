using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PracticasU2.Properties;

namespace PracticasU2.BO
{
    class Ejercicio7BO
    {
        private string codigoArt;
        private string nombreArt;
        private double precioArt;
        private int cantidadArt;
        private Image imagenArt;

        public string CodigoArt
        {
            get
            {
                return codigoArt;
            }

            set
            {
                codigoArt = value;
            }
        }

        public string NombreArt
        {
            get
            {
                return nombreArt;
            }

            set
            {
                nombreArt = value;
            }
        }

        public double PrecioArt
        {
            get
            {
                return precioArt;
            }

            set
            {
                precioArt = value;
            }
        }

        public int CantidadArt
        {
            get
            {
                return cantidadArt;
            }

            set
            {
                cantidadArt = value;
            }
        }

        public Image AsignarImagen()
        {
            imagenArt = (Bitmap)Resources.ResourceManager.GetObject(codigoArt);
            return imagenArt;
        }

        public void BuscarArticulo()
        {
            switch (codigoArt)
            {
                case "A001":
                    AsignarValores("PC-Dell", 7000, 50);
                    break;
                case "A002":
                    AsignarValores("Oreo", 10, 52);
                    break;
                case "A003":
                    AsignarValores("Lapiz", 5, 12);
                    break;
                case "A004":
                    AsignarValores("Mouse", 100, 82);
                    break;
                case "A005":
                    AsignarValores("Teclado", 150, 70);
                    break;
                case "A006":
                    AsignarValores("Mochila", 350, 87);
                    break;
                case "A007":
                    AsignarValores("Lego", 450, 70);
                    break;
                case "A008":
                    AsignarValores("Vaso", 10, 12);
                    break;
                case "A009":
                    AsignarValores("Coca-Cola", 12, 80);
                    break;
                case "A010":
                    AsignarValores("Libro", 150, 75);
                    break;
            }
        }

        private void AsignarValores(string nombre, double precio, int cant)
        {
            nombreArt = nombre;
            precioArt = precio;
            cantidadArt = cant;
        }

    }
}
