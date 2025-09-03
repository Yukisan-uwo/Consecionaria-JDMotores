namespace wfConcesionaria_v1
{
    partial class frmMantenimiento
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
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.dgvKit = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtProximoM = new System.Windows.Forms.TextBox();
            this.lblFechaMantenimiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUltimoMantenimiento = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtUltimoM = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblrgb = new System.Windows.Forms.Label();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Menos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVentas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlVentas.Controls.Add(this.lblMantenimiento);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(891, 96);
            this.pnlVentas.TabIndex = 14;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(344, 30);
            this.lblMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(180, 27);
            this.lblMantenimiento.TabIndex = 0;
            this.lblMantenimiento.Text = "Mantenimiento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblTotalPagar);
            this.panel1.Controls.Add(this.txtTotalPagar);
            this.panel1.Controls.Add(this.dgvKit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtProximoM);
            this.panel1.Controls.Add(this.lblFechaMantenimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUltimoMantenimiento);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.txtCedulaCliente);
            this.panel1.Controls.Add(this.txtUltimoM);
            this.panel1.Controls.Add(this.lblDetalles);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblrgb);
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 324);
            this.panel1.TabIndex = 15;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(12, 236);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(96, 19);
            this.lblTotalPagar.TabIndex = 29;
            this.lblTotalPagar.Text = "Total Final";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(31, 269);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(115, 20);
            this.txtTotalPagar.TabIndex = 28;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvKit
            // 
            this.dgvKit.AllowUserToAddRows = false;
            this.dgvKit.AllowUserToDeleteRows = false;
            this.dgvKit.AllowUserToResizeColumns = false;
            this.dgvKit.AllowUserToResizeRows = false;
            this.dgvKit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unidades,
            this.Kit,
            this.Mas,
            this.Menos,
            this.Precio});
            this.dgvKit.Location = new System.Drawing.Point(7, 47);
            this.dgvKit.Name = "dgvKit";
            this.dgvKit.ReadOnly = true;
            this.dgvKit.RowHeadersVisible = false;
            this.dgvKit.Size = new System.Drawing.Size(317, 169);
            this.dgvKit.TabIndex = 27;
            this.dgvKit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKit_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(429, 274);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(115, 20);
            this.txtAño.TabIndex = 24;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(574, 149);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 19);
            this.lblMarca.TabIndex = 23;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(724, 149);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 19);
            this.lblModelo.TabIndex = 22;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(763, 196);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(113, 20);
            this.txtModelo.TabIndex = 21;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(597, 196);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(116, 20);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProximoM
            // 
            this.txtProximoM.Location = new System.Drawing.Point(728, 97);
            this.txtProximoM.Name = "txtProximoM";
            this.txtProximoM.ReadOnly = true;
            this.txtProximoM.Size = new System.Drawing.Size(148, 20);
            this.txtProximoM.TabIndex = 19;
            this.txtProximoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFechaMantenimiento
            // 
            this.lblFechaMantenimiento.AutoSize = true;
            this.lblFechaMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaMantenimiento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMantenimiento.Location = new System.Drawing.Point(647, 47);
            this.lblFechaMantenimiento.Name = "lblFechaMantenimiento";
            this.lblFechaMantenimiento.Size = new System.Drawing.Size(205, 19);
            this.lblFechaMantenimiento.TabIndex = 18;
            this.lblFechaMantenimiento.Text = "Proximo Mantenimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cedula del Cliente";
            // 
            // lblUltimoMantenimiento
            // 
            this.lblUltimoMantenimiento.AutoSize = true;
            this.lblUltimoMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoMantenimiento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMantenimiento.Location = new System.Drawing.Point(362, 47);
            this.lblUltimoMantenimiento.Name = "lblUltimoMantenimiento";
            this.lblUltimoMantenimiento.Size = new System.Drawing.Size(191, 19);
            this.lblUltimoMantenimiento.TabIndex = 15;
            this.lblUltimoMantenimiento.Text = "Ultimo Mantenimiento";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(428, 196);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(116, 20);
            this.txtPlaca.TabIndex = 13;
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(728, 274);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.ReadOnly = true;
            this.txtCedulaCliente.Size = new System.Drawing.Size(148, 20);
            this.txtCedulaCliente.TabIndex = 12;
            this.txtCedulaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUltimoM
            // 
            this.txtUltimoM.Location = new System.Drawing.Point(428, 97);
            this.txtUltimoM.Name = "txtUltimoM";
            this.txtUltimoM.ReadOnly = true;
            this.txtUltimoM.Size = new System.Drawing.Size(148, 20);
            this.txtUltimoM.TabIndex = 11;
            this.txtUltimoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(344, 13);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(82, 19);
            this.lblDetalles.TabIndex = 10;
            this.lblDetalles.Text = "Detalles:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(205, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 34);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblrgb
            // 
            this.lblrgb.AutoSize = true;
            this.lblrgb.BackColor = System.Drawing.Color.Transparent;
            this.lblrgb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrgb.Location = new System.Drawing.Point(3, 13);
            this.lblrgb.Name = "lblrgb";
            this.lblrgb.Size = new System.Drawing.Size(38, 19);
            this.lblrgb.TabIndex = 3;
            this.lblrgb.Text = "Kit:";
            // 
            // Unidades
            // 
            this.Unidades.FillWeight = 123.0962F;
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // Kit
            // 
            this.Kit.FillWeight = 123.0962F;
            this.Kit.HeaderText = "Kit";
            this.Kit.Name = "Kit";
            this.Kit.ReadOnly = true;
            // 
            // Mas
            // 
            this.Mas.FillWeight = 76.14214F;
            this.Mas.HeaderText = "Mas";
            this.Mas.Name = "Mas";
            this.Mas.ReadOnly = true;
            this.Mas.Text = "";
            // 
            // Menos
            // 
            this.Menos.FillWeight = 79.62593F;
            this.Menos.HeaderText = "Menos";
            this.Menos.Name = "Menos";
            this.Menos.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 98.03941F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimiento";
            this.Load += new System.EventHandler(this.frmMantenimiento_Load);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.DataGridView dgvKit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtProximoM;
        private System.Windows.Forms.Label lblFechaMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUltimoMantenimiento;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.TextBox txtUltimoM;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblrgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kit;
        private System.Windows.Forms.DataGridViewButtonColumn Mas;
        private System.Windows.Forms.DataGridViewButtonColumn Menos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}