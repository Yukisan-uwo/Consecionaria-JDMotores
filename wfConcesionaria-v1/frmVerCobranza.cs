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
    public partial class frmVerCobranza : Form
    {
        public frmVerCobranza()
        {
            InitializeComponent();
        }
        private void frmVerCobranza_Load(object sender, EventArgs e)
        {
            csCobranzas cobranzas = new csCobranzas();
            dgvCobranzas.DataSource = cobranzas.RetornarTabla();
        }
        private void tbtnModificar_Click(object sender, EventArgs e)
        {
            csCobranzas Cobranzas = new csCobranzas();
            frmModificarCobranza modificar = new frmModificarCobranza();
            string filtro = dgvCobranzas.CurrentRow.Cells[1].Value.ToString();
            modificar.Datos = Cobranzas.RetornarDatosConsulta("select * from Cobranzas where Id_Venta=" + filtro);
            modificar.ShowDialog();
            frmVerCobranza_Load(sender,e);
        }
        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text.Length >= 4)
            {
                string filtro = " where Id_Cliente like ('%"+ txtFiltro.Text + "%') or Factura like ('%" + txtFiltro.Text + "%') or Id_Vehiculo like ('%"+txtFiltro.Text+"%')";
                csCobranzas cobranzas = new csCobranzas();
                dgvCobranzas.DataSource = cobranzas.RetornarTablaFiltro(filtro);
            }
            if (txtFiltro.Text.Length < 4)
            {
                csCobranzas cobranzas = new csCobranzas();
                dgvCobranzas.DataSource = cobranzas.RetornarTabla();
            }
        }

        private void tbtnInfo_Click(object sender, EventArgs e)
        {
            ttpFiltros.IsBalloon = true;
            ttpFiltros.Show("Filtrado por:\nId_Cliente\nFactura\nId_Vehiculo",txtFiltro.Control, txtFiltro.Width/2, txtFiltro.Height - 60,3000);
        }

        private void tbtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = " where Id_Cliente like ('%" + txtFiltro.Text + "%') or Factura like ('%" + txtFiltro.Text + "%') or Id_Vehiculo like ('%" + txtFiltro.Text + "%')";
            csCobranzas cobranzas = new csCobranzas();
            dgvCobranzas.DataSource = cobranzas.RetornarTablaFiltro(filtro);
            frmVerCobranza_Load(sender, e);
        }
    }
}
