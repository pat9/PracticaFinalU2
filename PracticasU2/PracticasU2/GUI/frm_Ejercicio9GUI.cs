using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticasU2.BO;

namespace PracticasU2.GUI
{
    public partial class frm_Ejercicio9GUI : Form
    {
        Ejercicio9BO Carta = new Ejercicio9BO();

        public frm_Ejercicio9GUI()
        {
            InitializeComponent();
        }

        private void frm_Ejercicio9GUI_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void pic_Op1_Click(object sender, EventArgs e)
        {
            pic_Seleccion.Image = pic_Op1.Image;
            DesactivarOpciones();
            OpcionPC();
            Ganador(Carta.CompararCartas(Carta.NCarta1));
        }


        private void pic_Op2_Click(object sender, EventArgs e)
        {
            pic_Seleccion.Image = pic_Op2.Image;
            DesactivarOpciones();
            OpcionPC();
            Ganador(Carta.CompararCartas(Carta.NCarta2));
        }


        private void pic_Op3_Click(object sender, EventArgs e)
        {
            pic_Seleccion.Image = pic_Op3.Image;
            DesactivarOpciones();
            OpcionPC();
            Ganador(Carta.CompararCartas(Carta.NCarta3));
        }

        private void pic_Op4_Click(object sender, EventArgs e)
        {
            pic_Seleccion.Image = pic_Op4.Image;
            DesactivarOpciones();
            OpcionPC();
            Ganador(Carta.CompararCartas(Carta.NCarta4));
        }

        private void pic_Op5_Click(object sender, EventArgs e)
        {
            pic_Seleccion.Image = pic_Op5.Image;
            DesactivarOpciones();
            OpcionPC();
            Ganador(Carta.CompararCartas(Carta.NCarta5));
        }

        private void IniciarJuego()
        {
            Carta.EscojerCarta();

            Carta.AsignarImagenes();

            pic_Op1.Image = Carta.ImgCarta1;
            pic_Op2.Image = Carta.ImgCarta2;
            pic_Op3.Image = Carta.ImgCarta3;
            pic_Op4.Image = Carta.ImgCarta4;
            pic_Op5.Image = Carta.ImgCarta5;
        }

        private void DesactivarOpciones()
        {
            pic_Op1.Enabled = false;
            pic_Op2.Enabled = false;
            pic_Op3.Enabled = false;
            pic_Op4.Enabled = false;
            pic_Op5.Enabled = false;
        }

        private void ActivarOpciones()
        {
            pic_Op1.Enabled = true;
            pic_Op2.Enabled = true;
            pic_Op3.Enabled = true;
            pic_Op4.Enabled = true;
            pic_Op5.Enabled = true;
        }

        private void  OpcionPC()
        {
            Carta.ElegirMaquina();
            pic_PC.Image = Carta.ImgCartaPC;
        }

        private void Ganador(int resultado)
        {
            if( resultado == 1)
            {
                MessageBox.Show("Gana el usuario");
            }
            else if(resultado == 0)
            {
                MessageBox.Show("Gana la PC");
            }
            else
            {
                MessageBox.Show("Empate");
            }

            lbl_PuntosJ1.Text = Carta.GanadosJ1.ToString();
            lbl_PuntosJ2.Text = Carta.GanadosJ2.ToString();

            if(MessageBox.Show("¿Jugar otra vez?", "Cartas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IniciarJuego();
                ActivarOpciones();
            }
        }
    }
}
