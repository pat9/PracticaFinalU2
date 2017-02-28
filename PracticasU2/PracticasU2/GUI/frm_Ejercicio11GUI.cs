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
    public partial class frm_Ejercicio11GUI : Form
    {
        private bool activado = false;
        private int vueltas = 0;
        Ejercicio11BO Cronometro = new Ejercicio11BO(); 
        public frm_Ejercicio11GUI()
        {
            InitializeComponent();
        }

        private void trm_Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Segundos++;
            lbl_Contador.Text = Cronometro.ActualizarTiempo();
        }

        private void btn_Iniciar_Parar_Click(object sender, EventArgs e)
        {
            if (activado == false)
            {
                trm_Cronometro.Start();
                btn_Iniciar_Parar.Text = "Parar";
                btn_Reiniciar_Vuelta.Enabled = true;
                btn_Reiniciar_Vuelta.Text = "Vuelta";
                activado = true;
            }

            else
            {
                trm_Cronometro.Stop();
                btn_Iniciar_Parar.Text = "Iniciar";
                btn_Reiniciar_Vuelta.Enabled = true;
                btn_Reiniciar_Vuelta.Text = "Reiniciar";
                activado = false;

            }
        }

        private void btn_Reiniciar_Vuelta_Click(object sender, EventArgs e)
        {
            if(btn_Reiniciar_Vuelta.Text == "Reiniciar")
            {
                Cronometro.Segundos = 0;
                Cronometro.Minutos = 0;
                Cronometro.Horas = 0;
                lbl_Contador.Text = Cronometro.ActualizarTiempo();
            }
            else
            {
                vueltas++;
                dgt_Registro.Rows.Add(vueltas, Cronometro.Tiempo);
            }
        }
    }
}
