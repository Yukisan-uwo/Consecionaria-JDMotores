using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using InterfacesConcesionaria;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfConcesionaria_v1
{
    public partial class Modificar_Empleados : Form
    {
        static csEmpleados csEmpleados = new csEmpleados();
        static string cadena = "";

        string ID_Empleado;
        string Nombres1;
        string Nombres2; 
        string Apellidos1;
        string Apellidos2;
        string ciudad;
        string provincia;
        string correo;
        string telefono;
        string f_nacimiento;
        string f_contratacion;
        string salario;

        string usuario;
        string contrasenia;
        string rol;

        string des;

        public Modificar_Empleados()
        {
            InitializeComponent();
        }

        public Modificar_Empleados(string ID_Empleado)
        {
            InitializeComponent();

            SqlDataReader empleado = csEmpleados.retornaDataDRConsulta("select * from Empleados where Id_Empleado = '"+ ID_Empleado +"'");

            empleado.Read();

            string[] nombres = empleado["Nombres"].ToString().Split(' ');
            string[] apellidos = empleado["Apellidos"].ToString().Split(' ');

            this.ID_Empleado = ID_Empleado;
            this.Nombres1 = nombres[0];
            this.Nombres2 = nombres[1];
            this.Apellidos1 = apellidos[0];
            this.Apellidos2 = apellidos[1];
            this.f_nacimiento = empleado["Fecha_Nacimiento"].ToString();
            this.correo = empleado["Correo"].ToString();
            this.telefono = empleado["Telefono"].ToString();
            this.ciudad = empleado["Ciudad"].ToString();
            this.provincia = empleado["Provincia"].ToString();
            this.f_contratacion = empleado["Fecha_Contratacion"].ToString();
            this.salario = empleado["Salario"].ToString();

            SqlDataReader login = csEmpleados.retornaDataDRConsulta("select * from ULogin where Id_Empleado = '" + ID_Empleado + "'");
            login.Read();

            this.contrasenia = login["Contrasenia"].ToString();
            this.usuario = login["Usuario"].ToString();
            this.rol = login["Rol"].ToString();

            this.des = csEmpleados.Desencripta(this.usuario, this.contrasenia);

            txtID_Empleado.Text = ID_Empleado;
            txtPrimer_Nombre.Text = this.Nombres1;
            txtSegun_Nombre.Text = this.Nombres2;
            txtPrimer_Apellido.Text = this.Apellidos1;
            txtSegun_Apellido.Text = this.Apellidos2;
            txtF_Nacimiento.Text = this.f_nacimiento;
            txtCorreo.Text = this.correo;
            txtTelefono.Text = this.telefono;
            txtCiudad.Text = this.ciudad;
            txtProvincia.Text = this.provincia;
            txtContratacion.Text = this.f_contratacion;
            txtSalario.Text = this.salario;

            cbxRol.Text = this.rol;
            txtUsuario.Text = this.usuario;
            txtContrasenia.Text = this.des;
        }

        private void btnGuardar_Cambios_Click(object sender, EventArgs e)
        {
            string n = txtPrimer_Nombre.Text + " " + txtSegun_Nombre.Text;
            string nn = Nombres1 + " " + Nombres2;

            string a = txtPrimer_Apellido.Text + " " + txtSegun_Apellido.Text;
            string aa = Apellidos1 + " " + Apellidos2;

            if (rol != cbxRol.Text)
                csEmpleados.ejecutarSQL("Update " + "ULogin" + " set " + "Rol" + " = '" + cbxRol.Text + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (n != nn)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Nombres" + " = '" + n + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (a != aa)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Apellidos" + " = '" + a + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (correo != txtCorreo.Text)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Correo" + " = '" + txtCorreo.Text + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (telefono != txtTelefono.Text)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Telefono" + " = '" + txtTelefono.Text + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (ciudad != txtCiudad.Text)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Ciudad" + " = '" + txtCiudad.Text + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if(provincia != txtProvincia.Text)
                csEmpleados.ejecutarSQL("Update " + "Empleados" + " set " + "Provincia" + " = '" + txtProvincia.Text + "'" + " where " + "Id_Empleado" + " = '" + ID_Empleado + "'");

            if (salario != txtSalario.Text)
            {
                double con = Convert.ToDouble(txtSalario.Text);

                string modificar = "UPDATE Empleados SET Salario = " + con + " WHERE Id_Empleado = " + ID_Empleado + "";

                csEmpleados.ejecutarSQL(modificar);
            }


            if (usuario.Trim() != txtUsuario.Text.Trim() || des.Trim() != txtContrasenia.Text.Trim())
            {
                try
                {
                    string encrip = csEmpleados.Encriptar(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
                    csEmpleados.ejecutarSQL("Update " + "ULogin" + " set " + "Usuario" + " = '" + txtUsuario.Text + "'" + " where " + "Usuario" + " = '" + usuario + "'");
                    csEmpleados.ejecutarSQL("Update " + "ULogin" + " set " + "Contrasenia" + " = '" + encrip + "'" + " where " + "Contrasenia" + " = '" + contrasenia + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (txtID_Empleado.Text != ID_Empleado)
            {
                string modificar = "ALTER TABLE ULogin NOCHECK CONSTRAINT FK__ULogin__Id_Emple__628FA481;" +
                "UPDATE Empleados SET Id_Empleado = '" + txtID_Empleado.Text.Trim() + "' WHERE Id_Empleado = '" + ID_Empleado + "'; " +
                "UPDATE ULogin SET Id_Empleado = '" + txtID_Empleado.Text.Trim() + "' WHERE Id_Empleado = '" + ID_Empleado + "';" +
                "ALTER TABLE ULogin CHECK CONSTRAINT FK__ULogin__Id_Emple__628FA481;";

                csEmpleados.ejecutarSQL(modificar);
            }

            MessageBox.Show("Datos Modificados Correctamente");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
