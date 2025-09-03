namespace wfConcesionaria_v1
{
    partial class frmModificarCobranza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCobranza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtVentaID = new System.Windows.Forms.TextBox();
            this.lblFPago = new System.Windows.Forms.Label();
            this.txtFPago = new System.Windows.Forms.TextBox();
            this.txtFPagoSig = new System.Windows.Forms.TextBox();
            this.lblFPagoSig = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.lblValorCuota = new System.Windows.Forms.Label();
            this.txtValorPagado = new System.Windows.Forms.TextBox();
            this.lvlValorPagado = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.lblMora = new System.Windows.Forms.Label();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 56);
            this.panel1.TabIndex = 0;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblModificar.Location = new System.Drawing.Point(183, 18);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(202, 23);
            this.lblModificar.TabIndex = 0;
            this.lblModificar.Text = "Modificar Prestamo:";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(114, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(135, 23);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "VentaID";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVentaID
            // 
            this.txtVentaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVentaID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtVentaID.Location = new System.Drawing.Point(255, 76);
            this.txtVentaID.Name = "txtVentaID";
            this.txtVentaID.ReadOnly = true;
            this.txtVentaID.Size = new System.Drawing.Size(91, 27);
            this.txtVentaID.TabIndex = 2;
            // 
            // lblFPago
            // 
            this.lblFPago.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblFPago.Location = new System.Drawing.Point(12, 152);
            this.lblFPago.Name = "lblFPago";
            this.lblFPago.Size = new System.Drawing.Size(237, 23);
            this.lblFPago.TabIndex = 3;
            this.lblFPago.Text = "Fecha de Pago:";
            this.lblFPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFPago
            // 
            this.txtFPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPago.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFPago.Location = new System.Drawing.Point(255, 151);
            this.txtFPago.MaxLength = 10;
            this.txtFPago.Name = "txtFPago";
            this.txtFPago.Size = new System.Drawing.Size(278, 27);
            this.txtFPago.TabIndex = 4;
            this.txtFPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFPago_KeyPress);
            this.txtFPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFPago_KeyUp);
            // 
            // txtFPagoSig
            // 
            this.txtFPagoSig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPagoSig.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFPagoSig.Location = new System.Drawing.Point(255, 212);
            this.txtFPagoSig.Name = "txtFPagoSig";
            this.txtFPagoSig.ReadOnly = true;
            this.txtFPagoSig.Size = new System.Drawing.Size(278, 27);
            this.txtFPagoSig.TabIndex = 6;
            // 
            // lblFPagoSig
            // 
            this.lblFPagoSig.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblFPagoSig.Location = new System.Drawing.Point(12, 213);
            this.lblFPagoSig.Name = "lblFPagoSig";
            this.lblFPagoSig.Size = new System.Drawing.Size(237, 23);
            this.lblFPagoSig.TabIndex = 5;
            this.lblFPagoSig.Text = "Fecha de Siguiente Pago:";
            this.lblFPagoSig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCuota.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtValorCuota.Location = new System.Drawing.Point(255, 269);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.ReadOnly = true;
            this.txtValorCuota.Size = new System.Drawing.Size(278, 27);
            this.txtValorCuota.TabIndex = 8;
            // 
            // lblValorCuota
            // 
            this.lblValorCuota.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorCuota.Location = new System.Drawing.Point(12, 270);
            this.lblValorCuota.Name = "lblValorCuota";
            this.lblValorCuota.Size = new System.Drawing.Size(237, 23);
            this.lblValorCuota.TabIndex = 7;
            this.lblValorCuota.Text = "Valor por Cuota:";
            this.lblValorCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorPagado
            // 
            this.txtValorPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPagado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtValorPagado.Location = new System.Drawing.Point(255, 333);
            this.txtValorPagado.Name = "txtValorPagado";
            this.txtValorPagado.ReadOnly = true;
            this.txtValorPagado.Size = new System.Drawing.Size(278, 27);
            this.txtValorPagado.TabIndex = 10;
            // 
            // lvlValorPagado
            // 
            this.lvlValorPagado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lvlValorPagado.Location = new System.Drawing.Point(12, 334);
            this.lvlValorPagado.Name = "lvlValorPagado";
            this.lvlValorPagado.Size = new System.Drawing.Size(237, 23);
            this.lvlValorPagado.TabIndex = 9;
            this.lvlValorPagado.Text = "Valor Pagado:";
            this.lvlValorPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeuda
            // 
            this.txtDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeuda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtDeuda.Location = new System.Drawing.Point(255, 393);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.ReadOnly = true;
            this.txtDeuda.Size = new System.Drawing.Size(278, 27);
            this.txtDeuda.TabIndex = 12;
            // 
            // lblDeuda
            // 
            this.lblDeuda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeuda.Location = new System.Drawing.Point(12, 394);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(237, 23);
            this.lblDeuda.TabIndex = 11;
            this.lblDeuda.Text = "Deuda:";
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMora
            // 
            this.txtMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtMora.Location = new System.Drawing.Point(255, 456);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.Size = new System.Drawing.Size(278, 27);
            this.txtMora.TabIndex = 14;
            // 
            // lblMora
            // 
            this.lblMora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMora.Location = new System.Drawing.Point(12, 457);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(237, 23);
            this.lblMora.TabIndex = 13;
            this.lblMora.Text = "Mora:";
            this.lblMora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIntereses
            // 
            this.txtIntereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntereses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtIntereses.Location = new System.Drawing.Point(255, 515);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.ReadOnly = true;
            this.txtIntereses.Size = new System.Drawing.Size(278, 27);
            this.txtIntereses.TabIndex = 16;
            // 
            // lblIntereses
            // 
            this.lblIntereses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblIntereses.Location = new System.Drawing.Point(12, 516);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(237, 23);
            this.lblIntereses.TabIndex = 15;
            this.lblIntereses.Text = "Intereses:";
            this.lblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::wfConcesionaria_v1.Properties.Resources.guardar_el_archivo_25;
            this.btnGuardar.Location = new System.Drawing.Point(458, 565);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(255, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "(AAAA-MM-DD)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModificarCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.lblMora);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.txtValorPagado);
            this.Controls.Add(this.lvlValorPagado);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.lblValorCuota);
            this.Controls.Add(this.txtFPagoSig);
            this.Controls.Add(this.lblFPagoSig);
            this.Controls.Add(this.txtFPago);
            this.Controls.Add(this.lblFPago);
            this.Controls.Add(this.txtVentaID);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCobranza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cobranza";
            this.Load += new System.EventHandler(this.frmModificarCobranza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtVentaID;
        private System.Windows.Forms.Label lblFPago;
        private System.Windows.Forms.TextBox txtFPago;
        private System.Windows.Forms.TextBox txtFPagoSig;
        private System.Windows.Forms.Label lblFPagoSig;
        private System.Windows.Forms.TextBox txtValorCuota;
        private System.Windows.Forms.Label lblValorCuota;
        private System.Windows.Forms.TextBox txtValorPagado;
        private System.Windows.Forms.Label lvlValorPagado;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
    }
}