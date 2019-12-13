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
    public partial class FrmPreguntaDiez : Form
    {
        public FrmPreguntaDiez()
        {
            InitializeComponent();
            //  lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrDiez.Start();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmPreguntaDiez_Load(object sender, EventArgs e)
        {
            tmrDiez.Interval = Auxiliar.intervalo;
            this.cbA.Checked = false;
            this.cbB.Checked = false;
            this.cbC.Checked = false;
            this.cbD.Checked = false;
            this.cbE.Checked = false;
            this.cbF.Checked = false;
            this.cbG.Checked = false;
        }


        private void btnFinalizar_Click_2(object sender, EventArgs e)
        {
            if ((this.cbA.Checked == false) && (this.cbB.Checked == false) && (this.cbC.Checked == false) && (this.cbD.Checked == false) && (this.cbE.Checked == false) && (this.cbF.Checked == false) && (this.cbG.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((this.cbA.Checked == false)&& (this.cbB.Checked == false)&& (this.cbC.Checked == false)&&(this.cbD.Checked == true) && (this.cbE.Checked == false)&&(this.cbF.Checked == true)&& (this.cbG.Checked == false))
            {
                tmrDiez.Stop();
                FrmResultadoP resul = new FrmResultadoP();
                Auxiliar.contador += 10;
                Auxiliar.r10 = 1;
                resul.Show();
                this.Close();

            }
            else
            {
                tmrDiez.Stop();
                FrmResultadoP resul = new FrmResultadoP();
                resul.Show();
                this.Close();
            }

        }





        private void tmrDiez_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrDiez.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmResultadoP resultados = new FrmResultadoP();
                this.Hide();
                resultados.Show();
            }
        }

    }
}
