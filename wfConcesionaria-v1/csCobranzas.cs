using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace wfConcesionaria_v1
{
    internal class csCobranzas
    {
        bdConcesionaria concesionaria;
        DataTable dt;
        SqlDataReader dr;
        string cadena;

        string Id_Venta;
        string Id_Cliente;
        DateTime Fecha_Pago;
        DateTime Fecha_PagoSiguiente;
        decimal Valor_Cuota;
        decimal Valor_Pagado;
        decimal Valor_Pendiente;
        int Mora;
        decimal Intereses;

        public csCobranzas()
        {
            concesionaria = new bdConcesionaria();
        }
        public csCobranzas(string Id_Venta, string Id_Cliente, DateTime Fecha_Pago, DateTime Fecha_PagoSiguiente,
            decimal Valor_Cuota, decimal Valor_Pagado, decimal Valor_Pendiente,int Mora = 0, decimal Intereses = 0)
        {
            concesionaria = new bdConcesionaria();
            this.Id_Venta = Id_Venta;
            this.Id_Cliente = Id_Cliente;
            this.Fecha_Pago = Fecha_Pago;
            this.Fecha_PagoSiguiente = Fecha_PagoSiguiente;
            this.Valor_Cuota = Valor_Cuota;
            this.Valor_Pagado = Valor_Pagado;
            this.Valor_Pendiente = Valor_Pendiente;
            this.Mora = Mora;
            this.Intereses = Intereses;
        }
        public DataTable RetornarTabla()
        {
            cadena = "select C.Id_Cliente,D.Id_Venta,D.Factura,D.Id_Vehiculo,D.N_Cuotas,C.Fecha_Pago," +
                "C.Fecha_PagoSiguiente,C.Valor_Cuota,C.Valor_Pagado,C.Valor_Pendiente,C.Mora,C.Intereses " +
                "from DetallesVenta D inner join Cobranzas C on D.Id_Venta=C.Id_Venta";
            dt = concesionaria.retornaTablaConsulta(cadena);
            return dt;
        }
        public DataTable RetornarTablaConsulta(string Consulta)
        {
            dt = concesionaria.retornaTablaConsulta(Consulta);
            return dt;
        }
        public DataTable RetornarTablaFiltro(string filtro)
        {
            cadena = "select C.Id_Cliente,D.Id_Venta,D.Factura,D.Id_Vehiculo,D.N_Cuotas,C.Fecha_Pago," +
                "C.Fecha_PagoSiguiente,C.Valor_Cuota,C.Valor_Pagado,C.Valor_Pendiente,C.Mora,C.Intereses " +
                "from DetallesVenta D inner join Cobranzas C on D.Id_Venta=C.Id_Venta" + filtro;
            dt = concesionaria.retornaTablaConsulta(cadena);
            return dt;
        }
        public int RetornarValorConsulta(string Consulta)
        {
            int aux = concesionaria.retornaEnteroConsulta(Consulta);
            return aux;
        }
        public decimal RetornarDecimalConsulta(string Consulta)
        {
            decimal aux = concesionaria.retornaValorConsulta(Consulta);
            return aux;
        }
        public string RetornarStringConsulta(string Consulta)
        {
            string aux = concesionaria.retornaCadenaConsulta(Consulta);
            return aux;
        }
        public string RetornarFechaConsulta(string Consulta)
        {
            string Fecha = "";
            dr = concesionaria.retornaDataDRConsulta(Consulta);
            dr.Read();
            if (!dr.IsDBNull(0))
            {
                Fecha += dr.GetDateTime(0).ToString("yyyy-MM-dd");
            }
            return Fecha;
        }
        public string RetornarDatosConsulta(string Consulta)
        {
            string Datos = "";
            dr = concesionaria.retornaDataDRConsulta(Consulta);
            dr.Read();
            Datos += dr.GetInt32(1).ToString() + ",";
            Datos += dr.GetDateTime(3).ToString("yyyy-MM-dd") + ",";
            Datos += dr.GetDateTime(4).ToString("yyyy-MM-dd") + ",";
            Datos += dr.GetDecimal(5).ToString() + ",";
            Datos += dr.GetDecimal(6).ToString() + ",";
            Datos += dr.GetDecimal(7).ToString() + ",";
            Datos += dr.GetInt32(8).ToString() + ",";
            Datos += dr.GetDecimal(9).ToString() + ",";
            return Datos;
        }
        public Boolean IngresoCobranza()
        {
            cadena = "insert into Cobranzas(Id_Venta,Id_Cliente,Fecha_Pago,Fecha_PagoSiguiente,Valor_Cuota,Valor_Pagado,Valor_Pendiente,Mora,Intereses) " +
                            "values (" + Id_Venta + ",'" + Id_Cliente + "','" + Fecha_Pago.ToString("yyyy-MM-dd") + "','" + Fecha_PagoSiguiente.ToString("yyyy-MM-dd") + "'," +
                            Valor_Cuota + "," + Valor_Pagado + "," + Valor_Pendiente + "," + Mora + "," + Intereses + ")";
            concesionaria.ejecutarSQL(cadena);
            return true;
        }
        public Boolean ModificarCobranzaCadena(string Ingreso)
        {
            concesionaria.ejecutarSQL(Ingreso);
            return true;
        }
    }
}
