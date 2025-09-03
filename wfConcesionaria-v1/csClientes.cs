using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using InterfacesConcesionaria;

namespace wfConcesionaria_v1
{
    internal class csClientes
    {
        bdConcesionaria concesionaria;

        public SqlConnection conex;
        public SqlCommand comando;
        public SqlDataAdapter dataA;
        public DataTable dataT;
        public SqlDataReader dataR;

        static string cadena = "";

        public csClientes()
        {
            concesionaria = new bdConcesionaria();
        }

        string id_Cliente;
        string nombre1;
        string nombre2;
        string apellido1;
        string apellido2;
        string correo;
        string ciudad;
        string provincia;
        string telefono;

        public string Id_cliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
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

        public DataTable tablaAdaptada(string filtro = "")
        {
            try
            {
                if (String.IsNullOrEmpty(filtro))
                    cadena = cadena = "select Id_Cliente as Cédula, Nombres, Apellidos, Ciudad, Provincia, Correo, Telefono from Clientes";
                else
                    cadena = "select Id_Cliente as Cédula, Nombres, Apellidos, Ciudad, Provincia, Correo, Telefono from Clientes " +
                        "where Id_Cliente like " + "'%" + filtro + "%'" + " or Nombres like '%" + filtro + "%'" + "or Apellidos like '%" + filtro + "%'";

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

        public bool agregarClientes()
        {
            try
            {
                concesionaria.abrirConexion();
                string nombres = nombre1.Trim() + " " + nombre2.Trim();
                string apellidos = apellido1.Trim() + " " + apellido2.Trim();
                cadena = "insert into Clientes (Id_Cliente, Nombres, Apellidos, Correo, Ciudad, Provincia, Telefono) " +
                "values ( '" + id_Cliente.Trim() + "', '" + nombres + "', '" + apellidos + "', '" + correo.Trim() + "', '" + ciudad.Trim() + "', '" + provincia.Trim() + "', '" + telefono.Trim() + "')";
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

        public bool eliminarCliente()
        {
            try
            {
                concesionaria.abrirConexion();
                cadena = "delete Clientes where Id_Cliente = '" + id_Cliente + "'";
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

        public bool modificarCliente(string campo, string nuevo)
        {
            try
            {
                concesionaria.abrirConexion();
                cadena = ("Update Clientes set " + campo + " = '" + nuevo + "' where Id_Cliente = '" + id_Cliente + "'");
                comando = new SqlCommand(cadena, concesionaria.oCon);
                comando.ExecuteNonQuery();
                concesionaria.cerrarConexion();
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                if (concesionaria.oCon.State == ConnectionState.Open)
                    concesionaria.cerrarConexion();

                return false;
            }
        }

        public bool ValidarCedulaEcuatoriana()
        {
            string cedula = id_Cliente;

            if (cedula.Length != 10 || !cedula.All(char.IsDigit))
            {
                return false;
            }

            int provincia = int.Parse(cedula.Substring(0, 2));

            if (provincia < 1 || provincia > 24)
            {
                return false;
            }

            int digitoVerificador = int.Parse(cedula.Substring(9, 1));

            int[] multiplicador = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula.Substring(i, 1));
                int mul = digito * multiplicador[i];

                suma += mul > 9 ? mul - 9 : mul;
            }

            int digitoC= 10 - (suma % 10);

            if (digitoC == 10)
            {
                digitoC = 0;
            }

            return digitoC == digitoVerificador;
        }

    }
}
