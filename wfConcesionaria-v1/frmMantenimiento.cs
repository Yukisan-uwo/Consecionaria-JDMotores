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
    public partial class frmMantenimiento : Form
    {
        bdConcesionaria concesionaria = new bdConcesionaria();

        string Placa;
        string Marca;
        string Modelo;
        string Año;
        string Id_Cliente;
        string Ultimo_Mantenimiento;
        string Proximo_Mantenimiento;
        public string cadena;
        public frmMantenimiento(string placa, string marca, string modelo, string año, string id_Cliente, string ultimo_Mantenimiento, string proximo_Mantenimiento)
        {
            InitializeComponent();
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.Id_Cliente = id_Cliente;
            this.Ultimo_Mantenimiento = ultimo_Mantenimiento;
            this.Proximo_Mantenimiento = proximo_Mantenimiento;

            txtPlaca.Text = Placa;
            txtMarca.Text = Marca;
            txtModelo.Text = Modelo;
            txtAño.Text = Año;
            txtCedulaCliente.Text = Id_Cliente;
            txtUltimoM.Text = ultimo_Mantenimiento.Trim();
            txtProximoM.Text = proximo_Mantenimiento.Trim();
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            txtTotalPagar.Text = "0.00";
            DataTable kit = concesionaria.retornaTablaConsulta("select Kit from Tabla_Kits");
            DataTable precio = concesionaria.retornaTablaConsulta("select Precio_Kit from Tabla_Kits");

            for (int i = 0; i < kit.Rows.Count; i++)
            {
                DataRow kitRow = kit.Rows[i];
                DataRow precioRow = precio.Rows[i];
                dgvKit.Rows.Add();
                dgvKit[0, i].Value = kitRow[0].ToString();
                dgvKit[1, i].Value = 0;
                dgvKit[4, i].Value = precioRow[0].ToString();
            }
        }

        private void dgvKit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int numero = int.Parse(dgvKit.Rows[e.RowIndex].Cells[1].Value.ToString());
                dgvKit.Rows[e.RowIndex].Cells[1].Value = (numero + 1).ToString();
            }

            if (int.Parse(dgvKit.Rows[e.RowIndex].Cells[1].Value.ToString()) > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    int numero = int.Parse(dgvKit.Rows[e.RowIndex].Cells[1].Value.ToString());
                    dgvKit.Rows[e.RowIndex].Cells[1].Value = (numero - 1).ToString();
                }
            }

            decimal totalPagar = 0;
            for (int i = 0; i < dgvKit.Rows.Count; i++)
            {
                int cantidad = int.Parse(dgvKit.Rows[i].Cells[1].Value.ToString());
                decimal precioUnitario = decimal.Parse(dgvKit.Rows[i].Cells[4].Value.ToString());
                decimal precioTotal = cantidad * precioUnitario;
                totalPagar += precioTotal;
            }
            txtTotalPagar.Text = totalPagar.ToString("0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            for (int i = 0; i < dgvKit.Rows.Count; i++)
            {
                if (int.Parse(dgvKit[1, i].Value.ToString()) > 0)
                {
                    cadena += dgvKit[0, i].Value.ToString() + " " + dgvKit[1, i].Value.ToString() + " " + dgvKit[4, i].Value.ToString() + ";";
                }
            }

            string f=txtProximoM.Text;
            string ProximoMantenimiento = "";
            string[] cadena1=f.Split('/');
            int f_mes=int.Parse(cadena1[1]);
            int año = int.Parse(cadena1[0]);
            if (f_mes + 6 > 12)
            {
                int n = f_mes + 6;
                int resultado = n - 12;
                año++;
                ProximoMantenimiento += año.ToString() + "/" + resultado.ToString() + "/" + cadena1[2];
            }
            else
            {
                int resultado = f_mes + 6;
                ProximoMantenimiento += año.ToString() + "/" + resultado.ToString() + "/" + cadena1[2];
            }

            DataTable dt = Verifica_Idvehiculo(txtPlaca.Text);

            string id = dt.Rows[0][0].ToString();
            string cadena2 = "update Tabla_Mantenimiento set Ultimo_Mantenimiento = '" + txtProximoM.Text + "', Proximo_Mantenimiento='" + ProximoMantenimiento + "' where Id_Vehiculo='" + int.Parse(id) + "'";
            concesionaria.ejecutarSQL(cadena2);
            string cadena3 = "insert into FacturaMantenimiento (Placa,Id_Cliente,Descripcion,PrecioTotal,Fecha_Mantenimiento,Proximo_Mantenimiento) values ('"+ txtPlaca.Text + "','"+txtCedulaCliente.Text+"','"+cadena+"',"+txtTotalPagar.Text+",'"+ txtProximoM.Text + "','"+ ProximoMantenimiento + "')";
            concesionaria.ejecutarSQL(cadena3);
            MessageBox.Show("Agregado correctamente");
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAño.Text = "";
            txtCedulaCliente.Text = "";
            txtUltimoM.Text = "";
            txtProximoM.Text = "";
        }

        private DataTable Verifica_Idvehiculo(string placa)
        {
            DataTable dt = concesionaria.retornaTablaConsulta("select Id_Vehiculo from Vehiculos where Placa='" + placa + "'");
            return dt;
        }
    }
}
