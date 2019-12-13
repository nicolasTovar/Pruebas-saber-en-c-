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
    public partial class FrmResultadoP : Form
    {
        Prueba prueba = new Prueba();
        public FrmResultadoP()
        {
            InitializeComponent();
        }

        private void FrmResultadoP_Load(object sender, EventArgs e)
        {
            this.txtDatos.Text = prueba.MostrarEvaluador(Auxiliar.nombre);
            this.txtPuntaje.Text = Convert.ToString(Auxiliar.contador);
            this.txtPorcentaje.Text = Auxiliar.contador + "%";
            this.txtTiempo.Text = Convert.ToString((Auxiliar.menos/60)-(Auxiliar.segundos / 60)) + "Minutos";

            if (Auxiliar.resultado== 1)
            {
                lblR1.Text = "Ok";
            }
            else
            {
                lblR1.Text = "X";
            }
            if (Auxiliar.r2== 1)
            {
                lblR2.Text = "Ok";
            }
            else
            {
                lblR2.Text = "X";
            }
            if (Auxiliar.r3== 1)
            {
                lblR3.Text = "Ok";
            }
            else
            {
                lblR3.Text = "X";
            }
            if (Auxiliar.r4 == 1)
            {
                lblR4.Text = "Ok";
            }
            else
            {
                lblR4.Text = "X";
            }
            if (Auxiliar.r5== 1)
            {
                lblR5.Text = "Ok";
            }
            else
            {
                lblR5.Text = "X";
            }
            if (Auxiliar.r6 == 1)
            {
                lblR6.Text = "Ok";
            }
            else
            {
                lblR6.Text = "X";
            }
            if (Auxiliar.r7== 1)
            {
                lblR7.Text = "Ok";
            }
            else
            {
                lblR7.Text = "X";
            }
            if (Auxiliar.r8== 1)
            {
                lblR8.Text = "Ok";
            }
            else
            {
                lblR8.Text = "X";
            }
            if (Auxiliar.r9== 1)
            {
                lblR9.Text = "Ok";
            }
            else
            {
                lblR9.Text = "X";
            }
            if (Auxiliar.r10== 1)
            {
                lblR10.Text = "Ok";
            }
            else
            {
                lblR10.Text = "X";
            }


        }

      

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblR9_Click(object sender, EventArgs e)
        {

        }

        private void lblR8_Click(object sender, EventArgs e)
        {

        }

        private void lblR7_Click(object sender, EventArgs e)
        {

        }

        private void lblR6_Click(object sender, EventArgs e)
        {

        }

        private void lblR5_Click(object sender, EventArgs e)
        {

        }

        private void lblR4_Click(object sender, EventArgs e)
        {

        }

        private void lblR3_Click(object sender, EventArgs e)
        {

        }

        private void lblR2_Click(object sender, EventArgs e)
        {

        }

        private void lblR1_Click(object sender, EventArgs e)
        {

        }

        private void lbl10_Click(object sender, EventArgs e)
        {

        }

        private void lbl9_Click(object sender, EventArgs e)
        {

        }

        private void lbl8_Click(object sender, EventArgs e)
        {

        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lblR10_Click(object sender, EventArgs e)
        {

        }

        private void gbResultado_Enter(object sender, EventArgs e)
        {

        }
    }
}
