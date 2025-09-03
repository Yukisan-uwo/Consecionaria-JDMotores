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
    public partial class frm_Agregar_Cliente_ : Form
    {
        static csClientes clientes = new csClientes();

        static string cadena = "";

        public frm_Agregar_Cliente_()
        {
            InitializeComponent();
        }

        private void btnAgregar_Cliente_Click(object sender, EventArgs e)
        {
            clientes.Id_cliente = txtCedula.Text.Trim();

            if (clientes.ValidarCedulaEcuatoriana())
            {
                if(txtTelefono.Text.Trim().Length == 10 && txtTelefono.Text.All(char.IsDigit) && !String.IsNullOrEmpty(txtPrimer_Nombre.Text) && !String.IsNullOrEmpty(txtSegundo_Nombre.Text)
                    && !String.IsNullOrEmpty(txtPrimer_Apellido.Text) && !String.IsNullOrEmpty(txtSegundo_Apellido.Text) && !String.IsNullOrEmpty(txtCiudad.Text)
                    && !String.IsNullOrEmpty(txtProvincia.Text) && !string.IsNullOrEmpty(txtCorreo.Text))
                {
                    try
                    {
                        clientes.Id_cliente = txtCedula.Text;
                        clientes.Nombre1 = txtPrimer_Nombre.Text;
                        clientes.Nombre2 = txtSegundo_Nombre.Text;
                        clientes.Apellido1 = txtPrimer_Apellido.Text;
                        clientes.Apellido2 = txtSegundo_Apellido.Text;
                        clientes.Correo = txtCorreo.Text;
                        clientes.Ciudad = txtCiudad.Text;
                        clientes.Provincia = txtProvincia.Text;
                        clientes.Telefono = txtTelefono.Text;

                        clientes.agregarClientes();
                        MessageBox.Show("Cliente agregado correctamente");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos no son correctos");
                }
            }
            else
            {
                MessageBox.Show("La cédula es inválida.");
            }





            //if (!(String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtPrimer_Nombre.Text) || String.IsNullOrEmpty(txtSegundo_Nombre.Text) ||
            //    String.IsNullOrEmpty(txtPrimer_Apellido.Text) || String.IsNullOrEmpty(txtSegundo_Apellido.Text) || String.IsNullOrEmpty(txtCiudad.Text) ||
            //    String.IsNullOrEmpty(txtProvincia.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtCorreo.Text)))
            //{

            //    if (valido)
            //    {
            //        try
            //        {
            //            clientes.Id_cliente = txtCedula.Text;
            //            clientes.Nombre1 = txtPrimer_Nombre.Text;
            //            clientes.Nombre2 = txtSegundo_Nombre.Text;
            //            clientes.Apellido1 = txtPrimer_Apellido.Text;
            //            clientes.Apellido2 = txtSegundo_Apellido.Text;
            //            clientes.Correo = txtCorreo.Text;
            //            clientes.Ciudad = txtCiudad.Text;
            //            clientes.Provincia = txtProvincia.Text;
            //            clientes.Telefono = txtTelefono.Text;

            //            clientes.agregarClientes();
            //            MessageBox.Show("Cliente agregado correctamente");
            //            this.Close();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //            clientes.cerrarConexion();
            //        }
            //    }
            //    else
            //        MessageBox.Show("Valores númericos incorrectos");
            //}
            //else
            //    MessageBox.Show("Deben ingresarse todos los datos");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
