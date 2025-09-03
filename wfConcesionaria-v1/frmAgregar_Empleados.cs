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
    public partial class frmAgregar_Empleados : Form
    {
        static csEmpleados csEmpleados = new csEmpleados();
        static string cadena = "";

        public frmAgregar_Empleados()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            txtF_Nacimiento.Text = fecha.ToString("yyyy-MM-dd");
        }

        private void btnAgregar_Empleados_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtID_Empleado.Text) || String.IsNullOrEmpty(cbxRol.Text) || String.IsNullOrEmpty(txtPrimer_Nombre.Text) || String.IsNullOrEmpty(txtSegun_Nombre.Text) || String.IsNullOrEmpty(txtPrimer_Apellido.Text) || String.IsNullOrEmpty(txtSegun_Apellido.Text) ||
                String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtCiudad.Text) || String.IsNullOrEmpty(txtSalario.Text) || String.IsNullOrEmpty(txtUsuario.Text) ||
                String.IsNullOrEmpty(txtContrasenia.Text) || String.IsNullOrEmpty(txtF_Nacimiento.Text)))
            {
                bool valido = txtID_Empleado.Text.All(char.IsDigit) && txtTelefono.Text.All(char.IsDigit) && txtSalario.Text.All(c => char.IsDigit(c) || c == '.');

                if (valido)
                {
                    try
                    {
                        string nombre = txtPrimer_Nombre.Text + " " + txtSegun_Nombre.Text;
                        string apellido = txtPrimer_Apellido.Text + " " + txtSegun_Apellido.Text;
                        double convert = Convert.ToDouble(txtSalario.Text);
                        string encrip = csEmpleados.Encriptar(txtUsuario.Text, txtContrasenia.Text);

                        
                        cadena = "INSERT INTO Empleados(Id_Empleado, Nombres, Apellidos, Fecha_Nacimiento, Correo, Telefono, Ciudad, Provincia, Salario)" +
                            "VALUES ('" + txtID_Empleado.Text + "', '" + nombre + "', '" + apellido + "', '" + txtF_Nacimiento.Text + "', " +
                            "'" + txtCorreo.Text + "', '" + txtTelefono.Text + "', '" + txtCiudad.Text + "', '"+ txtProvincia.Text +"', " + convert + ")";

                        csEmpleados.agregarEmpleado(cadena);

                        cadena = "INSERT INTO ULogin (Id_Empleado, Usuario, Contrasenia, Rol)" +
                            "VALUES ('" + txtID_Empleado.Text + "', '" + txtUsuario.Text + "', '" + encrip + "', '" + cbxRol.Text + "')";

                        csEmpleados.agregarEmpleado(cadena);

                        MessageBox.Show("Agregado Correctamente");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Los datos números son incorrectos");
                
            }
            else
                MessageBox.Show("Deben llenarse todos los campos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
