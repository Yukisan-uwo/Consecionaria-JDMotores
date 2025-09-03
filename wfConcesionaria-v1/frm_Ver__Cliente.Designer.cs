namespace wfConcesionaria_v1
{
    partial class frm_Ver__Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ver__Cliente));
            this.dgvMostrar_Clientes = new System.Windows.Forms.DataGridView();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.txtfiltroo = new System.Windows.Forms.ToolStripTextBox();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCorreo = new System.Windows.Forms.ToolStripButton();
            this.imlLista1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar_Clientes)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar_Clientes
            // 
            this.dgvMostrar_Clientes.AllowUserToAddRows = false;
            this.dgvMostrar_Clientes.AllowUserToDeleteRows = false;
            this.dgvMostrar_Clientes.AllowUserToResizeColumns = false;
            this.dgvMostrar_Clientes.AllowUserToResizeRows = false;
            this.dgvMostrar_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar_Clientes.Location = new System.Drawing.Point(0, 100);
            this.dgvMostrar_Clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMostrar_Clientes.Name = "dgvMostrar_Clientes";
            this.dgvMostrar_Clientes.ReadOnly = true;
            this.dgvMostrar_Clientes.RowHeadersVisible = false;
            this.dgvMostrar_Clientes.RowHeadersWidth = 51;
            this.dgvMostrar_Clientes.RowTemplate.Height = 24;
            this.dgvMostrar_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar_Clientes.Size = new System.Drawing.Size(1219, 691);
            this.dgvMostrar_Clientes.TabIndex = 5;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFiltros.Controls.Add(this.lblTitulo);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1219, 59);
            this.pnlFiltros.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(499, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestionar Clientes";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFiltrar,
            this.txtfiltroo,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnModificar,
            this.toolStripSeparator3,
            this.btnAgregar,
            this.toolStripSeparator4,
            this.btnCorreo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1219, 39);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(101, 36);
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // txtfiltroo
            // 
            this.txtfiltroo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltroo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfiltroo.Name = "txtfiltroo";
            this.txtfiltroo.Size = new System.Drawing.Size(301, 39);
            this.txtfiltroo.TextChanged += new System.EventHandler(this.txtfiltroo_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnImprimir.Image = global::wfConcesionaria_v1.Properties.Resources.impresora;
            this.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 36);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEliminar.Image = global::wfConcesionaria_v1.Properties.Resources.hombre;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 36);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnModificar
            // 
            this.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnModificar.Image = global::wfConcesionaria_v1.Properties.Resources.orden;
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 36);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAgregar.Image = global::wfConcesionaria_v1.Properties.Resources.agregar_usuario;
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 36);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCorreo.Image = global::wfConcesionaria_v1.Properties.Resources.correo_electronico;
            this.btnCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(90, 36);
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // imlLista1
            // 
            this.imlLista1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLista1.ImageStream")));
            this.imlLista1.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLista1.Images.SetKeyName(0, "image-removebg-preview.png");
            // 
            // frm_Ver__Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 788);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMostrar_Clientes);
            this.Controls.Add(this.pnlFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Ver__Cliente";
            this.Text = "frm_Ver__Cliente";
            this.Load += new System.EventHandler(this.frm_Ver__Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar_Clientes)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMostrar_Clientes;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblFiltrar;
        private System.Windows.Forms.ToolStripTextBox txtfiltroo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imlLista1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCorreo;
    }
}