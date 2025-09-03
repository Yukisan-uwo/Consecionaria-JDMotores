using InterfacesConcesionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfConcesionaria_v1
{
    public partial class frmAdministrar_Empleados : Form
    {
        static csEmpleados csEmpleados = new csEmpleados();
        static string cadena = "";

        public string IDEmpleado;

        int ClientexPag = 40;
        int Bandera = 0;

        public frmAdministrar_Empleados()
        {
            InitializeComponent();
        }

        private void frmAdministrar_Empleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = csEmpleados.tablaAdaptada();
        }

        private void txtfiltroo_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = csEmpleados.tablaAdaptada(txtfiltroo.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(IDEmpleado == dgvEmpleados.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("No se puede modificar el perfil porque es con el que se inicio la sesión");
            }
            else
            {
                string ID_Empleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();

                Modificar_Empleados mod = new Modificar_Empleados(ID_Empleado);
                mod.ShowDialog();

                dgvEmpleados.DataSource = csEmpleados.tablaAdaptada();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar_Empleados frm = new frmAgregar_Empleados();
            frm.ShowDialog();
            txtfiltroo.Text = "";

            dgvEmpleados.DataSource = csEmpleados.tablaAdaptada();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDEmpleado == dgvEmpleados.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("No se puede eliminar el perfil porque es con el que se inicio la sesión");
            }
            else
            {
                if (dgvEmpleados.RowCount > 0)
                {
                    DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvEmpleados.CurrentRow.Index + ", que pertenece al cliente " + dgvEmpleados[0, dgvEmpleados.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (opc == DialogResult.Yes)
                    {
                        string ID_Empleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();

                        cadena = "delete ULogin where Id_Empleado = '" + ID_Empleado + "'";

                        csEmpleados.eliminarEmpleados(cadena);

                        cadena = "delete Empleados where Id_Empleado = '" + ID_Empleado + "'";

                        csEmpleados.eliminarEmpleados(cadena);

                        dgvEmpleados.DataSource = csEmpleados.tablaAdaptada();
                    }
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
            int ajuste = 15;
            e.Graphics.DrawImage(imlLista1.Images[0], new RectangleF(75, 15, imlLista1.Images[0].Width / 2, imlLista1.Images[0].Height / 2));

            Font fuente = new Font("Tahoma", 30, FontStyle.Bold | FontStyle.Underline);
            e.Graphics.DrawString("Concesionaria JDMOTORS", fuente, Brushes.DarkRed, new RectangleF(210, 55, 560, 50));

            fuente = new Font("Tahoma", 20, FontStyle.Bold);
            e.Graphics.DrawString("Listado de Empleados", fuente, Brushes.Black, new RectangleF(270, 120, 350, 40));

            fuente = new Font("Tahoma", 15, FontStyle.Bold);
            e.Graphics.DrawString("Num", fuente, Brushes.Black, new RectangleF(ajuste + 5, 170, 40, 30));
            e.Graphics.DrawString("Cedula", fuente, Brushes.Black, new RectangleF(ajuste + 55, 170, 100, 30));
            e.Graphics.DrawString("Nombres", fuente, Brushes.Black, new RectangleF(ajuste + 160, 170, 300, 30));
            e.Graphics.DrawString("Apellidos", fuente, Brushes.Black, new RectangleF(ajuste + 310, 170, 300, 30));
            e.Graphics.DrawString("salario", fuente, Brushes.Black, new RectangleF(ajuste + 450, 170, 300, 20));
            e.Graphics.DrawString("Correo", fuente, Brushes.Black, new RectangleF(ajuste + 540, 170, 300, 20));
            e.Graphics.DrawString("Rol", fuente, Brushes.Black, new RectangleF(ajuste + 710, 170, 300, 20));

            fuente = new Font("Tahoma", 12, FontStyle.Regular);
            DataTable dt = csEmpleados.tablaAdaptada();
            DataTable dt2 = csEmpleados.tablaAdaptada("TablaULogin");
            for (int i = 0; Bandera < dt.Rows.Count && i < ClientexPag; i++, Bandera++)
            {
                e.Graphics.DrawString((Bandera + 1).ToString(), fuente, Brushes.Black, new RectangleF(ajuste + 15, y, 40, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Cedula"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 55, y, 100, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Nombres"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 160, y, 300, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Apellidos"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 310, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Salario"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 450, y, 150, 20));
                e.Graphics.DrawString(dt.Rows[Bandera]["Correo"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 540, y, 150, 20));
                e.Graphics.DrawString(dt2.Rows[Bandera]["Rol"].ToString().Trim(), fuente, Brushes.Black, new RectangleF(ajuste + 710, y, 150, 20));
                y += 20;
            }
            e.HasMorePages = Bandera < dt.Rows.Count;
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            string correo = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();

            frmCorreo frmcorreo = new frmCorreo(correo);
            frmcorreo.ShowDialog();
        }
    }
}
