namespace wfConcesionaria_v1
{
    partial class frmverVehiculos
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
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.dgvvehiculos = new System.Windows.Forms.DataGridView();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTipovehiculo = new System.Windows.Forms.Label();
            this.lblMarcaVehiculo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.cbColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Items.AddRange(new object[] {
            "Todos",
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
            this.cbmarca.Location = new System.Drawing.Point(70, 58);
            this.cbmarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(106, 21);
            this.cbmarca.TabIndex = 6;
            this.cbmarca.SelectedIndexChanged += new System.EventHandler(this.cbmarca_SelectedIndexChanged);
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.BackColor = System.Drawing.Color.White;
            this.cbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Todos",
            "Deportivo",
            "Campero",
            "Servicio publico"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(237, 57);
            this.cbTipoVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(123, 21);
            this.cbTipoVehiculo.TabIndex = 7;
            this.cbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbTipoVehiculo_SelectedIndexChanged);
            // 
            // dgvvehiculos
            // 
            this.dgvvehiculos.AllowUserToAddRows = false;
            this.dgvvehiculos.AllowUserToResizeColumns = false;
            this.dgvvehiculos.AllowUserToResizeRows = false;
            this.dgvvehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvvehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiculos.Location = new System.Drawing.Point(0, 83);
            this.dgvvehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvvehiculos.Name = "dgvvehiculos";
            this.dgvvehiculos.ReadOnly = true;
            this.dgvvehiculos.RowHeadersVisible = false;
            this.dgvvehiculos.RowHeadersWidth = 51;
            this.dgvvehiculos.RowTemplate.Height = 24;
            this.dgvvehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvehiculos.Size = new System.Drawing.Size(914, 553);
            this.dgvvehiculos.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(366, 59);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 19);
            this.lblColor.TabIndex = 63;
            this.lblColor.Text = "Color:";
            // 
            // lblTipovehiculo
            // 
            this.lblTipovehiculo.AutoSize = true;
            this.lblTipovehiculo.BackColor = System.Drawing.Color.White;
            this.lblTipovehiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipovehiculo.Location = new System.Drawing.Point(180, 58);
            this.lblTipovehiculo.Name = "lblTipovehiculo";
            this.lblTipovehiculo.Size = new System.Drawing.Size(51, 19);
            this.lblTipovehiculo.TabIndex = 64;
            this.lblTipovehiculo.Text = "Tipo:";
            // 
            // lblMarcaVehiculo
            // 
            this.lblMarcaVehiculo.AutoSize = true;
            this.lblMarcaVehiculo.BackColor = System.Drawing.Color.White;
            this.lblMarcaVehiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaVehiculo.Location = new System.Drawing.Point(5, 57);
            this.lblMarcaVehiculo.Name = "lblMarcaVehiculo";
            this.lblMarcaVehiculo.Size = new System.Drawing.Size(64, 19);
            this.lblMarcaVehiculo.TabIndex = 65;
            this.lblMarcaVehiculo.Text = "Marca:";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFiltros.Controls.Add(this.lblTitulo);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(914, 48);
            this.pnlFiltros.TabIndex = 67;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(374, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestionar Vehiculos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnModificar,
            this.toolStripSeparator3,
            this.btnAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 41);
            this.toolStrip1.TabIndex = 68;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEliminar.Image = global::wfConcesionaria_v1.Properties.Resources.eliminar;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 38);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btnModificar
            // 
            this.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnModificar.Image = global::wfConcesionaria_v1.Properties.Resources.modificarCarro1;
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 38);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAgregar.Image = global::wfConcesionaria_v1.Properties.Resources.carroagregar1;
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 38);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Todos"});
            this.cbColor.Location = new System.Drawing.Point(427, 57);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(98, 21);
            this.cbColor.TabIndex = 69;
            this.cbColor.TextChanged += new System.EventHandler(this.cbColor_TextChanged);
            // 
            // frmverVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 640);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTipovehiculo);
            this.Controls.Add(this.lblMarcaVehiculo);
            this.Controls.Add(this.cbTipoVehiculo);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.dgvvehiculos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmverVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculos)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.DataGridView dgvvehiculos;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTipovehiculo;
        private System.Windows.Forms.Label lblMarcaVehiculo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ComboBox cbColor;
    }
}