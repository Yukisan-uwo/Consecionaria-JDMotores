using InterfacesConcesionaria;
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
using System.Windows.Forms;
using System.Media;

namespace wfConcesionaria_v1
{
    public partial class frmLogin : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();


        public string IDEmpleado;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
            label1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtContraseña.Text.Trim());
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(txtUsuario.Text.Trim()));
            tripledes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            string cifrado = Convert.ToBase64String(result);

            string cadena = "Select * from ULogin where Usuario = '" + txtUsuario.Text.Trim() + "' and Contrasenia = '" + cifrado.Trim() + "'";

            SqlDataReader linea = concesionaria.retornaDataDRConsulta(cadena);


            if (!(String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtContraseña.Text)))
            {
                if (linea.Read())
                {
                    IDEmpleado = linea["Id_Empleado"].ToString().Trim();
                    if (linea["Usuario"].ToString().Trim() == txtUsuario.Text.Trim() && linea["Contrasenia"].ToString().Trim() == cifrado.Trim())
                    {
                        bool admin = false;

                        if (linea["Rol"].ToString() == "Admin")
                        {
                            MessageBox.Show("Admin");

                            try
                            {
                                this.Hide();
                                admin = true;
                                frmMenuPrincipal menu = new frmMenuPrincipal(admin);
                                menu.IDEmpleado = this.IDEmpleado;
                                menu.ShowDialog();
                                this.Show();
                                txtContraseña.Text = "";
                                txtUsuario.Text = "";
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Empleado");

                            try
                            {
                                this.Hide();
                                frmMenuPrincipal menu = new frmMenuPrincipal(admin);
                                menu.IDEmpleado = this.IDEmpleado;
                                menu.ShowDialog();
                                this.Show();
                                txtContraseña.Text = "";
                                txtUsuario.Text = "";
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message); 
                            }
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Usuario o contraseña incorrectos");
                    string mensaje = "⚠️ Usuario o contraseña incorrectos";
                    label1.Text = mensaje;
                    label1.Visible = true;
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                string mensaje = "⚠️ Todos los campos deben estar ingresados";
                label1.Text = mensaje;
                label1.Visible = true;
                SystemSounds.Exclamation.Play();
            }

            concesionaria.cerrarConexion();
        }

        private void txtBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private bool mostrarContrasenia = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mostrarContrasenia = !mostrarContrasenia;

            if(mostrarContrasenia)
            {
                txtContraseña.PasswordChar = '\0';
                pbxOcultar_Clave.Image = wfConcesionaria_v1.Properties.Resources.invisible_2;
            }
            else
            {
                txtContraseña.PasswordChar = '*';
                pbxOcultar_Clave.Image = wfConcesionaria_v1.Properties.Resources.ojo;
            }
        }
    }
}
