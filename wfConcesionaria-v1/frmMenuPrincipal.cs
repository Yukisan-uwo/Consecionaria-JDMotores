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
    public partial class frmMenuPrincipal : Form
    {
        public string IDEmpleado;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            CerrarSubMenus();
        }
        public frmMenuPrincipal(bool admin)
        {
            InitializeComponent();
            CerrarSubMenus();

            if (admin == true)
            {
                btnAdministrador.Enabled = true;
            }
        }
        private void pnlLogo_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();
        }
        private void CerrarSubMenus()
        {
            pnlVentasSubMenu.Visible = false;
            pnlVehiculosSubmenu.Visible = false;
            pnlCobranzas.Visible = false;
            pnlClientesSubMenu.Visible = false;
            pnlAdministradorSubMenu.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if (pnlVentasSubMenu.Visible == true)
                pnlVentasSubMenu.Visible = false;
            if (pnlVehiculosSubmenu.Visible == true)
                pnlVehiculosSubmenu.Visible = false;
            if (pnlCobranzas.Visible == true)
                pnlCobranzas.Visible = false;
            if (pnlClientesSubMenu.Visible == true)
                pnlClientesSubMenu.Visible = false;
            if (pnlAdministradorSubMenu.Visible == true)
                pnlAdministradorSubMenu.Visible = false;
        }
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                EsconderSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        //  --------------------------------------------- VENTAS ----------------------------------------

        private void bntVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlVentasSubMenu);
        }
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmNuevaVenta Nueva = new frmNuevaVenta();
            Nueva.IDEmpleado = this.IDEmpleado;
            Nueva.TopLevel = false;
            Nueva.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(Nueva);
            Nueva.Show();
            EsconderSubMenu();
        }
        private void btnInfoVentas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmAdminVentas ventas = new frmAdminVentas();
            ventas.TopLevel = false;
            ventas.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(ventas);
            ventas.Show();
            EsconderSubMenu();
        }
        private void btnAdministarMantenimiento_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();
            frmAdministrarMantenimiento frmAdministrarMantenimiento = new frmAdministrarMantenimiento();
            frmAdministrarMantenimiento.TopLevel = false;
            frmAdministrarMantenimiento.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmAdministrarMantenimiento);
            frmAdministrarMantenimiento.Show();
            EsconderSubMenu();
        }
        //  --------------------------------------------- VEHICULOS ----------------------------------------

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlVehiculosSubmenu);
        }
        private void btnVerVehiculos_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmverVehiculos verVehiculos = new frmverVehiculos();
            verVehiculos.TopLevel = false;
            verVehiculos.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(verVehiculos);
            verVehiculos.Show();
            EsconderSubMenu();
        }
        //  --------------------------------------------- COBRANZAS ----------------------------------------

        private void btnCobranzas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCobranzas);
        }
        private void btnVerCobranzas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerCobranza cobranza = new frmVerCobranza();
            cobranza.TopLevel = false;
            cobranza.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(cobranza);
            cobranza.Show();
            EsconderSubMenu();
        }
        private void btnPagarCuotas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmPagarCuotas Pcuotas = new frmPagarCuotas();
            Pcuotas.TopLevel = false;
            Pcuotas.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(Pcuotas);
            Pcuotas.Show();
            EsconderSubMenu();
        }
        //  --------------------------------------------- CLIENTES ----------------------------------------

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlClientesSubMenu);
        }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frm_Ver__Cliente cliente = new frm_Ver__Cliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(cliente);
            cliente.Show();
            EsconderSubMenu();
        }
        //  --------------------------------------------- ADMIN ----------------------------------------

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlAdministradorSubMenu);
        }
        private void btnAdministrar_Empleados_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmAdministrar_Empleados empleados = new frmAdministrar_Empleados();
            empleados.IDEmpleado = this.IDEmpleado;
            empleados.TopLevel = false;
            empleados.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(empleados);
            empleados.Show();
            EsconderSubMenu();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerReportes ventas = new frmVerReportes();
            ventas.TopLevel = false;
            ventas.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(ventas);
            ventas.Show();
            EsconderSubMenu();
        }
        private void btnPromociones_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmControlPR controlPR = new frmControlPR();
            controlPR.TopLevel = false;
            controlPR.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(controlPR);
            controlPR.Show();
            EsconderSubMenu();
        }
        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
