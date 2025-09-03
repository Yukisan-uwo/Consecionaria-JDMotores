using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmPagarCuotas : Form
    {
        int Id_Venta;
        int Cuotas;
        decimal ValorPagado;
        public frmPagarCuotas()
        {
            InitializeComponent();
        }

        private void btnSelecCliente_Click(object sender, EventArgs e)
        {
            frmBusqueda buscar = new frmBusqueda();
            buscar.Comando = "select Id_Cliente,Nombres,Apellidos from Clientes";
            buscar.Columnas = "Id_Cliente,Nombres,Apellidos";
            buscar.Tabla = "Clientes";
            buscar.ShowDialog();
            if (!string.IsNullOrEmpty(buscar.Datos))
            {
                string[] datos = buscar.Datos.Split(',');
                txtCliente.Text = datos[0];
                txtNombre.Text = datos[1] + " " + datos[2];
                csCobranzas cobranzas = new csCobranzas();
                dgvCobranza.DataSource = cobranzas.RetornarTablaConsulta("select Id_Venta,Id_Cliente,Fecha_Pago,Fecha_PagoSiguiente,Valor_Cuota," +
                    "Valor_Pagado,Valor_Pendiente,Mora,Intereses from Cobranzas where Id_Cliente=" + txtCliente.Text);
                for (int i = 0; i < dgvCobranza.RowCount; i++)
                {
                    int iDv = (int)dgvCobranza.Rows[i].Cells[0].Value;
                    string FechaSig = cobranzas.RetornarFechaConsulta("select Fecha_PagoSiguiente from Cobranzas where Id_Venta=" + iDv.ToString());
                    int mora = cobranzas.RetornarValorConsulta("select datediff (DAY, '" + FechaSig + "' ,CONVERT(DATE, GETDATE()) )");
                    if (mora > 9 && mora < 300)
                    {
                        cobranzas.ModificarCobranzaCadena("update Cobranzas set Mora=" + mora.ToString() + ",Intereses=1.05 where Id_Venta=" + iDv.ToString());
                    }
                }
                dgvCobranza.DataSource = cobranzas.RetornarTablaConsulta("select Id_Venta,Id_Cliente,Fecha_Pago,Fecha_PagoSiguiente,Valor_Cuota," +
                    "Valor_Pagado,Valor_Pendiente,Mora,Intereses from Cobranzas where Id_Cliente=" + txtCliente.Text);
            }
            buscar.Dispose();
        }

        private void dgvCobranza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            csCobranzas cobranzas = new csCobranzas();
            Id_Venta = (int)dgvCobranza.CurrentRow.Cells["Id_Venta"].Value;
            ValorPagado = (decimal)dgvCobranza.CurrentRow.Cells["Valor_Pagado"].Value;
            decimal Deuda = cobranzas.RetornarDecimalConsulta("select Valor_Pendiente from Cobranzas where Id_Venta=" + Id_Venta.ToString());
            if (Deuda != 0)
            {
                nudCuotasPagar.Minimum = 1;
                nudCuotasPagar.Value = 1;
                txtPrecioCuota.Text = dgvCobranza.CurrentRow.Cells["Valor_Cuota"].Value.ToString();
                Cuotas = cobranzas.RetornarValorConsulta("select N_Cuotas from DetallesVenta where Id_Venta=" + Id_Venta.ToString());
                if ((int)dgvCobranza.Rows[dgvCobranza.CurrentRow.Index].Cells["Mora"].Value > 0)
                {
                    MessageBox.Show("Se aplicara un valor por mora a su primera cuota", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotal.Text = Math.Round((decimal)dgvCobranza.CurrentRow.Cells["Valor_Cuota"].Value * 1.05m).ToString();
                }
                else
                {
                    txtTotal.Text = txtPrecioCuota.Text;
                }
                nudCuotasPagar.Enabled = true;
                btnPagar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No cuenta con una deuda en este prestamo.");
            }
        }

        private void nudCuotasPagar_ValueChanged(object sender, EventArgs e)
        {
            nudCuotasPagar.Maximum = Cuotas;
            decimal Total = Convert.ToDecimal(txtTotal.Text);

            Total += Convert.ToDecimal(txtPrecioCuota.Text);

            txtTotal.Text = Math.Round(Total,2).ToString();
            nudCuotasPagar.Minimum = nudCuotasPagar.Value;
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            csCobranzas cobranzas = new csCobranzas();
            if (nudCuotasPagar.Value == Cuotas)
            {
                DateTime Fecha = DateTime.Now;
                cobranzas.ModificarCobranzaCadena("update DetallesVenta set N_Cuotas=0 where Id_Venta=" + Id_Venta.ToString());
                cobranzas.ModificarCobranzaCadena("update Cobranzas set " +
                    "Fecha_Pago='"+Fecha.ToString("yyyy-MM-dd")+"'," +
                    "Fecha_PagoSiguiente=null," +
                    "Valor_Pagado="+Math.Round(Convert.ToDecimal(txtTotal.Text)+ValorPagado).ToString() +"," +
                    "Valor_Pendiente=0,Mora=0,Intereses=0 " +
                    "where Id_Venta=" + Id_Venta.ToString());

                MessageBox.Show("Datos Actualizados");
                nudCuotasPagar.Enabled = false;
                btnPagar.Enabled = false;
                dgvCobranza.DataSource = cobranzas.RetornarTablaConsulta("select Id_Venta,Id_Cliente,Fecha_Pago,Fecha_PagoSiguiente,Valor_Cuota," +
                    "Valor_Pagado,Valor_Pendiente,Mora,Intereses from Cobranzas where Id_Cliente=" + txtCliente.Text);
            }
            else
            {
                DateTime FechaP = DateTime.Now;
                DateTime FeChaPS = FechaP.AddMonths(1);
                decimal deuda = (decimal) dgvCobranza.CurrentRow.Cells["Valor_Pendiente"].Value;
                cobranzas.ModificarCobranzaCadena("update DetallesVenta set N_Cuotas="+(Cuotas-nudCuotasPagar.Value)+" where Id_Venta=" + Id_Venta.ToString());
                cobranzas.ModificarCobranzaCadena("update Cobranzas set " +
                    "Fecha_Pago='" + FechaP.ToString("yyyy-MM-dd") + "'," +
                    "Fecha_PagoSiguiente='"+ FeChaPS.ToString("yyyy-MM-dd") + "'," +
                    "Valor_Pagado=" + Math.Round(Convert.ToDecimal(txtTotal.Text) + ValorPagado).ToString() + "," +
                    "Valor_Pendiente="+(deuda - Convert.ToDecimal(txtTotal.Text)) + ","+
                    "Mora=0,Intereses=0 " +
                    " where Id_Venta=" + Id_Venta.ToString());

                MessageBox.Show("Datos Actualizados");
                nudCuotasPagar.Enabled = false;
                btnPagar.Enabled = false;
                dgvCobranza.DataSource = cobranzas.RetornarTablaConsulta("select Id_Venta,Id_Cliente,Fecha_Pago,Fecha_PagoSiguiente,Valor_Cuota," +
                    "Valor_Pagado,Valor_Pendiente,Mora,Intereses from Cobranzas where Id_Cliente=" + txtCliente.Text);
            }
        }
    }
}
