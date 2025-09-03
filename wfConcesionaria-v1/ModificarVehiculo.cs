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
    public partial class ModificarVehiculo : Form
    {
        static Vehiculo vehiculo = new Vehiculo();
        string Marca;
        string TipoVehiculo;
        string Modelo;
        string Anio;
        string Placa;
        string Vin;
        string Precio_costo;
        string Precio_venta;
        string Idcolor;
        string Estado;
        string Idproveedor;
        string Kilometraje;
        string TipoCombustible;
        string Transmision;
        public ModificarVehiculo(string Marca, string TipoVehiculo, string Modelo, string Anio, string Placa, string Vin, string Precio_costo, string Precio_venta, string Idcolor, string Estado, string Idproveedor, string Kilometraje, string TipoCombustible, string Transmision)
        {
            InitializeComponent();

            llenarColor();

            this.Marca = Marca;
            this.TipoVehiculo = TipoVehiculo;
            this.Modelo = Modelo;
            this.Anio = Anio;
            this.Placa = Placa;
            this.Vin = Vin;
            this.Precio_costo = Precio_costo;
            this.Precio_venta = Precio_venta;
            this.Idcolor = Idcolor;
            this.Estado = Estado;
            this.Idproveedor = Idproveedor;
            this.Kilometraje = Kilometraje;
            this.TipoCombustible = TipoCombustible;
            this.Transmision = Transmision;

            txtPlaca.Text = Placa;
            txtModelo.Text = Modelo;
            cbxColor.Text = Idcolor;
            txtAño.Text = Anio;
            txtVin.Text = Vin;
            cbTipoCombustible.Text = TipoCombustible;
            cbMarca.Text = Marca;
            cbTipoVehiculo.Text = TipoVehiculo;
            txtKilometraje.Text = Kilometraje;
            cbEstado.Text = Estado;
            txtPrecio.Text = Precio_costo;
            txtPrecioVenta.Text = Precio_venta;
            cbProveedor.Text = Idproveedor;
            cbTransmicion.Text = Transmision;
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMarca.Text != Marca)
                    vehiculo.ModificarVehiculo("Marca", cbMarca.Text, txtPlaca.Text);
                if (cbTipoVehiculo.Text != TipoVehiculo)
                    vehiculo.ModificarVehiculo("TipoVehiculo", cbTipoVehiculo.Text, txtPlaca.Text);
                if (txtModelo.Text != Modelo)
                    vehiculo.ModificarVehiculo("Modelo", txtModelo.Text, txtPlaca.Text);
                if (txtAño.Text != Anio)
                    vehiculo.ModificarVehiculo("Anio", txtAño.Text, txtPlaca.Text);
                if (txtVin.Text != Vin)
                    vehiculo.ModificarVehiculo("Vin", txtVin.Text, txtPlaca.Text);
                if (txtPrecio.Text != Precio_costo)
                    vehiculo.ModificarVehiculo("Precio_Compra", txtPrecio.Text, txtPlaca.Text);
                if (txtPrecioVenta.Text != Precio_venta)
                    vehiculo.ModificarVehiculo("Precio_Venta", txtPrecioVenta.Text, txtPlaca.Text);
                if (cbxColor.Text != Idcolor)
                    vehiculo.ModificarVehiculo("Id_Color", cbxColor.Text, txtPlaca.Text);
                if (cbEstado.Text != Estado)
                    vehiculo.ModificarVehiculo("Estado", cbEstado.Text, txtPlaca.Text);
                if (cbProveedor.Text != Idproveedor)
                    vehiculo.ModificarVehiculo("Id_Proveedor", cbProveedor.Text, txtPlaca.Text);
                if (txtKilometraje.Text != Kilometraje)
                    vehiculo.ModificarVehiculo("Kilometraje", txtKilometraje.Text, txtPlaca.Text);
                if (cbTipoCombustible.Text != TipoCombustible)
                    vehiculo.ModificarVehiculo("TipoCombustible", cbTipoCombustible.Text, txtPlaca.Text);
                if (cbTransmicion.Text != Transmision)
                    vehiculo.ModificarVehiculo("Transmision", cbTransmicion.Text, txtPlaca.Text);
                if (txtPlaca.Text != Placa)
                    vehiculo.ModificarVehiculo("Placa", txtPlaca.Text, txtPlaca.Text);
                MessageBox.Show("Se modifico correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                vehiculo.cerrarConexion();
            }
        }

        private void llenarColor()
        {
            try
            {
                vehiculo.abrirConexion();
                string cadena = "SELECT Id_Color FROM Colores";
                SqlCommand comando = new SqlCommand(cadena, vehiculo.conexion);
                SqlDataReader dataread = comando.ExecuteReader();

                while (dataread.Read())
                {
                    cbxColor.Items.Add(dataread.GetValue(0).ToString());
                }

                vehiculo.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
                vehiculo.cerrarConexion();
            }
        }

    }
}
