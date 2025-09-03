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
    public partial class frmVerReportes : Form
    {
        public frmVerReportes()
        {
            InitializeComponent();
        }
        private void frmVerReportes_Load(object sender, EventArgs e)
        {
            tscbxReportes.Text = "-- Seleccionar --";
            tscbxFiltro1.Text = "-- Año --";
            tscbxFiltro2.Text = "-- Tipo --";
            tscbxTops.Text = "-- Tops --";
        }

        private void tscbxReportes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tscbxReportes.SelectedIndex)
            {
                case 0:
                    tsbtnBuscar.Enabled = false;
                    tscbxTops.Enabled = false;
                    tscbxFiltro1.Enabled = true;
                    tscbxFiltro2.Enabled = false;

                    tscbxFiltro1.Text = "-- Año --";
                    tscbxFiltro2.Text = "-- Tipo --";
                    tscbxTops.Text = "-- Tops --";

                    break;
                case 1:
                    tsbtnBuscar.Enabled = false;
                    tscbxTops.Enabled = false;
                    tscbxFiltro1.Enabled = true;
                    tscbxFiltro2.Enabled = false;

                    tscbxFiltro1.Text = "-- Año --";
                    tscbxFiltro2.Text = "-- Tipo --";
                    tscbxTops.Text = "-- Tops --";

                    break;
                case 2:
                    tsbtnBuscar.Enabled = false;
                    tscbxTops.Enabled = true;
                    tscbxFiltro1.Enabled = false;
                    tscbxFiltro2.Enabled = false;

                    tscbxFiltro1.Text = "-- Año --";
                    tscbxFiltro2.Text = "-- Tipo --";
                    tscbxTops.Text = "-- Tops --";

                    break;
                case 3:
                    tsbtnBuscar.Enabled = true;
                    tscbxTops.Enabled = false;
                    tscbxFiltro1.Enabled = false;
                    tscbxFiltro2.Enabled = false;

                    tscbxFiltro1.Text = "-- Año --";
                    tscbxFiltro2.Text = "-- Tipo --";
                    tscbxTops.Text = "-- Tops --"; ;

                    break;
            }
        }
        private void tscbxFiltro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tscbxFiltro2.Enabled = true;
        }
        private void tscbxFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbtnBuscar.Enabled = true;
        }

        private void tsbtnBuscar_Click(object sender, EventArgs e)
        {
            csReportes rep;
            string consulta;
            switch (tscbxReportes.SelectedIndex)
            {
                case 0:
                    if (tscbxFiltro2.SelectedIndex == 0)
                    {
                        rep = new csReportes();
                        consulta = "select Marca,MONTH(Fecha_Compra) as Mes,Count(*) as Compra " +
                            "from Vehiculos where year(Fecha_Compra)=" + tscbxFiltro1.Text +
                            " group by Marca,MONTH(Fecha_Compra)";
                        rep.GenerarReporteVentas(rptReportes, consulta, "rptComprasMes", "dsComprasPorMarcaINF");
                        this.rptReportes.RefreshReport();
                    }
                    else
                    {
                        rep = new csReportes();
                        consulta = "select Marca,MONTH(Fecha_Compra) as Mes,Sum(Precio_Compra) as Compra " +
                            "from Vehiculos where year(Fecha_Compra)=" + tscbxFiltro1.Text +
                            " group by Marca,MONTH(Fecha_Compra)";
                        rep.GenerarReporteVentas(rptReportes, consulta, "rptComprasMes", "dsComprasPorMarcaINF");
                        this.rptReportes.RefreshReport();
                    }

                    break;
                case 1:
                    if (tscbxFiltro2.SelectedIndex == 0)
                    {
                        rep = new csReportes();
                        consulta = "select Marca,month(Vn.Fecha_venta) as Mes,count(*) as Ventas " +
                            "from DetallesVenta D inner join Vehiculos V on D.Id_Vehiculo=V.Id_Vehiculo " +
                            "inner join Ventas Vn on Vn.Id_Venta=D.Id_Venta where YEAR(Vn.Fecha_venta)=" + tscbxFiltro1.Text +
                            " group by Marca,month(Vn.Fecha_venta),YEAR(Vn.Fecha_venta)";
                        rep.GenerarReporteVentas(rptReportes, consulta, "rptVentasMes", "dsVentasPorMarcaINF");
                        this.rptReportes.RefreshReport();
                    }
                    else
                    {
                        rep = new csReportes();
                        consulta = "select Marca,month(Vn.Fecha_venta) as Mes,sum(D.Precio) as Ventas " +
                            "from DetallesVenta D inner join Vehiculos V on D.Id_Vehiculo=V.Id_Vehiculo " +
                            "inner join Ventas Vn on Vn.Id_Venta=D.Id_Venta where YEAR(Vn.Fecha_venta)=" + tscbxFiltro1.Text +
                            " group by Marca,month(Vn.Fecha_venta),YEAR(Vn.Fecha_venta)";
                        rep.GenerarReporteVentas(rptReportes, consulta, "rptVentasMes", "dsVentasPorMarcaINF");
                        this.rptReportes.RefreshReport();
                    }
                    
                    break;
                case 2:
                    rep = new csReportes();
                    consulta = "select top(" + tscbxTops.Text + ")E.Nombres,month(V.Fecha_venta) as Mes,sum(D.Precio) as Venta " +
                        "from Empleados E inner join Ventas V on E.Id_Empleado=V.Id_Empleado " +
                        "inner join DetallesVenta D on V.Id_Venta=D.Id_Venta " +
                        "group by E.Nombres,month(V.Fecha_venta) " +
                        "order by Venta desc";
                    rep.GenerarReporteVentas(rptReportes, consulta, "rptEmpleadosTop", "dsEmpleadosTopINF");
                    this.rptReportes.RefreshReport();

                    break;
                case 3:
                    rep = new csReportes();
                    consulta = "select Month(Vn.Fecha_venta) as Mes,Sum(V.Precio_Compra) as Compra,sum(D.Precio) as Venta,(Sum(V.Precio_Compra) + sum(D.Precio) ) as Total " +
                        "from Vehiculos V inner join Ventas Vn on month(V.Fecha_Compra)=month(Vn.Fecha_venta) " +
                        "inner join DetallesVenta D on D.Id_Venta=Vn.Id_Venta " +
                        "group by Month(Vn.Fecha_venta)";
                    rep.GenerarReporteVentas(rptReportes, consulta, "rptCompraVenta", "dsCompraVentaINF");
                    this.rptReportes.RefreshReport();

                    break;
            }
            tsbtnBuscar.Enabled = false;

            tscbxFiltro1.Enabled = false;
            tscbxFiltro2.Enabled = false;
            tscbxTops.Enabled = false;

            tscbxReportes.Text = "-- Seleccionar --";
            tscbxFiltro1.Text = "-- Año --";
            tscbxFiltro2.Text = "-- Tipo --";
            tscbxTops.Text = "-- Tops --";
        }

        private void tscbxTops_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbtnBuscar.Enabled=true;
        }
    }
}
