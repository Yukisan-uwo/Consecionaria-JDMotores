using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace wfConcesionaria_v1
{
    public partial class frmverVehiculos : Form
    {
        static Vehiculo Vehiculo;

        public frmverVehiculos()
        {
            InitializeComponent();
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            Vehiculo = new Vehiculo();
            Vehiculo.Color_comproba(0);                                             //-------------------------------------------------------------------
            dgvvehiculos.DataSource = Vehiculo.retornaTablaConsulta("select * from Vehiculos");
        }
        private void cbmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizaDataGridView();
        }
        private void cbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizaDataGridView();
        }
        private void cbColor_TextChanged(object sender, EventArgs e)
        {
            ActualizaDataGridView();
        }

        private void ActualizaDataGridView()
        {
            Vehiculo = new Vehiculo();
            Vehiculo.Marca1 = cbmarca.Text;
            Vehiculo.TipoVehiculo = cbTipoVehiculo.Text;
            Vehiculo.Color1 = cbColor.Text;

            Vehiculo = new Vehiculo();
            Vehiculo.Busqueda_data(dgvvehiculos, cbmarca.Text, cbTipoVehiculo.Text, cbColor.Text);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculo = new Vehiculo();
            Vehiculo.Eliminardatos(dgvvehiculos);
            dgvvehiculos.DataSource = Vehiculo.retornaTablaConsulta("select * from Vehiculos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVehiculos aggVehiculo = new frmAgregarVehiculos();
            aggVehiculo.ShowDialog();
            dgvvehiculos.DataSource = Vehiculo.retornaTablaConsulta("select * from Vehiculos");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vehiculo = new Vehiculo();
            Vehiculo.Marca = dgvvehiculos.CurrentRow.Cells[1].Value.ToString();
            Vehiculo.Tipo_vehiculo = dgvvehiculos.CurrentRow.Cells[2].Value.ToString();
            Vehiculo.Modelo = dgvvehiculos.CurrentRow.Cells[3].Value.ToString();
            Vehiculo.Año = dgvvehiculos.CurrentRow.Cells[4].Value.ToString();
            Vehiculo.Placa = dgvvehiculos.CurrentRow.Cells[5].Value.ToString();
            Vehiculo.N_Vin = dgvvehiculos.CurrentRow.Cells[6].Value.ToString();
            Vehiculo.Precio_Costo = dgvvehiculos.CurrentRow.Cells[7].Value.ToString();
            Vehiculo.Precio_Venta = dgvvehiculos.CurrentRow.Cells[8].Value.ToString();
            Vehiculo.Color = dgvvehiculos.CurrentRow.Cells[9].Value.ToString();
            Vehiculo.Estado = dgvvehiculos.CurrentRow.Cells[10].Value.ToString();
            Vehiculo.Proveedor = dgvvehiculos.CurrentRow.Cells[11].Value.ToString();
            Vehiculo.Kilometraje = dgvvehiculos.CurrentRow.Cells[12].Value.ToString();
            Vehiculo.Tipo_combustible = dgvvehiculos.CurrentRow.Cells[13].Value.ToString();
            Vehiculo.Transmision = dgvvehiculos.CurrentRow.Cells[14].Value.ToString();

            ModificarVehiculo modificarVehiculo = new ModificarVehiculo(dgvvehiculos.CurrentRow.Cells[1].Value.ToString(), dgvvehiculos.CurrentRow.Cells[2].Value.ToString(), dgvvehiculos.CurrentRow.Cells[3].Value.ToString(), dgvvehiculos.CurrentRow.Cells[4].Value.ToString(), dgvvehiculos.CurrentRow.Cells[5].Value.ToString(), dgvvehiculos.CurrentRow.Cells[6].Value.ToString(), dgvvehiculos.CurrentRow.Cells[7].Value.ToString(), dgvvehiculos.CurrentRow.Cells[8].Value.ToString(), dgvvehiculos.CurrentRow.Cells[9].Value.ToString(), dgvvehiculos.CurrentRow.Cells[10].Value.ToString(), dgvvehiculos.CurrentRow.Cells[11].Value.ToString(), dgvvehiculos.CurrentRow.Cells[12].Value.ToString(), dgvvehiculos.CurrentRow.Cells[13].Value.ToString(), dgvvehiculos.CurrentRow.Cells[14].Value.ToString());
            modificarVehiculo.ShowDialog();
            dgvvehiculos.DataSource = Vehiculo.retornaTablaConsulta("select * from Vehiculos");
        }

    }
}
