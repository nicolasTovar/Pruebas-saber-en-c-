using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSaberPro
{
    public partial class FrmPreguntaDos : Form
    {
        public FrmPreguntaDos()
        {
            InitializeComponent();
            // lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrDos.Start();
        }

        private void cboRespuesta2_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void FrmPreguntaDos_Load(object sender, EventArgs e)
        {
            tmrDos.Interval = Auxiliar.intervalo;
           
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            if (cboRespuesta2.Text == "")
            {
                MessageBox.Show("Debe seleccionar una opción de respuesta", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboRespuesta2.Text == "•Es la mejor solución a problemas recurrentes al software")
            {
                tmrDos.Stop();
                Auxiliar.contador += 10;
                Auxiliar.r2 = 1;
                FrmPreguntaTres tres = new FrmPreguntaTres();
                tres.Show();
                this.Close();

            }
             else
             {
                tmrDos.Stop();
                FrmPreguntaTres tres = new FrmPreguntaTres();
                tres.Show();
                this.Close();
             }
            
        }

        private void tmrDos_Tick(object sender, EventArgs e)
        {

            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrDos.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
