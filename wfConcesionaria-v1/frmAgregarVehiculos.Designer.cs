namespace wfConcesionaria_v1
{
    partial class frmAgregarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarVehiculos));
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.pnlVehiculos = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.cbTransmicion = new System.Windows.Forms.ComboBox();
            this.cbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnAggColor = new System.Windows.Forms.Button();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNoVin = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dgvColores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVehiculos.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(475, 694);
            this.btnAgregarVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(280, 63);
            this.btnAgregarVehiculo.TabIndex = 74;
            this.btnAgregarVehiculo.Tag = "";
            this.btnAgregarVehiculo.Text = "Agregar vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // pnlVehiculos
            // 
            this.pnlVehiculos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlVehiculos.Controls.Add(this.lblCliente);
            this.pnlVehiculos.Location = new System.Drawing.Point(0, 0);
            this.pnlVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVehiculos.Name = "pnlVehiculos";
            this.pnlVehiculos.Size = new System.Drawing.Size(1219, 123);
            this.pnlVehiculos.TabIndex = 71;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(453, 46);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(228, 29);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Agregar Vehiculos";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlDatos.Controls.Add(this.btnColor);
            this.pnlDatos.Controls.Add(this.button1);
            this.pnlDatos.Controls.Add(this.cbEstado);
            this.pnlDatos.Controls.Add(this.txtPrecioVenta);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.lblTransmision);
            this.pnlDatos.Controls.Add(this.cbTransmicion);
            this.pnlDatos.Controls.Add(this.cbTipoCombustible);
            this.pnlDatos.Controls.Add(this.cbProveedor);
            this.pnlDatos.Controls.Add(this.lblProveedor);
            this.pnlDatos.Controls.Add(this.btnAggColor);
            this.pnlDatos.Controls.Add(this.lblTipoCombustible);
            this.pnlDatos.Controls.Add(this.cbTipoVehiculo);
            this.pnlDatos.Controls.Add(this.cbMarca);
            this.pnlDatos.Controls.Add(this.txtPrecioCosto);
            this.pnlDatos.Controls.Add(this.lblTipoVehiculo);
            this.pnlDatos.Controls.Add(this.txtModelo);
            this.pnlDatos.Controls.Add(this.txtAño);
            this.pnlDatos.Controls.Add(this.txtKilometraje);
            this.pnlDatos.Controls.Add(this.txtVin);
            this.pnlDatos.Controls.Add(this.lblAño);
            this.pnlDatos.Controls.Add(this.lblPlaca);
            this.pnlDatos.Controls.Add(this.lblNoVin);
            this.pnlDatos.Controls.Add(this.lblPrecio);
            this.pnlDatos.Controls.Add(this.lblColor);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.lblKilometraje);
            this.pnlDatos.Controls.Add(this.lblModelo);
            this.pnlDatos.Controls.Add(this.lblMarca);
            this.pnlDatos.Controls.Add(this.txtPlaca);
            this.pnlDatos.Controls.Add(this.btnAgregarVehiculo);
            this.pnlDatos.Controls.Add(this.dgvColores);
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1219, 788);
            this.pnlDatos.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(45, 606);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(175, 23);
            this.btnColor.TabIndex = 99;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(812, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 32);
            this.button1.TabIndex = 97;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Usado",
            "Nuevo"});
            this.cbEstado.Location = new System.Drawing.Point(812, 442);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(372, 31);
            this.cbEstado.TabIndex = 70;
            this.cbEstado.Tag = "";
            this.cbEstado.TextChanged += new System.EventHandler(this.cbEstado_TextChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(1005, 629);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(179, 30);
            this.txtPrecioVenta.TabIndex = 73;
            this.txtPrecioVenta.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 597);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Precio Venta:";
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.BackColor = System.Drawing.Color.Transparent;
            this.lblTransmision.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(316, 597);
            this.lblTransmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(139, 24);
            this.lblTransmision.TabIndex = 95;
            this.lblTransmision.Text = "Transmision:";
            // 
            // cbTransmicion
            // 
            this.cbTransmicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTransmicion.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbTransmicion.FormattingEnabled = true;
            this.cbTransmicion.Items.AddRange(new object[] {
            "Manual",
            "Automatico"});
            this.cbTransmicion.Location = new System.Drawing.Point(340, 630);
            this.cbTransmicion.Margin = new System.Windows.Forms.Padding(4);
            this.cbTransmicion.Name = "cbTransmicion";
            this.cbTransmicion.Size = new System.Drawing.Size(175, 31);
            this.cbTransmicion.TabIndex = 66;
            // 
            // cbTipoCombustible
            // 
            this.cbTipoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoCombustible.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCombustible.FormattingEnabled = true;
            this.cbTipoCombustible.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Hibrido"});
            this.cbTipoCombustible.Location = new System.Drawing.Point(271, 518);
            this.cbTipoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoCombustible.Name = "cbTipoCombustible";
            this.cbTipoCombustible.Size = new System.Drawing.Size(244, 31);
            this.cbTipoCombustible.TabIndex = 63;
            this.cbTipoCombustible.Tag = "";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(859, 518);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(325, 31);
            this.cbProveedor.TabIndex = 71;
            this.cbProveedor.Tag = "";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(588, 521);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(121, 24);
            this.lblProveedor.TabIndex = 88;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // btnAggColor
            // 
            this.btnAggColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAggColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggColor.Location = new System.Drawing.Point(239, 606);
            this.btnAggColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggColor.Name = "btnAggColor";
            this.btnAggColor.Size = new System.Drawing.Size(39, 32);
            this.btnAggColor.TabIndex = 65;
            this.btnAggColor.Text = "+";
            this.btnAggColor.UseVisualStyleBackColor = false;
            this.btnAggColor.Click += new System.EventHandler(this.btnAggColor_Click);
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCombustible.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustible.Location = new System.Drawing.Point(41, 521);
            this.lblTipoCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(185, 24);
            this.lblTipoCombustible.TabIndex = 84;
            this.lblTipoCombustible.Text = "TipoCombustible:";
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoVehiculo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Deportivo",
            "Campero",
            "Servicio publico"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(812, 254);
            this.cbTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(372, 31);
            this.cbTipoVehiculo.TabIndex = 68;
            this.cbTipoVehiculo.Tag = "";
            // 
            // cbMarca
            // 
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Nissan ",
            "Mazda",
            "Suzuki",
            "Lexus",
            "Subaru",
            "Mercedes-Benz",
            "Mitsubishi",
            "BMW"});
            this.cbMarca.Location = new System.Drawing.Point(812, 170);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(372, 31);
            this.cbMarca.TabIndex = 67;
            this.cbMarca.Tag = "";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCosto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCosto.Location = new System.Drawing.Point(717, 629);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(181, 30);
            this.txtPrecioCosto.TabIndex = 72;
            this.txtPrecioCosto.Tag = "";
            this.txtPrecioCosto.Leave += new System.EventHandler(this.txtPrecioCosto_Leave);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(588, 256);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(153, 24);
            this.lblTipoVehiculo.TabIndex = 79;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(143, 252);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(373, 30);
            this.txtModelo.TabIndex = 60;
            this.txtModelo.Tag = "";
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(143, 342);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(373, 30);
            this.txtAño.TabIndex = 61;
            this.txtAño.Tag = "";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKilometraje.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.Location = new System.Drawing.Point(812, 338);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(373, 30);
            this.txtKilometraje.TabIndex = 69;
            this.txtKilometraje.Tag = "";
            // 
            // txtVin
            // 
            this.txtVin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVin.Location = new System.Drawing.Point(143, 428);
            this.txtVin.Margin = new System.Windows.Forms.Padding(4);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(373, 30);
            this.txtVin.TabIndex = 62;
            this.txtVin.Tag = "";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.Transparent;
            this.lblAño.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(36, 343);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(56, 24);
            this.lblAño.TabIndex = 70;
            this.lblAño.Text = "Año:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(36, 166);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(71, 24);
            this.lblPlaca.TabIndex = 69;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblNoVin
            // 
            this.lblNoVin.AutoSize = true;
            this.lblNoVin.BackColor = System.Drawing.Color.Transparent;
            this.lblNoVin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoVin.Location = new System.Drawing.Point(36, 430);
            this.lblNoVin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoVin.Name = "lblNoVin";
            this.lblNoVin.Size = new System.Drawing.Size(83, 24);
            this.lblNoVin.TabIndex = 68;
            this.lblNoVin.Text = "No Vin:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(588, 597);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(141, 24);
            this.lblPrecio.TabIndex = 67;
            this.lblPrecio.Text = "Precio Costo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(41, 579);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(192, 24);
            this.lblColor.TabIndex = 66;
            this.lblColor.Text = "Seleccionar Color:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(588, 428);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 24);
            this.lblEstado.TabIndex = 65;
            this.lblEstado.Text = "Estado:";
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.BackColor = System.Drawing.Color.Transparent;
            this.lblKilometraje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraje.Location = new System.Drawing.Point(588, 342);
            this.lblKilometraje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(134, 24);
            this.lblKilometraje.TabIndex = 64;
            this.lblKilometraje.Text = "Kilometraje:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(36, 254);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(90, 24);
            this.lblModelo.TabIndex = 63;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(588, 172);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(79, 24);
            this.lblMarca.TabIndex = 62;
            this.lblMarca.Text = "Marca:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(143, 165);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(373, 30);
            this.txtPlaca.TabIndex = 59;
            this.txtPlaca.Tag = "";
            // 
            // dgvColores
            // 
            this.dgvColores.AllowUserToAddRows = false;
            this.dgvColores.AllowUserToDeleteRows = false;
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColores.ColumnHeadersVisible = false;
            this.dgvColores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvColores.Location = new System.Drawing.Point(45, 629);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.ReadOnly = true;
            this.dgvColores.RowHeadersVisible = false;
            this.dgvColores.RowHeadersWidth = 51;
            this.dgvColores.RowTemplate.Height = 24;
            this.dgvColores.Size = new System.Drawing.Size(175, 147);
            this.dgvColores.TabIndex = 98;
            this.dgvColores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColores_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmAgregarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 788);
            this.Controls.Add(this.pnlVehiculos);
            this.Controls.Add(this.pnlDatos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Vehiculos";
            this.Load += new System.EventHandler(this.frmAgregarVehiculos_Load);
            this.pnlVehiculos.ResumeLayout(false);
            this.pnlVehiculos.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Panel pnlVehiculos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNoVin;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.Button btnAggColor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbTipoCombustible;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.ComboBox cbTransmicion;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvColores;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}