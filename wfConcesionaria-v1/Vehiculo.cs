using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    internal class Vehiculo
    {
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader dataread;
        public SqlDataAdapter dataAdapter;
        public DataTable datatable;

        public Vehiculo()
        {
            
        }      

        public bool abrirConexion()
        {
            conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "server=STEVEN\\SQLSTEV; database=Concesionaria2; User id=sa; Password=12345";
                conexion.Open();
            }
            catch 
            {
                MessageBox.Show("error al conectar");
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            conexion.Close();
            return true;
        }

        private string placa;
        private string modelo;
        private string año;
        private string n_Vin;
        private string tipo_combustible;
        private string color1;
        private string transmision;
        private string marca1;
        private string tipo_vehiculo;
        private string kilometraje;
        private string estado;
        private string proveedor;
        private string precio_Costo;
        private string precio_Venta;


        private string marca11;
        private string tipoVehiculo;
        private string color11;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Año { get => año; set => año = value; }
        public string N_Vin { get => n_Vin; set => n_Vin = value; }
        public string Tipo_combustible { get => tipo_combustible; set => tipo_combustible = value; }
        public string Color { get => color1; set => color1 = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public string Marca { get => marca1; set => marca1 = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public string Kilometraje { get => kilometraje; set => kilometraje = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Precio_Costo { get => precio_Costo; set => precio_Costo = value; }
        public string Precio_Venta { get => precio_Venta; set => precio_Venta = value; }
        public string Marca1 { get => marca11; set => marca11 = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string Color1 { get => color11; set => color11 = value; }

        

        public bool Agregar_vehiculo()
        {
            string cadena = "insert into Vehiculos (Marca, TipoVehiculo, Modelo, Anio, Placa, Vin,Id_Proveedor, Precio_Compra,Precio_venta, Id_Color, Estado, Kilometraje, TipoCombustible, Transmision) " +
               "Values ('" + Marca + "','" + Tipo_vehiculo + "','" + Modelo + "'," + Año + ",'" + Placa + "','" + N_Vin + "','" + VerificaProveedor(Proveedor) + "'," + Precio_Costo + "," + Precio_Venta + ",'" + Verificacolor(Color) + "','" + Estado + "'," + Kilometraje + ",'" + Tipo_combustible + "','" + Transmision + "')";

            abrirConexion();
            comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        private string VerificaProveedor(string id_proveedor)
        {
            abrirConexion();
            string proveedor1 = "";
            string cadena = "select * from Proveedores where Nombre='" + id_proveedor + "'";
            comando = new SqlCommand(cadena, conexion);
            dataread = comando.ExecuteReader();
            if (dataread.Read())
            {
                proveedor1 = dataread["Id_Proveedor"].ToString();
            }
            dataread.Close();
            cerrarConexion();
            return proveedor1;
        }

        private string Verificacolor(string id_color)
        {
            abrirConexion();
            string color1 = "";
            string cadena = "select * from Colores where Color = '" + id_color + "'";

            comando = new SqlCommand(cadena, conexion);
            dataread = comando.ExecuteReader();
            if (dataread.Read())
            {
                color1 = dataread["Id_Color"].ToString();
            }
            dataread.Close();
            cerrarConexion();
            return color1;
        }

        public void EstadoVehiculo(TextBox Kilometraje, string Estado)
        {
            if (Estado == "Nuevo")
            {
                Kilometraje.ReadOnly = true;
                Kilometraje.Text = "0.000";
            }
            else
            {
                Kilometraje.ReadOnly = false;
                Kilometraje.Text = "";
            }
        }

        public void PrecioVenta(TextBox PrecioVenta, string PrecioCompra)
        {
            try
            {
                if (PrecioCompra != "")
                {
                    double precioCostoInt = double.Parse(PrecioCompra);
                    double monto = precioCostoInt * 0.15;
                    double montoFinal = precioCostoInt + monto;
                    PrecioVenta.ReadOnly = true;
                    PrecioVenta.Text = montoFinal.ToString();
                }
                else
                {
                    PrecioVenta.ReadOnly=false;
                    PrecioVenta.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PRECIO INVALIDO");
            }
        }

        public void Proveedor_comproba(ComboBox Proveedor)
        {
            abrirConexion();
            Proveedor.Items.Clear();
            string cadena = "select Nombre from Proveedores ";
            comando = new SqlCommand(cadena, conexion);
            dataread = comando.ExecuteReader();

            while (dataread.Read())
            {
                Proveedor.Items.Add(dataread.GetString(0));
            }
            cerrarConexion();
        }

        public string Color_comproba(int color)
        {
            string idColor = "";
            string nombreColor = "";
            string rgbcolor = "";
            abrirConexion();
            string cadena = "select * from Colores";
            comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cerrarConexion();

            if (color <= dt.Rows.Count)
            {
                idColor = dt.Rows[color]["Id_Color"].ToString();
                nombreColor = dt.Rows[color]["Color"].ToString();
                rgbcolor = dt.Rows[color]["ColorRGB"].ToString();

                return idColor + " ; " + nombreColor + " ; " + rgbcolor;
            }

            return "";

        }

        public void Actualizar_datacolor(DataGridView paleta, ComboBox Proveedor)
        {
            int cc = 0;
            int pc = 0;
            int pf = 0;

            abrirConexion();
            string cadena = "select * from Colores";
            comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cc = dt.Rows.Count;

            for (int i = 0; i < 4; i++)
            {
                paleta.Columns[i].Width = paleta.Width / 4 - 1;
            }

            for (int i = 0; i < cc; i++)
            {
                string colorHex = dt.Rows[i]["ColorRGB"].ToString();
                Color color = ColorTranslator.FromHtml(colorHex);

                if (pf >= paleta.Rows.Count)
                {
                    paleta.Rows.Add();
                }

                paleta[pc, pf].Style.BackColor = color;

                pc++;

                if (pc == 4)
                {
                    pc = 0;
                    pf++;
                }
            }

            cerrarConexion();

            abrirConexion();
            Proveedor.Items.Clear();
            string cadena1 = "select Nombre from Proveedores ";
            comando = new SqlCommand(cadena1, conexion);
            dataread = comando.ExecuteReader();

            while (dataread.Read())
            {
                Proveedor.Items.Add(dataread.GetString(0));
            }
            dataread.Close();
            cerrarConexion();
        }

        public void Eliminardatos(DataGridView dgvvehiculos)
        {

            if (dgvvehiculos.SelectedRows.Count > 0)
            {
                DialogResult opc = MessageBox.Show(
                    "Se eliminará el vehículo con la Placa: " + dgvvehiculos.SelectedRows[0].Cells["Placa"].Value.ToString(),
                    "Confirmación de Borrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (opc == DialogResult.Yes)
                {
                    string placa = dgvvehiculos.SelectedRows[0].Cells["Placa"].Value.ToString();

                    try
                    {
                        abrirConexion();
                        string cadena = "delete from Vehiculos where Placa = '"+placa+"'";
                        comando= new SqlCommand(cadena, conexion);
                        comando.ExecuteReader();
                        cerrarConexion();

                        MessageBox.Show("Vehículo eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el vehículo: " + ex.Message);
                        cerrarConexion();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo para eliminar.");
            }
        }

        public DataTable retornaTablaConsulta(string cadena)
        {
            if (cadena.Length > 0)
            {
                abrirConexion();
                comando = new SqlCommand(cadena, conexion);
                dataAdapter = new SqlDataAdapter(comando);
                datatable = new DataTable();
                dataAdapter.Fill(datatable);
                cerrarConexion();
            }
            return datatable;
        }

        public void Busqueda_data(DataGridView dgvvehiculos, string marca, string tipoVehiculo, string color)
        {
            try
            {
                string cadena = "select * from Vehiculos where 1=1";

                if (!String.IsNullOrEmpty(marca) && marca != "Todos")
                {
                    cadena += " and Marca='" + marca + "'";
                }

                if (!String.IsNullOrEmpty(tipoVehiculo) && tipoVehiculo != "Todos")
                {
                    cadena += " and TipoVehiculo='" + tipoVehiculo + "'";
                }

                if (!String.IsNullOrEmpty(color))
                {

                    cadena += " and Id_Color = (select Id_Color from Colores where Color like '%" + color + "%')";
                }
                else
                {
                    dgvvehiculos.DataSource = retornaTablaConsulta(cadena);
                }

                dgvvehiculos.DataSource = retornaTablaConsulta(cadena);

            }
            catch { }
        }

        public void Agrega_colordata(string nuevocolor, string colorrgb)
        {
            abrirConexion();
            string cadena = "insert into colores(Color, ColorHTML, ColorRGB) Values ('" + nuevocolor + "', '" + colorrgb + "')";
            comando = new SqlCommand(cadena, conexion);
            comando.ExecuteReader();
            cerrarConexion();
            MessageBox.Show("Color '" + nuevocolor + "' agregado correctamente.");
        }

        public void Agrega_proveedordata(string nuevoproveedor, string telefono,string ciudad)
        {
            abrirConexion();
            string cadena = "insert into Proveedores(Nombre, Telefono, Ciudad) Values ('" + nuevoproveedor + "', '" + telefono + "', '" + ciudad + "')";
            comando = new SqlCommand(cadena, conexion);
            comando.ExecuteReader();
            cerrarConexion();
            MessageBox.Show("Proveedor '" + nuevoproveedor + "' agregado correctamente.");
        }

        public bool ModificarVehiculo(string Cdonde, string Cnuevo, string placa)
        {
            abrirConexion();
            string cadena = "update Vehiculos set "+ Cdonde + "='"+ Cnuevo + "' where Placa='"+placa+"'";
            MessageBox.Show(cadena);
            comando = new SqlCommand(cadena, conexion);
            comando.ExecuteReader();
            cerrarConexion();
            return true;
        }
    }
}
