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
    public partial class FrmPreguntaCinco : Form
    {
        
        public FrmPreguntaCinco()
        {
            InitializeComponent();
         //   lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrCinco.Start();
        }

        private void btnSiguiente5_Click(object sender, EventArgs e)
        {
            if ((txtResp1.Text.Length > 0) && (txtResp2.Text.Length > 0) && (txtResp3.Text.Length > 0) && (txtResp4.Text.Length > 0) && (txtResp4.Text.Length > 0))
            {
                if ((txtResp1.Text == "d") && (txtResp2.Text == "c") && (txtResp3.Text == "b") && (txtResp4.Text == "e") && (txtResp5.Text == "a"))
                {
                    tmrCinco.Stop();
                    Auxiliar.contador += 10;
                    Auxiliar.r5 = 1;
                    FrmPreguntaSeis seis = new FrmPreguntaSeis();
                    seis.Show();
                    this.Close();

                 

                }
                if ((txtResp1.Text != "") | (txtResp2.Text != "") | (txtResp3.Text != "") | (txtResp4.Text != "") | (txtResp5.Text != ""))
                {
                    tmrCinco.Stop();
                    FrmPreguntaSeis seis = new FrmPreguntaSeis();
                    seis.Show();
                    this.Close();

                   
                }
            }

            else
            {
                if ((txtResp1.Text == "") && (txtResp2.Text == "") && (txtResp3.Text == "") && (txtResp4.Text == "") && (txtResp5.Text == ""))
                {
                    MessageBox.Show("Debe seleccionar todas las opciones", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void FrmPreguntaCinco_Load(object sender, EventArgs e)
        {
            tmrCinco.Interval = Auxiliar.intervalo;
          
        }

        private void tmrCinco_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrCinco.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
