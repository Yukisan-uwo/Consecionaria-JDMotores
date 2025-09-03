namespace wfConcesionaria_v1
{
    partial class frmVerReportes
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
            this.rptReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblSeleccionar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbxReportes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbxFiltro1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbxFiltro2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbxTops = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptReportes
            // 
            this.rptReportes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptReportes.Location = new System.Drawing.Point(0, 85);
            this.rptReportes.Name = "rptReportes";
            this.rptReportes.ServerReport.BearerToken = null;
            this.rptReportes.Size = new System.Drawing.Size(914, 555);
            this.rptReportes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblSeleccionar,
            this.toolStripSeparator1,
            this.tscbxReportes,
            this.toolStripSeparator2,
            this.tscbxFiltro1,
            this.toolStripSeparator3,
            this.tscbxFiltro2,
            this.toolStripSeparator4,
            this.tscbxTops,
            this.toolStripSeparator5,
            this.tsbtnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 43);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblSeleccionar
            // 
            this.tslblSeleccionar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tslblSeleccionar.Name = "tslblSeleccionar";
            this.tslblSeleccionar.Size = new System.Drawing.Size(155, 40);
            this.tslblSeleccionar.Text = "Seleccione el reporte:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tscbxReportes
            // 
            this.tscbxReportes.AutoSize = false;
            this.tscbxReportes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tscbxReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tscbxReportes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tscbxReportes.Items.AddRange(new object[] {
            "Compras",
            "Ventas",
            "Top Empleados",
            "Compra Venta"});
            this.tscbxReportes.Name = "tscbxReportes";
            this.tscbxReportes.Size = new System.Drawing.Size(135, 24);
            this.tscbxReportes.SelectedIndexChanged += new System.EventHandler(this.tscbxReportes_SelectedIndexChanged_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tscbxFiltro1
            // 
            this.tscbxFiltro1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tscbxFiltro1.Enabled = false;
            this.tscbxFiltro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tscbxFiltro1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tscbxFiltro1.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026"});
            this.tscbxFiltro1.Name = "tscbxFiltro1";
            this.tscbxFiltro1.Size = new System.Drawing.Size(121, 43);
            this.tscbxFiltro1.SelectedIndexChanged += new System.EventHandler(this.tscbxFiltro1_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // tscbxFiltro2
            // 
            this.tscbxFiltro2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tscbxFiltro2.Enabled = false;
            this.tscbxFiltro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tscbxFiltro2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tscbxFiltro2.Items.AddRange(new object[] {
            "Unidades",
            "PrecioTotal"});
            this.tscbxFiltro2.Name = "tscbxFiltro2";
            this.tscbxFiltro2.Size = new System.Drawing.Size(121, 43);
            this.tscbxFiltro2.SelectedIndexChanged += new System.EventHandler(this.tscbxFiltro2_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // tscbxTops
            // 
            this.tscbxTops.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tscbxTops.Enabled = false;
            this.tscbxTops.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tscbxTops.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tscbxTops.Name = "tscbxTops";
            this.tscbxTops.Size = new System.Drawing.Size(121, 43);
            this.tscbxTops.SelectedIndexChanged += new System.EventHandler(this.tscbxTops_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbtnBuscar
            // 
            this.tsbtnBuscar.AutoSize = false;
            this.tsbtnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBuscar.Enabled = false;
            this.tsbtnBuscar.Image = global::wfConcesionaria_v1.Properties.Resources.lupa_20;
            this.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBuscar.Name = "tsbtnBuscar";
            this.tsbtnBuscar.Size = new System.Drawing.Size(40, 30);
            this.tsbtnBuscar.Text = "toolStripButton1";
            this.tsbtnBuscar.Click += new System.EventHandler(this.tsbtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reportes";
            // 
            // frmVerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rptReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerReportes";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmVerReportes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptReportes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel tslblSeleccionar;
        private System.Windows.Forms.ToolStripComboBox tscbxReportes;
        private System.Windows.Forms.ToolStripComboBox tscbxFiltro2;
        private System.Windows.Forms.ToolStripComboBox tscbxFiltro1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox tscbxTops;
        private System.Windows.Forms.ToolStripButton tsbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}