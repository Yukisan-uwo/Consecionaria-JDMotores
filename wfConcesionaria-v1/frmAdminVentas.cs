using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmAdminVentas : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();
        string cadena;
        public frmAdminVentas()
        {
            InitializeComponent();
        }
        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = concesionaria.retornaTablaConsulta("select D.Factura,V.Fecha_venta,V.Id_Venta,D.Id_Vehiculo,V.Id_Cliente,V.Id_Empleado,D.Metodo,D.Facturacion,D.Precio, D.Descuento, D.Regalo, D.Pago_Final " +
                "from Ventas V inner join DetallesVenta D on V.Id_Venta=D.Id_Venta");
        }
        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                dgvVentas.DataSource = concesionaria.retornaTablaConsulta("select D.Factura,V.Fecha_venta,D.Id_Vehiculo,V.IdVenta,V.IdCliente,V.IdEmpleado,D.IdDetalle,D.Metodo,D.Facturacion,D.Precio " +
                "from Ventas V inner join DetallesVenta D on V.IdVenta=D.IdVenta");
            }
            else
            {
                dgvVentas.DataSource = concesionaria.retornaTablaConsulta("select D.Factura,V.Fecha_venta,D.Id_Vehiculo,V.IdVenta,V.IdCliente,V.IdEmpleado,D.IdDetalle,D.Metodo,D.Facturacion,D.Precio " +
                "from Ventas V inner join DetallesVenta D on V.IdVenta=D.IdVenta " +
                "where D.Factura like '%" + txtFiltro.Text + "' or V.IdVenta like '%" + txtFiltro.Text + "'");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvVentas.CurrentRow.Index + ", que pertenece al la venta " + dgvVentas[2, dgvVentas.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    string Id_venta = dgvVentas.CurrentRow.Cells[2].Value.ToString();

                    cadena = "delete Ventas where Id_Venta = '" + Id_venta + "'";

                    concesionaria.ejecutarSQL(cadena);

                    dgvVentas.DataSource = concesionaria.retornaTablaConsulta("select D.Factura,V.Fecha_venta,V.Id_Venta,D.Id_Vehiculo,V.Id_Cliente,V.Id_Empleado,D.Metodo,D.Facturacion,D.Precio " +
                        "from Ventas V inner join DetallesVenta D on V.Id_Venta=D.Id_Venta");
                }
            }
        }
    }
}
