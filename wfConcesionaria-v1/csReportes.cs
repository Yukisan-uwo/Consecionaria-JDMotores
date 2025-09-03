using InterfacesConcesionaria;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    internal class csReportes
    {
        public void GenerarReporteVentas(ReportViewer reporte,string consulta,string informe,string Tabla)
        {
            bdConcesionaria Con = new bdConcesionaria();
            ReportDataSource dataset;
            reporte.LocalReport.DataSources.Clear();
            DataTable dt = Con.retornaTablaConsulta(consulta);
            reporte.LocalReport.ReportEmbeddedResource = "wfConcesionaria_v1." + informe + ".rdlc";
            dataset = new ReportDataSource(Tabla, dt);
            reporte.LocalReport.DataSources.Add(dataset);
        }
    }
}
