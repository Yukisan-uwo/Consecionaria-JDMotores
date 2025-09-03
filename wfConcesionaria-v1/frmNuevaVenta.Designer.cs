namespace wfConcesionaria_v1
{
    partial class frmNuevaVenta
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
            this.components = new System.ComponentModel.Container();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelecVehiculo = new System.Windows.Forms.Button();
            this.btnSelecCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.txtTransmision = new System.Windows.Forms.TextBox();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.lblEspec = new System.Windows.Forms.Label();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.picVehiculo = new System.Windows.Forms.PictureBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.nudNdeCuotas = new System.Windows.Forms.NumericUpDown();
            this.lblNdeCuotas = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cbxFacturacion = new System.Windows.Forms.ComboBox();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.ttpTarjeta = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecuento = new System.Windows.Forms.TextBox();
            this.txtRegalo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculo)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNdeCuotas)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelecVehiculo
            // 
            this.btnSelecVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecVehiculo.Enabled = false;
            this.btnSelecVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecVehiculo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecVehiculo.Image = global::wfConcesionaria_v1.Properties.Resources.lupa_20;
            this.btnSelecVehiculo.Location = new System.Drawing.Point(497, 23);
            this.btnSelecVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecVehiculo.Name = "btnSelecVehiculo";
            this.btnSelecVehiculo.Size = new System.Drawing.Size(41, 37);
            this.btnSelecVehiculo.TabIndex = 5;
            this.ttpInfo.SetToolTip(this.btnSelecVehiculo, "Seleccionar");
            this.btnSelecVehiculo.UseVisualStyleBackColor = false;
            this.btnSelecVehiculo.Click += new System.EventHandler(this.btnSelecVehiculo_Click);
            // 
            // btnSelecCliente
            // 
            this.btnSelecCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCliente.Image = global::wfConcesionaria_v1.Properties.Resources.lupa_20;
            this.btnSelecCliente.Location = new System.Drawing.Point(652, 22);
            this.btnSelecCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecCliente.Name = "btnSelecCliente";
            this.btnSelecCliente.Size = new System.Drawing.Size(41, 37);
            this.btnSelecCliente.TabIndex = 2;
            this.ttpInfo.SetToolTip(this.btnSelecCliente, "Seleccionar");
            this.btnSelecCliente.UseVisualStyleBackColor = false;
            this.btnSelecCliente.Click += new System.EventHandler(this.btnSelecCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.txtCombustible);
            this.panel1.Controls.Add(this.lblCombustible);
            this.panel1.Controls.Add(this.txtTransmision);
            this.panel1.Controls.Add(this.lblTransmision);
            this.panel1.Controls.Add(this.lblEspec);
            this.panel1.Controls.Add(this.lblHistoria);
            this.panel1.Controls.Add(this.txtKilometraje);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblAño);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.picVehiculo);
            this.panel1.Controls.Add(this.btnSelecVehiculo);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 651);
            this.panel1.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(307, 561);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 24);
            this.lblColor.TabIndex = 25;
            this.lblColor.Text = "Color:";
            // 
            // txtCombustible
            // 
            this.txtCombustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCombustible.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustible.Location = new System.Drawing.Point(631, 478);
            this.txtCombustible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.ReadOnly = true;
            this.txtCombustible.Size = new System.Drawing.Size(247, 30);
            this.txtCombustible.TabIndex = 24;
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCombustible.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(459, 481);
            this.lblCombustible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(142, 24);
            this.lblCombustible.TabIndex = 23;
            this.lblCombustible.Text = "Combustible:";
            // 
            // txtTransmision
            // 
            this.txtTransmision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransmision.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmision.Location = new System.Drawing.Point(219, 475);
            this.txtTransmision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransmision.Name = "txtTransmision";
            this.txtTransmision.ReadOnly = true;
            this.txtTransmision.Size = new System.Drawing.Size(197, 30);
            this.txtTransmision.TabIndex = 22;
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTransmision.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmision.Location = new System.Drawing.Point(47, 479);
            this.lblTransmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(139, 24);
            this.lblTransmision.TabIndex = 21;
            this.lblTransmision.Text = "Transmision:";
            // 
            // lblEspec
            // 
            this.lblEspec.AutoSize = true;
            this.lblEspec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblEspec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspec.Location = new System.Drawing.Point(367, 417);
            this.lblEspec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspec.Name = "lblEspec";
            this.lblEspec.Size = new System.Drawing.Size(210, 24);
            this.lblEspec.TabIndex = 20;
            this.lblEspec.Text = "ESPECIFICACIONES";
            // 
            // lblHistoria
            // 
            this.lblHistoria.AutoSize = true;
            this.lblHistoria.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHistoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoria.Location = new System.Drawing.Point(337, 294);
            this.lblHistoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(269, 24);
            this.lblHistoria.TabIndex = 18;
            this.lblHistoria.Text = "HISTORIA DEL VEHICULO";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKilometraje.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.Location = new System.Drawing.Point(631, 353);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.ReadOnly = true;
            this.txtKilometraje.Size = new System.Drawing.Size(247, 30);
            this.txtKilometraje.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(219, 353);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(197, 30);
            this.txtEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(47, 357);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 24);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(413, 219);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(465, 30);
            this.txtAño.TabIndex = 13;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAño.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(297, 220);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(56, 24);
            this.lblAño.TabIndex = 12;
            this.lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(413, 159);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(465, 30);
            this.txtModelo.TabIndex = 11;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(297, 160);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(90, 24);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(415, 98);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(463, 30);
            this.txtMarca.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(297, 101);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(79, 24);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca:";
            // 
            // picVehiculo
            // 
            this.picVehiculo.BackgroundImage = global::wfConcesionaria_v1.Properties.Resources.image_removebg_preview;
            this.picVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVehiculo.Location = new System.Drawing.Point(41, 80);
            this.picVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVehiculo.Name = "picVehiculo";
            this.picVehiculo.Size = new System.Drawing.Size(216, 199);
            this.picVehiculo.TabIndex = 7;
            this.picVehiculo.TabStop = false;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblVehiculo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(368, 27);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(115, 29);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlColor);
            this.panel3.Controls.Add(this.lblKilometraje);
            this.panel3.Location = new System.Drawing.Point(8, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 631);
            this.panel3.TabIndex = 28;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.Location = new System.Drawing.Point(395, 537);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(217, 58);
            this.pnlColor.TabIndex = 17;
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblKilometraje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometraje.Location = new System.Drawing.Point(449, 346);
            this.lblKilometraje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(134, 24);
            this.lblKilometraje.TabIndex = 16;
            this.lblKilometraje.Text = "Kilometraje:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(541, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(96, 29);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCedula.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(36, 80);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(86, 24);
            this.lblCedula.TabIndex = 4;
            this.lblCedula.Text = "Cedula:";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(139, 76);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(233, 30);
            this.txtCliente.TabIndex = 5;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(408, 80);
            this.lblNombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(97, 24);
            this.lblNombreC.TabIndex = 6;
            this.lblNombreC.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(527, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(638, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.lblNombreC);
            this.pnlUsuario.Controls.Add(this.txtCliente);
            this.pnlUsuario.Controls.Add(this.lblCedula);
            this.pnlUsuario.Controls.Add(this.btnSelecCliente);
            this.pnlUsuario.Controls.Add(this.lblCliente);
            this.pnlUsuario.Controls.Add(this.panel2);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(1219, 137);
            this.pnlUsuario.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 120);
            this.panel2.TabIndex = 8;
            // 
            // cbxMetodo
            // 
            this.cbxMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMetodo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbxMetodo.FormattingEnabled = true;
            this.cbxMetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbxMetodo.Location = new System.Drawing.Point(20, 309);
            this.cbxMetodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMetodo.Name = "cbxMetodo";
            this.cbxMetodo.Size = new System.Drawing.Size(232, 31);
            this.cbxMetodo.TabIndex = 26;
            this.cbxMetodo.SelectedIndexChanged += new System.EventHandler(this.cbxMetodo_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblMetodo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(16, 280);
            this.lblMetodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(92, 24);
            this.lblMetodo.TabIndex = 25;
            this.lblMetodo.Text = "Metodo:";
            // 
            // nudNdeCuotas
            // 
            this.nudNdeCuotas.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.nudNdeCuotas.Location = new System.Drawing.Point(185, 430);
            this.nudNdeCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNdeCuotas.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudNdeCuotas.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNdeCuotas.Name = "nudNdeCuotas";
            this.nudNdeCuotas.ReadOnly = true;
            this.nudNdeCuotas.Size = new System.Drawing.Size(67, 30);
            this.nudNdeCuotas.TabIndex = 24;
            this.nudNdeCuotas.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNdeCuotas.Visible = false;
            // 
            // lblNdeCuotas
            // 
            this.lblNdeCuotas.AutoSize = true;
            this.lblNdeCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblNdeCuotas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdeCuotas.Location = new System.Drawing.Point(16, 432);
            this.lblNdeCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNdeCuotas.Name = "lblNdeCuotas";
            this.lblNdeCuotas.Size = new System.Drawing.Size(154, 24);
            this.lblNdeCuotas.TabIndex = 23;
            this.lblNdeCuotas.Text = "Nº de Cuotas :";
            this.lblNdeCuotas.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Location = new System.Drawing.Point(25, 556);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(244, 69);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // cbxFacturacion
            // 
            this.cbxFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFacturacion.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbxFacturacion.FormattingEnabled = true;
            this.cbxFacturacion.Items.AddRange(new object[] {
            "Contado",
            "Cuotas"});
            this.cbxFacturacion.Location = new System.Drawing.Point(25, 379);
            this.cbxFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFacturacion.Name = "cbxFacturacion";
            this.cbxFacturacion.Size = new System.Drawing.Size(232, 31);
            this.cbxFacturacion.TabIndex = 21;
            this.cbxFacturacion.SelectedIndexChanged += new System.EventHandler(this.cbxFacturacion_SelectedIndexChanged);
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblFacturacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(16, 348);
            this.lblFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(136, 24);
            this.lblFacturacion.TabIndex = 20;
            this.lblFacturacion.Text = "Facturacion:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(955, 240);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(233, 30);
            this.txtPrecio.TabIndex = 19;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(949, 199);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 24);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblPago.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(1024, 156);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(73, 29);
            this.lblPago.TabIndex = 17;
            this.lblPago.Text = "Pago";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarjeta.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(25, 492);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarjeta.MaxLength = 16;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(233, 30);
            this.txtTarjeta.TabIndex = 28;
            this.txtTarjeta.Visible = false;
            this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.lblTarjeta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(21, 464);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(89, 24);
            this.lblTarjeta.TabIndex = 27;
            this.lblTarjeta.Text = "Tarjeta:";
            this.lblTarjeta.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtRegalo);
            this.panel4.Controls.Add(this.txtDecuento);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTarjeta);
            this.panel4.Controls.Add(this.nudNdeCuotas);
            this.panel4.Controls.Add(this.lblTarjeta);
            this.panel4.Controls.Add(this.lblNdeCuotas);
            this.panel4.Controls.Add(this.cbxMetodo);
            this.panel4.Controls.Add(this.lblFacturacion);
            this.panel4.Controls.Add(this.lblMetodo);
            this.panel4.Controls.Add(this.cbxFacturacion);
            this.panel4.Controls.Add(this.btnPagar);
            this.panel4.Location = new System.Drawing.Point(932, 145);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 631);
            this.panel4.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Regalo:";
            // 
            // txtDecuento
            // 
            this.txtDecuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecuento.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecuento.Location = new System.Drawing.Point(20, 169);
            this.txtDecuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecuento.Name = "txtDecuento";
            this.txtDecuento.ReadOnly = true;
            this.txtDecuento.Size = new System.Drawing.Size(233, 30);
            this.txtDecuento.TabIndex = 30;
            // 
            // txtRegalo
            // 
            this.txtRegalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegalo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegalo.Location = new System.Drawing.Point(20, 240);
            this.txtRegalo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegalo.Name = "txtRegalo";
            this.txtRegalo.ReadOnly = true;
            this.txtRegalo.Size = new System.Drawing.Size(233, 30);
            this.txtRegalo.TabIndex = 32;
            // 
            // frmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 788);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirVenta";
            this.Load += new System.EventHandler(this.frmNuevaVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNdeCuotas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnSelecVehiculo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox picVehiculo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblEspec;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.TextBox txtTransmision;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnSelecCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.ComboBox cbxMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.NumericUpDown nudNdeCuotas;
        private System.Windows.Forms.Label lblNdeCuotas;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cbxFacturacion;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.ToolTip ttpTarjeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtRegalo;
        private System.Windows.Forms.TextBox txtDecuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}