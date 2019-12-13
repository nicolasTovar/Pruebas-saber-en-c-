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
    public partial class FrmPreguntaOcho : Form
    {
    
        string solucion;
        string resultado;

        public FrmPreguntaOcho()
        {
            InitializeComponent();
            //lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            tmrOcho.Start();
        }

        private void btnSiguiente8_Click(object sender, EventArgs e)
        {
            string solucion = "classAerolinea{privatestringboletos;privatestringinformacion;publicAerolinea(){}publicAerolinea(stringboletos,stringinformacion){this.boletos=boletos;this.informacion=informacion;}publicstringBoletos{get{returnthis.boletos;}set{this.boletos=value;}}publicstringInformacion{get{returnthis.informacion;}set{this.informacion=value;}}}";
            string resultado = txtPregunta8.Text.Trim().Replace(" ", "").Replace(Environment.NewLine, "");
            if (txtPregunta8.Text.Length > 0)
            {
                if (solucion == resultado)
                {

                    tmrOcho.Stop();
                    Auxiliar.contador += 10;
                    Auxiliar.r8 = 1;
                    FrmPreguntaNueve nueve = new FrmPreguntaNueve();
                    nueve.Show();
                    this.Close();
                }
                else
                {
                    tmrOcho.Stop();
                    FrmPreguntaNueve nueve = new FrmPreguntaNueve();
                    nueve.Show();
                    this.Close();
                }
               

            }
            else
            {
                MessageBox.Show("Debe diligenciar el campo", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void FrmPreguntaOcho_Load(object sender, EventArgs e)
        {
            tmrOcho.Interval = Auxiliar.intervalo;
            
        }

        private void tmrOcho_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(Auxiliar.segundos) + "Segundos";
            Auxiliar.segundos--;
            if (Auxiliar.segundos == 0)
            {
                tmrOcho.Stop();
                MessageBox.Show("Se acabó su tiempo", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                FrmResultadoP resultados = new FrmResultadoP();
                this.Close();
                resultados.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
