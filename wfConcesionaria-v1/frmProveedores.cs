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
    public partial class frmProveedores : Form
    {
        //static bdConcesionaria concesionaria = new bdConcesionaria("CARLOS", "ConcesionariaPrueba", "User", "12345");
        Vehiculo Vehiculo;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cadena = "insert into Proveedores(Nombre, Telefono, Ciudad) Values ('"+txtNuevoProveedor.Text+"', '"+txtTelefono.Text+"', '"+txtCiudad.Text+"')";
            //concesionaria.ejecutarSQL(cadena);
            //MessageBox.Show("Proveedor '" + txtNuevoProveedor.Text + "' agregado correctamente.");
            Vehiculo = new Vehiculo();
            Vehiculo.Agrega_proveedordata(txtNuevoProveedor.Text, txtTelefono.Text, txtCiudad.Text);
            this.Close();
        }
    }
}
