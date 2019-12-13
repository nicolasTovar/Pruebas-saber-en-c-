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
    public partial class FrmPreguntaNueve : Form
    {
        public FrmPreguntaNueve()
        {
            InitializeComponent();
           // lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrNueve.Start();
        }

        private void FrmPreguntaNueve_Load(object sender, EventArgs e)
        {
            tmrNueve.Interval = Auxiliar.intervalo;
            this.rbA9.Checked = false;
            this.rbB9.Checked = false;
            this.rbC9.Checked = false;
            this.rbD9.Checked = false;


            
        }

        private void btnSiguiente9_Click(object sender, EventArgs e)
        {
            if ((this.rbA9.Checked == false)&&(this.rbB9.Checked == false)&& (this.rbC9.Checked == false)&&(this.rbD9.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (this.rbD9.Checked == true)
                {
                    tmrNueve.Stop();
                    FrmPreguntaDiez Diez = new FrmPreguntaDiez();
                    Auxiliar.contador += 10;
                    Auxiliar.r9 =1;
                    Diez.Show();
                    this.Close();
                }
                else
                {
                    tmrNueve.Stop();
                    FrmPreguntaDiez Diez = new FrmPreguntaDiez();
                    Diez.Show();
                    this.Close();
                }

            }
       
        }

        private void tmrNueve_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrNueve.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
