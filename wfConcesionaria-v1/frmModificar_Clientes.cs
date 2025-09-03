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
    public partial class frmModificar_Clientes : Form
    {
        //static bdConcesionaria conexion = new bdConcesionaria("CARLOS", "ConcesionariaPrueba", "User", "12345");
        static csClientes clientes = new csClientes();
        static string cadena = "";

        string Id_Cliente;
        string nombres1;
        string nombres2; 
        string apellidos1;
        string apellidos2;
        string correo;
        string ciudad;
        string provincia;
        string telefono;

        public frmModificar_Clientes()
        {
            InitializeComponent();
        }

        public frmModificar_Clientes(string Id_Cliente, string nombres1, string nombres2, string apellidos1, string apellidos2, string ciudad, string provincia, string correo, string telefono)
        {
            InitializeComponent();

            this.Id_Cliente = Id_Cliente;
            this.nombres1 = nombres1;
            this.nombres2 = nombres2;
            this.apellidos1 = apellidos1;
            this.apellidos2 = apellidos2;
            this.correo = correo;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.telefono = telefono;

            txtCedula.Text = Id_Cliente;
            txtPrimer_Nombre.Text = nombres1;
            txtSegundo_Nombre.Text = nombres2;
            txtPrimer_Apellido.Text = apellidos1;
            txtSegundo_Apellido.Text = apellidos2;
            txtCorreo.Text = correo;
            txtCiudad.Text = ciudad;
            txtProvincia.Text = provincia;
            txtTelefono.Text = telefono;
        }

        private void btnAgregar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                clientes.Id_cliente = txtCedula.Text.Trim();

                if (clientes.ValidarCedulaEcuatoriana())
                {
                    if (txtTelefono.Text.Length == 10 && txtTelefono.Text.All(char.IsDigit) && !String.IsNullOrEmpty(txtPrimer_Nombre.Text.Trim()) && !String.IsNullOrEmpty(txtSegundo_Nombre.Text.Trim())
                        && !String.IsNullOrEmpty(txtPrimer_Apellido.Text.Trim()) && !String.IsNullOrEmpty(txtSegundo_Apellido.Text.Trim()) && !String.IsNullOrEmpty(txtCiudad.Text.Trim())
                        && !String.IsNullOrEmpty(txtProvincia.Text.Trim()) && !String.IsNullOrEmpty(txtTelefono.Text.Trim()) && !String.IsNullOrEmpty(txtCorreo.Text.Trim()))
                    {
                        clientes.Id_cliente = Id_Cliente;

                        string n = txtPrimer_Nombre.Text.Trim() + " " + txtSegundo_Nombre.Text.Trim();
                        string nn = nombres1 + " " + nombres2;
                        if (n != nn)
                            clientes.modificarCliente("Nombres", n);

                        string a = txtPrimer_Apellido.Text.Trim() + " " + txtSegundo_Apellido.Text.Trim();
                        string aa = apellidos1 + " " + apellidos2;
                        if(a != aa)
                            clientes.modificarCliente("Apellidos", a);

                        if (txtCorreo.Text.Trim() != correo)
                            clientes.modificarCliente("Correo", txtCorreo.Text.Trim());

                        if (txtCiudad.Text.Trim() != ciudad)
                            clientes.modificarCliente("Ciudad", txtCiudad.Text.Trim());

                        if (txtProvincia.Text.Trim() != provincia)
                            clientes.modificarCliente("Provincia", txtProvincia.Text.Trim());

                        if (txtTelefono.Text.Trim() != telefono)
                            clientes.modificarCliente("Telefono", txtTelefono.Text.Trim());

                        if (txtCedula.Text.Trim() != Id_Cliente)
                            clientes.modificarCliente("Id_Cliente", txtCedula.Text.Trim());

                        MessageBox.Show("Cambios relizados correctamente");

                        this.Close();
                    }
                    else
                        MessageBox.Show("Los datos no son correctos");
                }
                else
                {
                    MessageBox.Show("La cédula es inválida.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
