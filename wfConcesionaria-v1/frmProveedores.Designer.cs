namespace wfConcesionaria_v1
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.button1 = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblrgb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhtml = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNuevoProveedor = new System.Windows.Forms.TextBox();
            this.lblColorNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(200, 151);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(165, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblrgb);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblhtml);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNuevoProveedor);
            this.panel1.Controls.Add(this.lblColorNew);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 278);
            this.panel1.TabIndex = 10;
            // 
            // lblrgb
            // 
            this.lblrgb.AutoSize = true;
            this.lblrgb.BackColor = System.Drawing.Color.Transparent;
            this.lblrgb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrgb.Location = new System.Drawing.Point(15, 149);
            this.lblrgb.Name = "lblrgb";
            this.lblrgb.Size = new System.Drawing.Size(71, 19);
            this.lblrgb.TabIndex = 2;
            this.lblrgb.Text = "Ciudad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 49);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores";
            // 
            // lblhtml
            // 
            this.lblhtml.AutoSize = true;
            this.lblhtml.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhtml.Location = new System.Drawing.Point(15, 108);
            this.lblhtml.Name = "lblhtml";
            this.lblhtml.Size = new System.Drawing.Size(87, 19);
            this.lblhtml.TabIndex = 1;
            this.lblhtml.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(200, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtNuevoProveedor
            // 
            this.txtNuevoProveedor.Location = new System.Drawing.Point(200, 64);
            this.txtNuevoProveedor.Name = "txtNuevoProveedor";
            this.txtNuevoProveedor.Size = new System.Drawing.Size(165, 20);
            this.txtNuevoProveedor.TabIndex = 1;
            // 
            // lblColorNew
            // 
            this.lblColorNew.AutoSize = true;
            this.lblColorNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorNew.Location = new System.Drawing.Point(15, 65);
            this.lblColorNew.Name = "lblColorNew";
            this.lblColorNew.Size = new System.Drawing.Size(168, 19);
            this.lblColorNew.TabIndex = 0;
            this.lblColorNew.Text = "Nombre Proveedor:";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 272);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblrgb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhtml;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNuevoProveedor;
        private System.Windows.Forms.Label lblColorNew;
    }
}