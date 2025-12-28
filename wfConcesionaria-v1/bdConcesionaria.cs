using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace InterfacesConcesionaria
{
    internal class bdConcesionaria
    {
        public SqlConnection oCon;
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;
        public DataTable oDT;

        string Server;
        string Database;
        string Usuario;
        string Clave;
        string Cadena;

        public bdConcesionaria()
        {
            Server = "STEVEN\\SQLSTEV";
            Database = "Concesionaria2";
            Usuario = "sa";
            Clave = "12345";
        }

        public bdConcesionaria(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();
            try
            {
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion no establecida.");
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            oCon.Close();
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            abrirConexion();
            oCom = new SqlCommand(Sentencia, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }
        public int retornaEnteroConsulta(string Consulta)
        {
            int temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }
        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public DataTable retornaTablaConsulta(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                abrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                cerrarConexion();
            }
            return oDT;
        }
        public DataTable retornaTablaFiltro(string Seleccion, string Tabla, string Condicion)
        {
            abrirConexion();
            Cadena = "select " + Seleccion + " from " + Tabla + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDA = new SqlDataAdapter(oCom);
            oDT = new DataTable();
            oDA.Fill(oDT);
            cerrarConexion();
            return oDT;
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

        public SqlDataReader retornaDataDRConsulta(string Consulta)
        {
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            return oDR;
        }
    }
}
