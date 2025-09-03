using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmCorreo : Form
    {
        public frmCorreo()
        {
            InitializeComponent();
        }

        public frmCorreo(string correo)
        {
            InitializeComponent();

            txtPara.Text = correo;
            txtDe.Text = "cmuteq@hotmail.com";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Correo correo = new Correo();
            correo.Para = txtPara.Text;
            correo.ConCopia = txtConCopia.Text;
            correo.Asunto = txtAsunto.Text;
            correo.Cuerpo = txtCuerpo.Text;
            correo.Adjunto = txtAdjunto.Text;
            if (correo.Enviar())
                MessageBox.Show("Se envío el correo de manera satisfactoria");

            this.Close();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            ofdRuta.InitialDirectory = @"c:\Intel";
            ofdRuta.Filter = "Todos los Archivos(*.*)|*.*|Archivos docx(*.docx)|*.docx";
            if (ofdRuta.ShowDialog() == DialogResult.OK)
            {
                string[] adjunto = ofdRuta.FileNames;

                txtAdjunto.Text = String.Join(",", adjunto);
            }
        }
    }
}
