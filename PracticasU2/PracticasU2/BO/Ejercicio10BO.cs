using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticasU2.Properties;
using System.IO;
using System.Media;

namespace PracticasU2.BO
{
    class Ejercicio10BO
    {
        public void ReproducirSonido(string nota)
        {
            SoundPlayer sonido = new SoundPlayer((Stream)Resources.ResourceManager.GetObject(nota));
            sonido.Play();
        }
    }
}
