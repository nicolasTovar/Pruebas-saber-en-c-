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
    public partial class FrmPreguntaTres : Form
    {
        public FrmPreguntaTres()
        {
            InitializeComponent();
            //  lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrTres.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPreguntaTres_Load(object sender, EventArgs e)
        {
            tmrTres.Interval = Auxiliar.intervalo;
            this.rbA3.Checked = false;
            this.rbB3.Checked = false;
            this.rbC3.Checked = false;
            this.rbD3.Checked = false;
            
           
        }

        private void btnSiguiente3_Click(object sender, EventArgs e)
        {
            if ((this.rbA3.Checked == false) && (this.rbB3.Checked == false) && (this.rbC3.Checked == false) && (this.rbD3.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             else if (this.rbA3.Checked == true)
             {
                tmrTres.Stop();
                Auxiliar.contador += 10;
                Auxiliar.r3 = 1;
                PreguntaCuatro cuatro = new PreguntaCuatro();
                cuatro.Show();
                this.Close();
             }
              else
              {
                tmrTres.Stop();
                PreguntaCuatro cuatro = new PreguntaCuatro();
                cuatro.Show();
                this.Close();
              }
           
        }

        private void tmrTres_Tick(object sender, EventArgs e)
        {

            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrTres.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }

        private void rbA3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
