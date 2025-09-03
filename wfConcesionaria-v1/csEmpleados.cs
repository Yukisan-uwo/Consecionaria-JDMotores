using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace wfConcesionaria_v1
{
    internal class csEmpleados
    {
        bdConcesionaria concesionaria;

        public SqlConnection conex;
        public SqlCommand comando;
        public SqlDataAdapter dataA;
        public DataTable dataT;
        public SqlDataReader dataR;
        static string cadena = "";

        public csEmpleados()
        {
            concesionaria = new bdConcesionaria();
        }

        string id_Empleado;
        string nombre1;
        string nombre2;
        string apellido1;
        string apellido2;
        string fechaNacimineto;
        string correo;
        string telefono;
        string ciudad;
        string provincia;
        string salario;
        string comision;

        public string Id_Empleado
        {
            get { return id_Empleado; }
            set { id_Empleado = value; }
        }

        public string Nombre1
        {
            get { return nombre1; }
            set { nombre1 = value; }
        }

        public string Nombre2
        {
            get { return nombre2; }
            set { nombre2 = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public DataTable tablaAdaptada(string filtro = "")
        {
            try
            {
                // Para trabajar con la tabla de login se debe pasar como parametro "TablaULogin"
                if (filtro == "TablaULogin")
                {
                    cadena = "select * from ULogin";
                }
                else if (String.IsNullOrEmpty(filtro))
                {
                    cadena = "select E.Id_Empleado as Cedula, E.Nombres, E.Apellidos, E.Correo, E.Telefono, E.Salario, L.Rol, E.Comision " +
                                   "from Empleados as E inner join ULogin as L on E.Id_Empleado = L.Id_Empleado ";
                }
                else
                {
                    cadena = "select E.Id_Empleado as Cedula, E.Nombres, E.Apellidos, E.Correo, E.Telefono, E.Salario, L.Rol, E.Comision " +
                     "from Empleados as E inner join ULogin as L on E.Id_Empleado = L.Id_Empleado " +
                     "where E.Id_Empleado like '%" + filtro + "%' or E.Nombres like '%" + filtro + "%' or E.Apellidos like '%" + filtro + "%'";
                }

                concesionaria.abrirConexion();
                comando = new SqlCommand(cadena, concesionaria.oCon);
                dataA = new SqlDataAdapter(comando);
                dataT = new DataTable();
                dataA.Fill(dataT);
                concesionaria.cerrarConexion();

                return dataT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (concesionaria.oCon.State == ConnectionState.Open)
                    concesionaria.cerrarConexion();

                return null;
            }
        }

        public bool eliminarEmpleados(string cadena)
        {
            try
            {
                concesionaria.abrirConexion();
                comando = new SqlCommand(cadena, concesionaria.oCon);
                comando.ExecuteNonQuery();
                concesionaria.cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (concesionaria.oCon.State == ConnectionState.Open)
                    concesionaria.cerrarConexion();

                return false;

            }
        }

        public bool agregarEmpleado(string Sentencia)
        {
            try
            {
                concesionaria.abrirConexion();
                comando = new SqlCommand(Sentencia, concesionaria.oCon);
                comando.ExecuteNonQuery();
                concesionaria.cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (concesionaria.oCon.State == ConnectionState.Open)
                    concesionaria.cerrarConexion();

                return false;
            }
        }

        public SqlDataReader retornaDataDRConsulta(string Consulta)
        {
            concesionaria.abrirConexion();
            comando = new SqlCommand(Consulta, concesionaria.oCon);
            dataR = comando.ExecuteReader();
            return dataR;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            concesionaria.abrirConexion();
            comando = new SqlCommand(Sentencia, concesionaria.oCon);
            comando.ExecuteNonQuery();
            concesionaria.cerrarConexion();
            return true;
        }

        public string Encriptar(string usuario, string contrasenia)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(contrasenia);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(usuario));
            tripledes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            string cifrado = Convert.ToBase64String(result);

            return cifrado;
        }

        public string Desencripta(string Usuario, string Contrasenia)
        {
            byte[] encryptedData = Convert.FromBase64String(Contrasenia);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Usuario));
            tripledes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            string desencriptado = UTF8Encoding.UTF8.GetString(result);
            return desencriptado;
        }
    }
}
