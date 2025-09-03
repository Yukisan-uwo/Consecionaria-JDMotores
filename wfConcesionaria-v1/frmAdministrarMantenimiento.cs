using InterfacesConcesionaria;
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
    public partial class frmAdministrarMantenimiento : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();
        public frmAdministrarMantenimiento()
        {
            InitializeComponent();
        }

        private void frmAdministrarMantenimiento_Load(object sender, EventArgs e)
        {
            dgvmantenimiento.DataSource = concesionaria.retornaTablaConsulta("select VH.Placa,VH.Marca,VH.Modelo,VH.Anio,V.Id_Cliente,M.Ultimo_Mantenimiento," +
               "M.Proximo_Mantenimiento from DetallesVenta D inner join Ventas V on D.Id_Venta=V.Id_Venta inner join Vehiculos VH on VH.Id_Vehiculo=D.Id_Vehiculo " +
               "inner join Tabla_Mantenimiento M on VH.Id_Vehiculo=M.Id_Vehiculo");
        }
        private void dgvmantenimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Placa = dgvmantenimiento.CurrentRow.Cells[0].Value.ToString();
            string Marca = dgvmantenimiento.CurrentRow.Cells[1].Value.ToString();
            string Modelo = dgvmantenimiento.CurrentRow.Cells[2].Value.ToString();
            string Año = dgvmantenimiento.CurrentRow.Cells[3].Value.ToString();
            string id_Cliente = dgvmantenimiento.CurrentRow.Cells[4].Value.ToString();
            DateTime UltimoMantenimiento = Convert.ToDateTime(dgvmantenimiento.CurrentRow.Cells[5].Value);
            string Ultimo_Mantenimiento = UltimoMantenimiento.ToString("yyyy/MM/dd");
            DateTime ProximoMantenimiento = Convert.ToDateTime(dgvmantenimiento.CurrentRow.Cells[6].Value);
            string Proximo_Mantenimiento = ProximoMantenimiento.ToString("yyyy/MM/dd");

            frmMantenimiento frmMantenimiento = new frmMantenimiento(Placa, Marca, Modelo, Año, id_Cliente, Ultimo_Mantenimiento, Proximo_Mantenimiento);
            frmMantenimiento.ShowDialog();
            dgvmantenimiento.DataSource = concesionaria.retornaTablaConsulta("select VH.Placa,VH.Marca,VH.Modelo,VH.Anio,V.Id_Cliente,M.Ultimo_Mantenimiento," +
               "M.Proximo_Mantenimiento from DetallesVenta D inner join Ventas V on D.Id_Venta=V.Id_Venta inner join Vehiculos VH on VH.Id_Vehiculo=D.Id_Vehiculo " +
               "inner join Tabla_Mantenimiento M on VH.Id_Vehiculo=M.Id_Vehiculo");
        }
        private void btnAgregarKits_Click(object sender, EventArgs e)
        {
            frmAgregarKits frmAgregarKits = new frmAgregarKits();
            frmAgregarKits.ShowDialog();
        }
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturasMantenimiento frmFacturasMantenimiento = new frmFacturasMantenimiento();
            frmFacturasMantenimiento.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvmantenimiento.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará el mantenimiento del vehículo con placa " + dgvmantenimiento.CurrentRow.Cells[0].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    string placa = dgvmantenimiento.CurrentRow.Cells[0].Value.ToString();
                    DataTable dt = concesionaria.retornaTablaConsulta("SELECT Id_Vehiculo FROM Vehiculos WHERE Placa = '" + placa + "'");

                    if (dt.Rows.Count > 0)
                    {
                        string idVehiculo = dt.Rows[0][0].ToString();
                        concesionaria.ejecutarSQL("delete from Tabla_Mantenimiento where Id_Vehiculo = " + idVehiculo+"");

                        MessageBox.Show("Eliminado correctamente.");
                        dgvmantenimiento.DataSource = concesionaria.retornaTablaConsulta("select VH.Placa,VH.Marca,VH.Modelo,VH.Anio,V.Id_Cliente,M.Ultimo_Mantenimiento," +
                            "M.Proximo_Mantenimiento from DetallesVenta D inner join Ventas V on D.Id_Venta=V.Id_Venta inner join Vehiculos VH on VH.Id_Vehiculo=D.Id_Vehiculo " +
                            "inner join Tabla_Mantenimiento M on VH.Id_Vehiculo=M.Id_Vehiculo");
                    }
                }
            }
        }

    }
}
