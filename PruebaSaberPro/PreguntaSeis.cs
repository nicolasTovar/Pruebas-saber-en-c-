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
    public partial class FrmPreguntaSeis : Form
    {

        public FrmPreguntaSeis()
        {

            InitializeComponent();
            //   lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrSeis.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FrmPreguntaSeis_Load(object sender, EventArgs e)
        {
            tmrSeis.Interval = Auxiliar.intervalo;
            this.cbA.Checked = false;
            this.cbB.Checked = false;
            this.cbC.Checked = false;
            this.cbD.Checked = false;
            this.cbE.Checked = false;
            this.cbF.Checked = false;



        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((this.cbA.Checked == false) && (this.cbB.Checked == false) && (this.cbC.Checked == false) && (this.cbD.Checked == false) && (this.cbE.Checked == false) && (this.cbF.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((this.cbA.Checked == true) && (this.cbB.Checked == false)&& (this.cbC.Checked == false)&&(this.cbD.Checked == true)&& (this.cbE.Checked == false)&& (this.cbF.Checked == false))
            {
                tmrSeis.Stop();
                FrmPreguntaSiete siete = new FrmPreguntaSiete();
                Auxiliar.contador += 10;
                Auxiliar.r6 = 1;
                siete.Show();
                this.Close();
            }
            else
            {
                tmrSeis.Stop();
                FrmPreguntaSiete siete = new FrmPreguntaSiete();
                siete.Show();
                this.Close();
            }
        }


        private void tmrSeis_Tick(object sender, EventArgs e)
        {
            Auxiliar.segundos--;
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            if (Auxiliar.segundos == 0)
            {
                tmrSeis.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }

    }
}
