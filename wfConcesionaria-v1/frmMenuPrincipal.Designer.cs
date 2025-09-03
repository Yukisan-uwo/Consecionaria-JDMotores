namespace wfConcesionaria_v1
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlAdministradorSubMenu = new System.Windows.Forms.Panel();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.pnlClientesSubMenu = new System.Windows.Forms.Panel();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlCobranzas = new System.Windows.Forms.Panel();
            this.btnPagarCuotas = new System.Windows.Forms.Button();
            this.btnVerCobranzas = new System.Windows.Forms.Button();
            this.btnCobranzas = new System.Windows.Forms.Button();
            this.pnlVehiculosSubmenu = new System.Windows.Forms.Panel();
            this.btnVerVehiculos = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.pnlVentasSubMenu = new System.Windows.Forms.Panel();
            this.btnAdministrarMantenimiento = new System.Windows.Forms.Button();
            this.btnInfoVentas = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.bntVentas = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdministradorSubMenu.SuspendLayout();
            this.pnlClientesSubMenu.SuspendLayout();
            this.pnlCobranzas.SuspendLayout();
            this.pnlVehiculosSubmenu.SuspendLayout();
            this.pnlVentasSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.AutoScroll = true;
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.pnlBotones.Controls.Add(this.panel1);
            this.pnlBotones.Controls.Add(this.pnlAdministradorSubMenu);
            this.pnlBotones.Controls.Add(this.btnAdministrador);
            this.pnlBotones.Controls.Add(this.pnlClientesSubMenu);
            this.pnlBotones.Controls.Add(this.btnClientes);
            this.pnlBotones.Controls.Add(this.pnlCobranzas);
            this.pnlBotones.Controls.Add(this.btnCobranzas);
            this.pnlBotones.Controls.Add(this.pnlVehiculosSubmenu);
            this.pnlBotones.Controls.Add(this.btnVehiculos);
            this.pnlBotones.Controls.Add(this.pnlVentasSubMenu);
            this.pnlBotones.Controls.Add(this.bntVentas);
            this.pnlBotones.Controls.Add(this.pnlLogo);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(273, 640);
            this.pnlBotones.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 1021);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 72);
            this.panel1.TabIndex = 20;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::wfConcesionaria_v1.Properties.Resources.log_out_25;
            this.btnCerrarSesion.Location = new System.Drawing.Point(57, 14);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(155, 40);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlAdministradorSubMenu
            // 
            this.pnlAdministradorSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pnlAdministradorSubMenu.Controls.Add(this.btnPromociones);
            this.pnlAdministradorSubMenu.Controls.Add(this.btnReportes);
            this.pnlAdministradorSubMenu.Controls.Add(this.btnVerEmpleados);
            this.pnlAdministradorSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdministradorSubMenu.Location = new System.Drawing.Point(0, 854);
            this.pnlAdministradorSubMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdministradorSubMenu.Name = "pnlAdministradorSubMenu";
            this.pnlAdministradorSubMenu.Size = new System.Drawing.Size(256, 167);
            this.pnlAdministradorSubMenu.TabIndex = 19;
            // 
            // btnPromociones
            // 
            this.btnPromociones.BackColor = System.Drawing.Color.Transparent;
            this.btnPromociones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromociones.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromociones.Image = ((System.Drawing.Image)(resources.GetObject("btnPromociones.Image")));
            this.btnPromociones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromociones.Location = new System.Drawing.Point(0, 108);
            this.btnPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPromociones.Size = new System.Drawing.Size(256, 54);
            this.btnPromociones.TabIndex = 15;
            this.btnPromociones.Text = "Promociones";
            this.btnPromociones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromociones.UseVisualStyleBackColor = false;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 54);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(256, 54);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnVerEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEmpleados.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEmpleados.Image")));
            this.btnVerEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnVerEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVerEmpleados.Size = new System.Drawing.Size(256, 54);
            this.btnVerEmpleados.TabIndex = 13;
            this.btnVerEmpleados.Text = "Empleados";
            this.btnVerEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerEmpleados.UseVisualStyleBackColor = false;
            this.btnVerEmpleados.Click += new System.EventHandler(this.btnAdministrar_Empleados_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.Color.White;
            this.btnAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrador.Enabled = false;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Image = global::wfConcesionaria_v1.Properties.Resources.admin_50;
            this.btnAdministrador.Location = new System.Drawing.Point(0, 795);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(256, 59);
            this.btnAdministrador.TabIndex = 18;
            this.btnAdministrador.Text = "Admin";
            this.btnAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // pnlClientesSubMenu
            // 
            this.pnlClientesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pnlClientesSubMenu.Controls.Add(this.btnVerClientes);
            this.pnlClientesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientesSubMenu.Location = new System.Drawing.Point(0, 740);
            this.pnlClientesSubMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlClientesSubMenu.Name = "pnlClientesSubMenu";
            this.pnlClientesSubMenu.Size = new System.Drawing.Size(256, 55);
            this.pnlClientesSubMenu.TabIndex = 17;
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClientes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnVerClientes.Image")));
            this.btnVerClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClientes.Location = new System.Drawing.Point(0, 0);
            this.btnVerClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVerClientes.Size = new System.Drawing.Size(256, 50);
            this.btnVerClientes.TabIndex = 13;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::wfConcesionaria_v1.Properties.Resources.user_50;
            this.btnClientes.Location = new System.Drawing.Point(0, 681);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(256, 59);
            this.btnClientes.TabIndex = 16;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlCobranzas
            // 
            this.pnlCobranzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pnlCobranzas.Controls.Add(this.btnPagarCuotas);
            this.pnlCobranzas.Controls.Add(this.btnVerCobranzas);
            this.pnlCobranzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCobranzas.Location = new System.Drawing.Point(0, 578);
            this.pnlCobranzas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCobranzas.Name = "pnlCobranzas";
            this.pnlCobranzas.Size = new System.Drawing.Size(256, 103);
            this.pnlCobranzas.TabIndex = 15;
            // 
            // btnPagarCuotas
            // 
            this.btnPagarCuotas.BackColor = System.Drawing.Color.Transparent;
            this.btnPagarCuotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarCuotas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCuotas.Image = ((System.Drawing.Image)(resources.GetObject("btnPagarCuotas.Image")));
            this.btnPagarCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarCuotas.Location = new System.Drawing.Point(0, 50);
            this.btnPagarCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarCuotas.Name = "btnPagarCuotas";
            this.btnPagarCuotas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPagarCuotas.Size = new System.Drawing.Size(256, 50);
            this.btnPagarCuotas.TabIndex = 13;
            this.btnPagarCuotas.Text = "Pagar Cuotas";
            this.btnPagarCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagarCuotas.UseVisualStyleBackColor = false;
            this.btnPagarCuotas.Click += new System.EventHandler(this.btnPagarCuotas_Click);
            // 
            // btnVerCobranzas
            // 
            this.btnVerCobranzas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerCobranzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCobranzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCobranzas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCobranzas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCobranzas.Image")));
            this.btnVerCobranzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCobranzas.Location = new System.Drawing.Point(0, 0);
            this.btnVerCobranzas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerCobranzas.Name = "btnVerCobranzas";
            this.btnVerCobranzas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVerCobranzas.Size = new System.Drawing.Size(256, 50);
            this.btnVerCobranzas.TabIndex = 12;
            this.btnVerCobranzas.Text = "Ver Prestamos";
            this.btnVerCobranzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerCobranzas.UseVisualStyleBackColor = false;
            this.btnVerCobranzas.Click += new System.EventHandler(this.btnVerCobranzas_Click);
            // 
            // btnCobranzas
            // 
            this.btnCobranzas.BackColor = System.Drawing.Color.White;
            this.btnCobranzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCobranzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobranzas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobranzas.Image = global::wfConcesionaria_v1.Properties.Resources.calender_50;
            this.btnCobranzas.Location = new System.Drawing.Point(0, 519);
            this.btnCobranzas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCobranzas.Name = "btnCobranzas";
            this.btnCobranzas.Size = new System.Drawing.Size(256, 59);
            this.btnCobranzas.TabIndex = 14;
            this.btnCobranzas.Text = "Prestamos";
            this.btnCobranzas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCobranzas.UseVisualStyleBackColor = false;
            this.btnCobranzas.Click += new System.EventHandler(this.btnCobranzas_Click);
            // 
            // pnlVehiculosSubmenu
            // 
            this.pnlVehiculosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pnlVehiculosSubmenu.Controls.Add(this.btnVerVehiculos);
            this.pnlVehiculosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVehiculosSubmenu.Location = new System.Drawing.Point(0, 465);
            this.pnlVehiculosSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVehiculosSubmenu.Name = "pnlVehiculosSubmenu";
            this.pnlVehiculosSubmenu.Size = new System.Drawing.Size(256, 54);
            this.pnlVehiculosSubmenu.TabIndex = 13;
            // 
            // btnVerVehiculos
            // 
            this.btnVerVehiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVehiculos.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerVehiculos.Image")));
            this.btnVerVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVehiculos.Location = new System.Drawing.Point(0, 0);
            this.btnVerVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerVehiculos.Name = "btnVerVehiculos";
            this.btnVerVehiculos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVerVehiculos.Size = new System.Drawing.Size(256, 50);
            this.btnVerVehiculos.TabIndex = 12;
            this.btnVerVehiculos.Text = "Ver Vehiculos";
            this.btnVerVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerVehiculos.UseVisualStyleBackColor = false;
            this.btnVerVehiculos.Click += new System.EventHandler(this.btnVerVehiculos_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.White;
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.Image = global::wfConcesionaria_v1.Properties.Resources.carro;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 406);
            this.btnVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(256, 59);
            this.btnVehiculos.TabIndex = 12;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // pnlVentasSubMenu
            // 
            this.pnlVentasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pnlVentasSubMenu.Controls.Add(this.btnAdministrarMantenimiento);
            this.pnlVentasSubMenu.Controls.Add(this.btnInfoVentas);
            this.pnlVentasSubMenu.Controls.Add(this.btnNuevaVenta);
            this.pnlVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentasSubMenu.Location = new System.Drawing.Point(0, 253);
            this.pnlVentasSubMenu.Name = "pnlVentasSubMenu";
            this.pnlVentasSubMenu.Size = new System.Drawing.Size(256, 153);
            this.pnlVentasSubMenu.TabIndex = 11;
            // 
            // btnAdministrarMantenimiento
            // 
            this.btnAdministrarMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrarMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrarMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarMantenimiento.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrarMantenimiento.Image")));
            this.btnAdministrarMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrarMantenimiento.Location = new System.Drawing.Point(0, 100);
            this.btnAdministrarMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdministrarMantenimiento.Name = "btnAdministrarMantenimiento";
            this.btnAdministrarMantenimiento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdministrarMantenimiento.Size = new System.Drawing.Size(256, 50);
            this.btnAdministrarMantenimiento.TabIndex = 14;
            this.btnAdministrarMantenimiento.Text = "Administrar Mantenimiento";
            this.btnAdministrarMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrarMantenimiento.UseVisualStyleBackColor = false;
            this.btnAdministrarMantenimiento.Click += new System.EventHandler(this.btnAdministarMantenimiento_Click);
            // 
            // btnInfoVentas
            // 
            this.btnInfoVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoVentas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoVentas.Image")));
            this.btnInfoVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentas.Location = new System.Drawing.Point(0, 50);
            this.btnInfoVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoVentas.Name = "btnInfoVentas";
            this.btnInfoVentas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInfoVentas.Size = new System.Drawing.Size(256, 50);
            this.btnInfoVentas.TabIndex = 13;
            this.btnInfoVentas.Text = "Administrar Ventas";
            this.btnInfoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfoVentas.UseVisualStyleBackColor = false;
            this.btnInfoVentas.Click += new System.EventHandler(this.btnInfoVentas_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.Image")));
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNuevaVenta.Size = new System.Drawing.Size(256, 50);
            this.btnNuevaVenta.TabIndex = 12;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // bntVentas
            // 
            this.bntVentas.BackColor = System.Drawing.Color.White;
            this.bntVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntVentas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVentas.Image = global::wfConcesionaria_v1.Properties.Resources.imagen_venta_de_vehiculos_50;
            this.bntVentas.Location = new System.Drawing.Point(0, 194);
            this.bntVentas.Margin = new System.Windows.Forms.Padding(2);
            this.bntVentas.Name = "bntVentas";
            this.bntVentas.Size = new System.Drawing.Size(256, 59);
            this.bntVentas.TabIndex = 10;
            this.bntVentas.Text = "Ventas";
            this.bntVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntVentas.UseVisualStyleBackColor = false;
            this.bntVentas.Click += new System.EventHandler(this.bntVentas_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.pnlLogo.BackgroundImage = global::wfConcesionaria_v1.Properties.Resources.home_140;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(256, 194);
            this.pnlLogo.TabIndex = 1;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlContenedor.BackgroundImage = global::wfConcesionaria_v1.Properties.Resources.image_removebg_preview;
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(273, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(914, 640);
            this.pnlContenedor.TabIndex = 10;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 640);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBotones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuPrincipal_FormClosed);
            this.pnlBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlAdministradorSubMenu.ResumeLayout(false);
            this.pnlClientesSubMenu.ResumeLayout(false);
            this.pnlCobranzas.ResumeLayout(false);
            this.pnlVehiculosSubmenu.ResumeLayout(false);
            this.pnlVentasSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button bntVentas;
        private System.Windows.Forms.Panel pnlVentasSubMenu;
        private System.Windows.Forms.Button btnInfoVentas;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Panel pnlVehiculosSubmenu;
        private System.Windows.Forms.Button btnVerVehiculos;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Panel pnlCobranzas;
        private System.Windows.Forms.Button btnPagarCuotas;
        private System.Windows.Forms.Button btnVerCobranzas;
        private System.Windows.Forms.Button btnCobranzas;
        private System.Windows.Forms.Panel pnlClientesSubMenu;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlAdministradorSubMenu;
        private System.Windows.Forms.Button btnVerEmpleados;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAdministrarMantenimiento;
        private System.Windows.Forms.Button btnPromociones;
    }
}