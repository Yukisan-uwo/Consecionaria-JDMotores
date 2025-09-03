namespace wfConcesionaria_v1
{
    partial class frmVerCobranza
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCobranza = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tlblFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvCobranzas = new System.Windows.Forms.DataGridView();
            this.ttpFiltros = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranzas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblCobranza);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblCobranza
            // 
            this.lblCobranza.AutoSize = true;
            this.lblCobranza.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblCobranza.Location = new System.Drawing.Point(405, 14);
            this.lblCobranza.Name = "lblCobranza";
            this.lblCobranza.Size = new System.Drawing.Size(117, 23);
            this.lblCobranza.TabIndex = 0;
            this.lblCobranza.Text = "Prestamos:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInfo,
            this.tlblFiltrar,
            this.txtFiltro,
            this.toolStripSeparator2,
            this.tbtnModificar,
            this.toolStripSeparator3,
            this.tbtnBuscar,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnInfo
            // 
            this.tbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInfo.Image = global::wfConcesionaria_v1.Properties.Resources.informacion_15;
            this.tbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInfo.Name = "tbtnInfo";
            this.tbtnInfo.Size = new System.Drawing.Size(23, 32);
            this.tbtnInfo.Text = "toolStripButton2";
            this.tbtnInfo.Click += new System.EventHandler(this.tbtnInfo_Click);
            // 
            // tlblFiltrar
            // 
            this.tlblFiltrar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlblFiltrar.Name = "tlblFiltrar";
            this.tlblFiltrar.Size = new System.Drawing.Size(61, 32);
            this.tlblFiltrar.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.AutoSize = false;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(200, 25);
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tbtnModificar
            // 
            this.tbtnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnModificar.AutoSize = false;
            this.tbtnModificar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbtnModificar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.tbtnModificar.Image = global::wfConcesionaria_v1.Properties.Resources.lapiz_20;
            this.tbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnModificar.Name = "tbtnModificar";
            this.tbtnModificar.Size = new System.Drawing.Size(110, 28);
            this.tbtnModificar.Text = "Modificar";
            this.tbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tbtnModificar.Click += new System.EventHandler(this.tbtnModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // tbtnBuscar
            // 
            this.tbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnBuscar.Image = global::wfConcesionaria_v1.Properties.Resources.lupa_20;
            this.tbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBuscar.Name = "tbtnBuscar";
            this.tbtnBuscar.Size = new System.Drawing.Size(23, 32);
            this.tbtnBuscar.Text = "toolStripButton1";
            this.tbtnBuscar.Click += new System.EventHandler(this.tbtnBuscar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // dgvCobranzas
            // 
            this.dgvCobranzas.AllowUserToAddRows = false;
            this.dgvCobranzas.AllowUserToDeleteRows = false;
            this.dgvCobranzas.AllowUserToResizeColumns = false;
            this.dgvCobranzas.AllowUserToResizeRows = false;
            this.dgvCobranzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobranzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobranzas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCobranzas.Location = new System.Drawing.Point(0, 85);
            this.dgvCobranzas.Name = "dgvCobranzas";
            this.dgvCobranzas.ReadOnly = true;
            this.dgvCobranzas.RowHeadersVisible = false;
            this.dgvCobranzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobranzas.Size = new System.Drawing.Size(898, 516);
            this.dgvCobranzas.TabIndex = 2;
            // 
            // frmVerCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 601);
            this.Controls.Add(this.dgvCobranzas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerCobranza";
            this.Text = "frmVerCobranza";
            this.Load += new System.EventHandler(this.frmVerCobranza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranzas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCobranza;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tlblFiltrar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvCobranzas;
        private System.Windows.Forms.ToolTip ttpFiltros;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnInfo;
    }
}