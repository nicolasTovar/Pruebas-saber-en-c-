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
    public partial class FrmInicioSesion : Form
    {
        Prueba prueba = new Prueba();
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((txtCorreoInicio.Text.Length > 0) && (txtContraseñaInicio.Text.Length > 0))
            {
                int total = prueba.LogingUsuario(txtCorreoInicio.Text.Trim()) + prueba.LogingContraseña(txtContraseñaInicio.Text.Trim());
                if (total==2)
                {
                    Auxiliar.nombre = txtCorreoInicio.Text.Trim();   
                    FrmPreguntaUno uno = new FrmPreguntaUno();
                    uno.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Escribió un dato incorrecto", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}