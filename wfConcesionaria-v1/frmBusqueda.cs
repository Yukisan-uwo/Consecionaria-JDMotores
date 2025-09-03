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
    public partial class frmBusqueda : Form
    {
        bdConcesionaria concesionaria =new bdConcesionaria();
        string comando;
        string columnas;
        string datos;
        string tabla;
        bool vehiculo = false;
        public string Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public string Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }
        public string Datos { get { return datos; } }
        public string Tabla { set { tabla = value; } }
        public bool Vehiculo { set { vehiculo = value; } }
        public frmBusqueda()
        {
            InitializeComponent();
        }
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            string[] Filtros = columnas.Split(',');
            foreach (string col in Filtros)
            {
                cbxBuscar.Items.Add(col);
            }
            cbxBuscar.SelectedIndex = 0;
            dgvConsulta.DataSource = concesionaria.retornaTablaConsulta(comando);
            dgvConsulta.Font = new Font("Tahoma", 11);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = " where " + cbxBuscar.Text + " like ('%" + txtFiltro.Text + "%')";
            dgvConsulta.DataSource = concesionaria.retornaTablaConsulta(comando + condicion);
            dgvConsulta.Font = new Font("Tahoma", 11);
        }
        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string codi = dgvConsulta.CurrentRow.Cells[e.RowIndex].Value.ToString();

            if (e.RowIndex != -1)
            {
                for (int i = 0; i < dgvConsulta.ColumnCount; i++)
                {
                    datos += (dgvConsulta.Rows[e.RowIndex].Cells[i].Value.ToString()) + ",";
                }
                datos = datos.Substring(0, datos.Length-1);
                this.Close();
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Trim() == "")
                btnBuscar.Enabled = false;
            else btnBuscar.Enabled = true;
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text.Length >= 4)
            {
                string condicion;
                if (vehiculo)
                {
                    condicion = " and " + cbxBuscar.Text + " like ('%" + txtFiltro.Text + "%')";
                }
                else
                {
                    condicion = " where " + cbxBuscar.Text + " like ('%" + txtFiltro.Text + "%')";
                }
                dgvConsulta.DataSource = concesionaria.retornaTablaConsulta(comando + condicion);
                dgvConsulta.Font = new Font("Tahoma", 11);
            }
            if (txtFiltro.Text.Length < 4)
            {
                dgvConsulta.DataSource = concesionaria.retornaTablaConsulta(comando);
                dgvConsulta.Font = new Font("Tahoma", 11);
            }
            if (txtFiltro.Text.Length > 0)
            {
                if (txtFiltro.Text[txtFiltro.Text.Length - 1] == 39)
                {
                    txtFiltro.Text = txtFiltro.Text.Substring(0, txtFiltro.Text.Length - 1);
                }
            }
        }
    }
}
