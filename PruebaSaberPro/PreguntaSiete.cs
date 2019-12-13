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
    public partial class FrmPreguntaSiete : Form
    {
        
        public FrmPreguntaSiete()
        {
            InitializeComponent();
            tmrSiete.Start();

        }

        private void FrmPreguntaSiete_Load(object sender, EventArgs e)
        {

            tmrSiete.Interval = Auxiliar.intervalo;
      
        }

        private void btnSiguiente7_Click(object sender, EventArgs e)
        {
            

            if (cboRespuesta7.Text == "")
            {
                MessageBox.Show("Debe seleccionar una opción de respuesta", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             else if (cboRespuesta7.Text == "Patrón comportamental")
                {
                FrmPreguntaOcho ocho = new FrmPreguntaOcho();
                Auxiliar.contador += 10;
                Auxiliar.r7 = 1;
                tmrSiete.Stop();
                ocho.Show();
                this.Close();
             }
             else
             {
                FrmPreguntaOcho ocho = new FrmPreguntaOcho();
                tmrSiete.Stop();
                ocho.Show();
                this.Close();
             }          
        }

        private void cboRespuesta7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrSiete_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrSiete.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
