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
    public partial class PreguntaCuatro : Form
    {
        public PreguntaCuatro()
        {
            InitializeComponent();
            //  lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrCuatro.Start();

        }

        private void FrmPreguntaCuatro_Load(object sender, EventArgs e)
        {

            tmrCuatro.Interval = Auxiliar.intervalo;
            this.rbA4.Checked = false;
            this.rbB4.Checked = false;
            this.rbC4.Checked = false;
            this.rbD4.Checked = false;

       
        }

        private void btnSiguiente4_Click(object sender, EventArgs e)
        {
            if ((this.rbA4.Checked == false) && (this.rbB4.Checked == false) && (this.rbC4.Checked == false) && (this.rbD4.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.rbB4.Checked == true)
            {
                tmrCuatro.Stop();
                Auxiliar.contador += 10;
                Auxiliar.r4 = 1;
                FrmPreguntaCinco cinco = new FrmPreguntaCinco();
                cinco.Show();
                this.Close();
            }
            else
            {
                tmrCuatro.Stop();
                FrmPreguntaCinco cinco = new FrmPreguntaCinco();
                cinco.Show();
                this.Close();
            }
        }
           

        private void tmrCuatro_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrCuatro.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
