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
    public partial class frmFacturasMantenimiento : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();
        public frmFacturasMantenimiento()
        {
            InitializeComponent();
        }

        private void frmFacturasMantenimiento_Load(object sender, EventArgs e)
        {
            dgvFacturasmantenimiento.DataSource = concesionaria.retornaTablaConsulta("select * from FacturaMantenimiento");
        }
    }
}
