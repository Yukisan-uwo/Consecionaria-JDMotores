using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfConcesionaria_v1
{
    public partial class frmAgregarVehiculos : Form
    {
        static Vehiculo vehiculo;
        public frmAgregarVehiculos()
        {
            InitializeComponent();
        }
        private void frmAgregarVehiculos_Load(object sender, EventArgs e)
        {
            dgvColores.Visible = false;
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Actualizar_datacolor(dgvColores, cbProveedor);
        }
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            vehiculo = new Vehiculo();
            vehiculo.Marca = cbMarca.Text;
            vehiculo.Tipo_vehiculo = cbTipoVehiculo.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.Año = txtAño.Text;
            vehiculo.Placa = txtPlaca.Text.ToUpper();
            vehiculo.N_Vin = txtVin.Text.ToUpper();
            vehiculo.Proveedor = cbProveedor.Text;
            vehiculo.Precio_Costo = txtPrecioCosto.Text;
            vehiculo.Precio_Venta = txtPrecioVenta.Text;
            vehiculo.Color = btnColor.Text.Trim();
            vehiculo.Estado = cbEstado.Text;
            vehiculo.Kilometraje = txtKilometraje.Text;
            vehiculo.Tipo_combustible = cbTipoCombustible.Text;
            vehiculo.Transmision = cbTransmicion.Text;

            try
            {
                vehiculo.Agregar_vehiculo();
                MessageBox.Show("Vehículo '" + txtPlaca.Text + "' agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                vehiculo.cerrarConexion();
            }

            this.Close();
        }

        private void btnAggColor_Click(object sender, EventArgs e)
        {
            frmColores frmColores = new frmColores();
            frmColores.ShowDialog();

            Vehiculo vehiculo = new Vehiculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();

            vehiculo = new Vehiculo();
            vehiculo.Proveedor_comproba(cbProveedor);

        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {

            vehiculo = new Vehiculo();
            vehiculo.EstadoVehiculo(txtKilometraje, cbEstado.Text);

        }

        private void txtPrecioCosto_Leave(object sender, EventArgs e)
        {
            vehiculo = new Vehiculo();
            vehiculo.PrecioVenta(txtPrecioVenta, txtPrecioCosto.Text);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dgvColores.ClearSelection();
            dgvColores.Visible = !dgvColores.Visible;
        }

        private void dgvColores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            int posicion = (fila * 4) + columna;

            vehiculo = new Vehiculo();
            string datos = vehiculo.Color_comproba(posicion);
            string[] vector = datos.Split(';');

            string[] rgb = vector[2].Split(',');

            Color fondo = Color.FromArgb(int.Parse(rgb[0].Trim()), int.Parse(rgb[1].Trim()), int.Parse(rgb[2].Trim()));

            btnColor.BackColor = fondo;
            btnColor.Text = vector[1];

            dgvColores.Visible = false;
        }
    }
}
