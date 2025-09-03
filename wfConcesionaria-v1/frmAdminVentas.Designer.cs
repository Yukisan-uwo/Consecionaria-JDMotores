namespace wfConcesionaria_v1
{
    partial class frmAdminVentas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tspFiltros = new System.Windows.Forms.ToolStrip();
            this.lblFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.pnlVentas.SuspendLayout();
            this.tspFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlVentas.Controls.Add(this.lblTitulo);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(914, 48);
            this.pnlVentas.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(413, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ventas:";
            // 
            // tspFiltros
            // 
            this.tspFiltros.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspFiltros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFiltrar,
            this.txtFiltro,
            this.btnEliminar,
            this.toolStripSeparator2});
            this.tspFiltros.Location = new System.Drawing.Point(0, 48);
            this.tspFiltros.Name = "tspFiltros";
            this.tspFiltros.Size = new System.Drawing.Size(914, 39);
            this.tspFiltros.TabIndex = 13;
            this.tspFiltros.Text = "toolStrip1";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(81, 36);
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(226, 39);
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 87);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(914, 553);
            this.dgvVentas.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::wfConcesionaria_v1.Properties.Resources.hombre;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 36);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 640);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.tspFiltros);
            this.Controls.Add(this.pnlVentas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.tspFiltros.ResumeLayout(false);
            this.tspFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStrip tspFiltros;
        private System.Windows.Forms.ToolStripLabel lblFiltrar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ToolStripButton btnEliminar;
    }
}