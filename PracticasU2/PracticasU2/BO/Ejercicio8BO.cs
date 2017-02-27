using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticasU2.GUI;

namespace PracticasU2.BO
{
    class Ejercicio8BO
    {
        static Random rdn = new Random();
        private int turno = rdn.Next(1, 2);
        private Button btnTurno;
        private int ganadosJ1;
        private int ganadosJ2;

        public Button BtnActual
        {
            get
            {
                return btnTurno;
            }

            set
            {
                btnTurno = value;
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

        public void CambiarBoton(Button btn)
        {
            if (turno == 1)
            {
                btn.ForeColor = Color.Blue;
                btn.Text = "X";
                btnTurno.Text = "O";
                turno = 2;
                btn.Enabled = false;
            }
            else
            {
                btn.ForeColor = Color.Red;
                btn.Text = "O";
                btnTurno.Text = "X";
                turno = 1;
                btn.Enabled = false;
            }
        }

        public void Verificar(frm_Ejercicio8GUI form)
        {
            if (form.btn_P1.Text == form.btn_P2.Text && form.btn_P2.Text == form.btn_P3.Text && !form.btn_P1.Enabled)
            {
                MostrarGanador(form.btn_P1.Text, form);
            }
            else if (form.btn_P4.Text == form.btn_P5.Text && form.btn_P5.Text == form.btn_P6.Text && !form.btn_P4.Enabled)
            {
                MostrarGanador(form.btn_P4.Text, form);
            }
            else if (form.btn_P7.Text == form.btn_P8.Text && form.btn_P8.Text == form.btn_P9.Text && !form.btn_P7.Enabled)
            {
                MostrarGanador(form.btn_P7.Text, form);
            }
            else if (form.btn_P1.Text == form.btn_P4.Text && form.btn_P4.Text == form.btn_P7.Text && !form.btn_P1.Enabled)
            {
                MostrarGanador(form.btn_P1.Text, form);
            }
            else if (form.btn_P2.Text == form.btn_P5.Text && form.btn_P5.Text == form.btn_P8.Text && !form.btn_P2.Enabled)
            {
                MostrarGanador(form.btn_P2.Text, form);
            }
            else if (form.btn_P3.Text == form.btn_P6.Text && form.btn_P6.Text == form.btn_P9.Text && !form.btn_P3.Enabled)
            {
                MostrarGanador(form.btn_P3.Text, form);
            }
            else if (form.btn_P1.Text == form.btn_P5.Text && form.btn_P5.Text == form.btn_P9.Text && !form.btn_P1.Enabled)
            {
                MostrarGanador(form.btn_P1.Text, form);
            }
            else if (form.btn_P3.Text == form.btn_P5.Text && form.btn_P5.Text == form.btn_P7.Text && !form.btn_P3.Enabled)
            {
                MostrarGanador(form.btn_P3.Text, form);
            }
            else if(!form.btn_P1.Enabled && !form.btn_P2.Enabled && !form.btn_P3.Enabled && !form.btn_P4.Enabled && !form.btn_P5.Enabled && !form.btn_P6.Enabled && !form.btn_P7.Enabled && !form.btn_P8.Enabled && !form.btn_P9.Enabled)
            {
                MostrarGanador("-", form);
            }

        }

        public void MostrarGanador(string text, frm_Ejercicio8GUI form)
        {
            if(text == "X")
            {
                MessageBox.Show("Gana Jugador 1");
                ganadosJ1++;
                form.grb_Juego.Enabled = false;

            }
            else if (text == "O")
            {
                MessageBox.Show("Gana Jugador 2");
                ganadosJ2++;
                form.grb_Juego.Enabled = false;

            }
            else
            {
                MessageBox.Show("Empate");
                form.grb_Juego.Enabled = false;
            }
        }

        public void ReiniciarJuego(frm_Ejercicio8GUI form)
        {
            form.btn_P1.Text = "-";
            form.btn_P1.Enabled = true;
            form.btn_P2.Text = "-";
            form.btn_P2.Enabled = true;
            form.btn_P3.Text = "-";
            form.btn_P3.Enabled = true;
            form.btn_P4.Text = "-";
            form.btn_P4.Enabled = true;
            form.btn_P5.Text = "-";
            form.btn_P5.Enabled = true;
            form.btn_P6.Text = "-";
            form.btn_P6.Enabled = true;
            form.btn_P7.Text = "-";
            form.btn_P7.Enabled = true;
            form.btn_P8.Text = "-";
            form.btn_P8.Enabled = true;
            form.btn_P9.Text = "-";
            form.btn_P9.Enabled = true;

        }




    }
}
