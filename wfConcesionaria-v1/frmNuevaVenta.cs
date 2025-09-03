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
using static System.Net.Mime.MediaTypeNames;

namespace wfConcesionaria_v1
{
    public partial class frmNuevaVenta : Form
    {
        csRD rd = new csRD();
        bdConcesionaria concesionaria = new bdConcesionaria();
        public string IDEmpleado;
        string IDCliente;
        string IDVehiculo;
        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        public frmNuevaVenta(string aaaa)
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
                this.IDCliente = datos[0];
                txtNombre.Text = datos[1] + " " + datos[2];
                btnSelecVehiculo.Enabled = true;
            }
            buscar.Dispose();
        }
        private void btnSelecVehiculo_Click(object sender, EventArgs e)
        {
            frmBusqueda buscar = new frmBusqueda();
            buscar.Comando = "select V.Id_Vehiculo,V.Marca,V.Modelo,V.Anio,V.Estado,V.Kilometraje,V.Transmision,V.TipoCombustible,C.Id_Color,V.Precio_Venta " +
                "from Vehiculos V inner join Colores C on V.Id_Color=C.Id_Color where Disponibilidad=1";
            buscar.Columnas = "Marca,Modelo,Año";
            buscar.Tabla = "Vehiculos";
            buscar.Vehiculo = true;
            buscar.ShowDialog();
            if (!string.IsNullOrEmpty(buscar.Datos))
            {
                string[] datos = buscar.Datos.Split(',');
                txtMarca.Text = datos[1];
                txtModelo.Text = datos[2];
                txtAño.Text = datos[3];
                txtEstado.Text = datos[4];
                txtKilometraje.Text = datos[5];
                txtTransmision.Text = datos[6];
                txtCombustible.Text = datos[7];
                PintarColor(Convert.ToInt32(datos[8]));
                txtPrecio.Text = datos[9];
                IDVehiculo = datos[0];
                btnPagar.Enabled = true;

                txtDecuento.Text = Descuento(datos[9]).ToString();
                txtRegalo.Text = Regalo();
            }
            buscar.Dispose();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cbxMetodo.SelectedIndex == 1)
            {
                if (ComprobarTarjeta())
                {
                    concesionaria.ejecutarSQL("insert into Ventas (Id_Empleado,Id_Cliente) values ('" + IDEmpleado + "','" + IDCliente + "')");
                    concesionaria.ejecutarSQL("update Vehiculos set Disponibilidad=0 where Id_Vehiculo=" + IDVehiculo);
                    int IdVenta = concesionaria.retornaEnteroConsulta("select top(1)Id_Venta from Ventas order by Id_Venta desc");
                    decimal Precio = concesionaria.retornaValorConsulta("select Precio_Venta from Vehiculos where Id_Vehiculo=" + IDVehiculo);

                    decimal Descuento = Convert.ToDecimal(txtDecuento.Text);
                    decimal PagoTotal = Convert.ToDecimal(txtDecuento.Text);
                    string regalo = txtRegalo.Text;
                    
                    if (txtEstado.Text == "Nuevo")
                    {
                        decimal Comision = concesionaria.retornaValorConsulta("select Comision from Empleados where Id_Empleado="+IDEmpleado);
                        Comision += Precio * 0.5m;
                        concesionaria.ejecutarSQL("update Empleados set Comision=" + Math.Round(Comision, 2) + " where Id_Empleado="+IDEmpleado);
                    }
                    else
                    {
                        decimal Comision = concesionaria.retornaValorConsulta("select Comision from Empleados where Id_Empleado=" + IDEmpleado);
                        Comision += Precio * 0.10m;
                        concesionaria.ejecutarSQL("update Empleados set Comision=" + Math.Round(Comision, 2) + " where Id_Empleado=" + IDEmpleado);
                    }
                    
                    if (cbxFacturacion.SelectedIndex == 0)
                    {
                        concesionaria.ejecutarSQL("insert into DetallesVenta (Id_Venta,Id_Vehiculo,Metodo,Facturacion,N_Tarjeta,Precio, Descuento, Regalo, Pago_Final)" +
                        "values (" + IdVenta.ToString() + "," + IDVehiculo + ",'" + cbxMetodo.Text + "','" + cbxFacturacion.Text + "','" + txtTarjeta.Text + "'," + Precio + ", "+ Descuento + ", '"+ regalo +"', "+ PagoTotal +")");
                        MessageBox.Show("Ingresos ejecutados");
                    }
                    else if (cbxFacturacion.SelectedIndex == 1)
                    {
                        DateTime FechaHoy = DateTime.Now;
                        DateTime FechaN = FechaHoy.AddMonths(1);
                        decimal interes = 0;
                        for (int i = 1; i < 6; i++)
                        {
                            if (((int) nudNdeCuotas.Value) / 12 == i)
                            {
                                decimal dec = ((decimal)i / 100) + 1.00m;
                                interes += dec;
                                break;
                            }
                        }
                        decimal PrecioI = Precio * interes;
                        decimal Cuota = PrecioI / nudNdeCuotas.Value;
                        decimal Deuda = PrecioI - Cuota;
                        concesionaria.ejecutarSQL("insert into DetallesVenta (Id_Venta,Id_Vehiculo,Metodo,Facturacion,N_Cuotas,N_Tarjeta,Precio, Descuento, Regalo, Pago_Final)" +
                        "values ("+IdVenta.ToString() + ","+IDVehiculo+",'"+cbxMetodo.Text+"','"+cbxFacturacion.Text+"',"+(nudNdeCuotas.Value-1)+",'"+txtTarjeta.Text+"',"+ Precio + ", " + Descuento + ", '" + regalo + "', " + PagoTotal + ")");
                        csCobranzas Cobranza = new csCobranzas(IdVenta.ToString(), IDCliente, FechaHoy, FechaN, Cuota, Cuota, Deuda,0,0);
                        Cobranza.IngresoCobranza();
                        MessageBox.Show("Ingresos ejecutados");
                    }
                }
                else
                {
                    ttpTarjeta.IsBalloon = true;
                    ttpTarjeta.Show("Tarjeta Invalida", txtTarjeta, txtTarjeta.Width / 2, txtTarjeta.Height - 65, 2000);
                    txtTarjeta.Text = string.Empty;
                }
            }
            else
            {
                decimal Descuento = Convert.ToDecimal(txtDecuento.Text);
                decimal PagoTotal = Convert.ToDecimal(txtDecuento.Text);
                string regalo = txtRegalo.Text;

                concesionaria.ejecutarSQL("insert into Ventas (Id_Empleado,Id_Cliente) values ('" + IDEmpleado + "','" + IDCliente + "')");
                concesionaria.ejecutarSQL("update Vehiculos set Disponibilidad=0 where Id_Vehiculo="+IDVehiculo);
                int IdVenta = concesionaria.retornaEnteroConsulta("select top(1)Id_Venta from Ventas order by Id_Venta desc");
                decimal Precio = concesionaria.retornaValorConsulta("select Precio_Venta from Vehiculos where Id_Vehiculo=" + IDVehiculo);

                if (txtEstado.Text == "Nuevo")
                {
                    decimal Comision = concesionaria.retornaValorConsulta("select Comision from Empleados where Id_Empleado=" + IDEmpleado);
                    Comision += Precio * 0.5m;
                    concesionaria.ejecutarSQL("update Empleados set Comision=" + Math.Round(Comision, 2) + " where Id_Empleado=" + IDEmpleado);
                }
                else
                {
                    decimal Comision = concesionaria.retornaValorConsulta("select Comision from Empleados where Id_Empleado=" + IDEmpleado);
                    Comision += Precio * 0.10m;
                    concesionaria.ejecutarSQL("update Empleados set Comision=" + Math.Round(Comision, 2) + " where Id_Empleado=" + IDEmpleado);
                }

                if (cbxFacturacion.SelectedIndex == 0)
                {
                    concesionaria.ejecutarSQL("insert into DetallesVenta (Id_Venta,Id_Vehiculo,Metodo,Facturacion,Precio, Descuento, Regalo, Pago_Final)" +
                    "values (" + IdVenta.ToString() + "," + IDVehiculo + ",'" + cbxMetodo.Text + "','" + cbxFacturacion.Text + "'," + Precio.ToString() + ", " + Descuento + ", '" + regalo + "', " + PagoTotal + ")");
                    MessageBox.Show("Ingresos ejecutados");
                }
                else if (cbxFacturacion.SelectedIndex == 1)
                {
                    DateTime FechaHoy = DateTime.Now;
                    DateTime FechaN = FechaHoy.AddMonths(1);
                    decimal interes = 0;
                    for (int i = 1; i < 6; i++)
                    {
                        if (((int)nudNdeCuotas.Value) / 12 == i)
                        {
                            decimal dec = ((decimal)i / 100) + 1.00m;
                            interes += dec;
                            break;
                        }
                    }
                    decimal PrecioI = Precio * interes;
                    decimal Cuota = PrecioI / nudNdeCuotas.Value;
                    decimal Deuda = PrecioI - Cuota;
                    concesionaria.ejecutarSQL("insert into DetallesVenta (Id_Venta,Id_Vehiculo,Metodo,Facturacion,N_Cuotas,Precio, Descuento, Regalo, Pago_Final)" +
                    "values (" + IdVenta.ToString() + "," + IDVehiculo + ",'" + cbxMetodo.Text + "','" + cbxFacturacion.Text + "'," + (nudNdeCuotas.Value-1) + "," + Precio + ", " + Descuento + ", '" + regalo + "', " + PagoTotal + ")");
                    csCobranzas Cobranza = new csCobranzas(IdVenta.ToString(), IDCliente, FechaHoy, FechaN, Cuota, Cuota, Deuda);
                    Cobranza.IngresoCobranza();
                    MessageBox.Show("Ingresos ejecutados");
                }
            }
            DateTime FechaHoyy = DateTime.Now.Date;
            DateTime ProximoMantenimiento = FechaHoyy.AddMonths(6);
            int id_vehiculo = int.Parse(IDVehiculo);
            concesionaria.ejecutarSQL("insert into Tabla_Mantenimiento(Ultimo_Mantenimiento,Proximo_Mantenimiento,Id_Vehiculo) values ('" + FechaHoyy.ToString("yyyy/MM/dd") + "','" + ProximoMantenimiento.ToString("yyyy/MM/dd") + "'," + id_vehiculo + ")");

            txtModelo.Text = "";
            txtMarca.Text = "";
            txtAño.Text = "";
            txtEstado.Text = "";
            txtTransmision.Text = "";
            txtKilometraje.Text = "";
            txtCombustible.Text = "";
            txtPrecio.Text = "";
            pnlColor.BackColor = Color.White;

            nudNdeCuotas.Value = 12;
            lblNdeCuotas.Visible = false;
            nudNdeCuotas.Visible = false;

            txtTarjeta.Text = string.Empty;
            lblTarjeta.Visible = false;
            txtTarjeta.Visible = false;

            btnPagar.Enabled = false;
        }
        private void cbxFacturacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFacturacion.SelectedIndex == 1)
            {
                lblNdeCuotas.Visible = true;
                nudNdeCuotas.Visible = true;
            }
            else
            {
                nudNdeCuotas.Value = 12;
                lblNdeCuotas.Visible = false;
                nudNdeCuotas.Visible = false;
            }
        }
        private void cbxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMetodo.SelectedIndex == 1)
            {
                lblTarjeta.Visible = true;
                txtTarjeta.Visible = true;
            }
            else
            {
                txtTarjeta.Text = string.Empty;
                lblTarjeta.Visible= false;
                txtTarjeta.Visible = false;
            }
        }
        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            cbxFacturacion.SelectedIndex = 0;
            cbxMetodo.SelectedIndex = 0;
        }
        private Boolean ComprobarTarjeta()
        {
            if (String.IsNullOrEmpty(txtTarjeta.Text.Trim())) return false;
            int suma = 0;
            int numero = 0;
            for (int i = 0; i < txtTarjeta.Text.Length; i++)
            {
                numero = int.Parse(txtTarjeta.Text[i].ToString());
                if (i % 2 == 0)
                {
                    numero *= 2;
                    while (numero > 9 || numero > 0)
                    {
                        suma += numero % 10;
                        numero /= 10;
                    }
                }
                suma += numero;
            }
            return suma % 10 == 0;
        }
        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (txtTarjeta.Text.Length > 0)
            {
                if (txtTarjeta.Text[txtTarjeta.Text.Length - 1] < 48 || txtTarjeta.Text[txtTarjeta.Text.Length - 1] > 57)
                {
                    txtTarjeta.Text = txtTarjeta.Text.Substring(0, txtTarjeta.Text.Length - 1);
                    txtTarjeta.SelectionStart = txtTarjeta.Text.Length;
                }
            }
        }

        private void PintarColor(int IdColor)
        {
            string ColorRGB = concesionaria.retornaCadenaConsulta("select ColorRGB from Colores where Id_Color="+IdColor.ToString());
            string[] RGB = ColorRGB.Split(',');
            pnlColor.BackColor = Color.FromArgb(Convert.ToInt32(RGB[0]), Convert.ToInt32(RGB[1]), Convert.ToInt32(RGB[2]));
        }

        private decimal Descuento(string x)
        {
            double precio = Convert.ToDouble(x);
            decimal envio = 0;
            double porcentaje = 0;
            double porcentajetabla = 0;
            DateTime fechaActual = DateTime.Now;

            string cadena = "select d.Nombre, D.Fecha_Inicio, D.Fecha_Fin, D.Descuento from Descuentos as D";
            DataTable dt = rd.tablaAdaptada(cadena);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime fechainicio = Convert.ToDateTime(dt.Rows[i]["Fecha_Inicio"]);
                DateTime fechafin = Convert.ToDateTime(dt.Rows[i]["Fecha_Fin"]);

                if (fechaActual.Date >= fechainicio.Date && fechaActual.Date <= fechafin.Date)
                {
                    porcentajetabla = Convert.ToDouble(dt.Rows[i]["descuento"]);
                    porcentaje = precio * porcentajetabla;
                    double descuento = precio - porcentaje;
                    envio = Convert.ToDecimal(descuento);
                    break;
                }
                else
                {
                    envio = Convert.ToDecimal(txtPrecio.Text);
                }
            }

            return envio;
        }


        static Random rnd = new Random(DateTime.Now.Millisecond);

        private string Regalo()
        {
            string premio = "";
            DateTime fechaActual = DateTime.Now;
            string cadenafecha = "select d.Nombre, D.Fecha_Inicio, D.Fecha_Fin, D.Descuento from Descuentos as D";
            DataTable dt1 = rd.tablaAdaptada(cadenafecha);
            string cadena = "Select regalo from Regalos";
            DataTable dt = rd.tablaAdaptada(cadena);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DateTime fechainicio = Convert.ToDateTime(dt1.Rows[i]["Fecha_Inicio"]);
                DateTime fechafin = Convert.ToDateTime(dt1.Rows[i]["Fecha_Fin"]);

                if (fechaActual.Date >= fechainicio.Date && fechaActual.Date <= fechafin.Date)
                {
                    int n = rnd.Next(dt.Rows.Count);
                    premio = dt.Rows[n]["Regalo"].ToString();
                    break;
                }
                else
                {
                    premio = "Sin regalo";
                }
            }

            return premio;
        }

    }
}
