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
    public partial class FrmPreguntaUno : Form
    {
        public FrmPreguntaUno()
        {
            InitializeComponent();
            tmrUno.Start();
        }

   
      

        private void FrmPreguntaUno_Load(object sender, EventArgs e)
        {
              tmrUno.Interval = Auxiliar.intervalo;
            this.rbA1.Checked = false;
            this.rbB1.Checked = false;
            this.rbC1.Checked = false;
            this.rbD1.Checked = false;
          
         
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((this.rbA1.Checked== false) && (this.rbB1.Checked == false) && (this.rbC1.Checked == false) && (this.rbD1.Checked == false))
            {
                MessageBox.Show("Debe marcar una respuesta", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.rbB1.Checked == true)
            {
                    tmrUno.Stop();
                    Auxiliar.contador += 10;
                    Auxiliar.resultado=1;
                    FrmPreguntaDos dos = new FrmPreguntaDos();
                    dos.Show();
                    this.Close();
            }
            else
            {
                    tmrUno.Stop();
                    FrmPreguntaDos dos = new FrmPreguntaDos();
                    dos.Show();
                    this.Close();
            }
              
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrUno_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;


            if (Auxiliar.segundos == 0)
            {
                tmrUno.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }
    }
}
