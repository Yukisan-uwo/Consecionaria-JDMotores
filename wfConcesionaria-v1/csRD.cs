using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    internal class csRD
    {
        bdConcesionaria concesionaria;

        public SqlConnection conex;
        public SqlCommand comando;
        public SqlDataAdapter dataA;
        public DataTable dataT;
        public SqlDataReader dataR;

        static string cadena = "";

        public csRD()
        {
            concesionaria = new bdConcesionaria();
        }

        public DataTable tablaAdaptada(string cadena)
        {
            try
            {
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

        public bool agregar(string cadena)
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

        public bool eliminar(string cadena)
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
    }
}
