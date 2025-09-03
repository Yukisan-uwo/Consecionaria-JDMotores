namespace wfConcesionaria_v1
{
    partial class frmFacturasMantenimiento
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
            this.dgvFacturasmantenimiento = new System.Windows.Forms.DataGridView();
            this.pnlVentas.SuspendLayout();
            this.tspFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasmantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlVentas.Controls.Add(this.lblMantenimiento);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(891, 48);
            this.pnlVentas.TabIndex = 15;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(289, 9);
            this.lblMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(325, 27);
            this.lblMantenimiento.TabIndex = 0;
            this.lblMantenimiento.Text = "Facturas de Mantenimientos";
            // 
            // tspFiltros
            // 
            this.tspFiltros.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspFiltros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFiltrar,
            this.txtFiltro,
            this.toolStripSeparator2});
            this.tspFiltros.Location = new System.Drawing.Point(0, 48);
            this.tspFiltros.Name = "tspFiltros";
            this.tspFiltros.Size = new System.Drawing.Size(891, 25);
            this.tspFiltros.TabIndex = 16;
            this.tspFiltros.Text = "toolStrip1";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(81, 22);
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(226, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvFacturasmantenimiento
            // 
            this.dgvFacturasmantenimiento.AllowUserToAddRows = false;
            this.dgvFacturasmantenimiento.AllowUserToDeleteRows = false;
            this.dgvFacturasmantenimiento.AllowUserToResizeColumns = false;
            this.dgvFacturasmantenimiento.AllowUserToResizeRows = false;
            this.dgvFacturasmantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturasmantenimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturasmantenimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFacturasmantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasmantenimiento.Location = new System.Drawing.Point(0, 86);
            this.dgvFacturasmantenimiento.Name = "dgvFacturasmantenimiento";
            this.dgvFacturasmantenimiento.ReadOnly = true;
            this.dgvFacturasmantenimiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFacturasmantenimiento.RowHeadersVisible = false;
            this.dgvFacturasmantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturasmantenimiento.ShowEditingIcon = false;
            this.dgvFacturasmantenimiento.ShowRowErrors = false;
            this.dgvFacturasmantenimiento.Size = new System.Drawing.Size(891, 336);
            this.dgvFacturasmantenimiento.TabIndex = 17;
            // 
            // frmFacturasMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 420);
            this.Controls.Add(this.dgvFacturasmantenimiento);
            this.Controls.Add(this.tspFiltros);
            this.Controls.Add(this.pnlVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturasMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturasMantenimiento";
            this.Load += new System.EventHandler(this.frmFacturasMantenimiento_Load);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.tspFiltros.ResumeLayout(false);
            this.tspFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasmantenimiento)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFacturasmantenimiento;
    }
}