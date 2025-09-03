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
    public partial class frmControlPR : Form
    {
        csRD rd = new csRD();
        static string cadena = "";

        public frmControlPR()
        {
            InitializeComponent();
        }

        private void frmControlPR_Load(object sender, EventArgs e)
        {
            cadena = "select d.Nombre, D.Fecha_Inicio, D.Fecha_Fin, D.Descuento from Descuentos as D";
            dgvDescuentos.DataSource = rd.tablaAdaptada(cadena);

            cadena = "Select regalo from Regalos";
            dgvRegalos.DataSource = rd.tablaAdaptada(cadena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtFechaInicio.Text) && !String.IsNullOrEmpty(txtFechaFin.Text) && !String.IsNullOrEmpty(txtDescuento.Text))
            {
                try
                {
                    decimal n = Convert.ToDecimal(txtDescuento.Text);
                    cadena = "Insert into Descuentos (Nombre, Fecha_Inicio, Fecha_Fin, Descuento) values ('" + txtNombre.Text + "', '" + txtFechaInicio.Text + "', '" + txtFechaFin.Text + "', " + n + ")";
                    rd.agregar(cadena);
                    MessageBox.Show("Descuento agregado correctamente");
                    cadena = "select d.Nombre, D.Fecha_Inicio, D.Fecha_Fin, D.Descuento from Descuentos as D";
                    dgvDescuentos.DataSource = rd.tablaAdaptada(cadena);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Todos los deben estar llenos");

            txtNombre.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            txtDescuento.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            txtFechaInicio.Text = fecha.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker2.Value;
            txtFechaFin.Text = fecha.ToString("yyyy-MM-dd");
        }

        private void btnEliminarDes_Click(object sender, EventArgs e)
        {
            if (dgvDescuentos.Rows.Count >= 0)
            {
                cadena = "delete Descuentos where Nombre = '" + txtNombre.Text + "'";
                rd.eliminar(cadena);
                cadena = "select d.Nombre, D.Fecha_Inicio, D.Fecha_Fin, D.Descuento from Descuentos as D";
                dgvDescuentos.DataSource = rd.tablaAdaptada(cadena);
            }

            txtNombre.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            txtDescuento.Text = "";
        }

        private void dgvDescuentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvDescuentos.CurrentRow.Cells[0].Value.ToString();
            txtFechaInicio.Text = dgvDescuentos.CurrentRow.Cells[1].Value.ToString();
            txtFechaFin.Text = dgvDescuentos.CurrentRow.Cells[2].Value.ToString();
            txtDescuento.Text = dgvDescuentos.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAgregarRegalo_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtRegalo.Text))
            {
                cadena = "Insert into Regalos(Regalo) values ('"+ txtRegalo.Text +"')";
                rd.agregar(cadena);
                txtRegalo.Text = "";
                cadena = "Select regalo from Regalos";
                dgvRegalos.DataSource = rd.tablaAdaptada(cadena);
            }
        }

        private void dgvRegalos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegalo.Text = dgvRegalos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEliminarRegalo_Click(object sender, EventArgs e)
        {
            if (dgvRegalos.Rows.Count >= 0)
            {
                cadena = "delete Regalos where Regalo = '" + txtRegalo.Text + "'";
                rd.eliminar(cadena);
                cadena = "select Regalo from Regalos ";
                dgvRegalos.DataSource = rd.tablaAdaptada(cadena);
            }
        }
    }
}
