namespace wfConcesionaria_v1
{
    partial class frmAdministrarMantenimiento
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
            this.tspFiltros = new System.Windows.Forms.ToolStrip();
            this.lblFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregarKits = new System.Windows.Forms.ToolStripButton();
            this.btnFacturas = new System.Windows.Forms.ToolStripButton();
            this.dgvmantenimiento = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.pnlVentas.SuspendLayout();
            this.tspFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlVentas.Controls.Add(this.lblMantenimiento);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(898, 48);
            this.pnlVentas.TabIndex = 14;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(329, 9);
            this.lblMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(180, 27);
            this.lblMantenimiento.TabIndex = 0;
            this.lblMantenimiento.Text = "Mantenimiento";
            // 
            // tspFiltros
            // 
            this.tspFiltros.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspFiltros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFiltrar,
            this.txtFiltro,
            this.toolStripSeparator2,
            this.btneliminar,
            this.btnAgregarKits,
            this.btnFacturas});
            this.tspFiltros.Location = new System.Drawing.Point(0, 48);
            this.tspFiltros.Name = "tspFiltros";
            this.tspFiltros.Size = new System.Drawing.Size(898, 41);
            this.tspFiltros.TabIndex = 15;
            this.tspFiltros.Text = "toolStrip1";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(81, 38);
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(226, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAgregarKits
            // 
            this.btnAgregarKits.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAgregarKits.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarKits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregarKits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarKits.Name = "btnAgregarKits";
            this.btnAgregarKits.Size = new System.Drawing.Size(98, 38);
            this.btnAgregarKits.Text = "Agregar Kits";
            this.btnAgregarKits.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarKits.Click += new System.EventHandler(this.btnAgregarKits_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFacturas.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFacturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFacturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(71, 38);
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // dgvmantenimiento
            // 
            this.dgvmantenimiento.AllowUserToAddRows = false;
            this.dgvmantenimiento.AllowUserToDeleteRows = false;
            this.dgvmantenimiento.AllowUserToResizeColumns = false;
            this.dgvmantenimiento.AllowUserToResizeRows = false;
            this.dgvmantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmantenimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvmantenimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvmantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmantenimiento.Location = new System.Drawing.Point(0, 89);
            this.dgvmantenimiento.Name = "dgvmantenimiento";
            this.dgvmantenimiento.ReadOnly = true;
            this.dgvmantenimiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvmantenimiento.RowHeadersVisible = false;
            this.dgvmantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmantenimiento.ShowEditingIcon = false;
            this.dgvmantenimiento.ShowRowErrors = false;
            this.dgvmantenimiento.Size = new System.Drawing.Size(898, 512);
            this.dgvmantenimiento.TabIndex = 16;
            this.dgvmantenimiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmantenimiento_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Image = global::wfConcesionaria_v1.Properties.Resources.eliminar;
            this.btneliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 38);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmAdministrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 601);
            this.Controls.Add(this.dgvmantenimiento);
            this.Controls.Add(this.tspFiltros);
            this.Controls.Add(this.pnlVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrarMantenimiento";
            this.Load += new System.EventHandler(this.frmAdministrarMantenimiento_Load);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.tspFiltros.ResumeLayout(false);
            this.tspFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.ToolStrip tspFiltros;
        private System.Windows.Forms.ToolStripLabel lblFiltrar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFacturas;
        private System.Windows.Forms.DataGridView dgvmantenimiento;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btnAgregarKits;
    }
}