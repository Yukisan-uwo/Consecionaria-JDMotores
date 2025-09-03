namespace wfConcesionaria_v1
{
    partial class frmPagarCuotas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnSelecCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvCobranza = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.nudCuotasPagar = new System.Windows.Forms.NumericUpDown();
            this.lblNCuotas = new System.Windows.Forms.Label();
            this.txtPrecioCuota = new System.Windows.Forms.TextBox();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.LblPagarCuotas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 94);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblNombreC);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.lblCedula);
            this.panel2.Controls.Add(this.btnSelecCliente);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Location = new System.Drawing.Point(5, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 81);
            this.panel2.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(385, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(495, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(296, 46);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(79, 19);
            this.lblNombreC.TabIndex = 8;
            this.lblNombreC.Text = "Nombre:";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(106, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(175, 26);
            this.txtCliente.TabIndex = 7;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCedula.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(29, 46);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(71, 19);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cedula:";
            // 
            // btnSelecCliente
            // 
            this.btnSelecCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCliente.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCliente.Image = global::wfConcesionaria_v1.Properties.Resources.lupa_20;
            this.btnSelecCliente.Location = new System.Drawing.Point(463, 4);
            this.btnSelecCliente.Name = "btnSelecCliente";
            this.btnSelecCliente.Size = new System.Drawing.Size(31, 30);
            this.btnSelecCliente.TabIndex = 4;
            this.btnSelecCliente.UseVisualStyleBackColor = false;
            this.btnSelecCliente.Click += new System.EventHandler(this.btnSelecCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(380, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 23);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvCobranza
            // 
            this.dgvCobranza.AllowUserToAddRows = false;
            this.dgvCobranza.AllowUserToDeleteRows = false;
            this.dgvCobranza.AllowUserToResizeColumns = false;
            this.dgvCobranza.AllowUserToResizeRows = false;
            this.dgvCobranza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobranza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobranza.Location = new System.Drawing.Point(11, 103);
            this.dgvCobranza.Name = "dgvCobranza";
            this.dgvCobranza.ReadOnly = true;
            this.dgvCobranza.RowHeadersVisible = false;
            this.dgvCobranza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobranza.Size = new System.Drawing.Size(633, 489);
            this.dgvCobranza.TabIndex = 2;
            this.dgvCobranza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCobranza_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.nudCuotasPagar);
            this.panel3.Controls.Add(this.lblNCuotas);
            this.panel3.Controls.Add(this.txtPrecioCuota);
            this.panel3.Controls.Add(this.lblPrecioCuota);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblPrecio);
            this.panel3.Controls.Add(this.LblPagarCuotas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(650, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 507);
            this.panel3.TabIndex = 3;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Location = new System.Drawing.Point(34, 353);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(183, 56);
            this.btnPagar.TabIndex = 26;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // nudCuotasPagar
            // 
            this.nudCuotasPagar.Enabled = false;
            this.nudCuotasPagar.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.nudCuotasPagar.Location = new System.Drawing.Point(170, 221);
            this.nudCuotasPagar.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCuotasPagar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotasPagar.Name = "nudCuotasPagar";
            this.nudCuotasPagar.ReadOnly = true;
            this.nudCuotasPagar.Size = new System.Drawing.Size(66, 26);
            this.nudCuotasPagar.TabIndex = 25;
            this.nudCuotasPagar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCuotasPagar.ValueChanged += new System.EventHandler(this.nudCuotasPagar_ValueChanged);
            // 
            // lblNCuotas
            // 
            this.lblNCuotas.AutoSize = true;
            this.lblNCuotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNCuotas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCuotas.Location = new System.Drawing.Point(12, 222);
            this.lblNCuotas.Name = "lblNCuotas";
            this.lblNCuotas.Size = new System.Drawing.Size(138, 19);
            this.lblNCuotas.TabIndex = 24;
            this.lblNCuotas.Text = "Cuotas a pagar:";
            // 
            // txtPrecioCuota
            // 
            this.txtPrecioCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCuota.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCuota.Location = new System.Drawing.Point(16, 164);
            this.txtPrecioCuota.Name = "txtPrecioCuota";
            this.txtPrecioCuota.ReadOnly = true;
            this.txtPrecioCuota.Size = new System.Drawing.Size(220, 26);
            this.txtPrecioCuota.TabIndex = 23;
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPrecioCuota.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCuota.Location = new System.Drawing.Point(12, 130);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(144, 19);
            this.lblPrecioCuota.TabIndex = 22;
            this.lblPrecioCuota.Text = "Precio de Cuota:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(16, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(220, 26);
            this.txtTotal.TabIndex = 21;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 46);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 19);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Total:";
            // 
            // LblPagarCuotas
            // 
            this.LblPagarCuotas.AutoSize = true;
            this.LblPagarCuotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblPagarCuotas.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagarCuotas.Location = new System.Drawing.Point(85, 9);
            this.LblPagarCuotas.Name = "LblPagarCuotas";
            this.LblPagarCuotas.Size = new System.Drawing.Size(77, 23);
            this.LblPagarCuotas.TabIndex = 4;
            this.LblPagarCuotas.Text = "Cliente";
            // 
            // frmPagarCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(898, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvCobranza);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagarCuotas";
            this.Text = "frmPagarCuotas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobranza)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotasPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelecCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.DataGridView dgvCobranza;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblPagarCuotas;
        private System.Windows.Forms.TextBox txtPrecioCuota;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNCuotas;
        private System.Windows.Forms.NumericUpDown nudCuotasPagar;
        private System.Windows.Forms.Button btnPagar;
    }
}