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
    public partial class frmAgregarKits : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();
        public frmAgregarKits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            concesionaria.ejecutarSQL("insert into Tabla_Kits (Kit,Unidades,Precio_Kit) values ('"+txtNuevoKit.Text+"',"+txtUnidadesKit.Text+",'"+txtPrecioKit.Text+"')");
            MessageBox.Show("Agregado correctamente");
            txtNuevoKit.Text = "";
            txtUnidadesKit.Text = "";
            txtPrecioKit.Text = "";
        }
    }
}
