using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmModificarCobranza : Form
    {
        string datos;
        string Id_Venta;
        public string Datos { set { datos = value; } }
        public frmModificarCobranza()
        {
            InitializeComponent();
        }
        private void frmModificarCobranza_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(datos))
            {
                string[] DatosIN = datos.Split(',');
                txtVentaID.Text = DatosIN[0];
                txtFPago.Text = DatosIN[1];
                txtFPagoSig.Text = DatosIN[2];
                txtValorCuota.Text = DatosIN[3];
                txtValorPagado.Text = DatosIN[4];
                txtDeuda.Text = DatosIN[5];
                txtMora.Text = DatosIN[6];
                txtIntereses.Text = DatosIN[7];
                Id_Venta = DatosIN[0];
            }
            else
            {
                MessageBox.Show("Datos no Encontrados","Seleccione Correctamente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csCobranzas Cobranzas = new csCobranzas();
            DateTime fecha;
            if (DateTime.TryParse(txtFPago.Text,out fecha))
            {
                DateTime fechaN = fecha.AddMonths(1);
                Cobranzas.ModificarCobranzaCadena("update Cobranzas set Fecha_Pago='" + fecha.ToString("yyyy-MM-dd") +
                "',Fecha_PagoSiguiente='" + fechaN.ToString("yyyy-MM-dd") + "' where Id_Venta=" + Id_Venta.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Fecha Invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtFPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFPago.Text.Length > 0)
            {
                if (txtFPago.Text.Length == 5 || txtFPago.Text.Length == 8)
                {
                    if (txtFPago.Text[txtFPago.Text.Length - 1] != 45)
                    {
                        txtFPago.Text = txtFPago.Text.Substring(0, txtFPago.Text.Length - 1);
                        txtFPago.SelectionStart = txtFPago.Text.Length;
                    }
                }
                else if (txtFPago.Text[txtFPago.Text.Length - 1] < 48 || txtFPago.Text[txtFPago.Text.Length - 1] > 57)
                {
                    txtFPago.Text = txtFPago.Text.Substring(0, txtFPago.Text.Length - 1);
                    txtFPago.SelectionStart = txtFPago.Text.Length;
                }
            }
        }
        private void txtFPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFPago.Text.Length > 0)
            {
                if (txtFPago.Text.Length == 5 || txtFPago.Text.Length == 8)
                {
                    if (txtFPago.Text[txtFPago.Text.Length - 1] != 45)
                    {
                        txtFPago.Text = txtFPago.Text.Substring(0, txtFPago.Text.Length - 1);
                        txtFPago.SelectionStart = txtFPago.Text.Length;
                    }
                }
                else if (txtFPago.Text[txtFPago.Text.Length - 1] < 48 || txtFPago.Text[txtFPago.Text.Length - 1] > 57)
                {
                    txtFPago.Text = txtFPago.Text.Substring(0, txtFPago.Text.Length - 1);
                    txtFPago.SelectionStart = txtFPago.Text.Length;
                }
            }
        }
    }
}
