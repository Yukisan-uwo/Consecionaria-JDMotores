using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace wfConcesionaria_v1
{
    public partial class frm_Ver__Cliente : Form
    {
        static csClientes clientes = new csClientes();
        static string cadena = "";

        int ClientexPag = 40;
        int Bandera = 0;

        public frm_Ver__Cliente()
        {
            InitializeComponent();
        }

        private void frm_Ver__Cliente_Load(object sender, EventArgs e)
        {
            dgvMostrar_Clientes.Font = new Font("Tahoma", 11);

            dgvMostrar_Clientes.DataSource = clientes.tablaAdaptada();
        }        

        private void txtfiltroo_TextChanged(object sender, EventArgs e)
        {
            

            dgvMostrar_Clientes.DataSource = clientes.tablaAdaptada(txtfiltroo.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm_Agregar_Cliente_ cliente = new frm_Agregar_Cliente_();
            cliente.ShowDialog();
            txtfiltroo.Text = "";
            dgvMostrar_Clientes.DataSource = clientes.tablaAdaptada();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Id_Cliente = dgvMostrar_Clientes.CurrentRow.Cells[0].Value.ToString();
            string x = dgvMostrar_Clientes.CurrentRow.Cells[1].Value.ToString();
            string[] nombres = x.Split(' ');
            string xx = dgvMostrar_Clientes.CurrentRow.Cells[2].Value.ToString();
            string[] apellidos = xx.Split(' ');
            string correo = dgvMostrar_Clientes.CurrentRow.Cells[3].Value.ToString();
            string ciudad = dgvMostrar_Clientes.CurrentRow.Cells[4].Value.ToString();
            string provincia = dgvMostrar_Clientes.CurrentRow.Cells[5].Value.ToString();
            string telefono = dgvMostrar_Clientes.CurrentRow.Cells[6].Value.ToString();

            frmModificar_Clientes cliente = new frmModificar_Clientes(Id_Cliente, nombres[0], nombres[1], apellidos[0], apellidos[1], correo, ciudad, provincia, telefono);
            cliente.ShowDialog();
            txtfiltroo.Text = "";
            dgvMostrar_Clientes.DataSource = clientes.tablaAdaptada();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar_Clientes.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvMostrar_Clientes.CurrentRow.Index + ", que pertenece al cliente " + dgvMostrar_Clientes[0, dgvMostrar_Clientes.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    string envio = dgvMostrar_Clientes.CurrentRow.Cells[0].Value.ToString();
                    clientes.Id_cliente = envio;
                    clientes.eliminarCliente();

                    txtfiltroo.Text = "";
                    dgvMostrar_Clientes.DataSource = clientes.tablaAdaptada();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(Imprimir);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            printPreviewDialog.ShowDialog();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            int y = 200;
            int ajuste = 50;
            e.Graphics.DrawImage(imlLista1.Images[0], new RectangleF(75, 15, imlLista1.Images[0].Width / 2, imlLista1.Images[0].Height / 2));

            Font fuente = new Font("Tahoma", 30, FontStyle.Bold | FontStyle.Underline);
            e.Graphics.DrawString("Concesionaria JDMOTORS", fuente, Brushes.DarkRed, new RectangleF(210, 55, 560, 50));

            fuente = new Font("Tahoma", 20, FontStyle.Bold);
            e.Graphics.DrawString("Listado de clientes", fuente, Brushes.Black, new RectangleF(300, 120, 350, 40));

            fuente = new Font("Tahoma", 15, FontStyle.Bold);
            e.Graphics.DrawString("Num", fuente, Brushes.Black, new RectangleF(ajuste+5, 170, 40, 30));
            e.Graphics.DrawString("Cédula", fuente, Brushes.Black, new RectangleF(ajuste + 55, 170, 100, 30));
            e.Graphics.DrawString("Nombres", fuente, Brushes.Black, new RectangleF(ajuste + 150, 170, 300, 30));
            e.Graphics.DrawString("Apellidos", fuente, Brushes.Black, new RectangleF(ajuste + 310, 170, 300, 30));
            e.Graphics.DrawString("Teléfono", fuente, Brushes.Black, new RectangleF(ajuste + 450, 170, 300, 20));
            e.Graphics.DrawString("Correo", fuente, Brushes.Black, new RectangleF(ajuste + 570, 170, 300, 20));

            fuente = new Font("Tahoma", 12, FontStyle.Regular);

            DataTable dt = clientes.tablaAdaptada();

            for (int i = 0; Bandera < dt.Rows.Count && i < ClientexPag; i++, Bandera++)
            {
                e.Graphics.DrawString((Bandera + 1).ToString(), fuente, Brushes.Black, new RectangleF(ajuste + 15, y, 40, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Cédula"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 55, y, 75, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Nombres"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 150, y, 300, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Apellidos"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 310, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Telefono"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 450, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Correo"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 570, y, 150, 20));
                y += 20;
            }
            e.HasMorePages = Bandera < dt.Rows.Count;
            Bandera = 0;
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrar_Clientes.CurrentRow != null)
                {
                    string correo = dgvMostrar_Clientes.CurrentRow.Cells[5].Value.ToString();
                    frmCorreo frmcorreo = new frmCorreo(correo);
                    frmcorreo.ShowDialog();
                }
                else
                    MessageBox.Show("No se a seleccionado ninguna fila");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
